namespace OneSignalApp.Sample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		//Onesignal Helpers
        SharedPush.Initialize();

        MainPage = new AppShell();
	}
}

