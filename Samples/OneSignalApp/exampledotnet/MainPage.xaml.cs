using System.Globalization;

namespace exampledotnet;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        BindingContext = new Models.MainPageModel(this);
    }
}


