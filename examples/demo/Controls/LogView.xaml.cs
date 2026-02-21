using MauiIcons.Material;
using MauiIcons.Core;
using OneSignalDemo.Services;

namespace OneSignalDemo.Controls;

public partial class LogView : ContentView
{
    private bool _isExpanded = true;
    private readonly List<HorizontalStackLayout> _logRows = new();

    public LogView()
    {
        InitializeComponent();
        LogManager.Instance.LogAdded += OnLogAdded;
        UpdateCount();
    }

    private void OnLogAdded(object? sender, EventArgs e)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            RebuildLogList();
            _ = ScrollToBottomAsync();
        });
    }

    private void RebuildLogList()
    {
        var logs = LogManager.Instance.Logs;
        LogList.Children.Clear();
        _logRows.Clear();

        for (int i = 0; i < logs.Count; i++)
        {
            var entry = logs[i];
            var row = new HorizontalStackLayout { Spacing = 4 };

            var ts = new Label
            {
                Text = entry.Timestamp,
                TextColor = Color.FromArgb("#888888"),
                FontSize = 10,
                VerticalOptions = LayoutOptions.Center,
                AutomationId = $"log_entry_{i}_timestamp"
            };
            var level = new Label
            {
                Text = entry.Level,
                TextColor = entry.LevelColor,
                FontSize = 10,
                FontAttributes = FontAttributes.Bold,
                VerticalOptions = LayoutOptions.Center,
                Margin = new Thickness(4, 0),
                AutomationId = $"log_entry_{i}_level"
            };
            var msg = new Label
            {
                Text = entry.Message,
                TextColor = Color.FromArgb("#DDDDDD"),
                FontSize = 10,
                VerticalOptions = LayoutOptions.Center,
                AutomationId = $"log_entry_{i}_message"
            };

            row.Children.Add(ts);
            row.Children.Add(level);
            row.Children.Add(msg);
            row.AutomationId = $"log_entry_{i}";

            LogList.Children.Add(row);
            _logRows.Add(row);
        }

        UpdateCount();
    }

    private void UpdateCount()
    {
        LogCountLabel.Text = $"({LogManager.Instance.Logs.Count})";
    }

    private async Task ScrollToBottomAsync()
    {
        await Task.Delay(50);
        await LogScrollView.ScrollToAsync(0, LogScrollView.ContentSize.Height, false);
    }

    private void OnHeaderTapped(object? sender, TappedEventArgs e)
    {
        _isExpanded = !_isExpanded;
        LogScrollView.IsVisible = _isExpanded;
        CollapseArrow.Icon = _isExpanded ? MaterialIcons.ExpandLess : MaterialIcons.ExpandMore;
    }

    private void OnClearClicked(object? sender, EventArgs e)
    {
        LogManager.Instance.Clear();
        LogList.Children.Clear();
        _logRows.Clear();
        UpdateCount();
    }
}
