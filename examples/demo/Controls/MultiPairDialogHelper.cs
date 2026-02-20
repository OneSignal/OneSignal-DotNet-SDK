namespace OneSignalDemo.Controls;

public static class MultiPairDialogHelper
{
    public static async Task<Dictionary<string, string>?> Show(Page parentPage, string title, string keyPlaceholder, string valuePlaceholder)
    {
        var tcs = new TaskCompletionSource<Dictionary<string, string>?>();

        var rows = new List<(Entry Key, Entry Value)>();
        var rowsContainer = new VerticalStackLayout { Spacing = 0 };

        void AddRow()
        {
            if (rowsContainer.Children.Count > 0)
                rowsContainer.Children.Add(new BoxView { HeightRequest = 1, Color = Color.FromArgb("#E8EAED"), Margin = new Thickness(0, 4) });

            var keyEntry = new Entry { Placeholder = keyPlaceholder, AutomationId = $"multi_pair_key_{rows.Count}" };
            var valueEntry = new Entry { Placeholder = valuePlaceholder, AutomationId = $"multi_pair_value_{rows.Count}" };
            rows.Add((keyEntry, valueEntry));

            var deleteButton = new Button
            {
                Text = "✕",
                BackgroundColor = Colors.Transparent,
                TextColor = Color.FromArgb("#E54B4D"),
                WidthRequest = 40,
                HeightRequest = 40,
                Padding = 0
            };

            var rowIndex = rows.Count - 1;
            var capturedRow = (keyEntry, valueEntry);

            var rowGrid = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Auto }
                },
                Padding = new Thickness(0, 4),
                ColumnSpacing = 8
            };

            rowGrid.Children.Add(keyEntry);
            Grid.SetColumn(valueEntry, 1);
            rowGrid.Children.Add(valueEntry);
            Grid.SetColumn(deleteButton, 2);
            rowGrid.Children.Add(deleteButton);

            deleteButton.Clicked += (s, e) =>
            {
                if (rows.Count <= 1) return;
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
            HorizontalOptions = LayoutOptions.Start,
            Padding = new Thickness(0, 8)
        };

        var addAllButton = new Button
        {
            Text = "ADD ALL",
            Style = Application.Current?.Resources["PrimaryButtonStyle"] as Style,
            AutomationId = "multi_pair_add_all_button"
        };

        addRowButton.Clicked += (s, e) => AddRow();

        addAllButton.Clicked += (s, e) =>
        {
            var result = new Dictionary<string, string>();
            foreach (var (key, value) in rows)
            {
                var k = key.Text?.Trim() ?? "";
                var v = value.Text?.Trim() ?? "";
                if (!string.IsNullOrEmpty(k))
                    result[k] = v;
            }
            tcs.TrySetResult(result.Count > 0 ? result : null);
        };

        var page = new ContentPage
        {
            Title = title,
            Content = new ScrollView
            {
                Content = new VerticalStackLayout
                {
                    Padding = new Thickness(16),
                    Spacing = 8,
                    Children = { rowsContainer, addRowButton, addAllButton }
                }
            }
        };

        page.Disappearing += (s, e) => tcs.TrySetResult(null);
        await parentPage.Navigation.PushModalAsync(page);
        var result2 = await tcs.Task;
        if (parentPage.Navigation.ModalStack.Contains(page))
            await parentPage.Navigation.PopModalAsync();
        return result2;
    }

    public static async Task<List<string>?> ShowMultiSelect(Page parentPage, string title, IEnumerable<string> keys)
    {
        var tcs = new TaskCompletionSource<List<string>?>();
        var checkboxes = new List<(CheckBox Box, string Key)>();

        var layout = new VerticalStackLayout { Spacing = 4, Padding = new Thickness(16) };

        foreach (var key in keys)
        {
            var cb = new CheckBox { Color = Color.FromArgb("#E54B4D") };
            checkboxes.Add((cb, key));

            var row = new HorizontalStackLayout { Spacing = 8 };
            row.Children.Add(cb);
            row.Children.Add(new Label { Text = key, VerticalOptions = LayoutOptions.Center, FontSize = 14 });
            layout.Children.Add(row);
        }

        var removeButton = new Button
        {
            Text = "REMOVE (0)",
            Style = Application.Current?.Resources["PrimaryButtonStyle"] as Style,
            AutomationId = "multi_select_remove_button"
        };

        void UpdateButton()
        {
            var count = checkboxes.Count(c => c.Box.IsChecked);
            removeButton.Text = $"REMOVE ({count})";
            removeButton.IsEnabled = count > 0;
        }

        foreach (var (cb, _) in checkboxes)
            cb.CheckedChanged += (s, e) => UpdateButton();

        UpdateButton();

        removeButton.Clicked += (s, e) =>
        {
            var selected = checkboxes.Where(c => c.Box.IsChecked).Select(c => c.Key).ToList();
            tcs.TrySetResult(selected);
        };

        layout.Children.Add(removeButton);

        var page = new ContentPage
        {
            Title = title,
            Content = new ScrollView { Content = layout }
        };

        page.Disappearing += (s, e) => tcs.TrySetResult(null);
        await parentPage.Navigation.PushModalAsync(page);
        var result = await tcs.Task;
        if (parentPage.Navigation.ModalStack.Contains(page))
            await parentPage.Navigation.PopModalAsync();
        return result;
    }
}
