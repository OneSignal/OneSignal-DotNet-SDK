using System.Collections.Generic;

namespace OneSignalSDK.DotNet.Core.User
{
    /// <summary>
    /// User properties applied as part of <see cref="IOneSignal.LoginWithProfileAsync"/>.
    /// </summary>
    public class OneSignalUserProfile
    {
        public string? Email { get; }

        public string? Sms { get; }

        public IDictionary<string, string>? Tags { get; }

        public IDictionary<string, string>? Aliases { get; }

        public OneSignalUserProfile(
            string? email = null,
            string? sms = null,
            IDictionary<string, string>? tags = null,
            IDictionary<string, string>? aliases = null
        )
        {
            Email = email;
            Sms = sms;
            Tags = tags;
            Aliases = aliases;
        }
    }
}
