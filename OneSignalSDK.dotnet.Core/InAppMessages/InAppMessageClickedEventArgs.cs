using System;

namespace OneSignalSDK.DotNet.Core.InAppMessages;

/// <summary>
/// The <see cref="EventArgs"/> for the <see cref="IInAppMessagesManager.Clicked"/> event.
/// </summary>
public sealed class InAppMessageClickedEventArgs : EventArgs
{
    /// <summary>
    /// The message that has been clicked.
    /// </summary>
    public InAppMessage Message { get; }

    /// <summary>
    /// The action that was taken due to the click.
    /// </summary>
    public InAppMessageAction Action { get; }

    public InAppMessageClickedEventArgs(InAppMessage message, InAppMessageAction action)
    {
        Message = message;
        Action = action;
    }
}
