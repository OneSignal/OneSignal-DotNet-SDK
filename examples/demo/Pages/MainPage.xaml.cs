using OneSignalDemo.Models;
using OneSignalDemo.Services;
using OneSignalDemo.ViewModels;
using OneSignalDemo.Controls;

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
        var userId = await DialogInputHelper.ShowSingleInput(
            this,
            "Login User",
            "External User Id",
            "LOGIN"
        );

        if (string.IsNullOrEmpty(userId))
        {
            return;
        }

        await _viewModel.LoginUserAsync(userId);
    }

    private async void OnLogoutRequested(object? sender, EventArgs e)
    {
        await _viewModel.LogoutUserAsync();
    }

    private async void OnCustomNotificationRequested(object? sender, EventArgs e)
    {
        var form = await DialogInputHelper.ShowForm(
            this,
            "Custom Notification",
            new[]
            {
                new DialogInputField
                {
                    Key = "title",
                    Placeholder = "Title",
                    AutomationId = "custom_notif_title_input",
                },
                new DialogInputField
                {
                    Key = "body",
                    Placeholder = "Body",
                    AutomationId = "custom_notif_body_input",
                },
            },
            "SEND",
            "custom_notif_send_button"
        );

        if (form == null || !form.TryGetValue("title", out var title) || string.IsNullOrEmpty(title))
            return;

        form.TryGetValue("body", out var body);
        await _viewModel.SendCustomNotificationAsync(title, body ?? string.Empty);
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
        await DisplayAlertAsync(tooltip.Title, message, "OK");
    }

    private async void OnNextActivityClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new SecondaryPage());
    }
}
