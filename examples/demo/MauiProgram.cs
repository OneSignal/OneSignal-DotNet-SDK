using System.Diagnostics;
using CommunityToolkit.Maui;
using MauiIcons.Material;
using OneSignalDemo.Pages;
using OneSignalDemo.Services;
using OneSignalDemo.ViewModels;
using OneSignalSDK.DotNet;
using OneSignalSDK.DotNet.Core.LiveActivities;
using OsLogLevel = OneSignalSDK.DotNet.Core.Debug.LogLevel;
#if ANDROID
using AndroidX.AppCompat.Content.Res;
#endif
#if ANDROID || IOS
using Microsoft.Maui.Handlers;
#endif

namespace OneSignalDemo;

public static class MauiProgram
{
    private const string DefaultAppId = "77e32082-ea27-42e3-a898-c72e141824ef";

    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseMaterialMauiIcons()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("DroidSansMono.ttf", "DroidSansMono");
            })
            .ConfigureMauiHandlers(handlers =>
            {
#if ANDROID
                SwitchHandler.Mapper.AppendToMapping(
                    "ThumbShadow",
                    (handler, _) =>
                    {
                        var context = handler.PlatformView.Context;
                        if (context is null)
                        {
                            return;
                        }

                        var thumb = AppCompatResources.GetDrawable(
                            context,
                            global::OneSignalDemo.Resource.Drawable.switch_thumb_white_shadow
                        );
                        if (thumb is null)
                        {
                            return;
                        }

                        handler.PlatformView.ThumbTintList = null;
                        handler.PlatformView.ThumbDrawable = thumb.Mutate();
                    }
                );
#endif

#if IOS
                // MAUI iOS attaches a default UIToolbar `inputAccessoryView`
                // (a blue rounded "Done" affordance) above the on-screen
                // keyboard for every Entry/Editor. Its tap target sits in
                // the same on-screen Y range as the bottom-aligned confirm
                // button of taller popups (e.g. multi-row input dialogs),
                // and XCUITest tap routing happily hands the touch to the
                // accessory view, which only dismisses the keyboard — the
                // popup's confirm button never receives the click. Removing
                // the accessory view restores normal hit-testing and matches
                // the React Native demo's behavior (RN doesn't attach one
                // by default).
                EntryHandler.Mapper.AppendToMapping(
                    "RemoveInputAccessoryView",
                    (handler, _) => handler.PlatformView.InputAccessoryView = null
                );
                EditorHandler.Mapper.AppendToMapping(
                    "RemoveInputAccessoryView",
                    (handler, _) => handler.PlatformView.InputAccessoryView = null
                );
#endif
            });

        // Register services
        builder.Services.AddSingleton<PreferencesService>();
        builder.Services.AddSingleton<OneSignalApiService>();
        builder.Services.AddSingleton<AppViewModel>();
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddSingleton<App>();

        var app = builder.Build();

        // Load .env file for API keys
        DotEnv.Load();

        // Load App ID from .env (fall back to default if empty or missing)
        var envAppId = DotEnv.Get("ONESIGNAL_APP_ID");
        var appId =
            string.IsNullOrWhiteSpace(envAppId) || envAppId == "your-onesignal-app-id"
                ? DefaultAppId
                : envAppId;

        var prefs = app.Services.GetRequiredService<PreferencesService>();
        var apiService = app.Services.GetRequiredService<OneSignalApiService>();
        apiService.SetAppId(appId);

        OneSignal.Debug.LogLevel = OsLogLevel.VERBOSE;
        OneSignal.ConsentRequired = prefs.ConsentRequired;
        OneSignal.ConsentGiven = prefs.PrivacyConsent;
        OneSignal.Initialize(appId);

#if IOS
        OneSignal.LiveActivities.SetupDefault(
            new LiveActivitySetupOptions { EnablePushToStart = true, EnablePushToUpdate = true }
        );
        PopupKeyboardAvoider.Install();
#endif

        // Register observers
        OneSignal.InAppMessages.WillDisplay += (s, e) => Debug.WriteLine("IAM WillDisplay");
        OneSignal.InAppMessages.DidDisplay += (s, e) => Debug.WriteLine("IAM DidDisplay");
        OneSignal.InAppMessages.WillDismiss += (s, e) => Debug.WriteLine("IAM WillDismiss");
        OneSignal.InAppMessages.DidDismiss += (s, e) => Debug.WriteLine("IAM DidDismiss");
        OneSignal.InAppMessages.Clicked += (s, e) => Debug.WriteLine("IAM Clicked");
        OneSignal.Notifications.Clicked += (s, e) => Debug.WriteLine("Notification clicked");
        OneSignal.Notifications.WillDisplay += (s, e) =>
            Debug.WriteLine("Notification willDisplay");

        // Restore SDK state from prefs (after Initialize)
        OneSignal.InAppMessages.Paused = prefs.IamPaused;
        OneSignal.Location.IsShared = prefs.LocationShared;

        // Fetch tooltips in background
        _ = Task.Run(async () => await OneSignalDemo.Services.TooltipHelper.Instance.InitAsync());

        return app;
    }
}
