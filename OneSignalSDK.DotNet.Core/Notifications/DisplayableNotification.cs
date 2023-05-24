using System;
using System.Collections.Generic;

namespace OneSignalSDK.DotNet.Core.Notifications
{
    /// <summary>
    /// Represents a notification.
    /// </summary>
    public abstract class DisplayableNotification : Notification
    {
        public DisplayableNotification(
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
        }

        public abstract void display();
    }

}
