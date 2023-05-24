using System.Security.Permissions;
using Com.OneSignal.iOS;
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

    private InternalNotificationsPermissionObserver? _notificationsPermissionObserver;
    private InternalNotificationsClickListener? _notificationsClickListener;
    private InternalNotificationsLifecycleListener? _notificationsLifecycleListener;

    public void Initialize()
    {
        var _notificationsPermissionObserver = new InternalNotificationsPermissionObserver(this);
        var _notificationsClickListener = new InternalNotificationsClickListener(this);
        var _notificationsLifecycleListener = new InternalNotificationsLifecycleListener(this);


        OneSignalNative.Notifications.AddPermissionObserver(_notificationsPermissionObserver);
        OneSignalNative.Notifications.AddForegroundLifecycleListener(_notificationsLifecycleListener);
        OneSignalNative.Notifications.AddClickListener(_notificationsClickListener);
    }

    public async Task<bool> RequestPermission(bool fallbackToSettings)
    {
        var proxy = new BooleanCallbackProxy();
        OneSignalNative.Notifications.RequestPermission(r => proxy.OnResponse(r), fallbackToSettings);
        return await proxy;
    }

    private sealed class InternalNotificationsPermissionObserver : Com.OneSignal.iOS.OSNotificationPermissionObserver
    {
        private iOSNotificationsManager _manager;
        public InternalNotificationsPermissionObserver(iOSNotificationsManager manager)
        {
            _manager = manager;
        }

        public override void OnNotificationPermissionDidChange(bool permission)
        {
            _manager.PermissionChanged?.Invoke(_manager, new NotificationPermissionChangedEventArgs(permission));
        }
    }

    private sealed class InternalNotificationsLifecycleListener : Com.OneSignal.iOS.OSNotificationLifecycleListener
    {
        private iOSNotificationsManager _manager;
        public InternalNotificationsLifecycleListener(iOSNotificationsManager manager)
        {
            _manager = manager;
        }

        public override void OnWillDisplayNotification(Com.OneSignal.iOS.OSNotificationWillDisplayEvent willDisplayEvent)
        {
            var notification = iOSDisplayableNotification.ToDisplayableNotification(willDisplayEvent.Notification);
            var args = new iOSNotificationWillDisplayEventArgs(willDisplayEvent, notification);
            _manager.WillDisplay?.Invoke(_manager, args);
        }
    }

    private sealed class InternalNotificationsClickListener : Com.OneSignal.iOS.OSNotificationClickListener
    {
        private iOSNotificationsManager _manager;
        public InternalNotificationsClickListener(iOSNotificationsManager manager)
        {
            _manager = manager;
        }

        public override void OnClickNotification(Com.OneSignal.iOS.OSNotificationClickEvent clickEvent)
        {
            var notification = FromNativeConversion.ToNotification(clickEvent.Notification);
            var result = FromNativeConversion.ToNotificationClickResult(clickEvent.Result);
            var args = new Core.Notifications.NotificationClickedEventArgs(notification, result);
            _manager.Clicked?.Invoke(_manager, args);
        }
    }

    private sealed class iOSNotificationWillDisplayEventArgs : OneSignalSDK.DotNet.Core.Notifications.NotificationWillDisplayEventArgs
    {
        private Com.OneSignal.iOS.OSNotificationWillDisplayEvent _willDisplayEvent;

        public iOSNotificationWillDisplayEventArgs(Com.OneSignal.iOS.OSNotificationWillDisplayEvent willDisplayEvent,
                                                   DisplayableNotification notification) : base(notification)
        {
            _willDisplayEvent = willDisplayEvent;
        }

        public override void PreventDefault()
        {
            _willDisplayEvent.PreventDefault();
        }
    }

    private sealed class iOSDisplayableNotification : OneSignalSDK.DotNet.Core.Notifications.DisplayableNotification
    {
        public static iOSDisplayableNotification ToDisplayableNotification(Com.OneSignal.iOS.OSDisplayableNotification notification)
        {
            Dictionary<string, object> additionalDataXam = new Dictionary<string, object>();
            if (notification.AdditionalData != null)
            {
                additionalDataXam = FromNativeConversion.NSDictToPureDict(notification.AdditionalData);
            }

            List<ActionButton> actionButtonsXam = new List<ActionButton>();
            if (notification.ActionButtons != null)
            {
                foreach (NSObject actionButton in notification.ActionButtons)
                {
                    Dictionary<string, string> actionButtonXam = FromNativeConversion.NSObjectToPureDict(actionButton);
                    if (actionButtonXam != null)
                    {
                        actionButtonsXam.Add(new ActionButton(
                            id: actionButtonXam.GetValueOrDefault("id"),
                            text: actionButtonXam.GetValueOrDefault("text"),
                            icon: actionButtonXam.GetValueOrDefault("icon")
                        ));
                    }
                }
            }

            return new iOSDisplayableNotification(
                displayableNotification: notification,
                notificationId: notification.NotificationId,
                templateName: notification.TemplateName,
                templateId: notification.TemplateId,
                title: notification.Title,
                body: notification.Body,
                additionalData: additionalDataXam,
                launchUrl: notification.LaunchURL,
                sound: notification.Sound,
                relevanceScore: notification.RelevanceScore != null ? (float)notification.RelevanceScore : 0,
                badge: (int)notification.Badge,
                badgeIncrement: (int)notification.BadgeIncrement,
                actionButtons: actionButtonsXam,
                category: notification.Category,
                threadId: notification.ThreadId,
                subtitle: notification.Subtitle,
                mutableContent: notification.MutableContent,
                contentAvailable: notification.ContentAvailable,
                interruptionLevel: notification.InterruptionLevel
            );
        }

        private Com.OneSignal.iOS.OSDisplayableNotification _displayableNotification;

        public iOSDisplayableNotification(
            Com.OneSignal.iOS.OSDisplayableNotification displayableNotification,
            string title,
            string body,
            string sound,
            string launchUrl,
            IList<ActionButton> actionButtons,
            IDictionary<string, object> additionalData,
            string notificationId,
            IList<Notification> groupedNotifications = null,
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