using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Firebase.Iid;
using LinphoneXamarin.Entities;
using LinphoneXamarin.Services;
using LinphoneXamarin.Util;
using Plugin.CurrentActivity;

namespace LinphoneXamarin.Android
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.INSTANCE_ID_EVENT" })]
    public class MyFirebaseIIDService : FirebaseInstanceIdService
    {


        public override void OnTokenRefresh()
        {
            var refreshedToken = FirebaseInstanceId.Instance.Token;
            addLog($"fcm token have refreshed {refreshedToken}");
            var notification = MyFileSystem.Instance.loadNotificationTokens();
            if (notification != null && notification.isChina) return;

            addLog("save refreshed token");
            NotificationTokens n = new NotificationTokens();
            n.globalToken = refreshedToken;
            MyFileSystem.Instance.saveNotificationTokens(n);
            if (CrossCurrentActivity.Current.Activity != null && LoginService.Instance.registrationProcess.CurrentState == MyRegistrationState.AfterAeonix)
            {
                AeonixInfoService.Instance.sendFcm();
            }
        }

        private void addLog(string s)
        {
            MyFileSystem.Instance.writeDebug(s, "MyFirebaseIIDService");
            Console.WriteLine("omer346: " + s);
        }

    }
}