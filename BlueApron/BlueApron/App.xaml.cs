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
            var root = new Views.SamplePage();
            MainPage = new NavigationPage(root);
        }

        protected override void OnStart()
        {
            if (Properties.ContainsKey("sample"))
            {
                Properties["sample"] = "Hi there...";
            }
        }

        protected override void OnSleep()
        {
            Properties["sample"] = "Bernan G. Cordero";
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
