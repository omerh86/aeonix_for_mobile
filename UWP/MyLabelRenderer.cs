using LinphoneXamarin.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP;
using Windows.UI;
using Windows.UI.Text;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Label), typeof(MyLabelRenderer))]

namespace UWP
{
    class MyLabelRenderer : LabelRenderer
    {
        Brush black;
        Brush normal;
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Label> e)
        {
            base.OnElementChanged(e);
            black = new SolidColorBrush(new Windows.UI.Color() { R = 0, B = 0, G = 0 });
            normal = new SolidColorBrush(new Windows.UI.Color() { R = 114, B = 142, G = 192 });

            if (Control != null)
            {
                try
                {
                    Control.FontSize = Control.FontSize * 0.65;
                    if (e.NewElement.ClassId != null && e.NewElement.ClassId.Length > 0)
                    {
                        Control.PointerEntered -= onPointerEntered;
                        Control.PointerExited -= onPointerExited;
                        Control.PointerEntered += onPointerEntered;
                        Control.PointerExited += onPointerExited;
                        ToolTip toolTip = new ToolTip();
                        toolTip.Content = e.NewElement.ClassId;
                        ToolTipService.SetToolTip(this, toolTip);
                    }
                }
                catch (Exception err)
                {

                }
            }

        }

        private void onPointerEntered(object sender, PointerRoutedEventArgs e)
        {
            try
            {
                if (Control != null)
                    Control.FontWeight = FontWeights.Bold;
            }
            catch (Exception err)
            {

            }

        }

        private void onPointerExited(object sender, PointerRoutedEventArgs e)
        {
            try
            {
                if (Control != null)
                    Control.FontWeight = FontWeights.Normal;
            }
            catch (Exception err)
            {

            }
        }

    }
}
