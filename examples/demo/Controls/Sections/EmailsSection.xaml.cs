using OneSignalDemo.ViewModels;

namespace OneSignalDemo.Controls.Sections;

public partial class EmailsSection : ContentView
{
    private AppViewModel? _viewModel;
    private Page? _parentPage;
    private bool _expanded;
    private const int CollapseThreshold = 5;

    public event EventHandler? InfoTapped;

    public EmailsSection()
    {
        InitializeComponent();
    }

    public void Initialize(AppViewModel viewModel, Page parentPage)
    {
        _viewModel = viewModel;
        _parentPage = parentPage;
        viewModel.EmailsList.CollectionChanged += (s, e) => RebuildList();
        RebuildList();
    }

    private void RebuildList()
    {
        EmailListContainer.Children.Clear();
        var list = _viewModel?.EmailsList;

        if (list == null || list.Count == 0)
        {
            EmailListContainer.Children.Add(EmptyLabel);
            return;
        }

        var displayList = (!_expanded && list.Count > CollapseThreshold)
            ? list.Take(CollapseThreshold).ToList()
            : list.ToList();

        bool first = true;
        foreach (var email in displayList)
        {
            if (!first)
                EmailListContainer.Children.Add(new BoxView { HeightRequest = 1, Color = Color.FromArgb("#E8EAED"), Margin = new Thickness(16, 0) });
            first = false;

            var captured = email;
            var row = new Grid
            {
                Padding = new Thickness(16, 12),
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Auto }
                }
            };

            row.Children.Add(new Label
            {
                Text = email,
                FontSize = 14,
                TextColor = Color.FromArgb("#333333"),
                VerticalOptions = LayoutOptions.Center
            });

            var deleteBtn = new Button
            {
                Text = "✕",
                BackgroundColor = Colors.Transparent,
                TextColor = Color.FromArgb("#E54B4D"),
                Padding = new Thickness(8, 0),
                FontSize = 14,
                HeightRequest = 40
            };
            deleteBtn.Clicked += (s, e) => _viewModel?.RemoveEmail(captured);
            Grid.SetColumn(deleteBtn, 1);
            row.Children.Add(deleteBtn);

            EmailListContainer.Children.Add(row);
        }

        if (!_expanded && list.Count > CollapseThreshold)
        {
            var more = list.Count - CollapseThreshold;
            var moreLabel = new Label
            {
                Text = $"{more} more",
                TextColor = Color.FromArgb("#E54B4D"),
                Padding = new Thickness(16, 8),
                FontSize = 13
            };
            moreLabel.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() => { _expanded = true; RebuildList(); })
            });
            EmailListContainer.Children.Add(moreLabel);
        }
    }

    private async void OnAddEmailClicked(object? sender, EventArgs e)
    {
        if (_parentPage == null || _viewModel == null) return;

        var entry = new Entry { Placeholder = "Email address", AutomationId = "email_input" };
        var result = await ShowSingleInputDialog("Add Email", entry, "ADD EMAIL");
        if (!result) return;

        var email = entry.Text?.Trim() ?? "";
        if (string.IsNullOrEmpty(email)) return;

        _viewModel.AddEmail(email);
    }

    private async Task<bool> ShowSingleInputDialog(string title, Entry entry, string confirmText)
    {
        if (_parentPage == null) return false;
        var tcs = new TaskCompletionSource<bool>();

        var confirmBtn = new Button
        {
            Text = confirmText,
            Style = Application.Current?.Resources["PrimaryButtonStyle"] as Style,
            Command = new Command(() => tcs.TrySetResult(true))
        };

        var page = new ContentPage
        {
            Title = title,
            Content = new VerticalStackLayout
            {
                Padding = new Thickness(16),
                Spacing = 12,
                Children = { entry, confirmBtn }
            }
        };

        page.Disappearing += (s, e) => tcs.TrySetResult(false);
        await _parentPage.Navigation.PushModalAsync(page);
        var result = await tcs.Task;
        if (_parentPage.Navigation.ModalStack.Contains(page))
            await _parentPage.Navigation.PopModalAsync();
        return result;
    }

    private void OnInfoTapped(object? sender, EventArgs e) => InfoTapped?.Invoke(this, e);
}
