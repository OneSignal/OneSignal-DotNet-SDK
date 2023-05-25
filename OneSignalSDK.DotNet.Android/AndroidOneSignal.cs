using Android.Content;
using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.Debug;
using OneSignalSDK.DotNet.Core.InAppMessages;
using OneSignalSDK.DotNet.Core.Location;
using OneSignalSDK.DotNet.Core.Notifications;
using OneSignalSDK.DotNet.Core.Session;
using OneSignalSDK.DotNet.Core.User;
using OneSignalSDK.DotNet.Core.Internal.Utilities;

using Android.App;
using OneSignalNative = Com.OneSignal.Android.OneSignal;

namespace OneSignalSDK.DotNet.Android;

public class AndroidOneSignal : IOneSignal
{
   /** These static references are not used, but we need to reference at least one class
    *  in the binding projects that are otherwised not referenced. If we did *not*, then
    *  the binding DLLs will not be included in the output bin directory.
    */
    private static Com.OneSignal.Android.InAppMessages.BuildConfig InAppMessagesBuildConfig;
    private static Com.OneSignal.Android.Notifications.BuildConfig NotificationsBuildConfig;
    private static Com.OneSignal.Android.Location.BuildConfig LocationBuildConfig;

    public IUserManager User { get; } = new AndroidUserManager();

    public ISessionManager Session { get; } = new AndroidSessionManager();

    public INotificationsManager Notifications { get; } = new AndroidNotificationsManager();

    public ILocationManager Location { get; } = new AndroidLocationManager();

    public IInAppMessagesManager InAppMessages { get; } = new AndroidInAppMessagesManager();

    public IDebugManager Debug { get; } = new AndroidDebugManager();

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
        if (version != null) {
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

    public Task<bool> EnterLiveActivityAsync(string activityId, string token)
    {
        Console.WriteLine("OneSignal: EnterLiveActivity is available on iOS only");
        return Task.FromResult(false);
    }

    public Task<bool> ExitLiveActivityAsync(string activityId)
    {
        Console.WriteLine("OneSignal: ExitLiveActivity is available on iOS only");
        return Task.FromResult(false);
    }
}
