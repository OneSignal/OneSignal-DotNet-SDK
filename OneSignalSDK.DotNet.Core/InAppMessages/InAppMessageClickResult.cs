using System;
using System.Collections.Generic;

namespace OneSignalSDK.DotNet.Core.InAppMessages
{
    /// <summary>
    /// An IAM action represents an action performed by the user in reaction to an IAM
    /// being displayed.
    /// </summary>
    public class InAppMessageClickResult
    {
        /// <summary>
        /// An optional action id defined for the action element
        /// </summary>
        public string ActionId { get; }

        /// <summary>
        /// An optional URL that opens when the action takes place
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// Optional where the url will be launched
        /// </summary>
        public InAppMessageActionUrlType UrlTarget { get; }

        /// <summary>
        /// Whether this action will close the In-App Message
        /// </summary>
        public bool ClosingMessage { get; }

        public InAppMessageClickResult(string actionId, string url, InAppMessageActionUrlType urlTarget, bool closingMessage)
        {
            ActionId = actionId;
            Url = url;
            UrlTarget = urlTarget;
            ClosingMessage = closingMessage;
        }
    }

    public enum InAppMessageActionUrlType
    {
        Browser,
        InAppWebview,
        ReplaceContent
    }
}