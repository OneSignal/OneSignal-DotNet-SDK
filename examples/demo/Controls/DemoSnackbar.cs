using CommunityToolkit.Maui.Alerts;

namespace OneSignalDemo.Controls;

public static class DemoSnackbar
{
    public static readonly TimeSpan Duration = TimeSpan.FromSeconds(3);

    public static Task Show(string message) => Snackbar.Make(message, duration: Duration).Show();
}
