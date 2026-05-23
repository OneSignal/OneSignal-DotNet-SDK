using OneSignalDemo.Controls;
using OneSignalDemo.Models;
using OneSignalDemo.ViewModels;

namespace OneSignalDemo.Controls.Sections;

public partial class SendPushSection : ContentView
{
    private AppViewModel? _viewModel;
    private Page? _parentPage;

    public event EventHandler? InfoTapped;

    public SendPushSection()
    {
        InitializeComponent();
    }

    public void Initialize(AppViewModel viewModel, Page parentPage)
    {
        _viewModel = viewModel;
        _parentPage = parentPage;
    }

    private async void OnSimpleClicked(object? sender, EventArgs e)
    {
        if (_viewModel == null)
            return;
        await _viewModel.SendNotificationAsync(NotificationType.Simple);
    }

    private async void OnWithImageClicked(object? sender, EventArgs e)
    {
        if (_viewModel == null)
            return;
        await _viewModel.SendNotificationAsync(NotificationType.WithImage);
    }

    private async void OnWithSoundClicked(object? sender, EventArgs e)
    {
        if (_viewModel == null)
            return;
        await _viewModel.SendNotificationAsync(NotificationType.WithSound);
    }

    private async void OnCustomClicked(object? sender, EventArgs e)
    {
        if (_parentPage == null || _viewModel == null)
            return;

        var form = await DialogInputHelper.ShowForm(
            _parentPage,
            "Custom Notification",
            new[]
            {
                new DialogInputField
                {
                    Key = "title",
                    Placeholder = "Title",
                    AutomationId = "custom_notification_title_input",
                },
                new DialogInputField
                {
                    Key = "body",
                    Placeholder = "Body",
                    AutomationId = "custom_notification_body_input",
                },
            },
            "Send",
            "custom_notification_send_button"
        );

        if (
            form == null
            || !form.TryGetValue("title", out var title)
            || string.IsNullOrEmpty(title)
        )
            return;

        form.TryGetValue("body", out var body);
        await _viewModel.SendCustomNotificationAsync(title, body ?? string.Empty);
    }

    private void OnClearAllClicked(object? sender, EventArgs e)
    {
        _viewModel?.ClearAllNotifications();
    }

    private void OnInfoTapped(object? sender, EventArgs e) => InfoTapped?.Invoke(this, e);
}
