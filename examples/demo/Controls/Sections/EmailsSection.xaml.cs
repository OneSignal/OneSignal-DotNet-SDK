using OneSignalDemo.Controls;
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

        var displayList =
            (!_expanded && list.Count > CollapseThreshold)
                ? list.Take(CollapseThreshold).ToList()
                : list.ToList();

        bool first = true;
        foreach (var email in displayList)
        {
            if (!first)
                EmailListContainer.Children.Add(
                    new BoxView
                    {
                        HeightRequest = 1,
                        Color = Color.FromArgb("#E8EAED"),
                        Margin = new Thickness(12, 0),
                    }
                );
            first = false;

            var captured = email;
            var row = new Grid
            {
                Padding = new Thickness(12, 4),
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Auto },
                },
            };

            row.Children.Add(
                new Label
                {
                    Text = email,
                    FontSize = 14,
                    VerticalOptions = LayoutOptions.Center,
                    AutomationId = $"emails_value_{email}",
                }
            );

            var deleteBtn = new Button
            {
                Text = "✕",
                BackgroundColor = Colors.Transparent,
                TextColor = Color.FromArgb("#E54B4D"),
                Padding = new Thickness(8, 0),
                FontSize = 18,
                HeightRequest = 40,
                AutomationId = $"emails_remove_{email}",
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
                FontAttributes = FontAttributes.Bold,
                Padding = new Thickness(12, 4),
                FontSize = 14,
            };
            moreLabel.GestureRecognizers.Add(
                new TapGestureRecognizer
                {
                    Command = new Command(() =>
                    {
                        _expanded = true;
                        RebuildList();
                    }),
                }
            );
            EmailListContainer.Children.Add(moreLabel);
        }
    }

    private async void OnAddEmailClicked(object? sender, EventArgs e)
    {
        if (_parentPage == null || _viewModel == null)
            return;

        var email = await DialogInputHelper.ShowSingleInput(
            _parentPage,
            "Add Email",
            "Email address",
            "Add",
            "email_input"
        );

        if (string.IsNullOrEmpty(email))
            return;
        _viewModel.AddEmail(email);
    }

    private void OnInfoTapped(object? sender, EventArgs e) => InfoTapped?.Invoke(this, e);
}
