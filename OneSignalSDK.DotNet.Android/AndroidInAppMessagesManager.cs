using Com.OneSignal.Android.InAppMessages;
using OneSignalSDK.DotNet.Android.Utilities;
using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.InAppMessages;
using OneSignalNative = Com.OneSignal.Android.OneSignal;

namespace OneSignalSDK.DotNet.Android;

public class AndroidInAppMessagesManager
    : OneSignalSDK.DotNet.Core.InAppMessages.IInAppMessagesManager
{
    public event EventHandler<InAppMessageWillDisplayEventArgs>? WillDisplay;
    public event EventHandler<InAppMessageDidDisplayEventArgs>? DidDisplay;
    public event EventHandler<InAppMessageWillDismissEventArgs>? WillDismiss;
    public event EventHandler<InAppMessageDidDismissEventArgs>? DidDismiss;
    public event EventHandler<InAppMessageClickedEventArgs>? Clicked;

    public bool Paused
    {
        get => OneSignalNative.InAppMessages.Paused;
        set => OneSignalNative.InAppMessages.Paused = value;
    }

    private InternalInAppMessageEventsHandler? _inAppMessageEventsHandler;

    public void Initialize()
    {
        _inAppMessageEventsHandler = new InternalInAppMessageEventsHandler(this);
        OneSignalNative.InAppMessages.AddClickListener(_inAppMessageEventsHandler);
        OneSignalNative.InAppMessages.AddLifecycleListener(_inAppMessageEventsHandler);
    }

    public void AddTrigger(string key, string value)
    {
        if (InputGuard.Missing(key, "addTrigger: key"))
            return;
        if (value == null)
        {
            System.Diagnostics.Debug.WriteLine("OneSignal: addTrigger: value is required");
            return;
        }
        OneSignalNative.InAppMessages.AddTrigger(key, value);
    }

    public void AddTriggers(IDictionary<string, string> triggers)
    {
        if (InputGuard.MissingEntries(triggers, "addTriggers", true))
            return;
        IDictionary<string, string> jTriggers = new Dictionary<string, string>();
        foreach (var trigger in triggers)
        {
            jTriggers[trigger.Key] = trigger.Value;
        }

        OneSignalNative.InAppMessages.AddTriggers(jTriggers);
    }

    public void ClearTriggers()
    {
        OneSignalNative.InAppMessages.ClearTriggers();
    }

    public void RemoveTrigger(string key)
    {
        if (InputGuard.Missing(key, "removeTrigger: key"))
            return;
        OneSignalNative.InAppMessages.RemoveTrigger(key);
    }

    public void RemoveTriggers(params string[] keys)
    {
        if (InputGuard.MissingAny(keys, "removeTriggers: key"))
            return;
        OneSignalNative.InAppMessages.RemoveTriggers(keys);
    }

    private class InternalInAppMessageEventsHandler
        : Java.Lang.Object,
            Com.OneSignal.Android.InAppMessages.IInAppMessageClickListener,
            Com.OneSignal.Android.InAppMessages.IInAppMessageLifecycleListener
    {
        private AndroidInAppMessagesManager _manager;

        public InternalInAppMessageEventsHandler(AndroidInAppMessagesManager manager)
        {
            _manager = manager;
        }

        public void OnClick(IInAppMessageClickEvent clickEvent)
        {
            var args = new InAppMessageClickedEventArgs(
                FromNativeConversion.ToInAppMessage(clickEvent.Message),
                FromNativeConversion.ToInAppMessageClickResult(clickEvent.Result)
            );
            _manager.Clicked?.Invoke(_manager, args);
        }

        public void OnWillDisplay(IInAppMessageWillDisplayEvent willDisplayEvent)
        {
            _manager.WillDisplay?.Invoke(_manager, GetWillDisplayEventArgs(willDisplayEvent));
        }

        public void OnDidDisplay(IInAppMessageDidDisplayEvent didDisplayEvent)
        {
            _manager.DidDisplay?.Invoke(_manager, GetDidDisplayEventArgs(didDisplayEvent));
        }

        public void OnWillDismiss(IInAppMessageWillDismissEvent willDismissEvent)
        {
            _manager.WillDismiss?.Invoke(_manager, GetWillDismissEventArgs(willDismissEvent));
        }

        public void OnDidDismiss(IInAppMessageDidDismissEvent didDismissEvent)
        {
            _manager.DidDismiss?.Invoke(_manager, GetDidDismissEventArgs(didDismissEvent));
        }

        private InAppMessageWillDisplayEventArgs GetWillDisplayEventArgs(
            Com.OneSignal.Android.InAppMessages.IInAppMessageWillDisplayEvent willDisplayEvent
        )
        {
            return new InAppMessageWillDisplayEventArgs(
                FromNativeConversion.ToInAppMessage(willDisplayEvent.Message)
            );
        }

        private InAppMessageDidDisplayEventArgs GetDidDisplayEventArgs(
            Com.OneSignal.Android.InAppMessages.IInAppMessageDidDisplayEvent didDisplayEvent
        )
        {
            return new InAppMessageDidDisplayEventArgs(
                FromNativeConversion.ToInAppMessage(didDisplayEvent.Message)
            );
        }

        private InAppMessageWillDismissEventArgs GetWillDismissEventArgs(
            Com.OneSignal.Android.InAppMessages.IInAppMessageWillDismissEvent willDismissEvent
        )
        {
            return new InAppMessageWillDismissEventArgs(
                FromNativeConversion.ToInAppMessage(willDismissEvent.Message)
            );
        }

        private InAppMessageDidDismissEventArgs GetDidDismissEventArgs(
            Com.OneSignal.Android.InAppMessages.IInAppMessageDidDismissEvent didDismissEvent
        )
        {
            return new InAppMessageDidDismissEventArgs(
                FromNativeConversion.ToInAppMessage(didDismissEvent.Message)
            );
        }
    }
}
