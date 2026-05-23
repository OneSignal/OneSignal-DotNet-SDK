using OneSignalDemo.Controls;
using OneSignalDemo.Services;
using OneSignalDemo.ViewModels;

namespace OneSignalDemo.Pages;

public partial class MainPage : ContentPage
{
    private readonly AppViewModel _viewModel;
    private bool _initialLoadDone;

    public MainPage(AppViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;

        AppSectionControl.Initialize(_viewModel);

        UserSectionControl.Initialize(_viewModel, this);

        PushSectionControl.Initialize(_viewModel);
        PushSectionControl.InfoTapped += (s, e) => ShowTooltip("push");

        SendPushSectionControl.Initialize(_viewModel, this);
        SendPushSectionControl.InfoTapped += (s, e) => ShowTooltip("sendPushNotification");

        InAppSectionControl.Initialize(_viewModel);
        InAppSectionControl.InfoTapped += (s, e) => ShowTooltip("inAppMessaging");

        SendIamSectionControl.Initialize(_viewModel, this);
        SendIamSectionControl.InfoTapped += (s, e) => ShowTooltip("sendInAppMessage");

        AliasesSectionControl.Initialize(_viewModel, this);
        AliasesSectionControl.InfoTapped += (s, e) => ShowTooltip("aliases");

        EmailsSectionControl.Initialize(_viewModel, this);
        EmailsSectionControl.InfoTapped += (s, e) => ShowTooltip("emails");

        SmsSectionControl.Initialize(_viewModel, this);
        SmsSectionControl.InfoTapped += (s, e) => ShowTooltip("sms");

        TagsSectionControl.Initialize(_viewModel, this);
        TagsSectionControl.InfoTapped += (s, e) => ShowTooltip("tags");

        OutcomesSectionControl.Initialize(_viewModel, this);
        OutcomesSectionControl.InfoTapped += (s, e) => ShowTooltip("outcomes");

        TriggersSectionControl.Initialize(_viewModel, this);
        TriggersSectionControl.InfoTapped += (s, e) => ShowTooltip("triggers");

        CustomEventsSectionControl.Initialize(_viewModel, this);
        CustomEventsSectionControl.InfoTapped += (s, e) => ShowTooltip("customEvents");

        LocationSectionControl.Initialize(_viewModel);
        LocationSectionControl.InfoTapped += (s, e) => ShowTooltip("location");

#if IOS
        LiveActivitiesSectionControl.IsVisible = true;
        LiveActivitiesSectionControl.Initialize(_viewModel);
        LiveActivitiesSectionControl.InfoTapped += (s, e) => ShowTooltip("liveActivities");
#endif
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        if (_initialLoadDone)
            return;
        _initialLoadDone = true;
        await _viewModel.LoadInitialStateAsync();
        await _viewModel.PromptPushAsync();
    }

    private async void ShowTooltip(string key)
    {
        var tooltip = TooltipHelper.Instance.GetTooltip(key);
        if (tooltip == null)
            return;

        await TooltipDialogHelper.Show(this, tooltip);
    }

    private async void OnNextActivityClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new SecondaryPage());
    }
}
