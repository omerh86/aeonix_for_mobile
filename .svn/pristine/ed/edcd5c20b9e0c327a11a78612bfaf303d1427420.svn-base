using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Android.Pushservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']"
	[global::Android.Runtime.Register ("com/baidu/android/pushservice/PushManager", DoNotGenerateAcw=true)]
	public partial class PushManager : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/baidu/android/pushservice/PushManager", typeof (PushManager));

		internal static IntPtr class_ref {
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

		protected PushManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/constructor[@name='PushManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PushManager () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/method[@name='bindPush' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("bindPush", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void BindPush (global::Android.Content.Context p0, string p1)
		{
			const string __id = "bindPush.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/method[@name='createNotificationChannel' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("createNotificationChannel", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void CreateNotificationChannel (global::Android.Content.Context p0, string p1, string p2)
		{
			const string __id = "createNotificationChannel.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/method[@name='delTags' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("delTags", "(Landroid/content/Context;Ljava/util/List;)V", "")]
		public static unsafe void DelTags (global::Android.Content.Context p0, global::System.Collections.Generic.IList<string> p1)
		{
			const string __id = "delTags.(Landroid/content/Context;Ljava/util/List;)V";
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/method[@name='deleteNotificationChannel' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("deleteNotificationChannel", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void DeleteNotificationChannel (global::Android.Content.Context p0, string p1)
		{
			const string __id = "deleteNotificationChannel.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/method[@name='disableAlarm' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("disableAlarm", "(Landroid/content/Context;)V", "")]
		public static unsafe void DisableAlarm (global::Android.Content.Context p0)
		{
			const string __id = "disableAlarm.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/method[@name='enableHuaweiProxy' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("enableHuaweiProxy", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void EnableHuaweiProxy (global::Android.Content.Context p0, bool p1)
		{
			const string __id = "enableHuaweiProxy.(Landroid/content/Context;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/method[@name='enableMeizuProxy' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("enableMeizuProxy", "(Landroid/content/Context;ZLjava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void EnableMeizuProxy (global::Android.Content.Context p0, bool p1, string p2, string p3)
		{
			const string __id = "enableMeizuProxy.(Landroid/content/Context;ZLjava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/method[@name='enableOppoProxy' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("enableOppoProxy", "(Landroid/content/Context;ZLjava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void EnableOppoProxy (global::Android.Content.Context p0, bool p1, string p2, string p3)
		{
			const string __id = "enableOppoProxy.(Landroid/content/Context;ZLjava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/method[@name='enableVivoProxy' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("enableVivoProxy", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void EnableVivoProxy (global::Android.Content.Context p0, bool p1)
		{
			const string __id = "enableVivoProxy.(Landroid/content/Context;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/method[@name='enableXiaomiProxy' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("enableXiaomiProxy", "(Landroid/content/Context;ZLjava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void EnableXiaomiProxy (global::Android.Content.Context p0, bool p1, string p2, string p3)
		{
			const string __id = "enableXiaomiProxy.(Landroid/content/Context;ZLjava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/method[@name='getBindType' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getBindType", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetBindType (global::Android.Content.Context p0)
		{
			const string __id = "getBindType.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/method[@name='insertPassThroughMessageClick' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("insertPassThroughMessageClick", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void InsertPassThroughMessageClick (global::Android.Content.Context p0, string p1, string p2)
		{
			const string __id = "insertPassThroughMessageClick.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/method[@name='isPushEnabled' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isPushEnabled", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsPushEnabled (global::Android.Content.Context p0)
		{
			const string __id = "isPushEnabled.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/method[@name='listTags' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("listTags", "(Landroid/content/Context;)V", "")]
		public static unsafe void ListTags (global::Android.Content.Context p0)
		{
			const string __id = "listTags.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/method[@name='reStartWork' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("reStartWork", "(Landroid/content/Context;)V", "")]
		public static unsafe void ReStartWork (global::Android.Content.Context p0)
		{
			const string __id = "reStartWork.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/method[@name='requestOppoNotification' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("requestOppoNotification", "(Landroid/content/Context;)V", "")]
		public static unsafe void RequestOppoNotification (global::Android.Content.Context p0)
		{
			const string __id = "requestOppoNotification.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/method[@name='resumeWork' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("resumeWork", "(Landroid/content/Context;)V", "")]
		public static unsafe void ResumeWork (global::Android.Content.Context p0)
		{
			const string __id = "resumeWork.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/method[@name='setDefaultNotificationBuilder' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.baidu.android.pushservice.PushNotificationBuilder']]"
		[Register ("setDefaultNotificationBuilder", "(Landroid/content/Context;Lcom/baidu/android/pushservice/PushNotificationBuilder;)V", "")]
		public static unsafe void SetDefaultNotificationBuilder (global::Android.Content.Context p0, global::Com.Baidu.Android.Pushservice.PushNotificationBuilder p1)
		{
			const string __id = "setDefaultNotificationBuilder.(Landroid/content/Context;Lcom/baidu/android/pushservice/PushNotificationBuilder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/method[@name='setJobSchedulerId' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("setJobSchedulerId", "(Landroid/content/Context;I)V", "")]
		public static unsafe void SetJobSchedulerId (global::Android.Content.Context p0, int p1)
		{
			const string __id = "setJobSchedulerId.(Landroid/content/Context;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/method[@name='setNoDisturbMode' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("setNoDisturbMode", "(Landroid/content/Context;IIII)V", "")]
		public static unsafe void SetNoDisturbMode (global::Android.Content.Context p0, int p1, int p2, int p3, int p4)
		{
			const string __id = "setNoDisturbMode.(Landroid/content/Context;IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/method[@name='setNotificationBuilder' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='com.baidu.android.pushservice.PushNotificationBuilder']]"
		[Register ("setNotificationBuilder", "(Landroid/content/Context;ILcom/baidu/android/pushservice/PushNotificationBuilder;)V", "")]
		public static unsafe void SetNotificationBuilder (global::Android.Content.Context p0, int p1, global::Com.Baidu.Android.Pushservice.PushNotificationBuilder p2)
		{
			const string __id = "setNotificationBuilder.(Landroid/content/Context;ILcom/baidu/android/pushservice/PushNotificationBuilder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/method[@name='setTags' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("setTags", "(Landroid/content/Context;Ljava/util/List;)V", "")]
		public static unsafe void SetTags (global::Android.Content.Context p0, global::System.Collections.Generic.IList<string> p1)
		{
			const string __id = "setTags.(Landroid/content/Context;Ljava/util/List;)V";
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/method[@name='startWork' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("startWork", "(Landroid/content/Context;ILjava/lang/String;)V", "")]
		public static unsafe void StartWork (global::Android.Content.Context p0, int p1, string p2)
		{
			const string __id = "startWork.(Landroid/content/Context;ILjava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushManager']/method[@name='stopWork' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("stopWork", "(Landroid/content/Context;)V", "")]
		public static unsafe void StopWork (global::Android.Content.Context p0)
		{
			const string __id = "stopWork.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
