using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BlueApron.Renderers.EntryWhiteBox),
    typeof(BlueApron.Droid.Rendereres.EntryWhiteBox))]
namespace BlueApron.Droid.Rendereres
{
    public class EntryWhiteBox : EntryRenderer
    {
        public EntryWhiteBox(Context context)
            :base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.White);
                Control.SetPadding(20, 20, 20, 20);
                Control.SetHintTextColor(Android.Graphics.Color.LightGray);
            }
        }
    }
}