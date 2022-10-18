namespace exampledotnet;
using OneSignalSDK.dotnet;
using OneSignalSDK.dotnet.Core;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
       

        SharedPush.Initialize();
       

    }
}

