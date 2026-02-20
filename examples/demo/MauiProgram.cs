using OneSignalSDK.DotNet;
using OneSignalDemo.Pages;
using OneSignalDemo.Repositories;
using OneSignalDemo.Services;
using OneSignalDemo.ViewModels;
using OsLogLevel = OneSignalSDK.DotNet.Core.Debug.LogLevel;

namespace OneSignalDemo;

public static class MauiProgram
{
    private const string AppId = "77e32082-ea27-42e3-a898-c72e141824ef";

    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });


        // Register services
        builder.Services.AddSingleton<PreferencesService>();
        builder.Services.AddSingleton<OneSignalApiService>();
        builder.Services.AddSingleton<OneSignalRepository>();
        builder.Services.AddSingleton<AppViewModel>();
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddSingleton<App>();

        var app = builder.Build();

        // Initialize OneSignal SDK before building the app
        var prefs = app.Services.GetRequiredService<PreferencesService>();
        var apiService = app.Services.GetRequiredService<OneSignalApiService>();
        apiService.SetAppId(prefs.AppId);

        OneSignal.Debug.LogLevel = OsLogLevel.VERBOSE;
        OneSignal.ConsentRequired = prefs.ConsentRequired;
        OneSignal.ConsentGiven = prefs.PrivacyConsent;
        OneSignal.Initialize(prefs.AppId);

        // Register observers
        OneSignal.InAppMessages.WillDisplay += (s, e) => LogManager.Instance.D("IAM", $"WillDisplay");
        OneSignal.InAppMessages.DidDisplay += (s, e) => LogManager.Instance.D("IAM", $"DidDisplay");
        OneSignal.InAppMessages.WillDismiss += (s, e) => LogManager.Instance.D("IAM", $"WillDismiss");
        OneSignal.InAppMessages.DidDismiss += (s, e) => LogManager.Instance.D("IAM", $"DidDismiss");
        OneSignal.InAppMessages.Clicked += (s, e) => LogManager.Instance.D("IAM", $"Clicked");
        OneSignal.Notifications.Clicked += (s, e) => LogManager.Instance.D("Notifications", "Clicked");
        OneSignal.Notifications.WillDisplay += (s, e) => LogManager.Instance.D("Notifications", "WillDisplay");

        // Restore SDK state from prefs (after Initialize)
        OneSignal.InAppMessages.Paused = prefs.IamPaused;
        OneSignal.Location.IsShared = prefs.LocationShared;

        // Fetch tooltips in background
        _ = Task.Run(async () => await OneSignalDemo.Services.TooltipHelper.Instance.InitAsync());

        return app;
    }
}
