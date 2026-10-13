using System;
using System.Collections.Generic;

namespace OneSignalSDK.DotNet.Core.User
{
    /// <summary>
    /// The result of <see cref="IOneSignal.LoginWithProfileAsync"/>. <see cref="Error"/> is
    /// non-empty whenever <see cref="Success"/> is false.
    /// </summary>
    public class LoginResult
    {
        internal const string UnsupportedPlatformMessage =
            "loginWithProfile is only supported on Android";

        public bool Success { get; }

        public LoginData? Data { get; }

        public IReadOnlyList<OneSignalError>? Error { get; }

        public LoginResult(bool success, LoginData? data, IReadOnlyList<OneSignalError>? error)
        {
            Success = success;
            Data = data;
            Error = error;
        }

        internal static LoginResult Failure(string code, string message)
        {
            return new LoginResult(
                false,
                null,
                new[] { new OneSignalError(code, "CLIENT", null, null, message, null) }
            );
        }

        internal static LoginResult FromMap(object? value)
        {
            if (!(value is IDictionary<string, object> map))
                return Malformed("result is not an object");
            if (!(Get(map, "success") is bool success))
                return Malformed("success is missing");

            if (success)
            {
                var data = LoginData.FromMap(Get(map, "data"));
                return data == null
                    ? Malformed("data is missing")
                    : new LoginResult(true, data, null);
            }

            var errors = new List<OneSignalError>();
            if (Get(map, "error") is IList<object> entries)
            {
                foreach (var entry in entries)
                {
                    var error = OneSignalError.FromMap(entry);
                    if (error != null)
                        errors.Add(error);
                }
            }
            return errors.Count == 0
                ? Malformed("error is missing")
                : new LoginResult(false, null, errors);
        }

        internal static object? Get(IDictionary<string, object> map, string key)
        {
            return map.TryGetValue(key, out var value) ? value : null;
        }

        private static LoginResult Malformed(string reason)
        {
            return Failure("UNKNOWN", "Malformed loginWithProfile result: " + reason);
        }
    }

    public class LoginData
    {
        public string OneSignalId { get; }

        public string ExternalId { get; }

        public string? EmailSubscriptionId { get; }

        public string? SmsSubscriptionId { get; }

        public LoginData(
            string oneSignalId,
            string externalId,
            string? emailSubscriptionId,
            string? smsSubscriptionId
        )
        {
            OneSignalId = oneSignalId;
            ExternalId = externalId;
            EmailSubscriptionId = emailSubscriptionId;
            SmsSubscriptionId = smsSubscriptionId;
        }

        internal static LoginData? FromMap(object? value)
        {
            if (!(value is IDictionary<string, object> map))
                return null;
            if (!(LoginResult.Get(map, "onesignalId") is string oneSignalId))
                return null;
            if (!(LoginResult.Get(map, "externalId") is string externalId))
                return null;
            return new LoginData(
                oneSignalId,
                externalId,
                LoginResult.Get(map, "emailSubscriptionId") as string,
                LoginResult.Get(map, "smsSubscriptionId") as string
            );
        }
    }

    public class OneSignalError
    {
        /// <summary>
        /// One of BACKEND_ERROR, INVALID_ARGUMENT, NOT_INITIALIZED, STORAGE_LOCKED, UNKNOWN.
        /// </summary>
        public string Code { get; }

        /// <summary>
        /// CLIENT or BACKEND.
        /// </summary>
        public string Source { get; }

        public string? BackendCode { get; }

        public int? HttpStatus { get; }

        public string Message { get; }

        public IDictionary<string, object>? Meta { get; }

        public OneSignalError(
            string code,
            string source,
            string? backendCode,
            int? httpStatus,
            string message,
            IDictionary<string, object>? meta
        )
        {
            Code = code;
            Source = source;
            BackendCode = backendCode;
            HttpStatus = httpStatus;
            Message = message;
            Meta = meta;
        }

        internal static OneSignalError? FromMap(object? value)
        {
            if (!(value is IDictionary<string, object> map))
                return null;
            if (!(LoginResult.Get(map, "code") is string code))
                return null;
            if (!(LoginResult.Get(map, "source") is string source))
                return null;
            if (!(LoginResult.Get(map, "message") is string message))
                return null;
            return new OneSignalError(
                code,
                source,
                LoginResult.Get(map, "backendCode") as string,
                ToInt(LoginResult.Get(map, "httpStatus")),
                message,
                LoginResult.Get(map, "meta") as IDictionary<string, object>
            );
        }

        private static int? ToInt(object? value)
        {
            switch (value)
            {
                case int i:
                    return i;
                case long l when l >= int.MinValue && l <= int.MaxValue:
                    return (int)l;
                case double d when d >= int.MinValue && d <= int.MaxValue && Math.Floor(d) == d:
                    return (int)d;
                default:
                    return null;
            }
        }
    }
}
