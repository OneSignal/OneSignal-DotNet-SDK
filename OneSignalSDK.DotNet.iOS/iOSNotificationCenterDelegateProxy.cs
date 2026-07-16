using System.Runtime.InteropServices;
using Com.OneSignal.iOS;
using ObjCRuntime;
using UserNotifications;

namespace OneSignalSDK.DotNet.iOS;

internal sealed class iOSNotificationCenterDelegateProxy
    : OneSignalNotificationCenterDelegateProxy,
        IUNUserNotificationCenterDelegate
{
    private const string WillPresentSelector =
        "userNotificationCenter:willPresentNotification:withCompletionHandler:";
    private const string OneSignalWillPresentSelector =
        "onesignalUserNotificationCenter:willPresentNotification:withCompletionHandler:";
    private const string DidReceiveResponseSelector =
        "userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:";
    private const string OneSignalDidReceiveResponseSelector =
        "onesignalUserNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:";

    private readonly IUNUserNotificationCenterDelegate _innerDelegate;

    public iOSNotificationCenterDelegateProxy(IUNUserNotificationCenterDelegate innerDelegate)
    {
        _innerDelegate = innerDelegate;
    }

    public override void WillPresentNotification(
        UNUserNotificationCenter center,
        UNNotification notification,
        Action<UNNotificationPresentationOptions> completionHandler
    ) => ForwardWillPresentNotification(center, notification, completionHandler);

    public override void DidReceiveNotificationResponse(
        UNUserNotificationCenter center,
        UNNotificationResponse response,
        Action completionHandler
    ) => _innerDelegate.DidReceiveNotificationResponse(center, response, completionHandler);

    public override void OneSignalWillPresentNotification(
        UNUserNotificationCenter center,
        UNNotification notification,
        Action<UNNotificationPresentationOptions> completionHandler
    ) => ForwardWillPresentNotification(center, notification, completionHandler);

    public override void OneSignalDidReceiveNotificationResponse(
        UNUserNotificationCenter center,
        UNNotificationResponse response,
        Action completionHandler
    ) => _innerDelegate.DidReceiveNotificationResponse(center, response, completionHandler);

    private void ForwardWillPresentNotification(
        UNUserNotificationCenter center,
        UNNotification notification,
        Action<UNNotificationPresentationOptions> completionHandler
    )
    {
        if (OneSignalCoreHelper.IsOneSignalPayload(notification.Request.Content.UserInfo))
        {
            _innerDelegate.WillPresentNotification(center, notification, _ => { });
            return;
        }

        _innerDelegate.WillPresentNotification(center, notification, completionHandler);
    }

    public static bool RepairOneSignalDispatch()
    {
        // The exported aliases make native injection exchange two managed IMPs.
        // Restore OneSignal's implementation on the Apple selectors afterward.
        var proxyClass = Class.GetHandle(typeof(iOSNotificationCenterDelegateProxy));
        var oneSignalClass = Class.GetHandle("OneSignalNotificationsUNUserNotificationCenter");
        if (proxyClass == IntPtr.Zero || oneSignalClass == IntPtr.Zero)
            return false;

        return InstallOneSignalImplementation(
                proxyClass,
                oneSignalClass,
                WillPresentSelector,
                OneSignalWillPresentSelector
            )
            && InstallOneSignalImplementation(
                proxyClass,
                oneSignalClass,
                DidReceiveResponseSelector,
                OneSignalDidReceiveResponseSelector
            );
    }

    private static bool InstallOneSignalImplementation(
        IntPtr proxyClass,
        IntPtr oneSignalClass,
        string targetSelectorName,
        string oneSignalSelectorName
    )
    {
        var targetMethod = class_getInstanceMethod(
            proxyClass,
            Selector.GetHandle(targetSelectorName)
        );
        var oneSignalMethod = class_getInstanceMethod(
            oneSignalClass,
            Selector.GetHandle(oneSignalSelectorName)
        );
        if (targetMethod == IntPtr.Zero || oneSignalMethod == IntPtr.Zero)
            return false;

        var oneSignalImplementation = method_getImplementation(oneSignalMethod);
        if (oneSignalImplementation == IntPtr.Zero)
            return false;

        method_setImplementation(targetMethod, oneSignalImplementation);
        return true;
    }

    [DllImport(Constants.ObjectiveCLibrary)]
    private static extern IntPtr class_getInstanceMethod(IntPtr cls, IntPtr selector);

    [DllImport(Constants.ObjectiveCLibrary)]
    private static extern IntPtr method_getImplementation(IntPtr method);

    [DllImport(Constants.ObjectiveCLibrary)]
    private static extern IntPtr method_setImplementation(IntPtr method, IntPtr implementation);
}
