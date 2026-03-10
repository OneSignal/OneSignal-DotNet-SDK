using System.Collections.ObjectModel;
using System.ComponentModel;

namespace OneSignalDemo.Services;

public class LogEntry
{
    public string Timestamp { get; }
    public string Level { get; }
    public string Message { get; }
    public Color LevelColor { get; }

    public LogEntry(string level, string message)
    {
        Timestamp = DateTime.Now.ToString("HH:mm:ss");
        Level = level;
        Message = message;
        LevelColor = level switch
        {
            "E" => Color.FromArgb("#FF5370"),
            "W" => Color.FromArgb("#FFCB6B"),
            "I" => Color.FromArgb("#C3E88D"),
            _ => Color.FromArgb("#82AAFF"),
        };
    }
}

public class LogManager : INotifyPropertyChanged
{
    private static readonly LogManager _instance = new();
    public static LogManager Instance => _instance;

    public event PropertyChangedEventHandler? PropertyChanged;

    public ObservableCollection<LogEntry> Logs { get; } = new();

    public event EventHandler? LogAdded;

    private LogManager() { }

    public void D(string tag, string message) => AddLog("D", tag, message);

    public void I(string tag, string message) => AddLog("I", tag, message);

    public void W(string tag, string message) => AddLog("W", tag, message);

    public void E(string tag, string message) => AddLog("E", tag, message);

    private const int MaxEntries = 100;

    private void AddLog(string level, string tag, string message)
    {
        var entry = new LogEntry(level, $"[{tag}] {message}");
        var line = $"[{level}][{tag}] {message}";
        if (level is "W" or "E")
            Console.Error.WriteLine(line);
        else
            Console.WriteLine(line);

        MainThread.BeginInvokeOnMainThread(() =>
        {
            Logs.Insert(0, entry);
            if (Logs.Count > MaxEntries)
                Logs.RemoveAt(Logs.Count - 1);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Logs)));
            LogAdded?.Invoke(this, EventArgs.Empty);
        });
    }

    public void Clear()
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            Logs.Clear();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Logs)));
        });
    }
}
