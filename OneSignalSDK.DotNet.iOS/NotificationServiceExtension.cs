using System;
using UserNotifications;

using OneSignalNative = Com.OneSignal.iOS;

namespace OneSignalSDK.DotNet.iOS
{
    /// <summary>
    /// Public SDK API to be consumed by the App's iOS NotificationServiceExtension target
    /// </summary>
    public class NotificationServiceExtension
    {
        public static UNMutableNotificationContent DidReceiveNotificationExtensionRequest(
           UNNotificationRequest request,
           UNMutableNotificationContent replacementContent,
           Action<UNNotificationContent> contentHandler)
        {
            return OneSignalNative.OneSignal.DidReceiveNotificationExtensionRequest(
               request,
               replacementContent,
               delegate (UNNotificationContent notificationContent)
               {
                   contentHandler.Invoke(notificationContent);
               }
            );
        }

        public static void ServiceExtensionTimeWillExpireRequest(
           UNNotificationRequest request,
           UNMutableNotificationContent replacementContent)
        {
            OneSignalNative.OneSignal.ServiceExtensionTimeWillExpireRequest(request, replacementContent);
        }
    }
}
