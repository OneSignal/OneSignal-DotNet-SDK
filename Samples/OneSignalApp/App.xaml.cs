using OneSignalSDK.DotNet;
using OneSignalSDK.DotNet.Core;

namespace OneSignalApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
    }
}

