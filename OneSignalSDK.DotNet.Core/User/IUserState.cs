using System;

namespace OneSignalSDK.DotNet.Core.User 
{
    public interface IUserState {
        /// <summary>
        /// The unique identifier for your OneSignal account. This will be an empty string until the
        /// user has been successfully logged in on the backend and assigned an ID.
        /// Use [Changed] to be notified when the [OneSignalId] has been successfully assigned.
        /// </summary>
        string OneSignalId { get; }

        /// <summary>
        /// The external identifier that you use to identify users. Use [Changed] to be notified
        /// when the [ExternalId] has been successfully assigned. This will be an empty string if no
        /// external identifier has been assigned to the associated [OneSignalId].
        /// </summary>
        string ExternalId { get; }
    }
}