namespace OneSignalDemo.Controls;

public partial class LoadingState : ContentView
{
    public LoadingState()
    {
        InitializeComponent();
    }

    public LoadingState(string automationId)
        : this()
    {
        AutomationId = automationId;
    }
}
