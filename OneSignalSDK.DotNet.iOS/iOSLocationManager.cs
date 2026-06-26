using System.Runtime.CompilerServices;
using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.Location;
using OneSignalNative = Com.OneSignal.iOS.OneSignal;

namespace OneSignalSDK.DotNet.iOS;

public class iOSLocationManager : ILocationManager
{
    private const string LocationModuleNotAvailable =
        "OneSignal.Location call failed. The location module may not be included in this build.";

    public bool IsShared
    {
        get
        {
            try
            {
                return GetShared();
            }
            catch (Exception exception)
            {
                LogLocationModuleNotAvailable(exception);
                return false;
            }
        }
        set
        {
            try
            {
                SetShared(value);
            }
            catch (Exception exception)
            {
                LogLocationModuleNotAvailable(exception);
            }
        }
    }

    public void RequestPermission()
    {
        try
        {
            RequestNativePermission();
        }
        catch (Exception exception)
        {
            LogLocationModuleNotAvailable(exception);
        }
    }

    private static void LogLocationModuleNotAvailable(Exception exception)
    {
        Console.Error.WriteLine($"{LocationModuleNotAvailable} {exception}");
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool GetShared() => OneSignalNative.Location.IsShared;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetShared(bool shared) => OneSignalNative.Location.SetShared(shared);

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void RequestNativePermission() => OneSignalNative.Location.RequestPermission();
}
