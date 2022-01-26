using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Linphone.Mediastream {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.linphone.mediastream']/class[@name='MediastreamerAndroidContext']"
	[global::Android.Runtime.Register ("org/linphone/mediastream/MediastreamerAndroidContext", DoNotGenerateAcw=true)]
	public partial class MediastreamerAndroidContext : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='org.linphone.mediastream']/class[@name='MediastreamerAndroidContext']/field[@name='DEVICE_HAS_BUILTIN_AEC']"
		[Register ("DEVICE_HAS_BUILTIN_AEC")]
		public const int DeviceHasBuiltinAec = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.linphone.mediastream']/class[@name='MediastreamerAndroidContext']/field[@name='DEVICE_HAS_BUILTIN_AEC_CRAPPY']"
		[Register ("DEVICE_HAS_BUILTIN_AEC_CRAPPY")]
		public const int DeviceHasBuiltinAecCrappy = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.linphone.mediastream']/class[@name='MediastreamerAndroidContext']/field[@name='DEVICE_HAS_BUILTIN_OPENSLES_AEC']"
		[Register ("DEVICE_HAS_BUILTIN_OPENSLES_AEC")]
		public const int DeviceHasBuiltinOpenslesAec = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.linphone.mediastream']/class[@name='MediastreamerAndroidContext']/field[@name='DEVICE_USE_ANDROID_MIC']"
		[Register ("DEVICE_USE_ANDROID_MIC")]
		public const int DeviceUseAndroidMic = (int) 4;

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/linphone/mediastream/MediastreamerAndroidContext", typeof (MediastreamerAndroidContext));

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

		protected MediastreamerAndroidContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public static unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream']/class[@name='MediastreamerAndroidContext']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "")]
			get {
				const string __id = "getContext.()Landroid/content/Context;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream']/class[@name='MediastreamerAndroidContext']/method[@name='enableFilterFromName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("enableFilterFromName", "(Ljava/lang/String;Z)V", "")]
		public static unsafe void EnableFilterFromName (string p0, bool p1)
		{
			const string __id = "enableFilterFromName.(Ljava/lang/String;Z)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream']/class[@name='MediastreamerAndroidContext']/method[@name='filterFromNameEnabled' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("filterFromNameEnabled", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool FilterFromNameEnabled (string p0)
		{
			const string __id = "filterFromNameEnabled.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream']/class[@name='MediastreamerAndroidContext']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("setContext", "(Ljava/lang/Object;)V", "")]
		public static unsafe void SetContext (global::Java.Lang.Object p0)
		{
			const string __id = "setContext.(Ljava/lang/Object;)V";
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
