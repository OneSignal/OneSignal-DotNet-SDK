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

    public async Task<bool> RequestPermissionAsync(bool fallbackToSettings)
    {
        var consumer = new AndroidBoolConsumer();
        OneSignalNative.Location.RequestPermission(fallbackToSettings, Com.OneSignal.Android.Continue.With(consumer));
        return await consumer;
    }
}
