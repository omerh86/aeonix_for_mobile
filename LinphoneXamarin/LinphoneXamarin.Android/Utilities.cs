using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Plugin.Messaging;
using Android.Support.V4.Content;
using Android.Content;
using Android.Support.V4.App;
using Android.Content.PM;
using Org.Linphone.Mediastream.Video;

namespace LinphoneXamarin.Android
{
    class Utilities
    {

        public static string getExternalStoragePath()
        {
           
            return global::Android.OS.Environment.GetExternalStoragePublicDirectory(global::Android.OS.Environment.DirectoryDownloads).AbsolutePath;
        }
    }
}