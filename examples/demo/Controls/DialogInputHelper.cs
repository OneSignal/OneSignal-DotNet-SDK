using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Extensions;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Devices;

namespace OneSignalDemo.Controls;

public sealed class DialogInputField
{
    public required string Key { get; init; }
    public required string Placeholder { get; init; }
    public string? AutomationId { get; init; }
    public Keyboard Keyboard { get; init; } = Keyboard.Default;
}

public static class DialogInputHelper
{
    private static readonly PopupOptions DefaultOptions = new()
    {
        CanBeDismissedByTappingOutsideOfPopup = true,
        PageOverlayColor = Colors.Black.WithAlpha(0.4f),
        Shape = new RoundRectangle { CornerRadius = 12, StrokeThickness = 0, Stroke = new SolidColorBrush(Colors.Transparent) },
        Shadow = new Shadow
        {
            Brush = new SolidColorBrush(Colors.Black),
            Opacity = 0.12f,
            Radius = 10,
            Offset = new Microsoft.Maui.Graphics.Point(0, 2),
        },
    };

    public static async Task<string?> ShowSingleInput(
        Page parentPage,
        string title,
        string placeholder,
        string confirmText,
        string? entryAutomationId = null,
        string? confirmAutomationId = null,
        Keyboard? keyboard = null
    )
    {
        var result = await ShowForm(
            parentPage,
            title,
            new[]
            {
                new DialogInputField
                {
                    Key = "value",
                    Placeholder = placeholder,
                    AutomationId = entryAutomationId,
                    Keyboard = keyboard ?? Keyboard.Default,
                },
            },
            confirmText,
            confirmAutomationId
        );
        return result != null && result.TryGetValue("value", out var value) ? value : null;
    }

    public static async Task<Dictionary<string, string>?> ShowForm(
        Page parentPage,
        string title,
        IReadOnlyList<DialogInputField> fields,
        string confirmText,
        string? confirmAutomationId = null
    )
    {
        if (fields.Count == 0)
            return null;

        var entries = new Dictionary<string, Entry>(StringComparer.Ordinal);
        var contentStack = new VerticalStackLayout { Spacing = 12 };

        foreach (var field in fields)
        {
            var entry = new Entry
            {
                Placeholder = field.Placeholder,
                AutomationId = field.AutomationId ?? string.Empty,
                Keyboard = field.Keyboard,
            };
            entries[field.Key] = entry;
            contentStack.Children.Add(entry);
        }

        var cancelButton = SecondaryGhostButton("CANCEL");
        var confirmButton = PrimaryGhostButton(confirmText, confirmAutomationId);

        cancelButton.Clicked += async (s, e) => await parentPage.ClosePopupAsync();
        confirmButton.Clicked += async (s, e) =>
        {
            var values = entries.ToDictionary(
                kvp => kvp.Key,
                kvp => kvp.Value.Text?.Trim() ?? string.Empty,
                StringComparer.Ordinal
            );
            await parentPage.ClosePopupAsync(values);
        };

        Grid.SetColumn(confirmButton, 1);

        var card = new VerticalStackLayout
        {
            BackgroundColor = Colors.White,
            WidthRequest = PopupContentWidth(parentPage),
            Padding = new Thickness(16),
            Spacing = 12,
            Children =
            {
                new Label
                {
                    Text = title,
                    FontAttributes = FontAttributes.Bold,
                    FontSize = 16,
                },
                contentStack,
                new Grid
                {
                    ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star },
                    },
                    Children = { cancelButton, confirmButton },
                },
            },
        };

        var result = await parentPage.ShowPopupAsync<Dictionary<string, string>>(card, DefaultOptions);
        return result?.Result;
    }

    private static Button PrimaryGhostButton(string text, string? automationId = null) =>
        GhostButton(text, Color.FromArgb("#E54B4D"), automationId);

    private static Button SecondaryGhostButton(string text, string? automationId = null) =>
        GhostButton(text, Color.FromArgb("#6E6E73"), automationId);

    private static Button GhostButton(string text, Color textColor, string? automationId = null) =>
        new()
        {
            Text = text,
            Style = null,
            BackgroundColor = Colors.Transparent,
            TextColor = textColor,
            FontAttributes = FontAttributes.Bold,
            BorderWidth = 0,
            BorderColor = Colors.Transparent,
            Shadow = null,
            HorizontalOptions = LayoutOptions.Fill,
            AutomationId = automationId ?? string.Empty,
        };

    private static double PopupContentWidth(Page page)
    {
        var width = page.Width > 0 ? page.Width : DeviceDisplay.Current.MainDisplayInfo.Width / DeviceDisplay.Current.MainDisplayInfo.Density;
        return Math.Max(240, width - 32);
    }
}
