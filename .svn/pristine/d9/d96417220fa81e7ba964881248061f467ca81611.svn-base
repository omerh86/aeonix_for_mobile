using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(BoxView), typeof(MyRoundedBoxViewRenderer))]

namespace UWP
{
    class MyRoundedBoxViewRenderer : BoxViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
        {
            base.OnElementChanged(e);


            if (Control != null)
            {
                Control.RadiusX = 50;
                Control.RadiusY = 50;
              
            }
        }


    }
}
