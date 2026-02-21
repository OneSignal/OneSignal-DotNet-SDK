using OneSignalDemo.ViewModels;
using OneSignalDemo.Controls;

namespace OneSignalDemo.Controls.Sections;

public partial class TriggersSection : ContentView
{
    private AppViewModel? _viewModel;
    private Page? _parentPage;

    public event EventHandler? InfoTapped;

    public TriggersSection()
    {
        InitializeComponent();
    }

    public void Initialize(AppViewModel viewModel, Page parentPage)
    {
        _viewModel = viewModel;
        _parentPage = parentPage;
        viewModel.TriggersList.CollectionChanged += (s, e) => RebuildList();
        RebuildList();
    }

    private void RebuildList()
    {
        TriggerListContainer.Children.Clear();
        var list = _viewModel?.TriggersList;

        bool hasTriggers = list != null && list.Count > 0;
        RemoveSelectedButton.IsVisible = hasTriggers;
        ClearAllButton.IsVisible = hasTriggers;

        if (!hasTriggers)
        {
            TriggerListContainer.Children.Add(EmptyLabel);
            return;
        }

        bool first = true;
        foreach (var trigger in list!)
        {
            if (!first)
                TriggerListContainer.Children.Add(new BoxView { HeightRequest = 1, Color = Color.FromArgb("#E8EAED"), Margin = new Thickness(16, 0) });
            first = false;

            var captured = trigger;
            var row = new Grid
            {
                Padding = new Thickness(16, 12),
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Auto }
                }
            };

            var textStack = new VerticalStackLayout { Spacing = 2 };
            textStack.Children.Add(new Label { Text = trigger.Key, FontAttributes = FontAttributes.Bold, FontSize = 14, TextColor = Color.FromArgb("#333333") });
            textStack.Children.Add(new Label { Text = trigger.Value, FontSize = 13, TextColor = Color.FromArgb("#666666") });
            row.Children.Add(textStack);

            var deleteBtn = new Button
            {
                Text = "✕",
                BackgroundColor = Colors.Transparent,
                TextColor = Color.FromArgb("#E54B4D"),
                Padding = new Thickness(8, 0),
                FontSize = 14,
                HeightRequest = 40,
                VerticalOptions = LayoutOptions.Center
            };
            deleteBtn.Clicked += (s, e) => _viewModel?.RemoveTrigger(captured.Key);
            Grid.SetColumn(deleteBtn, 1);
            row.Children.Add(deleteBtn);

            TriggerListContainer.Children.Add(row);
        }
    }

    private async void OnAddClicked(object? sender, EventArgs e)
    {
        if (_parentPage == null || _viewModel == null) return;

        var form = await DialogInputHelper.ShowPairInput(
            _parentPage,
            "Add Trigger",
            new DialogInputField { Key = "key", Placeholder = "Key", AutomationId = "trigger_key_input" },
            new DialogInputField { Key = "value", Placeholder = "Value", AutomationId = "trigger_value_input" },
            "ADD"
        );

        if (
            form == null
            || !form.TryGetValue("key", out var key)
            || !form.TryGetValue("value", out var value)
            || string.IsNullOrEmpty(key)
            || string.IsNullOrEmpty(value)
        )
            return;
        _viewModel.AddTrigger(new KeyValuePair<string, string>(key, value));
    }

    private async void OnAddMultipleClicked(object? sender, EventArgs e)
    {
        if (_parentPage == null || _viewModel == null) return;
        var pairs = await MultiPairDialogHelper.Show(_parentPage, "Add Multiple Triggers", "Key", "Value");
        if (pairs == null || pairs.Count == 0) return;
        _viewModel.AddTriggers(pairs);
    }

    private async void OnRemoveSelectedClicked(object? sender, EventArgs e)
    {
        if (_parentPage == null || _viewModel == null) return;
        var keys = _viewModel.TriggersList.Select(t => t.Key).ToList();
        var selected = await MultiPairDialogHelper.ShowMultiSelect(_parentPage, "Remove Triggers", keys);
        if (selected == null || selected.Count == 0) return;
        _viewModel.RemoveSelectedTriggers(selected);
    }

    private void OnClearAllClicked(object? sender, EventArgs e)
    {
        _viewModel?.ClearTriggers();
    }

    private void OnInfoTapped(object? sender, EventArgs e) => InfoTapped?.Invoke(this, e);
}
