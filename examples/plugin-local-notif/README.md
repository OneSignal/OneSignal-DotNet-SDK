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
installs its own managed delegate that only implements the normal Apple
selectors. The .NET runtime cannot marshal the OneSignal-prefixed selector back
to that managed type.

This branch prototypes an SDK-owned delegate proxy. The proxy is installed
between OneSignal and the existing local-notification delegate, provides
registrar metadata for both selector names, and restores OneSignal's native
implementations after swizzling.

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
6. Send a OneSignal push while the app is foregrounded, then tap a push from
   Notification Center.
7. Confirm local callbacks and OneSignal `WillDisplay`/`Clicked` callbacks run
   without an `ObjCRuntime.RuntimeException`.

The bundled app ID matches the main demo app's default ID when
`ONESIGNAL_APP_ID` is missing or still set to the placeholder. To test against a
different OneSignal app, set `ONESIGNAL_APP_ID` in `.env`.

## Notes

The proxy must capture the third-party delegate before OneSignal starts native
initialization. `UseLocalNotification` installs its delegate during
`FinishedLaunching`, so this sample registers OneSignal's iOS initialization in
a later `FinishedLaunching` handler. Android still initializes immediately.

This is an experimental compatibility path, not a general delegate coordinator:

- Replacing `UNUserNotificationCenter.Current.Delegate` after
  `OneSignal.Initialize` is not protected. The prototype only reports this
  through `Debug.WriteLine`, so Release/AOT apps receive no warning.
- It relies on private native OneSignal class and selector names.
- If post-initialization IMP repair fails, initialization throws after the
  native SDK has already started; there is no safe rollback to the original
  managed delegate.
- The low-level binding helper and proxy model are internal implementation
  details and are not supported consumer APIs.
- Each bundled native iOS SDK version must be verified in both Debug and
  Release/AOT builds.

The supported fallback remains disabling swizzling with
`OneSignal_disable_swizzling` and manually forwarding notification delegate
methods. Those native manual-integration APIs are not currently exposed by this
.NET binding.
