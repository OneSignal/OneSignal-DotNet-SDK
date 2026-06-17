using OneSignalSDK.DotNet;
using Plugin.LocalNotification;
using OsLogLevel = OneSignalSDK.DotNet.Core.Debug.LogLevel;

namespace PluginLocalNotifDemo;

public static class MauiProgram
{
    private const string OneSignalAppId = "77e32082-ea27-42e3-a898-c72e141824ef";

    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder.UseMauiApp<App>().UseLocalNotification();

        var app = builder.Build();

        OneSignal.Debug.LogLevel = OsLogLevel.VERBOSE;
        OneSignal.Initialize(OneSignalAppId);

        OneSignal.Notifications.WillDisplay += (s, e) =>
            System.Diagnostics.Debug.WriteLine("OneSignal notification will display");
        OneSignal.Notifications.Clicked += (s, e) =>
            System.Diagnostics.Debug.WriteLine("OneSignal notification clicked");

        return app;
    }
}
