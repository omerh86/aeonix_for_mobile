using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Android.Pushservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushMessageReceiver']"
	[global::Android.Runtime.Register ("com/baidu/android/pushservice/PushMessageReceiver", DoNotGenerateAcw=true)]
	public abstract partial class PushMessageReceiver : global::Android.Content.BroadcastReceiver {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushMessageReceiver']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "PushMessageReceiver";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/baidu/android/pushservice/PushMessageReceiver", typeof (PushMessageReceiver));

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

		protected PushMessageReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushMessageReceiver']/constructor[@name='PushMessageReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PushMessageReceiver () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_onBind_Landroid_content_Context_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnBind_Landroid_content_Context_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onBind_Landroid_content_Context_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onBind_Landroid_content_Context_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLILLLL_V) n_OnBind_Landroid_content_Context_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_onBind_Landroid_content_Context_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnBind_Landroid_content_Context_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Android.Pushservice.PushMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			var p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.OnBind (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushMessageReceiver']/method[@name='onBind' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("onBind", "(Landroid/content/Context;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetOnBind_Landroid_content_Context_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract void OnBind (global::Android.Content.Context p0, int p1, string p2, string p3, string p4, string p5);

		static Delegate cb_onDelTags_Landroid_content_Context_ILjava_util_List_Ljava_util_List_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnDelTags_Landroid_content_Context_ILjava_util_List_Ljava_util_List_Ljava_lang_String_Handler ()
		{
			if (cb_onDelTags_Landroid_content_Context_ILjava_util_List_Ljava_util_List_Ljava_lang_String_ == null)
				cb_onDelTags_Landroid_content_Context_ILjava_util_List_Ljava_util_List_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLILLL_V) n_OnDelTags_Landroid_content_Context_ILjava_util_List_Ljava_util_List_Ljava_lang_String_);
			return cb_onDelTags_Landroid_content_Context_ILjava_util_List_Ljava_util_List_Ljava_lang_String_;
		}

		static void n_OnDelTags_Landroid_content_Context_ILjava_util_List_Ljava_util_List_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Android.Pushservice.PushMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnDelTags (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushMessageReceiver']/method[@name='onDelTags' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[5][@type='java.lang.String']]"
		[Register ("onDelTags", "(Landroid/content/Context;ILjava/util/List;Ljava/util/List;Ljava/lang/String;)V", "GetOnDelTags_Landroid_content_Context_ILjava_util_List_Ljava_util_List_Ljava_lang_String_Handler")]
		public abstract void OnDelTags (global::Android.Content.Context p0, int p1, global::System.Collections.Generic.IList<string> p2, global::System.Collections.Generic.IList<string> p3, string p4);

		static Delegate cb_onListTags_Landroid_content_Context_ILjava_util_List_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnListTags_Landroid_content_Context_ILjava_util_List_Ljava_lang_String_Handler ()
		{
			if (cb_onListTags_Landroid_content_Context_ILjava_util_List_Ljava_lang_String_ == null)
				cb_onListTags_Landroid_content_Context_ILjava_util_List_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLILL_V) n_OnListTags_Landroid_content_Context_ILjava_util_List_Ljava_lang_String_);
			return cb_onListTags_Landroid_content_Context_ILjava_util_List_Ljava_lang_String_;
		}

		static void n_OnListTags_Landroid_content_Context_ILjava_util_List_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Android.Pushservice.PushMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnListTags (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushMessageReceiver']/method[@name='onListTags' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[4][@type='java.lang.String']]"
		[Register ("onListTags", "(Landroid/content/Context;ILjava/util/List;Ljava/lang/String;)V", "GetOnListTags_Landroid_content_Context_ILjava_util_List_Ljava_lang_String_Handler")]
		public abstract void OnListTags (global::Android.Content.Context p0, int p1, global::System.Collections.Generic.IList<string> p2, string p3);

		static Delegate cb_onMessage_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnMessage_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onMessage_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onMessage_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnMessage_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_);
			return cb_onMessage_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnMessage_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Android.Pushservice.PushMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnMessage (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushMessageReceiver']/method[@name='onMessage' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("onMessage", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "GetOnMessage_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract void OnMessage (global::Android.Content.Context p0, string p1, string p2);

		static Delegate cb_onNotificationArrived_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnNotificationArrived_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onNotificationArrived_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onNotificationArrived_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_OnNotificationArrived_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_onNotificationArrived_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnNotificationArrived_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Android.Pushservice.PushMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnNotificationArrived (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushMessageReceiver']/method[@name='onNotificationArrived' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("onNotificationArrived", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetOnNotificationArrived_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract void OnNotificationArrived (global::Android.Content.Context p0, string p1, string p2, string p3);

		static Delegate cb_onNotificationClicked_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnNotificationClicked_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onNotificationClicked_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onNotificationClicked_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_OnNotificationClicked_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_onNotificationClicked_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnNotificationClicked_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Android.Pushservice.PushMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnNotificationClicked (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushMessageReceiver']/method[@name='onNotificationClicked' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("onNotificationClicked", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetOnNotificationClicked_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract void OnNotificationClicked (global::Android.Content.Context p0, string p1, string p2, string p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushMessageReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "")]
		public override sealed unsafe void OnReceive (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			const string __id = "onReceive.(Landroid/content/Context;Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_onSetTags_Landroid_content_Context_ILjava_util_List_Ljava_util_List_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSetTags_Landroid_content_Context_ILjava_util_List_Ljava_util_List_Ljava_lang_String_Handler ()
		{
			if (cb_onSetTags_Landroid_content_Context_ILjava_util_List_Ljava_util_List_Ljava_lang_String_ == null)
				cb_onSetTags_Landroid_content_Context_ILjava_util_List_Ljava_util_List_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLILLL_V) n_OnSetTags_Landroid_content_Context_ILjava_util_List_Ljava_util_List_Ljava_lang_String_);
			return cb_onSetTags_Landroid_content_Context_ILjava_util_List_Ljava_util_List_Ljava_lang_String_;
		}

		static void n_OnSetTags_Landroid_content_Context_ILjava_util_List_Ljava_util_List_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Android.Pushservice.PushMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnSetTags (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushMessageReceiver']/method[@name='onSetTags' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[5][@type='java.lang.String']]"
		[Register ("onSetTags", "(Landroid/content/Context;ILjava/util/List;Ljava/util/List;Ljava/lang/String;)V", "GetOnSetTags_Landroid_content_Context_ILjava_util_List_Ljava_util_List_Ljava_lang_String_Handler")]
		public abstract void OnSetTags (global::Android.Content.Context p0, int p1, global::System.Collections.Generic.IList<string> p2, global::System.Collections.Generic.IList<string> p3, string p4);

		static Delegate cb_onUnbind_Landroid_content_Context_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnUnbind_Landroid_content_Context_ILjava_lang_String_Handler ()
		{
			if (cb_onUnbind_Landroid_content_Context_ILjava_lang_String_ == null)
				cb_onUnbind_Landroid_content_Context_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_V) n_OnUnbind_Landroid_content_Context_ILjava_lang_String_);
			return cb_onUnbind_Landroid_content_Context_ILjava_lang_String_;
		}

		static void n_OnUnbind_Landroid_content_Context_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Android.Pushservice.PushMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnUnbind (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushMessageReceiver']/method[@name='onUnbind' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onUnbind", "(Landroid/content/Context;ILjava/lang/String;)V", "GetOnUnbind_Landroid_content_Context_ILjava_lang_String_Handler")]
		public abstract void OnUnbind (global::Android.Content.Context p0, int p1, string p2);

	}

	[global::Android.Runtime.Register ("com/baidu/android/pushservice/PushMessageReceiver", DoNotGenerateAcw=true)]
	internal partial class PushMessageReceiverInvoker : PushMessageReceiver {
		public PushMessageReceiverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/baidu/android/pushservice/PushMessageReceiver", typeof (PushMessageReceiverInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushMessageReceiver']/method[@name='onBind' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("onBind", "(Landroid/content/Context;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetOnBind_Landroid_content_Context_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe void OnBind (global::Android.Content.Context p0, int p1, string p2, string p3, string p4, string p5)
		{
			const string __id = "onBind.(Landroid/content/Context;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushMessageReceiver']/method[@name='onDelTags' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[5][@type='java.lang.String']]"
		[Register ("onDelTags", "(Landroid/content/Context;ILjava/util/List;Ljava/util/List;Ljava/lang/String;)V", "GetOnDelTags_Landroid_content_Context_ILjava_util_List_Ljava_util_List_Ljava_lang_String_Handler")]
		public override unsafe void OnDelTags (global::Android.Content.Context p0, int p1, global::System.Collections.Generic.IList<string> p2, global::System.Collections.Generic.IList<string> p3, string p4)
		{
			const string __id = "onDelTags.(Landroid/content/Context;ILjava/util/List;Ljava/util/List;Ljava/lang/String;)V";
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushMessageReceiver']/method[@name='onListTags' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[4][@type='java.lang.String']]"
		[Register ("onListTags", "(Landroid/content/Context;ILjava/util/List;Ljava/lang/String;)V", "GetOnListTags_Landroid_content_Context_ILjava_util_List_Ljava_lang_String_Handler")]
		public override unsafe void OnListTags (global::Android.Content.Context p0, int p1, global::System.Collections.Generic.IList<string> p2, string p3)
		{
			const string __id = "onListTags.(Landroid/content/Context;ILjava/util/List;Ljava/lang/String;)V";
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushMessageReceiver']/method[@name='onMessage' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("onMessage", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "GetOnMessage_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe void OnMessage (global::Android.Content.Context p0, string p1, string p2)
		{
			const string __id = "onMessage.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushMessageReceiver']/method[@name='onNotificationArrived' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("onNotificationArrived", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetOnNotificationArrived_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe void OnNotificationArrived (global::Android.Content.Context p0, string p1, string p2, string p3)
		{
			const string __id = "onNotificationArrived.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushMessageReceiver']/method[@name='onNotificationClicked' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("onNotificationClicked", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetOnNotificationClicked_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe void OnNotificationClicked (global::Android.Content.Context p0, string p1, string p2, string p3)
		{
			const string __id = "onNotificationClicked.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushMessageReceiver']/method[@name='onSetTags' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[5][@type='java.lang.String']]"
		[Register ("onSetTags", "(Landroid/content/Context;ILjava/util/List;Ljava/util/List;Ljava/lang/String;)V", "GetOnSetTags_Landroid_content_Context_ILjava_util_List_Ljava_util_List_Ljava_lang_String_Handler")]
		public override unsafe void OnSetTags (global::Android.Content.Context p0, int p1, global::System.Collections.Generic.IList<string> p2, global::System.Collections.Generic.IList<string> p3, string p4)
		{
			const string __id = "onSetTags.(Landroid/content/Context;ILjava/util/List;Ljava/util/List;Ljava/lang/String;)V";
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice']/class[@name='PushMessageReceiver']/method[@name='onUnbind' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onUnbind", "(Landroid/content/Context;ILjava/lang/String;)V", "GetOnUnbind_Landroid_content_Context_ILjava_lang_String_Handler")]
		public override unsafe void OnUnbind (global::Android.Content.Context p0, int p1, string p2)
		{
			const string __id = "onUnbind.(Landroid/content/Context;ILjava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
