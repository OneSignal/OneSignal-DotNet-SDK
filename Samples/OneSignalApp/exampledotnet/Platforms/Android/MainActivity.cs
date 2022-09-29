using Android.App;
using Android.Content.PM;
using Android.OS;

namespace exampledotnet;

using OneSignalSDK.dotnet;
using OneSignalSDK.dotnet.Core;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);


        SharedPush.Initialize();

    }
}


