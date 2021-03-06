using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Linphone;
using Android.Content.Res;
using System.IO;
using System.Net.Http;
using Android.Util;
using Firebase.Iid;
using Firebase;
using LinphoneXamarin.Services;

using System.Collections.Generic;
using Android;
using Android.Media;
using Android.Content;
using ImageCircle.Forms.Plugin.Droid;
using LinphoneXamarin.Entities;
using System.Linq;
using Android.Hardware;

using System.Threading;
using LinphoneXamarin.Util;
using Android.Graphics;
using Android.Net;
using Android.Telephony;

using Org.Linphone.Mediastream.Video;
using Android.Bluetooth;
using static Android.App.KeyguardManager;
using Android.Net.Wifi;
using static Android.Net.Wifi.WifiManager;
using Plugin.CurrentActivity;
using Android.Text.Format;
using AndroidX.Core.App;
using Acr.UserDialogs;
using Android.Gms.Common;
using Android.App.Job;
using Xamarin.Essentials;

namespace LinphoneXamarin.Android
{
    [Activity(Theme = "@style/MainTheme.Base", HardwareAccelerated = true, ShowWhenLocked = true, LaunchMode = LaunchMode.SingleInstance, MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait, Enabled = true, Exported = true)]
    [IntentFilter(new string[] {
        "com.tadiran.atouch2.MainActivity"
       })]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity, AndroidVideoWindowImpl.IVideoWindowListener, VideoListener, ISensorEventListener, MySensorListener, RingListener, configGenerator, AudioManager.IOnAudioFocusChangeListener, lifeCycleHandler, callUtilHandler
    {
        App application;
        int PERMISSIONS_REQUEST = 101;
        static readonly string INCOMING_CHANNEL_ID = "aeonix_incoming_notification_channel";
        static readonly string CHANNEL_ID = "aeonix_notification_channel";


        RelativeLayout fl;
        LinearLayout videoActionlayout;
        LinearLayout incomingLayout;
        SensorManager sm;
        StateListener phoneStateListener;

        private static readonly object padlock = new object();
        private NetworkStatusBroadcastReceiver _networkStatusBroadcastReceiver;

        Org.Linphone.Mediastream.Video.Display.GL2JNIView displayCamera;
        SurfaceView captureCamera;
        AndroidVideoWindowImpl androidView;

        protected override void OnCreate(Bundle bundle)
        {
            //Java.Lang.JavaSystem.LoadLibrary("c++_shared");
            Java.Lang.JavaSystem.LoadLibrary("bctoolbox");
            Java.Lang.JavaSystem.LoadLibrary("ortp");
            Java.Lang.JavaSystem.LoadLibrary("mediastreamer_base");
            Java.Lang.JavaSystem.LoadLibrary("mediastreamer_voip");
            Java.Lang.JavaSystem.LoadLibrary("linphone");
            //  Java.Lang.JavaSystem.LoadLibrary("mediastreamer");

            // This is mandatory for Android
            LinphoneAndroid.setAndroidContext(JNIEnv.Handle, this.Handle);

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
            Window.SetBackgroundDrawable(null);
            Platform.Init(this, bundle);
            string action = this.Intent.GetStringExtra("action");
            Console.WriteLine("omer456: " + action);
            SharedData sd = SharedData.Instance;
            if (action != null && action != "")
            {
                if (action == LaunchAction.INCOMING_CALL.ToString())
                {
                    clearNotifications();
                    sd.launchAction = LaunchAction.INCOMING_CALL;
                    sd.isAndroidIncomingAnswered = this.Intent.GetBooleanExtra("isAnswer", false);
                }
                else if (action == LaunchAction.COLLAB.ToString())
                {
                    clearNotifications();
                    sd.launchAction = LaunchAction.COLLAB;
                    //  var infoService = AeonixInfoService.Instance;
                    // infoService.pendingCollaborationToken = this.Intent.GetStringExtra("collab_token");
                    // infoService.pendingCollaborationLink = this.Intent.GetStringExtra("collab_link");
                }
                else if (action == LaunchAction.REGISTRATION_LOST.ToString())
                {
                    sd.launchAction = LaunchAction.REGISTRATION_LOST;
                }
                else
                {
                    sd.launchAction = LaunchAction.DEFAULT;
                    clearNotifications();
                    getPermissions();
                }
            }
            else
            {
                sd.launchAction = LaunchAction.DEFAULT;
                clearNotifications();
                getPermissions();
            }


            Xamarin.Forms.Forms.Init(this, bundle);
            ImageCircleRenderer.Init();
            UserDialogs.Init(this);
            application = new App();

            LoadApplication(application);
            setRingBackFile();
            setTLSSecurityParams();
            pushHubInitializer(Intent.GetStringExtra("token"));
            StrictMode.VmPolicy.Builder builder = new StrictMode.VmPolicy.Builder();
            StrictMode.SetVmPolicy(builder.Build());
            CreateNotificationChannels();
            sm = (SensorManager)CrossCurrentActivity.Current.Activity.GetSystemService(Context.SensorService);
            initFontScale();

            IntentFilter filter = new IntentFilter();
            filter.AddAction(AudioManager.ActionScoAudioStateUpdated);
            filter.AddAction(BluetoothAdapter.ActionStateChanged);
            filter.AddAction(BluetoothAdapter.ActionConnectionStateChanged);
            RegisterReceiver(new BtReceiver(), filter);

            IntentFilter filter2 = new IntentFilter();
            filter2.AddAction(Intent.ActionScreenOff);
            RegisterReceiver(new screenBroadcastReceiver(), filter2);

            if (_networkStatusBroadcastReceiver == null)
            {
                // Create the broadcast receiver and bind the event handler
                // so that the app gets updates of the network connectivity status
                _networkStatusBroadcastReceiver = new NetworkStatusBroadcastReceiver();
                _networkStatusBroadcastReceiver.ConnectionStatusChanged += OnNetworkStatusChanged;

                // Register the broadcast receiver
                RegisterReceiver(_networkStatusBroadcastReceiver,
                  new IntentFilter(ConnectivityManager.ConnectivityAction));
            }
            else
                addLog("OnCreate _networkStatusBroadcastReceiver already exists");



            phoneStateListener = new StateListener();
            TelephonyManager telephonyManager = (TelephonyManager)GetSystemService(TelephonyService);
            telephonyManager.Listen(phoneStateListener, PhoneStateListenerFlags.CallState);
            var Is24HourFormat = DateFormat.Is24HourFormat(this);
            addLog($"Is24HourFormat: {Is24HourFormat}");
            TimeHelper.Instance.timeFormat = Is24HourFormat ? "HH:mm" : "h:mm tt";

        }

        private void pushHubInitializer(string token)
        {
            addLog("pushHubInitializer()");
            if (token != null && token != "")
            {
                addLog($"pushHubInitializer get token from aconnect: {token}");
                NotificationTokens n = new NotificationTokens();
                n.globalToken = token;
                n.isChina = true;
                MyFileSystem.Instance.saveNotificationTokens(n);
            }
            else
            {
                var notification = MyFileSystem.Instance.loadNotificationTokens();
                if (notification != null && notification.isChina) return;

                addLog("initiate firebase");
                SharedData.Instance.customHub = null;
                FirebaseApp.InitializeApp(this);
                NotificationTokens n = new NotificationTokens();
                n.globalToken = FirebaseInstanceId.Instance.Token;
                MyFileSystem.Instance.saveNotificationTokens(n);
            }
        }

        private void stopIncomingCallService()
        {
            Intent i = new Intent(CrossCurrentActivity.Current.AppContext, typeof(MyIncomingForgroundService));
            var b = CrossCurrentActivity.Current.AppContext.StopService(i);
        }

        void OnNetworkStatusChanged(object sender, EventArgs e)
        {
            var connectivityManager = (ConnectivityManager)
               Application.Context.GetSystemService(
                   Context.ConnectivityService);

            // Check if the network is connected or connecting.
            // This means that it will be available, 
            // or become available in a few seconds.
            var activeNetworkInfo = connectivityManager.ActiveNetworkInfo;
            string message = "OnNetworkStatusChanged  activeNetworkInfo: " + activeNetworkInfo;
            Console.WriteLine("omer456: " + message);
            MyFileSystem.Instance.writeDebug(message, "main_activity");
        }

        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            switch (keyCode)
            {
                // in smartphone
                case Keycode.VolumeUp:
                case Keycode.VolumeMute:
                case Keycode.VolumeDown:

                    Console.WriteLine("omer456, keyCode: " + keyCode);
                    LinphoneBase.Instance.linphoneCore.StopRinging();
                    break;
            }
            return base.OnKeyDown(keyCode, e);
        }

        protected override void OnResume()
        {
            base.OnResume();
            stopIncomingCallService();
        }

        protected override void OnStop()
        {
            base.OnStop();
            stopProximity();
            if (LinphoneBase.Instance.linphoneCore.CallsNb > 0)
            {
                setWakeLock(false);
                setWiFiLock(true);
                inACallServiceHandler(true);
            }
        }

        private void setWiFiLock(bool shouldOn)
        {
            WifiManager wifiManager = (WifiManager)GetSystemService("wifi");
            WifiLock mWifiLock = wifiManager.CreateWifiLock(WifiMode.Full, "WifiLock");
            mWifiLock.Acquire();
            if (shouldOn)
            {
                mWifiLock.Acquire();
            }
            else
            {
                mWifiLock.Release();
            }
        }

        protected override void OnDestroy()
        {
            addLog("OnDestroy()");
            base.OnDestroy();
        }

        public void doDestroy()
        {
            addLog("doDestroy()");
            GetSystemService(Context.TelephonyService).UnregisterFromRuntime();
            string message;
            if (_networkStatusBroadcastReceiver != null)
            {
                //Application.Context.UnregisterReceiver(_networkStatusBroadcastReceiver);
                _networkStatusBroadcastReceiver.ConnectionStatusChanged -= OnNetworkStatusChanged;
                _networkStatusBroadcastReceiver = null;
                message = "doDestroy  _networkStatusBroadcastReceiver released";
            }
            else
            {
                message = "doDestroy  _networkStatusBroadcastReceiver does not exist";
            }
            this.FinishAndRemoveTask();
            ActivityManager am = (ActivityManager)GetSystemService(Context.ActivityService);
            am.KillBackgroundProcesses(PackageName);
            Process.KillProcess(Process.MyPid());
            Java.Lang.JavaSystem.Exit(0);
        }

        private void addLog(string s)
        {
            MyFileSystem.Instance.writeDebug(s, "main_activity");
            Console.WriteLine("omer345: " + s);
        }

        private void clearNotifications()
        {
            var notificationManager = NotificationManagerCompat.From(Application.Context);
            notificationManager.CancelAll();
        }

        private void initFontScale()
        {
            Configuration configuration = Resources.Configuration;
            configuration.FontScale = (float)1;
            //0.85 small, 1 standard, 1.15 big，1.3 more bigger ，1.45 supper big 
            DisplayMetrics metrics = new DisplayMetrics();
            WindowManager.DefaultDisplay.GetMetrics(metrics);
            metrics.ScaledDensity = configuration.FontScale * metrics.Density;
            BaseContext.Resources.UpdateConfiguration(configuration, metrics);
        }

        void CreateNotificationChannels()
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.O)
            {
                var regularChan = new NotificationChannel(CHANNEL_ID, "Aeonix", NotificationImportance.High);
                var IncomingChan = new NotificationChannel(INCOMING_CHANNEL_ID, "Aeonix Incoming Calls", NotificationImportance.High);
                //global::Android.Net.Uri alarmUri = global::Android.Net.Uri.Parse($"{ ContentResolver.SchemeAndroidResource}://{Application.Context.PackageName}/{Resource.Raw.ring2}");
                var alarmAttributes = new AudioAttributes.Builder()
                   .SetContentType(AudioContentType.Music)
                   .SetUsage(AudioUsageKind.NotificationRingtone).Build();
                IncomingChan.SetSound(RingtoneManager.GetDefaultUri(RingtoneType.Ringtone), alarmAttributes);
                IncomingChan.LockscreenVisibility = NotificationVisibility.Public;
                IncomingChan.EnableLights(true);
                IncomingChan.EnableVibration(true);
                IncomingChan.Importance = NotificationImportance.Max;
                regularChan.LockscreenVisibility = NotificationVisibility.Public;
                NotificationManager notificationManager =
      (NotificationManager)GetSystemService(NotificationService);
                notificationManager.CreateNotificationChannel(IncomingChan);
                notificationManager.CreateNotificationChannel(regularChan);

            }
        }

        private void getPermissions()
        {
            if (Int32.Parse(Build.VERSION.Sdk) >= 23)
            {
                List<string> Permissions = new List<string>();

                if (this.CheckSelfPermission(Manifest.Permission.Camera) != Permission.Granted)
                {
                    Permissions.Add(Manifest.Permission.Camera);
                }
                if (this.CheckSelfPermission(Manifest.Permission.DisableKeyguard) != Permission.Granted)
                {
                    Permissions.Add(Manifest.Permission.DisableKeyguard);
                }
                if (this.CheckSelfPermission(Manifest.Permission.RecordAudio) != Permission.Granted)
                {
                    Permissions.Add(Manifest.Permission.RecordAudio);
                }
                if (this.CheckSelfPermission(Manifest.Permission.ReadContacts) != Permission.Granted)
                {
                    Permissions.Add(Manifest.Permission.ReadContacts);
                }
                if (this.CheckSelfPermission(Manifest.Permission.ModifyAudioSettings) != Permission.Granted)
                {
                    Permissions.Add(Manifest.Permission.ModifyAudioSettings);
                }
                if (this.CheckSelfPermission(Manifest.Permission.WriteExternalStorage) != Permission.Granted)
                {
                    Permissions.Add(Manifest.Permission.WriteExternalStorage);
                }
                if (this.CheckSelfPermission(Manifest.Permission.ReadExternalStorage) != Permission.Granted)
                {
                    Permissions.Add(Manifest.Permission.ReadExternalStorage);
                }
                if (this.CheckSelfPermission(Manifest.Permission.ReadLogs) != Permission.Granted)
                {
                    Permissions.Add(Manifest.Permission.ReadLogs);
                }
                if (this.CheckSelfPermission(Manifest.Permission.WakeLock) != Permission.Granted)
                {
                    Permissions.Add(Manifest.Permission.WakeLock);
                }
                if (this.CheckSelfPermission(Manifest.Permission.ReadPhoneState) != Permission.Granted)
                {
                    Permissions.Add(Manifest.Permission.ReadPhoneState);
                }
                if (this.CheckSelfPermission(Manifest.Permission.ForegroundService) != Permission.Granted)
                {
                    Permissions.Add(Manifest.Permission.ForegroundService);
                }
                if (this.CheckSelfPermission(Manifest.Permission.AccessFineLocation) != Permission.Granted)
                {
                    Permissions.Add(Manifest.Permission.AccessFineLocation);
                }
                if (this.CheckSelfPermission(Manifest.Permission.AccessCoarseLocation) != Permission.Granted)
                {
                    Permissions.Add(Manifest.Permission.AccessCoarseLocation);
                }
                if (Permissions.Count > 0)
                {
                    this.RequestPermissions(Permissions.ToArray(), PERMISSIONS_REQUEST);
                }

            }
        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            if (requestCode == PERMISSIONS_REQUEST)
            {
                int i = 0;
                foreach (string permission in permissions)
                {
                    addLog("Permission " + permission + " : " + grantResults[i]);
                    if (permission.Equals("android.permission.ACCESS_FINE_LOCATION") && grantResults[i] == Permission.Denied)
                    {
                        AlertDialog.Builder dialog = new AlertDialog.Builder(this);
                        AlertDialog alert = dialog.Create();
                        alert.SetTitle("Cannot Access Location Information");
                        alert.SetMessage("Location information is required for emergency calls, please enable Aeonix Touch access to the location information.");
                        alert.SetButton("Enable Location", (c, ev) =>
                         {
                             var intent = new Intent(global::Android.Provider.Settings.ActionApplicationDetailsSettings);
                             intent.AddFlags(ActivityFlags.NewTask);
                             var uri = global::Android.Net.Uri.FromParts("package", "com.tadiran.atouch2", null);
                             intent.SetData(uri);
                             Application.Context.StartActivity(intent);
                         });
                        alert.SetButton2("CANCEL", (c, ev) => { });
                        alert.Show();
                    }

                    i += 1;
                }
            }

        }

        public void setRingBackFile()
        {
            AssetManager assets = Assets;
            string path = FilesDir.AbsolutePath;
            string ring_path = path + "/ringback.wav";
            using (var br = new BinaryReader(Application.Context.Assets.Open("ringback.wav")))
            {
                using (var bw = new BinaryWriter(new FileStream(ring_path, FileMode.Create)))
                {
                    byte[] buffer = new byte[2048];
                    int length = 0;
                    while ((length = br.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        bw.Write(buffer, 0, length);
                    }
                }
            }

            LinphoneBase.Instance.linphoneCore.Ringback = ring_path;
        }

        public void setRingFile()
        {
            AssetManager assets = Assets;
            string path = FilesDir.AbsolutePath;
            string fileName = MyFileSystem.Instance.loadSettings().ringFile;

            string ring_path = $"{path}/{fileName}";
            using (var br = new BinaryReader(Application.Context.Assets.Open(fileName)))
            {
                using (var bw = new BinaryWriter(new FileStream(ring_path, FileMode.Create)))
                {
                    byte[] buffer = new byte[2048];
                    int length = 0;
                    while ((length = br.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        bw.Write(buffer, 0, length);
                    }
                }
            }
            ((App)App.Current).LinphoneCore.Ring = ring_path;

        }



        private string getConfigPath()
        {
            AssetManager assets = Assets;
            string path = FilesDir.AbsolutePath;
            string config_path = path + "/linphonerc_default";
            using (var br = new BinaryReader(Application.Context.Assets.Open("linphonerc_default")))
            {
                using (var bw = new BinaryWriter(new FileStream(config_path, FileMode.Create)))
                {
                    byte[] buffer = new byte[2048];
                    int length = 0;
                    while ((length = br.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        bw.Write(buffer, 0, length);
                    }
                }
            }
            return config_path;

        }

        private string getConfigFactoryPath()
        {
            AssetManager assets = Assets;
            string path = FilesDir.AbsolutePath;
            string config_path = path + "/linphonerc_factory";
            using (var br = new BinaryReader(Application.Context.Assets.Open("linphonerc_factory")))
            {
                using (var bw = new BinaryWriter(new FileStream(config_path, FileMode.Create)))
                {
                    byte[] buffer = new byte[2048];
                    int length = 0;
                    while ((length = br.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        bw.Write(buffer, 0, length);
                    }
                }
            }
            return config_path;

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
             ((App)App.Current).LinphoneCore.RootCa = rootca_path;
        }

        public static void setSpeakerMode(bool isSpeaker)
        {
            AudioManager audioManager = (AudioManager)Plugin.CurrentActivity.CrossCurrentActivity.Current.Activity.GetSystemService(Context.AudioService);
            audioManager.SpeakerphoneOn = isSpeaker;
        }

        public static void setMuteMode(bool isMute)
        {
            AudioManager audioManager = (AudioManager)Plugin.CurrentActivity.CrossCurrentActivity.Current.Activity.GetSystemService(Context.AudioService);
            audioManager.MicrophoneMute = isMute;
        }

        public static void setCommunicationMode(AudioMode audioMode)
        {
            Console.WriteLine("omer333:setCommunicationMode() " + audioMode);
            AudioManager audioManager = (AudioManager)Plugin.CurrentActivity.CrossCurrentActivity.Current.Activity.GetSystemService(AudioService);
            switch (audioMode)
            {
                case AudioMode.RINGTONE:
                    audioManager.Mode = Mode.Ringtone;
                    break;
                case AudioMode.VOIP:
                    audioManager.Mode = Mode.InCommunication;
                    break;
                case AudioMode.DEFAULT:
                    audioManager.Mode = Mode.Normal;
                    break;
            }


        }


        public static bool isBTEnabled()
        {
            BluetoothAdapter bluetoothAdapter = BluetoothAdapter.DefaultAdapter;
            if (bluetoothAdapter.IsEnabled)
            {
                ProfileState p = BluetoothAdapter.DefaultAdapter.GetProfileConnectionState(ProfileType.Headset);
                return p == ProfileState.Connected;
            }
            else
                return false;
        }

        public static void turnOnBTIntent()
        {
            Intent i = new Intent(global::Android.Provider.Settings.ActionBluetoothSettings);
            Plugin.CurrentActivity.CrossCurrentActivity.Current.Activity.StartActivityForResult(i, 1);
        }

        public static void setBTScoMode(bool shouldStart)
        {
            AudioManager audioManager = (AudioManager)Plugin.CurrentActivity.CrossCurrentActivity.Current.Activity.GetSystemService(Context.AudioService);
            Console.WriteLine($"omer333:should start BluetoothSco: {shouldStart}, IsBluetoothScoAvailableOffCall: {audioManager.IsBluetoothScoAvailableOffCall}, BluetoothScoOn: {audioManager.BluetoothScoOn}");
            if (shouldStart)
            {
                audioManager.BluetoothScoOn = true;
                audioManager.StartBluetoothSco();
            }
            else
            {
                audioManager.BluetoothScoOn = false;
                audioManager.StopBluetoothSco();
            }
        }

        public void OnVideoPreviewSurfaceDestroyed(AndroidVideoWindowImpl p0)
        {
            Console.WriteLine("omer138: OnVideoPreviewSurfaceDestroyed");
        }

        public void OnVideoPreviewSurfaceReady(AndroidVideoWindowImpl p0, SurfaceView p1)
        {
            Console.WriteLine("omer138: OnVideoPreviewSurfaceReady");
            LinphoneBase.Instance.linphoneCore.NativePreviewWindowId = p1.Handle;
            p0.Update();
            p0.RequestRender();
        }

        public void OnVideoRenderingSurfaceDestroyed(AndroidVideoWindowImpl p0)
        {
            Console.WriteLine("omer138: OnVideoRenderingSurfaceDestroyed");

        }

        public void OnVideoRenderingSurfaceReady(AndroidVideoWindowImpl p0, SurfaceView p1)
        {
            Console.WriteLine("omer138: OnVideoRenderingSurfaceReady");
            LinphoneBase.Instance.linphoneCore.NativeVideoWindowId = p0.Handle;
            //p0.Update();
            //p0.RequestRender();
        }

        public void addIncomingCallComponent(string title)
        {
            incomingLayout = new LinearLayout(this);
            incomingLayout.SetBackgroundColor(Color.Black);
            RelativeLayout.LayoutParams llparams = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
            llparams.AddRule(LayoutRules.AlignParentBottom);
            LinearLayout.LayoutParams p = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.MatchParent, 1);
            TextView label = new TextView(this);
            label.Text = $"Incoming call from {title}";
            label.TextAlignment = TextAlignment.Center;
            label.TextSize = 18;
            label.Gravity = GravityFlags.CenterVertical;
            label.SetTextColor(Color.White);

            ImageButton answer = new ImageButton(this);
            answer.SetImageResource(Resource.Drawable.answer_small);
            answer.SetBackgroundColor(Color.Transparent);
            answer.Click += (sender, e) =>
            {
                CallService.Instance.answerCall(false);
            };
            ImageButton terminate = new ImageButton(this);
            terminate.SetImageResource(Resource.Drawable.end_small);
            terminate.SetBackgroundColor(Color.Transparent);
            terminate.Click += (sender, e) =>
            {
                CallService.Instance.terminateCall();
            };
            incomingLayout.AddView(label, p);
            incomingLayout.AddView(answer, p);
            incomingLayout.AddView(terminate, p);
            fl.AddView(incomingLayout, llparams);
        }

        public void removeIncomingCallComponent()
        {
            fl.RemoveView(incomingLayout);
        }

        public void setVideo(Call call)
        {
            removeVideo();
            fl = new RelativeLayout(this);
            RelativeLayout.LayoutParams lparams = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);
            //lparams.SetMargins(5, 5, 5, 0);  // left, top, right, bottom


            displayCamera = new Org.Linphone.Mediastream.Video.Display.GL2JNIView(this);
            ViewGroup.LayoutParams dparams = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
            displayCamera.LayoutParameters = dparams;

            //displayCamera.Holder.SetFixedSize(1280, 960);

            captureCamera = new SurfaceView(this);
            ViewGroup.LayoutParams cparams = new ViewGroup.LayoutParams(WindowManager.DefaultDisplay.Width / 3, WindowManager.DefaultDisplay.Height / 4);
            captureCamera.LayoutParameters = cparams;
            // captureCamera.Holder.SetFixedSize(320, 400);
            captureCamera.SetZOrderOnTop(true);

            Core core = LinphoneBase.Instance.linphoneCore;
            //captureCamera.Click += (sender, e) =>{};

            fl.AddView(captureCamera);
            fl.AddView(displayCamera);

            if (androidView != null)
            {
                androidView.UnregisterFromRuntime();
                androidView.Release();
            }

            androidView = new AndroidVideoWindowImpl(displayCamera, captureCamera, this);
            // core.NativeVideoWindowId = androidView.Handle;
            // core.NativePreviewWindowId = captureCamera.Handle;
            if (call != null)
                call.NativeVideoWindowId = androidView.Handle;

            this.AddContentView(fl, lparams);
            videoActionlayout = new LinearLayout(this);
            videoActionlayout.WeightSum = 5;
            videoActionlayout.Orientation = global::Android.Widget.Orientation.Horizontal;
            RelativeLayout.LayoutParams llparams = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
            llparams.AddRule(LayoutRules.AlignParentBottom);
            llparams.SetMargins(15, 10, 15, 10);
            captureCamera.Click += OnCameraClicked;

            ImageButton terminate = new ImageButton(this);
            terminate.SetImageResource(Resource.Drawable.end);
            terminate.SetBackgroundColor(Color.Transparent);
            terminate.SetAdjustViewBounds(true);
            terminate.Click += (sender, e) =>
            {
                CallService.Instance.terminateCall();
            };
            ImageButton speaker = new ImageButton(this);
            ImageButton video = new ImageButton(this);
            ImageButton mute = new ImageButton(this);
            ImageButton hold = new ImageButton(this);
            LinearLayout.LayoutParams p = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent, 1);

            hold.SetBackgroundColor(Color.Transparent);
            hold.SetImageResource(Resource.Drawable.hold);
            hold.SetAdjustViewBounds(true);
            hold.SetPadding(8, 0, 8, 0);
            hold.Click += (sender, e) =>
            {
                CallService.Instance.toggleHold();
                if (LinphoneBase.Instance.linphoneCore.CurrentCall == null)
                    hold.SetImageResource(Resource.Drawable.hold_active);
                else
                    hold.SetImageResource(Resource.Drawable.hold);
                hold.SetAdjustViewBounds(true);
            };
            video.SetPadding(8, 0, 8, 0);
            video.SetImageResource(Resource.Drawable.video_active);
            video.SetAdjustViewBounds(true);
            video.SetBackgroundColor(Color.Transparent);
            video.Click += (sender, e) =>
            {
                CallService.Instance.OnVideoClicked();
            };
            mute.SetBackgroundColor(Color.Transparent);
            mute.SetPadding(8, 0, 8, 0);
            mute.Click += (sender, e) =>
            {
                CallService.Instance.onMuteToggle();
                updateIcons(mute, speaker);
            };

            speaker.SetBackgroundColor(Color.Transparent);
            speaker.SetPadding(8, 0, 8, 0);
            speaker.Click += (sender, e) =>
            {
                if (MyAudioManager.Instance.myAudioState != MYAudioState.SPEAKER)
                {
                    MyAudioManager.Instance.setAudioState(MYAudioState.SPEAKER, true);
                }
                else
                {
                    MyAudioManager.Instance.setAudioState(MYAudioState.HEARPEACE, true);
                }
                updateIcons(mute, speaker);
            };
            speaker.CallOnClick();
            //updateIcons(mute, speaker);
            videoActionlayout.AddView(video, p);
            videoActionlayout.AddView(mute, p);
            videoActionlayout.AddView(terminate, p);
            videoActionlayout.AddView(hold, p);
            videoActionlayout.AddView(speaker, p);
            //videoActionlayout.Visibility = ViewStates.Gone;
            //isVideoActionlayoutVisible = false;
            fl.AddView(videoActionlayout, llparams);

            //displayCamera.Click += (sender, e) =>
            //{
            //    videoActionlayout.Visibility = isVideoActionlayoutVisible ? ViewStates.Gone : ViewStates.Visible;
            //    isVideoActionlayoutVisible = !isVideoActionlayoutVisible;
            //};
            screenStatusHandler(true);
        }

        private void OnCameraClicked(object sender, EventArgs e)
        {
            var Core = LinphoneBase.Instance.linphoneCore;

            Call call = Core.CurrentCall;
            if (call.State == Linphone.CallState.StreamsRunning)
            {
                try
                {
                    string currentDevice = Core.VideoDevice;
                    IEnumerable<string> devices = Core.VideoDevices;
                    int index = 0;
                    foreach (string d in devices)
                    {
                        if (d == currentDevice)
                        {
                            break;
                        }
                        index++;
                    }

                    String newDevice;
                    if (index == 1)
                    {
                        newDevice = devices.ElementAt(0);
                    }
                    else if (devices.Count() > 1)
                    {
                        newDevice = devices.ElementAt(1);
                    }
                    else
                    {
                        newDevice = devices.ElementAt(index);
                    }
                    Core.VideoDevice = newDevice;
                    Console.WriteLine("video device: " + Core.VideoDevice);
                    Core.UpdateCall(call, new CallParams());

                }
                catch (ArithmeticException err)
                {
                    addLog(err.ToString());
                }
            }
        }

        private void updateIcons(ImageButton mute, ImageButton speaker)
        {
            if (CallService.Instance.myCalls[0].isMute)
                mute.SetImageResource(Resource.Drawable.mute_active);
            else
                mute.SetImageResource(Resource.Drawable.mute);
            if (MyAudioManager.Instance.myAudioState == MYAudioState.SPEAKER)
                speaker.SetImageResource(Resource.Drawable.speaker_active);
            else
                speaker.SetImageResource(Resource.Drawable.speaker);

            speaker.SetAdjustViewBounds(true);
            mute.SetAdjustViewBounds(true);
        }

        public void removeVideo()
        {
            if (fl != null)
            {
                fl.RemoveAllViews();

                if (androidView != null)
                {

                    androidView.Release();
                    androidView.UnregisterFromRuntime();
                }

            }

        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            addLog("OnActivityResult: " + requestCode);

            if (requestCode == 1)
            {
                MyAudioManager.Instance.setAudioState(MYAudioState.BT, false);
            }
        }

        public void OnAccuracyChanged(Sensor sensor, [GeneratedEnum] SensorStatus accuracy)
        {
            Console.WriteLine("omer578: OnAccuracyChanged");
        }

        public void OnSensorChanged(SensorEvent e)
        {
            Console.WriteLine("omer578: sensorChanged: " + e.Values[0]);

            if (e.Values[0] > 0)
            {
                freeScreen();
            }
            else
            {
                lockScreen();
            }

        }

        private void lockScreen()
        {
            Console.WriteLine("omer578: lockscreen");
            var attributes = Window.Attributes;
            attributes.ScreenBrightness = 0;

            Window.Attributes = attributes;
            Window.AddFlags(WindowManagerFlags.Fullscreen | WindowManagerFlags.NotTouchable | WindowManagerFlags.IgnoreCheekPresses);
        }

        private void freeScreen()
        {
            Console.WriteLine("omer578: freescreen");
            var attributes = Window.Attributes;
            attributes.ScreenBrightness = -1;
            Window.Attributes = attributes;
            Window.ClearFlags(WindowManagerFlags.Fullscreen | WindowManagerFlags.NotTouchable | WindowManagerFlags.IgnoreCheekPresses);
        }

        public void startProximity()
        {
            Sensor s = sm.GetDefaultSensor(SensorType.Proximity);
            sm.UnregisterListener(this);
            sm.RegisterListener(this, s, SensorDelay.Normal);
        }

        public void stopProximity()
        {
            sm.UnregisterListener(this);
            freeScreen();
        }

        public void onRingSoundToggled(bool isRing)
        {
            if (isRing)
            {
                this.setRingFile();
            }
            else
            {
                ((App)App.Current).LinphoneCore.Ring = null;
            }
        }

        public void OnAudioFocusChange([GeneratedEnum] global::Android.Media.AudioFocus focusChange)
        {
            Console.WriteLine("omer333 OnAudioFocusChange()" + focusChange);
        }

        public string onConfigNeeded()
        {
            return getConfigPath();
        }

        public override void OnAttachedToWindow()
        {
            if (SharedData.Instance.launchAction == LaunchAction.INCOMING_CALL)
                screenStatusHandler(true);
        }

        private void setWakeLock(bool isFull)
        {
            PowerManager.WakeLock _wakeLock;
            Console.WriteLine("omer333: setWakeLock: isfull: " + isFull);
            var pm = (PowerManager)GetSystemService(PowerService);
            if (isFull)
                _wakeLock = pm.NewWakeLock((WakeLockFlags.Full | WakeLockFlags.AcquireCausesWakeup), "ATOUCH");
            else
                _wakeLock = pm.NewWakeLock(WakeLockFlags.Partial, "ATOUCH");

            _wakeLock.Acquire();
        }

        public void screenStatusHandler(bool shouldScrrenOn)
        {
            if (shouldScrrenOn)
            {
                Console.WriteLine("omer333: KeepScreenOn:true");
                RequestAudioFocus();
                setWakeLock(true);

                if (Int32.Parse(Build.VERSION.Sdk) >= 27)
                {
                    Console.WriteLine("omer333: using SetTurnScreenOn(true)");
                    this.SetTurnScreenOn(true);
                    this.SetShowWhenLocked(true);
                    var keyguardManager = (KeyguardManager)GetSystemService(KeyguardService);
                    keyguardManager.RequestDismissKeyguard(this, new MyKeyguardDismissCallback());
                    Window.AddFlags(WindowManagerFlags.KeepScreenOn);
                }
                else
                {
                    Window.AddFlags(WindowManagerFlags.KeepScreenOn |
                        WindowManagerFlags.TurnScreenOn |
                        WindowManagerFlags.ShowWhenLocked |
                       WindowManagerFlags.DismissKeyguard);
                }


            }
            else
            {
                Console.WriteLine("omer333: KeepScreenOn:false");
                Window.ClearFlags(WindowManagerFlags.KeepScreenOn |
                    WindowManagerFlags.TurnScreenOn |
                    WindowManagerFlags.ShowWhenLocked |
                    WindowManagerFlags.DismissKeyguard);
                if (Int32.Parse(Build.VERSION.Sdk) >= 27)
                {
                    Console.WriteLine("omer333: using SetTurnScreenOn(false)");
                    this.SetTurnScreenOn(false);
                    this.SetShowWhenLocked(false);
                }
            }
        }



        public void inACallServiceHandler(bool shouldRun)
        {
            Console.WriteLine("omer333:inACallServiceHandler(): " + shouldRun);
            Intent i = new Intent(CrossCurrentActivity.Current.AppContext, typeof(MyForgroundService));
            if (shouldRun)
            {
                if (Build.VERSION.SdkInt >= BuildVersionCodes.O)
                {
                    StartForegroundService(i);
                }
                else
                {
                    StartService(i);
                }
            }
            else
            {
                StopService(i);
            }
        }

        public bool RequestAudioFocus()
        {
            AudioManager audioManager = (AudioManager)Plugin.CurrentActivity.CrossCurrentActivity.Current.Activity.GetSystemService(AudioService);
            AudioFocusRequest audioFocusRequest;

            if (Build.VERSION.SdkInt > BuildVersionCodes.O)
            {
                audioFocusRequest = audioManager.RequestAudioFocus(new AudioFocusRequestClass.Builder(AudioFocus.Gain)
                .SetAudioAttributes(new AudioAttributes.Builder().SetLegacyStreamType(global::Android.Media.Stream.VoiceCall).Build()).SetOnAudioFocusChangeListener(this)
                .Build());
            }
            else
            {
                audioFocusRequest = audioManager.RequestAudioFocus(this, global::Android.Media.Stream.VoiceCall, AudioFocus.Gain);
            }

            if (audioFocusRequest == AudioFocusRequest.Granted)
            {

                return true;
            }
            return false;
        }

        public string onConfigFactoryNeeded()
        {
            return getConfigFactoryPath();
        }


        //[BroadcastReceiver(Enabled = true, Label = "Media Button Receiver")]
        //[IntentFilter(new[] { Intent.ActionMediaButton })]
        //public class MediaBtnReciever : BroadcastReceiver
        //{

        //    public override void OnReceive(Context context, Intent intent)
        //    {
        //        Console.WriteLine("omer428: MediaBtnReciever onRecieve ");
        //    }
        //}

        public class BtReceiver : BroadcastReceiver
        {
            public override void OnReceive(Context context, Intent intent)
            {

                try
                {
                    MyFileSystem.Instance.writeDebug(intent.Action, "BtReceiver");
                    Console.WriteLine("omer428: BtReceiver: " + intent.Action);
                    switch (intent.Action)
                    {

                        case BluetoothAdapter.ActionStateChanged:
                            var state = intent.GetIntExtra(BluetoothAdapter.ExtraState, -1);
                            Console.WriteLine("omer428: ActionStateChanged: " + state);
                            MyFileSystem.Instance.writeDebug($"ActionStateChanged: {state}", "BtReceiver");
                            break;
                        case AudioManager.ActionScoAudioStateUpdated:
                            var state2 = intent.GetIntExtra(AudioManager.ExtraScoAudioState, -1);
                            Console.WriteLine("omer428: ExtraScoAudioState: " + state2);
                            MyFileSystem.Instance.writeDebug($"ExtraScoAudioState: {state2}", "BtReceiver");
                            MyAudioManager.Instance.onSCOChanged(state2 == 1 ? true : false);
                            break;

                        case BluetoothAdapter.ActionConnectionStateChanged:
                            ProfileState p = BluetoothAdapter.DefaultAdapter.GetProfileConnectionState(ProfileType.Headset);
                            Console.WriteLine("omer428: ProfileState: " + p);
                            MyFileSystem.Instance.writeDebug($"ProfileState: {p}", "BtReceiver");
                            if (p == ProfileState.Disconnected)
                            {
                                MyAudioManager.Instance.onBTConnectionFailed();
                            }
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
        }

        [BroadcastReceiver()]
        public class NetworkStatusBroadcastReceiver : BroadcastReceiver
        {
            public event EventHandler ConnectionStatusChanged;
            public override void OnReceive(Context context, Intent intent)
            {
                if (ConnectionStatusChanged != null)
                    ConnectionStatusChanged(this, EventArgs.Empty);
            }
        }



        public class screenBroadcastReceiver : BroadcastReceiver
        {
            public override void OnReceive(Context context, Intent intent)
            {
                Console.WriteLine("omer428:screenBroadcastReceiver: " + intent.Action);
                if (intent.Action.Equals(Intent.ActionScreenOff))
                {
                    Console.WriteLine("omer428:ActionScreenOff: " + intent.Action);
                    var lc = LinphoneBase.Instance.linphoneCore;
                    if (lc.CallsNb == 0)
                        CrossCurrentActivity.Current.Activity.FinishAffinity();
                    else
                        lc.StopRinging();
                }

            }
        }

        public class StateListener : PhoneStateListener
        {
            public override void OnCallStateChanged(global::Android.Telephony.CallState state, string incomingNumber)
            {
                base.OnCallStateChanged(state, incomingNumber);
                if (state == global::Android.Telephony.CallState.Offhook)
                {
                    CallService.Instance.toggleHold();
                }
                Console.WriteLine("omer:238 call state is: " + state);
            }
        }


        public class MyKeyguardDismissCallback : KeyguardDismissCallback
        {
            public override void OnDismissError()
            {
                base.OnDismissError();
                Console.WriteLine("omer428:MyKeyguardDismissCallback: OnDismissError");
            }

            public override void OnDismissSucceeded()
            {
                base.OnDismissSucceeded();
                Console.WriteLine("omer428:MyKeyguardDismissCallback: OnDismissSucceeded");
            }

            public override void OnDismissCancelled()
            {
                base.OnDismissCancelled();
                Console.WriteLine("omer428:MyKeyguardDismissCallback: OnDismissCancelled");
            }
        }
    }

}

