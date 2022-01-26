using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Linphone.Core.Tutorials {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.linphone.core.tutorials']/class[@name='TutorialChatRoom']"
	[global::Android.Runtime.Register ("org/linphone/core/tutorials/TutorialChatRoom", DoNotGenerateAcw=true)]
	public partial class TutorialChatRoom : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/linphone/core/tutorials/TutorialChatRoom", typeof (TutorialChatRoom));

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

		protected TutorialChatRoom (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.linphone.core.tutorials']/class[@name='TutorialChatRoom']/constructor[@name='TutorialChatRoom' and count(parameter)=1 and parameter[1][@type='org.linphone.core.tutorials.TutorialNotifier']]"
		[Register (".ctor", "(Lorg/linphone/core/tutorials/TutorialNotifier;)V", "")]
		public unsafe TutorialChatRoom (global::Org.Linphone.Core.Tutorials.TutorialNotifier p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/linphone/core/tutorials/TutorialNotifier;)V";

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.linphone.core.tutorials']/class[@name='TutorialChatRoom']/constructor[@name='TutorialChatRoom' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TutorialChatRoom () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_launchTutorial_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLaunchTutorial_Ljava_lang_String_Handler ()
		{
			if (cb_launchTutorial_Ljava_lang_String_ == null)
				cb_launchTutorial_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_LaunchTutorial_Ljava_lang_String_);
			return cb_launchTutorial_Ljava_lang_String_;
		}

		static void n_LaunchTutorial_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Core.Tutorials.TutorialChatRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LaunchTutorial (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.core.tutorials']/class[@name='TutorialChatRoom']/method[@name='launchTutorial' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("launchTutorial", "(Ljava/lang/String;)V", "GetLaunchTutorial_Ljava_lang_String_Handler")]
		public virtual unsafe void LaunchTutorial (string p0)
		{
			const string __id = "launchTutorial.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.core.tutorials']/class[@name='TutorialChatRoom']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] p0)
		{
			const string __id = "main.([Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_stopMainLoop;
#pragma warning disable 0169
		static Delegate GetStopMainLoopHandler ()
		{
			if (cb_stopMainLoop == null)
				cb_stopMainLoop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopMainLoop);
			return cb_stopMainLoop;
		}

		static void n_StopMainLoop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Core.Tutorials.TutorialChatRoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopMainLoop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.core.tutorials']/class[@name='TutorialChatRoom']/method[@name='stopMainLoop' and count(parameter)=0]"
		[Register ("stopMainLoop", "()V", "GetStopMainLoopHandler")]
		public virtual unsafe void StopMainLoop ()
		{
			const string __id = "stopMainLoop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
