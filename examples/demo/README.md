# OneSignal Demo App

A .NET MAUI sample app demonstrating the OneSignal .NET SDK on Android and iOS. It references the SDK source in this repository (`OneSignalSDK.DotNet`) as a project reference, so SDK changes are built with the demo.

The demo uses the app ID `com.onesignal.example` on Android and iOS (team `99SW8E36CT` on iOS) and the shared OneSignal demo app (`1154c350-e715-4b71-a58b-1b84b6745baa`).

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download) with MAUI workloads:
  ```sh
  dotnet workload install maui-android maui-ios
  ```
- For Android: Android SDK and an emulator or physical device
- For iOS: Xcode and an iOS simulator or physical device (macOS only; the iOS target is only added when building on macOS)

## Setup

To use your own credentials, copy `.env.example` to `.env` in `examples/demo`:

```sh
cd examples/demo
cp .env.example .env
```

```sh
ONESIGNAL_APP_ID=
ONESIGNAL_API_KEY=your_rest_api_key
ONESIGNAL_ANDROID_CHANNEL_ID=
```

- `ONESIGNAL_APP_ID`: optional. Defaults to the shared demo app.
- `ONESIGNAL_API_KEY`: REST API key, used to update and end live activities. Sending notifications from the demo doesn't need it.
- `ONESIGNAL_ANDROID_CHANNEL_ID`: optional Android notification channel for the sound test notification. Falls back to a built-in default channel.

The real `.env` file is gitignored. It's bundled into the app at build time (as the `appenv` asset), so rebuild after changing it.

The OneSignal app needs FCM credentials for the `com.onesignal.example` Android package and APNs credentials for the `com.onesignal.example` bundle ID on iOS.

`demo.props` sets `DEMO_BUNDLE_ID` (default `com.onesignal.example`) and `DEMO_TEAM_ID` (default `99SW8E36CT`). Pass `-p:DEMO_BUNDLE_ID=<id> -p:DEMO_TEAM_ID=<team>` to use your own; the NSE, Live Activity widget and app group IDs derive from `DEMO_BUNDLE_ID`. E2E builds pass `-p:DEMO_BUNDLE_ID=com.onesignal.sdkdemo -p:DEMO_TEAM_ID=DL8TF3X4K3`, which also switches device builds to the enterprise In House profiles.

### Firebase Installation IDs (optional)

E2E builds register with Firebase Installation IDs. To match locally, put a `google-services.json` for your package in `Platforms/Android/` (it is gitignored) and build with `-p:FIREBASE_INSTALLATION_ID_ENABLED=true`. The flag is off by default, and the build fails if it is on without `google-services.json`.

## Running on Android

**Emulator or connected device:**

Use the helper script to pick from connected devices interactively:

```sh
cd examples/demo
./run-android.sh
```

Or run on a specific device (find the serial with `adb devices`):

```sh
cd examples/demo
dotnet build -f net10.0-android -t:Run -p:AdbTarget="-s <device-serial>"
```

**Build APK only:**

```sh
dotnet build -f net10.0-android
```

## Running on iOS

**Simulator:**

Use the helper script to pick from booted simulators interactively:

```sh
cd examples/demo
./run-ios.sh
```

Or target a specific simulator (find the UDID with `xcrun simctl list`):

```sh
cd examples/demo
dotnet build -f net10.0-ios -t:Build,Run -p:_DeviceName=:v2:udid=<simulator-udid>
```

**Physical device** — device builds sign with team `$(DEMO_TEAM_ID)` and pick a matching development profile. To use your own team:

```sh
dotnet build -f net10.0-ios -t:Run -p:RuntimeIdentifier=ios-arm64 -p:DEMO_BUNDLE_ID=<your-bundle-id> -p:DEMO_TEAM_ID=<your-team-id>
```

The committed Live Activity widget is a simulator build, so device builds still need a device build of `OneSignalWidget` (see the E2E workflow).

## Troubleshooting

### iOS: "requires Xcode X.Y" build error

If `dotnet build -f net10.0-ios` aborts with:

```
error : This version of .NET for iOS (X.Y.NNNNN) requires Xcode X.Y. The current version of Xcode is Z.Z.
```

your active Xcode and the installed `Microsoft.iOS.Sdk.net10.0_X.Y` workload pack are from different release bands. Each pack is bound to the iOS SDK that ships inside a specific Xcode (Xcode 26.3 also ships the iOS 26.2 SDK, so the `_26.2` pack accepts either). Two ways out:

- **Workload is older than your Xcode** (e.g. workload `_26.2` + Xcode 26.5): bump the workload set so it picks up the newest iOS SDK pack.
  ```sh
  dotnet workload update
  ```
- **Xcode is older than the workload, or you keep multiple Xcodes around** (e.g. workload `_26.4` + Xcode 26.3): side-install a matching Xcode under `/Applications/Xcode_<version>.app` and point only this build at it via `DEVELOPER_DIR`. Your global `xcode-select -p` stays untouched, so simulators booted against the default Xcode keep working.
  ```sh
  # from examples/demo
  DEVELOPER_DIR="/Applications/Xcode_26.4.app/Contents/Developer" ./run-ios.sh
  ```

The repo's CI pins `runs-on: macos-26` for the same reason: it's the GitHub-hosted runner that currently ships an Xcode (26.4.1) compatible with the latest .NET 10 iOS workload. See [aka.ms/xcode-requirement](https://aka.ms/xcode-requirement) for the current compatibility matrix.

## Other demos

- [`demo-no-location`](../demo-no-location): app without the native location module
- [`android-service-ext`](../android-service-ext): Android notification service extension
- [`plugin-local-notif`](../plugin-local-notif): OneSignal alongside `Plugin.LocalNotification`

## Build Guide

See [../build.md](../build.md) for the full set of prompts and requirements used to build this app, and [../build_ios.md](../build_ios.md) for iOS verification prompts.
