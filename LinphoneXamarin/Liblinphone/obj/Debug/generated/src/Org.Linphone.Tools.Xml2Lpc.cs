using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Linphone.Tools {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.linphone.tools']/class[@name='Xml2Lpc']"
	[global::Android.Runtime.Register ("org/linphone/tools/Xml2Lpc", DoNotGenerateAcw=true)]
	public partial class Xml2Lpc : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/linphone/tools/Xml2Lpc", typeof (Xml2Lpc));

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

		protected Xml2Lpc (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.linphone.tools']/class[@name='Xml2Lpc']/constructor[@name='Xml2Lpc' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Xml2Lpc () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe bool IsAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.tools']/class[@name='Xml2Lpc']/method[@name='isAvailable' and count(parameter)=0]"
			[Register ("isAvailable", "()Z", "")]
			get {
				const string __id = "isAvailable.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_finalize;
#pragma warning disable 0169
		static Delegate GetFinalizeHandler ()
		{
			if (cb_finalize == null)
				cb_finalize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Finalize);
			return cb_finalize;
		}

		static void n_Finalize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Tools.Xml2Lpc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finalize ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.tools']/class[@name='Xml2Lpc']/method[@name='finalize' and count(parameter)=0]"
		[Register ("finalize", "()V", "GetFinalizeHandler")]
		public virtual unsafe void Finalize ()
		{
			const string __id = "finalize.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_printLog_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPrintLog_ILjava_lang_String_Handler ()
		{
			if (cb_printLog_ILjava_lang_String_ == null)
				cb_printLog_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_PrintLog_ILjava_lang_String_);
			return cb_printLog_ILjava_lang_String_;
		}

		static void n_PrintLog_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Tools.Xml2Lpc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PrintLog (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.tools']/class[@name='Xml2Lpc']/method[@name='printLog' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("printLog", "(ILjava/lang/String;)V", "GetPrintLog_ILjava_lang_String_Handler")]
		public virtual unsafe void PrintLog (int p0, string p1)
		{
			const string __id = "printLog.(ILjava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setXmlFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetXmlFile_Ljava_lang_String_Handler ()
		{
			if (cb_setXmlFile_Ljava_lang_String_ == null)
				cb_setXmlFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_SetXmlFile_Ljava_lang_String_);
			return cb_setXmlFile_Ljava_lang_String_;
		}

		static int n_SetXmlFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Tools.Xml2Lpc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetXmlFile (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.tools']/class[@name='Xml2Lpc']/method[@name='setXmlFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setXmlFile", "(Ljava/lang/String;)I", "GetSetXmlFile_Ljava_lang_String_Handler")]
		public virtual unsafe int SetXmlFile (string p0)
		{
			const string __id = "setXmlFile.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setXmlString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetXmlString_Ljava_lang_String_Handler ()
		{
			if (cb_setXmlString_Ljava_lang_String_ == null)
				cb_setXmlString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_SetXmlString_Ljava_lang_String_);
			return cb_setXmlString_Ljava_lang_String_;
		}

		static int n_SetXmlString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Tools.Xml2Lpc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetXmlString (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.tools']/class[@name='Xml2Lpc']/method[@name='setXmlString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setXmlString", "(Ljava/lang/String;)I", "GetSetXmlString_Ljava_lang_String_Handler")]
		public virtual unsafe int SetXmlString (string p0)
		{
			const string __id = "setXmlString.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setXsdFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetXsdFile_Ljava_lang_String_Handler ()
		{
			if (cb_setXsdFile_Ljava_lang_String_ == null)
				cb_setXsdFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_SetXsdFile_Ljava_lang_String_);
			return cb_setXsdFile_Ljava_lang_String_;
		}

		static int n_SetXsdFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Tools.Xml2Lpc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetXsdFile (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.tools']/class[@name='Xml2Lpc']/method[@name='setXsdFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setXsdFile", "(Ljava/lang/String;)I", "GetSetXsdFile_Ljava_lang_String_Handler")]
		public virtual unsafe int SetXsdFile (string p0)
		{
			const string __id = "setXsdFile.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setXsdString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetXsdString_Ljava_lang_String_Handler ()
		{
			if (cb_setXsdString_Ljava_lang_String_ == null)
				cb_setXsdString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_SetXsdString_Ljava_lang_String_);
			return cb_setXsdString_Ljava_lang_String_;
		}

		static int n_SetXsdString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Tools.Xml2Lpc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetXsdString (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.tools']/class[@name='Xml2Lpc']/method[@name='setXsdString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setXsdString", "(Ljava/lang/String;)I", "GetSetXsdString_Ljava_lang_String_Handler")]
		public virtual unsafe int SetXsdString (string p0)
		{
			const string __id = "setXsdString.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_validate;
#pragma warning disable 0169
		static Delegate GetValidateHandler ()
		{
			if (cb_validate == null)
				cb_validate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Validate);
			return cb_validate;
		}

		static int n_Validate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Tools.Xml2Lpc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Validate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.tools']/class[@name='Xml2Lpc']/method[@name='validate' and count(parameter)=0]"
		[Register ("validate", "()I", "GetValidateHandler")]
		public virtual unsafe int Validate ()
		{
			const string __id = "validate.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
