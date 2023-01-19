using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.Notifications;
using OneSignalSDK.DotNet.iOS.Utilities;
using OneSignalNative = Com.OneSignal.iOS.OneSignal;

namespace OneSignalSDK.DotNet.iOS;

public class iOSNotificationsManager : INotificationsManager
{
    public event EventHandler<NotificationPermissionChangedEventArgs>? PermissionChanged;
    public event EventHandler<NotificationWillDisplayEventArgs>? WillDisplay;
    public event EventHandler<NotificationClickedEventArgs>? Clicked;

    public bool Permission => OneSignalNative.Notifications.Permission;

    public void Initialize()
    {
        var handler = new iOSNotificationsEventsHandler(this);

        OneSignalNative.Notifications.AddPermissionObserver(handler);
        OneSignalNative.Notifications.SetNotificationWillShowInForegroundHandler((nativeNotification, displayResponse) =>
        {
            var notification = FromNativeConversion.ToNotification(nativeNotification);
            var args = new NotificationWillDisplayEventArgs(notification);

            WillDisplay?.Invoke(this, args);

            displayResponse(args.ToDisplayNotification != null ? nativeNotification : null);
        });

        OneSignalNative.Notifications.SetNotificationOpenedHandler(r =>
        {
            var notification = FromNativeConversion.ToNotification(r.Notification);
            var action = FromNativeConversion.ToNotificationAction(r.Action);
            var args = new Core.Notifications.NotificationClickedEventArgs(notification, action);
            Clicked?.Invoke(this, args);
        });
    }

    public async Task<bool> RequestPermissionAsync(bool fallbackToSettings)
    {
        var proxy = new BooleanCallbackProxy();
        OneSignalNative.Notifications.RequestPermission(r => proxy.OnResponse(r), fallbackToSettings);
        return await proxy;
    }

    private class iOSNotificationsEventsHandler : Com.OneSignal.iOS.OSPermissionObserver
    {
        private iOSNotificationsManager _manager;
        public iOSNotificationsEventsHandler(iOSNotificationsManager manager)
        {
            _manager = manager;
        }

        public void OnOSPermissionChanged(Com.OneSignal.iOS.OSPermissionStateChanges stateChanges)
        {
            _manager.PermissionChanged?.Invoke(_manager, new NotificationPermissionChangedEventArgs(stateChanges.To.Status == Com.OneSignal.iOS.OSNotificationPermission.Authorized));
        }
    }
}
