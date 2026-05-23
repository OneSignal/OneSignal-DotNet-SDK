# OneSignal .NET MAUI Sample App - Build Guide

This document extends the shared build guide with .NET MAUI-specific details.

**Read the shared guide first:**
https://raw.githubusercontent.com/OneSignal/sdk-shared/refs/heads/main/demo/build.md

Replace `{{PLATFORM}}` with `DotNet` everywhere in that guide. Everything below either overrides or supplements sections from the shared guide.

---

## Project Foundation

- Framework: .NET MAUI with C# nullable reference types enabled
- Architecture: MVVM via CommunityToolkit.Mvvm (INotifyPropertyChanged / ObservableObject)
- UI: XAML pages and controls (not code-only)
- Target frameworks: Android always; iOS appended only when `MSBuild::IsOSPlatform('OSX')` is true (so non-macOS CI builds Android only). See `demo.csproj`.
- Logo asset: `Resources/Images/onesignal_logo.svg`. MAUI renders it via `Source = "onesignal_logo"` in `App.xaml.cs` and bound `Image`s. No PNG version is committed.

App icon setup (the source PNG is transparent; Color fills it so iOS icons render correctly):
```xml
<MauiIcon Include="Resources\AppIcon\appicon.png" Color="#ffffff" ForegroundScale="0.65" />
<MauiSplashScreen Include="Resources\AppIcon\appicon.png" Color="#ffffff" BaseSize="128,128" />
```

SDK reference via project reference:
```xml
<ProjectReference Include="..\..\OneSignalSDK.DotNet\OneSignalSDK.DotNet.csproj" />
```

---

## Required Packages

`Microsoft.Maui.Controls` is pinned directly in `demo.csproj` to `10.0.41` (not `$(MauiVersion)` from `Directory.Build.props`, which resolves to `10.0.0`).

```xml
<ItemGroup>
  <ProjectReference Include="..\..\OneSignalSDK.DotNet\OneSignalSDK.DotNet.csproj" />
</ItemGroup>

<ItemGroup>
  <PackageReference Include="Microsoft.Maui.Controls" Version="10.0.41" />
  <PackageReference Include="CommunityToolkit.Mvvm" Version="8.*" />
  <PackageReference Include="CommunityToolkit.Maui" Version="14.0.0" />
  <PackageReference Include="AathifMahir.Maui.MauiIcons.Material" Version="5.0.0" />
</ItemGroup>
```

- `Microsoft.Maui.Controls 10.0.41` -- pinned.
- `CommunityToolkit.Mvvm 8.x` -- `[ObservableProperty]` / `[RelayCommand]`.
- `CommunityToolkit.Maui 14.0.0` -- popups + snackbar.
- `AathifMahir.Maui.MauiIcons.Material 5.0.0` -- info icons used by `SectionHeader`.

---

## Platform Setup

### Android
- `Platforms/Android/google-services.json` is pre-committed (no setup script). The csproj wires it as a `<GoogleServicesJson>` item only for Android target frameworks.
- AndroidManifest.xml must include:
```xml
<uses-permission android:name="android.permission.ACCESS_FINE_LOCATION" />
<uses-permission android:name="android.permission.ACCESS_COARSE_LOCATION" />
```

### iOS
- `Platforms/iOS/Entitlements.plist` with push notification entitlement (`aps-environment = development`).
- `Platforms/iOS/Info.plist` with `NSLocationWhenInUseUsageDescription` for location prompts.
- Info.plist must include `XSAppIconAssets` so the build system passes `--app-icon` to actool:
```xml
<key>XSAppIconAssets</key>
<string>Assets.xcassets/appicon.appiconset</string>
```

---

## Environment / Secrets

- Loader: `Services/DotEnv.cs` (custom, no third-party env package).
- Files: `.env` and `.env.example` at the demo root.
- Bundled as a `MauiAsset` with `LogicalName="appenv"` (Android's aapt2 silently drops assets whose name starts with `.`; the workaround is documented inline in `demo.csproj` and `DotEnv.cs`).
- Loaded keys: `ONESIGNAL_APP_ID`, `ONESIGNAL_API_KEY`, `ONESIGNAL_ANDROID_CHANNEL_ID`.
- `MauiProgram.cs` calls `DotEnv.Load()` after `builder.Build()` and falls back to a built-in default App ID if the env value is missing or still the placeholder string.

---

## SDK API Mapping

Call the static `OneSignal` class from `OneSignalSDK.DotNet` directly inside `AppViewModel`. There is no repository wrapper.

| Operation | SDK Call |
|---|---|
| LoginUser(externalUserId) | `OneSignal.Login(externalUserId)` |
| LogoutUser() | `OneSignal.Logout()` |
| AddAlias(label, id) | `OneSignal.User.AddAlias(label, id)` |
| AddAliases(aliases) | `OneSignal.User.AddAliases(aliases)` |
| AddEmail(email) | `OneSignal.User.AddEmail(email)` |
| RemoveEmail(email) | `OneSignal.User.RemoveEmail(email)` |
| AddSms(number) | `OneSignal.User.AddSms(number)` |
| RemoveSms(number) | `OneSignal.User.RemoveSms(number)` |
| AddTag(key, value) | `OneSignal.User.AddTag(key, value)` |
| AddTags(tags) | `OneSignal.User.AddTags(tags)` |
| RemoveTag(key) | `OneSignal.User.RemoveTag(key)` |
| RemoveTags(keys) | `OneSignal.User.RemoveTags(keys.ToArray())` |
| GetTags() | `OneSignal.User.GetTags()` |
| AddTrigger(key, value) | `OneSignal.InAppMessages.AddTrigger(key, value)` |
| AddTriggers(triggers) | `OneSignal.InAppMessages.AddTriggers(triggers)` |
| RemoveTrigger(key) | `OneSignal.InAppMessages.RemoveTrigger(key)` |
| RemoveTriggers(keys) | `OneSignal.InAppMessages.RemoveTriggers(keys.ToArray())` |
| ClearTriggers() | `OneSignal.InAppMessages.ClearTriggers()` |
| SendOutcome(name) | `OneSignal.Session.AddOutcome(name)` |
| SendUniqueOutcome(name) | `OneSignal.Session.AddUniqueOutcome(name)` |
| SendOutcomeWithValue(name, value) | `OneSignal.Session.AddOutcomeWithValue(name, value)` |
| TrackEvent(name, properties) | `OneSignal.User.TrackEvent(name, properties)` |
| GetPushSubscriptionId() | `OneSignal.User.PushSubscription.Id` |
| IsPushOptedIn() | `OneSignal.User.PushSubscription.OptedIn` |
| OptInPush() | `OneSignal.User.PushSubscription.OptIn()` |
| OptOutPush() | `OneSignal.User.PushSubscription.OptOut()` |
| ClearAllNotifications() | `OneSignal.Notifications.ClearAllNotifications()` |
| HasPermission() | `OneSignal.Notifications.Permission` |
| RequestPermissionAsync(fallback) | `OneSignal.Notifications.RequestPermissionAsync(fallback)` |
| SetInAppMessagesPaused(paused) | `OneSignal.InAppMessages.Paused = paused` |
| IsInAppMessagesPaused() | `OneSignal.InAppMessages.Paused` |
| SetLocationShared(shared) | `OneSignal.Location.IsShared = shared` |
| IsLocationShared() | `OneSignal.Location.IsShared` |
| RequestLocationPermission() | `OneSignal.Location.RequestPermission()` |
| SetConsentRequired(required) | `OneSignal.ConsentRequired = required` |
| SetConsentGiven(granted) | `OneSignal.ConsentGiven = granted` |
| GetExternalId() | `OneSignal.User.ExternalId` |
| GetOnesignalId() | `OneSignal.User.OneSignalId` |

REST API client uses `HttpClient`. JSON parsing via `System.Text.Json`.

---

## SDK Initialization & Observers

In `MauiProgram.cs`, before observers are wired up:

```csharp
using OsLogLevel = OneSignalSDK.DotNet.Core.Debug.LogLevel;

OneSignal.Debug.LogLevel = OsLogLevel.VERBOSE;
OneSignal.ConsentRequired = cachedConsentRequired;
OneSignal.ConsentGiven = cachedPrivacyConsent;
OneSignal.Initialize(appId);
```

Event handlers are wired as inline lambdas with `Debug.WriteLine`, not named handler methods (no `OnIamWillDisplay`/etc. method exists):
```csharp
OneSignal.InAppMessages.WillDisplay  += (s, e) => Debug.WriteLine("IAM WillDisplay");
OneSignal.InAppMessages.DidDisplay   += (s, e) => Debug.WriteLine("IAM DidDisplay");
OneSignal.InAppMessages.WillDismiss  += (s, e) => Debug.WriteLine("IAM WillDismiss");
OneSignal.InAppMessages.DidDismiss   += (s, e) => Debug.WriteLine("IAM DidDismiss");
OneSignal.InAppMessages.Clicked      += (s, e) => Debug.WriteLine("IAM Clicked");
OneSignal.Notifications.Clicked      += (s, e) => Debug.WriteLine("Notification clicked");
OneSignal.Notifications.WillDisplay  += (s, e) => Debug.WriteLine("Notification willDisplay");
```

After initialization, restore cached state:
```csharp
OneSignal.InAppMessages.Paused = cachedPausedStatus;
OneSignal.Location.IsShared = cachedLocationShared;
```

ViewModel observers (in `AppViewModel`):
```csharp
OneSignal.User.PushSubscription.Changed += OnPushSubscriptionChanged;
OneSignal.Notifications.PermissionChanged += OnPermissionChanged;
OneSignal.User.Changed += OnUserChanged;
```

---

## UI Notes

- Notification permission prompt: call `await viewModel.PromptPushAsync()` in the page's `OnAppearing()` override.
- Open browser links via `Launcher.OpenAsync(uri)`.
- Navigate to the secondary page via `Navigation.PushAsync(new SecondaryPage())` -- no Shell.
- Triggers list state: `ObservableCollection<KeyValuePair<string, string>>`.
- Track Event JSON parsing: `System.Text.Json` into `Dictionary<string, object>`; show inline red error label on invalid JSON; TRACK button does NOT close the modal when validation fails.

---

## State Management (MVVM)

`AppViewModel` extends `ObservableObject` (CommunityToolkit.Mvvm):
- `[ObservableProperty]` fields generate properties + INotifyPropertyChanged.
- `[RelayCommand]` methods for actions.
- `ObservableCollection<T>` for list state (`AliasesList`, `EmailsList`, `SmsNumbersList`, `TagsList`, `TriggersList`).
- Receives `PreferencesService` and `OneSignalApiService` via constructor injection.
- Calls `OneSignal.*` static APIs directly (no repository layer).

DI registrations in `MauiProgram.cs`:
```csharp
builder.Services.AddSingleton<PreferencesService>();
builder.Services.AddSingleton<OneSignalApiService>();
builder.Services.AddSingleton<AppViewModel>();
builder.Services.AddTransient<MainPage>();
builder.Services.AddSingleton<App>();
```

- Singletons: `AppViewModel`, `PreferencesService`, `OneSignalApiService`, `App`.
- Transient: `MainPage`.

Persistence: `Microsoft.Maui.Storage.Preferences`.

---

## Reusable Controls

XAML controls in `Controls/`:
- Sections use `Controls/SectionHeader.xaml` (title + info-icon `ImageButton`) wrapped by an inline `<Border Style="{StaticResource CardBorderStyle}">` for the card chrome. See `Controls/Sections/AliasesSection.xaml`, `PushSection.xaml` for examples.
- Toggle rows are inline `Grid` / `VerticalStackLayout` + `Switch` per-section (see `InAppSection.xaml`, `PushSection.xaml`, `LocationSection.xaml`). There is no shared `ToggleRow` control.
- `LoadingState.xaml` -- inline `ActivityIndicator` shown by list-bearing sections (Aliases, Emails, SMS, Tags) while `AppViewModel.IsLoading` is true and the list is empty.

Button styles are defined in `Resources/Styles/Styles.xaml` (not `App.xaml`, which only merges resource dictionaries):
- `PrimaryButtonStyle` -- filled primary actions.
- `OutlineButtonStyle` -- used for logout, clear-all, and end-live-activity buttons (i.e. destructive / secondary actions).

### SectionHeader control

- `Controls/SectionHeader.xaml(.cs)` is the actual section title + info-icon control used by every section except `AppSection`.
- Uses `xmlns:mi="http://www.aathifmahir.com/dotnet/2022/maui/icons"` and renders `{mi:Material Icon=InfoOutline, IconSize=20, IconColor=#9E9E9E}` with `Aspect="Center"`, `WidthRequest="32"`, `HeightRequest="32"`.
- Exposes an `InfoTapped` event and a `SectionKey` `BindableProperty`. `SectionKey` drives the `{key}_info_icon` `AutomationId` on the info `ImageButton` via the property-changed callback.

### Sections with non-standard chrome

- `AppSection` uses a plain `Label Text="APP"` for its title (no info icon, no `SectionHeader`), unlike every other section.

### Snackbar

- `DemoSnackbar` static helper (`Controls/DemoSnackbar.cs`) wraps `CommunityToolkit.Maui.Alerts.Snackbar`. Section code-behind calls `await DemoSnackbar.Show(message)` from button command handlers for the allowed actions (Outcomes, Custom Events, Location check).
- The helper signature is `public static Task Show(string message)` returning the underlying `Snackbar.Make(...).Show()` task. There is no `ShowAsync` method.
- Replace-on-show is handled by `CommunityToolkit.Maui.Alerts.Snackbar` automatically: invoking `Snackbar.Make(...).Show()` dismisses the currently visible snackbar before showing the new one, so the helper only forwards the call.
- Duration is the static field `public static readonly TimeSpan Duration = TimeSpan.FromSeconds(3);` and is passed into every `Snackbar.Make(...)` invocation inside `DemoSnackbar`.
- `AppViewModel` must not hold any snackbar state, expose snackbar events, or call `DemoSnackbar` directly.

### Dialogs

Use CommunityToolkit.Maui popup overlays for all flows (do not use `DisplayPromptAsync`):

- `MainPage` owns layout + tooltip popups only (`ShowTooltip(key)`). Each section's `InfoTapped` event is wired to the matching tooltip key.
- Section initialization (see `MainPage.xaml.cs`):
  - Sections that need to present popups take `Initialize(viewModel, parentPage)`: `UserSection`, `AliasesSection`, `EmailsSection`, `SmsSection`, `TagsSection`, `TriggersSection`, `CustomEventsSection`, `OutcomesSection`, `SendIamSection`, `SendPushSection`.
  - Sections that only render their own controls take `Initialize(viewModel)` only: `AppSection`, `PushSection`, `InAppSection`, `LocationSection`, `LiveActivitiesSection`.
- Sections invoke shared helpers (`DialogInputHelper.ShowSingleInput`, `DialogInputHelper.ShowPairInput`, `DialogInputHelper.ShowForm`, `MultiPairDialogHelper`, etc.) or inline custom popups from button handlers. Do not raise events back to `MainPage` for login, custom push, or CRUD dialogs.
- `AppViewModel` must not hold any dialog visibility flags or dialog input drafts.
- Single-input popups (login, email, SMS): one `Entry` field. Two-field single-add dialogs (alias, tag, trigger, track event) use `DialogInputHelper.ShowPairInput` and render both fields side by side in a two-column `Grid` on one row.
- Custom-notification popup (`SendPushSection.xaml.cs`) uses `DialogInputHelper.ShowForm` with two vertically stacked fields (`title`, `body`), not `ShowPairInput`.
- Outcome popup: inline `RadioButton` type selection (no `Picker`) + `Entry` fields.
- Multi-pair input: popup overlay via `ShowPopupAsync<T>` with dynamic rows. Multi-select remove: popup overlay via `MultiPairDialogHelper.ShowMultiSelect` with a `CheckBox` per item.
- Close via `page.ClosePopupAsync(result)`.
- Shared helpers live in `Controls/` (`DialogInputHelper`, `MultiPairDialogHelper`, `TooltipDialogHelper`, `DemoSnackbar`).

### Per-item delete UX

- Emails and SMS render an inline `✕` button on each list row for one-off removal.
- Tags and Triggers use a multi-select-remove popup driven by `MultiPairDialogHelper.ShowMultiSelect` (one `CheckBox` per item).

---

## Theme

Implement in `Resources/Styles/`:
- `Colors.xaml` -- `Color` resources mapped from styles.md tokens.
- `Styles.xaml` -- global implicit/explicit styles for `Border`, `Button`, `Entry`, `Label`, `Switch`, etc. It does NOT set `NavigationPage.BarBackgroundColor` / `BarTextColor`; those are applied in `App.xaml.cs` `CreateWindow` (along with `NavigationPage.SetTitleView` for the OneSignal logo + "DotNet" label header).

There is no `AppSpacing` class and no `x:Double` spacing resources. Spacing is hardcoded in XAML / code (e.g. `Padding="16,24"`, `Spacing="24"`).

### Switch styling

- Android: `Platforms/Android/Resources/drawable/switch_thumb_white_shadow.xml` plus a `SwitchHandler.Mapper.AppendToMapping("ThumbShadow", ...)` block in `MauiProgram.cs` for consistent track/thumb colors.
- iOS: handled by the implicit `Style TargetType="Switch"` in `Styles.xaml` (`OnColor = OsPrimary`).

---

## Logging

Use `System.Diagnostics.Debug.WriteLine` for debug logging; do not build a custom in-app log viewer.

---

## UserData Model

```csharp
public class UserData
{
    public Dictionary<string, string> Aliases { get; }
    public Dictionary<string, string> Tags { get; }
    public List<string> Emails { get; }
    public List<string> SmsNumbers { get; }
    public string? ExternalId { get; }

    public UserData(
        Dictionary<string, string> aliases,
        Dictionary<string, string> tags,
        List<string> emails,
        List<string> smsNumbers,
        string? externalId
    )
    {
        Aliases = aliases;
        Tags = tags;
        Emails = emails;
        SmsNumbers = smsNumbers;
        ExternalId = externalId;
    }

    public static UserData? FromJson(JsonElement json) { ... }
}
```

`FromJson` invokes the constructor above with the parsed dictionaries / lists.

---

## Live Activities (iOS only)

- `LiveActivitiesSection` is rendered only under `#if IOS` in `MainPage.xaml.cs` (hidden in XAML and toggled visible / initialized in the iOS conditional block).
- SDK setup runs inside `#if IOS` in `MauiProgram.cs`:
  ```csharp
  OneSignal.LiveActivities.SetupDefault(
      new LiveActivitySetupOptions { EnablePushToStart = true, EnablePushToUpdate = true }
  );
  ```
- Update / end flows hit OneSignal's REST API directly from `AppViewModel` (no SDK helper is used for those).
- `Platforms/iOS/PlugIns/OneSignalWidgetExtension.appex` is a pre-built widget extension bundled by `demo.csproj` (`Content Include="Platforms\iOS\PlugIns\OneSignalWidgetExtension.appex\**"`, iOS-only `ItemGroup`).
- `Platforms/iOS/PopupKeyboardAvoider.cs` is installed from `MauiProgram.cs` (iOS only) and works around iOS keyboard overlap on popups.

---

## Notification Service Extension

- `NotificationServiceExtension/` is a separate project referenced from `demo.csproj` inside an `ItemGroup Condition="$(TargetFramework.Contains('-ios'))"` (iOS / macOS builds only); Android targets exclude it entirely.
- Required for the OneSignal native SDK:
  ```xml
  <TrimmerRootAssembly Include="System.Net.Mail" />
  ```
  Without this entry in `NotificationServiceExtension.csproj`, the NSE crashes on launch in AOT-only mode (the native SDK depends on `System.Net.Mail`).

---

## Models

- `Models/NotificationType.cs` -- enum: `Simple`, `WithImage`, `WithSound`, `Custom`. Consumed by `SendPushSection` and `AppViewModel.SendNotificationAsync`.
- `Models/InAppMessageType.cs` -- enum: `TopBanner`, `BottomBanner`, `CenterModal`, `FullScreen`, plus string helpers (`GetTriggerValue`, `GetDisplayName`). `SendIamSection.xaml` uses text buttons; there are no icon glyphs.

---

## Key Files Structure

```
examples/demo/
├── MauiProgram.cs                          # App entry, SDK init, DI setup, env load
├── App.xaml / App.xaml.cs                  # Application lifecycle; CreateWindow builds NavigationPage + TitleView
├── .env / .env.example                     # Secrets (bundled as MauiAsset LogicalName="appenv")
├── Models/
│   ├── UserData.cs                         # UserData model + constructor + FromJson
│   ├── NotificationType.cs                 # Simple, WithImage, WithSound, Custom
│   └── InAppMessageType.cs                 # TopBanner, BottomBanner, CenterModal, FullScreen
├── Services/
│   ├── OneSignalApiService.cs              # REST API client (HttpClient)
│   ├── PreferencesService.cs               # Preferences wrapper
│   ├── TooltipHelper.cs                    # Fetches tooltips from remote URL
│   └── DotEnv.cs                           # Loads bundled "appenv" asset into a dict
├── ViewModels/
│   └── AppViewModel.cs                     # ObservableObject with all UI state
├── Pages/
│   ├── MainPage.xaml / MainPage.xaml.cs    # Main scrollable page; wires all sections
│   └── SecondaryPage.xaml / .cs            # "Secondary Screen" page
├── Controls/
│   ├── SectionHeader.xaml(.cs)             # Title Label + InfoOutline ImageButton; InfoTapped event; SectionKey BindableProperty
│   ├── LoadingState.xaml                   # Inline list loading spinner
│   ├── DemoSnackbar.cs                     # Static wrapper around CommunityToolkit.Maui Snackbar
│   ├── DialogInputHelper.cs                # ShowSingleInput / ShowPairInput / ShowForm popups
│   ├── MultiPairDialogHelper.cs            # Multi-row input + multi-select remove popups
│   ├── TooltipDialogHelper.cs              # Tooltip popup
│   └── Sections/
│       ├── AppSection.xaml(.cs)            # Uses plain "APP" Label; no SectionHeader
│       ├── PushSection.xaml(.cs)
│       ├── SendPushSection.xaml(.cs)       # Custom popup via DialogInputHelper.ShowForm
│       ├── InAppSection.xaml(.cs)
│       ├── SendIamSection.xaml(.cs)
│       ├── AliasesSection.xaml(.cs)
│       ├── EmailsSection.xaml(.cs)
│       ├── SmsSection.xaml(.cs)
│       ├── TagsSection.xaml(.cs)
│       ├── OutcomesSection.xaml(.cs)
│       ├── TriggersSection.xaml(.cs)
│       ├── CustomEventsSection.xaml(.cs)
│       ├── LocationSection.xaml(.cs)
│       └── LiveActivitiesSection.xaml(.cs) # iOS-only; activated under #if IOS in MainPage
├── Resources/
│   ├── Styles/
│   │   ├── Colors.xaml
│   │   └── Styles.xaml                     # PrimaryButtonStyle, OutlineButtonStyle, etc.
│   ├── Images/
│   │   └── onesignal_logo.svg              # MAUI renders SVG; no PNG version committed
│   └── AppIcon/
│       └── appicon.png
├── Platforms/
│   ├── Android/
│   │   ├── AndroidManifest.xml
│   │   ├── MainActivity.cs
│   │   ├── MainApplication.cs
│   │   ├── Resources/drawable/switch_thumb_white_shadow.xml
│   │   └── google-services.json            # Pre-committed
│   └── iOS/
│       ├── AppDelegate.cs
│       ├── Info.plist
│       ├── Entitlements.plist
│       ├── Program.cs
│       ├── PopupKeyboardAvoider.cs
│       └── PlugIns/OneSignalWidgetExtension.appex/  # Pre-built widget extension
├── NotificationServiceExtension/
│   ├── NotificationService.cs
│   └── NotificationServiceExtension.csproj # TrimmerRootAssembly Include="System.Net.Mail"
└── demo.csproj
```

Navigation uses a `NavigationPage` created in `App.xaml.cs` (`CreateWindow`). No Shell, so there are no `AppShell.xaml` / `AppShell.xaml.cs` files.

---

## .NET MAUI Best Practices

- `[ObservableProperty]` / `[RelayCommand]` from CommunityToolkit.Mvvm to eliminate boilerplate.
- DI container (`builder.Services`) for dependency injection and testability.
- `AutomationId` on interactive elements for Appium test automation.
- `ObservableCollection<T>` for list state so UI updates automatically.
- Styles and `ResourceDictionary` for consistent theming.
- No platform channels needed since the OneSignal .NET SDK handles all native bridging via bindings.
- Compiled bindings (`x:DataType`) -- future improvement, not yet adopted. Zero usages in the current demo.
