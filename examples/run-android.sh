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
while IFS= read -r serial; do
  avd=$(adb -s "$serial" emu avd name 2>/dev/null | head -1 | tr -d '\r')
  label="${avd:-$serial} ($serial)"
  labels+=("$label")
  devices+=("$serial")
done <<< "$serials"

if [ ${#devices[@]} -eq 1 ]; then
  selected="${devices[0]}"
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
fi

application_id=$(
  dotnet msbuild "$PROJECT_FILE" \
    -getProperty:ApplicationId \
    -p:TargetFramework=net10.0-android 2>/dev/null || true
)

build_log=$(mktemp)
trap 'rm -f "$build_log"' EXIT

set +e
dotnet build "$PROJECT_FILE" -f net10.0-android -t:Run -p:AdbTarget="-s $selected" "$@" 2>&1 |
  tee "$build_log"
build_status=${PIPESTATUS[0]}
set -e

if [ "$build_status" -ne 0 ] &&
  grep -q "Requested internal only, but not enough space" "$build_log"; then
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
  else
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
