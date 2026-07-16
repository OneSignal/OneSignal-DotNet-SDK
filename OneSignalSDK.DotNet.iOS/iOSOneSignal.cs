using Foundation;
using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.Debug;
using OneSignalSDK.DotNet.Core.InAppMessages;
using OneSignalSDK.DotNet.Core.Internal.Utilities;
using OneSignalSDK.DotNet.Core.LiveActivities;
using OneSignalSDK.DotNet.Core.Location;
using OneSignalSDK.DotNet.Core.Notifications;
using OneSignalSDK.DotNet.Core.Session;
using OneSignalSDK.DotNet.Core.User;
using OneSignalSDK.DotNet.iOS.Utilities;
using UIKit;
using UserNotifications;
using OneSignalNative = Com.OneSignal.iOS.OneSignal;

namespace OneSignalSDK.DotNet.iOS;

public class iOSOneSignal : IOneSignal
{
    private iOSNotificationCenterDelegateProxy? _notificationCenterDelegateProxy;
    private NSObject? _notificationDelegateObserver;

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

        var notificationCenter = UNUserNotificationCenter.Current;
        var existingDelegate = notificationCenter.Delegate;
        if (existingDelegate != null && existingDelegate is not iOSNotificationCenterDelegateProxy)
        {
            _notificationCenterDelegateProxy = new iOSNotificationCenterDelegateProxy(
                existingDelegate
            );
            notificationCenter.Delegate = _notificationCenterDelegateProxy;
        }

        OneSignalNative.Initialize(appId, new NSDictionary());

        if (
            _notificationCenterDelegateProxy != null
            && !iOSNotificationCenterDelegateProxy.RepairOneSignalDispatch()
        )
        {
            throw new InvalidOperationException(
                "OneSignal could not install its iOS notification delegate compatibility proxy."
            );
        }

        if (_notificationCenterDelegateProxy != null)
        {
            _notificationDelegateObserver ??= NSNotificationCenter.DefaultCenter.AddObserver(
                UIApplication.DidBecomeActiveNotification,
                _ => VerifyNotificationDelegate()
            );
        }

        ((iOSUserManager)User).Initialize();
        ((iOSNotificationsManager)Notifications).Initialize();
        ((iOSInAppMessagesManager)InAppMessages).Initialize();
    }

    private void VerifyNotificationDelegate()
    {
        if (
            _notificationCenterDelegateProxy != null
            && !ReferenceEquals(
                UNUserNotificationCenter.Current.Delegate,
                _notificationCenterDelegateProxy
            )
        )
        {
            System.Diagnostics.Debug.WriteLine(
                "OneSignal iOS notification delegate proxy was replaced after initialization; "
                    + "compatibility forwarding is no longer active."
            );
        }
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
