using System;

namespace OneSignalSDK.DotNet.Core.User.Subscriptions
{
    /// <summary>
    /// A subscription.
    /// </summary>
    public interface IPushSubscriptionState
    {
        /// <summary>
        /// The unique identifier for this subscription. This will be an empty string
        /// until the subscription has been successfully created on the backend and
        /// assigned an ID.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// The token which identifies the device/app that notifications are to be sent. May
        /// be an empty string, indicating the push token has not yet been retrieved.
        /// </summary>
        string Token { get; }

        /// <summary>
        /// Whether the user of this subscription is opted-in to received notifications. When true,
        /// the user is able to receive notifications through this subscription.Otherwise, the
        /// user will not receive notifications through this subscription (even when the user has
        /// granted app permission).
        /// </summary>
        bool OptedIn { get; }
    }
}
