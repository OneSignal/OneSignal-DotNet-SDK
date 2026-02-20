using System.Collections.Specialized;
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

            var row = new Grid
            {
                Padding = new Thickness(16, 12),
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star }
                }
            };
            row.Children.Add(new Label
            {
                Text = alias.Key,
                Style = Application.Current?.Resources["KeyLabelStyle"] as Style,
                VerticalOptions = LayoutOptions.Center
            });
            var valLabel = new Label
            {
                Text = alias.Value,
                Style = Application.Current?.Resources["ValueLabelStyle"] as Style,
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Center
            };
            Grid.SetColumn(valLabel, 1);
            row.Children.Add(valLabel);

            AliasListContainer.Children.Add(row);
        }
    }

    private async void OnAddClicked(object? sender, EventArgs e)
    {
        if (_parentPage == null || _viewModel == null) return;

        var keyEntry = new Entry { Placeholder = "Label", AutomationId = "alias_label_input" };
        var valueEntry = new Entry { Placeholder = "ID", AutomationId = "alias_id_input" };
        var layout = new VerticalStackLayout { Spacing = 8, Children = { keyEntry, valueEntry } };

        bool confirmed = await ShowPairDialog("Add Alias", layout, keyEntry, valueEntry, "ADD");
        if (!confirmed) return;

        var key = keyEntry.Text?.Trim() ?? "";
        var value = valueEntry.Text?.Trim() ?? "";
        if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(value)) return;

        _viewModel.AddAlias(new KeyValuePair<string, string>(key, value));
        await _parentPage.DisplayAlert("Success", $"Alias added: {key}", "OK");
    }

    private async void OnAddMultipleClicked(object? sender, EventArgs e)
    {
        if (_parentPage == null || _viewModel == null) return;
        var pairs = await ShowMultiPairDialog("Add Multiple Aliases", "Label", "ID");
        if (pairs == null || pairs.Count == 0) return;

        _viewModel.AddAliases(pairs);
        await _parentPage.DisplayAlert("Success", $"{pairs.Count} alias(es) added", "OK");
    }

    private async Task<bool> ShowPairDialog(string title, View content, Entry key, Entry value, string confirm)
    {
        if (_parentPage == null) return false;

        var tcs = new TaskCompletionSource<bool>();
        var page = new ContentPage
        {
            Title = title,
            Content = new VerticalStackLayout
            {
                Padding = new Thickness(16),
                Spacing = 12,
                Children =
                {
                    content,
                    new Button
                    {
                        Text = confirm,
                        Style = Application.Current?.Resources["PrimaryButtonStyle"] as Style,
                        Command = new Command(() => tcs.TrySetResult(true))
                    }
                }
            }
        };
        page.Disappearing += (s, e2) => tcs.TrySetResult(false);
        await _parentPage.Navigation.PushModalAsync(page);
        var result = await tcs.Task;
        if (_parentPage.Navigation.ModalStack.Contains(page))
            await _parentPage.Navigation.PopModalAsync();
        return result;
    }

    private async Task<Dictionary<string, string>?> ShowMultiPairDialog(string title, string keyLabel, string valueLabel)
    {
        if (_parentPage == null) return null;
        return await MultiPairDialogHelper.Show(_parentPage, title, keyLabel, valueLabel);
    }

    private void OnInfoTapped(object? sender, EventArgs e) => InfoTapped?.Invoke(this, e);
}
