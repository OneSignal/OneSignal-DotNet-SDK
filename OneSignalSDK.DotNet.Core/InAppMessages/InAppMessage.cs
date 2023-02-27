using System;

namespace OneSignalSDK.DotNet.Core.InAppMessages
{
    public class InAppMessage
    {
        /// <summary>
        /// The unique identifier for this in-app message
        /// </summary>
        public string MessageId { get; }

        public InAppMessage(string messageId)
        {
            MessageId = messageId;
        }
    }
}