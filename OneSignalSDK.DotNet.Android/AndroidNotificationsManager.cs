using OneSignalSDK.DotNet.Android.Utilities;
using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.Notifications;

using OneSignalNative = Com.OneSignal.Android.OneSignal;

namespace OneSignalSDK.DotNet.Android;

public class AndroidNotificationsManager : INotificationsManager
{
    public event EventHandler<NotificationPermissionChangedEventArgs>? PermissionChanged;
    public event EventHandler<NotificationWillDisplayEventArgs>? WillDisplay;
    public event EventHandler<NotificationClickedEventArgs>? Clicked;

    public bool Permission => OneSignalNative.Notifications.Permission;

    private InternalNotificationsEventsHandler? _notificationsEventsHandler;
    public void Initialize()
    {
        _notificationsEventsHandler = new InternalNotificationsEventsHandler(this);

        OneSignalNative.Notifications.AddPermissionChangedHandler(_notificationsEventsHandler);
        OneSignalNative.Notifications.SetNotificationWillShowInForegroundHandler(_notificationsEventsHandler);
        OneSignalNative.Notifications.SetNotificationClickHandler(_notificationsEventsHandler);
    }

    public async Task<bool> RequestPermissionAsync(bool fallbackToSettings)
    {
        var consumer = new AndroidBoolConsumer();
        OneSignalNative.Notifications.RequestPermission(fallbackToSettings, Com.OneSignal.Android.Continue.With(consumer));
        return await consumer;
    }

    private class InternalNotificationsEventsHandler : Java.Lang.Object,
        Com.OneSignal.Android.Notifications.IPermissionChangedHandler,
        Com.OneSignal.Android.Notifications.INotificationWillShowInForegroundHandler,
        Com.OneSignal.Android.Notifications.INotificationClickHandler
    {
        private AndroidNotificationsManager _manager;
        public InternalNotificationsEventsHandler(AndroidNotificationsManager manager)
        {
            _manager = manager;
        }

        public void OnPermissionChanged(bool permission)
        {
            _manager.PermissionChanged?.Invoke(_manager, new NotificationPermissionChangedEventArgs(permission));
        }

        public void NotificationWillShowInForeground(Com.OneSignal.Android.Notifications.INotificationReceivedEvent notificationReceivedEvent)
        {
            var notification = FromNativeConversion.ToNotification(notificationReceivedEvent.Notification);
            var args = new NotificationWillDisplayEventArgs(notification);

            _manager.WillDisplay?.Invoke(_manager, args);

            notificationReceivedEvent.Complete(args.ToDisplayNotification != null ? notificationReceivedEvent.Notification : null);
        }

        public void NotificationClicked(Com.OneSignal.Android.Notifications.INotificationClickResult jResult)
        {
            var notification = FromNativeConversion.ToNotification(jResult.Notification);
            var action = new OneSignalSDK.DotNet.Core.Notifications.NotificationAction(
                actionId: jResult.Action.ActionId,
                type: FromNativeConversion.ToNotificationActionType(jResult.Action.Type)
            );

            var args = new OneSignalSDK.DotNet.Core.Notifications.NotificationClickedEventArgs(notification, action);
            _manager.Clicked?.Invoke(_manager, args);
        }
    }
}
