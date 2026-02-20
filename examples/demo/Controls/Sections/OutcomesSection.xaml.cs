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

        var picker = new Picker { Title = "Outcome Type", SelectedIndex = 0 };
        picker.Items.Add("Normal Outcome");
        picker.Items.Add("Unique Outcome");
        picker.Items.Add("Outcome with Value");

        var nameEntry = new Entry { Placeholder = "Outcome name" };
        var valueEntry = new Entry { Placeholder = "Value (float)", Keyboard = Keyboard.Numeric };
        var valueContainer = new VerticalStackLayout { IsVisible = false, Children = { valueEntry } };

        picker.SelectedIndexChanged += (s, e2) =>
        {
            valueContainer.IsVisible = picker.SelectedIndex == 2;
        };

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
            outcomeType = picker.SelectedItem?.ToString();
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
                picker,
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
