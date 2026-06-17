using OneSignalSDK.DotNet;
using Plugin.LocalNotification;
using Plugin.LocalNotification.Core.Models;

namespace PluginLocalNotifDemo;

public class MainPage : ContentPage
{
    private int _nextNotificationId = 132;
    private readonly Label _statusLabel;
    private readonly Label _permissionLabel;

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

        var requestOneSignalPermissionButton = new Button
        {
            Text = "Request OneSignal Permission",
            AutomationId = "request_onesignal_permission_button",
        };
        requestOneSignalPermissionButton.Clicked += async (s, e) =>
        {
            var granted = await OneSignal.Notifications.RequestPermissionAsync(true);
            SetStatus($"OneSignal permission granted: {granted}");
            RefreshPermissionLabel();
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
                Description = "Foreground display/tap exercises the iOS notification delegate path.",
            };

            await LocalNotificationCenter.Current.Show(request);
            SetStatus(
                "Local notification requested. If it is delivered while foregrounded or tapped "
                    + "from Notification Center, watch for the selector crash from issue #132."
            );
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
                    requestOneSignalPermissionButton,
                    requestLocalPermissionButton,
                    showLocalNotificationButton,
                    clearButton,
                    _statusLabel,
                },
            },
        };

        RefreshPermissionLabel();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        RefreshPermissionLabel();
    }

    private void RefreshPermissionLabel()
    {
        _permissionLabel.Text = $"OneSignal permission: {OneSignal.Notifications.Permission}";
    }

    private void SetStatus(string message)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            _statusLabel.Text = message;
            System.Diagnostics.Debug.WriteLine(message);
        });
    }
}
