using OneSignalDemo.ViewModels;

namespace OneSignalDemo.Controls.Sections;

public partial class LocationSection : ContentView
{
    private AppViewModel? _viewModel;
    private bool _suppressToggle;

    public event EventHandler? InfoTapped;

    public LocationSection()
    {
        InitializeComponent();
    }

    public void Initialize(AppViewModel viewModel)
    {
        _viewModel = viewModel;
        _suppressToggle = true;
        LocationSharedSwitch.IsToggled = viewModel.LocationShared;
        _suppressToggle = false;

        viewModel.PropertyChanged += (s, e) =>
        {
            if (e.PropertyName == nameof(AppViewModel.LocationShared))
            {
                _suppressToggle = true;
                LocationSharedSwitch.IsToggled = viewModel.LocationShared;
                _suppressToggle = false;
            }
        };
    }

    private void OnLocationSharedToggled(object? sender, ToggledEventArgs e)
    {
        if (_suppressToggle) return;
        _viewModel?.SetLocationSharedValue(e.Value);
    }

    private void OnPromptLocationClicked(object? sender, EventArgs e)
    {
        _viewModel?.PromptLocation();
    }

    private void OnInfoTapped(object? sender, EventArgs e) => InfoTapped?.Invoke(this, e);
}
