using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using OneSignalSDK.DotNet;
using OneSignalSDK.DotNet.Core.User.Subscriptions;

namespace OneSignalAndroidServiceExtension;

[Activity(
    Label = "OneSignal Service Extension",
    MainLauncher = true,
    Exported = true
)]
public sealed class MainActivity : Activity
{
    private TextView? _message;

    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        var appId = DotEnv.Get("ONESIGNAL_APP_ID");
        var isConfigured = Guid.TryParse(appId, out _);
        _message = new TextView(this)
        {
            Gravity = GravityFlags.Center,
            Text = isConfigured
                ? "Push ID: registering..."
                : "Set ONESIGNAL_APP_ID in .env, then run the app again.",
            TextSize = 18,
        };
        _message.SetBackgroundColor(Color.White);
        _message.SetTextColor(Color.Black);
        _message.SetPadding(48, 48, 48, 48);
        SetContentView(_message);

        if (!isConfigured)
            return;

        OneSignal.Initialize(appId);
        OneSignal.User.PushSubscription.Changed += OnPushSubscriptionChanged;
        RefreshPushId();
        _ = OneSignal.Notifications.RequestPermissionAsync(false);
    }

    protected override void OnDestroy()
    {
        OneSignal.User.PushSubscription.Changed -= OnPushSubscriptionChanged;
        base.OnDestroy();
    }

    private void OnPushSubscriptionChanged(
        object? sender,
        PushSubscriptionChangedEventArgs args
    )
    {
        RunOnUiThread(RefreshPushId);
    }

    private void RefreshPushId()
    {
        var pushId = OneSignal.User.PushSubscription.Id;
        _message!.Text =
            $"Push ID: {pushId ?? "registering..."}\n\n"
            + "Send a push notification to test the blue accent color.";
    }
}
