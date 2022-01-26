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
using Android.Views;
using Android.Widget;
using Linphone;
using LinphoneXamarin.Entities;
using LinphoneXamarin.Services;
using LinphoneXamarin.Util;

namespace LinphoneXamarin.Android
{
    [Service]
    class MyForgroundService : Service
    {

        public const int FORSERVICE_NOTIFICATION_ID = 10000;
        public const string MAIN_ACTIVITY_ACTION = "Main_activity";
        public const string PUT_EXTRA = "has_service_been_started";

        public override IBinder OnBind(Intent intent)
        {
            throw new NotImplementedException();
        }

        public const int SERVICE_RUNNING_NOTIFICATION_ID = 10000;


        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            // Code not directly related to publishing the notification has been omitted for clarity.
            // Normally, this method would hold the code to be run when the service is started.

            registerForService();
            addLog("OnStartCommand");
            return StartCommandResult.NotSticky;
        }

        public override void OnDestroy()
        {
            // Remove the notification from the status bar.
            var notificationManager = (NotificationManager)GetSystemService(NotificationService);
            notificationManager.Cancel(FORSERVICE_NOTIFICATION_ID);
            StopSelf();
            StopForeground(true);
            addLog("OnDestroy call service");
            base.OnDestroy();
        }

        private void registerForService()
        {
            try
            {
                // Enlist this instance of the service as a foreground service, MUST CALL IN < 5 SECONDS ON RUNTIME
                StartForeground(FORSERVICE_NOTIFICATION_ID, getNotification());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private Notification getNotification()
        {
            Notification.Builder builder;
            builder = new Notification.Builder(this, "aeonix_notification_channel");


            builder.SetContentTitle("Aeonix Call In Progress")
           .SetSmallIcon(Resource.Drawable.atouch_launcher);
            Intent i = PackageManager.GetLaunchIntentForPackage("com.tadiran.atouch2").SetPackage(null).SetFlags(ActivityFlags.NewTask | ActivityFlags.ResetTaskIfNeeded);
            PendingIntent pi = PendingIntent.GetActivity(this, 0, i, 0);
            builder.SetContentIntent(pi);
            return builder.Build();
        }

        private void addLog(string s)
        {
            MyFileSystem.Instance.writeDebug(s, "MyForgroundService");
            Console.WriteLine("omer345: " + s);
        }

    }
}