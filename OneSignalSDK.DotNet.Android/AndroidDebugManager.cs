using OneSignalSDK.DotNet.Android.Utilities;
using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.Debug;

using OneSignalNative = Com.OneSignal.Android.OneSignal;

namespace OneSignalSDK.DotNet.Android;

public class AndroidDebugManager : IDebugManager
{
    private Core.Debug.LogLevel _logLevel = Core.Debug.LogLevel.WARN;
    private Core.Debug.LogLevel _alertLevel = Core.Debug.LogLevel.NONE;

    public Core.Debug.LogLevel LogLevel
    {
        get => _logLevel;
        set => OneSignalNative.Debug.LogLevel = ToNativeConversion.ToLogLevel(value);
    }

    public Core.Debug.LogLevel AlertLevel
    {
        get => _alertLevel;
        set => OneSignalNative.Debug.AlertLevel = ToNativeConversion.ToLogLevel(value);
    }
}
