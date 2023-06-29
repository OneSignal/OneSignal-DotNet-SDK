using System;

namespace OneSignalSDK.DotNet.Core.Notifications
{
    /// <summary>
    /// The <see cref="EventArgs"/> for the <see cref="INotificationsManager.Clicked"/> event.
    /// </summary>
    public sealed class NotificationClickedEventArgs : EventArgs
    {
        /// <summary>
        /// The notification that was clicked on.
        /// </summary>
        public Notification Notification { get; }

        /// <summary>
        /// The action that was taken on the notification.
        /// </summary>
        public NotificationClickResult Result { get; }

        public NotificationClickedEventArgs(Notification notification, NotificationClickResult result)
        {
            Notification = notification;
            Result = result;
        }
    }
}