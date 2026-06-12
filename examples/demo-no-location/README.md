# OneSignal No-Location Demo

This lightweight MAUI example uses the package id `com.onesignal.example` on iOS and Android, enables APNs for iOS, and builds with the native OneSignal location module disabled.

Copy `.env.example` to `.env` and set your OneSignal app ID:

```sh
cp .env.example .env
```

Then run from this directory:

```sh
dotnet build -f net10.0-ios -t:Run
dotnet build -f net10.0-android -t:Run
```

The project disables location with:

```xml
<OneSignalDisableLocation>true</OneSignalDisableLocation>
```

The app initializes OneSignal, requests notification permission only when you tap the button, sends a test push to the current push subscription, and includes a location test button that exercises the no-location path.
