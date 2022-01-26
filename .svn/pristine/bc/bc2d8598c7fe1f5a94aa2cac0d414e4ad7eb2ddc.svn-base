using System;

using Foundation;
using LinphoneXamarin.iOS;
using LinphoneXamarin.components;
using LinphoneXamarin.styles;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ContactTabbedPage), typeof(TabbedPageRenderer))]

namespace LinphoneXamarin.iOS
{

    public class TabbedPageRenderer : TabbedRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            TabBar.TintColor = UIKit.UIColor.FromRGB(0, 104, 143);
            // TabBar.BarTintColor = UIKit.UIColor.FromRGB(0, 104, 143);
            //TabBar.BackgroundColor = UIKit.UIColor.Black;


        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            if (TabBar.Items == null) return;
            foreach (var uiTabBarItem in TabBar.Items)
            {

                // uiTabBarItem.SetTitleTextAttributes(new UITextAttributes() {TextColor = UIColor.Black},
                //    UIControlState.Normal);
                var x = new UIOffset { Horizontal = 0, Vertical = -15 };
                uiTabBarItem.TitlePositionAdjustment = x;

                uiTabBarItem.SelectedImage.AccessibilityLabel = "1";
            }
        }

    }
}