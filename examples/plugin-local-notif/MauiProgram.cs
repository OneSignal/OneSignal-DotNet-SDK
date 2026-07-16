using OneSignalSDK.DotNet;
using Plugin.LocalNotification;
using OsLogLevel = OneSignalSDK.DotNet.Core.Debug.LogLevel;
#if IOS
using Microsoft.Maui.LifecycleEvents;
#endif

namespace PluginLocalNotifDemo;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        DotEnv.Load();

        var builder = MauiApp.CreateBuilder();

        builder.UseMauiApp<App>().UseLocalNotification();

#if IOS
        builder.ConfigureLifecycleEvents(events =>
        {
            events.AddiOS(ios =>
            {
                ios.FinishedLaunching(
                    (_, _) =>
                    {
                        InitializeOneSignal(installNotificationDelegate: true);
                        return true;
                    }
                );
            });
        });
#endif

        var app = builder.Build();

        OneSignal.Debug.LogLevel = OsLogLevel.VERBOSE;
        OneSignal.Notifications.WillDisplay += (s, e) =>
            System.Diagnostics.Debug.WriteLine("OneSignal notification will display");
        OneSignal.Notifications.Clicked += (s, e) =>
            System.Diagnostics.Debug.WriteLine("OneSignal notification clicked");

#if !IOS
        InitializeOneSignal();
#endif

        return app;
    }

    private static void InitializeOneSignal(bool installNotificationDelegate = false)
    {
        if (!DotEnv.HasOneSignalAppId)
        {
            System.Diagnostics.Debug.WriteLine(
                "Set ONESIGNAL_APP_ID in .env to initialize OneSignal."
            );
            return;
        }

#if IOS
        if (installNotificationDelegate)
        {
            OneSignalNotificationDelegate.Install();
        }
#endif

        OneSignal.Initialize(DotEnv.OneSignalAppId);
    }
}
