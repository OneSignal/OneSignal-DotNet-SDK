# Android notification service extension

This Android app changes the notification accent color before OneSignal displays it.

Create `.env` and set your OneSignal App ID:

```shell
cp examples/android-service-ext/.env.example examples/android-service-ext/.env
```

```dotenv
ONESIGNAL_APP_ID=your-onesignal-app-id
```

Start an emulator or connect a device, then run:

```shell
./examples/android-service-ext/run-android.sh
```

Copy `NotificationServiceExtension.cs` into the Android platform directory of your .NET MAUI app, then add the `<meta-data>` entry from `Properties/AndroidManifest.xml` inside your app's `<application>` element.

The JNI class registered by `[Register]` uses slash separators; the same class in the manifest uses dot separators. Keep both names in sync.

To suppress a notification permanently, call:

```csharp
notificationEvent.PreventDefault(true);
```

To delay display while doing asynchronous work, call `PreventDefault()`, then call `notificationEvent.Notification.Display()` within approximately 30 seconds.

The sample references the SDK source project for local development. Apps consuming the released SDK should use the `OneSignalSDK.DotNet` NuGet package instead.

Build the sample with:

```shell
dotnet build examples/android-service-ext/android-service-ext.csproj
```
