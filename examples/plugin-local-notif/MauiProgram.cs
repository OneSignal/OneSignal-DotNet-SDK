using OneSignalSDK.DotNet;
using Plugin.LocalNotification;
using OsLogLevel = OneSignalSDK.DotNet.Core.Debug.LogLevel;

namespace PluginLocalNotifDemo;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder.UseMauiApp<App>()
            .UseLocalNotification(options =>
            {
#if IOS
                options.AddiOS(ios =>
                {
                    ios.SetCustomUserNotificationCenterDelegate(
                        new OneSignalCompatibleNotificationDelegate()
                    );
                });
#endif
            });

        var app = builder.Build();

        DotEnv.Load();

        OneSignal.Debug.LogLevel = OsLogLevel.VERBOSE;
        if (DotEnv.HasOneSignalAppId)
        {
            OneSignal.Initialize(DotEnv.OneSignalAppId);
        }
        else
        {
            System.Diagnostics.Debug.WriteLine("Set ONESIGNAL_APP_ID in .env to initialize OneSignal.");
        }

        OneSignal.Notifications.WillDisplay += (s, e) =>
            System.Diagnostics.Debug.WriteLine("OneSignal notification will display");
        OneSignal.Notifications.Clicked += (s, e) =>
            System.Diagnostics.Debug.WriteLine("OneSignal notification clicked");

        return app;
    }
}
