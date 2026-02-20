APP_ID="77e32082-ea27-42e3-a898-c72e141824ef"
API_KEY="os_v2_app_o7rsbaxke5bohkeyy4xbigbe55jfnj4bui2uyw5s6qshyv4sfodikxl64yvvodfcqqekwkuhr5aguperosbfjyieedhrtf5ccmqq7yq"
ACTIVITY_TYPE="DefaultLiveActivityAttributes"
EXTERNAL_ID="fadi-flutter-i16"
ACTIVITY_ID="fadi-1-7-2026"

# Start a live activity
curl --request POST \
  --url "https://api.onesignal.com/apps/${APP_ID}/activities/activity/${ACTIVITY_TYPE}" \
  --header "Authorization: Key ${API_KEY}" \
  --header 'Content-Type: application/json' \
  --data '{
  "event": "start",
  "activity_id": "test-activity-001",
  "event_attributes": {
    "title": "Order Status"
  },
  "event_updates": {
    "message": {"en": "Your order is being prepared"},
    "intValue": 25,
    "doubleValue": 1.5,
    "boolValue": true
  },
  "contents": {"en": "Live Activity Content"},
  "headings": {"en": "Live Activity"},
  "name": "Test Live Activity",
  "include_aliases": {
    "external_id": ["'"${EXTERNAL_ID}"'"]
  }
}'