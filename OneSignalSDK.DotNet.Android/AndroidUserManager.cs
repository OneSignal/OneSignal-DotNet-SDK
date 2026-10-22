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
                NativeCall.Run("setLanguage", () => OneSignalNative.User.SetLanguage(value));
            }
        }

        public IPushSubscription PushSubscription { get; } = new AndroidPushSubscription();

        private InternalUserChangedHandler? _userChangedHandler;

        public void Initialize()
        {
            _userChangedHandler = new InternalUserChangedHandler(this);
            OneSignalNative.User.AddObserver(_userChangedHandler);
            ((AndroidPushSubscription)PushSubscription).Initialize();
        }

        public string? OneSignalId
        {
            get
            {
                string? id = NativeCall.Get<string?>(
                    "oneSignalId",
                    () => OneSignalNative.User.OnesignalId,
                    null
                );
                return string.IsNullOrEmpty(id) ? null : id;
            }
        }

        public string? ExternalId
        {
            get
            {
                string? id = NativeCall.Get<string?>(
                    "externalId",
                    () => OneSignalNative.User.ExternalId,
                    null
                );
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
            NativeCall.Run("addAlias", () => OneSignalNative.User.AddAlias(label, id));
        }

        public void AddAliases(IDictionary<string, string> aliases)
        {
            if (InputGuard.HasMissingEntries(aliases, "addAliases", false))
                return;
            NativeCall.Run("addAliases", () => OneSignalNative.User.AddAliases(aliases));
        }

        public void RemoveAlias(string label)
        {
            if (InputGuard.IsMissing(label, "removeAlias: label"))
                return;
            NativeCall.Run("removeAlias", () => OneSignalNative.User.RemoveAlias(label));
        }

        public void RemoveAliases(params string[] labels)
        {
            if (InputGuard.IsMissingAny(labels, "removeAliases: label"))
                return;
            NativeCall.Run("removeAliases", () => OneSignalNative.User.RemoveAliases(labels));
        }

        public void AddEmail(string email)
        {
            if (InputGuard.IsMissing(email, "addEmail: email"))
                return;
            NativeCall.Run("addEmail", () => OneSignalNative.User.AddEmail(email));
        }

        public void RemoveEmail(string email)
        {
            if (InputGuard.IsMissing(email, "removeEmail: email"))
                return;
            NativeCall.Run("removeEmail", () => OneSignalNative.User.RemoveEmail(email));
        }

        public void AddSms(string sms)
        {
            if (InputGuard.IsMissing(sms, "addSms: sms"))
                return;
            NativeCall.Run("addSms", () => OneSignalNative.User.AddSms(sms));
        }

        public void RemoveSms(string sms)
        {
            if (InputGuard.IsMissing(sms, "removeSms: sms"))
                return;
            NativeCall.Run("removeSms", () => OneSignalNative.User.RemoveSms(sms));
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
            NativeCall.Run("addTag", () => OneSignalNative.User.AddTag(key, value));
        }

        public void AddTags(IDictionary<string, string> tags)
        {
            if (InputGuard.HasMissingEntries(tags, "addTags", true))
                return;
            NativeCall.Run("addTags", () => OneSignalNative.User.AddTags(tags));
        }

        public void RemoveTag(string key)
        {
            if (InputGuard.IsMissing(key, "removeTag: key"))
                return;
            NativeCall.Run("removeTag", () => OneSignalNative.User.RemoveTag(key));
        }

        public void RemoveTags(params string[] keys)
        {
            if (InputGuard.IsMissingAny(keys, "removeTags: key"))
                return;
            NativeCall.Run("removeTags", () => OneSignalNative.User.RemoveTags(keys));
        }

        public IDictionary<string, string>? GetTags() =>
            NativeCall.Get<IDictionary<string, string>?>(
                "getTags",
                () => OneSignalNative.User.Tags,
                null
            );

        public void TrackEvent(string name, IDictionary<string, object>? properties = null)
        {
            if (InputGuard.IsMissing(name, "trackEvent: name"))
                return;
            NativeCall.Run(
                "trackEvent",
                () =>
                    OneSignalNative.User.TrackEvent(
                        name,
                        ToNativeConversion.DictToJavaMap(
                            InputGuard.ReplaceNonFiniteNumbers(properties)
                        )!
                    )
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
            NativeCall.Get<string?>(
                "token",
                () => OneSignalNative.User.PushSubscription.Token,
                null
            );

        public bool OptedIn =>
            NativeCall.Get("optedIn", () => OneSignalNative.User.PushSubscription.OptedIn, false);

        public string? Id =>
            NativeCall.Get<string?>(
                "pushSubscriptionId",
                () => OneSignalNative.User.PushSubscription.Id,
                null
            );

        public event EventHandler<PushSubscriptionChangedEventArgs>? Changed;

        private InternalSubscriptionChangedHandler? _subscriptionChangedHandler;

        public void Initialize()
        {
            _subscriptionChangedHandler = new InternalSubscriptionChangedHandler(this);
            OneSignalNative.User.PushSubscription.AddObserver(_subscriptionChangedHandler);
        }

        public void OptIn()
        {
            NativeCall.Run("optIn", () => OneSignalNative.User.PushSubscription.OptIn());
        }

        public void OptOut()
        {
            NativeCall.Run("optOut", () => OneSignalNative.User.PushSubscription.OptOut());
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
