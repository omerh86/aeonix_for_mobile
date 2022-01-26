using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Android.Pushservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='CustomPushNotificationBuilder']"
	[global::Android.Runtime.Register ("com/baidu/android/pushservice/CustomPushNotificationBuilder", DoNotGenerateAcw=true)]
	public partial class CustomPushNotificationBuilder : global::Com.Baidu.Android.Pushservice.PushNotificationBuilder {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/baidu/android/pushservice/CustomPushNotificationBuilder", typeof (CustomPushNotificationBuilder));

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

		protected CustomPushNotificationBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='CustomPushNotificationBuilder']/constructor[@name='CustomPushNotificationBuilder' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IIII)V", "")]
		public unsafe CustomPushNotificationBuilder (int p0, int p1, int p2, int p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Android.Pushservice.CustomPushNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Construct (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='CustomPushNotificationBuilder']/method[@name='construct' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

		static Delegate cb_setLayoutDrawable_I;
#pragma warning disable 0169
		static Delegate GetSetLayoutDrawable_IHandler ()
		{
			if (cb_setLayoutDrawable_I == null)
				cb_setLayoutDrawable_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetLayoutDrawable_I);
			return cb_setLayoutDrawable_I;
		}

		static void n_SetLayoutDrawable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Android.Pushservice.CustomPushNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLayoutDrawable (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='CustomPushNotificationBuilder']/method[@name='setLayoutDrawable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLayoutDrawable", "(I)V", "GetSetLayoutDrawable_IHandler")]
		public virtual unsafe void SetLayoutDrawable (int p0)
		{
			const string __id = "setLayoutDrawable.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
