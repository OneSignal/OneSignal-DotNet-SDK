using Microsoft.Maui.Layouts;

namespace OneSignalDemo.Controls;

/// <summary>
/// Lays out visible children two per row in equal columns. An odd last child
/// spans both columns, and hidden children drop out so the rest reflow.
/// </summary>
public class ButtonGrid : Layout
{
    public static readonly BindableProperty SpacingProperty = BindableProperty.Create(
        nameof(Spacing),
        typeof(double),
        typeof(ButtonGrid),
        8.0,
        propertyChanged: (bindable, _, _) => ((ButtonGrid)bindable).InvalidateMeasure()
    );

    public double Spacing
    {
        get => (double)GetValue(SpacingProperty);
        set => SetValue(SpacingProperty, value);
    }

    protected override ILayoutManager CreateLayoutManager() => new ButtonGridLayoutManager(this);

    private sealed class ButtonGridLayoutManager(ButtonGrid grid) : LayoutManager(grid)
    {
        public override Size Measure(double widthConstraint, double heightConstraint)
        {
            var children = VisibleChildren();
            var cellWidth = CellWidth(widthConstraint);
            double height = 0;

            for (var i = 0; i < children.Count; i += 2)
            {
                var spans = i == children.Count - 1;
                var rowHeight = children[i]
                    .Measure(spans ? widthConstraint : cellWidth, double.PositiveInfinity)
                    .Height;
                if (!spans)
                {
                    rowHeight = Math.Max(
                        rowHeight,
                        children[i + 1].Measure(cellWidth, double.PositiveInfinity).Height
                    );
                }
                height += rowHeight + (i > 0 ? grid.Spacing : 0);
            }

            return new Size(widthConstraint, height);
        }

        public override Size ArrangeChildren(Rect bounds)
        {
            var children = VisibleChildren();
            var cellWidth = CellWidth(bounds.Width);
            var y = bounds.Top;

            for (var i = 0; i < children.Count; i += 2)
            {
                if (i == children.Count - 1)
                {
                    var height = children[i].DesiredSize.Height;
                    children[i].Arrange(new Rect(bounds.Left, y, bounds.Width, height));
                    y += height + grid.Spacing;
                    continue;
                }

                var rowHeight = Math.Max(
                    children[i].DesiredSize.Height,
                    children[i + 1].DesiredSize.Height
                );
                children[i].Arrange(new Rect(bounds.Left, y, cellWidth, rowHeight));
                children[i + 1]
                    .Arrange(
                        new Rect(bounds.Left + cellWidth + grid.Spacing, y, cellWidth, rowHeight)
                    );
                y += rowHeight + grid.Spacing;
            }

            return bounds.Size;
        }

        private double CellWidth(double width) => Math.Max(0, (width - grid.Spacing) / 2);

        private List<IView> VisibleChildren() =>
            grid.Where(child => child.Visibility != Visibility.Collapsed).ToList();
    }
}
