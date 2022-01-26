using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Linphone.Tools {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.linphone.tools']/class[@name='Lpc2Xml']"
	[global::Android.Runtime.Register ("org/linphone/tools/Lpc2Xml", DoNotGenerateAcw=true)]
	public partial class Lpc2Xml : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/linphone/tools/Lpc2Xml", typeof (Lpc2Xml));

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

		protected Lpc2Xml (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.linphone.tools']/class[@name='Lpc2Xml']/constructor[@name='Lpc2Xml' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Lpc2Xml () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_convertFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetConvertFile_Ljava_lang_String_Handler ()
		{
			if (cb_convertFile_Ljava_lang_String_ == null)
				cb_convertFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_ConvertFile_Ljava_lang_String_);
			return cb_convertFile_Ljava_lang_String_;
		}

		static int n_ConvertFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Tools.Lpc2Xml> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ConvertFile (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.tools']/class[@name='Lpc2Xml']/method[@name='convertFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("convertFile", "(Ljava/lang/String;)I", "GetConvertFile_Ljava_lang_String_Handler")]
		public virtual unsafe int ConvertFile (string p0)
		{
			const string __id = "convertFile.(Ljava/lang/String;)I";
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

		static Delegate cb_convertString_Ljava_lang_StringBuffer_;
#pragma warning disable 0169
		static Delegate GetConvertString_Ljava_lang_StringBuffer_Handler ()
		{
			if (cb_convertString_Ljava_lang_StringBuffer_ == null)
				cb_convertString_Ljava_lang_StringBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_ConvertString_Ljava_lang_StringBuffer_);
			return cb_convertString_Ljava_lang_StringBuffer_;
		}

		static int n_ConvertString_Ljava_lang_StringBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Tools.Lpc2Xml> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ConvertString (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.tools']/class[@name='Lpc2Xml']/method[@name='convertString' and count(parameter)=1 and parameter[1][@type='java.lang.StringBuffer']]"
		[Register ("convertString", "(Ljava/lang/StringBuffer;)I", "GetConvertString_Ljava_lang_StringBuffer_Handler")]
		public virtual unsafe int ConvertString (global::Java.Lang.StringBuffer p0)
		{
			const string __id = "convertString.(Ljava/lang/StringBuffer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Tools.Lpc2Xml> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finalize ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.tools']/class[@name='Lpc2Xml']/method[@name='finalize' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Tools.Lpc2Xml> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PrintLog (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.tools']/class[@name='Lpc2Xml']/method[@name='printLog' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
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

	}
}
