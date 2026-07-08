using Foundation;
using Plugin.LocalNotification.Platforms;
using UserNotifications;

namespace PluginLocalNotifDemo;

public sealed class OneSignalCompatibleNotificationDelegate : UserNotificationCenterDelegate
{
    // OneSignal's swizzle forwards to prefixed selectors; exporting them gives
    // Xamarin a managed target while preserving Plugin.LocalNotification handling.
    [Export("onesignalUserNotificationCenter:willPresentNotification:withCompletionHandler:")]
    public void OneSignalWillPresentNotification(
        UNUserNotificationCenter center,
        UNNotification notification,
        Action<UNNotificationPresentationOptions> completionHandler
    )
    {
        WillPresentNotification(center, notification, completionHandler);
    }

    [Export("onesignalUserNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:")]
    public void OneSignalDidReceiveNotificationResponse(
        UNUserNotificationCenter center,
        UNNotificationResponse response,
        Action completionHandler
    )
    {
        DidReceiveNotificationResponse(center, response, completionHandler);
    }
}
