using Com.OneSignal.iOS;
using Foundation;
using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.InAppMessages;
using OneSignalSDK.DotNet.iOS.Utilities;
using OneSignalNative = Com.OneSignal.iOS.OneSignal;

namespace OneSignalSDK.DotNet.iOS;

public class iOSInAppMessagesManager : Core.InAppMessages.IInAppMessagesManager
{
    public event EventHandler<InAppMessageWillDisplayEventArgs>? WillDisplay;
    public event EventHandler<InAppMessageDidDisplayEventArgs>? DidDisplay;
    public event EventHandler<InAppMessageWillDismissEventArgs>? WillDismiss;
    public event EventHandler<InAppMessageDidDismissEventArgs>? DidDismiss;
    public event EventHandler<InAppMessageClickedEventArgs>? Clicked;

    public bool Paused
    {
        get => OneSignalNative.InAppMessages.Paused;
        set => OneSignalNative.InAppMessages.SetPaused(value);
    }

    private InternalInAppMessageLifeCycleListener? _lifecycleListener;

    private InternalInAppMessageClickListener? _clickListener;

    public void Initialize()
    {
        _lifecycleListener = new InternalInAppMessageLifeCycleListener(this);
        _clickListener = new InternalInAppMessageClickListener(this);
        OneSignalNative.InAppMessages.AddLifecycleListener(_lifecycleListener);
        OneSignalNative.InAppMessages.AddClickListener(_clickListener);
    }

    public void AddTrigger(string key, string value) => OneSignalNative.InAppMessages.AddTrigger(key, value);
    public void AddTriggers(IDictionary<string, string> triggers) => OneSignalNative.InAppMessages.AddTriggers(NativeConversion.DictToNSDict(triggers));
    public void ClearTriggers() => OneSignalNative.InAppMessages.ClearTriggers();
    public void RemoveTrigger(string key) => OneSignalNative.InAppMessages.RemoveTrigger(key);
    public void RemoveTriggers(params string[] keys) => OneSignalNative.InAppMessages.RemoveTriggers(keys);


    private sealed class InternalInAppMessageClickListener : Com.OneSignal.iOS.OSInAppMessageClickListener
    {
        private iOSInAppMessagesManager _manager;
        public InternalInAppMessageClickListener(iOSInAppMessagesManager manager) : base()
        {
            _manager = manager;
        }

        public override void OnClickInAppMessage(Com.OneSignal.iOS.OSInAppMessageClickEvent clickEvent)
        {
            var args = new InAppMessageClickedEventArgs(FromNativeConversion.ToInAppMessage(clickEvent.Message), FromNativeConversion.ToInAppMessageClickResult(clickEvent.Result));
            _manager.Clicked?.Invoke(this, args);
        }
    }

    private sealed class InternalInAppMessageLifeCycleListener : Com.OneSignal.iOS.OSInAppMessageLifecycleListener
    {
        private iOSInAppMessagesManager _manager;
        public InternalInAppMessageLifeCycleListener(iOSInAppMessagesManager manager) : base()
        {
            _manager = manager;
        }

        public override void OnWillDisplayInAppMessage(Com.OneSignal.iOS.OSInAppMessageWillDisplayEvent willDisplayEvent)
        {
            _manager.WillDisplay?.Invoke(_manager, GetWillDisplayArgs(willDisplayEvent));
        }

        public override void OnDidDisplayInAppMessage(Com.OneSignal.iOS.OSInAppMessageDidDisplayEvent didDisplayEvent)
        {
            _manager.DidDisplay?.Invoke(_manager, GetDidDisplayArgs(didDisplayEvent));
        }

        public override void OnWillDismissInAppMessage(Com.OneSignal.iOS.OSInAppMessageWillDismissEvent willDismissEvent)
        {
            _manager.WillDismiss?.Invoke(_manager, GetWillDismissArgs(willDismissEvent));
        }

        public override void OnDidDismissInAppMessage(Com.OneSignal.iOS.OSInAppMessageDidDismissEvent didDismissEvent)
        {
            _manager.DidDismiss?.Invoke(_manager, GetDidDismissArgs(didDismissEvent));
        }        

        private InAppMessageWillDisplayEventArgs GetWillDisplayArgs(Com.OneSignal.iOS.OSInAppMessageWillDisplayEvent willDisplayEvent)
        {
            return new InAppMessageWillDisplayEventArgs(FromNativeConversion.ToInAppMessage(willDisplayEvent.Message));
        }

        private InAppMessageDidDisplayEventArgs GetDidDisplayArgs(Com.OneSignal.iOS.OSInAppMessageDidDisplayEvent didDisplayEvent)
        {
            return new InAppMessageDidDisplayEventArgs(FromNativeConversion.ToInAppMessage(didDisplayEvent.Message));
        }

        private InAppMessageWillDismissEventArgs GetWillDismissArgs(Com.OneSignal.iOS.OSInAppMessageWillDismissEvent willDismissEvent)
        {
            return new InAppMessageWillDismissEventArgs(FromNativeConversion.ToInAppMessage(willDismissEvent.Message));
        }

        private InAppMessageDidDismissEventArgs GetDidDismissArgs(Com.OneSignal.iOS.OSInAppMessageDidDismissEvent didDismissEvent)
        {
            return new InAppMessageDidDismissEventArgs(FromNativeConversion.ToInAppMessage(didDismissEvent.Message));
        }
    }
}
