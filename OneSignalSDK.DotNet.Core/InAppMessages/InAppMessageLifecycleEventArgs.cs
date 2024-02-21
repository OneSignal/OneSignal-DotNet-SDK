using System;

namespace OneSignalSDK.DotNet.Core.InAppMessages
{
    /// <summary>
    /// The <see cref="EventArgs"/> for the In App Message Will Display lifecycle event:
    /// * <see cref="IInAppMessagesManager.WillDisplay"/>
    /// </summary>
    public sealed class InAppMessageWillDisplayEventArgs : EventArgs
    {
        /// <summary>
        /// The message that has raised the lifecycle event.
        /// </summary>
        public InAppMessage Message { get; }

        public InAppMessageWillDisplayEventArgs(InAppMessage message)
        {
            Message = message;
        }
    }

    /// <summary>
    /// The <see cref="EventArgs"/> for the In App Message Did Display lifecycle event:
    /// * <see cref="IInAppMessagesManager.DidDisplay"/>
    /// </summary>
    public sealed class InAppMessageDidDisplayEventArgs : EventArgs
    {
        /// <summary>
        /// The message that has raised the lifecycle event.
        /// </summary>
        public InAppMessage Message { get; }

        public InAppMessageDidDisplayEventArgs(InAppMessage message)
        {
            Message = message;
        }
    }

    /// <summary>
    /// The <see cref="EventArgs"/> for the In App Message Will Dismiss lifecycle event:
    /// * <see cref="IInAppMessagesManager.WillDismiss"/>
    /// </summary>
    public sealed class InAppMessageWillDismissEventArgs : EventArgs
    {
        /// <summary>
        /// The message that has raised the lifecycle event.
        /// </summary>
        public InAppMessage Message { get; }

        public InAppMessageWillDismissEventArgs(InAppMessage message)
        {
            Message = message;
        }
    }

    /// <summary>
    /// The <see cref="EventArgs"/> for the In App Message Did Dismiss lifecycle event:
    /// * <see cref="IInAppMessagesManager.DidDismiss"/>
    /// </summary>
    public sealed class InAppMessageDidDismissEventArgs : EventArgs
    {
        /// <summary>
        /// The message that has raised the lifecycle event.
        /// </summary>
        public InAppMessage Message { get; }

        public InAppMessageDidDismissEventArgs(InAppMessage message)
        {
            Message = message;
        }
    }
}