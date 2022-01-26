using System;

using Android.Content;

using LinphoneXamarin.Services;
using Plugin.CurrentActivity;

namespace LinphoneXamarin.Android
{
    [BroadcastReceiver(Enabled = true)]
    public class EndCallReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            Console.WriteLine("omer3332:EndCallReceiver OnReceive");
            Intent i = new Intent(CrossCurrentActivity.Current.AppContext, typeof(MyIncomingForgroundService));
            var b = CrossCurrentActivity.Current.AppContext.StopService(i);
            CallService.Instance.terminateCall();

        }
    }
}