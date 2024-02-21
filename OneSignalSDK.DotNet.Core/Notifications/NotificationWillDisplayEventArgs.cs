using System;
using static System.Net.Mime.MediaTypeNames;

namespace OneSignalSDK.DotNet.Core.Notifications
{
    /// <summary>
    /// The <see cref="EventArgs"/> for the <see cref="INotificationsManager.WillDisplay"/> event.
    /// </summary>
    public abstract class NotificationWillDisplayEventArgs : EventArgs
    {
        /// <summary>
        /// The notification received by the app.
        /// </summary>
        public DisplayableNotification Notification { get; }

        public NotificationWillDisplayEventArgs(DisplayableNotification notification)
        {
            Notification = notification;
        }

        public abstract void PreventDefault();
    }
}