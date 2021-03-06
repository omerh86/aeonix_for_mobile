using System;

using Android.Content;
using LinphoneXamarin.Entities;
using LinphoneXamarin.Services;
using Plugin.CurrentActivity;

namespace LinphoneXamarin.Android
{
    [BroadcastReceiver(Enabled = true)]
    public class AnswerCallReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            Console.WriteLine("omer3332:AnswerCallReceiver OnReceive");
            Intent i = new Intent(CrossCurrentActivity.Current.AppContext, typeof(MyIncomingForgroundService));
            var b = CrossCurrentActivity.Current.AppContext.StopService(i);
            ((callUtilHandler)CrossCurrentActivity.Current.Activity).screenStatusHandler(true);
            CallService.Instance.answerCall(false);
            Intent i2 = new Intent(CrossCurrentActivity.Current.AppContext, typeof(MyForgroundService));
            CrossCurrentActivity.Current.AppContext.StartForegroundService(i2);
        }
    }
}
