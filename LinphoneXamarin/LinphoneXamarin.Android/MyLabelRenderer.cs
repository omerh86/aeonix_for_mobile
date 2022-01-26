using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;
using LinphoneXamarin.Android;
using LinphoneXamarin.styles;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

//[assembly: ExportRenderer(typeof(Xamarin.Forms.Button), typeof(MyLabelRenderer))]
namespace LinphoneXamarin.Android
{
    class MyLabelRenderer : Xamarin.Forms.Platform.Android.AppCompat.ButtonRenderer
    {
        public MyLabelRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetPadding(0,0,0,0);
                
                //Control.Touch += (s, t) =>
                //{
                //    var handled = false;
                //    if (t.Event.Action == MotionEventActions.Down)
                //    {
                //        Console.WriteLine("omer4545: OnTouchDown");
                //        Control.SetBackgroundColor(global::Android.Graphics.Color.Red);
                //        handled = true;
                //    }
                //    else if (t.Event.Action == MotionEventActions.Up)
                //    {
                //        Console.WriteLine("omer4545: OnTouchUp");
                //        Control.SetBackgroundColor(global::Android.Graphics.Color.Black);
                //        handled = true;
                //    }

                //    t.Handled = handled;
                //};
            }
        }

       
    }
}