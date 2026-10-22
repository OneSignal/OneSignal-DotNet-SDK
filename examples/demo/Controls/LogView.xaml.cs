using System.Collections.Specialized;
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

    public LogView()
    {
        InitializeComponent();
        var resources = Application.Current!.Resources;
        _textColor = (Color)resources["OsLogText"];
        _mutedColor = (Color)resources["OsGrey600"];

        EntriesLayout.SizeChanged += (_, _) => ScrollToEnd();
        LogService.Entries.CollectionChanged += OnEntriesChanged;
        Render();
    }

    public bool IsCollapsed
    {
        get => (bool)GetValue(IsCollapsedProperty);
        set => SetValue(IsCollapsedProperty, value);
    }

    private void OnEntriesChanged(object? sender, NotifyCollectionChangedEventArgs e) => Render();

    private void OnClearClicked(object? sender, EventArgs e) => LogService.Clear();

    private void OnToggleClicked(object? sender, EventArgs e) => IsCollapsed = !IsCollapsed;

    private void OnCollapsedChanged(bool collapsed)
    {
        LogScroll.IsVisible = !collapsed;
        if (!collapsed)
            ScrollToEnd();
    }

    // Rebuilt in full so `log_entry_{index}` stays 0-based after the oldest entries are dropped.
    private void Render()
    {
        var entries = LogService.Entries;
        HeaderLabel.Text = $"LOGS ({entries.Count})";
        EntriesLayout.Children.Clear();

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
        {
            var label = CreateEntryLabel(
                new FormattedString
                {
                    Spans =
                    {
                        new Span { Text = entries[i].Time, TextColor = _mutedColor },
                        new Span { Text = $" {entries[i].Message}", TextColor = _textColor },
                    },
                }
            );
            label.AutomationId = $"log_entry_{i}";
            EntriesLayout.Children.Add(label);
        }
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
