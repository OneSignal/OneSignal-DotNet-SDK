using System.Collections.Generic;
using Foundation;
using HomeKit;
using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.InAppMessages;
using OneSignalSDK.DotNet.Core.Notifications;
using OneSignalSDK.DotNet.Core.Internal.Utilities;
using OneSignaliOS = Com.OneSignal.iOS;

namespace OneSignalSDK.DotNet.iOS.Utilities;

/// <summary>
/// Translation functions when translating from native SDK class types to their respective .NET SDK class types.
/// </summary>
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
                    actionButtonsXam.Add(new ActionButton(
                        id: actionButtonXam.GetValueOrDefault("id"),
                        text: actionButtonXam.GetValueOrDefault("text"),
                        icon: actionButtonXam.GetValueOrDefault("icon")
                    ));
                }
            }
        }

        return new Notification(
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

    public static NotificationClickResult ToNotificationClickResult(OneSignaliOS.OSNotificationClickResult result)
    {
        return new NotificationClickResult(
            actionId: result.ActionId,
            url: result.Url
        );
    }

    public static InAppMessageClickResult ToInAppMessageClickResult(OneSignaliOS.OSInAppMessageClickResult inAppMessageClickResult)
    {
        long urlTarget = (long)inAppMessageClickResult.UrlTarget;
        return new InAppMessageClickResult(
            actionId: inAppMessageClickResult.ActionId,
            url: inAppMessageClickResult.Url,
            urlTarget: (InAppMessageActionUrlType)urlTarget,
            closingMessage: inAppMessageClickResult.ClosingMessage
        );
    }

    public static InAppMessage ToInAppMessage(OneSignaliOS.OSInAppMessage inAppMessage)
    {
        return new InAppMessage(
            messageId: inAppMessage.MessageId
        );
    }
}
