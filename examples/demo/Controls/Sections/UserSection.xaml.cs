using OneSignalDemo.ViewModels;

namespace OneSignalDemo.Controls.Sections;

public partial class UserSection : ContentView
{
    private AppViewModel? _viewModel;

    public event EventHandler? LoginRequested;
    public event EventHandler? LogoutRequested;

    public UserSection()
    {
        InitializeComponent();
    }

    public void Initialize(AppViewModel viewModel)
    {
        _viewModel = viewModel;
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

    private void OnLoginClicked(object? sender, EventArgs e)
    {
        LoginRequested?.Invoke(this, e);
    }

    private void OnLogoutClicked(object? sender, EventArgs e)
    {
        LogoutRequested?.Invoke(this, e);
    }
}
