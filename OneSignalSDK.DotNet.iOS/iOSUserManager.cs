using System.Reflection.Emit;
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

        public void Initialize()
        {
            ((iOSPushSubscription)PushSubscription).Initialize();
        }

        public void AddAlias(string label, string id) => OneSignalNative.User.AddAliasWithLabel(label, id);
        public void AddAliases(IDictionary<string, string> aliases) => OneSignalNative.User.AddAliases(NativeConversion.DictToNSDict(aliases));
        public void RemoveAlias(string label) => OneSignalNative.User.RemoveAlias(label);

        public void AddEmail(string email) => OneSignalNative.User.AddEmail(email);
        public void RemoveEmail(string email) => OneSignalNative.User.RemoveEmail(email);

        public void AddSms(string sms) => OneSignalNative.User.AddSms(sms);
        public void RemoveSms(string sms) => OneSignalNative.User.RemoveSms(sms);

        public void AddTag(string key, string value) => OneSignalNative.User.AddTagWithKey(key, value);
        public void AddTags(IDictionary<string, string> tags) => OneSignalNative.User.AddTags(NativeConversion.DictToNSDict(tags));
        public void RemoveTag(string key) => OneSignalNative.User.RemoveTag(key);
        public void RemoveTags(params string[] keys) => OneSignalNative.User.RemoveTags(keys);
    }

    public class iOSPushSubscription : IPushSubscription
    {
        public string Token => OneSignalNative.User.PushSubscription.Token;

        public bool OptedIn => OneSignalNative.User.PushSubscription.OptedIn;

        public string Id => OneSignalNative.User.PushSubscription.Id;

        public event EventHandler<SubscriptionChangedEventArgs>? Changed;

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

        private sealed class InternalSubscriptionChangedHandler : Com.OneSignal.iOS.OSPushSubscriptionObserver
        {
            private iOSPushSubscription _manager;
            public InternalSubscriptionChangedHandler(iOSPushSubscription manager)
            {
                _manager = manager;
            }

            public override void OnOSPushSubscriptionChangedWithStateChanges(Com.OneSignal.iOS.OSPushSubscriptionStateChanges subscriptionChanges)
            {
                _manager.Changed?.Invoke(_manager, new SubscriptionChangedEventArgs(_manager));
            }
        }
    }
}
