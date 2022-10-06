namespace exampledotnet;
using OneSignalSDK.Xamarin;
using OneSignalSDK.Xamarin.Core;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
        OneSignal.Default.Initialize("31cc0310-2322-493c-a323-194f7a8b11f4");
        OneSignal.Default.PromptForPushNotificationsWithUserResponse();

    }
}

