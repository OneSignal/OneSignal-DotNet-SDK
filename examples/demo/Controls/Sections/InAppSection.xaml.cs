using OneSignalDemo.ViewModels;

namespace OneSignalDemo.Controls.Sections;

public partial class InAppSection : ContentView
{
    private AppViewModel? _viewModel;
    private bool _suppressToggle;

    public event EventHandler? InfoTapped;

    public InAppSection()
    {
        InitializeComponent();
    }

    public void Initialize(AppViewModel viewModel)
    {
        _viewModel = viewModel;
        _suppressToggle = true;
        IamPausedSwitch.IsToggled = viewModel.InAppMessagesPaused;
        _suppressToggle = false;

        viewModel.PropertyChanged += (s, e) =>
        {
            if (e.PropertyName == nameof(AppViewModel.InAppMessagesPaused))
            {
                _suppressToggle = true;
                IamPausedSwitch.IsToggled = viewModel.InAppMessagesPaused;
                _suppressToggle = false;
            }
        };
    }

    private void OnIamPausedToggled(object? sender, ToggledEventArgs e)
    {
        if (_suppressToggle) return;
        _viewModel?.SetIamPaused(e.Value);
    }

    private void OnInfoTapped(object? sender, EventArgs e) => InfoTapped?.Invoke(this, e);
}
