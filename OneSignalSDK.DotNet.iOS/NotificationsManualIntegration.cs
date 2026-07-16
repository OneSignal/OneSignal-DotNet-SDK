using Foundation;
using UIKit;
using UserNotifications;
using OneSignalNative = Com.OneSignal.iOS.OneSignal;

namespace OneSignalSDK.DotNet.iOS;

/// <summary>
/// Supported iOS notification callbacks for apps that disable OneSignal method swizzling.
/// </summary>
public static class NotificationsManualIntegration
{
    private const string DisableSwizzlingKey = "OneSignal_disable_swizzling";

    /// <summary>
    /// Returns whether manual notification forwarding is enabled in the app's Info.plist.
    /// </summary>
    public static bool IsEnabled =>
        (NSBundle.MainBundle.ObjectForInfoDictionary(DisableSwizzlingKey) as NSNumber)?.BoolValue
        ?? false;

    /// <summary>
    /// Returns whether a notification payload belongs to OneSignal.
    /// </summary>
    public static bool IsOneSignalNotification(NSDictionary payload)
    {
        ArgumentNullException.ThrowIfNull(payload);
        return Com.OneSignal.iOS.OneSignalCoreHelper.IsOneSignalPayload(payload);
    }

    /// <summary>
    /// Forwards successful APNs registration to OneSignal.
    /// </summary>
    public static void DidRegisterForRemoteNotifications(NSData deviceToken)
    {
        EnsureEnabled();
        ArgumentNullException.ThrowIfNull(deviceToken);
        OneSignalNative.Notifications.DidRegisterForRemoteNotifications(deviceToken);
    }

    /// <summary>
    /// Forwards failed APNs registration to OneSignal.
    /// </summary>
    public static void DidFailToRegisterForRemoteNotifications(NSError error)
    {
        EnsureEnabled();
        ArgumentNullException.ThrowIfNull(error);
        OneSignalNative.Notifications.DidFailToRegisterForRemoteNotifications(error);
    }

    /// <summary>
    /// Forwards a background remote notification to OneSignal. OneSignal owns the completion handler.
    /// </summary>
    public static void DidReceiveRemoteNotification(
        NSDictionary userInfo,
        Action<UIBackgroundFetchResult> completionHandler
    )
    {
        EnsureEnabled();
        ArgumentNullException.ThrowIfNull(userInfo);
        ArgumentNullException.ThrowIfNull(completionHandler);
        OneSignalNative.Notifications.DidReceiveRemoteNotification(userInfo, completionHandler);
    }

    /// <summary>
    /// Handles a OneSignal foreground notification and completes Apple's callback exactly once.
    /// </summary>
    /// <returns><see langword="true"/> when the notification belonged to OneSignal.</returns>
    public static bool TryHandleWillPresentNotification(
        UNNotification notification,
        UNNotificationPresentationOptions presentationOptions,
        Action<UNNotificationPresentationOptions> completionHandler
    )
    {
        EnsureEnabled();
        ArgumentNullException.ThrowIfNull(notification);
        ArgumentNullException.ThrowIfNull(completionHandler);

        var payload = notification.Request.Content.UserInfo;
        if (!IsOneSignalNotification(payload))
            return false;

        OneSignalNative.Notifications.WillPresentNotification(
            payload,
            displayableNotification =>
                completionHandler(
                    displayableNotification == null
                        ? (UNNotificationPresentationOptions)0
                        : presentationOptions
                )
        );
        return true;
    }

    /// <summary>
    /// Handles a OneSignal notification response and completes Apple's callback exactly once.
    /// </summary>
    /// <returns><see langword="true"/> when the notification belonged to OneSignal.</returns>
    public static bool TryHandleNotificationResponse(
        UNNotificationResponse response,
        Action completionHandler
    )
    {
        EnsureEnabled();
        ArgumentNullException.ThrowIfNull(response);
        ArgumentNullException.ThrowIfNull(completionHandler);

        if (!IsOneSignalNotification(response.Notification.Request.Content.UserInfo))
            return false;

        try
        {
            OneSignalNative.Notifications.DidReceiveNotificationResponse(response);
        }
        finally
        {
            completionHandler();
        }

        return true;
    }

    /// <summary>
    /// Sets the app icon badge count through OneSignal.
    /// </summary>
    public static void SetBadgeCount(nint badgeCount)
    {
        EnsureEnabled();
        OneSignalNative.Notifications.SetBadgeCount(badgeCount);
    }

    private static void EnsureEnabled()
    {
        if (!IsEnabled)
        {
            throw new InvalidOperationException(
                $"Set {DisableSwizzlingKey} to true in Info.plist before using manual integration."
            );
        }
    }
}
