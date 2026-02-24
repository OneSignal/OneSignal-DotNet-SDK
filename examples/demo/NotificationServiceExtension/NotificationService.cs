using System;
using Foundation;
using OneSignalSDK.DotNet.iOS;
using UserNotifications;

namespace OneSignalNotificationServiceExtension;

[Register("NotificationService")]
public class NotificationService : UNNotificationServiceExtension
{
    Action<UNNotificationContent>? ContentHandler { get; set; }
    UNMutableNotificationContent? BestAttemptContent { get; set; }
    UNNotificationRequest? ReceivedRequest { get; set; }

    protected NotificationService(IntPtr handle) : base(handle)
    {
    }

    public override void DidReceiveNotificationRequest(UNNotificationRequest request, Action<UNNotificationContent> contentHandler)
    {
        ReceivedRequest = request;
        ContentHandler = contentHandler;
        BestAttemptContent = (UNMutableNotificationContent)request.Content.MutableCopy();

        NotificationServiceExtension.DidReceiveNotificationExtensionRequest(request, BestAttemptContent, contentHandler);
    }

    public override void TimeWillExpire()
    {
        if (ReceivedRequest != null && BestAttemptContent != null)
            NotificationServiceExtension.ServiceExtensionTimeWillExpireRequest(ReceivedRequest, BestAttemptContent);

        ContentHandler?.Invoke(BestAttemptContent ?? new UNMutableNotificationContent());
    }
}
