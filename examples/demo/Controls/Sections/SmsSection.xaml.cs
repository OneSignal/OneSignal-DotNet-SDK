using OneSignalDemo.Controls;
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

        var displayList =
            (!_expanded && list.Count > CollapseThreshold)
                ? list.Take(CollapseThreshold).ToList()
                : list.ToList();

        bool first = true;
        foreach (var sms in displayList)
        {
            if (!first)
                SmsListContainer.Children.Add(
                    new BoxView
                    {
                        HeightRequest = 1,
                        Color = Color.FromArgb("#E8EAED"),
                        Margin = new Thickness(12, 0),
                    }
                );
            first = false;

            var captured = sms;
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
                    Text = sms,
                    FontSize = 14,
                    VerticalOptions = LayoutOptions.Center,
                    AutomationId = $"sms_value_{sms}",
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
                AutomationId = $"sms_remove_{sms}",
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
            SmsListContainer.Children.Add(moreLabel);
        }
    }

    private async void OnAddSmsClicked(object? sender, EventArgs e)
    {
        if (_parentPage == null || _viewModel == null)
            return;

        var sms = await DialogInputHelper.ShowSingleInput(
            _parentPage,
            "Add SMS",
            "Phone number",
            "Add",
            "sms_input",
            keyboard: Keyboard.Telephone
        );

        if (string.IsNullOrEmpty(sms))
            return;
        _viewModel.AddSms(sms);
    }

    private void OnInfoTapped(object? sender, EventArgs e) => InfoTapped?.Invoke(this, e);
}
