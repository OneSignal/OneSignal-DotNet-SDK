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
    private const string OneSignalAppId = "YOUR-ONESIGNAL-APP-ID";

    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        var isConfigured = OneSignalAppId != "YOUR-ONESIGNAL-APP-ID";
        var message = new TextView(this)
        {
            Gravity = GravityFlags.Center,
            Text = isConfigured
                ? "Send a push notification to test the blue accent color."
                : "Set OneSignalAppId in MainActivity.cs, then run the app again.",
            TextSize = 18,
        };
        message.SetBackgroundColor(Color.White);
        message.SetTextColor(Color.Black);
        message.SetPadding(48, 48, 48, 48);
        SetContentView(message);

        if (!isConfigured)
            return;

        OneSignal.Initialize(OneSignalAppId);
        _ = OneSignal.Notifications.RequestPermissionAsync(false);
    }
}
