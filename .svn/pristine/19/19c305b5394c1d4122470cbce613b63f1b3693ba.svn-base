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

[assembly: ExportRenderer(typeof(Editor), typeof(MyEditorRenderer))]

namespace UWP
{
    class MyEditorRenderer : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.FlowDirection = CoreTextServicesManager.GetForCurrentView().InputLanguage.LayoutDirection.ToString().ToLower().IndexOf("rtl") > -1 ? Windows.UI.Xaml.FlowDirection.RightToLeft : Windows.UI.Xaml.FlowDirection.LeftToRight;
                CoreTextServicesManager.GetForCurrentView().InputLanguageChanged -= onInputLanguageChanged;
                CoreTextServicesManager.GetForCurrentView().InputLanguageChanged += onInputLanguageChanged;
            }
        }

        void onInputLanguageChanged(CoreTextServicesManager i, Object Object)
        {
            try
            {
                addLog("onInputLanguageChanged");
                Control.FlowDirection = i.InputLanguage.LayoutDirection.ToString().ToLower().IndexOf("rtl") > -1 ? Windows.UI.Xaml.FlowDirection.RightToLeft : Windows.UI.Xaml.FlowDirection.LeftToRight;
            }
            catch (Exception e)
            {

            }

        }
        private void addLog(string message)
        {
            MyFileSystem.Instance.writeDebug(message, "MyEditorRenderer");
        }


    }
}
