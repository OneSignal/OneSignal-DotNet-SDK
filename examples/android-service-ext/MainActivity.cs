using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using OneSignalSDK.DotNet;

namespace OneSignalAndroidServiceExtension;

[Activity(
    Label = "OneSignal Service Extension",
    MainLauncher = true,
    Exported = true
)]
public sealed class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        var appId = DotEnv.Get("ONESIGNAL_APP_ID");
        var isConfigured = Guid.TryParse(appId, out _);
        var message = new TextView(this)
        {
            Gravity = GravityFlags.Center,
            Text = isConfigured
                ? "Send a push notification to test the blue accent color."
                : "Set ONESIGNAL_APP_ID in .env, then run the app again.",
            TextSize = 18,
        };
        message.SetBackgroundColor(Color.White);
        message.SetTextColor(Color.Black);
        message.SetPadding(48, 48, 48, 48);
        SetContentView(message);

        if (!isConfigured)
            return;

        OneSignal.Initialize(appId);
        _ = OneSignal.Notifications.RequestPermissionAsync(false);
    }
}
