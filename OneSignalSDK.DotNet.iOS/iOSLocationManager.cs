using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.Location;

using OneSignalNative = Com.OneSignal.iOS.OneSignal;

namespace OneSignalSDK.DotNet.iOS;

public class iOSLocationManager : ILocationManager
{
    public bool IsShared
    {
        get => OneSignalNative.Location.IsShared;
        set => OneSignalNative.Location.SetShared(value);
    }

    public Task<bool> RequestPermissionAsync()
    {
        OneSignalNative.Location.RequestPermission();
        return Task.FromResult(true);
    }
}
