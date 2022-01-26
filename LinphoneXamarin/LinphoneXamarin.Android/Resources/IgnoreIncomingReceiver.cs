using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Plugin.CurrentActivity;

namespace LinphoneXamarin.Android
{
    [BroadcastReceiver(Enabled = true)]
    [IntentFilter(new[] { "removeIncomingService" })]
    public class IgnoreIncomingReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            Console.WriteLine("omer3332:IgnoreIncomingReceiver OnReceive");
            Intent i = new Intent(CrossCurrentActivity.Current.AppContext, typeof(MyIncomingForgroundService));
            var b =CrossCurrentActivity.Current.AppContext.StopService(i);
            Console.WriteLine("omer3332:IgnoreIncomingReceiver: "+ b);
        }
    }
}