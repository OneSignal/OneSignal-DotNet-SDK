using System;
using Foundation;
using OneSignalSDK.DotNet;
using UIKit;
using UserNotifications;

namespace OneSignalApp.Maui.NotificationServiceExtension
{
    [Register("NotificationService")]
    public class NotificationService : UNNotificationServiceExtension
    {
        Action<UNNotificationContent> ContentHandler { get; set; }
        UNMutableNotificationContent BestAttemptContent { get; set; }
        UNNotificationRequest ReceivedRequest { get; set; }

        protected NotificationService(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void DidReceiveNotificationRequest(UNNotificationRequest request, Action<UNNotificationContent> contentHandler)
        {
            ReceivedRequest = request;
            ContentHandler = contentHandler;
            BestAttemptContent = (UNMutableNotificationContent)request.Content.MutableCopy();

            OneSignalSDK.DotNet.iOS.NotificationServiceExtension.DidReceiveNotificationExtensionRequest(request, BestAttemptContent, contentHandler);
        }

        public override void TimeWillExpire()
        {
            // Called just before the extension will be terminated by the system.
            // Use this as an opportunity to deliver your "best attempt" at modified content, otherwise the original push payload will be used.

            OneSignalSDK.DotNet.iOS.NotificationServiceExtension.ServiceExtensionTimeWillExpireRequest(ReceivedRequest, BestAttemptContent);

            ContentHandler(BestAttemptContent);
        }
    }
}

