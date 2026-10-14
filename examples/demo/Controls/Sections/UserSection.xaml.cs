using OneSignalDemo.Controls;
using OneSignalDemo.ViewModels;

namespace OneSignalDemo.Controls.Sections;

public partial class UserSection : ContentView
{
    private AppViewModel? _viewModel;
    private Page? _parentPage;

    public UserSection()
    {
        InitializeComponent();
    }

    public void Initialize(AppViewModel viewModel, Page parentPage)
    {
        _viewModel = viewModel;
        _parentPage = parentPage;
#if ANDROID
        CompositeLoginButton.IsVisible = true;
#endif
        UpdateUserDisplay(viewModel);

        viewModel.PropertyChanged += (s, e) =>
        {
            switch (e.PropertyName)
            {
                case nameof(AppViewModel.UserStatus):
                case nameof(AppViewModel.ExternalIdDisplay):
                case nameof(AppViewModel.IsLoggedIn):
                case nameof(AppViewModel.LoginButtonText):
                    UpdateUserDisplay(viewModel);
                    break;
            }
        };
    }

    private void UpdateUserDisplay(AppViewModel vm)
    {
        StatusLabel.Text = vm.UserStatus;
        StatusLabel.TextColor = vm.IsLoggedIn
            ? Color.FromArgb("#34A853")
            : Color.FromArgb("#757575");
        ExternalIdLabel.Text = vm.ExternalIdDisplay;
        LoginButton.Text = vm.LoginButtonText;
        LogoutButton.IsVisible = vm.IsLoggedIn;
    }

    private async void OnLoginClicked(object? sender, EventArgs e)
    {
        if (_parentPage == null || _viewModel == null)
            return;

        var userId = await DialogInputHelper.ShowSingleInput(
            _parentPage,
            "Login User",
            "External User Id",
            "Login",
            "login_user_id_input"
        );

        if (string.IsNullOrEmpty(userId))
            return;

        await _viewModel.LoginUserAsync(userId);
    }

    private async void OnCompositeLoginClicked(object? sender, EventArgs e)
    {
        if (_parentPage == null || _viewModel == null)
            return;

        var form = await DialogInputHelper.ShowForm(
            _parentPage,
            "Login With Profile",
            new[]
            {
                new DialogInputField
                {
                    Key = "externalId",
                    Placeholder = "External User Id",
                    AutomationId = "composite_login_user_id_input",
                },
                new DialogInputField
                {
                    Key = "email",
                    Placeholder = "Email (optional)",
                    AutomationId = "composite_login_email_input",
                    Keyboard = Keyboard.Email,
                },
                new DialogInputField
                {
                    Key = "sms",
                    Placeholder = "SMS (optional)",
                    AutomationId = "composite_login_sms_input",
                    Keyboard = Keyboard.Telephone,
                },
                new DialogInputField
                {
                    Key = "jwt",
                    Placeholder = "JWT Token (optional)",
                    AutomationId = "composite_login_jwt_input",
                },
            },
            "Login",
            "composite_login_confirm_button"
        );

        if (form == null || string.IsNullOrEmpty(form["externalId"]))
            return;

        await _viewModel.LoginWithProfileAsync(
            form["externalId"],
            form["email"],
            form["sms"],
            form["jwt"]
        );
    }

    private async void OnLogoutClicked(object? sender, EventArgs e)
    {
        if (_viewModel == null)
            return;

        await _viewModel.LogoutUserAsync();
    }
}
