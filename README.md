<p align="center">
  <img src="https://media.onesignal.com/cms/Website%20Layout/logo-red.svg"/>
</p>

### OneSignal .NET SDK

[NuGet](https://www.nuget.org/packages/OneSignalSDK.DotNet)

---

⚠️ Migration Advisory for current OneSignal customers

Our new [user-centric APIs and v5.x.x SDKs](https://onesignal.com/blog/unify-your-users-across-channels-and-devices/) offer an improved user and data management experience. However, they may not be at 1:1 feature parity with our previous versions yet.

If you are migrating an existing app, we suggest using iOS and Android’s Phased Rollout capabilities to ensure that there are no unexpected issues or edge cases. Here is the documentation for each:

[iOS Phased Rollout](https://developer.apple.com/help/app-store-connect/update-your-app/release-a-version-update-in-phases/)

[Google Play Staged Rollouts](https://support.google.com/googleplay/android-developer/answer/6346149?hl=en)

If you run into any challenges or have concerns, please contact our support team at support@onesignal.com

---

[OneSignal](https://onesignal.com) is a free email, sms, push notification and in-app message service for mobile apps. This plugin makes it easy to integrate your .NET application with OneSignal.

<p align="center"><img src="https://app.onesignal.com/images/android_and_ios_notification_image.gif" width="400" alt=".NET Notification"></p>

#### Installation and Setup

.NET6+ projects: See the [Setup Documentation](https://documentation.onesignal.com/docs/net-sdk-setup) for installation and setup instructions.
Xamarin projects: See the [Setup Documentation](https://documentation.onesignal.com/docs/xamarin-sdk-setup) for installation and setup instructions.

#### API

See OneSignal's [.NET SDK API](https://documentation.onesignal.com/docs/net-client-sdk) page for a list of all available methods.

#### Change Log

See this repository's [release tags](https://github.com/OneSignal/OneSignal-DotNet-SDK/releases) for a complete change log of every released version.

#### Support

Please visit this repository's [Github issue tracker](https://github.com/OneSignal/OneSignal-DotNet-SDK/issues) for feature requests and bug reports related specificly to the SDK.

For account issues and support please contact OneSignal support from the [OneSignal.com](https://onesignal.com) dashboard.

#### Sample Project

Install [dotnet 10 or later](https://dotnet.microsoft.com/en-us/download)

Use the OneSignalDev app to test the OneSignal functionality.

For Android you will need a `google-services.json` file (from Firebase) to be in `OneSignal-DotNet-SDK/Samples/OneSignalDevApp/Platforms/Android`.

Run iOS like so: `dotnet build -t:Run -f net10.0-ios`
For Android, run: `dotnet build -t:Run -f net10.0-android`

#### Targets:

- .NET 8.0 for Android (`net8.0-android`)
- .NET 8.0 for iOS (`net8.0-ios`)
- .NET 9.0 for Android (`net9.0-android`)
- .NET 9.0 for iOS (`net9.0-ios`)
- .NET 10.0 for Android (`net10.0-android`)
- .NET 10.0 for iOS (`net10.0-ios`)

#### Supports:

- iOS 12.2 and higher.
- Android 5.0 (API Level 21) and higher.
- Multi-platform App UI (MAUI) applications.
