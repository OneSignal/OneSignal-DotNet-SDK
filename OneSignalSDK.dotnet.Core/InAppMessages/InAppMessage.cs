using System;

namespace OneSignalSDK.DotNet.Core.InAppMessages; 

public record InAppMessage
{
    /// <summary>
    /// The unique identifier for this in-app message
    /// </summary>
    public string MessageId { get; init; } = "";
}
