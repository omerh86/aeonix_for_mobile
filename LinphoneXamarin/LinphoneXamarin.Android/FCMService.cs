using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Net;
using Android.Net.Wifi;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Linphone;
using LinphoneXamarin.Services;
using Plugin.CurrentActivity;
using static Android.Net.Wifi.WifiManager;

namespace LinphoneXamarin.Android
{
    [Service]
    class FCMService : Service
    {
        public override IBinder OnBind(Intent intent)
        {
            throw new NotImplementedException();
        }

        //private void doHardRegistration()
        //{
        //    Console.WriteLine("omer345: doHardRegistration");
        //    WifiManager wifiManager = (WifiManager)CrossCurrentActivity.Current.AppContext.ApplicationContext.GetSystemService("wifi");
        //    WifiLock mWifiLock = wifiManager.CreateWifiLock(WifiMode.Full, "WifiLock");
        //    mWifiLock.Acquire();

        //    Java.Lang.JavaSystem.LoadLibrary("bctoolbox");
        //    Java.Lang.JavaSystem.LoadLibrary("ortp");
        //    Java.Lang.JavaSystem.LoadLibrary("mediastreamer_base");
        //    Java.Lang.JavaSystem.LoadLibrary("mediastreamer_voip");
        //    Java.Lang.JavaSystem.LoadLibrary("linphone");
        //    LinphoneAndroid.setAndroidContext(JNIEnv.Handle,this.Handle);

        //    LinphoneBase.Instance.startBackgroundItreation();
        //    setTLSSecurityParams();
        //    LoginService loginService = LoginService.Instance;
        //    loginService.register(Entities.RegisterCommands.ReRegister);
        //    new Task(() =>
        //    {
        //        Thread.Sleep(1000 * 30);
        //        global::Android.OS.Process.KillProcess(global::Android.OS.Process.MyPid());
        //        Java.Lang.JavaSystem.Exit(0);
        //    }).Start();

        //}

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