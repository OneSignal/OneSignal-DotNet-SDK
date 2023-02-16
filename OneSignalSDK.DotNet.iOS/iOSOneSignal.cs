using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.Debug;
using OneSignalSDK.DotNet.Core.InAppMessages;
using OneSignalSDK.DotNet.Core.Location;
using OneSignalSDK.DotNet.Core.Notifications;
using OneSignalSDK.DotNet.Core.Session;
using OneSignalSDK.DotNet.Core.User;
using OneSignalSDK.DotNet.Core.Internal.Utilities;

using OneSignalNative = Com.OneSignal.iOS.OneSignal;

namespace OneSignalSDK.DotNet.iOS;

public class iOSOneSignal : IOneSignal
{
    public IUserManager User { get; } = new iOSUserManager();

    public ISessionManager Session { get; } = new iOSSessionManager();

    public INotificationsManager Notifications { get; } = new iOSNotificationsManager();

    public ILocationManager Location { get; } = new iOSLocationManager();

    public IInAppMessagesManager InAppMessages { get; } = new iOSInAppMessagesManager();

    public IDebugManager Debug { get; } = new iOSDebugManager();

    public bool RequiresPrivacyConsent
    {
        get => OneSignalNative.RequiresPrivacyConsent;
        set => OneSignalNative.RequiresPrivacyConsent = value;
    }

    public bool PrivacyConsent
    {
        get => OneSignalNative.PrivacyConsent;
        set => OneSignalNative.SetPrivacyConsent(value);
    }

    public void Initialize(string appId)
    {
        OneSignalNative.SetMSDKType(WrapperSDK.Type);
        OneSignalNative.Initialize(appId, new NSDictionary());

        ((iOSUserManager)User).Initialize();
        ((iOSNotificationsManager)Notifications).Initialize();
        ((iOSInAppMessagesManager)InAppMessages).Initialize();
    }

    public void Login(string externalId, string? jwtBearerToken = null)
    {
        if (String.IsNullOrWhiteSpace(jwtBearerToken))
        {
            OneSignalNative.Login(externalId);
        }
        else
        {
            OneSignalNative.Login(externalId, jwtBearerToken);
        }
    }

    public void Logout()
    {
        OneSignalNative.Logout();
    }
}
