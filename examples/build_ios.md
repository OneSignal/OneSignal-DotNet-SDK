# OneSignal .NET MAUI Sample App - iOS Verification Prompts

---

## Phase iOS: iOS Permissions Verification

### Prompt iOS.1 - Verify Notification Permission

Verify that push notification permission is correctly configured for iOS.

Check Platforms/iOS/Entitlements.plist contains:

```xml
<key>aps-environment</key>
<string>development</string>
```

Check Platforms/iOS/Info.plist contains:

```xml
<key>UIBackgroundModes</key>
<array>
  <string>remote-notification</string>
</array>
```

If either is missing, add it. The aps-environment entitlement is required for push notifications to work on a physical device. UIBackgroundModes with remote-notification is required to receive pushes while the app is in the background.

### Prompt iOS.2 - Verify Location Permission

Verify that location permission is correctly configured for iOS.

Check Platforms/iOS/Info.plist contains:

```xml
<key>NSLocationWhenInUseUsageDescription</key>
<string>OneSignal uses your location to test location-based features.</string>
```

Without this key, the app will crash when requesting location permission.

### Prompt iOS.2b - Verify App Icon Asset Catalog

Verify that the app icon asset catalog reference is in Info.plist. Without this, the MAUI build
system will not pass --app-icon to actool, resulting in no Assets.car and a missing app icon on iOS.

Check Platforms/iOS/Info.plist contains:

```xml
<key>XSAppIconAssets</key>
<string>Assets.xcassets/appicon.appiconset</string>
```

If missing, add it.

---

## Phase iOS: Notification Service Extension

### Prompt iOS.3 - Add Notification Service Extension

Add a Notification Service Extension to support rich push notifications (images, etc.) on iOS. This is a separate project embedded in the main app bundle.

**1. Create the extension project at `NotificationServiceExtension/NotificationServiceExtension.csproj`:**

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>net10.0-ios</TargetFramework>
    <OutputType>Library</OutputType>
    <IsAppExtension>true</IsAppExtension>
    <ApplicationId>$(DEMO_BUNDLE_ID).NSE</ApplicationId>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include="..\..\..\OneSignalSDK.DotNet\OneSignalSDK.DotNet.csproj" />
  </ItemGroup>

  <ItemGroup>
    <TrimmerRootAssembly Include="System.Net.Mail" />
  </ItemGroup>
</Project>
```

The `TrimmerRootAssembly` for `System.Net.Mail` is required because the OneSignal native SDK
depends on it transitively. Without it, the AOT compiler won't include the assembly in the
extension bundle, causing a crash at runtime (`Failed to load AOT module` in aot-only mode).

**2. Create `NotificationServiceExtension/NotificationService.cs`:**

```csharp
using System;
using Foundation;
using OneSignalSDK.DotNet.iOS;
using UserNotifications;

namespace OneSignalNotificationServiceExtension;

[Register("NotificationService")]
public class NotificationService : UNNotificationServiceExtension
{
    Action<UNNotificationContent>? ContentHandler { get; set; }
    UNMutableNotificationContent? BestAttemptContent { get; set; }
    UNNotificationRequest? ReceivedRequest { get; set; }

    protected NotificationService(IntPtr handle) : base(handle)
    {
    }

    public override void DidReceiveNotificationRequest(UNNotificationRequest request, Action<UNNotificationContent> contentHandler)
    {
        ReceivedRequest = request;
        ContentHandler = contentHandler;
        BestAttemptContent = (UNMutableNotificationContent)request.Content.MutableCopy();

        NotificationServiceExtension.DidReceiveNotificationExtensionRequest(request, BestAttemptContent, contentHandler);
    }

    public override void TimeWillExpire()
    {
        if (ReceivedRequest != null && BestAttemptContent != null)
            NotificationServiceExtension.ServiceExtensionTimeWillExpireRequest(ReceivedRequest, BestAttemptContent);

        ContentHandler?.Invoke(BestAttemptContent ?? new UNMutableNotificationContent());
    }
}
```

**3. Create `NotificationServiceExtension/Info.plist`:**

```xml
<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList-1.0.dtd">
<plist version="1.0">
<dict>
    <key>NSExtension</key>
    <dict>
        <key>NSExtensionPointIdentifier</key>
        <string>com.apple.usernotifications.service</string>
        <key>NSExtensionPrincipalClass</key>
        <string>NotificationService</string>
    </dict>
</dict>
</plist>
```

**4. Reference the extension from `demo.csproj`:**

```xml
<ItemGroup>
  <Compile Remove="NotificationServiceExtension\**" />
</ItemGroup>

<ItemGroup Condition="$(TargetFramework.Contains('-ios'))">
  <ProjectReference Include="NotificationServiceExtension\NotificationServiceExtension.csproj">
    <IsAppExtension>true</IsAppExtension>
  </ProjectReference>
</ItemGroup>
```

Two things are required here:

- `<Compile Remove>` — the extension folder lives inside the main project directory, so MSBuild's default `**/*.cs` glob would otherwise pull in the extension's source and generated `obj/` files, causing duplicate assembly attribute errors.
- `<IsAppExtension>true</IsAppExtension>` on the `ProjectReference` — this tells the iOS build targets to copy the built `.appex` into the main app's `PlugIns/` folder. Setting it only in the extension's own csproj is not sufficient; without it on the reference, the extension builds but is never embedded.

The extension bundle ID must be prefixed with the main app's bundle ID (`$(DEMO_BUNDLE_ID)`).

### Prompt iOS.4 - Shared IDs, App Groups and signing

`examples/demo/demo.props` is imported at the top of both `demo.csproj` and `NotificationServiceExtension.csproj`. It sets:

- `DEMO_BUNDLE_ID` (default `com.onesignal.example`) and `DEMO_TEAM_ID` (default `99SW8E36CT`). E2E passes `-p:DEMO_BUNDLE_ID=com.onesignal.sdkdemo -p:DEMO_TEAM_ID=DL8TF3X4K3`; MSBuild forwards global properties to the referenced NSE project.
- The `com.apple.security.application-groups` entitlement `group.$(DEMO_BUNDLE_ID).onesignal` as a `CustomEntitlements` item, so the main app and NSE share it without hardcoding it in `Entitlements.plist`.
- `IsDemoDeviceBuild` (an `ios-*` RuntimeIdentifier) and `IsDemoE2ESigning` (a device build of `com.onesignal.sdkdemo`).

`ApplicationId` is `$(DEMO_BUNDLE_ID)` in `demo.csproj` and `$(DEMO_BUNDLE_ID).NSE` in the NSE. `Platforms/iOS/Info.plist` must not set `CFBundleIdentifier`, because it would override `ApplicationId`.

Device builds set `CodesignTeamId` to `$(DEMO_TEAM_ID)`. E2E signing builds also use the in-house "iPhone Distribution" certificate and the "Appium Demo - Main" / "Appium Demo - NSE" In House profiles (OneSignal Enterprise team `DL8TF3X4K3`), so BrowserStack can install the IPA without re-signing it, and add `aps-environment = production` because In House profiles only grant production APNs. Signing is limited to device builds because a simulator build with `CodesignTeamId` set looks for a provisioning profile and fails.

The committed Live Activity widget (`Platforms/iOS/PlugIns/OneSignalWidgetExtension.appex`) is an ad hoc signed simulator build with bundle ID `com.onesignal.sdkdemo.LA`. iOS won't install an extension whose ID doesn't start with the app's, so the `MatchDemoWidgetBundleId` target in `demo.csproj` bundles a copy with `CFBundleIdentifier` set to `$(ApplicationId).LA` and re-signs it ad hoc for simulator builds when the IDs differ. E2E device builds replace the appex with an `xcodebuild` of `OneSignalWidget` signed with the "Appium Demo - Live Activity" profile.

App Groups must be registered in the Apple Developer portal under the app's identifier; this cannot be skipped even for simulator builds.

Both targets must use the same Team ID so the extension is signed consistently with the main app.
