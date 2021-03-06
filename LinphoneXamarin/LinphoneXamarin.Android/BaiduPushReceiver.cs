using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.Core.App;
using Com.Baidu.Android.Pushservice;
using LinphoneXamarin.Entities;
using LinphoneXamarin.Services;
using LinphoneXamarin.Util;
using Newtonsoft.Json;
using Plugin.CurrentActivity;
using WindowsAzure.Messaging;
using Xamarin.Essentials;

namespace LinphoneXamarin.Android
{
    [BroadcastReceiver()]
    [IntentFilter(new string[] {
        "com.baidu.android.pushservice.action.MESSAGE",
        "com.baidu.android.pushservice.action.RECEIVE",
        "com.baidu.android.pushservice.action.notification.CLICK"
       })]


    public class BaiduPushReceiver : PushMessageReceiver
    {
        public static string mChannelId, mUserId;

        /// <summary>
        /// Call this to initialize Baidu's push notification service for this device.
        /// 调用此功能开启百度推送通知服务。
        /// </summary>
        public static void InitializeBaiduPushManager()
        {
            // You can customized the appearance of the default notifcation created by SDK here
            // BasicPushNotificationBuilder -> Default OS notification UI layout, but only certain attribute are customizable.
            // CustomPushNotificationBuilder -> Custom notification UI layout

            string baiduPushApiKey = GetMetaDataValueByName("baidu_api_key");

            if (!string.IsNullOrWhiteSpace(baiduPushApiKey))
            {
                try
                {
                    Console.WriteLine("omer346: PushManager.StartWork()");
                    PushSettings.EnableDebugMode(true);
                    // PushManager.EnableXiaomiProxy(Application.Context, false, "2882303761518858140", "5581885865140");
                    PushManager.StartWork(Application.Context, PushConstants.LoginTypeApiKey, baiduPushApiKey);

                    BasicPushNotificationBuilder builder = new BasicPushNotificationBuilder();
                    builder.SetNotificationFlags(
                        (int)NotificationFlags.AutoCancel |
                        (int)NotificationFlags.HighPriority |
                        (int)NotificationFlags.ShowLights);
                    builder.SetStatusbarIcon(Resource.Drawable.atouch_launcher);
                    builder.SetChannelId("aeonix_notification_channel");
                    // the second parameter is the id. This is the id that you need to set
                    // in the JSON payload in order for the incoming notification to appear
                    // in this way.
                    PushManager.SetNotificationBuilder(CrossCurrentActivity.Current.AppContext, 1, builder);
                }
                catch (Exception e)
                {
                    Console.WriteLine("omer346: err: " + e.ToString());
                }
            }
        }

        /// <summary>
        /// Gets the value of meta data from AndroidManifest.xml, based on the given name.
        /// 获取AndroidManifest.xml的对应meta data name的值。
        /// </summary>
        /// <param name="metaDataName"></param>
        /// <returns></returns>
        private static string GetMetaDataValueByName(string metaDataName)
        {
            Bundle metaData = null;
            string metaDataValue = "";
            Context context = Application.Context;
            global::Android.Content.PM.ApplicationInfo ai = context.PackageManager.GetApplicationInfo(context.PackageName, global::Android.Content.PM.PackageInfoFlags.MetaData);

            if (ai != null)
                metaData = ai.MetaData;

            if (metaData != null)
                metaDataValue = metaData.GetString(metaDataName);

            return metaDataValue;
        }

        /// <summary>
        /// Sends the push notification channel id to the server.
        /// 把channel id发送到服务器。
        /// </summary>
        /// <param name="channelId">User's push token/用户的推送通知token。</param>
        private async void SendRegistrationToAppServer(string userId, string channelId)
        {
            // Here you should send channelId to your server and save it.
            // 这里应该把channelId发送到服务器并保存一下。
            // addLog($"SendRegistrationToAppServer: {userId}, {channelId}");
            await Task.Run(() =>
            {
                // Register with your preferred middleware such as Amazon SNS & Azure NotificationHub

                // In this sample, we're registering with Azure Notification Hub
                try
                {
                    addLog($"channel id is {channelId}");
                    //   var hub = new NotificationHub("atouch", "Endpoint=sb://tadiran-telecom-hub.servicebus.windows.net/;SharedAccessKeyName=DefaultListenSharedAccessSignature;SharedAccessKey=S5hNED/Ksbqxtre0e6lpFKiv0p7tHd5MKbLNwhRHvOs=", Application.Context);
                    //  var regId = hub.RegisterBaidu(userId, channelId, channelId);

                    NotificationTokens n = new NotificationTokens();
                    n.globalToken = channelId;
                    MyFileSystem.Instance.saveNotificationTokens(n);
                    // addLog($"Azure Notification Hub registation successful: {regId.RegistrationId} for userid: {userId}, channelId: {channelId}");

                }
                catch (Exception e)
                {
                    addLog(e.ToString());
                }

            });

        }

        /// <summary>
        /// This method will be called after calling PushManager.StarWork(). The channelId should be sent to your
        /// server; this value can be used to send push notifictions to this user.
        /// 调用PushManager.StartWork()以后，此功能要提供channelId。因为channelId让你发送本用户给通知，所以你应该把channelId
        /// 保存在服务器里。
        /// </summary>
        /// <param name="context"></param>
        /// <param name="errorCode"></param>
        /// <param name="appid"></param>
        /// <param name="userId"></param>
        /// <param name="channelId"></param>
        /// <param name="requestId"></param>
        public override void OnBind(Context context, int errorCode, string appid, string userId, string channelId, string requestId)
        {

            addLog($"OnBind, channel id is: {channelId}");
            SendRegistrationToAppServer(userId, channelId);
        }

        public override void OnMessage(Context context, string message, string customContent)
        {
            addLog($"OnMessage, message: {message} ");
            try
            {


                if (CrossCurrentActivity.Current.Activity == null)
                {
                    addLog("Destroyed mode");
                    setWakeLock();


                    addLog("launching for incoming call");
                    clearNotification();
                    if (Build.VERSION.SdkInt > BuildVersionCodes.P)
                    {
                        incomingCallHandler("Incoming call from 4001 Mike Williams");
                    }
                    else
                    {
                        addLog("regular intent");
                        Intent newMainActivity = new Intent(Application.Context, typeof(MainActivity));
                        newMainActivity.PutExtra("action", LaunchAction.INCOMING_CALL.ToString());
                        newMainActivity.AddFlags(ActivityFlags.FromBackground | ActivityFlags.ReceiverForeground | ActivityFlags.NoUserAction);
                        CrossCurrentActivity.Current.AppContext.StartActivity(newMainActivity);
                    }

                }
                else if (!((App)App.Current).isForeground)
                {
                    addLog("Background mode");
                    clearNotification();
                    if (Build.VERSION.SdkInt > BuildVersionCodes.P)
                    {
                        incomingCallHandler(message);
                    }
                    else
                    {
                        Intent resumeMainActivity = new Intent(CrossCurrentActivity.Current.AppContext, typeof(MainActivity));
                        resumeMainActivity.AddFlags(ActivityFlags.NewTask | ActivityFlags.FromBackground | ActivityFlags.ReceiverForeground | ActivityFlags.NoUserAction);
                        CrossCurrentActivity.Current.AppContext.StartActivity(resumeMainActivity);
                        var x = CrossCurrentActivity.Current.Activity as callUtilHandler;
                        x.screenStatusHandler(true);
                    }

                }


            }
            catch (Exception e)
            {
                addLog(e.ToString());
            }
        }

        public override void OnNotificationArrived(Context context, string title, string description, string customContent)
        {
            try
            {
                CustomContent data = JsonConvert.DeserializeObject<CustomContent>(customContent);
                addLog($"OnNotificationArrived, title: {title}, desc: {description}, custom content: {customContent}");
                if (CrossCurrentActivity.Current.Activity == null)
                {
                    addLog("Destroyed mode");
                    setWakeLock();

                    switch (data.type)
                    {
                        case "ISSUE_MWI":
                            int vmCounter = getVmCounter(data.info);
                            MyFileSystem.Instance.saveVMCounter(vmCounter);
                            break;
                        case "INCOMING_CALL":
                            //addLog("launching for incoming call");
                            //clearNotification();
                            //if (Build.VERSION.SdkInt > BuildVersionCodes.P)
                            //{
                            //    incomingCallHandler(title);
                            //}
                            //else
                            //{
                            //    addLog("regular intent");
                            //    Intent newMainActivity = new Intent(Application.Context, typeof(MainActivity));
                            //    newMainActivity.PutExtra("action", LaunchAction.INCOMING_CALL.ToString());
                            //    newMainActivity.AddFlags(ActivityFlags.FromBackground | ActivityFlags.ReceiverForeground | ActivityFlags.NoUserAction);
                            //    CrossCurrentActivity.Current.AppContext.StartActivity(newMainActivity);
                            //}

                            break;

                        default:
                            if (Build.VERSION.SdkInt > BuildVersionCodes.P)
                                CrossCurrentActivity.Current.AppContext.StopService(new Intent(CrossCurrentActivity.Current.AppContext, typeof(MyIncomingForgroundService)));
                            break;
                    }
                }
                else if (!((App)App.Current).isForeground)
                {
                    addLog("Background mode");
                    switch (data.type)
                    {
                        case "MISSED_CALL":
                        case "NEW_IM":
                        case "START_COLLABORATION":

                            if (Build.VERSION.SdkInt > BuildVersionCodes.P)
                                CrossCurrentActivity.Current.AppContext.StopService(new Intent(CrossCurrentActivity.Current.AppContext, typeof(MyIncomingForgroundService)));
                            break;
                        case "ISSUE_MWI":
                            int vmCounter = getVmCounter(data.info);
                            MyFileSystem.Instance.saveVMCounter(vmCounter);
                            CallLogService.Instance.setVMCounter(vmCounter);
                            break;
                        case "INCOMING_CALL":
                            clearNotification();
                            if (Build.VERSION.SdkInt > BuildVersionCodes.P)
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
                            clearNotification();
                            RegistrationService.Instance.unRegister();
                            break;
                    }
                }
                else
                {
                    addLog("Forground mode");
                    switch (data.type)
                    {
                        case "ISSUE_MWI":
                            clearNotification();
                            int vmCounter = getVmCounter(data.info);
                            MyFileSystem.Instance.saveVMCounter(vmCounter);
                            CallLogService.Instance.setVMCounter(vmCounter);
                            break;
                        case "MISSED_CALL":

                            if (LinphoneBase.Instance.linphoneCore.CallsNb > 0)
                            {
                                CallLogService.Instance.setMissedCounter(CallLogService.Instance.missedCallcounter + 1);
                            }
                            break;
                        case "REGISTRATION_LOST":
                            clearNotification();
                            RegistrationService.Instance.unRegister();
                            break;
                        default:
                            clearNotification();
                            break;
                    }
                }

            }
            catch (Exception e)
            {
                addLog(e.ToString());
            }

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

        private void clearNotification()
        {
            var notificationManager = (NotificationManager)CrossCurrentActivity.Current.AppContext.GetSystemService("notification");
            notificationManager.CancelAll();
        }

        private void setWakeLock()
        {
            addLog("setWakeLock()");
            PowerManager.WakeLock _wakeLock;
            var pm = (PowerManager)CrossCurrentActivity.Current.AppContext.ApplicationContext.GetSystemService("power");
            _wakeLock = pm.NewWakeLock((WakeLockFlags.Full | WakeLockFlags.AcquireCausesWakeup), "ATOUCH");
            _wakeLock.Acquire();
        }

        private void incomingCallHandler(string title)
        {
            addLog("full screen intent");
            Intent i2 = new Intent(Application.Context, typeof(MyIncomingForgroundService));
            i2.PutExtra("title", title);
            CrossCurrentActivity.Current.AppContext.StartForegroundService(i2);
            Thread t = new Thread(() =>
            {
                Thread.Sleep(1000 * 30);
                CrossCurrentActivity.Current.AppContext.StopService(i2);

            });
            t.Start();
        }

        public override void OnNotificationClicked(Context context, string title, string description, string customContent)
        {
            addLog($"OnNotificationClicked, customContent: {customContent}");
            try
            {
                CustomContent customContent1 = JsonConvert.DeserializeObject<CustomContent>(customContent);
                if (customContent1.type.IndexOf("START_COLLABORATION") > -1)
                {
                    SharedData sd = SharedData.Instance;
                    sd.launchAction = LaunchAction.COLLAB;
                   // var infoService = AeonixInfoService.Instance;
                   // infoService.pendingCollaborationToken = customContent1.returnKey;
                   // infoService.pendingCollaborationLink = description;
                }
            }
            catch (Exception e)
            {
                addLog(e.ToString());
            }

        }

        public override void OnUnbind(Context context, int errorCode, string requestId)
        {
            addLog("OnUnbind");
            PushManager.StopWork(Application.Context);
            MyFileSystem.Instance.saveNotificationTokens(null);
        }

        public override void OnDelTags(Context context, int errorCode, IList<string> successTags, IList<string> failedTags, string requestId)
        {
            addLog("OnDelTags");
        }

        public override void OnListTags(Context context, int errorCode, IList<string> tags, string requestId)
        {
            addLog("OnListTags");
        }

        public override void OnSetTags(Context context, int errorCode, IList<string> successTags, IList<string> failedTags, string requestId)
        {
            addLog("OnSetTags");
        }

        private void addLog(string s)
        {
            MyFileSystem.Instance.writeDebug(s, "BaiduPushReceiver");
            Console.WriteLine("omer346: " + s);
        }

        public struct CustomContent
        {
            public string type { get; set; }
            public string returnKey { get; set; }
            public string info { get; set; }
        }
    }
}