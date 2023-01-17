using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.InAppMessages;
using OneSignalSDK.DotNet.iOS.Utilities;
using OneSignalNative = Com.OneSignal.iOS.OneSignal;

namespace OneSignalSDK.DotNet.iOS;

public class iOSInAppMessagesManager : Core.InAppMessages.IInAppMessagesManager
{
    public event EventHandler<InAppMessageLifecycleEventArgs>? WillDisplay;
    public event EventHandler<InAppMessageLifecycleEventArgs>? DidDisplay;
    public event EventHandler<InAppMessageLifecycleEventArgs>? WillDismiss;
    public event EventHandler<InAppMessageLifecycleEventArgs>? DidDismiss;
    public event EventHandler<InAppMessageClickedEventArgs>? Clicked;

    public bool Paused
    {
        get => OneSignalNative.InAppMessages.IsPaused;
        set => OneSignalNative.InAppMessages.Paused(value);
    }

    public void Initialize()
    {
        var handler = new iOSInAppMessageEventsHandler(this);
        OneSignalNative.InAppMessages.SetLifecycleHandler(handler);
        OneSignalNative.InAppMessages.SetClickHandler(action =>
        {
            //TODO: iOS does not provide IAMMessage in OneSignal.InAppMessages.SetClickHandler
            var args = new InAppMessageClickedEventArgs(null, FromNativeConversion.ToInAppMessageAction(action));
            Clicked?.Invoke(this, args);
        });
    }

    public void AddTrigger(string key, object value) => OneSignalNative.InAppMessages.AddTrigger(key, NSObject.FromObject(value));
    public void AddTriggers(IDictionary<string, object> triggers) => OneSignalNative.InAppMessages.AddTriggers(NativeConversion.DictToNSDict(triggers));
    public void ClearTriggers() => OneSignalNative.InAppMessages.ClearTriggers();
    public void RemoveTrigger(string key) => OneSignalNative.InAppMessages.RemoveTrigger(key);
    public void RemoveTriggers(params string[] keys) => OneSignalNative.InAppMessages.RemoveTriggers(keys);

    private class iOSInAppMessageEventsHandler : Com.OneSignal.iOS.OSInAppMessageLifecycleHandler
    {
        private iOSInAppMessagesManager _manager;
        public iOSInAppMessageEventsHandler(iOSInAppMessagesManager manager)
        {
            _manager = manager;
        }

        public override void OnDidDismissInAppMessage(Com.OneSignal.iOS.OSInAppMessage message)
        {
            _manager.DidDismiss?.Invoke(_manager, GetLifecycleArgs(message));
        }

        public override void OnDidDisplayInAppMessage(Com.OneSignal.iOS.OSInAppMessage message)
        {
            _manager.DidDisplay?.Invoke(_manager, GetLifecycleArgs(message));
        }

        public override void OnWillDismissInAppMessage(Com.OneSignal.iOS.OSInAppMessage message)
        {
            _manager.WillDismiss?.Invoke(_manager, GetLifecycleArgs(message));
        }

        public override void OnWillDisplayInAppMessage(Com.OneSignal.iOS.OSInAppMessage message)
        {
            _manager.WillDisplay?.Invoke(_manager, GetLifecycleArgs(message));
        }

        private InAppMessageLifecycleEventArgs GetLifecycleArgs(Com.OneSignal.iOS.OSInAppMessage message)
        {
            return new InAppMessageLifecycleEventArgs(FromNativeConversion.ToInAppMessage(message));
        }
    }
}
