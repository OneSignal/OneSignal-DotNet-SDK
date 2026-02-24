using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Extensions;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Devices;

namespace OneSignalDemo.Controls;

public static class MultiPairDialogHelper
{
    public static async Task<Dictionary<string, string>?> Show(
        Page parentPage,
        string title,
        string keyPlaceholder,
        string valuePlaceholder
    )
    {
        var rows = new List<(Entry Key, Entry Value)>();
        var rowsContainer = new VerticalStackLayout { Spacing = 0 };

        void AddRow()
        {
            if (rowsContainer.Children.Count > 0)
                rowsContainer.Children.Add(
                    new BoxView
                    {
                        HeightRequest = 1,
                        Color = Color.FromArgb("#E8EAED"),
                        Margin = new Thickness(0, 4),
                    }
                );

            var keyEntry = new Entry
            {
                Placeholder = keyPlaceholder,
                AutomationId = $"multi_pair_key_{rows.Count}",
            };
            var valueEntry = new Entry
            {
                Placeholder = valuePlaceholder,
                AutomationId = $"multi_pair_value_{rows.Count}",
            };
            var capturedRow = (keyEntry, valueEntry);
            rows.Add(capturedRow);

            var deleteButton = new Button
            {
                Text = "✕",
                BackgroundColor = Colors.Transparent,
                TextColor = Color.FromArgb("#E54B4D"),
                WidthRequest = 36,
                HeightRequest = 36,
                Padding = 0,
            };

            var rowGrid = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Auto },
                },
                Padding = new Thickness(0, 4),
                ColumnSpacing = 8,
            };

            rowGrid.Children.Add(keyEntry);
            Grid.SetColumn(valueEntry, 1);
            rowGrid.Children.Add(valueEntry);
            Grid.SetColumn(deleteButton, 2);
            rowGrid.Children.Add(deleteButton);

            deleteButton.Clicked += (s, e) =>
            {
                if (rows.Count <= 1)
                    return;
                rows.Remove(capturedRow);
                var idx = rowsContainer.Children.IndexOf(rowGrid);
                if (idx > 0 && rowsContainer.Children[idx - 1] is BoxView divider)
                    rowsContainer.Children.Remove(divider);
                rowsContainer.Children.Remove(rowGrid);
            };

            rowsContainer.Children.Add(rowGrid);
        }

        AddRow();

        var addRowButton = new Button
        {
            Text = "+ Add Row",
            BackgroundColor = Colors.Transparent,
            TextColor = Color.FromArgb("#E54B4D"),
            HorizontalOptions = LayoutOptions.Center,
            Padding = new Thickness(0, 8),
        };

        var cancelButton = DialogInputHelper.ActionButton("CANCEL", "multi_pair_cancel_button");
        var addAllButton = DialogInputHelper.ActionButton("ADD ALL", "multi_pair_add_all_button");

        addRowButton.Clicked += (s, e) => AddRow();
        cancelButton.Clicked += async (s, e) => await parentPage.ClosePopupAsync();

        addAllButton.Clicked += async (s, e) =>
        {
            var result = new Dictionary<string, string>();
            foreach (var (key, value) in rows)
            {
                var k = key.Text?.Trim() ?? "";
                var v = value.Text?.Trim() ?? "";
                if (!string.IsNullOrEmpty(k))
                    result[k] = v;
            }
            await parentPage.ClosePopupAsync(result.Count > 0 ? result : null);
        };

        Grid.SetColumn(addAllButton, 1);

        var content = new VerticalStackLayout
        {
            BackgroundColor = Colors.White,
            Padding = new Thickness(24, 24),
            WidthRequest = DialogInputHelper.PopupContentWidth(parentPage),
            Spacing = 8,
            Children =
            {
                new Label
                {
                    Text = title,
                    FontSize = 24,
                    Margin = new Thickness(0, 0, 0, 4),
                },
                new ScrollView { MaximumHeightRequest = 300, Content = rowsContainer },
                addRowButton,
                new Grid
                {
                    ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star },
                    },
                    ColumnSpacing = 8,
                    Padding = new Thickness(0, 8, 0, 0),
                    Children = { cancelButton, addAllButton },
                },
            },
        };

        var result2 = await parentPage.ShowPopupAsync<Dictionary<string, string>?>(
            content,
            DialogInputHelper.DialogOptions
        );
        return result2?.Result;
    }

    public static async Task<List<string>?> ShowMultiSelect(
        Page parentPage,
        string title,
        IEnumerable<string> keys
    )
    {
        var checkboxes = new List<(CheckBox Box, string Key)>();
        var itemsLayout = new VerticalStackLayout { Spacing = 4 };

        foreach (var key in keys)
        {
            var cb = new CheckBox { Color = Color.FromArgb("#E54B4D") };
            checkboxes.Add((cb, key));
            var row = new HorizontalStackLayout { Spacing = 8 };
            row.Children.Add(cb);
            row.Children.Add(
                new Label { Text = key, VerticalOptions = LayoutOptions.Center, FontSize = 14 }
            );
            itemsLayout.Children.Add(row);
        }

        var cancelButton = DialogInputHelper.ActionButton("CANCEL", "multi_select_cancel_button");
        var removeButton = DialogInputHelper.ActionButtonDisabled("REMOVE (0)", "multi_select_remove_button");

        void UpdateButton()
        {
            var count = checkboxes.Count(c => c.Box.IsChecked);
            removeButton.Text = $"REMOVE ({count})";
            DialogInputHelper.SetActionButtonEnabled(removeButton, count > 0);
        }

        foreach (var (cb, _) in checkboxes)
            cb.CheckedChanged += (s, e) => UpdateButton();

        cancelButton.Clicked += async (s, e) => await parentPage.ClosePopupAsync();

        removeButton.Clicked += async (s, e) =>
        {
            var selected = checkboxes
                .Where(c => c.Box.IsChecked)
                .Select(c => c.Key)
                .ToList();
            await parentPage.ClosePopupAsync(selected);
        };

        Grid.SetColumn(removeButton, 1);

        var content = new VerticalStackLayout
        {
            BackgroundColor = Colors.White,
            Padding = new Thickness(24, 24),
            WidthRequest = DialogInputHelper.PopupContentWidth(parentPage),
            Spacing = 8,
            Children =
            {
                new Label
                {
                    Text = title,
                    FontSize = 24,
                    Margin = new Thickness(0, 0, 0, 4),
                },
                new ScrollView { MaximumHeightRequest = 300, Content = itemsLayout },
                new Grid
                {
                    ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star },
                    },
                    ColumnSpacing = 8,
                    Padding = new Thickness(0, 8, 0, 0),
                    Children = { cancelButton, removeButton },
                },
            },
        };

        var result = await parentPage.ShowPopupAsync<List<string>>(content, DialogInputHelper.DialogOptions);
        return result?.Result;
    }
}
