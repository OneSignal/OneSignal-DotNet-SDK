using System.Reflection.Emit;
using Com.OneSignal.iOS;
using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.User;
using OneSignalSDK.DotNet.Core.User.Subscriptions;
using OneSignalSDK.DotNet.iOS.Utilities;
using static OneSignalSDK.DotNet.iOS.iOSPushSubscription;
using OneSignalNative = Com.OneSignal.iOS.OneSignal;

namespace OneSignalSDK.DotNet.iOS
{
    public class iOSUserManager : IUserManager
    {
        public string Language
        {
            set => OneSignalNative.User.SetLanguage(value);
        }

        public IPushSubscription PushSubscription { get; } = new iOSPushSubscription();

        private InternalUserChangedHandler _userChangedHandler;

        public void Initialize()
        {
            _userChangedHandler = new InternalUserChangedHandler(this);
            OneSignalNative.User.AddObserver(_userChangedHandler);
            ((iOSPushSubscription)PushSubscription).Initialize();
        }

        public string OneSignalId 
        {
            get => OneSignalNative.User.OnesignalId;
        }

        public string ExternalId 
        {
            get => OneSignalNative.User.ExternalId;
        }
        public event EventHandler<UserStateChangedEventArgs>? Changed;

        public void AddAlias(string label, string id) => OneSignalNative.User.AddAliasWithLabel(label, id);
        public void AddAliases(IDictionary<string, string> aliases) => OneSignalNative.User.AddAliases(NativeConversion.DictToNSDict(aliases));
        public void RemoveAlias(string label) => OneSignalNative.User.RemoveAlias(label);
        public void RemoveAliases(params string[] labels) => OneSignalNative.User.RemoveAliases(labels);

        public void AddEmail(string email) => OneSignalNative.User.AddEmail(email);
        public void RemoveEmail(string email) => OneSignalNative.User.RemoveEmail(email);

        public void AddSms(string sms) => OneSignalNative.User.AddSms(sms);
        public void RemoveSms(string sms) => OneSignalNative.User.RemoveSms(sms);

        public void AddTag(string key, string value) => OneSignalNative.User.AddTagWithKey(key, value);
        public void AddTags(IDictionary<string, string> tags) => OneSignalNative.User.AddTags(NativeConversion.DictToNSDict(tags));
        public void RemoveTag(string key) => OneSignalNative.User.RemoveTag(key);
        public void RemoveTags(params string[] keys) => OneSignalNative.User.RemoveTags(keys);
        public IDictionary<string, string> GetTags() => FromNativeConversion.NSDictToPureStringDict(OneSignalNative.User.GetTags());

        public void TrackEvent(string name, IDictionary<string, object>? properties = null)
        {
            OneSignalNative.User.TrackEventWithName(name, properties == null ? null : NativeConversion.DictToNSDict(properties));
        }

        private sealed class InternalUserState : IUserState
        {
            public string OneSignalId { get; }

            public string ExternalId { get; }

            public InternalUserState(string onesignalId, string externalId)
            {
                OneSignalId = onesignalId;
                ExternalId = externalId;
            }
        }

        private class InternalUserChangedHandler : Com.OneSignal.iOS.OSUserStateObserver
        {
            private iOSUserManager _manager;
            public InternalUserChangedHandler(iOSUserManager manager)
            {
                _manager = manager;
            }

            public override void OnUserStateDidChangeWithState(OSUserChangedState state)
            {
                var current = new InternalUserState(state.Current.OnesignalId, state.Current.ExternalId);
                var userChangedState = new UserChangedState(current);
                _manager.Changed?.Invoke(_manager, new UserStateChangedEventArgs(userChangedState));
            }
        }
    }

    public class iOSPushSubscription : IPushSubscription
    {
        public string Token => OneSignalNative.User.PushSubscription.Token;

        public bool OptedIn => OneSignalNative.User.PushSubscription.OptedIn;

        public string Id => OneSignalNative.User.PushSubscription.Id;

        public event EventHandler<PushSubscriptionChangedEventArgs>? Changed;

        private InternalPushSubscriptionChangedHandler? _pushSubscriptionChangedHandler;

        public void Initialize()
        {
            _pushSubscriptionChangedHandler = new InternalPushSubscriptionChangedHandler(this);
            OneSignalNative.User.PushSubscription.AddObserver(_pushSubscriptionChangedHandler);
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
            public string Id { get; }

            public string Token { get; }

            public bool OptedIn { get; }


            public InternalPushSubscriptionState(string token, bool optedIn, string id)
            {
                Token = token;
                OptedIn = optedIn;
                Id = id;
            }
        }

        private sealed class InternalPushSubscriptionChangedHandler : Com.OneSignal.iOS.OSPushSubscriptionObserver
        {
            private iOSPushSubscription _manager;
            public InternalPushSubscriptionChangedHandler(iOSPushSubscription manager)
            {
                _manager = manager;
            }

            public override void OnPushSubscriptionDidChangeWithState(OSPushSubscriptionChangedState state)
            {
                var previous = new InternalPushSubscriptionState(state.Previous.Token, state.Previous.OptedIn, state.Previous.Id);
                var current = new InternalPushSubscriptionState(state.Current.Token, state.Current.OptedIn, state.Current.Id);
                var changedState = new PushSubscriptionChangedState(previous, current);
                _manager.Changed?.Invoke(_manager, new PushSubscriptionChangedEventArgs(changedState));
            }
        }
    }
}
