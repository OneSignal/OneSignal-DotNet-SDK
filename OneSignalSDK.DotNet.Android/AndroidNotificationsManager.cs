using OneSignalSDK.DotNet.Android.Utilities;
using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.Internal.Utilities;
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

        OneSignalNative.Notifications.AddPermissionObserver(_notificationsEventsHandler);
        OneSignalNative.Notifications.AddForegroundLifecycleListener(_notificationsEventsHandler);
        OneSignalNative.Notifications.AddClickListener(_notificationsEventsHandler);
    }

    public async Task<bool> RequestPermission(bool fallbackToSettings)
    {
        var consumer = new AndroidBoolConsumer();
        OneSignalNative.Notifications.RequestPermission(fallbackToSettings, Com.OneSignal.Android.Continue.With(consumer));
        return await consumer;
    }

    private class InternalNotificationsEventsHandler : Java.Lang.Object,
        Com.OneSignal.Android.Notifications.IPermissionObserver,
        Com.OneSignal.Android.Notifications.INotificationLifecycleListener,
        Com.OneSignal.Android.Notifications.INotificationClickListener
    {
        private AndroidNotificationsManager _manager;
        public InternalNotificationsEventsHandler(AndroidNotificationsManager manager)
        {
            _manager = manager;
        }

        public void OnNotificationPermissionChange(bool permission)
        {
            _manager.PermissionChanged?.Invoke(_manager, new NotificationPermissionChangedEventArgs(permission));
        }

        public void OnWillDisplay(Com.OneSignal.Android.Notifications.INotificationWillDisplayEvent willDisplayEvent)
        {
            var notification = AndroidDisplayableNotification.ToDisplayableNotification(willDisplayEvent.Notification);
            var args = new AndroidNotificationWillDisplayEventArgs(willDisplayEvent, notification);

            _manager.WillDisplay?.Invoke(_manager, args);
        }

        public void OnClick(Com.OneSignal.Android.Notifications.INotificationClickEvent clickEvent)
        {
            var notification = FromNativeConversion.ToNotification(clickEvent.Notification);
            var result = FromNativeConversion.ToNotificationClickResult(clickEvent.Result);
            var args = new OneSignalSDK.DotNet.Core.Notifications.NotificationClickedEventArgs(notification, result);
            _manager.Clicked?.Invoke(_manager, args);
        }
    }

    private sealed class AndroidNotificationWillDisplayEventArgs : OneSignalSDK.DotNet.Core.Notifications.NotificationWillDisplayEventArgs
    {
        private Com.OneSignal.Android.Notifications.INotificationWillDisplayEvent _willDisplayEvent;

        public AndroidNotificationWillDisplayEventArgs(Com.OneSignal.Android.Notifications.INotificationWillDisplayEvent willDisplayEvent,
                                                   DisplayableNotification notification) : base(notification)
        {
            _willDisplayEvent = willDisplayEvent;
        }

        public override void PreventDefault()
        {
            _willDisplayEvent.PreventDefault();
        }
    }

    private sealed class AndroidDisplayableNotification : OneSignalSDK.DotNet.Core.Notifications.DisplayableNotification
    {
        public static AndroidDisplayableNotification ToDisplayableNotification(Com.OneSignal.Android.Notifications.IDisplayableNotification notification)
        {
            IDictionary<string, object> additionalData = new Dictionary<string, object>();
            if (notification.AdditionalData != null)
                additionalData = Json.Deserialize(notification.AdditionalData.ToString()) as IDictionary<string, object> ?? new Dictionary<string, object>();

            IList<OneSignalSDK.DotNet.Core.Notifications.Notification>? groupedNotifications = null;
            if (notification.GroupedNotifications != null)
            {
                groupedNotifications = new List<OneSignalSDK.DotNet.Core.Notifications.Notification>();
                foreach (var individualNotification in notification.GroupedNotifications)
                    groupedNotifications.Add(FromNativeConversion.ToNotification(individualNotification));
            }

            var actionButtons = new List<OneSignalSDK.DotNet.Core.Notifications.ActionButton>();
            if (notification.ActionButtons != null)
            {
                foreach (var actionButton in notification.ActionButtons)
                    actionButtons.Add(new OneSignalSDK.DotNet.Core.Notifications.ActionButton(
                        id: actionButton.Id,
                        text: actionButton.Text,
                        icon: actionButton.Icon
                    ));
            }

            OneSignalSDK.DotNet.Core.Notifications.BackgroundImageLayout? backgroundImageLayout = null;
            if (notification.BackgroundImageLayout != null)
            {
                backgroundImageLayout = new OneSignalSDK.DotNet.Core.Notifications.BackgroundImageLayout(
                    image: notification.BackgroundImageLayout.Image,
                    titleTextColor: notification.BackgroundImageLayout.TitleTextColor,
                    bodyTextColor: notification.BackgroundImageLayout.BodyTextColor
                );
            }

            return new AndroidDisplayableNotification(
                displayableNotification: notification,
                title: notification.Title,
                body: notification.Body,
                sound: notification.Sound,
                launchUrl: notification.LaunchURL,
                actionButtons: actionButtons,
                additionalData: additionalData,
                notificationId: notification.NotificationId,
                groupedNotifications: groupedNotifications,
                backgroundImageLayout: backgroundImageLayout,
                groupKey: notification.GroupKey,
                groupMessage: notification.GroupMessage,
                ledColor: notification.LedColor,
                priority: notification.Priority,
                smallIcon: notification.SmallIcon,
                largeIcon: notification.LargeIcon,
                bigPicture: notification.BigPicture,
                collapseId: notification.CollapseId,
                fromProjectNumber: notification.FromProjectNumber,
                smallIconAccentColor: notification.SmallIconAccentColor,
                lockScreenVisibility: notification.LockScreenVisibility,
                androidNotificationId: notification.AndroidNotificationId
            );
        }
            
        private Com.OneSignal.Android.Notifications.IDisplayableNotification _displayableNotification;

        public AndroidDisplayableNotification(
            Com.OneSignal.Android.Notifications.IDisplayableNotification displayableNotification,
            string title,
            string body,
            string sound,
            string launchUrl,
            IList<ActionButton> actionButtons,
            IDictionary<string, object> additionalData,
            string notificationId,
            IList<OneSignalSDK.DotNet.Core.Notifications.Notification> groupedNotifications = null,
            BackgroundImageLayout backgroundImageLayout = null,
            string templateId = null,
            string templateName = null,
            string groupKey = null,
            string groupMessage = null,
            string ledColor = null,
            int? priority = null,
            string smallIcon = null,
            string largeIcon = null,
            string bigPicture = null,
            string collapseId = null,
            string fromProjectNumber = null,
            string smallIconAccentColor = null,
            int? lockScreenVisibility = null,
            int? androidNotificationId = null,
            int? badge = null, int?
            badgeIncrement = null,
            string category = null,
            string threadId = null,
            string subtitle = null,
            float? relevanceScore = null,
            bool? mutableContent = null,
            bool? contentAvailable = null,
            string interruptionLevel = null) : base(
                title,
                body,
                sound,
                launchUrl,
                actionButtons,
                additionalData,
                notificationId,
                groupedNotifications,
                backgroundImageLayout,
                templateId,
                templateName,
                groupKey,
                groupMessage,
                ledColor,
                priority,
                smallIcon,
                largeIcon,
                bigPicture,
                collapseId,
                fromProjectNumber,
                smallIconAccentColor,
                lockScreenVisibility,
                androidNotificationId,
                badge,
                badgeIncrement,
                category,
                threadId,
                subtitle,
                relevanceScore,
                mutableContent,
                contentAvailable,
                interruptionLevel)
        {
            _displayableNotification = displayableNotification;
        }

        public override void display()
        {
            _displayableNotification.Display();
        }
    }
}
