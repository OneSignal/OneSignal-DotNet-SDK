using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.Location;
using OneSignalNative = Com.OneSignal.iOS.OneSignal;

namespace OneSignalSDK.DotNet.iOS;

public class iOSLocationManager : ILocationManager
{
    private const string LocationModuleNotAvailable =
        "OneSignal location module is not available. Add the location dependency to use OneSignal.Location.";

    public bool IsShared
    {
        get
        {
            try
            {
                return OneSignalNative.Location.IsShared;
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
                OneSignalNative.Location.SetShared(value);
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
            OneSignalNative.Location.RequestPermission();
        }
        catch (Exception exception)
        {
            LogLocationModuleNotAvailable(exception);
        }
    }

    private static void LogLocationModuleNotAvailable(Exception exception)
    {
        System.Diagnostics.Debug.WriteLine($"{LocationModuleNotAvailable} {exception}");
    }
}
