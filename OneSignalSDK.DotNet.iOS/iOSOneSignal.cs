using Foundation;
using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.Debug;
using OneSignalSDK.DotNet.Core.InAppMessages;
using OneSignalSDK.DotNet.Core.Location;
using OneSignalSDK.DotNet.Core.Notifications;
using OneSignalSDK.DotNet.Core.Session;
using OneSignalSDK.DotNet.Core.User;
using OneSignalSDK.DotNet.Core.Internal.Utilities;

using OneSignalNative = Com.OneSignal.iOS.OneSignal;
using OneSignalSDK.DotNet.iOS.Utilities;
using OneSignalSDK.DotNet.Core.LiveActivities;

namespace OneSignalSDK.DotNet.iOS;

public class iOSOneSignal : IOneSignal
{
    public IUserManager User { get; } = new iOSUserManager();

    public ISessionManager Session { get; } = new iOSSessionManager();

    public INotificationsManager Notifications { get; } = new iOSNotificationsManager();

    public ILocationManager Location { get; } = new iOSLocationManager();

    public IInAppMessagesManager InAppMessages { get; } = new iOSInAppMessagesManager();

    public IDebugManager Debug { get; } = new iOSDebugManager();

    public ILiveActivitiesManager LiveActivities { get; } = new iOSLiveActivitiesManager();

    public bool ConsentRequired
    {
        set => OneSignalNative.SetConsentRequired(value);
    }

    public bool ConsentGiven
    {
        set => OneSignalNative.SetConsentGiven(value);
    }

    public void Initialize(string appId)
    {
        Com.OneSignal.iOS.OneSignalWrapper.SdkType = WrapperSDK.Type;

        var version = WrapperSDK.Version;
        if (version != null)
        {
            Com.OneSignal.iOS.OneSignalWrapper.SdkVersion = version;
        }

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
