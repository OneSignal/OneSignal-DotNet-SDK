using OneSignalSDK.DotNet.Android.Utilities;
using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.Debug;
using OneSignalNative = Com.OneSignal.Android.OneSignal;

namespace OneSignalSDK.DotNet.Android;

public class AndroidDebugManager : IDebugManager
{
    private OneSignalSDK.DotNet.Core.Debug.LogLevel _logLevel = OneSignalSDK
        .DotNet
        .Core
        .Debug
        .LogLevel
        .WARN;
    private OneSignalSDK.DotNet.Core.Debug.LogLevel _alertLevel = OneSignalSDK
        .DotNet
        .Core
        .Debug
        .LogLevel
        .NONE;

    public OneSignalSDK.DotNet.Core.Debug.LogLevel LogLevel
    {
        get => _logLevel;
        set
        {
            _logLevel = value;
            OneSignalNative.Debug.LogLevel = ToNativeConversion.ToLogLevel(value);
        }
    }

    public OneSignalSDK.DotNet.Core.Debug.LogLevel AlertLevel
    {
        get => _alertLevel;
        set
        {
            _alertLevel = value;
            OneSignalNative.Debug.AlertLevel = ToNativeConversion.ToLogLevel(value);
        }
    }
}
