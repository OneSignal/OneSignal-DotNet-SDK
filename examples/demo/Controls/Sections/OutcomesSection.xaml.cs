using OneSignalDemo.ViewModels;

namespace OneSignalDemo.Controls.Sections;

public partial class OutcomesSection : ContentView
{
    private AppViewModel? _viewModel;
    private Page? _parentPage;

    public event EventHandler? InfoTapped;

    public OutcomesSection()
    {
        InitializeComponent();
    }

    public void Initialize(AppViewModel viewModel, Page parentPage)
    {
        _viewModel = viewModel;
        _parentPage = parentPage;
    }

    private async void OnSendOutcomeClicked(object? sender, EventArgs e)
    {
        if (_parentPage == null || _viewModel == null) return;

        // Radio buttons for outcome type
        var normalRadio = new RadioButton { Content = "Normal Outcome", IsChecked = true, AutomationId = "outcome_radio_normal" };
        var uniqueRadio = new RadioButton { Content = "Unique Outcome", AutomationId = "outcome_radio_unique" };
        var valueRadio = new RadioButton { Content = "Outcome with Value", AutomationId = "outcome_radio_value" };

        var nameEntry = new Entry { Placeholder = "Outcome name", AutomationId = "outcome_name_input" };
        var valueEntry = new Entry { Placeholder = "Value (float)", Keyboard = Keyboard.Numeric, AutomationId = "outcome_value_input" };
        var valueEntryContainer = new VerticalStackLayout { Children = { valueEntry }, IsVisible = false };

        valueRadio.CheckedChanged += (s, ev) => valueEntryContainer.IsVisible = ev.Value;

        var tcs = new TaskCompletionSource<bool>();
        var confirmBtn = new Button
        {
            Text = "SEND",
            Style = Application.Current?.Resources["PrimaryButtonStyle"] as Style,
            Command = new Command(() => tcs.TrySetResult(true))
        };

        var page = new ContentPage
        {
            Title = "Send Outcome",
            Content = new VerticalStackLayout
            {
                Padding = new Thickness(16),
                Spacing = 12,
                Children = { normalRadio, uniqueRadio, valueRadio, nameEntry, valueEntryContainer, confirmBtn }
            }
        };

        page.Disappearing += (s2, e2) => tcs.TrySetResult(false);
        await _parentPage.Navigation.PushModalAsync(page);
        var result = await tcs.Task;
        if (_parentPage.Navigation.ModalStack.Contains(page))
            await _parentPage.Navigation.PopModalAsync();

        if (!result) return;

        var name = nameEntry.Text?.Trim() ?? "";
        if (string.IsNullOrEmpty(name)) return;

        if (valueRadio.IsChecked)
        {
            if (float.TryParse(valueEntry.Text?.Trim(), out float val))
                _viewModel.SendOutcomeWithValue(name, val);
        }
        else if (uniqueRadio.IsChecked)
        {
            _viewModel.SendUniqueOutcome(name);
        }
        else
        {
            _viewModel.SendOutcome(name);
        }

        await _parentPage.DisplayAlert("Success", $"Outcome sent: {name}", "OK");
    }

    private void OnInfoTapped(object? sender, EventArgs e) => InfoTapped?.Invoke(this, e);
}
