using System.Text;
using System.Text.Json;
using OneSignalSDK.DotNet;
using OneSignalSDK.DotNet.Core.Notifications;
using OneSignalSDK.DotNet.Core.User.Subscriptions;

namespace OneSignalDemoNoLocation;

public partial class MainPage : ContentPage
{
    private readonly string _appId;

    public MainPage(AppConfig config)
    {
        InitializeComponent();

        _appId = config.OneSignalAppId;
        AppIdLabel.Text = _appId;

        OneSignal.Notifications.PermissionChanged += OnPermissionChanged;
        OneSignal.User.PushSubscription.Changed += OnPushSubscriptionChanged;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        RefreshPushState();
    }

    private void RefreshPushState()
    {
        PermissionLabel.Text = OneSignal.Notifications.Permission ? "Granted" : "Not granted";
        PushIdLabel.Text = FormatValue(OneSignal.User.PushSubscription.Id);
    }

    private async void OnRequestPermissionClicked(object? sender, EventArgs e)
    {
        SetBusy(RequestPermissionButton, RequestPermissionSpinner, true);
        try
        {
            await OneSignal.Notifications.RequestPermissionAsync(false);
            RefreshPushState();
        }
        catch (Exception exception)
        {
            await DisplayAlert("Permission Request Failed", exception.Message, "OK");
        }
        finally
        {
            SetBusy(RequestPermissionButton, RequestPermissionSpinner, false);
        }
    }

    private async void OnSendNotificationClicked(object? sender, EventArgs e)
    {
        if (IsPlaceholder(_appId))
        {
            await DisplayAlert(
                "Configure OneSignal",
                "Set ONESIGNAL_APP_ID in .env before sending a test push.",
                "OK"
            );
            return;
        }

        if (!OneSignal.Notifications.Permission)
        {
            await DisplayAlert(
                "Notifications Disabled",
                "Request notification permission before sending a test push.",
                "OK"
            );
            return;
        }

        var pushSubscriptionId = OneSignal.User.PushSubscription.Id;
        if (string.IsNullOrWhiteSpace(pushSubscriptionId))
        {
            await DisplayAlert(
                "No Push Subscription",
                "Allow notifications, then wait for a push ID.",
                "OK"
            );
            return;
        }

        SetBusy(SendNotificationButton, SendNotificationSpinner, true);
        try
        {
            var response = await SendTestNotificationAsync(pushSubscriptionId);
            if (response.IsSuccessStatusCode)
            {
                await DisplayAlert("Sent", "Test notification requested.", "OK");
                return;
            }

            var message = await response.Content.ReadAsStringAsync();
            await DisplayAlert("Send Failed", message, "OK");
        }
        catch (Exception exception)
        {
            await DisplayAlert("Send Failed", exception.Message, "OK");
        }
        finally
        {
            SetBusy(SendNotificationButton, SendNotificationSpinner, false);
        }
    }

    private void OnTestLocationClicked(object? sender, EventArgs e)
    {
        try
        {
            OneSignal.Location.RequestPermission();
            LocationStatusLabel.Text = $"Location request completed. IsShared={OneSignal.Location.IsShared}";
        }
        catch (Exception exception)
        {
            LocationStatusLabel.Text = $"Location request failed: {exception.Message}";
        }
    }

    private async Task<HttpResponseMessage> SendTestNotificationAsync(string pushSubscriptionId)
    {
        using var client = new HttpClient();
        client.DefaultRequestHeaders.Add("Accept", "application/vnd.onesignal.v1+json");

        var payload = new Dictionary<string, object>
        {
            ["app_id"] = _appId,
            ["include_subscription_ids"] = new[] { pushSubscriptionId },
            ["headings"] = new Dictionary<string, string>
            {
                ["en"] = "OneSignal No-Location Demo",
            },
            ["contents"] = new Dictionary<string, string>
            {
                ["en"] = "This test push was sent without linking the location module.",
            },
        };

        var json = JsonSerializer.Serialize(payload);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        return await client.PostAsync("https://onesignal.com/api/v1/notifications", content);
    }

    private void OnPermissionChanged(object? sender, NotificationPermissionChangedEventArgs args)
    {
        MainThread.BeginInvokeOnMainThread(RefreshPushState);
    }

    private void OnPushSubscriptionChanged(object? sender, PushSubscriptionChangedEventArgs args)
    {
        MainThread.BeginInvokeOnMainThread(RefreshPushState);
    }

    private static void SetBusy(Button button, ActivityIndicator spinner, bool busy)
    {
        button.IsEnabled = !busy;
        button.IsVisible = !busy;
        spinner.IsRunning = busy;
        spinner.IsVisible = busy;
    }

    private static string FormatValue(string value) => string.IsNullOrWhiteSpace(value) ? "-" : value;

    private static bool IsPlaceholder(string value) =>
        value.Trim().StartsWith("YOUR-", StringComparison.OrdinalIgnoreCase);
}
