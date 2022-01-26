using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Linphone.Mediastream.Video.Capture.Hwconf {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='Hacks']"
	[global::Android.Runtime.Register ("org/linphone/mediastream/video/capture/hwconf/Hacks", DoNotGenerateAcw=true)]
	public sealed partial class Hacks : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/linphone/mediastream/video/capture/hwconf/Hacks", typeof (Hacks));

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

		internal Hacks (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public static unsafe bool HasBuiltInEchoCanceller {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='Hacks']/method[@name='hasBuiltInEchoCanceller' and count(parameter)=0]"
			[Register ("hasBuiltInEchoCanceller", "()Z", "")]
			get {
				const string __id = "hasBuiltInEchoCanceller.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool HasCamera {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='Hacks']/method[@name='hasCamera' and count(parameter)=0]"
			[Register ("hasCamera", "()Z", "")]
			get {
				const string __id = "hasCamera.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool HasTwoCamerasRear0Front1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='Hacks']/method[@name='hasTwoCamerasRear0Front1' and count(parameter)=0]"
			[Register ("hasTwoCamerasRear0Front1", "()Z", "")]
			get {
				const string __id = "hasTwoCamerasRear0Front1.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsGalaxySOrTab {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='Hacks']/method[@name='isGalaxySOrTab' and count(parameter)=0]"
			[Register ("isGalaxySOrTab", "()Z", "")]
			get {
				const string __id = "isGalaxySOrTab.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsGalaxySOrTabWithFrontCamera {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='Hacks']/method[@name='isGalaxySOrTabWithFrontCamera' and count(parameter)=0]"
			[Register ("isGalaxySOrTabWithFrontCamera", "()Z", "")]
			get {
				const string __id = "isGalaxySOrTabWithFrontCamera.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsGalaxyTab {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='Hacks']/method[@name='isGalaxyTab' and count(parameter)=0]"
			[Register ("isGalaxyTab", "()Z", "")]
			get {
				const string __id = "isGalaxyTab.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='Hacks']/method[@name='needGalaxySAudioHack' and count(parameter)=0]"
		[Register ("needGalaxySAudioHack", "()Z", "")]
		public static unsafe bool NeedGalaxySAudioHack ()
		{
			const string __id = "needGalaxySAudioHack.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='Hacks']/method[@name='needPausingCallForSpeakers' and count(parameter)=0]"
		[Register ("needPausingCallForSpeakers", "()Z", "")]
		public static unsafe bool NeedPausingCallForSpeakers ()
		{
			const string __id = "needPausingCallForSpeakers.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='Hacks']/method[@name='needSoftvolume' and count(parameter)=0]"
		[Register ("needSoftvolume", "()Z", "")]
		public static unsafe bool NeedSoftvolume ()
		{
			const string __id = "needSoftvolume.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video.capture.hwconf']/class[@name='Hacks']/method[@name='sleep' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("sleep", "(I)V", "")]
		public static unsafe void Sleep (int p0)
		{
			const string __id = "sleep.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
