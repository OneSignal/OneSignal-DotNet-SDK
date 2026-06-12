#!/bin/bash
set -e

SCRIPT_DIR="$(cd "$(dirname "$0")" && pwd)"
"$SCRIPT_DIR/../run-ios.sh" "$SCRIPT_DIR/demo-no-location.csproj"
