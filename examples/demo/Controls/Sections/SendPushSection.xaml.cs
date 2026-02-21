using OneSignalDemo.Models;
using OneSignalDemo.ViewModels;

namespace OneSignalDemo.Controls.Sections;

public partial class SendPushSection : ContentView
{
    private AppViewModel? _viewModel;

    public event EventHandler? InfoTapped;
    public event EventHandler? CustomNotificationRequested;

    public SendPushSection()
    {
        InitializeComponent();
    }

    public void Initialize(AppViewModel viewModel)
    {
        _viewModel = viewModel;
    }

    private async void OnSimpleClicked(object? sender, EventArgs e)
    {
        if (_viewModel == null) return;
        await _viewModel.SendNotificationAsync(NotificationType.Simple);
    }

    private async void OnWithImageClicked(object? sender, EventArgs e)
    {
        if (_viewModel == null) return;
        await _viewModel.SendNotificationAsync(NotificationType.WithImage);
    }

    private void OnCustomClicked(object? sender, EventArgs e)
    {
        CustomNotificationRequested?.Invoke(this, e);
    }

    private void OnInfoTapped(object? sender, EventArgs e) => InfoTapped?.Invoke(this, e);
}
