# OneSignal + Plugin.LocalNotification

This .NET MAUI app demonstrates the supported iOS manual-integration path for
using OneSignal with `Plugin.LocalNotification`. It avoids the managed delegate
selector crash reported in
[GitHub issue #132](https://github.com/OneSignal/OneSignal-DotNet-SDK/issues/132)
without relying on private selectors or Objective-C runtime patches.

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

## iOS Manual Integration

The integration has four required parts:

1. `Info.plist` sets `OneSignal_disable_swizzling` to `true`.
2. `OneSignalNotificationDelegate` captures the delegate installed by
   `Plugin.LocalNotification` and becomes the app's notification-center
   delegate.
3. `MauiProgram` installs that coordinator after the plugin's
   `FinishedLaunching` callback, then initializes OneSignal.
4. `AppDelegate` forwards APNs registration, registration failure, and
   background remote-notification callbacks through
   `NotificationsManualIntegration`.

The coordinator routes OneSignal foreground and tap callbacks to
`NotificationsManualIntegration`. Non-OneSignal notifications are forwarded to
the plugin delegate. Each Apple completion handler has one owner:

- OneSignal owns background remote-notification completion.
- The manual integration completes OneSignal foreground and tap callbacks.
- `Plugin.LocalNotification` completes callbacks for local notifications.

The app must retain ownership of `UNUserNotificationCenter.Current.Delegate`.
If another library replaces the coordinator after startup, forwarding stops.
Install any library-owned delegate first, wrap it with the coordinator, and
initialize OneSignal last.

## Verify

On iOS, verify local foreground display and tap, OneSignal foreground
`WillDisplay` and banner presentation, background and silent delivery,
OneSignal `Clicked`, and APNs token registration. The
`Show OneSignal Notification` button sends a push to the displayed subscription
ID so these paths can be tested without opening the OneSignal dashboard. No
`onesignalUserNotificationCenter:*` or
`oneSignalDidRegisterForRemoteNotifications:*` registrar crash should occur.

Set `ONESIGNAL_APP_ID` in `.env` before running the sample. The app does not
fall back to a built-in OneSignal app ID.
