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
- Target frameworks: `net10.0-android;net10.0-ios`

Download the OneSignal logo as PNG (not SVG, MAUI does not natively render SVG):
  https://raw.githubusercontent.com/OneSignal/sdk-shared/refs/heads/main/assets/onesignal_logo.png
Save to `Resources/Images/onesignal_logo.png` and use it in the NavigationPage title.

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

## Dependencies (.csproj)

```xml
<ItemGroup>
  <ProjectReference Include="..\..\OneSignalSDK.DotNet\OneSignalSDK.DotNet.csproj" />
</ItemGroup>

<ItemGroup>
  <PackageReference Include="Microsoft.Maui.Controls" Version="$(MauiVersion)" />
  <PackageReference Include="CommunityToolkit.Mvvm" Version="8.*" />
</ItemGroup>
```

---

## Platform Setup

### Android
- google-services.json included as GoogleServicesJson build action
- Run `examples/setup-devapp.sh` to copy google-services.json from above the repo root
- AndroidManifest.xml must include:
```xml
<uses-permission android:name="android.permission.ACCESS_FINE_LOCATION" />
<uses-permission android:name="android.permission.ACCESS_COARSE_LOCATION" />
```

### iOS
- Entitlements.plist with push notification entitlement (`aps-environment = development`)
- Info.plist with `NSLocationWhenInUseUsageDescription` for location prompts
- Info.plist must include XSAppIconAssets so the build system passes --app-icon to actool:
```xml
<key>XSAppIconAssets</key>
<string>Assets.xcassets/appicon.appiconset</string>
```
- The NotificationServiceExtension .csproj must include TrimmerRootAssembly for System.Net.Mail
  (the OneSignal native SDK depends on it; without it the NSE crashes on launch in aot-only mode):
```xml
<TrimmerRootAssembly Include="System.Net.Mail" />
```

---

## OneSignal Repository (SDK API Mapping)

Use the static `OneSignal` class from `OneSignalSDK.DotNet`:

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
| ClearAllNotifications() | `OneSignal.Notifications.ClearAll()` |
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

In MauiProgram.cs (or App.xaml.cs), before the app runs:

```csharp
OneSignal.Debug.LogLevel = LogLevel.Verbose;
OneSignal.ConsentRequired = cachedConsentRequired;
OneSignal.ConsentGiven = cachedPrivacyConsent;
OneSignal.Initialize(appId);
```

Event handlers (C# events, not callbacks):
```csharp
OneSignal.InAppMessages.WillDisplay += OnIamWillDisplay;
OneSignal.InAppMessages.DidDisplay += OnIamDidDisplay;
OneSignal.InAppMessages.WillDismiss += OnIamWillDismiss;
OneSignal.InAppMessages.DidDismiss += OnIamDidDismiss;
OneSignal.InAppMessages.Clicked += OnIamClicked;
OneSignal.Notifications.Clicked += OnNotificationClicked;
OneSignal.Notifications.WillDisplay += OnNotificationWillDisplay;
```

After initialization, restore cached state:
```csharp
OneSignal.InAppMessages.Paused = cachedPausedStatus;
OneSignal.Location.IsShared = cachedLocationShared;
```

ViewModel observers:
```csharp
OneSignal.User.PushSubscription.Changed += OnPushSubscriptionChanged;
OneSignal.Notifications.PermissionChanged += OnPermissionChanged;
OneSignal.User.Changed += OnUserChanged;
```

---

## UI Notes

- Notification permission prompt: call `await viewModel.PromptPushAsync()` in the page's `OnAppearing()` override
- Open browser links via `Launcher.OpenAsync(uri)`
- Loading delay: `await Task.Delay(100)` after setting state
- Navigate to secondary page via `Shell.Current.GoToAsync` or `NavigationPage` push
- Triggers list state: `ObservableCollection<KeyValuePair<string, string>>`
- Track Event JSON parsing: `System.Text.Json` into `Dictionary<string, object>`; show inline red error label on invalid JSON; TRACK button does NOT close the modal when validation fails

---

## State Management (MVVM)

AppViewModel extends `ObservableObject` (CommunityToolkit.Mvvm):
- `[ObservableProperty]` fields generate properties + INotifyPropertyChanged
- `[RelayCommand]` methods for actions
- `ObservableCollection<T>` for list state (AliasesList, EmailsList, SmsNumbersList, TagsList, TriggersList)
- Receives `OneSignalRepository` and `PreferencesService` via constructor injection

Register with MAUI DI container:
```csharp
builder.Services.AddSingleton<AppViewModel>();
builder.Services.AddSingleton<OneSignalRepository>();
builder.Services.AddSingleton<PreferencesService>();
```

Persistence: `Microsoft.Maui.Storage.Preferences`

---

## Reusable Controls

XAML controls in `Controls/`:
- `SectionCard.xaml` — Frame/Border with title Label, optional info ImageButton, ContentView child (BindableProperty)
- `ToggleRow.xaml` — Label + description Label + Switch in a Grid with IsToggled two-way binding
- `LoadingOverlay.xaml` — AbsoluteLayout overlay with centered ActivityIndicator, IsVisible bound to IsLoading
- `LogView.xaml` — sticky at top, VerticalStackLayout inside ScrollView (not CollectionView), default expanded, Material icons via `mi:MauiIcon` (ExpandLess/ExpandMore for collapse toggle, Delete for clear), auto-scroll via `ScrollView.ScrollToAsync`

Button styles defined in `App.xaml` (PrimaryButton style, DestructiveButton style), not separate controls.

### Dialogs

Use CommunityToolkit.Maui popup overlays for all flows (do not use `DisplayPromptAsync`):
- Single-input popups (login, email, SMS): one Entry field
- Two-input popups (alias, tag, trigger, custom notification, track event): two Entry fields
- Outcome popup: inline RadioButton type selection (no Picker) + Entry fields
- Multi-pair input: popup overlay via `ShowPopupAsync<T>` with dynamic rows
- Multi-select remove: popup overlay via `ShowPopupAsync<T>` with CheckBox per item
- Close via `page.ClosePopupAsync(result)`
- Two-field single-add dialogs use `DialogInputHelper.ShowPairInput` — renders both fields side by side in a two-column Grid on one row

---

## Theme

Implement in `Resources/Styles/`:
- `Colors.xaml` — Color resources mapped from styles.md tokens
- `Styles.xaml` — global implicit/explicit styles for Border, Button, Entry, NavigationPage BarBackgroundColor/BarTextColor, etc.
- `AppSpacing` as static doubles (or `x:Double` resources) for spacing tokens

---

## Log View

- Use `VerticalStackLayout` inside `ScrollView` (100dp container is small, CollectionView is overkill)
- Material icons via `mi:MauiIcon`: `Delete` for trash, `ExpandLess`/`ExpandMore` for collapse toggle
- Collapse/expand toggled in code-behind: `CollapseArrow.Icon = MaterialIcons.ExpandLess/ExpandMore`
- AutomationId on each element (e.g. `AutomationId="log_entry_0_message"`)
- LogManager singleton uses `INotifyPropertyChanged` or event for reactive updates
- Console output via `Debug.WriteLine`

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

    public static UserData? FromJson(JsonElement json) { ... }
}
```

---

## Setup Script

Run from the repo root before building for Android:
```
./examples/setup-devapp.sh
```
This copies `google-services.json` from one directory above the repo root into the Android platform folder.

---

## Key Files Structure

```
examples/demo/
├── MauiProgram.cs                          # App entry, SDK init, DI setup
├── App.xaml / App.xaml.cs                  # Application lifecycle, global styles
├── AppShell.xaml / AppShell.xaml.cs        # Shell navigation structure
├── Models/
│   ├── UserData.cs                         # UserData model from API
│   ├── NotificationType.cs                 # Enum with BigPicture and IosAttachments
│   └── InAppMessageType.cs                 # Enum with icon glyphs
├── Services/
│   ├── OneSignalApiService.cs              # REST API client (HttpClient)
│   ├── PreferencesService.cs               # Preferences wrapper
│   ├── TooltipHelper.cs                    # Fetches tooltips from remote URL
│   └── LogManager.cs                       # Singleton logger with INotifyPropertyChanged
├── Repositories/
│   └── OneSignalRepository.cs              # Centralized SDK calls
├── ViewModels/
│   └── AppViewModel.cs                     # ObservableObject with all UI state
├── Pages/
│   ├── MainPage.xaml / MainPage.xaml.cs    # Main scrollable page (includes LogView)
│   └── SecondaryPage.xaml / .cs            # "Secondary Activity" page
├── Controls/
│   ├── SectionCard.xaml                    # Card with title and info icon
│   ├── ToggleRow.xaml                      # Label + Switch
│   ├── LoadingOverlay.xaml                 # Full-screen loading spinner
│   ├── LogView.xaml                        # Collapsible log viewer (Appium-ready)
│   └── Sections/
│       ├── AppSection.xaml
│       ├── PushSection.xaml
│       ├── SendPushSection.xaml
│       ├── InAppSection.xaml
│       ├── SendIamSection.xaml
│       ├── AliasesSection.xaml
│       ├── EmailsSection.xaml
│       ├── SmsSection.xaml
│       ├── TagsSection.xaml
│       ├── OutcomesSection.xaml
│       ├── TriggersSection.xaml
│       ├── TrackEventSection.xaml
│       └── LocationSection.xaml
├── Resources/
│   ├── Styles/
│   │   ├── Colors.xaml
│   │   └── Styles.xaml
│   ├── Images/
│   │   └── onesignal_logo.png
│   └── AppIcon/
│       └── appicon.png
├── Platforms/
│   ├── Android/
│   │   ├── AndroidManifest.xml
│   │   ├── MainActivity.cs
│   │   ├── MainApplication.cs
│   │   └── google-services.json            # Copied by setup-devapp.sh
│   └── iOS/
│       ├── AppDelegate.cs
│       ├── Info.plist
│       ├── Entitlements.plist
│       └── Program.cs
└── demo.csproj
```

---

## .NET MAUI Best Practices

- `[ObservableProperty]` / `[RelayCommand]` from CommunityToolkit.Mvvm to eliminate boilerplate
- DI container (`builder.Services`) for dependency injection and testability
- Compiled bindings (`x:DataType`) on all XAML pages/controls for performance and compile-time safety
- `AutomationId` on interactive elements for Appium test automation
- `ObservableCollection<T>` for list state so UI updates automatically
- Styles and ResourceDictionary for consistent theming
- No platform channels needed since the OneSignal .NET SDK handles all native bridging via bindings
