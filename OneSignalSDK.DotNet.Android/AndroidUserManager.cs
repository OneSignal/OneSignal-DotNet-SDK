using System.Reflection.Emit;
using OneSignalSDK.DotNet.Android.Utilities;
using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.User;
using OneSignalSDK.DotNet.Core.User.Subscriptions;
using OneSignalNative = Com.OneSignal.Android.OneSignal;

namespace OneSignalSDK.DotNet.Android
{
    public class AndroidUserManager : IUserManager
    {
        public string Language
        {
            set
            {
                // Empty string is the reset to the device language. Null is not.
                if (value == null)
                {
                    global::System.Diagnostics.Debug.WriteLine(
                        "OneSignal: setLanguage: language is required"
                    );
                    return;
                }
                AndroidInit
                    .Require("user.language", () => OneSignalNative.User)
                    ?.SetLanguage(value);
            }
        }

        public IPushSubscription PushSubscription { get; } = new AndroidPushSubscription();

        private InternalUserChangedHandler? _userChangedHandler;

        public void Initialize()
        {
            if (AndroidInit.Reject("user"))
                return;
            _userChangedHandler = new InternalUserChangedHandler(this);
            OneSignalNative.User.AddObserver(_userChangedHandler);
            ((AndroidPushSubscription)PushSubscription).Initialize();
        }

        public string? OneSignalId
        {
            get
            {
                string? id = AndroidInit
                    .Require("user.oneSignalId", () => OneSignalNative.User)
                    ?.OnesignalId;
                return string.IsNullOrEmpty(id) ? null : id;
            }
        }

        public string? ExternalId
        {
            get
            {
                string? id = AndroidInit
                    .Require("user.externalId", () => OneSignalNative.User)
                    ?.ExternalId;
                return string.IsNullOrEmpty(id) ? null : id;
            }
        }

        public event EventHandler<UserStateChangedEventArgs>? Changed;

        public void AddAlias(string label, string id)
        {
            if (
                InputGuard.IsMissing(label, "addAlias: label")
                || InputGuard.IsMissing(id, "addAlias: id")
            )
                return;
            AndroidInit.Require("addAlias", () => OneSignalNative.User)?.AddAlias(label, id);
        }

        public void AddAliases(IDictionary<string, string> aliases)
        {
            if (InputGuard.HasMissingEntries(aliases, "addAliases", false))
                return;
            AndroidInit.Require("addAliases", () => OneSignalNative.User)?.AddAliases(aliases);
        }

        public void RemoveAlias(string label)
        {
            if (InputGuard.IsMissing(label, "removeAlias: label"))
                return;
            AndroidInit.Require("removeAlias", () => OneSignalNative.User)?.RemoveAlias(label);
        }

        public void RemoveAliases(params string[] labels)
        {
            if (InputGuard.IsMissingAny(labels, "removeAliases: label"))
                return;
            AndroidInit.Require("removeAliases", () => OneSignalNative.User)?.RemoveAliases(labels);
        }

        public void AddEmail(string email)
        {
            if (InputGuard.IsMissing(email, "addEmail: email"))
                return;
            AndroidInit.Require("addEmail", () => OneSignalNative.User)?.AddEmail(email);
        }

        public void RemoveEmail(string email)
        {
            if (InputGuard.IsMissing(email, "removeEmail: email"))
                return;
            AndroidInit.Require("removeEmail", () => OneSignalNative.User)?.RemoveEmail(email);
        }

        public void AddSms(string sms)
        {
            if (InputGuard.IsMissing(sms, "addSms: sms"))
                return;
            AndroidInit.Require("addSms", () => OneSignalNative.User)?.AddSms(sms);
        }

        public void RemoveSms(string sms)
        {
            if (InputGuard.IsMissing(sms, "removeSms: sms"))
                return;
            AndroidInit.Require("removeSms", () => OneSignalNative.User)?.RemoveSms(sms);
        }

        public void AddTag(string key, string value)
        {
            if (InputGuard.IsMissing(key, "addTag: key"))
                return;
            if (value == null)
            {
                System.Diagnostics.Debug.WriteLine("OneSignal: addTag: value is required");
                return;
            }
            AndroidInit.Require("addTag", () => OneSignalNative.User)?.AddTag(key, value);
        }

        public void AddTags(IDictionary<string, string> tags)
        {
            if (InputGuard.HasMissingEntries(tags, "addTags", true))
                return;
            AndroidInit.Require("addTags", () => OneSignalNative.User)?.AddTags(tags);
        }

        public void RemoveTag(string key)
        {
            if (InputGuard.IsMissing(key, "removeTag: key"))
                return;
            AndroidInit.Require("removeTag", () => OneSignalNative.User)?.RemoveTag(key);
        }

        public void RemoveTags(params string[] keys)
        {
            if (InputGuard.IsMissingAny(keys, "removeTags: key"))
                return;
            AndroidInit.Require("removeTags", () => OneSignalNative.User)?.RemoveTags(keys);
        }

        public IDictionary<string, string>? GetTags() =>
            AndroidInit.Require("getTags", () => OneSignalNative.User)?.Tags;

        public void TrackEvent(string name, IDictionary<string, object>? properties = null)
        {
            if (InputGuard.IsMissing(name, "trackEvent: name"))
                return;
            AndroidInit
                .Require("trackEvent", () => OneSignalNative.User)
                ?.TrackEvent(
                    name,
                    ToNativeConversion.DictToJavaMap(
                        InputGuard.ReplaceNonFiniteNumbers(properties)
                    )!
                );
        }

        private sealed class InternalUserState : IUserState
        {
            public string? OneSignalId { get; }

            public string? ExternalId { get; }

            public InternalUserState(string? onesignalId, string? externalId)
            {
                OneSignalId = onesignalId;
                ExternalId = externalId;
            }
        }

        private class InternalUserChangedHandler
            : Java.Lang.Object,
                Com.OneSignal.Android.User.State.IUserStateObserver
        {
            private AndroidUserManager _manager;

            public InternalUserChangedHandler(AndroidUserManager manager)
            {
                _manager = manager;
            }

            public void OnUserStateChange(Com.OneSignal.Android.User.State.UserChangedState state)
            {
                var current = new InternalUserState(
                    state.Current.OnesignalId,
                    state.Current.ExternalId
                );
                var userChangedState = new UserChangedState(current);
                _manager.Changed?.Invoke(_manager, new UserStateChangedEventArgs(userChangedState));
            }
        }
    }

    public class AndroidPushSubscription : IPushSubscription
    {
        public string? Token =>
            AndroidInit
                .Require("pushSubscription.token", () => OneSignalNative.User)
                ?.PushSubscription.Token;

        public bool OptedIn =>
            AndroidInit
                .Require("pushSubscription.optedIn", () => OneSignalNative.User)
                ?.PushSubscription.OptedIn
            ?? false;

        public string? Id =>
            AndroidInit
                .Require("pushSubscription.id", () => OneSignalNative.User)
                ?.PushSubscription.Id;

        public event EventHandler<PushSubscriptionChangedEventArgs>? Changed;

        private InternalSubscriptionChangedHandler? _subscriptionChangedHandler;

        public void Initialize()
        {
            if (AndroidInit.Reject("pushSubscription"))
                return;
            _subscriptionChangedHandler = new InternalSubscriptionChangedHandler(this);
            OneSignalNative.User.PushSubscription.AddObserver(_subscriptionChangedHandler);
        }

        public void OptIn()
        {
            AndroidInit.Require("optIn", () => OneSignalNative.User)?.PushSubscription.OptIn();
        }

        public void OptOut()
        {
            AndroidInit.Require("optOut", () => OneSignalNative.User)?.PushSubscription.OptOut();
        }

        private sealed class InternalPushSubscriptionState : IPushSubscriptionState
        {
            public string? Id { get; }

            public string? Token { get; }

            public bool OptedIn { get; }

            public InternalPushSubscriptionState(string? token, bool optedIn, string? id)
            {
                Token = token;
                OptedIn = optedIn;
                Id = id;
            }
        }

        private class InternalSubscriptionChangedHandler
            : Java.Lang.Object,
                Com.OneSignal.Android.User.Subscriptions.IPushSubscriptionObserver
        {
            private AndroidPushSubscription _manager;

            public InternalSubscriptionChangedHandler(AndroidPushSubscription manager)
            {
                _manager = manager;
            }

            public void OnPushSubscriptionChange(
                Com.OneSignal.Android.User.Subscriptions.PushSubscriptionChangedState state
            )
            {
                var previous = new InternalPushSubscriptionState(
                    state.Previous.Token,
                    state.Previous.OptedIn,
                    state.Previous.Id
                );
                var current = new InternalPushSubscriptionState(
                    state.Current.Token,
                    state.Current.OptedIn,
                    state.Current.Id
                );
                var changedState = new PushSubscriptionChangedState(previous, current);
                _manager.Changed?.Invoke(
                    _manager,
                    new PushSubscriptionChangedEventArgs(changedState)
                );
            }
        }
    }
}
