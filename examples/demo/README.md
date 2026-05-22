# OneSignal Demo App

A .NET MAUI sample app demonstrating the OneSignal .NET SDK on Android and iOS.

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download) with MAUI workloads:
  ```sh
  dotnet workload install maui-android maui-ios
  ```
- For Android: Android SDK and an emulator or physical device
- For iOS: Xcode and an iOS simulator or physical device (macOS only)

## Setup

From the repo root, copy the Firebase config file needed for Android:

```sh
./examples/setup-devapp.sh
```

> This copies `google-services.json` from one directory above the repo root into `Platforms/Android/`. The file must match the `com.onesignal.example` package name.

## Running on Android

**Emulator or connected device:**

Use the helper script from the `examples/` directory to pick from connected devices interactively:

```sh
cd examples
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

Use the helper script from the `examples/` directory to pick from booted simulators interactively:

```sh
cd examples
./run-ios.sh
```

Or target a specific simulator (find the UDID with `xcrun simctl list`):

```sh
cd examples/demo
dotnet build -f net10.0-ios -t:Build,Run -p:_DeviceName=:v2:udid=<simulator-udid>
```

**Physical device** — set your team ID first:

```sh
dotnet build -f net10.0-ios -t:Run -p:RuntimeIdentifier=ios-arm64 -p:CodesignKey="Apple Development" -p:CodesignProvision="<your-provisioning-profile>"
```

## Configuration

The app ships with a placeholder OneSignal App ID (`77e32082-ea27-42e3-a898-c72e141824ef`). To test with your own account, update the constant in `MauiProgram.cs` and rebuild:

```csharp
private const string AppId = "<your-app-id>";
```

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
  DEVELOPER_DIR="/Applications/Xcode_26.4.app/Contents/Developer" ./run-ios.sh
  ```

The repo's CI pins `runs-on: macos-26` for the same reason: it's the GitHub-hosted runner that currently ships an Xcode (26.4.1) compatible with the latest .NET 10 iOS workload. See [aka.ms/xcode-requirement](https://aka.ms/xcode-requirement) for the current compatibility matrix.
