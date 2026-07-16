namespace PluginLocalNotifDemo;

public class App : Application
{
    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new NavigationPage(new MainPage()))
        {
            Title = "OneSignal LocalNotification Repro",
        };
    }
}
