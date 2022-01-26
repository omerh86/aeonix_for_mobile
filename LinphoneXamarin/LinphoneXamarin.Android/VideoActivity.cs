using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using LinphoneXamarin.Services;


namespace LinphoneXamarin.Android
{
    [Activity(Label = "VideoActivity")]
    public class VideoActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            LinearLayout fl;

            fl = new LinearLayout(this);
            ViewGroup.LayoutParams lparams = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
            fl.LayoutParameters = lparams;
            Button answer = new Button(this);
            answer.Text = "answer";
            answer.Click += OnCallClicked;


            Button end = new Button(this);
            end.Text = "end";
            end.Click += OnEndClicked;

            fl.AddView(answer);
            fl.AddView(end);
            this.AddContentView(fl, lparams);
            screenStatusHandler(true);
            MyAudioManager.Instance.playFile("ring1.wav");
        }

        private void OnCallClicked(object sender, EventArgs e)
        {
            var i = new Intent(this, typeof(MainActivity));
            i.PutExtra("isAuto", true);
            StartActivity(i);
            this.Finish();
        }

        private void OnEndClicked(object sender, EventArgs e)
        {
            ActivityManager am = (ActivityManager)GetSystemService(ActivityService);
            am.KillBackgroundProcesses(PackageName);
            Process.KillProcess(global::Android.OS.Process.MyPid());
            Java.Lang.JavaSystem.Exit(0);
        }

        public void screenStatusHandler(bool shouldScrrenOn)
        {
            if (shouldScrrenOn)
            {
                Console.WriteLine("omer333: KeepScreenOn:true");
                PowerManager.WakeLock _wakeLock;
                var pm = (PowerManager)GetSystemService(PowerService);
                _wakeLock = pm.NewWakeLock((WakeLockFlags.Full | WakeLockFlags.AcquireCausesWakeup), "ATOUCH");
                _wakeLock.Acquire();


                if (Int32.Parse(global::Android.OS.Build.VERSION.Sdk) >= 27)
                {
                    Console.WriteLine("omer333: using SetTurnScreenOn(true)");
                    this.SetTurnScreenOn(true);
                    this.SetShowWhenLocked(true);
                }

                Window.AddFlags(WindowManagerFlags.Fullscreen | WindowManagerFlags.KeepScreenOn |
                  WindowManagerFlags.TurnScreenOn |
                  WindowManagerFlags.ShowWhenLocked |
                 WindowManagerFlags.DismissKeyguard);

            }
            else
            {
                Console.WriteLine("omer333: KeepScreenOn:false");
                Window.ClearFlags(WindowManagerFlags.Fullscreen | WindowManagerFlags.KeepScreenOn |
                    WindowManagerFlags.TurnScreenOn |
                    WindowManagerFlags.ShowWhenLocked |
                    WindowManagerFlags.AllowLockWhileScreenOn |
                    WindowManagerFlags.DismissKeyguard);
                if (Int32.Parse(global::Android.OS.Build.VERSION.Sdk) >= 27)
                {
                    Console.WriteLine("omer333: using SetTurnScreenOn(false)");
                    this.SetTurnScreenOn(false);
                    this.SetShowWhenLocked(false);

                }
            }
        }
    }
}