using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using LinphoneXamarin.iOS;
using LinphoneXamarin.styles;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using System.Drawing;
using Linphone;

[assembly: ExportRenderer(typeof(GradientView), typeof(GradientColorStackRenderer))]

namespace LinphoneXamarin.iOS
{


    public class GradientColorStackRenderer : PageRenderer
    {
        UIView u1;
        UIView u2;

        bool isShrink;

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null) // perform initial setup
            {

                var page = e.NewElement as GradientView;
                var gradientLayer = new CAGradientLayer();
                gradientLayer.Frame = View.Bounds;
                gradientLayer.Colors = new CGColor[] { page.StartColor.ToCGColor(), page.EndColor.ToCGColor() };
                View.Layer.InsertSublayer(gradientLayer, 0);
              
                u1 = new UIView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height/3));
                isShrink = true;
               
                u2 = new UIView(new RectangleF(0, 0, 80, 120));
                u2.AddGestureRecognizer(new UITapGestureRecognizer(OnCameraClicked));
                Services.LinphoneBase.Instance.linphoneCore.NativeVideoWindowId = u1.Handle;
                Services.LinphoneBase.Instance.linphoneCore.NativePreviewWindowId = u2.Handle;
                var v = Services.LinphoneBase.Instance.linphoneCore.VideoDevices;
                if (v.ElementAt(1) != null && v.ElementAt(1).Length > 0)
                {
                    LinphoneXamarin.Services.LinphoneBase.Instance.linphoneCore.VideoDevice = v.ElementAt(1);
                }
                View.Add(u1);
                View.Add(u2);
                View.AddGestureRecognizer(new UITapGestureRecognizer(onVideoClicked));
            }
        }
        private void onVideoClicked(){
           
            u1.Frame = new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, isShrink ? UIScreen.MainScreen.Bounds.Height : UIScreen.MainScreen.Bounds.Height / 3);
            isShrink = !isShrink;
        }
       

        private void OnCameraClicked()
        {
            var Core = Services.LinphoneBase.Instance.linphoneCore;

            Call call = Core.CurrentCall;
            if (call.State == CallState.StreamsRunning)
            {
                try
                {
                    string currentDevice = Core.VideoDevice;
                    IEnumerable<string> devices = Core.VideoDevices;
                    int index = 0;
                    foreach (string d in devices)
                    {
                        if (d == currentDevice)
                        {
                            break;
                        }
                        index++;
                    }

                    string newDevice;
                    if (index == 1)
                    {
                        newDevice = devices.ElementAt(0);
                    }
                    else if (devices.Count() > 1)
                    {
                        newDevice = devices.ElementAt(1);
                    }
                    else
                    {
                        newDevice = devices.ElementAt(index);
                    }
                    Core.VideoDevice = newDevice;
                    Console.WriteLine("video device: " + Core.VideoDevice);
                    call.Update(new CallParams());
                }
                catch (ArithmeticException)
                {
                    Console.WriteLine("Cannot swtich camera : no camera");
                }
            }
        }
    }

}