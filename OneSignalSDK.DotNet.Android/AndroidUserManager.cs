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
                    global::System.Diagnostics.Debug.WriteLine("OneSignal: setLanguage: language is required");
                    return;
                }
                OneSignalNative.User.SetLanguage(value);
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
                string? id = OneSignalNative.User.OnesignalId;
                return string.IsNullOrEmpty(id) ? null : id;
            }
        }

        public string? ExternalId
        {
            get
            {
                string? id = OneSignalNative.User.ExternalId;
                return string.IsNullOrEmpty(id) ? null : id;
            }
        }

        public event EventHandler<UserStateChangedEventArgs>? Changed;

        public void AddAlias(string label, string id)
        {
            if (InputGuard.Missing(label, "addAlias: label") || InputGuard.Missing(id, "addAlias: id")) return;
            OneSignalNative.User.AddAlias(label, id);
        }

        public void AddAliases(IDictionary<string, string> aliases)
        {
            if (InputGuard.MissingEntries(aliases, "addAliases", false)) return;
            OneSignalNative.User.AddAliases(aliases);
        }

        public void RemoveAlias(string label)
        {
            if (InputGuard.Missing(label, "removeAlias: label")) return;
            OneSignalNative.User.RemoveAlias(label);
        }

        public void RemoveAliases(params string[] labels)
        {
            if (InputGuard.MissingAny(labels, "removeAliases: label")) return;
            OneSignalNative.User.RemoveAliases(labels);
        }

        public void AddEmail(string email)
        {
            if (InputGuard.Missing(email, "addEmail: email")) return;
            OneSignalNative.User.AddEmail(email);
        }

        public void RemoveEmail(string email)
        {
            if (InputGuard.Missing(email, "removeEmail: email")) return;
            OneSignalNative.User.RemoveEmail(email);
        }

        public void AddSms(string sms)
        {
            if (InputGuard.Missing(sms, "addSms: sms")) return;
            OneSignalNative.User.AddSms(sms);
        }

        public void RemoveSms(string sms)
        {
            if (InputGuard.Missing(sms, "removeSms: sms")) return;
            OneSignalNative.User.RemoveSms(sms);
        }

        public void AddTag(string key, string value)
        {
            if (InputGuard.Missing(key, "addTag: key")) return;
            if (value == null)
            {
                System.Diagnostics.Debug.WriteLine("OneSignal: addTag: value is required");
                return;
            }
            OneSignalNative.User.AddTag(key, value);
        }

        public void AddTags(IDictionary<string, string> tags)
        {
            if (InputGuard.MissingEntries(tags, "addTags", true)) return;
            OneSignalNative.User.AddTags(tags);
        }

        public void RemoveTag(string key)
        {
            if (InputGuard.Missing(key, "removeTag: key")) return;
            OneSignalNative.User.RemoveTag(key);
        }

        public void RemoveTags(params string[] keys)
        {
            if (InputGuard.MissingAny(keys, "removeTags: key")) return;
            OneSignalNative.User.RemoveTags(keys);
        }

        public IDictionary<string, string>? GetTags() => OneSignalNative.User.Tags;

        public void TrackEvent(string name, IDictionary<string, object>? properties = null)
        {
            if (InputGuard.Missing(name, "trackEvent: name")) return;
            OneSignalNative.User.TrackEvent(name, ToNativeConversion.DictToJavaMap(properties)!);
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
        public string? Token => OneSignalNative.User.PushSubscription.Token;

        public bool OptedIn => OneSignalNative.User.PushSubscription.OptedIn;

        public string? Id => OneSignalNative.User.PushSubscription.Id;

        public event EventHandler<PushSubscriptionChangedEventArgs>? Changed;

        private InternalSubscriptionChangedHandler? _subscriptionChangedHandler;

        public void Initialize()
        {
            _subscriptionChangedHandler = new InternalSubscriptionChangedHandler(this);
            OneSignalNative.User.PushSubscription.AddObserver(_subscriptionChangedHandler);
        }

        public void OptIn()
        {
            OneSignalNative.User.PushSubscription.OptIn();
        }

        public void OptOut()
        {
            OneSignalNative.User.PushSubscription.OptOut();
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
