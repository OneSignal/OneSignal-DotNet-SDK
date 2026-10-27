using OneSignalDemo.Controls;
using OneSignalDemo.ViewModels;

namespace OneSignalDemo.Controls.Sections;

public partial class UserSection : ContentView
{
    private static readonly (string Name, string Code)[] LanguageOptions =
    {
        ("Device Default", ""),
        ("English", "en"),
        ("Arabic", "ar"),
        ("Azerbaijani", "az"),
        ("Bosnian", "bs"),
        ("Catalan", "ca"),
        ("Chinese (Simplified)", "zh-Hans"),
        ("Chinese (Traditional)", "zh-Hant"),
        ("Croatian", "hr"),
        ("Czech", "cs"),
        ("Danish", "da"),
        ("Dutch", "nl"),
        ("Estonian", "et"),
        ("Finnish", "fi"),
        ("French", "fr"),
        ("Georgian", "ka"),
        ("Bulgarian", "bg"),
        ("German", "de"),
        ("Greek", "el"),
        ("Hindi", "hi"),
        ("Hebrew", "he"),
        ("Hungarian", "hu"),
        ("Indonesian", "id"),
        ("Italian", "it"),
        ("Japanese", "ja"),
        ("Korean", "ko"),
        ("Latvian", "lv"),
        ("Lithuanian", "lt"),
        ("Malay", "ms"),
        ("Norwegian", "nb"),
        ("Persian", "fa"),
        ("Polish", "pl"),
        ("Portuguese", "pt"),
        ("Punjabi", "pa"),
        ("Romanian", "ro"),
        ("Russian", "ru"),
        ("Serbian", "sr"),
        ("Slovak", "sk"),
        ("Spanish", "es"),
        ("Swedish", "sv"),
        ("Thai", "th"),
        ("Turkish", "tr"),
        ("Ukrainian", "uk"),
        ("Vietnamese", "vi"),
    };

    private AppViewModel? _viewModel;
    private Page? _parentPage;
    private bool _suppressLanguageSelection;

    public UserSection()
    {
        InitializeComponent();
        LanguagePicker.ItemsSource = LanguageOptions.Select(o => o.Name).ToList();
    }

    public void Initialize(AppViewModel viewModel, Page parentPage)
    {
        _viewModel = viewModel;
        _parentPage = parentPage;
        UpdateUserDisplay(viewModel);
        UpdateLanguageSelection(viewModel);

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
                case nameof(AppViewModel.Language):
                    UpdateLanguageSelection(viewModel);
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

    private void UpdateLanguageSelection(AppViewModel vm)
    {
        var index = Array.FindIndex(LanguageOptions, o => o.Code == vm.Language);
        _suppressLanguageSelection = true;
        LanguagePicker.SelectedIndex = Math.Max(index, 0);
        _suppressLanguageSelection = false;
    }

    private void OnLanguageSelected(object? sender, EventArgs e)
    {
        if (_suppressLanguageSelection || _viewModel == null || LanguagePicker.SelectedIndex < 0)
            return;
        var code = LanguageOptions[LanguagePicker.SelectedIndex].Code;
        if (code != _viewModel.Language)
            _viewModel.SetLanguage(code);
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
