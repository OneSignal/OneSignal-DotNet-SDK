#!/bin/bash
set -e

SCRIPT_DIR="$(cd "$(dirname "$0")" && pwd)"
dotnet clean "$SCRIPT_DIR/plugin-local-notif.csproj" -f net10.0-ios
"$SCRIPT_DIR/../run-ios.sh" "$SCRIPT_DIR/plugin-local-notif.csproj"
