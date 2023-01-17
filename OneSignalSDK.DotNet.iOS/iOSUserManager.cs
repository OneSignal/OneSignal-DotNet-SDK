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
            get => ""; //TODO: iOS does not provide a getter for the language
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

        public void AddEmailSubscription(string email) => OneSignalNative.User.AddEmail(email);
        public void RemoveEmailSubscription(string email) => OneSignalNative.User.RemoveEmail(email);

        public void AddSmsSubscription(string sms) => OneSignalNative.User.AddSmsNumber(sms);
        public void RemoveSmsSubscription(string sms) => OneSignalNative.User.RemoveSmsNumber(sms);

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

        public void Initialize()
        {
            OneSignalNative.User.PushSubscription.AddObserver(new iOSSubscriptionChangedHandler(this));
        }

        public void OptIn()
        {
            OneSignalNative.User.PushSubscription.OptIn();
        }

        public void OptOut()
        {
            OneSignalNative.User.PushSubscription.OptOut();
        }

        public class iOSSubscriptionChangedHandler : Com.OneSignal.iOS.OSPushSubscriptionObserver
        {
            private iOSPushSubscription _manager;
            public iOSSubscriptionChangedHandler(iOSPushSubscription manager)
            {
                _manager = manager;
            }

            public void OnOSPushSubscriptionChangedWithStateChanges(Com.OneSignal.iOS.OSPushSubscriptionStateChanges subscriptionChanges)
            {
                _manager.Changed?.Invoke(_manager, new SubscriptionChangedEventArgs(_manager));
            }
        }
    }
}
