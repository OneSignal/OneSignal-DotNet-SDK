using OneSignalDemo.ViewModels;

namespace OneSignalDemo.Controls.Sections;

public partial class AppSection : ContentView
{
    private AppViewModel? _viewModel;

    public event EventHandler? LoginRequested;
    public event EventHandler? LogoutRequested;

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
        UpdateUserDisplay(viewModel);

        viewModel.PropertyChanged += (s, e) =>
        {
            switch (e.PropertyName)
            {
                case nameof(AppViewModel.UserStatus):
                case nameof(AppViewModel.ExternalIdDisplay):
                case nameof(AppViewModel.IsLoggedIn):
                    UpdateUserDisplay(viewModel);
                    break;
            }
        };
    }

    private void UpdateUserDisplay(AppViewModel vm)
    {
        StatusLabel.Text = vm.UserStatus;
        StatusLabel.TextColor = vm.IsLoggedIn
            ? Color.FromArgb("#2E7D32")
            : Color.FromArgb("#666666");
        ExternalIdLabel.Text = vm.ExternalIdDisplay;
        LoginButton.Text = vm.LoginButtonText;
        LogoutButton.IsVisible = vm.IsLoggedIn;
    }

    private void UpdatePrivacyConsentVisibility(bool consentRequired)
    {
        ConsentDivider.IsVisible = consentRequired;
        PrivacyConsentRow.IsVisible = consentRequired;
    }

    private void OnConsentRequiredToggled(object? sender, ToggledEventArgs e)
    {
        _viewModel?.SetConsentRequired(e.Value);
        UpdatePrivacyConsentVisibility(e.Value);
    }

    private void OnPrivacyConsentToggled(object? sender, ToggledEventArgs e)
    {
        _viewModel?.SetConsentGiven(e.Value);
    }

    private void OnLoginClicked(object? sender, EventArgs e)
    {
        LoginRequested?.Invoke(this, e);
    }

    private void OnLogoutClicked(object? sender, EventArgs e)
    {
        LogoutRequested?.Invoke(this, e);
    }

    private async void OnGetKeysTapped(object? sender, TappedEventArgs e)
    {
        await Launcher.OpenAsync("https://onesignal.com");
    }
}
