namespace exampledotnet;
using OneSignalSDK.DotNet;
using OneSignalSDK.DotNet.Core;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
       

        SharedPush.Initialize();
       

    }
}

