using OneSignalDemo.ViewModels;

namespace OneSignalDemo.Controls.Sections;

public partial class SmsSection : ContentView
{
    private AppViewModel? _viewModel;
    private Page? _parentPage;
    private bool _expanded;
    private const int CollapseThreshold = 5;

    public event EventHandler? InfoTapped;

    public SmsSection()
    {
        InitializeComponent();
    }

    public void Initialize(AppViewModel viewModel, Page parentPage)
    {
        _viewModel = viewModel;
        _parentPage = parentPage;
        viewModel.SmsNumbersList.CollectionChanged += (s, e) => RebuildList();
        RebuildList();
    }

    private void RebuildList()
    {
        SmsListContainer.Children.Clear();
        var list = _viewModel?.SmsNumbersList;

        if (list == null || list.Count == 0)
        {
            SmsListContainer.Children.Add(EmptyLabel);
            return;
        }

        var displayList = (!_expanded && list.Count > CollapseThreshold)
            ? list.Take(CollapseThreshold).ToList()
            : list.ToList();

        bool first = true;
        foreach (var sms in displayList)
        {
            if (!first)
                SmsListContainer.Children.Add(new BoxView { HeightRequest = 1, Color = Color.FromArgb("#E8EAED"), Margin = new Thickness(16, 0) });
            first = false;

            var captured = sms;
            var row = new Grid
            {
                Padding = new Thickness(16, 12),
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Auto }
                }
            };

            row.Children.Add(new Label { Text = sms, FontSize = 14, TextColor = Color.FromArgb("#333333"), VerticalOptions = LayoutOptions.Center });

            var deleteBtn = new Button
            {
                Text = "✕",
                BackgroundColor = Colors.Transparent,
                TextColor = Color.FromArgb("#E54B4D"),
                Padding = new Thickness(8, 0),
                FontSize = 14,
                HeightRequest = 40
            };
            deleteBtn.Clicked += (s, e) => _viewModel?.RemoveSms(captured);
            Grid.SetColumn(deleteBtn, 1);
            row.Children.Add(deleteBtn);

            SmsListContainer.Children.Add(row);
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
            SmsListContainer.Children.Add(moreLabel);
        }
    }

    private async void OnAddSmsClicked(object? sender, EventArgs e)
    {
        if (_parentPage == null || _viewModel == null) return;

        var entry = new Entry { Placeholder = "Phone number", AutomationId = "sms_input" };
        var tcs = new TaskCompletionSource<bool>();

        var confirmBtn = new Button
        {
            Text = "ADD SMS",
            Style = Application.Current?.Resources["PrimaryButtonStyle"] as Style,
            Command = new Command(() => tcs.TrySetResult(true))
        };

        var page = new ContentPage
        {
            Title = "Add SMS",
            Content = new VerticalStackLayout
            {
                Padding = new Thickness(16),
                Spacing = 12,
                Children = { entry, confirmBtn }
            }
        };

        page.Disappearing += (s2, e2) => tcs.TrySetResult(false);
        await _parentPage.Navigation.PushModalAsync(page);
        var result = await tcs.Task;
        if (_parentPage.Navigation.ModalStack.Contains(page))
            await _parentPage.Navigation.PopModalAsync();

        if (!result) return;
        var sms = entry.Text?.Trim() ?? "";
        if (string.IsNullOrEmpty(sms)) return;
        _viewModel.AddSms(sms);
    }

    private void OnInfoTapped(object? sender, EventArgs e) => InfoTapped?.Invoke(this, e);
}
