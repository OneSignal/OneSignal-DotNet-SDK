using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Extensions;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Devices;
using OneSignalDemo.ViewModels;

namespace OneSignalDemo.Controls.Sections;

public partial class OutcomesSection : ContentView
{
    private AppViewModel? _viewModel;
    private Page? _parentPage;

    public event EventHandler? InfoTapped;

    public OutcomesSection()
    {
        InitializeComponent();
    }

    public void Initialize(AppViewModel viewModel, Page parentPage)
    {
        _viewModel = viewModel;
        _parentPage = parentPage;
    }

    private async void OnSendOutcomeClicked(object? sender, EventArgs e)
    {
        if (_parentPage == null || _viewModel == null) return;

        const string group = "outcome_type";
        var radioNormal = new RadioButton { Content = "Normal Outcome", GroupName = group, IsChecked = true };
        var radioUnique = new RadioButton { Content = "Unique Outcome", GroupName = group };
        var radioWithValue = new RadioButton { Content = "Outcome with Value", GroupName = group };

        var nameEntry = new Entry { Placeholder = "Outcome name", AutomationId = "outcome_name_input" };
        var valueEntry = new Entry { Placeholder = "Value (float)", Keyboard = Keyboard.Numeric, AutomationId = "outcome_value_input" };
        var valueContainer = new VerticalStackLayout { IsVisible = false, Children = { valueEntry } };

        radioWithValue.CheckedChanged += (s, e2) => valueContainer.IsVisible = e2.Value;
        radioNormal.CheckedChanged += (s, e2) => { if (e2.Value) valueContainer.IsVisible = false; };
        radioUnique.CheckedChanged += (s, e2) => { if (e2.Value) valueContainer.IsVisible = false; };

        var cancelButton = new Button
        {
            Text = "CANCEL",
            Style = null,
            BackgroundColor = Colors.Transparent,
            TextColor = Color.FromArgb("#6E6E73"),
            FontAttributes = FontAttributes.Bold,
            BorderWidth = 0,
            BorderColor = Colors.Transparent,
            Shadow = null,
            HorizontalOptions = LayoutOptions.Fill,
        };

        var sendButton = new Button
        {
            Text = "SEND",
            Style = null,
            BackgroundColor = Colors.Transparent,
            TextColor = Color.FromArgb("#E54B4D"),
            FontAttributes = FontAttributes.Bold,
            BorderWidth = 0,
            BorderColor = Colors.Transparent,
            Shadow = null,
            HorizontalOptions = LayoutOptions.Fill,
        };

        string? outcomeType = null;
        string? name = null;
        string? valueStr = null;

        cancelButton.Clicked += async (s, e2) => await _parentPage.ClosePopupAsync();
        sendButton.Clicked += async (s, e2) =>
        {
            outcomeType = radioWithValue.IsChecked ? "Outcome with Value"
                        : radioUnique.IsChecked ? "Unique Outcome"
                        : "Normal Outcome";
            name = nameEntry.Text?.Trim();
            valueStr = valueEntry.Text?.Trim();
            await _parentPage.ClosePopupAsync();
        };

        Grid.SetColumn(sendButton, 1);

        var content = new VerticalStackLayout
        {
            BackgroundColor = Colors.White,
            WidthRequest = PopupContentWidth(_parentPage),
            Padding = new Thickness(16),
            Spacing = 12,
            Children =
            {
                new Label { Text = "Send Outcome", FontAttributes = FontAttributes.Bold, FontSize = 16 },
                new VerticalStackLayout
                {
                    Spacing = 4,
                    Children = { radioNormal, radioUnique, radioWithValue }
                },
                nameEntry,
                valueContainer,
                new Grid
                {
                    ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star },
                    },
                    Children = { cancelButton, sendButton },
                },
            },
        };

        await _parentPage.ShowPopupAsync(
            content,
            new PopupOptions
            {
                CanBeDismissedByTappingOutsideOfPopup = true,
                PageOverlayColor = Colors.Black.WithAlpha(0.4f),
                Shape = new RoundRectangle
                {
                    CornerRadius = 12,
                    StrokeThickness = 0,
                    Stroke = new SolidColorBrush(Colors.Transparent),
                },
                Shadow = new Shadow
                {
                    Brush = new SolidColorBrush(Colors.Black),
                    Opacity = 0.12f,
                    Radius = 10,
                    Offset = new Microsoft.Maui.Graphics.Point(0, 2),
                },
            }
        );

        if (string.IsNullOrEmpty(outcomeType) || string.IsNullOrEmpty(name))
            return;

        if (outcomeType == "Outcome with Value")
        {
            if (!float.TryParse(valueStr, out float val))
                return;
            _viewModel.SendOutcomeWithValue(name, val);
        }
        else if (outcomeType == "Unique Outcome")
        {
            _viewModel.SendUniqueOutcome(name);
        }
        else
        {
            _viewModel.SendOutcome(name);
        }

        await Toast.Make($"Outcome sent: {name}", ToastDuration.Short).Show();
    }

    private void OnInfoTapped(object? sender, EventArgs e) => InfoTapped?.Invoke(this, e);

    private static double PopupContentWidth(Page? page)
    {
        var width = (page?.Width ?? 0) > 0 ? page!.Width : DeviceDisplay.Current.MainDisplayInfo.Width / DeviceDisplay.Current.MainDisplayInfo.Density;
        return Math.Max(240, width - 32);
    }
}
