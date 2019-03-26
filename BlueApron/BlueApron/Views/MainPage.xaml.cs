﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlueApron.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        MainPage vm = null;
        public MainPage()
        {
            InitializeComponent();
            BindingContext = vm = new MainPage();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}