using System;

namespace OneSignalSDK.DotNet.Core.Notifications
{
    /// <summary>
    /// The result of a click a user has taken when opening a notification.
    /// </summary>
    public class NotificationClickResult
    {
        public string ActionId { get; }

        public string Url { get; }

        public NotificationClickResult(string actionId, string url)
        {
            ActionId = actionId;
            Url = url;
        }
    }
}
