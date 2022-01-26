using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Linphone.Mediastream {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.linphone.mediastream']/class[@name='AACFilter']"
	[global::Android.Runtime.Register ("org/linphone/mediastream/AACFilter", DoNotGenerateAcw=true)]
	public partial class AACFilter : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/linphone/mediastream/AACFilter", typeof (AACFilter));

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

		protected AACFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.linphone.mediastream']/class[@name='AACFilter']/constructor[@name='AACFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AACFilter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream']/class[@name='AACFilter']/method[@name='instance' and count(parameter)=0]"
		[Register ("instance", "()Lorg/linphone/mediastream/AACFilter;", "")]
		public static unsafe global::Org.Linphone.Mediastream.AACFilter Instance ()
		{
			const string __id = "instance.()Lorg/linphone/mediastream/AACFilter;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.AACFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_postprocess;
#pragma warning disable 0169
		static Delegate GetPostprocessHandler ()
		{
			if (cb_postprocess == null)
				cb_postprocess = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Postprocess);
			return cb_postprocess;
		}

		static bool n_Postprocess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.AACFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Postprocess ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream']/class[@name='AACFilter']/method[@name='postprocess' and count(parameter)=0]"
		[Register ("postprocess", "()Z", "GetPostprocessHandler")]
		public virtual unsafe bool Postprocess ()
		{
			const string __id = "postprocess.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_preprocess_IIIZ;
#pragma warning disable 0169
		static Delegate GetPreprocess_IIIZHandler ()
		{
			if (cb_preprocess_IIIZ == null)
				cb_preprocess_IIIZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIZ_Z) n_Preprocess_IIIZ);
			return cb_preprocess_IIIZ;
		}

		static bool n_Preprocess_IIIZ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, bool p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.AACFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Preprocess (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream']/class[@name='AACFilter']/method[@name='preprocess' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("preprocess", "(IIIZ)Z", "GetPreprocess_IIIZHandler")]
		public virtual unsafe bool Preprocess (int p0, int p1, int p2, bool p3)
		{
			const string __id = "preprocess.(IIIZ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_pullFromDecoder_arrayB;
#pragma warning disable 0169
		static Delegate GetPullFromDecoder_arrayBHandler ()
		{
			if (cb_pullFromDecoder_arrayB == null)
				cb_pullFromDecoder_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_PullFromDecoder_arrayB);
			return cb_pullFromDecoder_arrayB;
		}

		static int n_PullFromDecoder_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.AACFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PullFromDecoder (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream']/class[@name='AACFilter']/method[@name='pullFromDecoder' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("pullFromDecoder", "([B)I", "GetPullFromDecoder_arrayBHandler")]
		public virtual unsafe int PullFromDecoder (byte[] p0)
		{
			const string __id = "pullFromDecoder.([B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_pullFromEncoder_arrayB;
#pragma warning disable 0169
		static Delegate GetPullFromEncoder_arrayBHandler ()
		{
			if (cb_pullFromEncoder_arrayB == null)
				cb_pullFromEncoder_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_PullFromEncoder_arrayB);
			return cb_pullFromEncoder_arrayB;
		}

		static int n_PullFromEncoder_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.AACFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PullFromEncoder (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream']/class[@name='AACFilter']/method[@name='pullFromEncoder' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("pullFromEncoder", "([B)I", "GetPullFromEncoder_arrayBHandler")]
		public virtual unsafe int PullFromEncoder (byte[] p0)
		{
			const string __id = "pullFromEncoder.([B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_pushToDecoder_arrayBI;
#pragma warning disable 0169
		static Delegate GetPushToDecoder_arrayBIHandler ()
		{
			if (cb_pushToDecoder_arrayBI == null)
				cb_pushToDecoder_arrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_Z) n_PushToDecoder_arrayBI);
			return cb_pushToDecoder_arrayBI;
		}

		static bool n_PushToDecoder_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.AACFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.PushToDecoder (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream']/class[@name='AACFilter']/method[@name='pushToDecoder' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("pushToDecoder", "([BI)Z", "GetPushToDecoder_arrayBIHandler")]
		public virtual unsafe bool PushToDecoder (byte[] p0, int p1)
		{
			const string __id = "pushToDecoder.([BI)Z";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_pushToEncoder_arrayBI;
#pragma warning disable 0169
		static Delegate GetPushToEncoder_arrayBIHandler ()
		{
			if (cb_pushToEncoder_arrayBI == null)
				cb_pushToEncoder_arrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_Z) n_PushToEncoder_arrayBI);
			return cb_pushToEncoder_arrayBI;
		}

		static bool n_PushToEncoder_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.AACFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.PushToEncoder (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream']/class[@name='AACFilter']/method[@name='pushToEncoder' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("pushToEncoder", "([BI)Z", "GetPushToEncoder_arrayBIHandler")]
		public virtual unsafe bool PushToEncoder (byte[] p0, int p1)
		{
			const string __id = "pushToEncoder.([BI)Z";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
