# OneSignal + Plugin.LocalNotification Repro

Minimal .NET MAUI app for investigating the iOS interaction reported in
[GitHub issue #132](https://github.com/OneSignal/OneSignal-DotNet-SDK/issues/132).

## What This Reproduces

Issue #132 reports an iOS crash when `OneSignalSDK.DotNet` and
`Plugin.LocalNotification` are both installed:

```text
Cannot get the method descriptor for the selector
'onesignalUserNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:'
on the type 'Plugin.LocalNotification.Platforms.UserNotificationCenterDelegate'
```

Related issue #110 reported the same failure shape for the foreground delivery
selector:

```text
onesignalUserNotificationCenter:willPresentNotification:withCompletionHandler:
```

Both failures point at the same interaction: OneSignal's native iOS SDK swizzles
`UNUserNotificationCenterDelegate` methods, while `Plugin.LocalNotification`
installs its own delegate that only implements the normal Apple selectors.

## Run

From this directory, run iOS:

```sh
cp .env.example .env
./run-ios.sh
```

Or run Android:

```sh
./run-android.sh
```

The shared scripts select from currently booted simulators or connected Android
devices.

## Repro Steps

1. Launch the app on iOS.
2. Tap `Request OneSignal Permission`.
3. Tap `Request LocalNotification Permission`.
4. Tap `Show Local Notification` while the app is foregrounded.
5. If the notification is delivered, tap it from Notification Center.
6. Watch device logs for the `onesignalUserNotificationCenter:*` selector crash.

The bundled app ID matches the main demo app's default ID when
`ONESIGNAL_APP_ID` is missing or still set to the placeholder. To test against a
different OneSignal app, set `ONESIGNAL_APP_ID` in `.env`.

## Notes

The native OneSignal iOS SDK now documents disabling swizzling via
`OneSignal_disable_swizzling` and manually forwarding notification delegate
methods. This .NET binding currently does not expose the newer manual forwarding
APIs, so this sample keeps swizzling enabled and demonstrates the reported
interaction directly.
