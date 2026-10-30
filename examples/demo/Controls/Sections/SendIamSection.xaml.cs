using MauiIcons.Core;
using OneSignalDemo.Models;
using OneSignalDemo.ViewModels;

namespace OneSignalDemo.Controls.Sections;

public partial class SendIamSection : ContentView
{
    private AppViewModel? _viewModel;
    private Page? _parentPage;

    public event EventHandler? InfoTapped;

    // Forces the linker to keep MauiIcons.Core so XamlC can resolve the
    // mi: HTTP-based xmlns at compile time. Without this, XAML compilation
    // in Release fails with: Cannot resolve type "...:MauiIcon".
    // See dotnet/maui#32830.
    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Performance",
        "CA1823:Avoid unused private fields",
        Justification = "Linker hint"
    )]
    private static readonly Type _mauiIconKeepAlive = typeof(MauiIcon);

    public SendIamSection()
    {
        InitializeComponent();
    }

    public void Initialize(AppViewModel viewModel, Page parentPage)
    {
        _viewModel = viewModel;
        _parentPage = parentPage;
    }

    private void OnTopBannerTapped(object? sender, EventArgs e) =>
        SendIam(InAppMessageType.TopBanner);

    private void OnBottomBannerTapped(object? sender, EventArgs e) =>
        SendIam(InAppMessageType.BottomBanner);

    private void OnCenterModalTapped(object? sender, EventArgs e) =>
        SendIam(InAppMessageType.CenterModal);

    private void OnHtmlTapped(object? sender, EventArgs e) => SendIam(InAppMessageType.Html);

    private void OnFullScreenTapped(object? sender, EventArgs e) =>
        SendIam(InAppMessageType.FullScreen);

    private void OnFullBleedTapped(object? sender, EventArgs e) =>
        SendIam(InAppMessageType.FullBleed);

    private void OnCarouselTapped(object? sender, EventArgs e) =>
        SendIam(InAppMessageType.Carousel);

    private void OnCarouselBleedTapped(object? sender, EventArgs e) =>
        SendIam(InAppMessageType.CarouselBleed);

    private void SendIam(InAppMessageType type)
    {
        _viewModel?.SendInAppMessage(type);
    }

    private void OnInfoTapped(object? sender, EventArgs e) => InfoTapped?.Invoke(this, e);
}
