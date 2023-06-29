using System;

namespace OneSignalSDK.DotNet.Core.User.Subscriptions
{
    /// <summary>
    /// The <see cref="EventArgs"/> for the <see cref="ISubscription.Changed"/> event.
    /// </summary>
    public sealed class PushSubscriptionChangedEventArgs : EventArgs
    {
        /// <summary>
        /// The subscription that has changed, in its new state.
        /// </summary>
        public PushSubscriptionChangedState State { get; }

        public PushSubscriptionChangedEventArgs(PushSubscriptionChangedState state)
        {
            State = state;
        }
    }

    public sealed class PushSubscriptionChangedState
    {
        /// <summary>
        /// The push subscription state prior to being changed.
        /// </summary>
        public IPushSubscriptionState Previous { get; }

        /// <summary>
        /// The push subscription state after being changed.
        /// </summary>
        public IPushSubscriptionState Current { get; }

        public PushSubscriptionChangedState(IPushSubscriptionState previous, IPushSubscriptionState current)
        {
            Previous = previous;
            Current = current;
        }
    }
}
