using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Linphone.Mediastream.Video.Capture {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.linphone.mediastream.video.capture']/class[@name='AndroidVideoApi5JniWrapper']"
	[global::Android.Runtime.Register ("org/linphone/mediastream/video/capture/AndroidVideoApi5JniWrapper", DoNotGenerateAcw=true)]
	public partial class AndroidVideoApi5JniWrapper : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='org.linphone.mediastream.video.capture']/class[@name='AndroidVideoApi5JniWrapper']/field[@name='isRecording']"
		[Register ("isRecording")]
		public static bool IsRecording {
			get {
				const string __id = "isRecording.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "isRecording.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/linphone/mediastream/video/capture/AndroidVideoApi5JniWrapper", typeof (AndroidVideoApi5JniWrapper));

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

		protected AndroidVideoApi5JniWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.linphone.mediastream.video.capture']/class[@name='AndroidVideoApi5JniWrapper']/constructor[@name='AndroidVideoApi5JniWrapper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AndroidVideoApi5JniWrapper () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.capture']/class[@name='AndroidVideoApi5JniWrapper']/method[@name='activateAutoFocus' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("activateAutoFocus", "(Ljava/lang/Object;)V", "")]
		public static unsafe void ActivateAutoFocus (global::Java.Lang.Object p0)
		{
			const string __id = "activateAutoFocus.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.capture']/class[@name='AndroidVideoApi5JniWrapper']/method[@name='applyCameraParameters' and count(parameter)=4 and parameter[1][@type='android.hardware.Camera'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("applyCameraParameters", "(Landroid/hardware/Camera;III)V", "")]
		protected static unsafe void ApplyCameraParameters (global::Android.Hardware.Camera p0, int p1, int p2, int p3)
		{
			const string __id = "applyCameraParameters.(Landroid/hardware/Camera;III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.capture']/class[@name='AndroidVideoApi5JniWrapper']/method[@name='detectCameras' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]']]"
		[Register ("detectCameras", "([I[I[I)I", "")]
		public static unsafe int DetectCameras (int[] p0, int[] p1, int[] p2)
		{
			const string __id = "detectCameras.([I[I[I)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.capture']/class[@name='AndroidVideoApi5JniWrapper']/method[@name='putImage' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='byte[]']]"
		[Register ("putImage", "(J[B)V", "")]
		public static unsafe void PutImage (long p0, byte[] p1)
		{
			const string __id = "putImage.(J[B)V";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.capture']/class[@name='AndroidVideoApi5JniWrapper']/method[@name='selectNearestResolutionAvailable' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("selectNearestResolutionAvailable", "(III)[I", "")]
		public static unsafe int[] SelectNearestResolutionAvailable (int p0, int p1, int p2)
		{
			const string __id = "selectNearestResolutionAvailable.(III)[I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.capture']/class[@name='AndroidVideoApi5JniWrapper']/method[@name='selectNearestResolutionAvailableForCamera' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("selectNearestResolutionAvailableForCamera", "(III)[I", "")]
		protected static unsafe int[] SelectNearestResolutionAvailableForCamera (int p0, int p1, int p2)
		{
			const string __id = "selectNearestResolutionAvailableForCamera.(III)[I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.capture']/class[@name='AndroidVideoApi5JniWrapper']/method[@name='setPreviewDisplaySurface' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setPreviewDisplaySurface", "(Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public static unsafe void SetPreviewDisplaySurface (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			const string __id = "setPreviewDisplaySurface.(Ljava/lang/Object;Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.capture']/class[@name='AndroidVideoApi5JniWrapper']/method[@name='startRecording' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='long']]"
		[Register ("startRecording", "(IIIIIJ)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object StartRecording (int p0, int p1, int p2, int p3, int p4, long p5)
		{
			const string __id = "startRecording.(IIIIIJ)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.capture']/class[@name='AndroidVideoApi5JniWrapper']/method[@name='stopRecording' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("stopRecording", "(Ljava/lang/Object;)V", "")]
		public static unsafe void StopRecording (global::Java.Lang.Object p0)
		{
			const string __id = "stopRecording.(Ljava/lang/Object;)V";
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
