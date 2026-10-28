using OneSignalDemo.Controls;
using OneSignalDemo.ViewModels;

namespace OneSignalDemo.Controls.Sections;

public partial class UserSection : ContentView
{
    private static readonly DropdownOption[] LanguageOptions =
    {
        new("Device Default", ""),
        new("English", "en"),
        new("Arabic", "ar"),
        new("Azerbaijani", "az"),
        new("Bosnian", "bs"),
        new("Catalan", "ca"),
        new("Chinese (Simplified)", "zh-Hans"),
        new("Chinese (Traditional)", "zh-Hant"),
        new("Croatian", "hr"),
        new("Czech", "cs"),
        new("Danish", "da"),
        new("Dutch", "nl"),
        new("Estonian", "et"),
        new("Finnish", "fi"),
        new("French", "fr"),
        new("Georgian", "ka"),
        new("Bulgarian", "bg"),
        new("German", "de"),
        new("Greek", "el"),
        new("Hindi", "hi"),
        new("Hebrew", "he"),
        new("Hungarian", "hu"),
        new("Indonesian", "id"),
        new("Italian", "it"),
        new("Japanese", "ja"),
        new("Korean", "ko"),
        new("Latvian", "lv"),
        new("Lithuanian", "lt"),
        new("Malay", "ms"),
        new("Norwegian", "nb"),
        new("Persian", "fa"),
        new("Polish", "pl"),
        new("Portuguese", "pt"),
        new("Punjabi", "pa"),
        new("Romanian", "ro"),
        new("Russian", "ru"),
        new("Serbian", "sr"),
        new("Slovak", "sk"),
        new("Spanish", "es"),
        new("Swedish", "sv"),
        new("Thai", "th"),
        new("Turkish", "tr"),
        new("Ukrainian", "uk"),
        new("Vietnamese", "vi"),
    };

    private AppViewModel? _viewModel;
    private Page? _parentPage;
    private DropdownMenu? _dropdownMenu;

    public UserSection()
    {
        InitializeComponent();
    }

    public void Initialize(AppViewModel viewModel, Page parentPage, DropdownMenu dropdownMenu)
    {
        _viewModel = viewModel;
        _parentPage = parentPage;
        _dropdownMenu = dropdownMenu;
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
        var option =
            LanguageOptions.FirstOrDefault(o => o.Value == vm.Language) ?? LanguageOptions[0];
        LanguageLabel.Text = option.Label;
    }

    private async void OnLanguageTapped(object? sender, TappedEventArgs e)
    {
        if (_dropdownMenu == null || _viewModel == null)
            return;
        var code = await _dropdownMenu.ShowAsync(
            LanguageDropdown,
            LanguageOptions,
            _viewModel.Language,
            "language_option"
        );
        if (code != null && code != _viewModel.Language)
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
