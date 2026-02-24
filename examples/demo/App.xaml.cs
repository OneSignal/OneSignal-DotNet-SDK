using OneSignalDemo.Pages;

namespace OneSignalDemo;

public partial class App : Application
{
    private readonly IServiceProvider _serviceProvider;

    public App(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var mainPage = _serviceProvider.GetRequiredService<MainPage>();

        var osPrimary = (Color)Application.Current!.Resources["OsPrimary"];
        var navPage = new NavigationPage(mainPage)
        {
            BarBackgroundColor = osPrimary,
            BarTextColor = Colors.White
        };

        NavigationPage.SetTitleView(mainPage, CreateTitleView());

        return new Window(navPage);
    }

    private static View CreateTitleView()
    {
        return new HorizontalStackLayout
        {
            Spacing = 8,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            Children =
            {
                new Image
                {
                    Source = "onesignal_logo",
                    HeightRequest = 22,
                    VerticalOptions = LayoutOptions.Center
                },
                new Label
                {
                    Text = "DotNet",
                    TextColor = Colors.White,
                    FontSize = 14,
                    VerticalOptions = LayoutOptions.Center
                }
            }
        };
    }
}
