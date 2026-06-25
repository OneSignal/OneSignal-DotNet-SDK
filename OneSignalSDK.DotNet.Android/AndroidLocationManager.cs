using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.Location;
using OneSignalNative = Com.OneSignal.Android.OneSignal;

namespace OneSignalSDK.DotNet.Android;

public class AndroidLocationManager : ILocationManager
{
    private const string LocationModuleNotAvailable =
        "OneSignal location module is not available. Add the location dependency to use OneSignal.Location.";

    public bool IsShared
    {
        get
        {
            try
            {
                return OneSignalNative.Location.Shared;
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
                OneSignalNative.Location.Shared = value;
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
            var consumer = new AndroidBoolConsumer();
            OneSignalNative.Location.RequestPermission(
                Com.OneSignal.Android.Continue.With(consumer)
            );
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
}
