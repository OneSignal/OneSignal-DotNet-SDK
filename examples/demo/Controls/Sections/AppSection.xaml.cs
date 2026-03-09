using OneSignalDemo.ViewModels;

namespace OneSignalDemo.Controls.Sections;

public partial class AppSection : ContentView
{
    private AppViewModel? _viewModel;
    private bool _suppressToggle;

    public AppSection()
    {
        InitializeComponent();
    }

    public void Initialize(AppViewModel viewModel)
    {
        _viewModel = viewModel;

        AppIdLabel.Text = viewModel.AppId;
        ConsentRequiredSwitch.IsToggled = viewModel.ConsentRequired;
        UpdatePrivacyConsentVisibility(viewModel.ConsentRequired);
        PrivacyConsentSwitch.IsToggled = viewModel.PrivacyConsentGiven;

        viewModel.PropertyChanged += (s, e) =>
        {
            switch (e.PropertyName)
            {
                case nameof(AppViewModel.AppId):
                    AppIdLabel.Text = viewModel.AppId;
                    break;
                case nameof(AppViewModel.ConsentRequired):
                    _suppressToggle = true;
                    ConsentRequiredSwitch.IsToggled = viewModel.ConsentRequired;
                    _suppressToggle = false;
                    UpdatePrivacyConsentVisibility(viewModel.ConsentRequired);
                    break;
                case nameof(AppViewModel.PrivacyConsentGiven):
                    _suppressToggle = true;
                    PrivacyConsentSwitch.IsToggled = viewModel.PrivacyConsentGiven;
                    _suppressToggle = false;
                    break;
            }
        };
    }

    private void UpdatePrivacyConsentVisibility(bool consentRequired)
    {
        ConsentDivider.IsVisible = consentRequired;
        PrivacyConsentRow.IsVisible = consentRequired;
    }

    private void OnConsentRequiredToggled(object? sender, ToggledEventArgs e)
    {
        if (_suppressToggle)
            return;
        _viewModel?.SetConsentRequired(e.Value);
        UpdatePrivacyConsentVisibility(e.Value);
    }

    private void OnPrivacyConsentToggled(object? sender, ToggledEventArgs e)
    {
        if (_suppressToggle)
            return;
        _viewModel?.SetConsentGiven(e.Value);
    }

    private async void OnGetKeysTapped(object? sender, TappedEventArgs e)
    {
        await Launcher.OpenAsync("https://onesignal.com");
    }
}
