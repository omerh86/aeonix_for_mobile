using System;
using Foundation;
using LinphoneXamarin.iOS;
using LinphoneXamarin.components;
using LinphoneXamarin.styles;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(Frame), typeof(MyFrameRenderer))]


namespace LinphoneXamarin.iOS
{
    public class MyFrameRenderer: FrameRenderer
    {
       

        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);
            if(e!=null&e.NewElement!=null){
                e.NewElement.HasShadow = false;
            }
           
        }
    }
}
