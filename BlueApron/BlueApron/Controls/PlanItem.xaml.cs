using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlueApron.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlanItem : ContentView
    {
        public PlanItem()
        {
            InitializeComponent();
        }

        //Plan Title
        public static readonly BindableProperty PlanTitleProperty =
            BindableProperty.Create(nameof(PlanTitle), typeof(string), typeof(string), default(string), BindingMode.TwoWay);

        //Plan Image
        public static readonly BindableProperty PlanImageProperty =
            BindableProperty.Create(nameof(PlanImage), typeof(string), typeof(string), default(string), BindingMode.TwoWay);

        //Plan Description
        public static readonly BindableProperty PlanDescriptionProperty =
            BindableProperty.Create(nameof(PlanDescription), typeof(string), typeof(string), default(string), BindingMode.TwoWay);

        //Plan Price
        public static readonly BindableProperty PlanPriceProperty =
          BindableProperty.Create(nameof(PlanPrice), typeof(string), typeof(string), default(string), BindingMode.TwoWay);


        public string PlanImage {
            get => (string)GetValue(PlanImageProperty);
            set => SetValue(PlanImageProperty, value);
        }

        public string PlanTitle
        {
            get => (string)GetValue(PlanTitleProperty);
            set => SetValue(PlanTitleProperty, value);
        }

        public string PlanDescription {
            get => (string)GetValue(PlanDescriptionProperty);
            set => SetValue(PlanImageProperty, value);
        }

        public string PlanPrice
        {
            get => (string)GetValue(PlanPriceProperty);
            set => SetValue(PlanPriceProperty, value);
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            //Plan title
            if (propertyName == PlanTitleProperty.PropertyName)
                planTitle.Text = PlanTitle;


            //Plan image
            if (propertyName == PlanImageProperty.PropertyName)
                planImage.Source = ImageSource.FromFile(PlanImage);

            //Plan Description
            if (propertyName == PlanDescriptionProperty.PropertyName)
                planDescription.Text = PlanDescription;

            //Plan Price
            if (propertyName == PlanPriceProperty.PropertyName)
                planPrice.Text = PlanPrice;
        }
     

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Application.Current.MainPage.DisplayAlert("Titulo", "Hola", "OK");
        }
    }
}