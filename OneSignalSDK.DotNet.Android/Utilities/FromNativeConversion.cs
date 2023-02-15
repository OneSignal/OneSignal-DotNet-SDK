using System;
using System.Collections.Generic;
using OneSignalSDK.DotNet.Core.Debug;
using OneSignalSDK.DotNet.Core.InAppMessages;
using OneSignalSDK.DotNet.Core.Notifications;
using OneSignalSDK.DotNet.Core.Utilities;

namespace OneSignalSDK.DotNet.Android.Utilities;

/// <summary>
/// Translation functions when translating from native SDK class types to their respective .NET SDK class types.
/// </summary>
public static class FromNativeConversion
{
    public static Core.Notifications.Notification ToNotification(Com.OneSignal.Android.Notifications.INotification notification)
    {
        IDictionary<string, object> additionalData = new Dictionary<string, object>();
        if (notification.AdditionalData != null)
            additionalData = Json.Deserialize(notification.AdditionalData.ToString()) as IDictionary<string, object> ?? new Dictionary<string, object>();

        IList<Core.Notifications.Notification>? groupedNotifications = null;
        if (notification.GroupedNotifications != null)
        {
            groupedNotifications = new List<Core.Notifications.Notification>();
            foreach (var individualNotification in notification.GroupedNotifications)
                groupedNotifications.Add(ToNotification(individualNotification));
        }

        var actionButtons = new List<Core.Notifications.ActionButton>();
        if (notification.ActionButtons != null)
        {
            foreach (var actionButton in notification.ActionButtons)
                actionButtons.Add(new Core.Notifications.ActionButton {
                    Id = actionButton.Id,
                    Text = actionButton.Text,
                    Icon = actionButton.Icon
                });
        }

        Core.Notifications.BackgroundImageLayout? backgroundImageLayout = null;
        if (notification.BackgroundImageLayout != null)
        {
            backgroundImageLayout = new Core.Notifications.BackgroundImageLayout {
                Image = notification.BackgroundImageLayout.Image,
                TitleTextColor = notification.BackgroundImageLayout.TitleTextColor,
                BodyTextColor = notification.BackgroundImageLayout.BodyTextColor
            };
        }

        return new Core.Notifications.Notification
        {
            Title = notification.Title,
            Body = notification.Body,
            Sound = notification.Sound,
            LaunchUrl = notification.LaunchURL,
            ActionButtons = actionButtons,
            AdditionalData = additionalData,
            NotificationId = notification.NotificationId,
            GroupedNotifications = groupedNotifications,
            BackgroundImageLayout = backgroundImageLayout,
            GroupKey = notification.GroupKey,
            GroupMessage = notification.GroupMessage,
            LedColor = notification.LedColor,
            Priority = notification.Priority,
            SmallIcon = notification.SmallIcon,
            LargeIcon = notification.LargeIcon,
            BigPicture = notification.BigPicture,
            CollapseId = notification.CollapseId,
            FromProjectNumber = notification.FromProjectNumber,
            SmallIconAccentColor = notification.SmallIconAccentColor,
            LockScreenVisibility = notification.LockScreenVisibility,
            AndroidNotificationId = notification.AndroidNotificationId,
        };
    }

    public static Core.Notifications.NotificationActionType ToNotificationActionType(Com.OneSignal.Android.Notifications.INotificationAction.ActionType actionType)
    {
        return (Core.Notifications.NotificationActionType)actionType.Ordinal();
    }

    public static InAppMessage ToInAppMessage(Com.OneSignal.Android.InAppMessages.IInAppMessage inAppMessage)
    {
        return new InAppMessage {
           MessageId = inAppMessage.MessageId
        };
    }

    public static InAppMessageAction ToInAppMessageAction(Com.OneSignal.Android.InAppMessages.IInAppMessageAction inAppMessageAction)
    {
        return new InAppMessageAction
        {
            ClickName = inAppMessageAction.ClickName,
            ClickUrl = inAppMessageAction.ClickUrl,
            IsFirstClick = inAppMessageAction.IsFirstClick,
            ClosesMessage = inAppMessageAction.ClosesMessage
        };
    }
}
