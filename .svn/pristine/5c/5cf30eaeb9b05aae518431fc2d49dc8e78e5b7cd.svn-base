using LinphoneXamarin.components;
using Plugin.Badge.UWP;
using System.Globalization;
using UWP;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(Tabs), typeof(TabbedPageCustom))]

namespace UWP
{
    class TabbedPageCustom : BadgedTabbedPageRenderer
    {
       
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                string hexColor;
                byte a, r, g, b;
                hexColor = "#EEEEEEEE";
                a = byte.Parse(hexColor.Substring(1, 2), NumberStyles.HexNumber);
                r = byte.Parse(hexColor.Substring(3, 2), NumberStyles.HexNumber);
                g = byte.Parse(hexColor.Substring(5, 2), NumberStyles.HexNumber);
                b = byte.Parse(hexColor.Substring(7, 2), NumberStyles.HexNumber);
                Control.ToolbarBackground = new SolidColorBrush(Color.FromArgb(a, r, g, b));
               
            }

        }

    }
}
