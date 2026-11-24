# OneSignal No-Location Demo

This lightweight MAUI example uses the app ID `com.onesignal.example` on Android and iOS and the shared OneSignal demo app (`1154c350-e715-4b71-a58b-1b84b6745baa`) by default, enables APNs for iOS, and builds with the native OneSignal location module disabled.

To use your own app, copy `.env.example` to `.env` (gitignored) and set your OneSignal app ID:

```sh
cp .env.example .env
```

Then run from this directory:

```sh
./run-ios.sh
./run-android.sh
```

The project disables location with:

```xml
<OneSignalDisableLocation>true</OneSignalDisableLocation>
```

`run-ios.sh` clears stale local iOS outputs if an old app bundle still contains or links `OneSignalLocation.framework`. If you run from an IDE and still see stale simulator state, clear local outputs once and reinstall the simulator app:

```sh
rm -rf bin obj
xcrun simctl uninstall booted com.onesignal.example
```

The app initializes OneSignal, requests notification permission only when you tap the button, sends a test push to the current push subscription, and includes a location test button that exercises the no-location path.
