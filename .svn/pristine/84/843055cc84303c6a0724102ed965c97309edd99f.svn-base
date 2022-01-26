using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Media.Session;
using Android.Views;
using Android.Widget;

namespace LinphoneXamarin.Android
{
    [BroadcastReceiver(Exported = true, Enabled = true)]
    [IntentFilter(new[] { Intent.ActionMediaButton, Intent.ActionHeadsetPlug })]
    public class MediaBtnReciever : BroadcastReceiver
    {
        public string ComponentName { get { return Class.Name; } }

        public override void OnReceive(Context context, Intent intent)
        {
            Console.WriteLine("omer428: MediaBtnReciever onRecieve ");
        }
    }
}