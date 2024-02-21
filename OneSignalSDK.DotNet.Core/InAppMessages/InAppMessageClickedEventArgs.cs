using System;

namespace OneSignalSDK.DotNet.Core.InAppMessages
{
    /// <summary>
    /// The <see cref="EventArgs"/> for the <see cref="IInAppMessagesManager.Clicked"/> event.
    /// </summary>
    public sealed class InAppMessageClickedEventArgs : EventArgs
    {
        /// <summary>
        /// The message that has raised the lifecycle event.
        /// </summary>
        public InAppMessage Message { get; }

        /// <summary>
        /// The action that was taken due to the click.
        /// </summary>
        public InAppMessageClickResult Result { get; }

        public InAppMessageClickedEventArgs(InAppMessage message, InAppMessageClickResult result)
        {
            Message = message;
            Result = result;
        }
    }
}
