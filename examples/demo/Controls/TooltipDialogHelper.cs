using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Extensions;
using OneSignalDemo.Services;

namespace OneSignalDemo.Controls;

public static class TooltipDialogHelper
{
    public static async Task Show(Page parentPage, TooltipData tooltip)
    {
        var okButton = DialogInputHelper.ActionButton("OK");
        okButton.Clicked += async (s, e) => await parentPage.ClosePopupAsync();

        var contentStack = new VerticalStackLayout { Spacing = 8 };
        contentStack.Children.Add(
            new Label
            {
                Text = tooltip.Description,
                FontSize = 14,
                TextColor = Color.FromArgb("#5F6368"),
            }
        );

        if (tooltip.Options is { Count: > 0 })
        {
            foreach (var option in tooltip.Options)
            {
                contentStack.Children.Add(
                    new Label
                    {
                        Text = option.Name,
                        FontSize = 14,
                        FontAttributes = FontAttributes.Bold,
                    }
                );
                contentStack.Children.Add(
                    new Label
                    {
                        Text = option.Description,
                        FontSize = 13,
                        TextColor = Color.FromArgb("#5F6368"),
                        Margin = new Thickness(0, 0, 0, 4),
                    }
                );
            }
        }

        var card = new VerticalStackLayout
        {
            BackgroundColor = Colors.White,
            WidthRequest = DialogInputHelper.PopupContentWidth(parentPage),
            Padding = new Thickness(24, 24),
            Spacing = 12,
            Children =
            {
                new Label { Text = tooltip.Title, FontSize = 24 },
                new ScrollView { MaximumHeightRequest = 400, Content = contentStack },
                new HorizontalStackLayout
                {
                    HorizontalOptions = LayoutOptions.End,
                    Spacing = 8,
                    Padding = new Thickness(0, 8, 0, 0),
                    Children = { okButton },
                },
            },
        };

        await parentPage.ShowPopupAsync(card, DialogInputHelper.DialogOptions);
    }
}
