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
    private static readonly Type[] BindingRetentionTypes =
    {
        typeof(Com.OneSignal.Android.InAppMessages.IInAppMessagesManager),
        typeof(Com.OneSignal.Android.Notifications.INotificationsManager),
        typeof(Com.OneSignal.Android.Location.ILocationManager),
    };

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
        if (InputGuard.IsMissing(appId, "initialize: appId"))
            return;
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
        if (InputGuard.IsMissing(externalId, "login: externalId"))
            return;
        OneSignalNative.Login(externalId, jwtBearerToken);
    }

    public Task<LoginResult> LoginWithProfileAsync(
        string externalId,
        OneSignalUserProfile profile,
        string? jwtBearerToken = null
    )
    {
        if (InputGuard.IsMissing(externalId, "loginWithProfile: externalId"))
            return InvalidArgument("externalId is required");
        if (InputGuard.IsMissing(profile, "loginWithProfile: profile"))
            return InvalidArgument("profile is required");
        if (
            profile.Tags != null
            && InputGuard.HasMissingEntries(profile.Tags, "loginWithProfile: tags", true)
        )
            return InvalidArgument("tags must not contain empty keys or null values");
        if (
            profile.Aliases != null
            && InputGuard.HasMissingEntries(profile.Aliases, "loginWithProfile: aliases", false)
        )
            return InvalidArgument("aliases must not contain empty keys or values");

        var continuation = new LoginResultContinuation();
        try
        {
            var nativeProfile = new Com.OneSignal.Android.OneSignalUserProfile(
                profile.Email,
                profile.Sms,
                profile.Tags ?? new Dictionary<string, string>(),
                profile.Aliases ?? new Dictionary<string, string>()
            );
            var returned = OneSignalNative.Login(
                externalId,
                nativeProfile,
                jwtBearerToken!,
                continuation
            );
            continuation.OnReturned(returned);
        }
        catch (Exception e)
        {
            continuation.Fail("loginWithProfile failed: " + e.Message);
        }
        return continuation.Task;
    }

    private static Task<LoginResult> InvalidArgument(string message)
    {
        return Task.FromResult(LoginResult.Failure("INVALID_ARGUMENT", message));
    }

    public void Logout()
    {
        OneSignalNative.Logout();
    }
}
