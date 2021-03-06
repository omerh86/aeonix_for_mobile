using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Linphone.Mediastream {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.linphone.mediastream']/class[@name='Factory']"
	[global::Android.Runtime.Register ("org/linphone/mediastream/Factory", DoNotGenerateAcw=true)]
	public partial class Factory : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/linphone/mediastream/Factory", typeof (Factory));

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

		protected Factory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_enableFilterFromName_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetEnableFilterFromName_Ljava_lang_String_ZHandler ()
		{
			if (cb_enableFilterFromName_Ljava_lang_String_Z == null)
				cb_enableFilterFromName_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_EnableFilterFromName_Ljava_lang_String_Z);
			return cb_enableFilterFromName_Ljava_lang_String_Z;
		}

		static void n_EnableFilterFromName_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.Factory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EnableFilterFromName (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream']/class[@name='Factory']/method[@name='enableFilterFromName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("enableFilterFromName", "(Ljava/lang/String;Z)V", "GetEnableFilterFromName_Ljava_lang_String_ZHandler")]
		public virtual unsafe void EnableFilterFromName (string p0, bool p1)
		{
			const string __id = "enableFilterFromName.(Ljava/lang/String;Z)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_filterFromNameEnabled_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFilterFromNameEnabled_Ljava_lang_String_Handler ()
		{
			if (cb_filterFromNameEnabled_Ljava_lang_String_ == null)
				cb_filterFromNameEnabled_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_FilterFromNameEnabled_Ljava_lang_String_);
			return cb_filterFromNameEnabled_Ljava_lang_String_;
		}

		static bool n_FilterFromNameEnabled_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.Factory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.FilterFromNameEnabled (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream']/class[@name='Factory']/method[@name='filterFromNameEnabled' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("filterFromNameEnabled", "(Ljava/lang/String;)Z", "GetFilterFromNameEnabled_Ljava_lang_String_Handler")]
		public virtual unsafe bool FilterFromNameEnabled (string p0)
		{
			const string __id = "filterFromNameEnabled.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getDecoderText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDecoderText_Ljava_lang_String_Handler ()
		{
			if (cb_getDecoderText_Ljava_lang_String_ == null)
				cb_getDecoderText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetDecoderText_Ljava_lang_String_);
			return cb_getDecoderText_Ljava_lang_String_;
		}

		static IntPtr n_GetDecoderText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.Factory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetDecoderText (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream']/class[@name='Factory']/method[@name='getDecoderText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDecoderText", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetDecoderText_Ljava_lang_String_Handler")]
		public virtual unsafe string GetDecoderText (string p0)
		{
			const string __id = "getDecoderText.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getEncoderText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetEncoderText_Ljava_lang_String_Handler ()
		{
			if (cb_getEncoderText_Ljava_lang_String_ == null)
				cb_getEncoderText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetEncoderText_Ljava_lang_String_);
			return cb_getEncoderText_Ljava_lang_String_;
		}

		static IntPtr n_GetEncoderText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.Factory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetEncoderText (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream']/class[@name='Factory']/method[@name='getEncoderText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getEncoderText", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetEncoderText_Ljava_lang_String_Handler")]
		public virtual unsafe string GetEncoderText (string p0)
		{
			const string __id = "getEncoderText.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setDeviceInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_III;
#pragma warning disable 0169
		static Delegate GetSetDeviceInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IIIHandler ()
		{
			if (cb_setDeviceInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_III == null)
				cb_setDeviceInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLIII_V) n_SetDeviceInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_III);
			return cb_setDeviceInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_III;
		}

		static void n_SetDeviceInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, int p4, int p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.Factory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetDeviceInfo (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream']/class[@name='Factory']/method[@name='setDeviceInfo' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("setDeviceInfo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;III)V", "GetSetDeviceInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IIIHandler")]
		public virtual unsafe void SetDeviceInfo (string p0, string p1, string p2, int p3, int p4, int p5)
		{
			const string __id = "setDeviceInfo.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;III)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
