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
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(BlueApron.Renderers.NavigationPageCustom),
    typeof(BlueApron.Droid.Rendereres.NavigationPageCustom))]
namespace BlueApron.Droid.Rendereres
{
    public class NavigationPageCustom : NavigationPageRenderer
    {
        private Android.Support.V7.Widget.Toolbar _toolbar;

        public NavigationPageCustom(Context context)
            :base(context)
        {

        }

        public override void OnViewAdded(Android.Views.View child)
        {
            base.OnViewAdded(child);
            if(child.GetType() == typeof(Android.Support.V7.Widget.Toolbar))
            {
                _toolbar = (Android.Support.V7.Widget.Toolbar)child;
                _toolbar.SetBackgroundColor(global::Android.Graphics.Color.White);
            }
        }
    }
}