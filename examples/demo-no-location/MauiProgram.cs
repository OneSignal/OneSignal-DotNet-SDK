using CommunityToolkit.Maui;
using OneSignalSDK.DotNet;
using OsLogLevel = OneSignalSDK.DotNet.Core.Debug.LogLevel;

namespace OneSignalDemoNoLocation;

public static class MauiProgram
{
    private const string DefaultAppId = "YOUR-ONESIGNAL-APP-ID";

    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder.UseMauiApp<App>().UseMauiCommunityToolkit();

        DotEnv.Load();

        var envAppId = DotEnv.Get("ONESIGNAL_APP_ID");
        var appId = string.IsNullOrWhiteSpace(envAppId) ? DefaultAppId : envAppId.Trim();

        OneSignal.Debug.LogLevel = OsLogLevel.VERBOSE;
        OneSignal.Initialize(appId);

        builder.Services.AddSingleton(new AppConfig(appId));
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<App>();

        return builder.Build();
    }
}

public sealed record AppConfig(string OneSignalAppId);
