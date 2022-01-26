using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Linphone.Mediastream.Video.Display {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.linphone.mediastream.video.display']/class[@name='OpenGLESDisplay']"
	[global::Android.Runtime.Register ("org/linphone/mediastream/video/display/OpenGLESDisplay", DoNotGenerateAcw=true)]
	public partial class OpenGLESDisplay : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/linphone/mediastream/video/display/OpenGLESDisplay", typeof (OpenGLESDisplay));

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

		protected OpenGLESDisplay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.linphone.mediastream.video.display']/class[@name='OpenGLESDisplay']/constructor[@name='OpenGLESDisplay' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OpenGLESDisplay () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.display']/class[@name='OpenGLESDisplay']/method[@name='init' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("init", "(JII)V", "")]
		public static unsafe void Init (long p0, int p1, int p2)
		{
			const string __id = "init.(JII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.display']/class[@name='OpenGLESDisplay']/method[@name='render' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("render", "(J)V", "")]
		public static unsafe void Render (long p0)
		{
			const string __id = "render.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
