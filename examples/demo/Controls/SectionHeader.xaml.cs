namespace OneSignalDemo.Controls;

public partial class SectionHeader : ContentView
{
    public static readonly BindableProperty TitleProperty = BindableProperty.Create(
        nameof(Title),
        typeof(string),
        typeof(SectionHeader),
        default(string)
    );

    public static readonly BindableProperty SectionKeyProperty = BindableProperty.Create(
        nameof(SectionKey),
        typeof(string),
        typeof(SectionHeader),
        default(string),
        propertyChanged: OnSectionKeyChanged
    );

    public event EventHandler? InfoTapped;

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public string SectionKey
    {
        get => (string)GetValue(SectionKeyProperty);
        set => SetValue(SectionKeyProperty, value);
    }

    public SectionHeader()
    {
        InitializeComponent();
    }

    private static void OnSectionKeyChanged(
        BindableObject bindable,
        object oldValue,
        object newValue
    )
    {
        if (bindable is SectionHeader sh && newValue is string key && !string.IsNullOrEmpty(key))
        {
            sh.InfoButton.AutomationId = $"{key}_info_icon";
        }
    }

    private void OnInfoTappedInternal(object? sender, EventArgs e) => InfoTapped?.Invoke(this, e);
}
