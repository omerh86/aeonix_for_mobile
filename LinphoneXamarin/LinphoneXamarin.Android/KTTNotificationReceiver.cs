using Android.App;
using Android.Content;
using LinphoneXamarin.Entities;
using LinphoneXamarin.Util;
using Plugin.CurrentActivity;
using System;


namespace LinphoneXamarin.Android
{
    [BroadcastReceiver(Enabled = true, Exported = true)]
    [IntentFilter(new string[] {
        "com.tadiran.atouch2.KTTNotificationReceiver"
       })]
    public class KTTNotificationReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            var type = intent.GetStringExtra("message_type");
            var token = intent.GetStringExtra("token");
            var title = $"KTTNotificationReceiver OnReceive(), type: {type}, token: {token}";
            addLog(title);
            //setNotification("KTTNotificationReceiver", $"type: {type}, token: {token}");
            if (type == "REGISTRATION_TOKEN" && token != null)
            {
                NotificationTokens n = new NotificationTokens();
                n.globalToken = token;
                MyFileSystem.Instance.saveNotificationTokens(n);
            }
         
        }

        private void setNotification(string title, string body, bool isTimeout = false)
        {
            var context = CrossCurrentActivity.Current.AppContext;
            Notification.Builder builder = new Notification.Builder(CrossCurrentActivity.Current.AppContext, "aeonix_notification_channel");

            builder.SetContentTitle(title)
             .SetContentText(body)
             .SetSmallIcon(Resource.Drawable.atouch_launcher)
             .SetChannelId("aeonix_notification_channel");

            if (isTimeout)
                builder.SetTimeoutAfter(40000);


            var notificationManager = (NotificationManager)CrossCurrentActivity.Current.AppContext.GetSystemService("notification");

            notificationManager.Notify(100, builder.Build());
        }

        private void addLog(string s)
        {
            MyFileSystem.Instance.writeDebug(s, "KTTNotificationReceiver");
            Console.WriteLine("omer346: " + s);
        }
    }
}