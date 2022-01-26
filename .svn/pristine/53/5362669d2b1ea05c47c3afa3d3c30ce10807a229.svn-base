using LinphoneXamarin.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP;
using Windows.UI;
using Windows.UI.Text.Core;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(Entry), typeof(MyEntryRenderer))]

namespace UWP
{
    class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Transparent);
                Control.FontSize = Control.FontSize * 0.85;
                Control.BorderBrush.Opacity = 0;
                Control.ClearButtonVisible = true;
                
                Control.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center;
                Control.FlowDirection = CoreTextServicesManager.GetForCurrentView().InputLanguage.LayoutDirection.ToString().ToLower().IndexOf("rtl") > -1 ? Windows.UI.Xaml.FlowDirection.RightToLeft : Windows.UI.Xaml.FlowDirection.LeftToRight;
                CoreTextServicesManager.GetForCurrentView().InputLanguageChanged -= onInputLanguageChanged;
                CoreTextServicesManager.GetForCurrentView().InputLanguageChanged += onInputLanguageChanged;
            }
        }

        void onInputLanguageChanged(CoreTextServicesManager i, Object Object)
        {
            try
            {
                Control.FlowDirection = i.InputLanguage.LayoutDirection.ToString().ToLower().IndexOf("rtl") > -1 ? Windows.UI.Xaml.FlowDirection.RightToLeft : Windows.UI.Xaml.FlowDirection.LeftToRight;
            }
            catch (Exception e)
            {

            }

        }


        private void addLog(string message)
        {
            MyFileSystem.Instance.writeDebug(message, "MyEntryRenderer");
        }
    }
}
