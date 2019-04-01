using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlueApron
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var root = new Views.MainPage();
            MainPage = new NavigationPage(root);
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
           
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
