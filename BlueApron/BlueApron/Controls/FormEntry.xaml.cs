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
    public partial class FormEntry : ContentView
    {
        public FormEntry()
        {
            InitializeComponent();
        }

        //Bindable FormEntryPlaceholder
        public static readonly BindableProperty FormEntryPlaceholderProperty =
             BindableProperty.Create(nameof(FormEntryPlaceholder), typeof(string), typeof(string), default(string), BindingMode.TwoWay);

        //Bindable FormEntryTitle
        public static readonly BindableProperty FormEntryLabelProperty =
             BindableProperty.Create(nameof(FormEntryLabel), typeof(string), typeof(string), default(string), BindingMode.TwoWay);

        public static readonly BindableProperty IsPickerProperty =
            BindableProperty.Create(nameof(IsPicker), typeof(bool), typeof(bool), false, BindingMode.TwoWay);

        public string FormEntryPlaceholder {
            get => (string)GetValue(FormEntryPlaceholderProperty);
            set => SetValue(FormEntryPlaceholderProperty, value);
        }

        public string FormEntryLabel
        {
            get => (string)GetValue(FormEntryLabelProperty);
            set => SetValue(FormEntryLabelProperty, value);
        }

        public bool IsPicker {
            get => (bool)GetValue(IsPickerProperty);
            set => SetValue(IsPickerProperty, value);
        }


        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == FormEntryPlaceholderProperty.PropertyName)
                entryWhiteBox.Placeholder = FormEntryPlaceholder;

            if (propertyName == FormEntryLabelProperty.PropertyName)
                entryWhiteBoxLabel.Text = FormEntryLabel;

            if (propertyName == IsPickerProperty.PropertyName)
            {
                if (IsPicker)
                {
                    pickerBox.IsVisible = true;
                    entryWhiteBoxPicker.IsVisible = true;
                    entryWhiteBox.IsVisible = false;
                }
                else
                {
                    pickerBox.IsVisible = false;
                    entryWhiteBoxPicker.IsVisible = false;
                    entryWhiteBox.IsVisible = true;
                }
            }
        }
    }
}