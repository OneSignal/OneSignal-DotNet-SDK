#!/bin/bash
set -e

SCRIPT_DIR="$(cd "$(dirname "$0")" && pwd)"

for app_bundle in "$SCRIPT_DIR"/bin/Debug/net10.0-ios/iossimulator-*/demo-no-location.app; do
  [ -d "$app_bundle" ] || continue

  executable="$app_bundle/demo-no-location"
  framework="$app_bundle/Frameworks/OneSignalLocation.framework"
  if [ -d "$framework" ] || { [ -f "$executable" ] && otool -L "$executable" 2>/dev/null | grep -q "OneSignalLocation.framework"; }; then
    echo "Removing stale iOS build output that references OneSignalLocation.framework..."
    rm -rf "$SCRIPT_DIR/bin" "$SCRIPT_DIR/obj"
    break
  fi
done

"$SCRIPT_DIR/../run-ios.sh" "$SCRIPT_DIR/demo-no-location.csproj"
