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
    <ApplicationId>com.onesignal.example.NotificationServiceExtensionDotNet</ApplicationId>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include="..\..\..\OneSignalSDK.DotNet\OneSignalSDK.DotNet.csproj" />
  </ItemGroup>
</Project>
```

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

The extension bundle ID must be prefixed with the main app's bundle ID (`com.onesignal.example`).

### Prompt iOS.4 - Add App Groups

App Groups are required for the NSE and main app to share data (e.g. badge counts, notification state). The group ID must be registered in the Apple Developer portal under the app's identifier.

**1. Add to the main app's `Platforms/iOS/Entitlements.plist`:**

```xml
<key>com.apple.security.application-groups</key>
<array>
    <string>group.com.onesignal.example.onesignal</string>
</array>
```

**2. Create `NotificationServiceExtension/Entitlements.plist` with the same group:**

```xml
<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList-1.0.dtd">
<plist version="1.0">
<dict>
    <key>com.apple.security.application-groups</key>
    <array>
        <string>group.com.onesignal.example.onesignal</string>
</array>
</dict>
</plist>
```

**3. Reference the entitlements file in `NotificationServiceExtension/NotificationServiceExtension.csproj`:**

```xml
<PropertyGroup>
    <CodesignEntitlements>Entitlements.plist</CodesignEntitlements>
</PropertyGroup>
```

App Groups must be registered in the Apple Developer portal — this cannot be skipped even for simulator builds.

---

## Phase iOS: Code Signing

### Prompt iOS.5 - Set Team ID

Set the Apple Developer Team ID in both the main app and the Notification Service Extension so the build system can find the correct signing identity and provisioning profile automatically.

**1. In `demo.csproj`, inside the iOS-conditional `PropertyGroup`:**

```xml
<PropertyGroup Condition="$(TargetFramework.Contains('-ios'))">
  <CodesignEntitlements>Platforms\iOS\Entitlements.plist</CodesignEntitlements>
  <CodesignTeamId>99SW8E36CT</CodesignTeamId>
</PropertyGroup>
```

**2. In `NotificationServiceExtension/NotificationServiceExtension.csproj`:**

```xml
<PropertyGroup>
  <TargetFramework>net10.0-ios</TargetFramework>
  <OutputType>Library</OutputType>
  <IsAppExtension>true</IsAppExtension>
  <ApplicationId>com.onesignal.example.NotificationServiceExtensionDotNet</ApplicationId>
  <CodesignEntitlements>Entitlements.plist</CodesignEntitlements>
  <CodesignTeamId>99SW8E36CT</CodesignTeamId>
</PropertyGroup>
```

Both targets must use the same Team ID so the extension is signed consistently with the main app.
