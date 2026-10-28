using Microsoft.Maui.Controls.Shapes;

namespace OneSignalDemo.Controls;

public sealed record DropdownOption(string Label, string Value);

internal sealed record DropdownItem(
    string Label,
    string Value,
    string AutomationId,
    bool IsSelected
)
{
    public Color TextColor => IsSelected ? Color.FromArgb("#E54B4D") : Color.FromArgb("#212121");
    public FontAttributes FontAttributes => IsSelected ? FontAttributes.Bold : FontAttributes.None;
}

// Page-level overlay so the menu can draw over every section and be dismissed
// by tapping anywhere outside it.
public sealed class DropdownMenu : Grid
{
    private const double MenuWidth = 240;
    private const double MenuMaxHeight = 320;
    private const double ScreenMargin = 16;
    private const double ItemHeight = 48;
    private const double ListPadding = 8;

    private readonly Border _menu;
    private readonly CollectionView _list;
    private TaskCompletionSource<string?>? _result;

    public DropdownMenu()
    {
        IsVisible = false;

        var backdrop = new BoxView { Color = Colors.Transparent };
        var backdropTap = new TapGestureRecognizer();
        backdropTap.Tapped += (s, e) => Close(null);
        backdrop.GestureRecognizers.Add(backdropTap);

        // CollectionView selection, unlike a tap gesture, is not triggered by a
        // drag that ends on an item once the list can't scroll any further.
        _list = new CollectionView
        {
            SelectionMode = SelectionMode.Single,
            Margin = new Thickness(0, ListPadding),
            ItemTemplate = new DataTemplate(BuildItem),
        };
        _list.SelectionChanged += (s, e) =>
        {
            if (e.CurrentSelection.FirstOrDefault() is DropdownItem item)
                Close(item.Value);
        };

        _menu = new Border
        {
            WidthRequest = MenuWidth,
            BackgroundColor = Colors.White,
            StrokeThickness = 0,
            StrokeShape = new RoundRectangle { CornerRadius = 8 },
            Shadow = new Shadow
            {
                Brush = new SolidColorBrush(Colors.Black),
                Opacity = 0.2f,
                Radius = 8,
                Offset = new Point(0, 4),
            },
            HorizontalOptions = LayoutOptions.End,
            Content = _list,
        };

        Children.Add(backdrop);
        Children.Add(_menu);
    }

    public bool IsOpen => IsVisible;

    public Task<string?> ShowAsync(
        VisualElement anchor,
        IReadOnlyList<DropdownOption> options,
        string selectedValue,
        string automationIdPrefix
    )
    {
        Close(null);
        _result = new TaskCompletionSource<string?>();

        _list.ItemsSource = options
            .Select(o => new DropdownItem(
                o.Label,
                o.Value,
                $"{automationIdPrefix}_{(o.Value.Length == 0 ? "default" : o.Value)}",
                o.Value == selectedValue
            ))
            .ToList();
        _list.HeightRequest =
            Math.Min(MenuMaxHeight, options.Count * ItemHeight + ListPadding * 2) - ListPadding * 2;

        // A hidden overlay is never laid out, so measure against the parent it fills.
        var container = (VisualElement)Parent;
        var anchorOrigin = OriginInPage(anchor);
        var origin = OriginInPage(container);
        var anchorTop = anchorOrigin.Y - origin.Y;
        var anchorBottom = anchorTop + anchor.Height;
        var anchorRight = anchorOrigin.X - origin.X + anchor.Width;
        var right = Math.Max(ScreenMargin, container.Width - anchorRight);

        if (anchorBottom + MenuMaxHeight > container.Height - ScreenMargin)
        {
            _menu.VerticalOptions = LayoutOptions.End;
            _menu.Margin = new Thickness(0, 0, right, container.Height - anchorTop);
        }
        else
        {
            _menu.VerticalOptions = LayoutOptions.Start;
            _menu.Margin = new Thickness(0, anchorBottom, right, 0);
        }

        IsVisible = true;
        // Bring the current choice into view; iOS would otherwise keep the
        // previous scroll offset across ItemsSource changes.
        var selectedIndex = Math.Max(0, options.ToList().FindIndex(o => o.Value == selectedValue));
        Dispatcher.Dispatch(() =>
            _list.ScrollTo(selectedIndex, position: ScrollToPosition.Center, animate: false)
        );
        return _result.Task;
    }

    public void Close(string? value)
    {
        IsVisible = false;
        _result?.TrySetResult(value);
        _result = null;
    }

    private static View BuildItem()
    {
        var label = new Label
        {
            FontSize = 16,
            HeightRequest = ItemHeight,
            VerticalTextAlignment = TextAlignment.Center,
            Padding = new Thickness(16, 0),
        };
        label.SetBinding(Label.TextProperty, nameof(DropdownItem.Label));
        label.SetBinding(Label.TextColorProperty, nameof(DropdownItem.TextColor));
        label.SetBinding(Label.FontAttributesProperty, nameof(DropdownItem.FontAttributes));
        label.SetBinding(AutomationIdProperty, nameof(DropdownItem.AutomationId));

        // Suppress the platform selection highlight; the menu closes on select.
        var container = new Grid { Children = { label } };
        VisualStateManager.SetVisualStateGroups(
            container,
            new VisualStateGroupList
            {
                new VisualStateGroup
                {
                    Name = "CommonStates",
                    States =
                    {
                        new VisualState { Name = "Normal" },
                        new VisualState
                        {
                            Name = "Selected",
                            Setters =
                            {
                                new Setter
                                {
                                    Property = BackgroundColorProperty,
                                    Value = Colors.White,
                                },
                            },
                        },
                    },
                },
            }
        );
        return container;
    }

    private static Point OriginInPage(VisualElement element)
    {
        double x = 0,
            y = 0;
        for (
            Element? current = element;
            current is VisualElement visual and not Page;
            current = current.Parent
        )
        {
            x += visual.X + visual.TranslationX;
            y += visual.Y + visual.TranslationY;
            if (visual.Parent is ScrollView scroll)
            {
                x -= scroll.ScrollX;
                y -= scroll.ScrollY;
            }
        }
        return new Point(x, y);
    }
}
