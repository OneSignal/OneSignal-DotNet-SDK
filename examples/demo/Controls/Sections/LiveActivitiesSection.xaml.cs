using OneSignalDemo.ViewModels;

namespace OneSignalDemo.Controls.Sections;

public partial class LiveActivitiesSection : ContentView
{
    private AppViewModel? _viewModel;

    public event EventHandler? InfoTapped;

    public LiveActivitiesSection()
    {
        InitializeComponent();
    }

    public void Initialize(AppViewModel viewModel)
    {
        _viewModel = viewModel;

        var hasApiKey = viewModel.HasApiKey();
        UpdateButton.IsEnabled = hasApiKey;
        EndButton.IsEnabled = hasApiKey;

        viewModel.PropertyChanged += (s, e) =>
        {
            if (e.PropertyName == nameof(AppViewModel.LiveActivityUpdateButtonText))
                UpdateButton.Text = viewModel.LiveActivityUpdateButtonText;

            if (e.PropertyName == nameof(AppViewModel.IsLiveActivityUpdating))
            {
                UpdateButton.IsEnabled = !viewModel.IsLiveActivityUpdating && viewModel.HasApiKey()
                    && !string.IsNullOrWhiteSpace(ActivityIdEntry.Text);
                EndButton.IsEnabled = !viewModel.IsLiveActivityUpdating && viewModel.HasApiKey()
                    && !string.IsNullOrWhiteSpace(ActivityIdEntry.Text);
            }
        };
    }

    private void OnActivityIdChanged(object? sender, TextChangedEventArgs e)
    {
        if (_viewModel != null)
            _viewModel.LiveActivityId = e.NewTextValue;

        var hasText = !string.IsNullOrWhiteSpace(e.NewTextValue);
        StartButton.IsEnabled = hasText;
        UpdateButton.IsEnabled = hasText && _viewModel?.HasApiKey() == true
            && _viewModel?.IsLiveActivityUpdating != true;
        EndButton.IsEnabled = hasText && _viewModel?.HasApiKey() == true
            && _viewModel?.IsLiveActivityUpdating != true;
    }

    private void OnOrderNumberChanged(object? sender, TextChangedEventArgs e)
    {
        if (_viewModel != null)
            _viewModel.LiveActivityOrderNumber = e.NewTextValue;
    }

    private void OnStartClicked(object? sender, EventArgs e)
    {
        _viewModel?.StartLiveActivity();
    }

    private async void OnUpdateClicked(object? sender, EventArgs e)
    {
        if (_viewModel != null)
            await _viewModel.UpdateLiveActivityAsync();
    }

    private async void OnEndClicked(object? sender, EventArgs e)
    {
        if (_viewModel != null)
            await _viewModel.EndLiveActivityAsync();
    }

    private void OnInfoTapped(object? sender, EventArgs e) => InfoTapped?.Invoke(this, e);
}
