using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Linphone.Mediastream.Video.Capture.Hwconf {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='AndroidCameraConfigurationReader21']"
	[global::Android.Runtime.Register ("org/linphone/mediastream/video/capture/hwconf/AndroidCameraConfigurationReader21", DoNotGenerateAcw=true)]
	public partial class AndroidCameraConfigurationReader21 : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/linphone/mediastream/video/capture/hwconf/AndroidCameraConfigurationReader21", typeof (AndroidCameraConfigurationReader21));

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

		protected AndroidCameraConfigurationReader21 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='AndroidCameraConfigurationReader21']/constructor[@name='AndroidCameraConfigurationReader21' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AndroidCameraConfigurationReader21 () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='AndroidCameraConfigurationReader21']/method[@name='probeCameras' and count(parameter)=0]"
		[Register ("probeCameras", "()[Lorg/linphone/mediastream/video/capture/hwconf/AndroidCameraConfiguration$AndroidCamera;", "")]
		public static unsafe global::Org.Linphone.Mediastream.Video.Capture.Hwconf.AndroidCameraConfiguration.AndroidCamera[] ProbeCameras ()
		{
			const string __id = "probeCameras.()[Lorg/linphone/mediastream/video/capture/hwconf/AndroidCameraConfiguration$AndroidCamera;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Org.Linphone.Mediastream.Video.Capture.Hwconf.AndroidCameraConfiguration.AndroidCamera[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Linphone.Mediastream.Video.Capture.Hwconf.AndroidCameraConfiguration.AndroidCamera));
			} finally {
			}
		}

	}
}
