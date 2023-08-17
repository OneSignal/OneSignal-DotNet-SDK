using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.Location;

using OneSignalNative = Com.OneSignal.Android.OneSignal;

namespace OneSignalSDK.DotNet.Android;

public class AndroidLocationManager : ILocationManager
{
    public bool IsShared
    {
        get => OneSignalNative.Location.Shared;
        set => OneSignalNative.Location.Shared = value;
    }

    public void RequestPermission()
    {
        var consumer = new AndroidBoolConsumer();
        OneSignalNative.Location.RequestPermission(Com.OneSignal.Android.Continue.With(consumer));
    }
}
