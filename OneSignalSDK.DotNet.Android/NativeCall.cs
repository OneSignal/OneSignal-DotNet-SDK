using Android.Util;

namespace OneSignalSDK.DotNet.Android;

// Native throws IllegalStateException when init has not started or has failed.
internal static class NativeCall
{
    internal static bool Run(string api, Action call)
    {
        try
        {
            call();
            return true;
        }
        catch (Java.Lang.IllegalStateException e)
        {
            LogSkipped(api, e);
            return false;
        }
    }

    internal static T Get<T>(string api, Func<T> call, T fallback)
    {
        try
        {
            return call();
        }
        catch (Java.Lang.IllegalStateException e)
        {
            LogSkipped(api, e);
            return fallback;
        }
    }

    private static void LogSkipped(string api, Java.Lang.IllegalStateException e) =>
        Log.Error("OneSignal", $"{api} ignored: {e.Message}");
}
