#!/bin/bash
set -e

PROJECT_FILE="$1"
shift || true

if [ -z "$PROJECT_FILE" ]; then
  echo "Usage: $0 <project-file>"
  exit 1
fi

serials=$(adb devices | awk '/\tdevice$/{print $1}')

if [ -z "$serials" ]; then
  echo "No Android devices connected. Start an emulator and try again."
  exit 1
fi

labels=()
devices=()
avds=()
while IFS= read -r serial; do
  avd=$(adb -s "$serial" emu avd name 2>/dev/null | head -1 | tr -d '\r')
  label="${avd:-$serial} ($serial)"
  labels+=("$label")
  devices+=("$serial")
  avds+=("$avd")
done <<< "$serials"

if [ ${#devices[@]} -eq 1 ]; then
  selected="${devices[0]}"
  selected_avd="${avds[0]}"
  echo "Using device: ${labels[0]}"
else
  echo "Select a device:"
  for i in "${!labels[@]}"; do
    echo "  $((i+1))) ${labels[$i]}"
  done
  printf "Choice [1]: "
  read -r choice
  choice=${choice:-1}
  idx=$((choice - 1))
  if [ "$idx" -lt 0 ] || [ "$idx" -ge ${#devices[@]} ]; then
    echo "Invalid choice."
    exit 1
  fi
  selected="${devices[$idx]}"
  selected_avd="${avds[$idx]}"
fi

application_id=$(
  dotnet msbuild "$PROJECT_FILE" \
    -getProperty:ApplicationId \
    -p:TargetFramework=net10.0-android 2>/dev/null || true
)

build_log=$(mktemp)
emulator_log=$(mktemp)
trap 'rm -f "$build_log" "$emulator_log"' EXIT

find_emulator_binary() {
  if command -v emulator >/dev/null 2>&1; then
    command -v emulator
  elif [ -n "${ANDROID_SDK_ROOT:-}" ] && [ -x "$ANDROID_SDK_ROOT/emulator/emulator" ]; then
    echo "$ANDROID_SDK_ROOT/emulator/emulator"
  elif [ -n "${ANDROID_HOME:-}" ] && [ -x "$ANDROID_HOME/emulator/emulator" ]; then
    echo "$ANDROID_HOME/emulator/emulator"
  elif [ -x "$HOME/Library/Android/sdk/emulator/emulator" ]; then
    echo "$HOME/Library/Android/sdk/emulator/emulator"
  fi
}

wipe_emulator() {
  local emulator_binary="$1"
  local port="${selected#emulator-}"

  echo "Stopping $selected..."
  adb -s "$selected" emu kill >/dev/null

  for _ in {1..20}; do
    if ! adb devices | awk '/\tdevice$/{print $1}' | grep -qx "$selected"; then
      break
    fi
    sleep 0.5
  done

  echo "Wiping and restarting $selected_avd..."
  nohup "$emulator_binary" -avd "$selected_avd" -port "$port" -wipe-data \
    -no-snapshot-load >"$emulator_log" 2>&1 &
  local emulator_pid=$!

  local connected=false
  for _ in {1..120}; do
    if [ "$(adb -s "$selected" get-state 2>/dev/null || true)" = "device" ]; then
      connected=true
      break
    fi
    if ! kill -0 "$emulator_pid" 2>/dev/null; then
      echo "The emulator stopped before connecting. Emulator output:"
      cat "$emulator_log"
      return 1
    fi
    sleep 1
  done

  if [ "$connected" != true ]; then
    echo "The emulator did not reconnect. Emulator output:"
    cat "$emulator_log"
    return 1
  fi

  for _ in {1..180}; do
    if [ "$(adb -s "$selected" shell getprop sys.boot_completed 2>/dev/null | tr -d '\r')" = "1" ]; then
      return 0
    fi
    sleep 1
  done

  echo "The emulator did not finish booting. Emulator output:"
  cat "$emulator_log"
  return 1
}

set +e
dotnet build "$PROJECT_FILE" -f net10.0-android -t:Run -p:AdbTarget="-s $selected" "$@" 2>&1 |
  tee "$build_log"
build_status=${PIPESTATUS[0]}
set -e

if [ "$build_status" -ne 0 ] &&
  grep -Eq "Requested internal only, but not enough space|InsufficientSpaceException|There is not enough storage space" \
    "$build_log"; then
  echo
  echo "The selected Android device does not have enough internal storage to install the app."
  echo "Device storage:"
  adb -s "$selected" shell df -h /data || true

  if [ -t 0 ] &&
    [ -n "$application_id" ] &&
    adb -s "$selected" shell pm path "$application_id" >/dev/null 2>&1; then
    echo
    printf "Uninstall %s from the device and retry? This deletes its app data. [y/N] " \
      "$application_id"
    read -r retry || retry=""

    if [[ "$retry" =~ ^[Yy]$ ]]; then
      adb -s "$selected" uninstall "$application_id"
      echo "Retrying..."

      set +e
      dotnet build "$PROJECT_FILE" -f net10.0-android -t:Run \
        -p:AdbTarget="-s $selected" "$@"
      build_status=$?
      set -e
    fi
  fi

  if [ "$build_status" -ne 0 ] && [ -t 0 ] && [ -n "$selected_avd" ]; then
    emulator_binary=$(find_emulator_binary)
    if [ -n "$emulator_binary" ]; then
      echo
      printf "Factory-reset %s and retry? This deletes all emulator data. [y/N] " \
        "$selected_avd"
      read -r wipe || wipe=""

      if [[ "$wipe" =~ ^[Yy]$ ]] && wipe_emulator "$emulator_binary"; then
        echo "Retrying..."

        set +e
        dotnet build "$PROJECT_FILE" -f net10.0-android -t:Run \
          -p:AdbTarget="-s $selected" "$@"
        build_status=$?
        set -e
      fi
    fi
  fi

  if [ "$build_status" -ne 0 ]; then
    echo "Free space or wipe the emulator's data, then run this script again."
  fi
fi

if [ "$build_status" -eq 0 ] && [ -n "$application_id" ]; then
  app_pid=""
  for _ in {1..20}; do
    app_pid=$(adb -s "$selected" shell pidof "$application_id" || true)
    [ -n "$app_pid" ] && break
    sleep 0.25
  done

  if [ -n "$app_pid" ]; then
    echo
    echo "Streaming $application_id logs. Press Ctrl-C to stop."
    adb -s "$selected" logcat --pid="$app_pid" -v time
  else
    echo "The app launched, but its process is no longer running."
  fi
fi

exit "$build_status"
