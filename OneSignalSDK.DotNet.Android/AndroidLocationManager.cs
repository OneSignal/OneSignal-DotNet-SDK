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
    private static bool GetShared()
    {
        if (AndroidInit.Reject("location.isShared"))
            return false;
        return OneSignalNative.Location.Shared;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetShared(bool shared)
    {
        if (AndroidInit.Reject("location.isShared"))
            return;
        OneSignalNative.Location.Shared = shared;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void RequestNativePermission()
    {
        if (AndroidInit.Reject("location.requestPermission"))
            return;
        var consumer = new AndroidBoolConsumer();
        OneSignalNative.Location.RequestPermission(Com.OneSignal.Android.Continue.With(consumer));
    }
}
