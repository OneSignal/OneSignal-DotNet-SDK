using OneSignalSDK.DotNet;
using OneSignalDemo.Models;
using OneSignalDemo.Services;

namespace OneSignalDemo.Repositories;

public class OneSignalRepository
{
    private readonly OneSignalApiService _apiService;

    public OneSignalRepository(OneSignalApiService apiService)
    {
        _apiService = apiService;
    }

    // User
    public void LoginUser(string externalUserId) => OneSignal.Login(externalUserId);
    public void LogoutUser() => OneSignal.Logout();

    // Aliases
    public void AddAlias(string label, string id) => OneSignal.User.AddAlias(label, id);
    public void AddAliases(IDictionary<string, string> aliases) => OneSignal.User.AddAliases(aliases);

    // Email
    public void AddEmail(string email) => OneSignal.User.AddEmail(email);
    public void RemoveEmail(string email) => OneSignal.User.RemoveEmail(email);

    // SMS
    public void AddSms(string smsNumber) => OneSignal.User.AddSms(smsNumber);
    public void RemoveSms(string smsNumber) => OneSignal.User.RemoveSms(smsNumber);

    // Tags
    public void AddTag(string key, string value) => OneSignal.User.AddTag(key, value);
    public void AddTags(IDictionary<string, string> tags) => OneSignal.User.AddTags(tags);
    public void RemoveTag(string key) => OneSignal.User.RemoveTag(key);
    public void RemoveTags(IEnumerable<string> keys) => OneSignal.User.RemoveTags(keys.ToArray());
    public IDictionary<string, string> GetTags() => OneSignal.User.GetTags();

    // Triggers
    public void AddTrigger(string key, string value) => OneSignal.InAppMessages.AddTrigger(key, value);
    public void AddTriggers(IDictionary<string, string> triggers) => OneSignal.InAppMessages.AddTriggers(triggers);
    public void RemoveTrigger(string key) => OneSignal.InAppMessages.RemoveTrigger(key);
    public void RemoveTriggers(IEnumerable<string> keys) => OneSignal.InAppMessages.RemoveTriggers(keys.ToArray());
    public void ClearTriggers() => OneSignal.InAppMessages.ClearTriggers();

    // Outcomes
    public void SendOutcome(string name) => OneSignal.Session.AddOutcome(name);
    public void SendUniqueOutcome(string name) => OneSignal.Session.AddUniqueOutcome(name);
    public void SendOutcomeWithValue(string name, float value) => OneSignal.Session.AddOutcomeWithValue(name, value);

    // Track Event
    public void TrackEvent(string name, IDictionary<string, object>? properties) =>
        OneSignal.User.TrackEvent(name, properties);

    // Push subscription
    public string? GetPushSubscriptionId() => OneSignal.User.PushSubscription.Id;
    public bool IsPushOptedIn() => OneSignal.User.PushSubscription.OptedIn;
    public void OptInPush() => OneSignal.User.PushSubscription.OptIn();
    public void OptOutPush() => OneSignal.User.PushSubscription.OptOut();

    // Notifications
    public bool HasPermission() => OneSignal.Notifications.Permission;
    public Task<bool> RequestPermissionAsync(bool fallbackToSettings) =>
        OneSignal.Notifications.RequestPermissionAsync(fallbackToSettings);

    // In-App Messages
    public void SetInAppMessagesPaused(bool paused) => OneSignal.InAppMessages.Paused = paused;
    public bool IsInAppMessagesPaused() => OneSignal.InAppMessages.Paused;

    // Location
    public void SetLocationShared(bool shared) => OneSignal.Location.IsShared = shared;
    public bool IsLocationShared() => OneSignal.Location.IsShared;
    public void RequestLocationPermission() => OneSignal.Location.RequestPermission();

    // Privacy consent
    public void SetConsentRequired(bool required) => OneSignal.ConsentRequired = required;
    public void SetConsentGiven(bool granted) => OneSignal.ConsentGiven = granted;

    // User IDs
    public string? GetExternalId() => OneSignal.User.ExternalId;
    public string? GetOnesignalId() => OneSignal.User.OneSignalId;

    // Notifications (API)
    public Task<bool> SendNotificationAsync(NotificationType type)
    {
        var id = GetPushSubscriptionId();
        if (string.IsNullOrEmpty(id)) return Task.FromResult(false);
        return _apiService.SendNotificationAsync(type, id);
    }

    public Task<bool> SendCustomNotificationAsync(string title, string body)
    {
        var id = GetPushSubscriptionId();
        if (string.IsNullOrEmpty(id)) return Task.FromResult(false);
        return _apiService.SendCustomNotificationAsync(title, body, id);
    }

    public Task<UserData?> FetchUserAsync(string onesignalId) =>
        _apiService.FetchUserAsync(onesignalId);
}
