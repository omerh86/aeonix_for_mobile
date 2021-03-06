using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Net.Wifi;
using Android.OS;
using Android.Runtime;
using AndroidX.Core.App;

using Android.Views;
using Android.Widget;
using Linphone;
using LinphoneXamarin.Entities;
using LinphoneXamarin.Services;
using Plugin.CurrentActivity;
using LinphoneXamarin.Util;

namespace LinphoneXamarin.Android
{
    [Service]
    class MyIncomingForgroundService : Service
    {
        public override IBinder OnBind(Intent intent)
        {
            throw new NotImplementedException();
        }

        public const int SERVICE_RUNNING_NOTIFICATION_ID = 10001;

        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            addLog("OnStartCommand");
            try
            {
                StartForeground(2, getNotification(intent.GetStringExtra("title")));
                IntentFilter filter2 = new IntentFilter();
                filter2.AddAction(Intent.ActionScreenOff);
                RegisterReceiver(new screenBroadcastReceiver(), filter2);
            }
            catch (Exception e)
            {
                addLog(e.ToString());
            }
            return StartCommandResult.NotSticky;
        }

        public override void OnDestroy()
        {

            addLog("onDestroy() MyIncomingForgroundService");
            StopForeground(true);
            StopSelf();
            base.OnDestroy();
        }

        private void addLog(string s)
        {
            MyFileSystem.Instance.writeDebug(s, "MyIncomingForgroundService");
            Console.WriteLine("omer346: " + s);
        }

        private Notification getNotification(string title)
        {
            var notificationBuilder =
                                    new NotificationCompat.Builder(CrossCurrentActivity.Current.AppContext, "aeonix_incoming_notification_channel")
                                .SetSmallIcon(Resource.Drawable.atouch_launcher)
                                .SetContentTitle("Aeonix call from " + title)
                                .SetPriority(NotificationCompat.PriorityMax)
                                .SetCategory(NotificationCompat.CategoryCall)
                                .SetAutoCancel(true)
                                .SetOngoing(true)
                                .SetChannelId("aeonix_incoming_notification_channel");

            if (CrossCurrentActivity.Current.Activity == null)
            {
                notificationBuilder.AddAction(new NotificationCompat.Action(0, "Ignore", getIgnorePendingIntent()));
                notificationBuilder.AddAction(new NotificationCompat.Action(0, "Answer", getAnswerPendingIntent()));

                Intent fullScreenIntent = new Intent(CrossCurrentActivity.Current.AppContext, typeof(MainActivity));
                fullScreenIntent.PutExtra("action", LaunchAction.INCOMING_CALL.ToString());
                fullScreenIntent.AddFlags(ActivityFlags.ClearTask | ActivityFlags.NewTask | ActivityFlags.FromBackground | ActivityFlags.ReceiverForeground | ActivityFlags.NoUserAction);
                PendingIntent fullScreenPendingIntent = PendingIntent.GetActivity(CrossCurrentActivity.Current.AppContext, 0, fullScreenIntent, PendingIntentFlags.UpdateCurrent);
                notificationBuilder.SetFullScreenIntent(fullScreenPendingIntent, true);
            }
            else
            {
                LinphoneBase.Instance.linphoneCore.StopRinging();
                notificationBuilder.AddAction(new NotificationCompat.Action(0, "Decline", getEndPendingIntent()));
                notificationBuilder.AddAction(new NotificationCompat.Action(0, "Answer", getAcceptPendingIntent()));
                notificationBuilder.SetFullScreenIntent(getAcceptPendingIntent(), true);
            }
            return notificationBuilder.Build();
        }

        private PendingIntent getAnswerPendingIntent()
        {
            Console.WriteLine("omer3332:getPendingIntent2()");
            global::Android.App.TaskStackBuilder stackBuilder = global::Android.App.TaskStackBuilder.Create(this);
            Intent secondIntent = new Intent(this, typeof(MainActivity));
            secondIntent.PutExtra("action", LaunchAction.INCOMING_CALL.ToString());
            secondIntent.PutExtra("isAnswer", true);
            secondIntent.AddFlags(ActivityFlags.ClearTask | ActivityFlags.NewTask | ActivityFlags.FromBackground | ActivityFlags.ReceiverForeground);
            stackBuilder.AddParentStack(Java.Lang.Class.FromType(typeof(MainActivity)));
            stackBuilder.AddNextIntent(secondIntent);
            const int pendingIntentId = 2;
            return stackBuilder.GetPendingIntent(pendingIntentId, PendingIntentFlags.OneShot);
        }

        private PendingIntent getIgnorePendingIntent()
        {
            // Intent secondIntent = new Intent("removeIncomingService");
            Intent secondIntent = new Intent(this, typeof(IgnoreCallReceiver));
            return PendingIntent.GetBroadcast(this, 0, secondIntent, 0);
        }
        private PendingIntent getEndPendingIntent()
        {
            // Intent secondIntent = new Intent("removeIncomingService");
            Intent secondIntent = new Intent(this, typeof(EndCallReceiver));
            return PendingIntent.GetBroadcast(this, 0, secondIntent, 0);
        }
        private PendingIntent getAcceptPendingIntent()
        {
            // Intent secondIntent = new Intent("removeIncomingService");
            Intent secondIntent = new Intent(this, typeof(AnswerCallReceiver));
            return PendingIntent.GetBroadcast(this, 0, secondIntent, 0);
        }

        public class screenBroadcastReceiver : BroadcastReceiver
        {
            public override void OnReceive(Context context, Intent intent)
            {
                Console.WriteLine("omer428:screenBroadcastReceiver from service: " + intent.Action);
                Intent i = new Intent(CrossCurrentActivity.Current.AppContext, typeof(MyIncomingForgroundService));
                CrossCurrentActivity.Current.AppContext.StopService(i);
                CrossCurrentActivity.Current.Activity.FinishAffinity();
            }
        }
    }
}