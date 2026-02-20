using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OneSignalSDK.DotNet;
using OneSignalSDK.DotNet.Core.User;
using OneSignalSDK.DotNet.Core.User.Subscriptions;
using OneSignalDemo.Models;
using OneSignalDemo.Repositories;
using OneSignalDemo.Services;

namespace OneSignalDemo.ViewModels;

public partial class AppViewModel : ObservableObject
{
    private readonly OneSignalRepository _repository;
    private readonly PreferencesService _prefs;

    // App section
    [ObservableProperty] private string _appId = "";
    [ObservableProperty] private bool _consentRequired;
    [ObservableProperty] private bool _privacyConsentGiven;
    [ObservableProperty] private string _userStatus = "Anonymous";
    [ObservableProperty] private string _externalIdDisplay = "–";
    [ObservableProperty] private bool _isLoggedIn;
    [ObservableProperty] private string _loginButtonText = "LOGIN USER";

    // Push section
    [ObservableProperty] private string _pushSubscriptionId = "";
    [ObservableProperty] private bool _isPushEnabled;
    [ObservableProperty] private bool _hasNotificationPermission;

    // IAM section
    [ObservableProperty] private bool _inAppMessagesPaused;

    // Location section
    [ObservableProperty] private bool _locationShared;

    // Loading
    [ObservableProperty] private bool _isLoading;

    // Lists
    public ObservableCollection<KeyValuePair<string, string>> AliasesList { get; } = new();
    public ObservableCollection<string> EmailsList { get; } = new();
    public ObservableCollection<string> SmsNumbersList { get; } = new();
    public ObservableCollection<KeyValuePair<string, string>> TagsList { get; } = new();
    public ObservableCollection<KeyValuePair<string, string>> TriggersList { get; } = new();

    public AppViewModel(OneSignalRepository repository, PreferencesService prefs)
    {
        _repository = repository;
        _prefs = prefs;

        OneSignal.User.PushSubscription.Changed += OnPushSubscriptionChanged;
        OneSignal.Notifications.PermissionChanged += OnPermissionChanged;
        OneSignal.User.Changed += OnUserChanged;
    }

    public async Task LoadInitialStateAsync()
    {
        AppId = _prefs.AppId;
        ConsentRequired = _prefs.ConsentRequired;
        PrivacyConsentGiven = _prefs.PrivacyConsent;
        InAppMessagesPaused = _repository.IsInAppMessagesPaused();
        LocationShared = _repository.IsLocationShared();
        HasNotificationPermission = _repository.HasPermission();

        var extId = _repository.GetExternalId();
        UpdateUserStatus(extId);

        var pushId = _repository.GetPushSubscriptionId() ?? "";
        PushSubscriptionId = pushId;
        IsPushEnabled = _repository.IsPushOptedIn();

        var onesignalId = _repository.GetOnesignalId();
        if (!string.IsNullOrEmpty(onesignalId))
        {
            IsLoading = true;
            await FetchUserDataFromApiAsync();
        }
    }

    public async Task PromptPushAsync()
    {
        if (!HasNotificationPermission)
        {
            var granted = await _repository.RequestPermissionAsync(false);
            HasNotificationPermission = granted;
        }
    }

    private void UpdateUserStatus(string? externalId)
    {
        IsLoggedIn = !string.IsNullOrEmpty(externalId);
        UserStatus = IsLoggedIn ? "Logged In" : "Anonymous";
        ExternalIdDisplay = IsLoggedIn ? externalId! : "–";
        LoginButtonText = IsLoggedIn ? "SWITCH USER" : "LOGIN USER";
    }

    // Login
    [RelayCommand]
    public async Task LoginUserAsync(string externalUserId)
    {
        if (string.IsNullOrWhiteSpace(externalUserId)) return;
        IsLoading = true;
        ClearUserData();
        _repository.LoginUser(externalUserId);
        _prefs.ExternalUserId = externalUserId;
        LogManager.Instance.I("AppVM", $"Login: {externalUserId}");
    }

    [RelayCommand]
    public async Task LogoutUserAsync()
    {
        IsLoading = true;
        _repository.LogoutUser();
        _prefs.ExternalUserId = null;
        ClearUserData();
        UpdateUserStatus(null);
        IsLoading = false;
        LogManager.Instance.I("AppVM", "Logged out");
    }

    private void ClearUserData()
    {
        AliasesList.Clear();
        EmailsList.Clear();
        SmsNumbersList.Clear();
        TriggersList.Clear();
        TagsList.Clear();
    }

    // Aliases
    [RelayCommand]
    public void AddAlias(KeyValuePair<string, string> pair)
    {
        _repository.AddAlias(pair.Key, pair.Value);
        UpsertAlias(pair.Key, pair.Value);
        LogManager.Instance.I("AppVM", $"Alias added: {pair.Key}");
    }

    [RelayCommand]
    public void AddAliases(IDictionary<string, string> aliases)
    {
        _repository.AddAliases(aliases);
        foreach (var kv in aliases) UpsertAlias(kv.Key, kv.Value);
        LogManager.Instance.I("AppVM", $"{aliases.Count} alias(es) added");
    }

    private void UpsertAlias(string key, string value)
    {
        var existing = AliasesList.FirstOrDefault(a => a.Key == key);
        if (existing.Key != null)
        {
            var idx = AliasesList.IndexOf(existing);
            AliasesList[idx] = new KeyValuePair<string, string>(key, value);
        }
        else
        {
            AliasesList.Add(new KeyValuePair<string, string>(key, value));
        }
    }

    // Emails
    [RelayCommand]
    public void AddEmail(string email)
    {
        _repository.AddEmail(email);
        if (!EmailsList.Contains(email)) EmailsList.Add(email);
        LogManager.Instance.I("AppVM", $"Email added: {email}");
    }

    [RelayCommand]
    public void RemoveEmail(string email)
    {
        _repository.RemoveEmail(email);
        EmailsList.Remove(email);
        LogManager.Instance.I("AppVM", $"Email removed: {email}");
    }

    // SMS
    [RelayCommand]
    public void AddSms(string sms)
    {
        _repository.AddSms(sms);
        if (!SmsNumbersList.Contains(sms)) SmsNumbersList.Add(sms);
        LogManager.Instance.I("AppVM", $"SMS added: {sms}");
    }

    [RelayCommand]
    public void RemoveSms(string sms)
    {
        _repository.RemoveSms(sms);
        SmsNumbersList.Remove(sms);
        LogManager.Instance.I("AppVM", $"SMS removed: {sms}");
    }

    // Tags
    [RelayCommand]
    public void AddTag(KeyValuePair<string, string> pair)
    {
        _repository.AddTag(pair.Key, pair.Value);
        UpsertTag(pair.Key, pair.Value);
        LogManager.Instance.I("AppVM", $"Tag added: {pair.Key}");
    }

    [RelayCommand]
    public void AddTags(IDictionary<string, string> tags)
    {
        _repository.AddTags(tags);
        foreach (var kv in tags) UpsertTag(kv.Key, kv.Value);
        LogManager.Instance.I("AppVM", $"{tags.Count} tag(s) added");
    }

    [RelayCommand]
    public void RemoveTag(string key)
    {
        _repository.RemoveTag(key);
        var item = TagsList.FirstOrDefault(t => t.Key == key);
        if (item.Key != null) TagsList.Remove(item);
        LogManager.Instance.I("AppVM", $"Tag removed: {key}");
    }

    [RelayCommand]
    public void RemoveSelectedTags(IEnumerable<string> keys)
    {
        var keyList = keys.ToList();
        _repository.RemoveTags(keyList);
        foreach (var key in keyList)
        {
            var item = TagsList.FirstOrDefault(t => t.Key == key);
            if (item.Key != null) TagsList.Remove(item);
        }
        LogManager.Instance.I("AppVM", $"{keyList.Count} tag(s) removed");
    }

    private void UpsertTag(string key, string value)
    {
        var existing = TagsList.FirstOrDefault(t => t.Key == key);
        if (existing.Key != null)
        {
            var idx = TagsList.IndexOf(existing);
            TagsList[idx] = new KeyValuePair<string, string>(key, value);
        }
        else
        {
            TagsList.Add(new KeyValuePair<string, string>(key, value));
        }
    }

    // Triggers
    [RelayCommand]
    public void AddTrigger(KeyValuePair<string, string> pair)
    {
        _repository.AddTrigger(pair.Key, pair.Value);
        UpsertTrigger(pair.Key, pair.Value);
        LogManager.Instance.I("AppVM", $"Trigger added: {pair.Key}");
    }

    [RelayCommand]
    public void AddTriggers(IDictionary<string, string> triggers)
    {
        _repository.AddTriggers(triggers);
        foreach (var kv in triggers) UpsertTrigger(kv.Key, kv.Value);
        LogManager.Instance.I("AppVM", $"{triggers.Count} trigger(s) added");
    }

    [RelayCommand]
    public void RemoveTrigger(string key)
    {
        _repository.RemoveTrigger(key);
        var item = TriggersList.FirstOrDefault(t => t.Key == key);
        if (item.Key != null) TriggersList.Remove(item);
        LogManager.Instance.I("AppVM", $"Trigger removed: {key}");
    }

    [RelayCommand]
    public void RemoveSelectedTriggers(IEnumerable<string> keys)
    {
        var keyList = keys.ToList();
        _repository.RemoveTriggers(keyList);
        foreach (var key in keyList)
        {
            var item = TriggersList.FirstOrDefault(t => t.Key == key);
            if (item.Key != null) TriggersList.Remove(item);
        }
        LogManager.Instance.I("AppVM", $"{keyList.Count} trigger(s) removed");
    }

    [RelayCommand]
    public void ClearTriggers()
    {
        _repository.ClearTriggers();
        TriggersList.Clear();
        LogManager.Instance.I("AppVM", "All triggers cleared");
    }

    public void UpsertTrigger(string key, string value)
    {
        var existing = TriggersList.FirstOrDefault(t => t.Key == key);
        if (existing.Key != null)
        {
            var idx = TriggersList.IndexOf(existing);
            TriggersList[idx] = new KeyValuePair<string, string>(key, value);
        }
        else
        {
            TriggersList.Add(new KeyValuePair<string, string>(key, value));
        }
    }

    // Outcomes
    [RelayCommand]
    public void SendOutcome(string name)
    {
        _repository.SendOutcome(name);
        LogManager.Instance.I("AppVM", $"Outcome sent: {name}");
    }

    [RelayCommand]
    public void SendUniqueOutcome(string name)
    {
        _repository.SendUniqueOutcome(name);
        LogManager.Instance.I("AppVM", $"Unique outcome sent: {name}");
    }

    public void SendOutcomeWithValue(string name, float value)
    {
        _repository.SendOutcomeWithValue(name, value);
        LogManager.Instance.I("AppVM", $"Outcome with value sent: {name} = {value}");
    }

    // Track Event
    public void TrackEvent(string name, IDictionary<string, object>? properties = null)
    {
        _repository.TrackEvent(name, properties);
        LogManager.Instance.I("AppVM", $"Event tracked: {name}");
    }

    // Notifications
    [RelayCommand]
    public async Task SendNotificationAsync(NotificationType type)
    {
        var success = await _repository.SendNotificationAsync(type);
        LogManager.Instance.I("AppVM", success ? $"Notification sent: {type}" : "Failed to send notification");
    }

    public async Task SendCustomNotificationAsync(string title, string body)
    {
        var success = await _repository.SendCustomNotificationAsync(title, body);
        LogManager.Instance.I("AppVM", success ? $"Notification sent: {title}" : "Failed to send notification");
    }

    // IAM
    public void SetIamPaused(bool paused)
    {
        _repository.SetInAppMessagesPaused(paused);
        _prefs.IamPaused = paused;
        InAppMessagesPaused = paused;
        LogManager.Instance.I("AppVM", paused ? "In-App Messages paused" : "In-App Messages resumed");
    }

    public void SendInAppMessage(InAppMessageType type)
    {
        var triggerValue = type.GetTriggerValue();
        _repository.AddTrigger("iam_type", triggerValue);
        UpsertTrigger("iam_type", triggerValue);
        LogManager.Instance.I("AppVM", $"Sent In-App Message: {type.GetDisplayName()}");
    }

    // Location
    public void SetLocationSharedValue(bool shared)
    {
        _repository.SetLocationShared(shared);
        _prefs.LocationShared = shared;
        LocationShared = shared;
        LogManager.Instance.I("AppVM", shared ? "Location sharing enabled" : "Location sharing disabled");
    }

    [RelayCommand]
    public void PromptLocation()
    {
        _repository.RequestLocationPermission();
        LogManager.Instance.I("AppVM", "Location permission requested");
    }

    // Consent
    public void SetConsentRequired(bool required)
    {
        _repository.SetConsentRequired(required);
        _prefs.ConsentRequired = required;
        ConsentRequired = required;
    }

    public void SetConsentGiven(bool granted)
    {
        _repository.SetConsentGiven(granted);
        _prefs.PrivacyConsent = granted;
        PrivacyConsentGiven = granted;
    }

    // Toggle push
    public void SetPushEnabled(bool enabled)
    {
        if (enabled) _repository.OptInPush();
        else _repository.OptOutPush();
        IsPushEnabled = enabled;
        LogManager.Instance.I("AppVM", enabled ? "Push enabled" : "Push disabled");
    }

    // Observers
    private void OnPushSubscriptionChanged(object? sender, PushSubscriptionChangedEventArgs args)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            PushSubscriptionId = _repository.GetPushSubscriptionId() ?? "";
            IsPushEnabled = _repository.IsPushOptedIn();
            LogManager.Instance.D("AppVM", $"Push subscription changed: id={PushSubscriptionId}, optedIn={IsPushEnabled}");
        });
    }

    private void OnPermissionChanged(object? sender, OneSignalSDK.DotNet.Core.Notifications.NotificationPermissionChangedEventArgs args)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            HasNotificationPermission = args.Permission;
            LogManager.Instance.D("AppVM", $"Permission changed: {args.Permission}");
        });
    }

    private void OnUserChanged(object? sender, OneSignalSDK.DotNet.Core.User.UserStateChangedEventArgs args)
    {
        MainThread.BeginInvokeOnMainThread(async () =>
        {
            var extId = _repository.GetExternalId();
            UpdateUserStatus(extId);
            LogManager.Instance.D("AppVM", $"User changed: externalId={extId}");
            await FetchUserDataFromApiAsync();
        });
    }

    public async Task FetchUserDataFromApiAsync()
    {
        var onesignalId = _repository.GetOnesignalId();
        if (string.IsNullOrEmpty(onesignalId))
        {
            IsLoading = false;
            return;
        }

        var userData = await _repository.FetchUserAsync(onesignalId);
        if (userData != null)
        {
            AliasesList.Clear();
            foreach (var kv in userData.Aliases)
                AliasesList.Add(kv);

            TagsList.Clear();
            foreach (var kv in userData.Tags)
                TagsList.Add(kv);

            EmailsList.Clear();
            foreach (var email in userData.Emails)
                EmailsList.Add(email);

            SmsNumbersList.Clear();
            foreach (var sms in userData.SmsNumbers)
                SmsNumbersList.Add(sms);

            UpdateUserStatus(userData.ExternalId ?? _repository.GetExternalId());
        }

        await Task.Delay(100);
        IsLoading = false;
    }
}
