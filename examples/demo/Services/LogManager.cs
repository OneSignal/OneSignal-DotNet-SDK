using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;

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
            "E" => Colors.Red,
            "W" => Colors.Orange,
            "I" => Colors.LightGreen,
            _ => Colors.LightGray
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

    private void AddLog(string level, string tag, string message)
    {
        var entry = new LogEntry(level, $"[{tag}] {message}");
        Debug.WriteLine($"{level} {entry.Timestamp} [{tag}] {message}");

        MainThread.BeginInvokeOnMainThread(() =>
        {
            Logs.Add(entry);
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
