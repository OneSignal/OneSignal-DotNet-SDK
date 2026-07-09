using System.Text;
using System.Text.Json;
using OneSignalSDK.DotNet;
using OneSignalSDK.DotNet.Core.Notifications;
using OneSignalSDK.DotNet.Core.User;
using OneSignalSDK.DotNet.Core.User.Subscriptions;
using Plugin.LocalNotification;
using Plugin.LocalNotification.Core.Models;
using Plugin.LocalNotification.Core.Models.AndroidOption;

namespace PluginLocalNotifDemo;

public class MainPage : ContentPage
{
    private int _nextNotificationId = 132;
    private readonly Label _statusLabel;
    private readonly Label _permissionLabel;
    private readonly Label _pushInfoLabel;

    public MainPage()
    {
        Title = "Local Notification Repro";
        BackgroundColor = Colors.White;

        _statusLabel = new Label
        {
            Text = "Ready. Request permissions, then show a local notification.",
            TextColor = Colors.Black,
        };

        _permissionLabel = new Label { TextColor = Colors.DimGray };
        _pushInfoLabel = new Label
        {
            TextColor = Colors.DimGray,
            LineBreakMode = LineBreakMode.WordWrap,
        };

        OneSignal.Notifications.PermissionChanged += OnPermissionChanged;
        OneSignal.User.PushSubscription.Changed += OnPushSubscriptionChanged;
        OneSignal.User.Changed += OnUserChanged;

        var requestOneSignalPermissionButton = new Button
        {
            Text = "Request OneSignal Permission",
            AutomationId = "request_onesignal_permission_button",
        };
        requestOneSignalPermissionButton.Clicked += async (s, e) =>
        {
            if (!DotEnv.HasOneSignalAppId)
            {
                SetStatus("Set ONESIGNAL_APP_ID in .env before requesting OneSignal permission.");
                return;
            }

            var granted = await OneSignal.Notifications.RequestPermissionAsync(true);
            SetStatus($"OneSignal permission granted: {granted}");
            RefreshPermissionLabel();
            RefreshPushInfoLabel();
        };

        var requestLocalPermissionButton = new Button
        {
            Text = "Request LocalNotification Permission",
            AutomationId = "request_local_notification_permission_button",
        };
        requestLocalPermissionButton.Clicked += async (s, e) =>
        {
            var granted = await LocalNotificationCenter.Current.RequestNotificationPermission();
            SetStatus($"LocalNotification permission granted: {granted}");
            RefreshPermissionLabel();
        };

        var showLocalNotificationButton = new Button
        {
            Text = "Show Local Notification",
            AutomationId = "show_local_notification_button",
        };
        showLocalNotificationButton.Clicked += async (s, e) =>
        {
            var request = new NotificationRequest
            {
                NotificationId = _nextNotificationId++,
                Title = "Local notification repro",
                Description =
                    "Foreground display/tap exercises the iOS notification delegate path.",
                Android = new AndroidOptions
                {
                    IconSmallName = new AndroidIcon("ic_stat_local_notification", "drawable"),
                },
            };

            await LocalNotificationCenter.Current.Show(request);
            SetStatus(
                "Local notification requested. If it is delivered while foregrounded or tapped "
                    + "from Notification Center, watch for the selector crash from issue #132."
            );
        };

        var showOneSignalNotificationButton = new Button
        {
            Text = "Show OneSignal Notification",
            AutomationId = "show_onesignal_notification_button",
        };
        showOneSignalNotificationButton.Clicked += async (s, e) =>
        {
            showOneSignalNotificationButton.IsEnabled = false;
            try
            {
                await SendSimpleOneSignalNotificationAsync();
            }
            finally
            {
                showOneSignalNotificationButton.IsEnabled = true;
            }
        };

        var clearButton = new Button
        {
            Text = "Clear Delivered Notifications",
            AutomationId = "clear_notifications_button",
        };
        clearButton.Clicked += (s, e) =>
        {
            OneSignal.Notifications.ClearAllNotifications();
            SetStatus("Cleared delivered notifications through OneSignal.");
        };

        var refreshPushInfoButton = new Button
        {
            Text = "Refresh Push Info",
            AutomationId = "refresh_push_info_button",
        };
        refreshPushInfoButton.Clicked += (s, e) => RefreshPushInfoLabel();

        Content = new ScrollView
        {
            Content = new VerticalStackLayout
            {
                Padding = 20,
                Spacing = 16,
                Children =
                {
                    new Label
                    {
                        Text = "OneSignal + Plugin.LocalNotification",
                        FontSize = 24,
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Colors.Black,
                    },
                    new Label
                    {
                        Text =
                            "Minimal iOS repro for GitHub issue #132. The interesting paths are "
                            + "foreground delivery and tapping the delivered local notification.",
                        TextColor = Colors.DimGray,
                    },
                    _permissionLabel,
                    _pushInfoLabel,
                    requestOneSignalPermissionButton,
                    requestLocalPermissionButton,
                    showLocalNotificationButton,
                    showOneSignalNotificationButton,
                    clearButton,
                    refreshPushInfoButton,
                    _statusLabel,
                },
            },
        };

        RefreshPermissionLabel();
        RefreshPushInfoLabel();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        RefreshPermissionLabel();
        RefreshPushInfoLabel();
    }

    private void RefreshPermissionLabel()
    {
        _permissionLabel.Text = $"OneSignal permission: {OneSignal.Notifications.Permission}";
    }

    private void RefreshPushInfoLabel()
    {
        var pushSubscription = OneSignal.User.PushSubscription;
        _pushInfoLabel.Text =
            $"OneSignal ID: {FormatValue(OneSignal.User.OneSignalId)}\n"
            + $"Push subscription ID: {FormatValue(pushSubscription.Id)}\n"
            + $"Push opted in: {pushSubscription.OptedIn}\n"
            + $"Push token: {FormatValue(pushSubscription.Token)}";
    }

    private void OnPermissionChanged(object? sender, NotificationPermissionChangedEventArgs args)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            RefreshPermissionLabel();
            RefreshPushInfoLabel();
        });
    }

    private void OnPushSubscriptionChanged(object? sender, PushSubscriptionChangedEventArgs args)
    {
        MainThread.BeginInvokeOnMainThread(RefreshPushInfoLabel);
    }

    private void OnUserChanged(object? sender, UserStateChangedEventArgs args)
    {
        MainThread.BeginInvokeOnMainThread(RefreshPushInfoLabel);
    }

    private async Task SendSimpleOneSignalNotificationAsync()
    {
        if (!DotEnv.HasOneSignalAppId)
        {
            SetStatus("Set ONESIGNAL_APP_ID in .env before sending a OneSignal notification.");
            return;
        }

        var pushSubscriptionId = OneSignal.User.PushSubscription.Id;
        if (string.IsNullOrWhiteSpace(pushSubscriptionId))
        {
            SetStatus("No OneSignal push subscription ID yet. Refresh after permission is granted.");
            return;
        }

        using var client = new HttpClient();
        client.DefaultRequestHeaders.Add("Accept", "application/vnd.onesignal.v1+json");

        var payload = new Dictionary<string, object>
        {
            ["app_id"] = DotEnv.OneSignalAppId,
            ["headings"] = new Dictionary<string, string> { ["en"] = "Simple Notification" },
            ["contents"] = new Dictionary<string, string>
            {
                ["en"] = "This is a simple push notification",
            },
            ["include_subscription_ids"] = new[] { pushSubscriptionId },
        };

        var json = JsonSerializer.Serialize(payload);
        var response = await client.PostAsync(
            "https://onesignal.com/api/v1/notifications",
            new StringContent(json, Encoding.UTF8, "application/json")
        );
        var responseJson = await response.Content.ReadAsStringAsync();

        SetStatus(
            response.IsSuccessStatusCode
                ? $"OneSignal notification requested: {responseJson}"
                : $"OneSignal notification failed: {responseJson}"
        );
    }

    private void SetStatus(string message)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            _statusLabel.Text = message;
            System.Diagnostics.Debug.WriteLine(message);
        });
    }

    private static string FormatValue(string? value) =>
        string.IsNullOrWhiteSpace(value) ? "-" : value;
}
