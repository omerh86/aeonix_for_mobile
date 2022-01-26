using System;

using Android.Content;
using Plugin.CurrentActivity;

namespace LinphoneXamarin.Android
{
    [BroadcastReceiver(Enabled = true)]

    public class IgnoreCallReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            Console.WriteLine("omer3332:IgnoreIncomingReceiver OnReceive");
            Intent i = new Intent(CrossCurrentActivity.Current.AppContext, typeof(MyIncomingForgroundService));
            var b = CrossCurrentActivity.Current.AppContext.StopService(i);
            Console.WriteLine("omer3332:IgnoreIncomingReceiver: " + b);
        }
    }
}