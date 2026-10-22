using System.Collections.ObjectModel;

namespace OneSignalDemo.Services;

public sealed record LogEntry(string Time, string Message);

public static class LogService
{
    private const int MaxEntries = 100;

    // In memory only, so each launch starts empty and the Appium suite can assert per-launch counts.
    public static ObservableCollection<LogEntry> Entries { get; } = new();

    public static void Info(string message) => Console.WriteLine($"[OneSignal] {message}");

    public static void Show(string message)
    {
        Info(message);
        AddToView(message);
    }

    public static void Error(string message)
    {
        Console.Error.WriteLine($"[OneSignal] {message}");
        AddToView(message);
    }

    public static void Clear() => MainThread.BeginInvokeOnMainThread(Entries.Clear);

    private static void AddToView(string message)
    {
        var entry = new LogEntry(DateTime.Now.ToString("HH:mm:ss"), message);
        MainThread.BeginInvokeOnMainThread(() =>
        {
            Entries.Add(entry);
            while (Entries.Count > MaxEntries)
                Entries.RemoveAt(0);
        });
    }
}
