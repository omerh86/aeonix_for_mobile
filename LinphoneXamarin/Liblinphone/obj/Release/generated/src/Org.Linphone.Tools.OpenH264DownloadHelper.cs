using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Linphone.Tools {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.linphone.tools']/class[@name='OpenH264DownloadHelper']"
	[global::Android.Runtime.Register ("org/linphone/tools/OpenH264DownloadHelper", DoNotGenerateAcw=true)]
	public partial class OpenH264DownloadHelper : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/linphone/tools/OpenH264DownloadHelper", typeof (OpenH264DownloadHelper));

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

		protected OpenH264DownloadHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.linphone.tools']/class[@name='OpenH264DownloadHelper']/constructor[@name='OpenH264DownloadHelper' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe OpenH264DownloadHelper (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_getFullPathLib;
#pragma warning disable 0169
		static Delegate GetGetFullPathLibHandler ()
		{
			if (cb_getFullPathLib == null)
				cb_getFullPathLib = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFullPathLib);
			return cb_getFullPathLib;
		}

		static IntPtr n_GetFullPathLib (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Tools.OpenH264DownloadHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FullPathLib);
		}
#pragma warning restore 0169

		public virtual unsafe string FullPathLib {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.tools']/class[@name='OpenH264DownloadHelper']/method[@name='getFullPathLib' and count(parameter)=0]"
			[Register ("getFullPathLib", "()Ljava/lang/String;", "GetGetFullPathLibHandler")]
			get {
				const string __id = "getFullPathLib.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isCodecFound;
#pragma warning disable 0169
		static Delegate GetIsCodecFoundHandler ()
		{
			if (cb_isCodecFound == null)
				cb_isCodecFound = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCodecFound);
			return cb_isCodecFound;
		}

		static bool n_IsCodecFound (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Tools.OpenH264DownloadHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCodecFound;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsCodecFound {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.tools']/class[@name='OpenH264DownloadHelper']/method[@name='isCodecFound' and count(parameter)=0]"
			[Register ("isCodecFound", "()Z", "GetIsCodecFoundHandler")]
			get {
				const string __id = "isCodecFound.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLicenseMessage;
#pragma warning disable 0169
		static Delegate GetGetLicenseMessageHandler ()
		{
			if (cb_getLicenseMessage == null)
				cb_getLicenseMessage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLicenseMessage);
			return cb_getLicenseMessage;
		}

		static IntPtr n_GetLicenseMessage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Tools.OpenH264DownloadHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LicenseMessage);
		}
#pragma warning restore 0169

		public virtual unsafe string LicenseMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.tools']/class[@name='OpenH264DownloadHelper']/method[@name='getLicenseMessage' and count(parameter)=0]"
			[Register ("getLicenseMessage", "()Ljava/lang/String;", "GetGetLicenseMessageHandler")]
			get {
				const string __id = "getLicenseMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNameLib;
#pragma warning disable 0169
		static Delegate GetGetNameLibHandler ()
		{
			if (cb_getNameLib == null)
				cb_getNameLib = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNameLib);
			return cb_getNameLib;
		}

		static IntPtr n_GetNameLib (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Tools.OpenH264DownloadHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NameLib);
		}
#pragma warning restore 0169

		static Delegate cb_setNameLib_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNameLib_Ljava_lang_String_Handler ()
		{
			if (cb_setNameLib_Ljava_lang_String_ == null)
				cb_setNameLib_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetNameLib_Ljava_lang_String_);
			return cb_setNameLib_Ljava_lang_String_;
		}

		static void n_SetNameLib_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Tools.OpenH264DownloadHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NameLib = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string NameLib {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.tools']/class[@name='OpenH264DownloadHelper']/method[@name='getNameLib' and count(parameter)=0]"
			[Register ("getNameLib", "()Ljava/lang/String;", "GetGetNameLibHandler")]
			get {
				const string __id = "getNameLib.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.tools']/class[@name='OpenH264DownloadHelper']/method[@name='setNameLib' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNameLib", "(Ljava/lang/String;)V", "GetSetNameLib_Ljava_lang_String_Handler")]
			set {
				const string __id = "setNameLib.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUserDataSize;
#pragma warning disable 0169
		static Delegate GetGetUserDataSizeHandler ()
		{
			if (cb_getUserDataSize == null)
				cb_getUserDataSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetUserDataSize);
			return cb_getUserDataSize;
		}

		static int n_GetUserDataSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Tools.OpenH264DownloadHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UserDataSize;
		}
#pragma warning restore 0169

		public virtual unsafe int UserDataSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.tools']/class[@name='OpenH264DownloadHelper']/method[@name='getUserDataSize' and count(parameter)=0]"
			[Register ("getUserDataSize", "()I", "GetGetUserDataSizeHandler")]
			get {
				const string __id = "getUserDataSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_downloadCodec;
#pragma warning disable 0169
		static Delegate GetDownloadCodecHandler ()
		{
			if (cb_downloadCodec == null)
				cb_downloadCodec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DownloadCodec);
			return cb_downloadCodec;
		}

		static void n_DownloadCodec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Tools.OpenH264DownloadHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DownloadCodec ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.tools']/class[@name='OpenH264DownloadHelper']/method[@name='downloadCodec' and count(parameter)=0]"
		[Register ("downloadCodec", "()V", "GetDownloadCodecHandler")]
		public virtual unsafe void DownloadCodec ()
		{
			const string __id = "downloadCodec.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getUserData_I;
#pragma warning disable 0169
		static Delegate GetGetUserData_IHandler ()
		{
			if (cb_getUserData_I == null)
				cb_getUserData_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetUserData_I);
			return cb_getUserData_I;
		}

		static IntPtr n_GetUserData_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Tools.OpenH264DownloadHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetUserData (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.tools']/class[@name='OpenH264DownloadHelper']/method[@name='getUserData' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getUserData", "(I)Ljava/lang/Object;", "GetGetUserData_IHandler")]
		public virtual unsafe global::Java.Lang.Object GetUserData (int p0)
		{
			const string __id = "getUserData.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setNameFileDownload_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNameFileDownload_Ljava_lang_String_Handler ()
		{
			if (cb_setNameFileDownload_Ljava_lang_String_ == null)
				cb_setNameFileDownload_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetNameFileDownload_Ljava_lang_String_);
			return cb_setNameFileDownload_Ljava_lang_String_;
		}

		static void n_SetNameFileDownload_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Tools.OpenH264DownloadHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNameFileDownload (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.tools']/class[@name='OpenH264DownloadHelper']/method[@name='setNameFileDownload' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setNameFileDownload", "(Ljava/lang/String;)V", "GetSetNameFileDownload_Ljava_lang_String_Handler")]
		public virtual unsafe void SetNameFileDownload (string p0)
		{
			const string __id = "setNameFileDownload.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setUrlDownload_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUrlDownload_Ljava_lang_String_Handler ()
		{
			if (cb_setUrlDownload_Ljava_lang_String_ == null)
				cb_setUrlDownload_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetUrlDownload_Ljava_lang_String_);
			return cb_setUrlDownload_Ljava_lang_String_;
		}

		static void n_SetUrlDownload_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Tools.OpenH264DownloadHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetUrlDownload (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.tools']/class[@name='OpenH264DownloadHelper']/method[@name='setUrlDownload' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUrlDownload", "(Ljava/lang/String;)V", "GetSetUrlDownload_Ljava_lang_String_Handler")]
		public virtual unsafe void SetUrlDownload (string p0)
		{
			const string __id = "setUrlDownload.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setUserData_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetUserData_ILjava_lang_Object_Handler ()
		{
			if (cb_setUserData_ILjava_lang_Object_ == null)
				cb_setUserData_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_SetUserData_ILjava_lang_Object_);
			return cb_setUserData_ILjava_lang_Object_;
		}

		static void n_SetUserData_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Tools.OpenH264DownloadHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetUserData (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.tools']/class[@name='OpenH264DownloadHelper']/method[@name='setUserData' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setUserData", "(ILjava/lang/Object;)V", "GetSetUserData_ILjava_lang_Object_Handler")]
		public virtual unsafe void SetUserData (int p0, global::Java.Lang.Object p1)
		{
			const string __id = "setUserData.(ILjava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_setUserData_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetUserData_Ljava_lang_Object_Handler ()
		{
			if (cb_setUserData_Ljava_lang_Object_ == null)
				cb_setUserData_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_SetUserData_Ljava_lang_Object_);
			return cb_setUserData_Ljava_lang_Object_;
		}

		static int n_SetUserData_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Tools.OpenH264DownloadHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetUserData (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.tools']/class[@name='OpenH264DownloadHelper']/method[@name='setUserData' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("setUserData", "(Ljava/lang/Object;)I", "GetSetUserData_Ljava_lang_Object_Handler")]
		public virtual unsafe int SetUserData (global::Java.Lang.Object p0)
		{
			const string __id = "setUserData.(Ljava/lang/Object;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
