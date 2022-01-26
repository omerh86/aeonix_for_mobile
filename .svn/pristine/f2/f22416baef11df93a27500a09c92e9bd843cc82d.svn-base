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

[assembly: ExportRenderer(typeof(Xamarin.Forms.Button), typeof(MyButtonRenderer))]

namespace UWP
{
    class MyButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                try
                {
                    Control.FontSize = Control.FontSize * 0.65;

                    if (e.NewElement.ClassId!=null&& e.NewElement.ClassId.Length > 0)
                    {
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


    }
}
