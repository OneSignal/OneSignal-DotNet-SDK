using OneSignalDemo.Models;
using OneSignalDemo.ViewModels;

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

    private void OnTopBannerTapped(object? sender, TappedEventArgs e) =>
        SendIam(InAppMessageType.TopBanner);

    private void OnBottomBannerTapped(object? sender, TappedEventArgs e) =>
        SendIam(InAppMessageType.BottomBanner);

    private void OnCenterModalTapped(object? sender, TappedEventArgs e) =>
        SendIam(InAppMessageType.CenterModal);

    private void OnFullScreenTapped(object? sender, TappedEventArgs e) =>
        SendIam(InAppMessageType.FullScreen);

    private void SendIam(InAppMessageType type)
    {
        _viewModel?.SendInAppMessage(type);
    }

    private void OnInfoTapped(object? sender, EventArgs e) => InfoTapped?.Invoke(this, e);
}
