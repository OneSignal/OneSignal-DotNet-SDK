using System.Text.Json;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
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

        var form = await DialogInputHelper.ShowForm(
            _parentPage,
            "Track Event",
            new[]
            {
                new DialogInputField
                {
                    Key = "name",
                    Placeholder = "Event name",
                    AutomationId = "track_event_name_input",
                },
                new DialogInputField
                {
                    Key = "props",
                    Placeholder = "{\"key\": \"value\"} (optional)",
                    AutomationId = "track_event_props_input",
                },
            },
            "TRACK",
            "track_event_confirm_button"
        );

        if (form == null || !form.TryGetValue("name", out var name) || string.IsNullOrEmpty(name))
            return;

        form.TryGetValue("props", out var propsText);

        Dictionary<string, object>? properties = null;
        if (!string.IsNullOrEmpty(propsText))
        {
            try
            {
                var doc = JsonDocument.Parse(propsText);
                properties = new Dictionary<string, object>();
                foreach (var prop in doc.RootElement.EnumerateObject())
                    properties[prop.Name] = prop.Value.GetString() ?? "";
            }
            catch
            {
                await _parentPage.DisplayAlertAsync("Invalid JSON", "Properties must be valid JSON.", "OK");
                return;
            }
        }

        _viewModel.TrackEvent(name, properties);
        await Toast.Make($"Event tracked: {name}", ToastDuration.Short).Show();
    }

    private void OnInfoTapped(object? sender, EventArgs e) => InfoTapped?.Invoke(this, e);
}
