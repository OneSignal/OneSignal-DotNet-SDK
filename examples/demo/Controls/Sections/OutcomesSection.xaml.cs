using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Extensions;
using OneSignalDemo.Controls;
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

        const string group = "outcome_type";
        var radioNormal = new RadioButton { Content = "Normal Outcome", GroupName = group, IsChecked = true };
        var radioUnique = new RadioButton { Content = "Unique Outcome", GroupName = group };
        var radioWithValue = new RadioButton { Content = "Outcome with Value", GroupName = group };

        var nameEntry = new Entry { Placeholder = "Outcome name", AutomationId = "outcome_name_input" };
        var valueEntry = new Entry { Placeholder = "Value (float)", Keyboard = Keyboard.Numeric, AutomationId = "outcome_value_input" };
        var valueContainer = new VerticalStackLayout { IsVisible = false, Children = { valueEntry } };

        radioWithValue.CheckedChanged += (s, e2) => valueContainer.IsVisible = e2.Value;
        radioNormal.CheckedChanged += (s, e2) => { if (e2.Value) valueContainer.IsVisible = false; };
        radioUnique.CheckedChanged += (s, e2) => { if (e2.Value) valueContainer.IsVisible = false; };

        var cancelButton = DialogInputHelper.ActionButton("Cancel");
        var sendButton = DialogInputHelper.ActionButton("Send");

        string? outcomeType = null;
        string? name = null;
        string? valueStr = null;

        cancelButton.Clicked += async (s, e2) => await _parentPage.ClosePopupAsync();
        sendButton.Clicked += async (s, e2) =>
        {
            outcomeType = radioWithValue.IsChecked ? "Outcome with Value"
                        : radioUnique.IsChecked ? "Unique Outcome"
                        : "Normal Outcome";
            name = nameEntry.Text?.Trim();
            valueStr = valueEntry.Text?.Trim();
            await _parentPage.ClosePopupAsync();
        };

        var content = new VerticalStackLayout
        {
            BackgroundColor = Colors.White,
            WidthRequest = DialogInputHelper.PopupContentWidth(_parentPage),
            Padding = new Thickness(24),
            Spacing = 12,
            Children =
            {
                new Label { Text = "Send Outcome", FontSize = 24 },
                new VerticalStackLayout
                {
                    Spacing = 4,
                    Children = { radioNormal, radioUnique, radioWithValue }
                },
                nameEntry,
                valueContainer,
                new HorizontalStackLayout
                {
                    HorizontalOptions = LayoutOptions.End,
                    Spacing = 8,
                    Padding = new Thickness(0, 8, 0, 0),
                    Children = { cancelButton, sendButton },
                },
            },
        };

        await _parentPage.ShowPopupAsync(content, DialogInputHelper.DialogOptions);

        if (string.IsNullOrEmpty(outcomeType) || string.IsNullOrEmpty(name))
            return;

        if (outcomeType == "Outcome with Value")
        {
            if (!float.TryParse(valueStr, out float val))
                return;
            _viewModel.SendOutcomeWithValue(name, val);
        }
        else if (outcomeType == "Unique Outcome")
        {
            _viewModel.SendUniqueOutcome(name);
        }
        else
        {
            _viewModel.SendOutcome(name);
        }

        await Toast.Make($"Outcome sent: {name}", ToastDuration.Short).Show();
    }

    private void OnInfoTapped(object? sender, EventArgs e) => InfoTapped?.Invoke(this, e);
}
