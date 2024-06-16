using Android.Content;

namespace Com.OneSignal.Android.Notifications
{
    public abstract class NotificationServiceExtenderBase: Java.Lang.Object, Com.OneSignal.Android.Notifications.INotificationServiceExtension
    {
        public abstract void OnNotificationReceived(Com.OneSignal.Android.Notifications.INotificationReceivedEvent ev);
    }
}

