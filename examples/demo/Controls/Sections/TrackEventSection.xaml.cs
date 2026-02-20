using System.Text.Json;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
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

        var nameEntry = new Entry { Placeholder = "Event name", AutomationId = "track_event_name_input" };
        var propsEntry = new Entry { Placeholder = "{\"key\": \"value\"}", AutomationId = "track_event_props_input" };
        var errorLabel = new Label { TextColor = Colors.Red, FontSize = 12, IsVisible = false };

        var trackBtn = new Button
        {
            Text = "TRACK",
            Style = Application.Current?.Resources["PrimaryButtonStyle"] as Style,
            AutomationId = "track_event_confirm_button"
        };

        var tcs = new TaskCompletionSource<bool>();

        void Validate()
        {
            var name = nameEntry.Text?.Trim() ?? "";
            var props = propsEntry.Text?.Trim() ?? "";

            if (string.IsNullOrEmpty(name))
            {
                trackBtn.IsEnabled = false;
                errorLabel.IsVisible = false;
                return;
            }

            if (!string.IsNullOrEmpty(props))
            {
                try { JsonDocument.Parse(props); errorLabel.IsVisible = false; }
                catch { errorLabel.Text = "Invalid JSON format"; errorLabel.IsVisible = true; trackBtn.IsEnabled = false; return; }
            }
            else
            {
                errorLabel.IsVisible = false;
            }

            trackBtn.IsEnabled = true;
        }

        nameEntry.TextChanged += (s, ev) => Validate();
        propsEntry.TextChanged += (s, ev) => Validate();
        trackBtn.IsEnabled = false;

        trackBtn.Clicked += (s, ev) => tcs.TrySetResult(true);

        var page = new ContentPage
        {
            Title = "Track Event",
            Content = new VerticalStackLayout
            {
                Padding = new Thickness(16),
                Spacing = 12,
                Children =
                {
                    new Label { Text = "Event Name", FontAttributes = FontAttributes.Bold, FontSize = 14 },
                    nameEntry,
                    new Label { Text = "Properties (optional, JSON)", FontAttributes = FontAttributes.Bold, FontSize = 14 },
                    propsEntry,
                    errorLabel,
                    trackBtn
                }
            }
        };

        page.Disappearing += (s2, e2) => tcs.TrySetResult(false);
        await _parentPage.Navigation.PushModalAsync(page);
        var result = await tcs.Task;
        if (_parentPage.Navigation.ModalStack.Contains(page))
            await _parentPage.Navigation.PopModalAsync();

        if (!result) return;

        var name = nameEntry.Text?.Trim() ?? "";
        if (string.IsNullOrEmpty(name)) return;

        Dictionary<string, object>? properties = null;
        var propsText = propsEntry.Text?.Trim() ?? "";
        if (!string.IsNullOrEmpty(propsText))
        {
            try
            {
                var doc = JsonDocument.Parse(propsText);
                properties = new Dictionary<string, object>();
                foreach (var prop in doc.RootElement.EnumerateObject())
                    properties[prop.Name] = prop.Value.GetString() ?? "";
            }
            catch { }
        }

        _viewModel.TrackEvent(name, properties);
        await Toast.Make($"Event tracked: {name}", ToastDuration.Short).Show();
    }

    private void OnInfoTapped(object? sender, EventArgs e) => InfoTapped?.Invoke(this, e);
}
