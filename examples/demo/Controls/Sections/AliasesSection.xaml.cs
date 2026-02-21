using System.Collections.Specialized;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using OneSignalDemo.Controls;
using OneSignalDemo.ViewModels;

namespace OneSignalDemo.Controls.Sections;

public partial class AliasesSection : ContentView
{
    private AppViewModel? _viewModel;
    private Page? _parentPage;

    public event EventHandler? InfoTapped;

    public AliasesSection()
    {
        InitializeComponent();
    }

    public void Initialize(AppViewModel viewModel, Page parentPage)
    {
        _viewModel = viewModel;
        _parentPage = parentPage;

        viewModel.AliasesList.CollectionChanged += (s, e) => RebuildList();
        RebuildList();
    }

    private void RebuildList()
    {
        AliasListContainer.Children.Clear();
        var list = _viewModel?.AliasesList;

        if (list == null || list.Count == 0)
        {
            AliasListContainer.Children.Add(EmptyLabel);
            return;
        }

        bool first = true;
        foreach (var alias in list)
        {
            if (!first)
            {
                AliasListContainer.Children.Add(new BoxView
                {
                    HeightRequest = 1,
                    Color = Color.FromArgb("#E8EAED"),
                    Margin = new Thickness(16, 0)
                });
            }
            first = false;

            var row = new VerticalStackLayout
            {
                Padding = new Thickness(16, 12),
                Spacing = 2
            };
            row.Children.Add(new Label
            {
                Text = alias.Key,
                FontAttributes = FontAttributes.Bold,
                FontSize = 14,
                TextColor = Color.FromArgb("#333333")
            });
            row.Children.Add(new Label
            {
                Text = alias.Value,
                FontSize = 13,
                TextColor = Color.FromArgb("#666666")
            });

            AliasListContainer.Children.Add(row);
        }
    }

    private async void OnAddClicked(object? sender, EventArgs e)
    {
        if (_parentPage == null || _viewModel == null) return;

        var form = await DialogInputHelper.ShowPairInput(
            _parentPage,
            "Add Alias",
            new DialogInputField { Key = "label", Placeholder = "Label", AutomationId = "alias_label_input" },
            new DialogInputField { Key = "id", Placeholder = "ID", AutomationId = "alias_id_input" },
            "ADD"
        );

        if (
            form == null
            || !form.TryGetValue("label", out var label)
            || !form.TryGetValue("id", out var id)
            || string.IsNullOrEmpty(label)
            || string.IsNullOrEmpty(id)
        )
            return;

        _viewModel.AddAlias(new KeyValuePair<string, string>(label, id));
        await Toast.Make($"Alias added: {label}", ToastDuration.Short).Show();
    }

    private async void OnAddMultipleClicked(object? sender, EventArgs e)
    {
        if (_parentPage == null || _viewModel == null) return;
        var pairs = await ShowMultiPairDialog("Add Multiple Aliases", "Label", "ID");
        if (pairs == null || pairs.Count == 0) return;

        _viewModel.AddAliases(pairs);
        await Toast.Make($"{pairs.Count} alias(es) added", ToastDuration.Short).Show();
    }

    private async Task<Dictionary<string, string>?> ShowMultiPairDialog(string title, string keyLabel, string valueLabel)
    {
        if (_parentPage == null) return null;
        return await MultiPairDialogHelper.Show(_parentPage, title, keyLabel, valueLabel);
    }

    private void OnInfoTapped(object? sender, EventArgs e) => InfoTapped?.Invoke(this, e);
}
