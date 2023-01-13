using System.Reflection.Emit;
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
            get => OneSignalNative.User.Language;
            set => OneSignalNative.User.Language = value;
        }

        public IPushSubscription PushSubscription { get; } = new AndroidPushSubscription();

        public void Initialize()
        {
            ((AndroidPushSubscription)PushSubscription).Initialize();
        }

        public void AddAlias(string label, string id) => OneSignalNative.User.AddAlias(label, id);
        public void AddAliases(IDictionary<string, string> aliases) => OneSignalNative.User.AddAliases(aliases);
        public void RemoveAlias(string label) => OneSignalNative.User.RemoveAlias(label);

        public void AddEmailSubscription(string email) => OneSignalNative.User.AddEmailSubscription(email);
        public void RemoveEmailSubscription(string email) => OneSignalNative.User.RemoveEmailSubscription(email);

        public void AddSmsSubscription(string sms) => OneSignalNative.User.AddSmsSubscription(sms);
        public void RemoveSmsSubscription(string sms) => OneSignalNative.User.RemoveSmsSubscription(sms);

        public void AddTag(string key, string value) => OneSignalNative.User.AddTag(key, value);
        public void AddTags(IDictionary<string, string> tags) => OneSignalNative.User.AddTags(tags);
        public void RemoveTag(string key) => OneSignalNative.User.RemoveTag(key);
        public void RemoveTags(params string[] keys) => OneSignalNative.User.RemoveTags(keys);
    }

    public class AndroidPushSubscription : IPushSubscription
    {
        public string Token => OneSignalNative.User.PushSubscription.Token;

        public bool OptedIn => OneSignalNative.User.PushSubscription.OptedIn;

        public string Id => OneSignalNative.User.PushSubscription.Id;

        public event EventHandler<SubscriptionChangedEventArgs>? Changed;

        public void Initialize()
        {
            OneSignalNative.User.PushSubscription.AddChangeHandler(new AndroidSubscriptionChangedHandler(this));
        }

        public void OptIn()
        {
            OneSignalNative.User.PushSubscription.OptIn();
        }

        public void OptOut()
        {
            OneSignalNative.User.PushSubscription.OptOut();
        }

        private class AndroidSubscriptionChangedHandler : Java.Lang.Object, Com.OneSignal.Android.User.Subscriptions.ISubscriptionChangedHandler
        {
            private AndroidPushSubscription _manager;
            public AndroidSubscriptionChangedHandler(AndroidPushSubscription manager)
            {
                _manager = manager;
            }

            public void OnSubscriptionChanged(Com.OneSignal.Android.User.Subscriptions.ISubscription subscription)
            {
                _manager.Changed?.Invoke(_manager, new SubscriptionChangedEventArgs(_manager));
            }
        }
    }
}
