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

        var navPage = new NavigationPage(mainPage)
        {
            BarBackgroundColor = Color.FromArgb("#E54B4D"),
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
                    HeightRequest = 28,
                    VerticalOptions = LayoutOptions.Center
                },
                new Label
                {
                    Text = "Sample App",
                    TextColor = Colors.White,
                    FontAttributes = FontAttributes.Bold,
                    FontSize = 18,
                    VerticalOptions = LayoutOptions.Center
                }
            }
        };
    }
}
