# OneSignal .NET MAUI Sample App - Build Guide

This document contains all the prompts and requirements needed to build the OneSignal .NET MAUI Sample App from scratch. Give these prompts to an AI assistant or follow them manually to recreate the app.

---

## Phase 0: Reference Screenshots (REQUIRED)

### Prompt 0.1 - Capture Reference UI

```
Before building anything, an Android emulator MUST be running with the
reference OneSignal demo app installed. These screenshots are the source
of truth for the UI you are building. Do NOT proceed to Phase 1 without them.

Check for connected emulators:
  adb devices

If no device is listed, stop and ask the user to start one.

Identify which emulator has com.onesignal.sdktest installed by checking each listed device, e.g.:
  adb -s emulator-5554 shell pm list packages 2>/dev/null | grep -i onesignal
  adb -s emulator-5556 shell pm list packages 2>/dev/null | grep -i onesignal

Use that emulator's serial (e.g. emulator-5556) for all subsequent adb commands via the -s flag.

Launch the reference app:
  adb -s <emulator-serial> shell am start -n com.onesignal.sdktest/.ui.main.MainActivity

Dismiss any in-app messages that appear on launch. Tap the X or
click-through button on each IAM until the main UI is fully visible
with no overlays.

Create an output directory:
  mkdir -p /tmp/onesignal_reference

Capture screenshots by scrolling through the full UI:
1. Take a screenshot from the top of the screen:
     adb shell screencap -p /sdcard/ref_01.png && adb pull /sdcard/ref_01.png /tmp/onesignal_reference/ref_01.png
2. Scroll down by roughly one viewport height:
     adb shell input swipe 500 1500 500 500
3. Take the next screenshot (ref_02.png, ref_03.png, etc.)
4. Repeat until you've reached the bottom of the scrollable content

You MUST read each captured screenshot image so you can see the actual UI.
These images define the visual target for every section you build later.
Pay close attention to:
  - Section header style and casing
  - Card vs non-card content grouping
  - Button placement (inside vs outside cards)
  - List item layout (stacked vs inline key-value)
  - Icon choices (delete, close, info, etc.)
  - Typography, spacing, and colors
  - Spacing: 12px gap between sections, 8px gap between cards/buttons within a section

You can also interact with the reference app to observe specific flows:

Dump the UI hierarchy to find elements by resource-id, text, or content-desc:
  adb shell uiautomator dump /sdcard/ui.xml && adb pull /sdcard/ui.xml /tmp/onesignal_reference/ui.xml

Parse the XML to find an element's bounds, then tap it:
  adb shell input tap <centerX> <centerY>

Type into a focused text field:
  adb shell input text "test"

Example flow to observe "Add Tag" behavior:
  1. Dump UI -> find the ADD button bounds -> tap it
  2. Dump UI -> find the Key and Value fields -> tap and type into them
  3. Tap the confirm button -> screenshot the result
  4. Compare the tag list state before and after

Also capture screenshots of key dialogs to match their layout:
  - Add Alias (single pair input)
  - Add Multiple Aliases/Tags (dynamic rows with add/remove)
  - Remove Selected Tags (checkbox multi-select)
  - Login User
  - Send Outcome (radio options)
  - Track Event (with JSON properties field)
  - Custom Notification (title + body)
These dialog screenshots are important for matching field layout,
button placement, spacing, and validation behavior.

Refer back to these screenshots throughout all remaining phases whenever
you need to decide on layout, spacing, section order, dialog flows, or
overall look and feel.
```

---

## Phase 1: Initial Setup

### Prompt 1.1 - Project Foundation

```
Create a new .NET MAUI project at examples/demo/ (relative to the SDK repo root).

Build the app with:
- Clean architecture: repository pattern with INotifyPropertyChanged-based state management (MVVM)
- .NET 10+ with C# nullable reference types enabled
- Material-style theming with OneSignal brand colors
- App name: "OneSignal Demo"
- Top app bar: title "Sample App" with the OneSignal logo image
- Support for both Android and iOS
- Android package name: com.onesignal.example
- iOS bundle identifier: com.onesignal.example
- All dialogs should have EMPTY input fields (for Appium testing - test framework enters values)
- Separate XAML page/view files per section to keep files focused and readable

Download the OneSignal logo PNG from:
  https://raw.githubusercontent.com/OneSignal/sdk-shared/refs/heads/main/assets/onesignal_logo.png
Save it to Resources/Images/onesignal_logo.png and use it in the NavigationPage title.

Download the padded app icon PNG from:
  https://raw.githubusercontent.com/OneSignal/sdk-shared/refs/heads/main/assets/onesignal_logo_icon_padded.png
Save it to Resources/AppIcon/appicon.png and configure it as the app icon in the .csproj with
a white background color (the source PNG is transparent; Color fills it so iOS icons render correctly):
  <MauiIcon Include="Resources\AppIcon\appicon.png" Color="#ffffff" />

Reference the OneSignal .NET SDK from the parent repo using a project reference:
  <ProjectReference Include="..\..\OneSignalSDK.DotNet\OneSignalSDK.DotNet.csproj" />
```

### Prompt 1.2 - Dependencies (.csproj)

```
Add these packages to the demo .csproj:

<ItemGroup>
  <!-- OneSignal SDK from parent repo -->
  <ProjectReference Include="..\..\OneSignalSDK.DotNet\OneSignalSDK.DotNet.csproj" />
</ItemGroup>

<ItemGroup>
  <!-- NuGet packages -->
  <PackageReference Include="Microsoft.Maui.Controls" Version="$(MauiVersion)" />
  <PackageReference Include="CommunityToolkit.Mvvm" Version="8.*" />
</ItemGroup>

Target frameworks:
  <TargetFrameworks>net10.0-android;net10.0-ios</TargetFrameworks>

Android-specific setup:
  - google-services.json included as GoogleServicesJson build action
  - Run setup-devapp.sh (at examples/) to copy google-services.json from above the repo root
  - AndroidManifest.xml must include the following permissions:
      <uses-permission android:name="android.permission.ACCESS_FINE_LOCATION" />
      <uses-permission android:name="android.permission.ACCESS_COARSE_LOCATION" />

iOS-specific setup:
  - Entitlements.plist with push notification entitlement (aps-environment = development)
  - Info.plist with NSLocationWhenInUseUsageDescription for location prompts
  - Info.plist must include XSAppIconAssets so the build system passes --app-icon to actool:
      <key>XSAppIconAssets</key>
      <string>Assets.xcassets/appicon.appiconset</string>
```

### Prompt 1.3 - OneSignal Repository

```
Create a OneSignalRepository class that centralizes all OneSignal SDK calls.
This is a plain C# class (not a ViewModel) injected into the ViewModel.

Use the static OneSignal class from OneSignalSDK.DotNet:
  using OneSignalSDK.DotNet;

User operations:
- LoginUser(string externalUserId) -> void  [OneSignal.Login(externalUserId)]
- LogoutUser() -> void  [OneSignal.Logout()]

Alias operations:
- AddAlias(string label, string id) -> void  [OneSignal.User.AddAlias(label, id)]
- AddAliases(IDictionary<string, string> aliases) -> void  [OneSignal.User.AddAliases(aliases)]

Email operations:
- AddEmail(string email) -> void  [OneSignal.User.AddEmail(email)]
- RemoveEmail(string email) -> void  [OneSignal.User.RemoveEmail(email)]

SMS operations:
- AddSms(string smsNumber) -> void  [OneSignal.User.AddSms(smsNumber)]
- RemoveSms(string smsNumber) -> void  [OneSignal.User.RemoveSms(smsNumber)]

Tag operations:
- AddTag(string key, string value) -> void  [OneSignal.User.AddTag(key, value)]
- AddTags(IDictionary<string, string> tags) -> void  [OneSignal.User.AddTags(tags)]
- RemoveTag(string key) -> void  [OneSignal.User.RemoveTag(key)]
- RemoveTags(IEnumerable<string> keys) -> void  [OneSignal.User.RemoveTags(keys.ToArray())]
- GetTags() -> IDictionary<string, string>  [OneSignal.User.GetTags()]

Trigger operations (via OneSignal.InAppMessages):
- AddTrigger(string key, string value) -> void  [OneSignal.InAppMessages.AddTrigger(key, value)]
- AddTriggers(IDictionary<string, string> triggers) -> void  [OneSignal.InAppMessages.AddTriggers(triggers)]
- RemoveTrigger(string key) -> void  [OneSignal.InAppMessages.RemoveTrigger(key)]
- RemoveTriggers(IEnumerable<string> keys) -> void  [OneSignal.InAppMessages.RemoveTriggers(keys.ToArray())]
- ClearTriggers() -> void  [OneSignal.InAppMessages.ClearTriggers()]

Outcome operations (via OneSignal.Session):
- SendOutcome(string name) -> void  [OneSignal.Session.AddOutcome(name)]
- SendUniqueOutcome(string name) -> void  [OneSignal.Session.AddUniqueOutcome(name)]
- SendOutcomeWithValue(string name, float value) -> void  [OneSignal.Session.AddOutcomeWithValue(name, value)]

Track Event:
- TrackEvent(string name, IDictionary<string, object>? properties) -> void  [OneSignal.User.TrackEvent(name, properties)]

Push subscription:
- GetPushSubscriptionId() -> string?  [OneSignal.User.PushSubscription.Id]
- IsPushOptedIn() -> bool  [OneSignal.User.PushSubscription.OptedIn]
- OptInPush() -> void  [OneSignal.User.PushSubscription.OptIn()]
- OptOutPush() -> void  [OneSignal.User.PushSubscription.OptOut()]

Notifications:
- HasPermission() -> bool  [OneSignal.Notifications.Permission]
- RequestPermissionAsync(bool fallbackToSettings) -> Task<bool>  [OneSignal.Notifications.RequestPermissionAsync(fallbackToSettings)]

In-App Messages:
- SetInAppMessagesPaused(bool paused) -> void  [OneSignal.InAppMessages.Paused = paused]
- IsInAppMessagesPaused() -> bool  [OneSignal.InAppMessages.Paused]

Location:
- SetLocationShared(bool shared) -> void  [OneSignal.Location.IsShared = shared]
- IsLocationShared() -> bool  [OneSignal.Location.IsShared]
- RequestLocationPermission() -> void  [OneSignal.Location.RequestPermission()]

Privacy consent:
- SetConsentRequired(bool required) -> void  [OneSignal.ConsentRequired = required]
- SetConsentGiven(bool granted) -> void  [OneSignal.ConsentGiven = granted]

User IDs:
- GetExternalId() -> string?  [OneSignal.User.ExternalId]
- GetOnesignalId() -> string?  [OneSignal.User.OneSignalId]

Notification sending (via REST API, delegated to OneSignalApiService):
- SendNotificationAsync(NotificationType type) -> Task<bool>
- SendCustomNotificationAsync(string title, string body) -> Task<bool>
- FetchUserAsync(string onesignalId) -> Task<UserData?>
```

### Prompt 1.4 - OneSignalApiService (REST API Client)

```
Create OneSignalApiService class for REST API calls using HttpClient:

Properties:
- _appId: string (set during initialization)

Methods:
- SetAppId(string appId)
- GetAppId() -> string
- SendNotificationAsync(NotificationType type, string subscriptionId) -> Task<bool>
- SendCustomNotificationAsync(string title, string body, string subscriptionId) -> Task<bool>
- FetchUserAsync(string onesignalId) -> Task<UserData?>

SendNotificationAsync endpoint:
- POST https://onesignal.com/api/v1/notifications
- Accept header: "application/vnd.onesignal.v1+json"
- Content-Type: "application/json"
- Uses include_subscription_ids (not include_player_ids)
- Includes big_picture for Android image notifications
- Includes ios_attachments for iOS image notifications (needed for the NSE to download and attach images)

FetchUserAsync endpoint:
- GET https://api.onesignal.com/apps/{app_id}/users/by/onesignal_id/{onesignal_id}
- NO Authorization header needed (public endpoint)
- Returns UserData with aliases, tags, emails, smsNumbers, externalId
```

### Prompt 1.5 - SDK Observers

```
In MauiProgram.cs (or App.xaml.cs), set up OneSignal initialization before the app runs:

OneSignal.Debug.LogLevel = LogLevel.Verbose;
OneSignal.ConsentRequired = cachedConsentRequired;
OneSignal.ConsentGiven = cachedPrivacyConsent;
OneSignal.Initialize(appId);

Then register event handlers:
- OneSignal.InAppMessages.WillDisplay += OnIamWillDisplay
- OneSignal.InAppMessages.DidDisplay += OnIamDidDisplay
- OneSignal.InAppMessages.WillDismiss += OnIamWillDismiss
- OneSignal.InAppMessages.DidDismiss += OnIamDidDismiss
- OneSignal.InAppMessages.Clicked += OnIamClicked
- OneSignal.Notifications.Clicked += OnNotificationClicked
- OneSignal.Notifications.WillDisplay += OnNotificationWillDisplay

After initialization, restore cached SDK states from Preferences:
- OneSignal.InAppMessages.Paused = cachedPausedStatus
- OneSignal.Location.IsShared = cachedLocationShared

In AppViewModel, register observers:
- OneSignal.User.PushSubscription.Changed += OnPushSubscriptionChanged  (react to push subscription changes)
- OneSignal.Notifications.PermissionChanged += OnPermissionChanged  (react to permission changes)
- OneSignal.User.Changed += OnUserChanged  (call FetchUserDataFromApiAsync() when user changes)
```

---

## Phase 2: UI Sections

### Section Order (top to bottom)

1. **App Section** (App ID, Guidance Banner, Consent Toggle, Logged-in-as display, Login/Logout)
2. **Push Section** (Push ID, Enabled Toggle, Auto-prompts permission on load)
3. **Send Push Notification Section** (Simple, With Image, Custom buttons)
4. **In-App Messaging Section** (Pause toggle)
5. **Send In-App Message Section** (Top Banner, Bottom Banner, Center Modal, Full Screen - with icons)
6. **Aliases Section** (Add/Add Multiple, read-only list)
7. **Emails Section** (Collapsible list >5 items)
8. **SMS Section** (Collapsible list >5 items)
9. **Tags Section** (Add/Add Multiple/Remove Selected)
10. **Outcome Events Section** (Send Outcome dialog with type selection)
11. **Triggers Section** (Add/Add Multiple/Remove Selected/Clear All - IN MEMORY ONLY)
12. **Track Event Section** (Track Event with JSON validation)
13. **Location Section** (Location Shared toggle, Prompt Location button)
14. **Next Page Button**

### Prompt 2.1 - App Section

```
App Section layout:

1. App ID display (readonly Label showing the OneSignal App ID)

2. Sticky guidance banner below App ID:
   - Text: "Add your own App ID, then rebuild to fully test all functionality."
   - Link text: "Get your keys at onesignal.com" (tappable, opens browser via Launcher.OpenAsync)
   - Light background color to stand out

3. Consent card with up to two toggles:
   a. "Consent Required" toggle (always visible):
      - Label: "Consent Required"
      - Description: "Require consent before SDK processes data"
      - Sets OneSignal.ConsentRequired = value
   b. "Privacy Consent" toggle (only visible when Consent Required is ON):
      - Label: "Privacy Consent"
      - Description: "Consent given for data collection"
      - Sets OneSignal.ConsentGiven = value
      - Separated from the above toggle by a horizontal divider (BoxView)
   - NOT a blocking overlay - user can interact with app regardless of state

4. User status card (always visible, ABOVE the login/logout buttons):
   - Card with two rows separated by a divider
   - Row 1: "Status" label on the left, value on the right
   - Row 2: "External ID" label on the left, value on the right
   - When logged out:
     - Status shows "Anonymous"
     - External ID shows "–" (dash)
   - When logged in:
     - Status shows "Logged In" with green styling (Color #2E7D32)
     - External ID shows the actual external user ID

5. LOGIN USER button:
   - Shows "LOGIN USER" when no user is logged in
   - Shows "SWITCH USER" when a user is logged in
   - Opens a CommunityToolkit.Maui popup dialog with one "External User Id" input

6. LOGOUT USER button (only visible when a user is logged in)
```

### Prompt 2.2 - Push Section

```
Push Section:
- Section title: "Push" with info icon for tooltip
- Push Subscription ID display (readonly Label)
- Enabled toggle switch (controls OptIn/OptOut)
  - Disabled when notification permission is NOT granted
- Notification permission is automatically requested when the main page loads
- PROMPT PUSH button:
  - Only visible when notification permission is NOT granted (fallback if user denied)
  - Calls OneSignal.Notifications.RequestPermissionAsync(true) when clicked
  - Hidden once permission is granted
```

### Prompt 2.3 - Send Push Notification Section

```
Send Push Notification Section (placed right after Push Section):
- Section title: "Send Push Notification" with info icon for tooltip
- Three buttons:
  1. SIMPLE - title: "Simple Notification", body: "This is a simple push notification"
  2. WITH IMAGE - title: "Image Notification", body: "This notification includes an image"
     big_picture (Android): https://media.onesignal.com/automated_push_templates/ratings_template.png
     ios_attachments (iOS): {"image": "https://media.onesignal.com/automated_push_templates/ratings_template.png"}
  3. CUSTOM - opens one CommunityToolkit.Maui popup with Title and Body fields

Tooltip should explain each button type.
```

### Prompt 2.4 - In-App Messaging Section

```
In-App Messaging Section (placed right after Send Push):
- Section title: "In-App Messaging" with info icon for tooltip
- Pause In-App Messages toggle switch:
  - Label: "Pause In-App Messages"
  - Description: "Toggle in-app message display"
  - Sets OneSignal.InAppMessages.Paused = value
```

### Prompt 2.5 - Send In-App Message Section

```
Send In-App Message Section (placed right after In-App Messaging):
- Section title: "Send In-App Message" with info icon for tooltip
- Four FULL-WIDTH buttons (not a grid):
  1. TOP BANNER - icon: Material.VerticalAlignTop, trigger: "iam_type" = "top_banner"
  2. BOTTOM BANNER - icon: Material.VerticalAlignBottom, trigger: "iam_type" = "bottom_banner"
  3. CENTER MODAL - icon: Material.CropSquare, trigger: "iam_type" = "center_modal"
  4. FULL SCREEN - icon: Material.Fullscreen, trigger: "iam_type" = "full_screen"
- Button styling:
  - RED background color (#E9444E)
  - WHITE text
  - Type-specific icon on LEFT side only (no right side icon)
  - Full width of the card
  - Left-aligned text and icon content (not centered)
  - UPPERCASE button text
- On tap: calls OneSignal.InAppMessages.AddTrigger("iam_type", value) and shows a Toast/DisplayAlert
  - Also upserts "iam_type" in the Triggers list immediately so UI reflects the sent IAM type

Tooltip should explain each IAM type.
```

### Prompt 2.6 - Aliases Section

```
Aliases Section (placed after Send In-App Message):
- Section title: "Aliases" with info icon for tooltip
- List showing key-value pairs (read-only, no delete icons)
- Each item shows label (key) bold on top, ID (value) below in lighter style (stacked, same as Tags/Triggers)
- Filter out "external_id" and "onesignal_id" from display (these are special)
- "No Aliases Added" text when empty
- ADD button -> DialogInputHelper.ShowPairInput with Label and ID fields side by side in one row
  [calls OneSignal.User.AddAlias(label, id)]
- ADD MULTIPLE button -> MultiPairInputDialog/Popup (dynamic rows, add/remove)
  [calls OneSignal.User.AddAliases(aliases)]
- No remove/delete functionality (aliases are add-only from the UI)
```

### Prompt 2.7 - Emails Section

```
Emails Section:
- Section title: "Emails" with info icon for tooltip
- List showing email addresses
- Each item shows email with an X button (remove action)
  [calls OneSignal.User.RemoveEmail(email)]
- "No Emails Added" text when empty
- ADD EMAIL button -> CommunityToolkit.Maui popup with one "Email address" field
  [calls OneSignal.User.AddEmail(email)]
- Collapse behavior when >5 items:
  - Show first 5 items
  - Show "X more" Label (tappable)
  - Expand to show all when tapped
```

### Prompt 2.8 - SMS Section

```
SMS Section:
- Section title: "SMS" with info icon for tooltip
- List showing phone numbers
- Each item shows phone number with an X button (remove action)
  [calls OneSignal.User.RemoveSms(number)]
- "No SMS Added" text when empty
- ADD SMS button -> CommunityToolkit.Maui popup with one "Phone number" field (Telephone keyboard)
  [calls OneSignal.User.AddSms(number)]
- Collapse behavior when >5 items (same as Emails)
```

### Prompt 2.9 - Tags Section

```
Tags Section:
- Section title: "Tags" with info icon for tooltip
- List showing key-value pairs
- Each item shows key above value (stacked layout) with an X button on the right (remove action)
  [calls OneSignal.User.RemoveTag(key)]
- "No Tags Added" text when empty
- ADD button -> DialogInputHelper.ShowPairInput with Key and Value fields side by side in one row
  [calls OneSignal.User.AddTag(key, value)]
- ADD MULTIPLE button -> CommunityToolkit.Maui Popup overlay with dynamic key-value rows
  [calls OneSignal.User.AddTags(tags)]
- REMOVE SELECTED button:
  - Only visible when at least one tag exists
  - Opens CommunityToolkit.Maui Popup overlay with checkboxes
  [calls OneSignal.User.RemoveTags(selectedKeys)]
```

### Prompt 2.10 - Outcome Events Section

```
Outcome Events Section:
- Section title: "Outcome Events" with info icon for tooltip
- SEND OUTCOME button -> CommunityToolkit.Maui popup with:
  - Three inline RadioButton options (grouped, no picker):
    1. Normal Outcome (default selected) [calls OneSignal.Session.AddOutcome(name)]
    2. Unique Outcome [calls OneSignal.Session.AddUniqueOutcome(name)]
    3. Outcome with Value [calls OneSignal.Session.AddOutcomeWithValue(name, value)]
  - Outcome name Entry field (AutomationId: outcome_name_input)
  - Value Entry field (float, numeric keyboard, AutomationId: outcome_value_input) — only visible when "Outcome with Value" is selected
```

### Prompt 2.11 - Triggers Section (IN MEMORY ONLY)

```
Triggers Section:
- Section title: "Triggers" with info icon for tooltip
- List showing key-value pairs
- Each item shows key above value (stacked layout) with an X button on the right (remove action)
  [calls OneSignal.InAppMessages.RemoveTrigger(key)]
- "No Triggers Added" text when empty
- ADD button -> DialogInputHelper.ShowPairInput with Key and Value fields side by side in one row
  [calls OneSignal.InAppMessages.AddTrigger(key, value)]
- ADD MULTIPLE button -> CommunityToolkit.Maui Popup overlay with dynamic key-value rows
  [calls OneSignal.InAppMessages.AddTriggers(triggers)]
- Two action buttons (only visible when triggers exist):
  - REMOVE SELECTED -> CommunityToolkit.Maui Popup overlay with checkboxes
    [calls OneSignal.InAppMessages.RemoveTriggers(selectedKeys)]
  - CLEAR ALL -> Removes all triggers at once
    [calls OneSignal.InAppMessages.ClearTriggers()]

IMPORTANT: Triggers are stored IN MEMORY ONLY during the app session.
- TriggersList is an ObservableCollection<KeyValuePair<string, string>> in AppViewModel
- Sending an IAM button also updates the same list by setting "iam_type"
- Triggers are NOT persisted to Preferences
- Triggers are cleared when the app is killed/restarted
- This is intentional - triggers are transient test data for IAM testing
```

### Prompt 2.12 - Track Event Section

```
Track Event Section:
- Section title: "Track Event" with info icon for tooltip
- TRACK EVENT button -> opens a custom CommunityToolkit.Maui popup (not ShowForm) with:
  - "Event Name" Entry field (AutomationId: track_event_name_input)
  - "Properties (optional, JSON)" Entry field with placeholder hint {"key": "value"} (AutomationId: track_event_props_input)
  - Inline red error label "Invalid JSON format" below the props field (hidden by default)
  - TRACK confirm button (AutomationId: track_event_confirm_button):
    - Does NOT close the modal if props is non-empty and invalid JSON — shows error label instead
    - Only closes when name is non-empty AND JSON is valid (or empty)
    - If valid, parsed via System.Text.Json into Dictionary<string, object>; empty props passes null
- Calls OneSignal.User.TrackEvent(name, properties)
```

### Prompt 2.13 - Location Section

```
Location Section:
- Section title: "Location" with info icon for tooltip
- Location Shared toggle switch:
  - Label: "Location Shared"
  - Description: "Share device location with OneSignal"
  - Sets OneSignal.Location.IsShared = value
- PROMPT LOCATION button
  [calls OneSignal.Location.RequestPermission()]
```

### Prompt 2.14 - Secondary Page

```
Secondary Page (launched by "Next Page" button at bottom of main screen):
- Page title: "Secondary Activity"
- Page content: centered Label "Secondary Activity" using a large font style
- Simple screen, no additional functionality needed
- Navigate using Shell.Current.GoToAsync or NavigationPage push
```

---

## Phase 3: View User API Integration

### Prompt 3.1 - Data Loading Flow

```
Loading indicator overlay:
- Full-screen semi-transparent overlay with centered ActivityIndicator
- IsLoading flag in AppViewModel
- Show/hide via IsVisible binding based on IsLoading state
- IMPORTANT: Add 100ms delay after populating data before dismissing loading indicator
  - This ensures UI has time to render
  - Use await Task.Delay(100) after setting state

On cold start:
- Check if OneSignal.User.OneSignalId is not null/empty
- If exists: show loading -> call FetchUserDataFromApiAsync() -> populate UI -> delay 100ms -> hide loading
- If null: just show empty state (no loading indicator)

On login (LOGIN USER / SWITCH USER):
- Show loading indicator immediately
- Call OneSignal.Login(externalUserId)
- Clear old user data (aliases, emails, sms, triggers)
- Wait for User.Changed event callback
- User.Changed calls FetchUserDataFromApiAsync()
- FetchUserDataFromApiAsync() populates UI, delays 100ms, then hides loading

On logout:
- Show loading indicator
- Call OneSignal.Logout()
- Clear local lists (aliases, emails, sms, triggers)
- Hide loading indicator

On User.Changed callback (EventHandler<UserStateChangedEventArgs>):
- Call FetchUserDataFromApiAsync() to sync with server state
- Update UI with new data (aliases, tags, emails, sms)

Note: REST API key is NOT required for fetchUser endpoint.
```

### Prompt 3.2 - UserData Model

```
public class UserData
{
    public Dictionary<string, string> Aliases { get; }    // From identity object (filter out external_id, onesignal_id)
    public Dictionary<string, string> Tags { get; }       // From properties.tags object
    public List<string> Emails { get; }                   // From subscriptions where type=="Email" -> token
    public List<string> SmsNumbers { get; }               // From subscriptions where type=="SMS" -> token
    public string? ExternalId { get; }                    // From identity.external_id

    public UserData(
        Dictionary<string, string> aliases,
        Dictionary<string, string> tags,
        List<string> emails,
        List<string> smsNumbers,
        string? externalId)
    { ... }

    public static UserData? FromJson(JsonElement json) { ... }
}
```

---

## Phase 4: Info Tooltips

### Prompt 4.1 - Tooltip Content (Remote)

```
Tooltip content is fetched at runtime from the sdk-shared repo. Do NOT bundle a local copy.

URL:
https://raw.githubusercontent.com/OneSignal/sdk-shared/main/demo/tooltip_content.json

This file is maintained in the sdk-shared repo and shared across all platform demo apps.
```

### Prompt 4.2 - Tooltip Helper

```
Create TooltipHelper as a singleton:

public class TooltipHelper
{
    private static readonly TooltipHelper _instance = new();
    public static TooltipHelper Instance => _instance;

    private Dictionary<string, TooltipData> _tooltips = new();
    private bool _initialized = false;

    private const string TooltipUrl =
        "https://raw.githubusercontent.com/OneSignal/sdk-shared/main/demo/tooltip_content.json";

    public async Task InitAsync()
    {
        if (_initialized) return;
        try
        {
            // Fetch tooltip_content.json from TooltipUrl using HttpClient
            // Parse JSON into _tooltips dictionary
            // On failure (no network, etc.), leave _tooltips empty — tooltips are non-critical
        }
        catch { }
        _initialized = true;
    }

    public TooltipData? GetTooltip(string key) => _tooltips.GetValueOrDefault(key);
}

public record TooltipData(string Title, string Description, List<TooltipOption>? Options);
public record TooltipOption(string Name, string Description);
```

### Prompt 4.3 - Tooltip UI Integration

```
For each section, pass an info tap Command or event to the SectionCard control:
- SectionCard has an optional info ImageButton that fires the command when tapped
- In MainPage, wire the command to show a TooltipPopup/DisplayAlert

Example in MainPage.xaml.cs:
void OnAliasesInfoTapped(object sender, EventArgs e)
{
    var tooltip = TooltipHelper.Instance.GetTooltip("aliases");
    if (tooltip != null)
        ShowTooltipPopup(tooltip);
}

void ShowTooltipPopup(TooltipData tooltip)
{
    // Show as DisplayAlert or custom popup overlay
    DisplayAlert(tooltip.Title, tooltip.Description, "OK");
}
```

---

## Phase 5: Data Persistence & Initialization

### What IS Persisted (Preferences)

```
PreferencesService stores (using Microsoft.Maui.Storage.Preferences):
- OneSignal App ID
- Consent required status
- Privacy consent status
- External user ID (for login state restoration)
- Location shared status
- In-app messaging paused status
```

### Initialization Flow

```
On app startup, state is restored in two layers:

1. MauiProgram.cs (or App.xaml.cs) restores SDK state from Preferences BEFORE Initialize:
   - OneSignal.ConsentRequired = cachedConsentRequired
   - OneSignal.ConsentGiven = cachedPrivacyConsent
   - OneSignal.Initialize(appId)
   Then AFTER Initialize, restores remaining SDK state:
   - OneSignal.InAppMessages.Paused = cachedPausedStatus
   - OneSignal.Location.IsShared = cachedLocationShared
   This ensures consent settings are in place before the SDK initializes.

2. AppViewModel.LoadInitialStateAsync() reads UI state from the SDK (not Preferences):
   - consentRequired from cached prefs (no SDK getter)
   - privacyConsentGiven from cached prefs (no SDK getter)
   - inAppMessagesPaused from OneSignal.InAppMessages.Paused
   - locationShared from OneSignal.Location.IsShared
   - externalUserId from OneSignal.User.ExternalId
   - appId from PreferencesService (app-level config)

This two-layer approach ensures:
- The SDK is configured with the user's last preferences before anything else runs
- The ViewModel reads the SDK's actual state as the source of truth for the UI
- The UI always reflects what the SDK reports, not stale cache values
```

### What is NOT Persisted (In-Memory Only)

```
AppViewModel holds in memory:
- TriggersList: ObservableCollection<KeyValuePair<string, string>>
  - Triggers are session-only
  - Cleared on app restart
  - Used for testing IAM trigger conditions

- AliasesList:
  - Populated from REST API on each session start
  - When user adds alias locally, added to list immediately (SDK syncs async)
  - Fetched fresh via FetchUserDataFromApiAsync() on login/app start

- EmailsList, SmsNumbersList:
  - Populated from REST API on each session
  - Not cached locally
  - Fetched fresh via FetchUserDataFromApiAsync()

- TagsList:
  - Can be read from SDK via OneSignal.User.GetTags()
  - Also fetched from API for consistency
```

---

## Phase 6: Testing Values (Appium Compatibility)

```
All dialog input fields should be EMPTY by default.
The test automation framework (Appium) will enter these values:

- Login Dialog: External User Id = "test"
- Add Alias Dialog: Key = "Test", Value = "Value"
- Add Multiple Aliases Dialog: Key = "Test", Value = "Value" (first row; supports multiple rows)
- Add Email Dialog: Email = "test@onesignal.com"
- Add SMS Dialog: SMS = "123-456-5678"
- Add Tag Dialog: Key = "Test", Value = "Value"
- Add Multiple Tags Dialog: Key = "Test", Value = "Value" (first row; supports multiple rows)
- Add Trigger Dialog: Key = "trigger_key", Value = "trigger_value"
- Add Multiple Triggers Dialog: Key = "trigger_key", Value = "trigger_value" (first row; supports multiple rows)
- Outcome Dialog: Name = "test_outcome", Value = "1.5"
- Track Event Dialog: Name = "test_event", Properties = "{\"key\": \"value\"}"
- Custom Notification Dialog: Title = "Test Title", Body = "Test Body"
```

---

## Phase 7: Important Implementation Details

### Alias Management

```
Aliases are managed with a hybrid approach:

1. On app start/login: Fetched from REST API via FetchUserDataFromApiAsync()
2. When user adds alias locally:
   - Call OneSignal.User.AddAlias(label, id) - syncs to server async
   - Immediately add to local AliasesList (don't wait for API)
   - This ensures instant UI feedback while SDK syncs in background
3. On next app launch: Fresh data from API includes the synced alias
```

### Notification Permission

```
Notification permission is automatically requested when the main page loads:
- Call await viewModel.PromptPushAsync() in the page's OnAppearing() override
- This ensures the prompt appears after the user sees the app UI
- PROMPT PUSH button remains as fallback if user initially denied
- Button hidden once OneSignal.Notifications.Permission is true
- Keep Push "Enabled" Switch disabled until permission is granted
```

---

## Phase 8: .NET MAUI Architecture

### Prompt 8.1 - State Management with MVVM

```
Use CommunityToolkit.Mvvm for MVVM boilerplate.

MauiProgram.cs:
- Register AppViewModel and services with the MAUI DI container (builder.Services)
- Initialize OneSignal SDK in MauiProgram.cs before builder.Build()
- Fetch tooltips in the background (non-blocking, fire-and-forget)

AppViewModel : ObservableObject (CommunityToolkit.Mvvm):
- Holds all UI state as [ObservableProperty] fields (generates properties + INotifyPropertyChanged)
- Exposes [RelayCommand] methods that update state
- Receives OneSignalRepository via constructor injection
- Receives PreferencesService via constructor injection
- ObservableCollection<T> for list state (AliasesList, EmailsList, SmsNumbersList, TagsList, TriggersList)
```

### Prompt 8.2 - Reusable Controls

```
Create reusable MAUI controls in Controls/:

SectionCard.xaml:
- Frame/Border with title Label and optional info ImageButton
- ContentView child slot (BindableProperty)
- InfoTappedCommand for tooltips
- Consistent padding and shadow styling

ToggleRow.xaml:
- Label, optional description Label, Switch
- Grid layout with columns for label group and switch
- IsToggled two-way binding

ActionButton.xaml (or use Button styles in App.xaml):
- PrimaryButton style (filled, primary color background)
- DestructiveButton style (outlined, red accent)
- Full-width buttons

ListControls:
- PairItemView (key-value row with optional delete Button)
- SingleItemView (single value row with delete Button)
- EmptyStateView (centered "No items" Label)
- CollapsibleListView (shows 5 items, expandable with "X more" Label)

LoadingOverlay.xaml:
- Semi-transparent full-screen overlay using AbsoluteLayout
- Centered ActivityIndicator
- IsVisible bound to AppViewModel.IsLoading

Dialogs — use CommunityToolkit.Maui popup overlays for all app flows (do not use DisplayPromptAsync):
- Single-input dialogs (login, email, SMS): toolkit popup with one field
- Two-input dialogs (tags, triggers, aliases, custom notification, track event): toolkit popup with two fields
- Outcome dialog: toolkit popup with inline RadioButton type selection (no picker) + fields
- Multi-pair input (add multiple tags/triggers/aliases): toolkit popup overlay via ShowPopupAsync<T>
- Multi-select remove (remove selected tags/triggers/aliases): toolkit popup overlay via ShowPopupAsync<T>
- Close popups from button handlers using page.ClosePopupAsync(result)
- Use shared helpers (DialogInputHelper and MultiPairDialogHelper) for consistent layout and ghost action buttons
- Two-field single-add dialogs (add alias, add tag, add trigger): use DialogInputHelper.ShowPairInput — renders both fields side by side in a two-column Grid on one row

Dialog styling rules:
- Popup width: set WidthRequest to page width minus 32px (16px margin from each edge); popup is centered by the host
- Action buttons are ghost style (transparent background, no border, bold text, no shadow):
  - Primary/confirm action: red (#E54B4D)
  - Secondary/cancel action: gray (#6E6E73)
- Action buttons sit side by side in a two-column Grid at the bottom of the popup
- No divider line above the action buttons
```

### Prompt 8.3 - Reusable Multi-Pair Popup

```
Tags, Aliases, and Triggers all share a reusable MultiPairDialogHelper (static class)
for adding multiple key-value pairs at once. It uses CommunityToolkit.Maui ShowPopupAsync<T>
to show a dialog overlay (not a full-screen page). Close via page.ClosePopupAsync(result).

Behavior:
- Popup shows as an overlay dialog with a dimmed background, not full-screen
- Starts with one empty key-value row (Key and Value Entries side by side in a Grid)
- "Add Row" Button below the rows adds another empty row; the button is centered horizontally
- BoxView dividers separate each row for visual clarity
- Each row shows an X (close icon) delete Button on the right (hidden when only one row)
- "Add All" Button is disabled until ALL key and value Entry fields in every row are filled
- Validation runs on every TextChanged and after row add/remove
- On "Add All" press, all rows are collected and submitted as a batch
- Batch operations use SDK bulk APIs (AddAliases, AddTags, AddTriggers)

Used by:
- ADD MULTIPLE button (Aliases section) -> calls viewModel.AddAliasesCommand
- ADD MULTIPLE button (Tags section) -> calls viewModel.AddTagsCommand
- ADD MULTIPLE button (Triggers section) -> calls viewModel.AddTriggersCommand
```

### Prompt 8.4 - Reusable Remove Multi Popup

```
Tags and Triggers share a reusable MultiSelectRemovePopup control
for selectively removing items from the current list.

Behavior:
- Accepts the current list of items as IEnumerable<KeyValuePair<string, string>>
- Renders one CheckBox per item on the left with just the key as the label (not "key: value")
- User can check 0, 1, or more items
- "Remove (N)" Button shows count of selected items, disabled when none selected
- On confirm, checked items' keys are collected as List<string> and passed to the callback

Used by:
- REMOVE SELECTED button (Tags section) -> calls viewModel.RemoveSelectedTagsCommand
- REMOVE SELECTED button (Triggers section) -> calls viewModel.RemoveSelectedTriggersCommand
```

### Prompt 8.5 - Theme

```
Create OneSignal theme in Resources/Styles/:

Colors (in Colors.xaml):
- OneSignalRed = #E54B4D (primary)
- OneSignalGreen = #34A853 (success)
- OneSignalGreenLight = #E6F4EA (success background)
- LightBackground = #F8F9FA
- CardBackground = #FFFFFF
- DividerColor = #E8EAED
- WarningBackground = #FFF8E1

Spacing constants (use OnPlatform or static values):
- CardGap = 8   // gap between a card/banner and its action buttons within a section
- SectionGap = 12 // gap between sections (SectionCard wrapper bottom margin)

App.xaml global styles:
- Frame/Border style with rounded corners (12dp CornerRadius)
- Button style with rounded corners (8dp CornerRadius)
- Entry style with Border outline
- NavigationPage BarBackgroundColor = OneSignalRed
- NavigationPage BarTextColor = White
```

### Prompt 8.6 - Log View (Appium-Ready)

```
Add collapsible log view at top of screen for debugging and Appium testing.

Files:
- Services/LogManager.cs - Singleton logger
- Controls/LogView.xaml - Log viewer control with AutomationId labels

LogManager Features:
- Singleton with INotifyPropertyChanged or event for reactive UI updates
- API: LogManager.Instance.D(tag, message), .I(), .W(), .E() mimics debug log levels
- Also prints to console via Debug.WriteLine for development

LogView Features:
- STICKY at the top of the screen (always visible while scrolling content below)
- Full width, no horizontal margin, no rounded corners, no top margin (touches toolbar)
- Background color: #1A1B1E
- Single horizontal scroll on the entire log list (no text truncation)
- Use VerticalStackLayout inside ScrollView instead of CollectionView (100dp container is small)
- Fixed 100dp height
- Default expanded
- Material delete icon (mi:MauiIcon Icon=Delete) with TapGestureRecognizer for clearing logs
- Collapse/expand toggle uses Material icons (mi:MauiIcon): ExpandLess when expanded, ExpandMore when collapsed; icon is toggled in code-behind via CollapseArrow.Icon = MaterialIcons.ExpandLess/ExpandMore
- Auto-scroll to newest using ScrollView.ScrollToAsync

Appium AutomationId Labels:
| AutomationId              | Description                        |
|---------------------------|------------------------------------|
| log_view_container        | Main container                     |
| log_view_header           | Tappable expand/collapse           |
| log_view_count            | Shows "(N)" log count              |
| log_view_clear_button     | Clear all logs                     |
| log_view_list             | Scrollable list area               |
| log_view_empty            | "No logs yet" state                |
| log_entry_{N}             | Each log row (N=index)             |
| log_entry_{N}_timestamp   | Timestamp Label                    |
| log_entry_{N}_level       | D/I/W/E indicator Label            |
| log_entry_{N}_message     | Log message Label                  |

Set AutomationId on each element for Appium accessibility:
  <Label AutomationId="log_entry_0_message" Text="{Binding Message}" />
```

### Prompt 8.7 - Toast / Snackbar Messages

```
All user actions should display feedback messages (use DisplayAlert, a Toast,
or CommunityToolkit.Maui Snackbar):

- Login: "Logged in as: {userId}"
- Logout: "Logged out"
- Add alias: "Alias added: {label}"
- Add multiple aliases: "{count} alias(es) added"
- Similar patterns for tags, triggers, emails, SMS
- Notifications: "Notification sent: {type}" or "Failed to send notification"
- In-App Messages: "Sent In-App Message: {type}"
- Outcomes: "Outcome sent: {name}"
- Events: "Event tracked: {name}"
- Location: "Location sharing enabled/disabled"
- Push: "Push enabled/disabled"

Implementation:
- AppViewModel exposes a SnackbarMessage property (string?)
- MainPage observes the property and shows the appropriate feedback UI
- All messages are also logged via LogManager.Instance.I()
```

---

## Key Files Structure

```
examples/demo/
├── MauiProgram.cs                          # App entry, SDK init, DI setup
├── App.xaml / App.xaml.cs                 # Application lifecycle, global styles
├── AppShell.xaml / AppShell.xaml.cs       # Shell navigation structure
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
│   └── OneSignalRepository.cs             # Centralized SDK calls
├── ViewModels/
│   └── AppViewModel.cs                     # ObservableObject with all UI state
├── Pages/
│   ├── MainPage.xaml / MainPage.xaml.cs   # Main scrollable page (includes LogView)
│   └── SecondaryPage.xaml / .cs           # "Secondary Activity" page
├── Controls/
│   ├── SectionCard.xaml                    # Card with title and info icon
│   ├── ToggleRow.xaml                      # Label + Switch
│   ├── LoadingOverlay.xaml                 # Full-screen loading spinner
│   ├── LogView.xaml                        # Collapsible log viewer (Appium-ready)
│   └── Sections/
│       ├── AppSection.xaml                 # App ID, consent, login/logout
│       ├── PushSection.xaml                # Push subscription controls
│       ├── SendPushSection.xaml            # Send notification buttons
│       ├── InAppSection.xaml               # IAM pause toggle
│       ├── SendIamSection.xaml             # Send IAM buttons with icons
│       ├── AliasesSection.xaml             # Alias management
│       ├── EmailsSection.xaml              # Email management
│       ├── SmsSection.xaml                 # SMS management
│       ├── TagsSection.xaml                # Tag management
│       ├── OutcomesSection.xaml            # Outcome events
│       ├── TriggersSection.xaml            # Trigger management (in-memory)
│       ├── TrackEventSection.xaml          # Event tracking with JSON
│       └── LocationSection.xaml            # Location controls
├── Resources/
│   ├── Styles/
│   │   ├── Colors.xaml                     # OneSignal brand colors
│   │   └── Styles.xaml                     # Global button, entry, frame styles
│   ├── Images/
│   │   └── onesignal_logo.png              # AppBar logo
│   └── AppIcon/
│       └── appicon.png                     # App launcher icon
├── Platforms/
│   ├── Android/
│   │   ├── AndroidManifest.xml             # Package: com.onesignal.example
│   │   ├── MainActivity.cs
│   │   ├── MainApplication.cs
│   │   └── google-services.json            # Copied by setup-devapp.sh
│   └── iOS/
│       ├── AppDelegate.cs
│       ├── Info.plist
│       ├── Entitlements.plist              # Push notification entitlement
│       └── Program.cs
└── demo.csproj                             # Project file with SDK project reference
```

Note:

- All UI is MAUI XAML (no platform-specific UI code beyond AppDelegate/MainActivity boilerplate)
- Tooltip content is fetched from remote URL (not bundled locally)
- LogView at top of screen displays SDK and app logs for debugging/Appium testing
- MAUI DI container (builder.Services) is used for dependency injection

---

## Configuration

### App ID Placeholder

```csharp
// In MauiProgram.cs or a Constants file
public const string OneSignalAppId = "77e32082-ea27-42e3-a898-c72e141824ef";
```

Note: REST API key is NOT required for the fetchUser endpoint.

### Package / Bundle Identifier

The identifiers MUST be `com.onesignal.example` to work with the existing:

- `google-services.json` (Firebase configuration — copied by `examples/setup-devapp.sh`)

If you change the identifier, you must also update these files with your own Firebase project configuration.

### Setup Script

Run from the repo root before building for Android:

```
./examples/setup-devapp.sh
```

This copies `google-services.json` from one directory above the repo root into the Android platform folder.

---

## .NET MAUI Best Practices Applied

- **[ObservableProperty] / [RelayCommand]** from CommunityToolkit.Mvvm to eliminate boilerplate
- **DI container** (builder.Services) for dependency injection and testability
- **Single responsibility** per file: one control/page per file, sections split into their own XAML files
- **Compiled bindings** (x:DataType) on all XAML pages/controls for performance and compile-time safety
- **AutomationId** on interactive elements for Appium test automation
- **async/await** over blocking calls; all network and SDK async methods awaited properly
- **ObservableCollection<T>** for list state so CollectionView/ListView updates automatically
- **Styles and ResourceDictionary** for consistent theming across all pages
- **Error handling** with try/catch on all network and SDK async calls
- **No platform channels needed** since the OneSignal .NET SDK handles all native bridging via bindings

---

## Summary

This app demonstrates all OneSignal .NET SDK features:

- User management (login/logout, aliases with batch add)
- Push notifications (subscription, sending with images, auto-permission prompt)
- Email and SMS subscriptions
- Tags for segmentation (batch add/remove support)
- Triggers for in-app message targeting (in-memory only, batch operations)
- Outcomes for conversion tracking
- Event tracking with JSON properties validation
- In-app messages (display testing with type-specific icons)
- Location sharing
- Privacy consent management

The app is designed to be:

1. **Testable** - Empty dialogs with AutomationId labels for Appium automation
2. **Comprehensive** - All SDK features demonstrated
3. **Clean** - Repository pattern with CommunityToolkit.Mvvm-based MVVM
4. **Cross-platform** - Single MAUI codebase for Android and iOS
5. **Session-based triggers** - Triggers stored in memory only, cleared on restart
6. **Responsive UI** - Loading indicator with delay to ensure UI populates before dismissing
7. **Performant** - Tooltip JSON loaded asynchronously, compiled bindings, scoped rebuilds
8. **Modern UI** - Material-style theming with reusable XAML control components
9. **Batch Operations** - Add multiple items at once, select and remove multiple items
