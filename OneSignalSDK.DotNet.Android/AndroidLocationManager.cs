using System.Runtime.CompilerServices;
using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.Location;
using OneSignalNative = Com.OneSignal.Android.OneSignal;

namespace OneSignalSDK.DotNet.Android;

public class AndroidLocationManager : ILocationManager
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
        global::Android.Util.Log.Error("OneSignal", $"{LocationModuleNotAvailable} {exception}");
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool GetShared() => OneSignalNative.Location.Shared;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetShared(bool shared) => OneSignalNative.Location.Shared = shared;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void RequestNativePermission()
    {
        var consumer = new AndroidBoolConsumer();
        OneSignalNative.Location.RequestPermission(Com.OneSignal.Android.Continue.With(consumer));
    }
}
