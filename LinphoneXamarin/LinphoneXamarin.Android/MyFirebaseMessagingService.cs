using System;
using System.IO;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Util;
using LinphoneXamarin.Services;
using LinphoneXamarin.Util;
using Plugin.CurrentActivity;
using Firebase.Messaging;
using Android.Preferences;
using LinphoneXamarin.Entities;
using Android.Support.V4.App;
using System.Threading;
using Android.Media;

namespace LinphoneXamarin.Android
{

    [Service]
    [IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" })]
    public class MyFirebaseMessagingService : FirebaseMessagingService

    {
        const string TAG = "FCM";
        public override void OnMessageReceived(RemoteMessage message)
        {
            addLog("Fcm OnMessageReceived() ");
            try
            {
                if (message == null)
                {
                    addLog("message is null");
                    StopForeground(true);
                }
                else
                {
                    var title = message.Data["title"];
                    var body = message.Data["body"];
                    var command = message.Data["type"];
                    addLog($"Fcm message recieved, type: {command}, title: {title}, body: {body}");
                    if (CrossCurrentActivity.Current.Activity == null)
                    {
                        setWakeLock();
                        switch (command)
                        {
                            case "REGISTRATION_LOST":
                                addLog("launching for registration");
                                setNotification(title, body, getPendingIntent());
                                Intent i = new Intent(CrossCurrentActivity.Current.AppContext, typeof(MainActivity));
                                i.AddFlags(ActivityFlags.ClearTask | ActivityFlags.NewTask | ActivityFlags.FromBackground | ActivityFlags.ReceiverForeground | ActivityFlags.NoUserAction);
                                i.PutExtra("action", LaunchAction.REGISTRATION_LOST.ToString());
                                CrossCurrentActivity.Current.AppContext.StartActivity(i);
                                break;

                            case "INCOMING_CALL":
                                addLog("launching for incoming call");
                                var y = (global::Android.Telephony.TelephonyManager)CrossCurrentActivity.Current.AppContext.GetSystemService("phone");
                                if (y.CallState == global::Android.Telephony.CallState.Offhook)
                                {
                                    addLog("Decline call since cellular call is offhook");
                                    return;
                                }
                                if (Build.VERSION.SdkInt > BuildVersionCodes.O)
                                {
                                    incomingCallHandler(title);
                                }
                                else
                                {
                                    addLog("regular intent");
                                    Intent newMainActivity = new Intent(CrossCurrentActivity.Current.AppContext, typeof(MainActivity));
                                    newMainActivity.PutExtra("action", LaunchAction.INCOMING_CALL.ToString());
                                    newMainActivity.AddFlags(ActivityFlags.ClearTask | ActivityFlags.NewTask | ActivityFlags.FromBackground | ActivityFlags.ReceiverForeground | ActivityFlags.NoUserAction);
                                    CrossCurrentActivity.Current.AppContext.StartActivity(newMainActivity);
                                }

                                break;
                            case "ISSUE_MWI":
                                int vmCounter = getVmCounter(message.Data["info"]);
                                MyFileSystem.Instance.saveVMCounter(vmCounter);
                                if (vmCounter > 0)
                                    setNotification(title, body, getPendingIntent());
                                break;
                            case "START_COLLABORATION":
                                setNotification(title, "", getCollabPendingIntent(message.Data["returnKey"], body), true);
                                break;
                            default:
                                addLog("regular notification");
                                if (Build.VERSION.SdkInt > BuildVersionCodes.O)
                                    CrossCurrentActivity.Current.AppContext.StopService(new Intent(CrossCurrentActivity.Current.AppContext, typeof(MyIncomingForgroundService)));
                                setNotification(title, body, getPendingIntent());
                                break;

                        }
                    }
                    else if (!((App)App.Current).isForeground)
                    {

                        switch (command)
                        {
                            case "MISSED_CALL":
                            case "NEW_IM":
                            case "START_COLLABORATION":
                                addLog("background notification");
                                setNotification(title, body, null);
                                if (Build.VERSION.SdkInt > BuildVersionCodes.O)
                                    CrossCurrentActivity.Current.AppContext.StopService(new Intent(CrossCurrentActivity.Current.AppContext, typeof(MyIncomingForgroundService)));
                                break;
                            case "INCOMING_CALL":
                                var y = (global::Android.Telephony.TelephonyManager)CrossCurrentActivity.Current.AppContext.GetSystemService("phone");
                                if (y.CallState == global::Android.Telephony.CallState.Offhook)
                                {
                                    addLog("Decline call since cellular call is offhook");
                                    return;
                                }
                                if (Build.VERSION.SdkInt > BuildVersionCodes.O)
                                {
                                    incomingCallHandler(title);
                                }
                                else
                                {
                                    Intent resumeMainActivity = new Intent(CrossCurrentActivity.Current.AppContext, typeof(MainActivity));
                                    resumeMainActivity.AddFlags(ActivityFlags.NewTask | ActivityFlags.FromBackground | ActivityFlags.ReceiverForeground | ActivityFlags.NoUserAction);
                                    CrossCurrentActivity.Current.AppContext.StartActivity(resumeMainActivity);
                                    var x = CrossCurrentActivity.Current.Activity as callUtilHandler;
                                    x.screenStatusHandler(true);
                                }
                                break;
                            case "REGISTRATION_LOST":
                                RegistrationService.Instance.unRegister();
                                break;
                        }
                    }
                    else
                    {
                        switch (command)
                        {
                            case "ISSUE_MWI":
                                int vmCounter = getVmCounter(message.Data["info"]);
                                MyFileSystem.Instance.saveVMCounter(vmCounter);
                                CallLogService.Instance.setVMCounter(vmCounter);
                                break;
                            case "MISSED_CALL":
                                setNotification(title, body, getPendingIntent());
                                if (LinphoneBase.Instance.linphoneCore.CallsNb > 0)
                                {
                                    CallLogService.Instance.setMissedCounter(CallLogService.Instance.missedCallcounter + 1);
                                }
                                break;
                            case "REGISTRATION_LOST":
                                RegistrationService.Instance.unRegister();
                                break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Log.Debug(TAG, "err: " + e);
            }

        }

        private void addLog(string s)
        {
            MyFileSystem.Instance.writeDebug(s, TAG);
            Console.WriteLine("omer345: " + s);
        }

        private void incomingCallHandler(string title)
        {
            addLog("full screen intent");
            Intent i2 = new Intent(CrossCurrentActivity.Current.AppContext, typeof(MyIncomingForgroundService));
            i2.PutExtra("title", title);
            StartForegroundService(i2);
            Thread t = new Thread(() =>
            {
                Thread.Sleep(1000 * 20);
                CrossCurrentActivity.Current.AppContext.StopService(i2);

            });
            t.Start();
        }

        private int getVmCounter(string s)
        {
            try
            {
                char[] a = { '=', ';' };
                var parts = s.Split(a);

                return int.Parse(parts[1]);
            }
            catch (Exception e)
            {
                return 0;
            }

        }

        private void setNotification(string title, string body, PendingIntent pendingIntent, bool isTimeout = false)
        {
            var context = CrossCurrentActivity.Current.AppContext;
            Notification.Builder builder = new Notification.Builder(CrossCurrentActivity.Current.AppContext, "aeonix_notification_channel");

            builder.SetContentTitle(title)
             .SetContentText(body)
             .SetSmallIcon(Resource.Drawable.atouch_launcher)
             .SetChannelId("aeonix_notification_channel");

            if (isTimeout)
                builder.SetTimeoutAfter(40000);

            if (pendingIntent != null)
                builder.SetContentIntent(pendingIntent);


            var notificationManager = (NotificationManager)GetSystemService(NotificationService);

            notificationManager.Notify(100, builder.Build());
        }

        private PendingIntent getPendingIntent()
        {
            global::Android.App.TaskStackBuilder stackBuilder = global::Android.App.TaskStackBuilder.Create(this);
            Intent secondIntent = new Intent(this, typeof(MainActivity));
            secondIntent.PutExtra("action", LaunchAction.DEFAULT.ToString());
            stackBuilder.AddParentStack(Java.Lang.Class.FromType(typeof(MainActivity)));
            stackBuilder.AddNextIntent(secondIntent);
            const int pendingIntentId = 1;
            return stackBuilder.GetPendingIntent(pendingIntentId, PendingIntentFlags.OneShot);
        }

        private PendingIntent getCollabPendingIntent(string token, string link)
        {
            global::Android.App.TaskStackBuilder stackBuilder = global::Android.App.TaskStackBuilder.Create(this);
            Intent secondIntent = new Intent(this, typeof(MainActivity));
            stackBuilder.AddParentStack(Java.Lang.Class.FromType(typeof(MainActivity)));
            stackBuilder.AddNextIntent(secondIntent);
            const int pendingIntentId = 1;
            secondIntent.PutExtra("action", LaunchAction.COLLAB.ToString());
            secondIntent.PutExtra("collab_token", token);
            secondIntent.PutExtra("collab_link", link);
            return stackBuilder.GetPendingIntent(pendingIntentId, PendingIntentFlags.OneShot);
        }

        private void setWakeLock()
        {
            addLog("setWakeLock()");
            PowerManager.WakeLock _wakeLock;
            var pm = (PowerManager)CrossCurrentActivity.Current.AppContext.ApplicationContext.GetSystemService(PowerService);
            _wakeLock = pm.NewWakeLock((WakeLockFlags.Full | WakeLockFlags.AcquireCausesWakeup), "ATOUCH");
            //_wakeLock = pm.NewWakeLock((WakeLockFlags.Partial), "ATOUCH");
            _wakeLock.Acquire();
        }


        private void setTLSSecurityParams()
        {
            AssetManager assets = Assets;
            string path = FilesDir.AbsolutePath;
            string rootca_path = path + "/rootca.pem";
            using (var br = new BinaryReader(Application.Context.Assets.Open("rootca.pem")))
            {
                using (var bw = new BinaryWriter(new FileStream(rootca_path, FileMode.Create)))
                {
                    byte[] buffer = new byte[2048];
                    int length = 0;
                    while ((length = br.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        bw.Write(buffer, 0, length);
                    }
                }
            }
            LinphoneBase.Instance.linphoneCore.RootCa = rootca_path;
        }
    }
}