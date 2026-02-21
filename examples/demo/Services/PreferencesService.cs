using Microsoft.Maui.Storage;

namespace OneSignalDemo.Services;

public class PreferencesService
{
    private const string KeyAppId = "onesignal_app_id";
    private const string KeyConsentRequired = "consent_required";
    private const string KeyPrivacyConsent = "privacy_consent";
    private const string KeyExternalUserId = "external_user_id";
    private const string KeyLocationShared = "location_shared";
    private const string KeyIamPaused = "iam_paused";

    private const string DefaultAppId = "77e32082-ea27-42e3-a898-c72e141824ef";

    public string AppId
    {
        get => Preferences.Get(KeyAppId, DefaultAppId);
        set => Preferences.Set(KeyAppId, value);
    }

    public bool ConsentRequired
    {
        get => Preferences.Get(KeyConsentRequired, false);
        set => Preferences.Set(KeyConsentRequired, value);
    }

    public bool PrivacyConsent
    {
        get => Preferences.Get(KeyPrivacyConsent, false);
        set => Preferences.Set(KeyPrivacyConsent, value);
    }

    public string? ExternalUserId
    {
        get => Preferences.Get(KeyExternalUserId, (string?)null);
        set
        {
            if (value == null) Preferences.Remove(KeyExternalUserId);
            else Preferences.Set(KeyExternalUserId, value);
        }
    }

    public bool LocationShared
    {
        get => Preferences.Get(KeyLocationShared, false);
        set => Preferences.Set(KeyLocationShared, value);
    }

    public bool IamPaused
    {
        get => Preferences.Get(KeyIamPaused, false);
        set => Preferences.Set(KeyIamPaused, value);
    }
}
