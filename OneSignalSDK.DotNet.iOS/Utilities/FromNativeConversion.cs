using System.Collections.Generic;
using Foundation;
using HomeKit;
using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.InAppMessages;
using OneSignalSDK.DotNet.Core.Notifications;
using OneSignalSDK.DotNet.Core.Utilities;
using OneSignaliOS = Com.OneSignal.iOS;

namespace OneSignalSDK.DotNet.iOS.Utilities;

public static class FromNativeConversion
{
    public static Dictionary<string, string> NSObjectToPureDict(NSObject nSObject)
    {
        if (nSObject == null)
            return null;
        NSError error;
        NSData jsonData = NSJsonSerialization.Serialize(nSObject, 0, out error);
        NSString jsonNSString = NSString.FromData(jsonData, NSStringEncoding.UTF8);
        string jsonString = jsonNSString.ToString();
        return Json.Deserialize(jsonString) as Dictionary<string, string>;
    }

    public static Dictionary<string, object> NSDictToPureDict(NSDictionary nsDict)
    {
        if (nsDict == null)
            return null;
        NSError error;
        NSData jsonData = NSJsonSerialization.Serialize(nsDict, 0, out error);
        NSString jsonNSString = NSString.FromData(jsonData, NSStringEncoding.UTF8);
        string jsonString = jsonNSString.ToString();
        return Json.Deserialize(jsonString) as Dictionary<string, object>;
    }

    public static Notification ToNotification(OneSignaliOS.OSNotification notification)
    {
        Dictionary<string, object> additionalDataXam = new Dictionary<string, object>();
        if (notification.AdditionalData != null)
        {
            additionalDataXam = NSDictToPureDict(notification.AdditionalData);
        }

        List<ActionButton> actionButtonsXam = new List<ActionButton>();
        if (notification.ActionButtons != null)
        {
            foreach (NSObject actionButton in notification.ActionButtons)
            {
                Dictionary<string, string> actionButtonXam = NSObjectToPureDict(actionButton);
                if (actionButtonXam != null)
                {
                    actionButtonsXam.Add(new ActionButton
                    {
                        Id = actionButtonXam.GetValueOrDefault("id"),
                        Text = actionButtonXam.GetValueOrDefault("text"),
                        Icon = actionButtonXam.GetValueOrDefault("icon")
                    });
                }
            }
        }

        return new Notification
        {
            NotificationId = notification.NotificationId,
            TemplateName = notification.TemplateName,
            TemplateId = notification.TemplateId,
            Title = notification.Title,
            Body = notification.Body,
            AdditionalData = additionalDataXam,
            LaunchUrl = notification.LaunchURL,
            Sound = notification.Sound,
            RelevanceScore = notification.RelevanceScore != null ? (float)notification.RelevanceScore : 0,
            Badge = notification.Badge.ToString(),
            BadgeIncrement = notification.BadgeIncrement.ToString(),
            ActionButtons = actionButtonsXam,
            Category = notification.Category,
            ThreadId = notification.ThreadId,
            Subtitle = notification.Subtitle,
            MutableContent = notification.MutableContent,
            ContentAvailable = notification.ContentAvailable,
            InterruptionLevel = notification.InterruptionLevel
        };
    }

    public static NotificationAction ToNotificationAction(OneSignaliOS.OSNotificationAction notificationAction)
    {
        return new NotificationAction
        {
            ActionId = notificationAction.ActionId,
            Type = (NotificationActionType)notificationAction.Type
        };
    }

    public static InAppMessageAction ToInAppMessageAction(OneSignaliOS.OSInAppMessageAction inAppMessageAction)
    {
        return new InAppMessageAction
        {
            ClickName = inAppMessageAction.ClickName,
            ClickUrl = inAppMessageAction.ClickUrl?.AbsoluteString,
            ClosesMessage = inAppMessageAction.ClosesMessage,
            IsFirstClick = inAppMessageAction.FirstClick
        };
    }

    public static InAppMessage ToInAppMessage(OneSignaliOS.OSInAppMessage inAppMessage)
    {
        return new InAppMessage
        {
            MessageId = inAppMessage.MessageId
        };
    }
}
