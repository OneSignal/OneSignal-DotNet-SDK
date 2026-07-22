using Android.Runtime;
using AndroidX.Core.App;
using Com.OneSignal.Android.Notifications;

namespace OneSignalAndroidServiceExtension;

[Register("com/onesignal/example/NotificationServiceExtension")]
public sealed class NotificationServiceExtension
    : Java.Lang.Object,
        INotificationServiceExtension
{
    public void OnNotificationReceived(INotificationReceivedEvent notificationEvent)
    {
        notificationEvent.Notification.SetExtender(new NotificationExtender());
    }
}

public sealed class NotificationExtender : Java.Lang.Object, NotificationCompat.IExtender
{
    public NotificationCompat.Builder Extend(NotificationCompat.Builder builder)
    {
        return builder.SetColor(unchecked((int)0xFF0066FF));
    }
}
