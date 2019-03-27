using BlueApron.ViewModels;
using System;
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
        MainPageViewModel vm = null;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = vm = new MainPageViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}