using System;

using Foundation;
using LinphoneXamarin.iOS;
using LinphoneXamarin.components;
using LinphoneXamarin.styles;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using LinphoneXamarin.Util;

using Xamarin.Forms.Internals;
using static Xamarin.Forms.PlatformConfiguration.iOSSpecific.Page;
using PageUIStatusBarAnimation = Xamarin.Forms.PlatformConfiguration.iOSSpecific.UIStatusBarAnimation;
using static LinphoneXamarin.components.Tabs;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(GeneralTabbedPageRenderer))]

namespace LinphoneXamarin.iOS
{

    public class GeneralTabbedPageRenderer : TabbedRenderer
    {

   

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            ((Tabs)Element).UpdateIcons += Handle_UpdateIcons;
             TabBar.TintColor = UIKit.UIColor.FromRGB(0, 104, 143);

        }

        void Handle_UpdateIcons(object arg1, TabEventArgs arg2)
        {
            try
            {
                if (arg2 != null && TabBar.Items != null)
                {
                    if (arg2.counter > 0)
                    {
                        TabBar.Items[arg2.childindex].BadgeValue = arg2.counter.ToString();
                    }
                    else
                    {
                        TabBar.Items[arg2.childindex].BadgeValue = null;
                    }
                }
            }catch(Exception e){
                addLog("err: " + e);
            }
        }

        private void addLog(string message)
        {
            MyFileSystem.Instance.writeDebug(message, "tabbedRenderer");
            Console.WriteLine($"omer928: {message}");
        }
       
    }

}
