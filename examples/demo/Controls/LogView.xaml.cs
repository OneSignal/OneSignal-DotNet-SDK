using System.Collections.Specialized;
using MauiIcons.Core;
using MauiIcons.Material;
using OneSignalDemo.Services;

namespace OneSignalDemo.Controls;

public partial class LogView : ContentView
{
    public static readonly BindableProperty IsCollapsedProperty = BindableProperty.Create(
        nameof(IsCollapsed),
        typeof(bool),
        typeof(LogView),
        false,
        propertyChanged: (bindable, _, newValue) =>
            ((LogView)bindable).OnCollapsedChanged((bool)newValue)
    );

    private readonly Color _textColor;
    private readonly Color _mutedColor;
    private readonly Color _iconColor;
    private bool _hasEntryLabels;

    public LogView()
    {
        InitializeComponent();
        var resources = Application.Current!.Resources;
        _textColor = (Color)resources["OsLogText"];
        _mutedColor = (Color)resources["OsGrey600"];
        _iconColor = (Color)resources["OsGrey500"];

        EntriesLayout.SizeChanged += (_, _) => ScrollToEnd();
        // Entries is static, so only stay subscribed while attached or old views leak on Android activity recreation.
        Loaded += (_, _) =>
        {
            LogService.Entries.CollectionChanged += OnEntriesChanged;
            Render();
        };
        Unloaded += (_, _) => LogService.Entries.CollectionChanged -= OnEntriesChanged;
    }

    public bool IsCollapsed
    {
        get => (bool)GetValue(IsCollapsedProperty);
        set => SetValue(IsCollapsedProperty, value);
    }

    // Append in place: a full rebuild recreates every native view, and a UI read mid-rebuild
    // sees no entries. AutomationId can only be set before the platform view exists, so any
    // change that would shift indices still rebuilds.
    private void OnEntriesChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        var entries = LogService.Entries;
        var isAppend =
            e.Action == NotifyCollectionChangedAction.Add
            && _hasEntryLabels
            && e.NewStartingIndex == EntriesLayout.Children.Count;
        if (!isAppend)
        {
            Render();
            return;
        }

        for (var i = 0; i < e.NewItems!.Count; i++)
            EntriesLayout.Children.Add(
                CreateLogLabel((LogEntry)e.NewItems[i]!, e.NewStartingIndex + i)
            );
        HeaderLabel.Text = $"LOGS ({entries.Count})";
    }

    private void OnClearClicked(object? sender, EventArgs e) => LogService.Clear();

    private void OnToggleClicked(object? sender, EventArgs e) => IsCollapsed = !IsCollapsed;

    private void OnCollapsedChanged(bool collapsed)
    {
        LogScroll.IsVisible = !collapsed;
        ToggleButton.Source = (
            collapsed ? MaterialIcons.ExpandMore : MaterialIcons.ExpandLess
        ).ToImageSource(_iconColor, 18);
        SemanticProperties.SetDescription(
            ToggleButton,
            collapsed ? "Expand logs" : "Collapse logs"
        );
        if (!collapsed)
            ScrollToEnd();
    }

    // Rebuilt in full so `log_entry_{index}` stays 0-based after the oldest entries are dropped.
    private void Render()
    {
        var entries = LogService.Entries;
        HeaderLabel.Text = $"LOGS ({entries.Count})";
        EntriesLayout.Children.Clear();
        _hasEntryLabels = entries.Count > 0;

        if (entries.Count == 0)
        {
            EntriesLayout.Children.Add(
                CreateEntryLabel(
                    new FormattedString
                    {
                        Spans =
                        {
                            new Span { Text = "No logs yet", TextColor = _mutedColor },
                        },
                    }
                )
            );
            return;
        }

        for (var i = 0; i < entries.Count; i++)
            EntriesLayout.Children.Add(CreateLogLabel(entries[i], i));
    }

    private Label CreateLogLabel(LogEntry entry, int index)
    {
        var label = CreateEntryLabel(
            new FormattedString
            {
                Spans =
                {
                    new Span { Text = entry.Time, TextColor = _mutedColor },
                    new Span { Text = $" {entry.Message}", TextColor = _textColor },
                },
            }
        );
        label.AutomationId = $"log_entry_{index}";
        return label;
    }

    private static Label CreateEntryLabel(FormattedString text) =>
        new()
        {
            FormattedText = text,
            FontFamily = "DroidSansMono",
            FontSize = 8,
            LineHeight = 1.4,
            LineBreakMode = LineBreakMode.CharacterWrap,
        };

    private void ScrollToEnd()
    {
        if (!LogScroll.IsVisible)
            return;
        Dispatcher.Dispatch(async () =>
            await LogScroll.ScrollToAsync(EntriesLayout, ScrollToPosition.End, false)
        );
    }
}
