using OneSignalSDK.DotNet.iOS;
using UserNotifications;

namespace PluginLocalNotifDemo;

internal sealed class OneSignalNotificationDelegate : UNUserNotificationCenterDelegate
{
    private static OneSignalNotificationDelegate? _instance;
    private readonly IUNUserNotificationCenterDelegate _localNotificationDelegate;

    private OneSignalNotificationDelegate(
        IUNUserNotificationCenterDelegate localNotificationDelegate
    )
    {
        _localNotificationDelegate = localNotificationDelegate;
    }

    public static void Install()
    {
        var notificationCenter = UNUserNotificationCenter.Current;
        var localNotificationDelegate =
            notificationCenter.Delegate
            ?? throw new InvalidOperationException(
                "Plugin.LocalNotification must install its iOS delegate before OneSignal."
            );

        _instance = new OneSignalNotificationDelegate(localNotificationDelegate);
        notificationCenter.Delegate = _instance;
    }

    public override void WillPresentNotification(
        UNUserNotificationCenter center,
        UNNotification notification,
        Action<UNNotificationPresentationOptions> completionHandler
    )
    {
        var presentationOptions =
            UNNotificationPresentationOptions.Banner
            | UNNotificationPresentationOptions.List
            | UNNotificationPresentationOptions.Sound
            | UNNotificationPresentationOptions.Badge;

        if (
            NotificationsManualIntegration.TryHandleWillPresentNotification(
                notification,
                presentationOptions,
                completionHandler
            )
        )
        {
            return;
        }

        _localNotificationDelegate.WillPresentNotification(center, notification, completionHandler);
    }

    public override void DidReceiveNotificationResponse(
        UNUserNotificationCenter center,
        UNNotificationResponse response,
        Action completionHandler
    )
    {
        if (
            NotificationsManualIntegration.TryHandleNotificationResponse(
                response,
                completionHandler
            )
        )
        {
            return;
        }

        _localNotificationDelegate.DidReceiveNotificationResponse(
            center,
            response,
            completionHandler
        );
    }
}
