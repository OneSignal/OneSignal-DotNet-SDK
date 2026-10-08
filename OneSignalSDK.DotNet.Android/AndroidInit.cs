using Android.Util;

namespace OneSignalSDK.DotNet.Android;

internal static class AndroidInit
{
    // Set once InitWithContext has been attempted. A failed init that did start still throws.
    private static bool _started;
    private static readonly HashSet<string> Logged = new();

    internal static bool Started => Volatile.Read(ref _started);

    internal static void MarkStarted() => Volatile.Write(ref _started, true);

    internal static bool Reject(string api)
    {
        if (Volatile.Read(ref _started))
            return false;
        lock (Logged)
        {
            if (Logged.Add(api))
                Log.Warn("OneSignal", api + " ignored: OneSignal.Initialize did not start");
        }
        return true;
    }

    internal static T? Require<T>(string api, Func<T> get)
        where T : class
    {
        if (Reject(api))
            return null;
        return get();
    }
}
