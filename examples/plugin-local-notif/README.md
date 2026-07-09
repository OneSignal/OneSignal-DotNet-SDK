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
installs its own delegate that only implements the normal Apple selectors. This
sample registers a small iOS delegate shim that exports the OneSignal-prefixed
selectors and overrides the plugin's normal handlers. Remote pushes are shown as
foreground banners; local notifications keep the plugin's behavior.

## Run

From this directory, run iOS:

```sh
cp .env.example .env
# Set ONESIGNAL_APP_ID in .env before launching.
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
6. Send a OneSignal push while the app is foregrounded, then send another while
   the app is backgrounded and tap it from Notification Center.
7. Watch device logs to confirm the `onesignalUserNotificationCenter:*` selector
   paths no longer crash.

To reproduce the original issue #132 crash, remove the
`OneSignalCompatibleNotificationDelegate` registration from `MauiProgram.cs` and
delete `Platforms/iOS/OneSignalCompatibleNotificationDelegate.cs`, then repeat
the iOS push steps.

Set `ONESIGNAL_APP_ID` in `.env` before running the sample. The app does not
fall back to a built-in OneSignal app id.

## Notes

The native OneSignal iOS SDK now documents disabling swizzling via
`OneSignal_disable_swizzling` and manually forwarding notification delegate
methods. This .NET binding currently does not expose the newer manual forwarding
APIs, so this sample keeps swizzling enabled and uses the delegate shim as a
local compatibility workaround.

Because OneSignal's swizzle exchanges implementations on the shim class, the
normal delegate callbacks bypass OneSignal's own notification processing. With
this workaround, OneSignal iOS foreground lifecycle events (`WillDisplay`,
`Clicked`) may not fire; the durable fix is exposing the manual forwarding APIs
in the binding.
