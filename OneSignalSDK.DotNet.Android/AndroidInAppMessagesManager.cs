﻿using Com.OneSignal.Android.InAppMessages;
using OneSignalSDK.DotNet.Android.Utilities;
using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.InAppMessages;

using OneSignalNative = Com.OneSignal.Android.OneSignal;

namespace OneSignalSDK.DotNet.Android;

public class AndroidInAppMessagesManager : Core.InAppMessages.IInAppMessagesManager
{
    public event EventHandler<InAppMessageLifecycleEventArgs>? WillDisplay;
    public event EventHandler<InAppMessageLifecycleEventArgs>? DidDisplay;
    public event EventHandler<InAppMessageLifecycleEventArgs>? WillDismiss;
    public event EventHandler<InAppMessageLifecycleEventArgs>? DidDismiss;
    public event EventHandler<InAppMessageClickedEventArgs>? Clicked;

    public bool Paused
    {
        get => OneSignalNative.InAppMessages.Paused;
        set => OneSignalNative.InAppMessages.Paused = value;
    }

    public void Initialize()
    {
        var handler = new AndroidInAppMessageEventsHandler(this);
        OneSignalNative.InAppMessages.SetInAppMessageClickHandler(handler);
        OneSignalNative.InAppMessages.SetInAppMessageLifecycleHandler(handler);
    }

    public void AddTrigger(string key, object value)
    {
        OneSignalNative.InAppMessages.AddTrigger(key, ToNativeConversion.ToJavaObject(value));
    }

    public void AddTriggers(IDictionary<string, object> triggers)
    {
        IDictionary<string, Java.Lang.Object> jTriggers = new Dictionary<string, Java.Lang.Object>();
        foreach (var trigger in triggers)
        {
            jTriggers[trigger.Key] = ToNativeConversion.ToJavaObject(trigger.Value);
        }

        OneSignalNative.InAppMessages.AddTriggers(jTriggers);
    }

    public void ClearTriggers()
    {
        OneSignalNative.InAppMessages.ClearTriggers();
    }

    public void RemoveTrigger(string key)
    {
        OneSignalNative.InAppMessages.RemoveTrigger(key);
    }

    public void RemoveTriggers(params string[] keys)
    {
        OneSignalNative.InAppMessages.RemoveTriggers(keys);
    }

    private class AndroidInAppMessageEventsHandler : Java.Lang.Object,
        Com.OneSignal.Android.InAppMessages.IInAppMessageClickHandler,
        Com.OneSignal.Android.InAppMessages.IInAppMessageLifecycleHandler
    {
        private AndroidInAppMessagesManager _manager;
        public AndroidInAppMessageEventsHandler(AndroidInAppMessagesManager manager)
        {
            _manager = manager;
        }

        public void InAppMessageClicked(IInAppMessageClickResult result)
        {
            var args = new InAppMessageClickedEventArgs(FromNativeConversion.ToInAppMessageAction(result.Action));
            _manager.Clicked?.Invoke(_manager, args);
        }

        public void OnDidDismissInAppMessage(Com.OneSignal.Android.InAppMessages.IInAppMessage message)
        {
            _manager.DidDismiss?.Invoke(_manager, GetLifecycleArgs(message));
        }

        public void OnDidDisplayInAppMessage(Com.OneSignal.Android.InAppMessages.IInAppMessage message)
        {
            _manager.DidDisplay?.Invoke(_manager, GetLifecycleArgs(message));
        }

        public void OnWillDismissInAppMessage(Com.OneSignal.Android.InAppMessages.IInAppMessage message)
        {
            _manager.WillDismiss?.Invoke(_manager, GetLifecycleArgs(message));
        }

        public void OnWillDisplayInAppMessage(Com.OneSignal.Android.InAppMessages.IInAppMessage message)
        {
            _manager.WillDisplay?.Invoke(_manager, GetLifecycleArgs(message));
        }

        private InAppMessageLifecycleEventArgs GetLifecycleArgs(Com.OneSignal.Android.InAppMessages.IInAppMessage message)
        {
            return new InAppMessageLifecycleEventArgs(FromNativeConversion.ToInAppMessage(message));
        }
    }
}