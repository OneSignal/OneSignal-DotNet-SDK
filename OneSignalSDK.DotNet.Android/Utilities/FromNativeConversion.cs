using System;
using System.Collections.Generic;
using OneSignalSDK.DotNet.Core.Debug;
using OneSignalSDK.DotNet.Core.InAppMessages;
using OneSignalSDK.DotNet.Core.Notifications;
using OneSignalSDK.DotNet.Core.Internal.Utilities;

namespace OneSignalSDK.DotNet.Android.Utilities;

/// <summary>
/// Translation functions when translating from native SDK class types to their respective .NET SDK class types.
/// </summary>
public static class FromNativeConversion
{
    public static OneSignalSDK.DotNet.Core.Notifications.Notification ToNotification(Com.OneSignal.Android.Notifications.INotification notification)
    {
        IDictionary<string, object> additionalData = new Dictionary<string, object>();
        if (notification.AdditionalData != null)
            additionalData = Json.Deserialize(notification.AdditionalData.ToString()) as IDictionary<string, object> ?? new Dictionary<string, object>();

        IList<OneSignalSDK.DotNet.Core.Notifications.Notification>? groupedNotifications = null;
        if (notification.GroupedNotifications != null)
        {
            groupedNotifications = new List<OneSignalSDK.DotNet.Core.Notifications.Notification>();
            foreach (var individualNotification in notification.GroupedNotifications)
                groupedNotifications.Add(ToNotification(individualNotification));
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

        return new OneSignalSDK.DotNet.Core.Notifications.Notification(
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

    public static OneSignalSDK.DotNet.Core.Notifications.NotificationClickResult ToNotificationClickResult(Com.OneSignal.Android.Notifications.INotificationClickResult result)
    {
        return new NotificationClickResult(
            actionId: result.ActionId,
            url: result.Url
        );
    }

    public static InAppMessage ToInAppMessage(Com.OneSignal.Android.InAppMessages.IInAppMessage inAppMessage)
    {
        return new InAppMessage(
           messageId: inAppMessage.MessageId
        );
    }

    public static InAppMessageClickResult ToInAppMessageClickResult(Com.OneSignal.Android.InAppMessages.IInAppMessageClickResult clickResult)
    {
        return new InAppMessageClickResult(
            actionId: clickResult.ActionId,
            url: clickResult.Url,
            urlTarget: (InAppMessageActionUrlType)clickResult.UrlTarget.Ordinal(),
            closingMessage: clickResult.ClosingMessage
        );
    }
}
