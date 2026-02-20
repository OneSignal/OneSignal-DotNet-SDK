using OneSignalDemo.Models;
using OneSignalDemo.ViewModels;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace OneSignalDemo.Controls.Sections;

public partial class SendIamSection : ContentView
{
    private AppViewModel? _viewModel;
    private Page? _parentPage;

    public event EventHandler? InfoTapped;

    public SendIamSection()
    {
        InitializeComponent();
    }

    public void Initialize(AppViewModel viewModel, Page parentPage)
    {
        _viewModel = viewModel;
        _parentPage = parentPage;
    }

    private async void OnTopBannerTapped(object? sender, TappedEventArgs e) => await SendIam(InAppMessageType.TopBanner);
    private async void OnBottomBannerTapped(object? sender, TappedEventArgs e) => await SendIam(InAppMessageType.BottomBanner);
    private async void OnCenterModalTapped(object? sender, TappedEventArgs e) => await SendIam(InAppMessageType.CenterModal);
    private async void OnFullScreenTapped(object? sender, TappedEventArgs e) => await SendIam(InAppMessageType.FullScreen);

    private async Task SendIam(InAppMessageType type)
    {
        _viewModel?.SendInAppMessage(type);
        if (_parentPage != null)
            await Toast.Make($"Sent In-App Message: {type.GetDisplayName()}", ToastDuration.Short).Show();
    }

    private void OnInfoTapped(object? sender, EventArgs e) => InfoTapped?.Invoke(this, e);
}
