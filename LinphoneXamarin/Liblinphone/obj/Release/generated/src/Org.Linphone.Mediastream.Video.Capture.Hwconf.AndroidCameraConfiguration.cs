using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Linphone.Mediastream.Video.Capture.Hwconf {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='AndroidCameraConfiguration']"
	[global::Android.Runtime.Register ("org/linphone/mediastream/video/capture/hwconf/AndroidCameraConfiguration", DoNotGenerateAcw=true)]
	public partial class AndroidCameraConfiguration : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='AndroidCameraConfiguration.AndroidCamera']"
		[global::Android.Runtime.Register ("org/linphone/mediastream/video/capture/hwconf/AndroidCameraConfiguration$AndroidCamera", DoNotGenerateAcw=true)]
		public partial class AndroidCamera : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='AndroidCameraConfiguration.AndroidCamera']/field[@name='frontFacing']"
			[Register ("frontFacing")]
			public bool FrontFacing {
				get {
					const string __id = "frontFacing.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "frontFacing.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='AndroidCameraConfiguration.AndroidCamera']/field[@name='id']"
			[Register ("id")]
			public int Id {
				get {
					const string __id = "id.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "id.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='AndroidCameraConfiguration.AndroidCamera']/field[@name='orientation']"
			[Register ("orientation")]
			public int Orientation {
				get {
					const string __id = "orientation.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "orientation.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='AndroidCameraConfiguration.AndroidCamera']/field[@name='resolutions']"
			[Register ("resolutions")]
			public global::System.Collections.IList Resolutions {
				get {
					const string __id = "resolutions.Ljava/util/List;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "resolutions.Ljava/util/List;";

					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='AndroidCameraConfiguration.AndroidCamera.Size']"
			[global::Android.Runtime.Register ("org/linphone/mediastream/video/capture/hwconf/AndroidCameraConfiguration$AndroidCamera$Size", DoNotGenerateAcw=true)]
			public partial class Size : global::Java.Lang.Object {

				// Metadata.xml XPath field reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='AndroidCameraConfiguration.AndroidCamera.Size']/field[@name='height']"
				[Register ("height")]
				public int Height {
					get {
						const string __id = "height.I";

						var __v = _members.InstanceFields.GetInt32Value (__id, this);
						return __v;
					}
					set {
						const string __id = "height.I";

						try {
							_members.InstanceFields.SetValue (__id, this, value);
						} finally {
						}
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='AndroidCameraConfiguration.AndroidCamera.Size']/field[@name='width']"
				[Register ("width")]
				public int Width {
					get {
						const string __id = "width.I";

						var __v = _members.InstanceFields.GetInt32Value (__id, this);
						return __v;
					}
					set {
						const string __id = "width.I";

						try {
							_members.InstanceFields.SetValue (__id, this, value);
						} finally {
						}
					}
				}

				static readonly JniPeerMembers _members = new XAPeerMembers ("org/linphone/mediastream/video/capture/hwconf/AndroidCameraConfiguration$AndroidCamera$Size", typeof (Size));

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

				protected Size (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
				{
				}

				// Metadata.xml XPath constructor reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='AndroidCameraConfiguration.AndroidCamera.Size']/constructor[@name='AndroidCameraConfiguration.AndroidCamera.Size' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
				[Register (".ctor", "(II)V", "")]
				public unsafe Size (int p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					const string __id = "(II)V";

					if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
						return;

					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [2];
						__args [0] = new JniArgumentValue (p0);
						__args [1] = new JniArgumentValue (p1);
						var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
						SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
						_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
					} finally {
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/linphone/mediastream/video/capture/hwconf/AndroidCameraConfiguration$AndroidCamera", typeof (AndroidCamera));

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

			protected AndroidCamera (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='AndroidCameraConfiguration.AndroidCamera']/constructor[@name='AndroidCameraConfiguration.AndroidCamera' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='java.util.List&lt;org.linphone.mediastream.video.capture.hwconf.AndroidCameraConfiguration.AndroidCamera.Size&gt;'] and parameter[4][@type='int']]"
			[Register (".ctor", "(IZLjava/util/List;I)V", "")]
			public unsafe AndroidCamera (int p0, bool p1, global::System.Collections.Generic.IList<global::Org.Linphone.Mediastream.Video.Capture.Hwconf.AndroidCameraConfiguration.AndroidCamera.Size> p2, int p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(IZLjava/util/List;I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p2 = global::Android.Runtime.JavaList<global::Org.Linphone.Mediastream.Video.Capture.Hwconf.AndroidCameraConfiguration.AndroidCamera.Size>.ToLocalJniHandle (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (p3);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p2);
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='AndroidCameraConfiguration.AndroidCamera']/constructor[@name='AndroidCameraConfiguration.AndroidCamera' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='java.util.List&lt;android.hardware.Camera.Size&gt;']]"
			[Register (".ctor", "(IZILjava/util/List;)V", "")]
			public unsafe AndroidCamera (int p0, bool p1, int p2, global::System.Collections.Generic.IList<global::Android.Hardware.Camera.Size> p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(IZILjava/util/List;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p3 = global::Android.Runtime.JavaList<global::Android.Hardware.Camera.Size>.ToLocalJniHandle (p3);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (native_p3);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p3);
					global::System.GC.KeepAlive (p3);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/linphone/mediastream/video/capture/hwconf/AndroidCameraConfiguration", typeof (AndroidCameraConfiguration));

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

		protected AndroidCameraConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='AndroidCameraConfiguration']/constructor[@name='AndroidCameraConfiguration' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AndroidCameraConfiguration () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe bool HasFrontCamera {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='AndroidCameraConfiguration']/method[@name='hasFrontCamera' and count(parameter)=0]"
			[Register ("hasFrontCamera", "()Z", "")]
			get {
				const string __id = "hasFrontCamera.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool HasSeveralCameras {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='AndroidCameraConfiguration']/method[@name='hasSeveralCameras' and count(parameter)=0]"
			[Register ("hasSeveralCameras", "()Z", "")]
			get {
				const string __id = "hasSeveralCameras.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='AndroidCameraConfiguration']/method[@name='retrieveCameras' and count(parameter)=0]"
		[Register ("retrieveCameras", "()[Lorg/linphone/mediastream/video/capture/hwconf/AndroidCameraConfiguration$AndroidCamera;", "")]
		public static unsafe global::Org.Linphone.Mediastream.Video.Capture.Hwconf.AndroidCameraConfiguration.AndroidCamera[] RetrieveCameras ()
		{
			const string __id = "retrieveCameras.()[Lorg/linphone/mediastream/video/capture/hwconf/AndroidCameraConfiguration$AndroidCamera;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Org.Linphone.Mediastream.Video.Capture.Hwconf.AndroidCameraConfiguration.AndroidCamera[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Linphone.Mediastream.Video.Capture.Hwconf.AndroidCameraConfiguration.AndroidCamera));
			} finally {
			}
		}

	}
}
