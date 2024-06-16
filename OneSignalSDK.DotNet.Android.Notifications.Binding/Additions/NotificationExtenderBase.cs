using AndroidX.Core.App;

namespace Com.OneSignal.Notifications.Android
{
    public abstract class NotificationExtenderBase : Java.Lang.Object, NotificationCompat.IExtender
    {
        public abstract NotificationCompat.Builder Extend(NotificationCompat.Builder builder);
    }
}
