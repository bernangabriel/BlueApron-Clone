using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlueApron.MarkupExtensions
{
    public class LoadImage : IMarkupExtension
    {
        public string Source { get; set; }


        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Xamarin.Forms.ImageSource.FromResource($"BlueApron.Images.{Source}");
        }
    }
}
