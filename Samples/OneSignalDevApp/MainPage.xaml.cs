﻿namespace OneSignalDevApp;

public partial class MainPage : ContentPage
{
	int count = 0;

    public MainPage()
    {
        InitializeComponent();
        BindingContext = new Models.MainPageModel(this);
    }
}

