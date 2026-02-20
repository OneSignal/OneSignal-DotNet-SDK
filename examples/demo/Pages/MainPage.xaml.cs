using OneSignalDemo.Models;
using OneSignalDemo.Services;
using OneSignalDemo.ViewModels;

namespace OneSignalDemo.Pages;

public partial class MainPage : ContentPage
{
    private readonly AppViewModel _viewModel;

    public MainPage(AppViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;

        // Bind loading overlay
        _viewModel.PropertyChanged += (s, e) =>
        {
            if (e.PropertyName == nameof(AppViewModel.IsLoading))
                LoadingOverlayControl.IsVisible = _viewModel.IsLoading;
        };

        // Wire up sections
        AppSectionControl.Initialize(_viewModel);
        AppSectionControl.LoginRequested += OnLoginRequested;
        AppSectionControl.LogoutRequested += OnLogoutRequested;

        PushSectionControl.Initialize(_viewModel);
        PushSectionControl.InfoTapped += (s, e) => ShowTooltip("push");

        SendPushSectionControl.Initialize(_viewModel);
        SendPushSectionControl.InfoTapped += (s, e) => ShowTooltip("send_push");
        SendPushSectionControl.CustomNotificationRequested += OnCustomNotificationRequested;

        InAppSectionControl.Initialize(_viewModel);
        InAppSectionControl.InfoTapped += (s, e) => ShowTooltip("in_app_messaging");

        SendIamSectionControl.Initialize(_viewModel, this);
        SendIamSectionControl.InfoTapped += (s, e) => ShowTooltip("send_iam");

        AliasesSectionControl.Initialize(_viewModel, this);
        AliasesSectionControl.InfoTapped += (s, e) => ShowTooltip("aliases");

        EmailsSectionControl.Initialize(_viewModel, this);
        EmailsSectionControl.InfoTapped += (s, e) => ShowTooltip("emails");

        SmsSectionControl.Initialize(_viewModel, this);
        SmsSectionControl.InfoTapped += (s, e) => ShowTooltip("sms");

        TagsSectionControl.Initialize(_viewModel, this);
        TagsSectionControl.InfoTapped += (s, e) => ShowTooltip("tags");

        OutcomesSectionControl.Initialize(_viewModel, this);
        OutcomesSectionControl.InfoTapped += (s, e) => ShowTooltip("outcome_events");

        TriggersSectionControl.Initialize(_viewModel, this);
        TriggersSectionControl.InfoTapped += (s, e) => ShowTooltip("triggers");

        TrackEventSectionControl.Initialize(_viewModel, this);
        TrackEventSectionControl.InfoTapped += (s, e) => ShowTooltip("track_event");

        LocationSectionControl.Initialize(_viewModel);
        LocationSectionControl.InfoTapped += (s, e) => ShowTooltip("location");
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.LoadInitialStateAsync();
        await _viewModel.PromptPushAsync();
    }

    private async void OnLoginRequested(object? sender, EventArgs e)
    {
        var entry = new Entry { Placeholder = "External User Id", AutomationId = "login_user_id_input" };
        var tcs = new TaskCompletionSource<bool>();

        var confirmBtn = new Button
        {
            Text = "LOGIN",
            Style = Application.Current?.Resources["PrimaryButtonStyle"] as Style,
            AutomationId = "login_confirm_button",
            Command = new Command(() => tcs.TrySetResult(true))
        };

        var page = new ContentPage
        {
            Title = _viewModel.IsLoggedIn ? "Switch User" : "Login User",
            Content = new VerticalStackLayout
            {
                Padding = new Thickness(16),
                Spacing = 12,
                Children = { entry, confirmBtn }
            }
        };

        page.Disappearing += (s2, e2) => tcs.TrySetResult(false);
        await Navigation.PushModalAsync(page);
        var result = await tcs.Task;
        if (Navigation.ModalStack.Contains(page))
            await Navigation.PopModalAsync();

        if (!result) return;
        var userId = entry.Text?.Trim() ?? "";
        if (string.IsNullOrEmpty(userId)) return;

        await _viewModel.LoginUserAsync(userId);
        await DisplayAlert("Success", $"Logged in as: {userId}", "OK");
    }

    private async void OnLogoutRequested(object? sender, EventArgs e)
    {
        await _viewModel.LogoutUserAsync();
        await DisplayAlert("Success", "Logged out", "OK");
    }

    private async void OnCustomNotificationRequested(object? sender, EventArgs e)
    {
        var titleEntry = new Entry { Placeholder = "Title", AutomationId = "custom_notif_title_input" };
        var bodyEntry = new Entry { Placeholder = "Body", AutomationId = "custom_notif_body_input" };
        var tcs = new TaskCompletionSource<bool>();

        var confirmBtn = new Button
        {
            Text = "SEND",
            Style = Application.Current?.Resources["PrimaryButtonStyle"] as Style,
            AutomationId = "custom_notif_send_button",
            Command = new Command(() => tcs.TrySetResult(true))
        };

        var page = new ContentPage
        {
            Title = "Custom Notification",
            Content = new VerticalStackLayout
            {
                Padding = new Thickness(16),
                Spacing = 12,
                Children = { titleEntry, bodyEntry, confirmBtn }
            }
        };

        page.Disappearing += (s2, e2) => tcs.TrySetResult(false);
        await Navigation.PushModalAsync(page);
        var result = await tcs.Task;
        if (Navigation.ModalStack.Contains(page))
            await Navigation.PopModalAsync();

        if (!result) return;
        var title = titleEntry.Text?.Trim() ?? "";
        var body = bodyEntry.Text?.Trim() ?? "";
        if (string.IsNullOrEmpty(title)) return;

        await _viewModel.SendCustomNotificationAsync(title, body);
    }

    private async void ShowTooltip(string key)
    {
        var tooltip = TooltipHelper.Instance.GetTooltip(key);
        if (tooltip == null) return;

        var message = tooltip.Description;
        if (tooltip.Options != null && tooltip.Options.Count > 0)
        {
            message += "\n\n" + string.Join("\n\n", tooltip.Options.Select(o => $"• {o.Name}: {o.Description}"));
        }
        await DisplayAlert(tooltip.Title, message, "OK");
    }

    private async void OnNextActivityClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new SecondaryPage());
    }
}
