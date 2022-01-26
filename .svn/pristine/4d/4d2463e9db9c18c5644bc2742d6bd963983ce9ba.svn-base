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
using LinphoneXamarin.Util;
using Plugin.CurrentActivity;

namespace LinphoneXamarin.Android
{
    [Application]
    public class MainApplication : Application, Application.IActivityLifecycleCallbacks
    {
        MyFileSystem fileSystem;

        public MainApplication(IntPtr handle, JniHandleOwnership transer)
          : base(handle, transer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();
            RegisterActivityLifecycleCallbacks(this);
            //A great place to initialize Xamarin.Insights and Dependency Services!
            fileSystem = MyFileSystem.Instance;
        }

        public override void OnTerminate()
        {
            base.OnTerminate();
            UnregisterActivityLifecycleCallbacks(this);

        }

        public void OnActivityCreated(Activity activity, Bundle savedInstanceState)
        {
            CrossCurrentActivity.Current.Activity = activity;
            addLog("app state: " + "OnActivityCreated");
            Console.WriteLine("omer:333 app state: OnActivityCreated");
        }

        public void OnActivityDestroyed(Activity activity)
        {
            addLog("app state: " + "OnActivityDestroyed");
            Console.WriteLine("omer:333 app state: OnActivityDestroyed");
            CrossCurrentActivity.Current.Activity = null;
        }

        public void OnActivityPaused(Activity activity)
        {
            addLog("app state: " + "OnActivityPaused");
            Console.WriteLine("omer:333 app state: OnActivityPaused");
        }

        public void OnActivityResumed(Activity activity)
        {
            CrossCurrentActivity.Current.Activity = activity;
            addLog("app state: " + "OnActivityResumed");
            Console.WriteLine("omer:333 app state: OnActivityResumed");
        }

        public void OnActivitySaveInstanceState(Activity activity, Bundle outState)
        {
        }

        public void OnActivityStarted(Activity activity)
        {
            CrossCurrentActivity.Current.Activity = activity;
            addLog("app state: " + "OnActivityStarted");
            Console.WriteLine("omer:333 app state: OnActivityStarted");
        }

        public void OnActivityStopped(Activity activity)
        {
            addLog("app state: " + "OnActivityStopped");
            Console.WriteLine("omer:333 app state: OnActivityStopped");
        }

        private void addLog(string message)
        {
            if (fileSystem != null)
            {
                fileSystem.writeDebug(message, "app_lifecycle");
            }
        }
    }
}