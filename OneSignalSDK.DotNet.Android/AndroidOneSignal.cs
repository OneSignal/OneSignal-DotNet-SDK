using Android.App;
using Android.Content;
using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.Debug;
using OneSignalSDK.DotNet.Core.InAppMessages;
using OneSignalSDK.DotNet.Core.Internal.Utilities;
using OneSignalSDK.DotNet.Core.LiveActivities;
using OneSignalSDK.DotNet.Core.Location;
using OneSignalSDK.DotNet.Core.Notifications;
using OneSignalSDK.DotNet.Core.Session;
using OneSignalSDK.DotNet.Core.User;
using OneSignalNative = Com.OneSignal.Android.OneSignal;

namespace OneSignalSDK.DotNet.Android;

public class AndroidOneSignal : IOneSignal
{
    /** Retain binding assembly references so optional module DLLs are copied to output. */
#pragma warning disable CS0169
    private static readonly Type[] BindingRetentionTypes =
    {
        typeof(Com.OneSignal.Android.InAppMessages.IInAppMessagesManager),
        typeof(Com.OneSignal.Android.Notifications.INotificationsManager),
        typeof(Com.OneSignal.Android.Location.ILocationManager),
    };
#pragma warning restore CS0169

    public IUserManager User { get; } = new AndroidUserManager();

    public ISessionManager Session { get; } = new AndroidSessionManager();

    public INotificationsManager Notifications { get; } = new AndroidNotificationsManager();

    public ILocationManager Location { get; } = new AndroidLocationManager();

    public IInAppMessagesManager InAppMessages { get; } = new AndroidInAppMessagesManager();

    public IDebugManager Debug { get; } = new AndroidDebugManager();

    public ILiveActivitiesManager LiveActivities { get; } = new AndroidLiveActivitiesManager();

    public bool ConsentRequired
    {
        set => OneSignalNative.ConsentRequired = value;
    }

    public bool ConsentGiven
    {
        set => OneSignalNative.ConsentGiven = value;
    }

    public void Initialize(string appId)
    {
        Context context = Application.Context;

        Com.OneSignal.Android.Common.OneSignalWrapper.SdkType = WrapperSDK.Type;

        var version = WrapperSDK.Version;
        if (version != null)
        {
            Com.OneSignal.Android.Common.OneSignalWrapper.SdkVersion = version;
        }

        OneSignalNative.InitWithContext(context, appId);

        ((AndroidUserManager)User).Initialize();
        ((AndroidNotificationsManager)Notifications).Initialize();
        ((AndroidInAppMessagesManager)InAppMessages).Initialize();
    }

    public void Login(string externalId, string? jwtBearerToken = null)
    {
        OneSignalNative.Login(externalId, jwtBearerToken);
    }

    public void Logout()
    {
        OneSignalNative.Logout();
    }
}
