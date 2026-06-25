# OneSignal No-Location Demo

This lightweight MAUI example uses the package id `com.onesignal.example` on iOS and Android, enables APNs for iOS, and builds with the native OneSignal location module disabled.

The real `.env` file is intentionally gitignored. Copy `.env.example` to `.env` and set your OneSignal app ID:

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
