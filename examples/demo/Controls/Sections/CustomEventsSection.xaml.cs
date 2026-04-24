using System.Text.Json;
using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Extensions;
using OneSignalDemo.Controls;
using OneSignalDemo.ViewModels;

namespace OneSignalDemo.Controls.Sections;

public partial class CustomEventsSection : ContentView
{
    private AppViewModel? _viewModel;
    private Page? _parentPage;

    public event EventHandler? InfoTapped;

    public CustomEventsSection()
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
        if (_parentPage == null || _viewModel == null)
            return;

        var result = await ShowTrackEventPopup(_parentPage);
        if (result == null)
            return;

        _viewModel.TrackEvent(result.Value.name, result.Value.properties);
        await Snackbar.Make($"Event tracked: {result.Value.name}").Show();
    }

    private static async Task<(
        string name,
        Dictionary<string, object>? properties
    )?> ShowTrackEventPopup(Page parentPage)
    {
        var nameEntry = new Entry
        {
            Placeholder = "Event name",
            AutomationId = "event_name_input",
        };

        var propsEntry = new Entry
        {
            Placeholder = "{\"key\": \"value\"} (optional)",
            AutomationId = "event_properties_input",
        };

        var errorLabel = new Label
        {
            Text = "Invalid JSON format",
            TextColor = Color.FromArgb("#FF5370"),
            FontSize = 12,
            IsVisible = false,
        };

        var cancelButton = DialogInputHelper.ActionButton("Cancel");
        var confirmButton = DialogInputHelper.ActionButton("Track", "event_track_button");

        (string name, Dictionary<string, object>? properties)? popupResult = null;

        confirmButton.Clicked += async (s, ev) =>
        {
            var name = nameEntry.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrEmpty(name))
                return;

            var propsText = propsEntry.Text?.Trim() ?? string.Empty;
            Dictionary<string, object>? properties = null;

            if (!string.IsNullOrEmpty(propsText))
            {
                try
                {
                    using var doc = JsonDocument.Parse(propsText);
                    if (doc.RootElement.ValueKind != JsonValueKind.Object)
                        throw new JsonException("Root must be a JSON object");

                    properties = new Dictionary<string, object>();
                    foreach (var prop in doc.RootElement.EnumerateObject())
                    {
                        var value = JsonElementToObject(prop.Value);
                        if (value is not null)
                            properties[prop.Name] = value;
                    }
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

        var card = new VerticalStackLayout
        {
            BackgroundColor = Colors.White,
            WidthRequest = DialogInputHelper.PopupContentWidth(parentPage),
            Padding = new Thickness(24),
            Spacing = 12,
            Children =
            {
                new Label { Text = "Track Event", FontSize = 24 },
                new VerticalStackLayout
                {
                    Spacing = 8,
                    Children = { nameEntry, propsEntry, errorLabel },
                },
                new HorizontalStackLayout
                {
                    HorizontalOptions = LayoutOptions.End,
                    Spacing = 8,
                    Padding = new Thickness(0, 8, 0, 0),
                    Children = { cancelButton, confirmButton },
                },
            },
        };

        await parentPage.ShowPopupAsync<(string, Dictionary<string, object>?)?>(
            card,
            DialogInputHelper.DialogOptions
        );
        return popupResult;
    }

    private void OnInfoTapped(object? sender, EventArgs e) => InfoTapped?.Invoke(this, e);

    private static object? JsonElementToObject(JsonElement element) =>
        element.ValueKind switch
        {
            JsonValueKind.String => element.GetString(),
            JsonValueKind.Number => element.TryGetInt64(out var l) ? l : element.GetDouble(),
            JsonValueKind.True => true,
            JsonValueKind.False => false,
            JsonValueKind.Null => null,
            JsonValueKind.Object => element
                .EnumerateObject()
                .Where(p => p.Value.ValueKind != JsonValueKind.Null)
                .ToDictionary(p => p.Name, p => JsonElementToObject(p.Value)!),
            JsonValueKind.Array => element
                .EnumerateArray()
                .Select(JsonElementToObject)
                .ToList(),
            _ => null,
        };
}
