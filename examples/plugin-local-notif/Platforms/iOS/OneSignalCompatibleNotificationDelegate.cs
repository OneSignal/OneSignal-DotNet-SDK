using Foundation;
using Plugin.LocalNotification.Platforms;
using UserNotifications;

namespace PluginLocalNotifDemo;

public sealed class OneSignalCompatibleNotificationDelegate : UserNotificationCenterDelegate
{
    // OneSignal's swizzle can exchange method implementations on this class, so
    // depending on which slot iOS invokes, either the normal overrides or the
    // onesignal-prefixed exports receive the callback. Both route remote pushes
    // to foreground presentation and leave local notifications to the plugin.
    public override void WillPresentNotification(
        UNUserNotificationCenter center,
        UNNotification notification,
        Action<UNNotificationPresentationOptions> completionHandler
    )
    {
        if (HandledAsRemotePush(notification, completionHandler))
            return;

        base.WillPresentNotification(center, notification, completionHandler);
    }

    public override void DidReceiveNotificationResponse(
        UNUserNotificationCenter center,
        UNNotificationResponse response,
        Action completionHandler
    )
    {
        if (response.Notification.Request.Trigger is UNPushNotificationTrigger)
        {
            completionHandler();
            return;
        }

        base.DidReceiveNotificationResponse(center, response, completionHandler);
    }

    [Export("onesignalUserNotificationCenter:willPresentNotification:withCompletionHandler:")]
    public void OneSignalWillPresentNotification(
        UNUserNotificationCenter center,
        UNNotification notification,
        Action<UNNotificationPresentationOptions> completionHandler
    )
    {
        if (HandledAsRemotePush(notification, completionHandler))
            return;

        base.WillPresentNotification(center, notification, completionHandler);
    }

    [Export("onesignalUserNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:")]
    public void OneSignalDidReceiveNotificationResponse(
        UNUserNotificationCenter center,
        UNNotificationResponse response,
        Action completionHandler
    )
    {
        if (response.Notification.Request.Trigger is UNPushNotificationTrigger)
        {
            completionHandler();
            return;
        }

        base.DidReceiveNotificationResponse(center, response, completionHandler);
    }

    private static bool HandledAsRemotePush(
        UNNotification notification,
        Action<UNNotificationPresentationOptions> completionHandler
    )
    {
        if (notification.Request.Trigger is not UNPushNotificationTrigger)
            return false;

        completionHandler(
            UNNotificationPresentationOptions.Banner
                | UNNotificationPresentationOptions.List
                | UNNotificationPresentationOptions.Sound
                | UNNotificationPresentationOptions.Badge
        );
        return true;
    }
}
