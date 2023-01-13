using OneSignalSDK.DotNet;
using OneSignalSDK.DotNet.Core;

namespace exampledotnet;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
    }
}

