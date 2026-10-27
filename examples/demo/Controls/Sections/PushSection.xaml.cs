using OneSignalDemo.ViewModels;

namespace OneSignalDemo.Controls.Sections;

public partial class PushSection : ContentView
{
    private AppViewModel? _viewModel;
    private bool _suppressToggle;

    public event EventHandler? InfoTapped;
    public event EventHandler? PromptPushRequested;

    public PushSection()
    {
        InitializeComponent();
    }

    public void Initialize(AppViewModel viewModel)
    {
        _viewModel = viewModel;
        Refresh();

        viewModel.PropertyChanged += (s, e) =>
        {
            if (
                e.PropertyName
                is nameof(AppViewModel.PushSubscriptionId)
                    or nameof(AppViewModel.IsPushEnabled)
                    or nameof(AppViewModel.HasNotificationPermission)
                    or nameof(AppViewModel.PushSubscriptionStatus)
            )
            {
                Refresh();
            }
        };
    }

    private void Refresh()
    {
        if (_viewModel == null)
            return;
        PushIdLabel.Text = _viewModel.PushSubscriptionId;
        PushStatusLabel.Text = _viewModel.PushSubscriptionStatus;

        _suppressToggle = true;
        PushEnabledSwitch.IsToggled = _viewModel.IsPushEnabled;
        PushEnabledSwitch.IsEnabled = _viewModel.HasNotificationPermission;
        _suppressToggle = false;

        PromptPushButton.IsVisible = !_viewModel.HasNotificationPermission;
    }

    private void OnPushEnabledToggled(object? sender, ToggledEventArgs e)
    {
        if (_suppressToggle)
            return;
        _viewModel?.SetPushEnabled(e.Value);
    }

    private void OnInfoTapped(object? sender, EventArgs e) => InfoTapped?.Invoke(this, e);

    private async void OnPromptPushClicked(object? sender, EventArgs e)
    {
        PromptPushRequested?.Invoke(this, e);
        if (_viewModel != null)
            await _viewModel.PromptPushAsync();
    }
}
