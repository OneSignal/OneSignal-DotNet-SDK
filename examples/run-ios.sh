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

dotnet build "$SCRIPT_DIR/demo/demo.csproj" -f net10.0-ios -t:Build,Run -p:_DeviceName=":v2:udid=$selected"
