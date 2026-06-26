#!/bin/bash
set -e

SCRIPT_DIR="$(cd "$(dirname "$0")" && pwd)"
"$SCRIPT_DIR/../run-android.sh" "$SCRIPT_DIR/demo-no-location.csproj" -p:OneSignalDisableLocation=true
