using System;
using System.Collections.Generic;

namespace OneSignalSDK.DotNet.Core.InAppMessages; 

/// <summary>
/// An IAM action represents an action performed by the user in reaction to an IAM
/// being displayed.
/// </summary>
public record InAppMessageAction
{
    /// <summary>
    /// An optional click name defined for the action element
    /// </summary>
    public string? ClickName { get; init; }

    /// <summary>
    /// An optional URL that opens when the action takes place
    /// </summary>
    public string? ClickUrl { get; init; }

    /// <summary>
    /// Whether this is the first time the user has clicked any action on the In-App Message
    /// </summary>
    public bool IsFirstClick { get; init; }

    /// <summary>
    /// Whether this action will close the In-App Message
    /// </summary>
    public bool ClosesMessage { get; init; }
}
