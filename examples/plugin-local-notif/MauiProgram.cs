using OneSignalSDK.DotNet;
using Plugin.LocalNotification;
using OsLogLevel = OneSignalSDK.DotNet.Core.Debug.LogLevel;
#if IOS
using Microsoft.Maui.LifecycleEvents;
#endif

namespace PluginLocalNotifDemo;

public static class MauiProgram
{
    private const string DefaultAppId = "77e32082-ea27-42e3-a898-c72e141824ef";

    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        var appId = DefaultAppId;

        builder.UseMauiApp<App>().UseLocalNotification();

#if IOS
        builder.ConfigureLifecycleEvents(events =>
        {
            events.AddiOS(ios =>
            {
                ios.FinishedLaunching(
                    (_, _) =>
                    {
                        InitializeOneSignal(appId);
                        return true;
                    }
                );
            });
        });
#endif

        var app = builder.Build();

        DotEnv.Load();

        var envAppId = DotEnv.Get("ONESIGNAL_APP_ID");
        appId =
            string.IsNullOrWhiteSpace(envAppId) || envAppId == "your-onesignal-app-id"
                ? DefaultAppId
                : envAppId.Trim();

        OneSignal.Debug.LogLevel = OsLogLevel.VERBOSE;
        OneSignal.Notifications.WillDisplay += (s, e) =>
            System.Diagnostics.Debug.WriteLine("OneSignal notification will display");
        OneSignal.Notifications.Clicked += (s, e) =>
            System.Diagnostics.Debug.WriteLine("OneSignal notification clicked");

#if !IOS
        InitializeOneSignal(appId);
#endif

        return app;
    }

    private static void InitializeOneSignal(string appId)
    {
        OneSignal.Initialize(appId);
    }
}
