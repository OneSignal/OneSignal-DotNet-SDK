﻿using System.Globalization;

namespace OneSignalApp;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        BindingContext = new Models.MainPageModel(this);
    }
}


