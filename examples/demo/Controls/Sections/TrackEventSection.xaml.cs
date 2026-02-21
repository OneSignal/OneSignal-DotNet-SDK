using System.Text.Json;
using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Extensions;
using Microsoft.Maui.Controls.Shapes;
using OneSignalDemo.Controls;
using OneSignalDemo.ViewModels;

namespace OneSignalDemo.Controls.Sections;

public partial class TrackEventSection : ContentView
{
    private AppViewModel? _viewModel;
    private Page? _parentPage;

    public event EventHandler? InfoTapped;

    public TrackEventSection()
    {
        InitializeComponent();
    }

    public void Initialize(AppViewModel viewModel, Page parentPage)
    {
        _viewModel = viewModel;
        _parentPage = parentPage;
    }

    private async void OnTrackEventClicked(object? sender, EventArgs e)
    {
        if (_parentPage == null || _viewModel == null) return;

        var result = await ShowTrackEventPopup(_parentPage);
        if (result == null) return;

        _viewModel.TrackEvent(result.Value.name, result.Value.properties);
        await Toast.Make($"Event tracked: {result.Value.name}", ToastDuration.Short).Show();
    }

    private static async Task<(string name, Dictionary<string, object>? properties)?> ShowTrackEventPopup(Page parentPage)
    {
        var nameEntry = new Entry
        {
            Placeholder = "Event name",
            AutomationId = "track_event_name_input",
        };

        var propsEntry = new Entry
        {
            Placeholder = "{\"key\": \"value\"} (optional)",
            AutomationId = "track_event_props_input",
        };

        var errorLabel = new Label
        {
            Text = "Invalid JSON format",
            TextColor = Color.FromArgb("#E54B4D"),
            FontSize = 12,
            IsVisible = false,
        };

        var cancelButton = GhostButton("CANCEL", Color.FromArgb("#6E6E73"));
        var confirmButton = GhostButton("TRACK", Color.FromArgb("#E54B4D"), "track_event_confirm_button");

        (string name, Dictionary<string, object>? properties)? popupResult = null;

        confirmButton.Clicked += async (s, ev) =>
        {
            var name = nameEntry.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrEmpty(name)) return;

            var propsText = propsEntry.Text?.Trim() ?? string.Empty;
            Dictionary<string, object>? properties = null;

            if (!string.IsNullOrEmpty(propsText))
            {
                try
                {
                    var doc = JsonDocument.Parse(propsText);
                    properties = new Dictionary<string, object>();
                    foreach (var prop in doc.RootElement.EnumerateObject())
                        properties[prop.Name] = prop.Value.GetString() ?? string.Empty;
                    errorLabel.IsVisible = false;
                }
                catch
                {
                    errorLabel.IsVisible = true;
                    return;
                }
            }
            else
            {
                errorLabel.IsVisible = false;
            }

            popupResult = (name, properties);
            await parentPage.ClosePopupAsync(popupResult);
        };

        cancelButton.Clicked += async (s, ev) => await parentPage.ClosePopupAsync();

        Grid.SetColumn(confirmButton, 1);

        var width = parentPage.Width > 0 ? parentPage.Width : 320;

        var card = new VerticalStackLayout
        {
            BackgroundColor = Colors.White,
            WidthRequest = Math.Max(240, width - 32),
            Padding = new Thickness(16),
            Spacing = 12,
            Children =
            {
                new Label { Text = "Track Event", FontAttributes = FontAttributes.Bold, FontSize = 16 },
                new VerticalStackLayout
                {
                    Spacing = 8,
                    Children =
                    {
                        nameEntry,
                        propsEntry,
                        errorLabel,
                    }
                },
                new Grid
                {
                    ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star },
                    },
                    Children = { cancelButton, confirmButton },
                },
            },
        };

        var options = new PopupOptions
        {
            CanBeDismissedByTappingOutsideOfPopup = true,
            PageOverlayColor = Colors.Black.WithAlpha(0.4f),
            Shape = new RoundRectangle { CornerRadius = 12, StrokeThickness = 0, Stroke = new SolidColorBrush(Colors.Transparent) },
            Shadow = new Shadow
            {
                Brush = new SolidColorBrush(Colors.Black),
                Opacity = 0.12f,
                Radius = 10,
                Offset = new Microsoft.Maui.Graphics.Point(0, 2),
            },
        };

        await parentPage.ShowPopupAsync<(string, Dictionary<string, object>?)?>(card, options);
        return popupResult;
    }

    private static Button GhostButton(string text, Color textColor, string? automationId = null) => new()
    {
        Text = text,
        Style = null,
        BackgroundColor = Colors.Transparent,
        TextColor = textColor,
        FontAttributes = FontAttributes.Bold,
        BorderWidth = 0,
        BorderColor = Colors.Transparent,
        Shadow = null,
        HorizontalOptions = LayoutOptions.Fill,
        AutomationId = automationId ?? string.Empty,
    };

    private void OnInfoTapped(object? sender, EventArgs e) => InfoTapped?.Invoke(this, e);
}
