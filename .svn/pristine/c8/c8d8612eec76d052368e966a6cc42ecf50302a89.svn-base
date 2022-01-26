using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Android.Pushservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='BasicPushNotificationBuilder']"
	[global::Android.Runtime.Register ("com/baidu/android/pushservice/BasicPushNotificationBuilder", DoNotGenerateAcw=true)]
	public partial class BasicPushNotificationBuilder : global::Com.Baidu.Android.Pushservice.PushNotificationBuilder {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/baidu/android/pushservice/BasicPushNotificationBuilder", typeof (BasicPushNotificationBuilder));

		internal static new IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected BasicPushNotificationBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='BasicPushNotificationBuilder']/constructor[@name='BasicPushNotificationBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BasicPushNotificationBuilder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_construct_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetConstruct_Landroid_content_Context_Handler ()
		{
			if (cb_construct_Landroid_content_Context_ == null)
				cb_construct_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Construct_Landroid_content_Context_);
			return cb_construct_Landroid_content_Context_;
		}

		static IntPtr n_Construct_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Android.Pushservice.BasicPushNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Construct (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='BasicPushNotificationBuilder']/method[@name='construct' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("construct", "(Landroid/content/Context;)Landroid/app/Notification;", "GetConstruct_Landroid_content_Context_Handler")]
		public override unsafe global::Android.App.Notification Construct (global::Android.Content.Context p0)
		{
			const string __id = "construct.(Landroid/content/Context;)Landroid/app/Notification;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.App.Notification> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
