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

    private async void OnLogoutClicked(object? sender, EventArgs e)
    {
        if (_viewModel == null)
            return;

        await _viewModel.LogoutUserAsync();
    }
}
