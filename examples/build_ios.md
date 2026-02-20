# OneSignal .NET MAUI Sample App - iOS Verification Prompts

---

## Phase iOS: iOS Permissions Verification

### Prompt iOS.1 - Verify Notification Permission

Verify that push notification permission is correctly configured for iOS.

Check Platforms/iOS/Entitlements.plist contains:

```xml
<key>aps-environment</key>
<string>development</string>
```

Check Platforms/iOS/Info.plist contains:

```xml
<key>UIBackgroundModes</key>
<array>
  <string>remote-notification</string>
</array>
```

If either is missing, add it. The aps-environment entitlement is required for push notifications to work on a physical device. UIBackgroundModes with remote-notification is required to receive pushes while the app is in the background.

### Prompt iOS.2 - Verify Location Permission

Verify that location permission is correctly configured for iOS.

Check Platforms/iOS/Info.plist contains:

```xml
<key>NSLocationWhenInUseUsageDescription</key>
<string>OneSignal uses your location to test location-based features.</string>
```

Without this key, the app will crash when requesting location permission.
