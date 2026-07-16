using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using OneSignalSDK.DotNet.iOS;
using UIKit;

namespace PluginLocalNotifDemo;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    [Export("application:didRegisterForRemoteNotificationsWithDeviceToken:")]
    public void DidRegisterForRemoteNotifications(UIApplication application, NSData deviceToken)
    {
        NotificationsManualIntegration.DidRegisterForRemoteNotifications(deviceToken);
    }

    [Export("application:didFailToRegisterForRemoteNotificationsWithError:")]
    public void DidFailToRegisterForRemoteNotifications(UIApplication application, NSError error)
    {
        NotificationsManualIntegration.DidFailToRegisterForRemoteNotifications(error);
    }

    [Export("application:didReceiveRemoteNotification:fetchCompletionHandler:")]
    public void DidReceiveRemoteNotification(
        UIApplication application,
        NSDictionary userInfo,
        Action<UIBackgroundFetchResult> completionHandler
    )
    {
        NotificationsManualIntegration.DidReceiveRemoteNotification(userInfo, completionHandler);
    }
}
