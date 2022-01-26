using LinphoneXamarin.components.userControllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(SelectableLabel), typeof(MySelectableLabelRenderer))]

namespace UWP
{
    class MySelectableLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                try
                {
                    Control.FontSize = Control.FontSize * 0.65;
                    Control.IsTextSelectionEnabled = true;
                }
                catch (Exception err)
                {

                }
            }

        }


    }
}
