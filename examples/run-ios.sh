#!/bin/bash
set -e

SCRIPT_DIR="$(cd "$(dirname "$0")" && pwd)"

booted=$(xcrun simctl list devices booted -j | python3 -c "
import json, sys
data = json.load(sys.stdin)
for devices in data['devices'].values():
    for d in devices:
        if d['state'] == 'Booted' and d.get('udid'):
            print(d['udid'] + '|' + d['name'])
")

if [ -z "$booted" ]; then
  echo "No booted iOS simulators found. Start a simulator and try again."
  exit 1
fi

udids=()
labels=()
while IFS='|' read -r udid name; do
  udids+=("$udid")
  labels+=("$name ($udid)")
done <<< "$booted"

if [ ${#udids[@]} -eq 1 ]; then
  selected="${udids[0]}"
  echo "Using simulator: ${labels[0]}"
else
  echo "Select a simulator:"
  for i in "${!labels[@]}"; do
    echo "  $((i+1))) ${labels[$i]}"
  done
  printf "Choice [1]: "
  read -r choice
  choice=${choice:-1}
  idx=$((choice - 1))
  if [ "$idx" -lt 0 ] || [ "$idx" -ge ${#udids[@]} ]; then
    echo "Invalid choice."
    exit 1
  fi
  selected="${udids[$idx]}"
fi

# Build the OneSignalWidget extension if xcodegen is available
WIDGET_DIR="$SCRIPT_DIR/demo/OneSignalWidget"
if [ -f "$WIDGET_DIR/project.yml" ] && command -v xcodegen &>/dev/null; then
  echo "Building OneSignalWidget extension..."
  cd "$WIDGET_DIR"
  xcodegen generate -q 2>/dev/null || xcodegen generate
  xcodebuild build \
    -project OneSignalWidget.xcodeproj \
    -scheme OneSignalWidgetExtension \
    -configuration Debug \
    -sdk iphonesimulator \
    -arch arm64 \
    -derivedDataPath build \
    CODE_SIGN_IDENTITY="-" \
    CODE_SIGNING_REQUIRED=NO \
    CODE_SIGNING_ALLOWED=NO \
    -quiet
  echo "OneSignalWidget extension built."
fi

dotnet build "$SCRIPT_DIR/demo/demo.csproj" -f net10.0-ios -t:Build,Run -p:_DeviceName=":v2:udid=$selected"

# Copy widget extension into app bundle after MAUI build
APPEX="$WIDGET_DIR/build/Build/Products/Debug-iphonesimulator/OneSignalWidgetExtension.appex"
APP_BUNDLE="$SCRIPT_DIR/demo/bin/Debug/net10.0-ios/iossimulator-arm64/demo.app"
if [ -d "$APPEX" ] && [ -d "$APP_BUNDLE/PlugIns" ]; then
  cp -r "$APPEX" "$APP_BUNDLE/PlugIns/"
  echo "OneSignalWidget extension embedded into app."
fi
