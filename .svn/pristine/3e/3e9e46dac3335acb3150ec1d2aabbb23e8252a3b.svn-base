using System;
using Foundation;
using LinphoneXamarin.iOS;
using LinphoneXamarin.components;
using LinphoneXamarin.styles;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(DialpadEntry), typeof(MyEntryRenderer))]


namespace LinphoneXamarin.iOS
{
    public class MyEntryRenderer: EntryRenderer
    {
       

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the UITextField here!
               
                Control.BorderStyle = UITextBorderStyle.None;
                Control.Enabled = false;
            }
        }
    }
}
