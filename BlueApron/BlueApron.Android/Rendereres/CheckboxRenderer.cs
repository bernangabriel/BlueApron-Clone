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
using BlueApron.Renderers;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.ExportRenderer(typeof(BlueApron.Renderers.Checkbox),
    typeof(BlueApron.Droid.Rendereres.CheckboxRenderer))]
namespace BlueApron.Droid.Rendereres
{
   public class CheckboxRenderer : ViewRenderer<BlueApron.Renderers.Checkbox, BlueApron.Droid.Rendereres.CheckboxRenderer>
    {
        Context _context;
        View _view;

        public void ShowView()
        {
            _view = ((Activity)_context).LayoutInflater.Inflate(Resource.Layout.CardView, null);
            AddView(_view);
        }

        public CheckboxRenderer(Context context)
            :base(context)
        {
            _context = context;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Checkbox> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {
                var chk = new CheckBox(_context);
            }
        }
    }
}