using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Linphone.Mediastream.Video {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.linphone.mediastream.video']/class[@name='AndroidVideoWindowImpl']"
	[global::Android.Runtime.Register ("org/linphone/mediastream/video/AndroidVideoWindowImpl", DoNotGenerateAcw=true)]
	public partial class AndroidVideoWindowImpl : global::Java.Lang.Object {
		// Metadata.xml XPath interface reference: path="/api/package[@name='org.linphone.mediastream.video']/interface[@name='AndroidVideoWindowImpl.VideoWindowListener']"
		[Register ("org/linphone/mediastream/video/AndroidVideoWindowImpl$VideoWindowListener", "", "Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl/IVideoWindowListenerInvoker")]
		public partial interface IVideoWindowListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video']/interface[@name='AndroidVideoWindowImpl.VideoWindowListener']/method[@name='onVideoPreviewSurfaceDestroyed' and count(parameter)=1 and parameter[1][@type='org.linphone.mediastream.video.AndroidVideoWindowImpl']]"
			[Register ("onVideoPreviewSurfaceDestroyed", "(Lorg/linphone/mediastream/video/AndroidVideoWindowImpl;)V", "GetOnVideoPreviewSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Handler:Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl/IVideoWindowListenerInvoker, Liblinphone")]
			void OnVideoPreviewSurfaceDestroyed (global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video']/interface[@name='AndroidVideoWindowImpl.VideoWindowListener']/method[@name='onVideoPreviewSurfaceReady' and count(parameter)=2 and parameter[1][@type='org.linphone.mediastream.video.AndroidVideoWindowImpl'] and parameter[2][@type='android.view.SurfaceView']]"
			[Register ("onVideoPreviewSurfaceReady", "(Lorg/linphone/mediastream/video/AndroidVideoWindowImpl;Landroid/view/SurfaceView;)V", "GetOnVideoPreviewSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_Handler:Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl/IVideoWindowListenerInvoker, Liblinphone")]
			void OnVideoPreviewSurfaceReady (global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl p0, global::Android.Views.SurfaceView p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video']/interface[@name='AndroidVideoWindowImpl.VideoWindowListener']/method[@name='onVideoRenderingSurfaceDestroyed' and count(parameter)=1 and parameter[1][@type='org.linphone.mediastream.video.AndroidVideoWindowImpl']]"
			[Register ("onVideoRenderingSurfaceDestroyed", "(Lorg/linphone/mediastream/video/AndroidVideoWindowImpl;)V", "GetOnVideoRenderingSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Handler:Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl/IVideoWindowListenerInvoker, Liblinphone")]
			void OnVideoRenderingSurfaceDestroyed (global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video']/interface[@name='AndroidVideoWindowImpl.VideoWindowListener']/method[@name='onVideoRenderingSurfaceReady' and count(parameter)=2 and parameter[1][@type='org.linphone.mediastream.video.AndroidVideoWindowImpl'] and parameter[2][@type='android.view.SurfaceView']]"
			[Register ("onVideoRenderingSurfaceReady", "(Lorg/linphone/mediastream/video/AndroidVideoWindowImpl;Landroid/view/SurfaceView;)V", "GetOnVideoRenderingSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_Handler:Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl/IVideoWindowListenerInvoker, Liblinphone")]
			void OnVideoRenderingSurfaceReady (global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl p0, global::Android.Views.SurfaceView p1);

		}

		[global::Android.Runtime.Register ("org/linphone/mediastream/video/AndroidVideoWindowImpl$VideoWindowListener", DoNotGenerateAcw=true)]
		internal partial class IVideoWindowListenerInvoker : global::Java.Lang.Object, IVideoWindowListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/linphone/mediastream/video/AndroidVideoWindowImpl$VideoWindowListener", typeof (IVideoWindowListenerInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IVideoWindowListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IVideoWindowListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "org.linphone.mediastream.video.AndroidVideoWindowImpl.VideoWindowListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IVideoWindowListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onVideoPreviewSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_;
#pragma warning disable 0169
			static Delegate GetOnVideoPreviewSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Handler ()
			{
				if (cb_onVideoPreviewSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_ == null)
					cb_onVideoPreviewSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnVideoPreviewSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_);
				return cb_onVideoPreviewSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_;
			}

			static void n_OnVideoPreviewSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl.IVideoWindowListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnVideoPreviewSurfaceDestroyed (p0);
			}
#pragma warning restore 0169

			IntPtr id_onVideoPreviewSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_;
			public unsafe void OnVideoPreviewSurfaceDestroyed (global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl p0)
			{
				if (id_onVideoPreviewSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_ == IntPtr.Zero)
					id_onVideoPreviewSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_ = JNIEnv.GetMethodID (class_ref, "onVideoPreviewSurfaceDestroyed", "(Lorg/linphone/mediastream/video/AndroidVideoWindowImpl;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVideoPreviewSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_, __args);
			}

			static Delegate cb_onVideoPreviewSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_;
#pragma warning disable 0169
			static Delegate GetOnVideoPreviewSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_Handler ()
			{
				if (cb_onVideoPreviewSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_ == null)
					cb_onVideoPreviewSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnVideoPreviewSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_);
				return cb_onVideoPreviewSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_;
			}

			static void n_OnVideoPreviewSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl.IVideoWindowListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Android.Views.SurfaceView> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnVideoPreviewSurfaceReady (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onVideoPreviewSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_;
			public unsafe void OnVideoPreviewSurfaceReady (global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl p0, global::Android.Views.SurfaceView p1)
			{
				if (id_onVideoPreviewSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_ == IntPtr.Zero)
					id_onVideoPreviewSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_ = JNIEnv.GetMethodID (class_ref, "onVideoPreviewSurfaceReady", "(Lorg/linphone/mediastream/video/AndroidVideoWindowImpl;Landroid/view/SurfaceView;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVideoPreviewSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_, __args);
			}

			static Delegate cb_onVideoRenderingSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_;
#pragma warning disable 0169
			static Delegate GetOnVideoRenderingSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Handler ()
			{
				if (cb_onVideoRenderingSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_ == null)
					cb_onVideoRenderingSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnVideoRenderingSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_);
				return cb_onVideoRenderingSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_;
			}

			static void n_OnVideoRenderingSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl.IVideoWindowListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnVideoRenderingSurfaceDestroyed (p0);
			}
#pragma warning restore 0169

			IntPtr id_onVideoRenderingSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_;
			public unsafe void OnVideoRenderingSurfaceDestroyed (global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl p0)
			{
				if (id_onVideoRenderingSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_ == IntPtr.Zero)
					id_onVideoRenderingSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_ = JNIEnv.GetMethodID (class_ref, "onVideoRenderingSurfaceDestroyed", "(Lorg/linphone/mediastream/video/AndroidVideoWindowImpl;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVideoRenderingSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_, __args);
			}

			static Delegate cb_onVideoRenderingSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_;
#pragma warning disable 0169
			static Delegate GetOnVideoRenderingSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_Handler ()
			{
				if (cb_onVideoRenderingSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_ == null)
					cb_onVideoRenderingSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnVideoRenderingSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_);
				return cb_onVideoRenderingSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_;
			}

			static void n_OnVideoRenderingSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl.IVideoWindowListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Android.Views.SurfaceView> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnVideoRenderingSurfaceReady (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onVideoRenderingSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_;
			public unsafe void OnVideoRenderingSurfaceReady (global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl p0, global::Android.Views.SurfaceView p1)
			{
				if (id_onVideoRenderingSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_ == IntPtr.Zero)
					id_onVideoRenderingSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_ = JNIEnv.GetMethodID (class_ref, "onVideoRenderingSurfaceReady", "(Lorg/linphone/mediastream/video/AndroidVideoWindowImpl;Landroid/view/SurfaceView;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVideoRenderingSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_, __args);
			}

		}

		// event args for org.linphone.mediastream.video.AndroidVideoWindowImpl.VideoWindowListener.onVideoPreviewSurfaceDestroyed
		public partial class VideoPreviewSurfaceDestroyedEventArgs : global::System.EventArgs {
			public VideoPreviewSurfaceDestroyedEventArgs (global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl p0)
			{
				this.p0 = p0;
			}

			global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl p0;

			public global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl P0 {
				get { return p0; }
			}

		}

		// event args for org.linphone.mediastream.video.AndroidVideoWindowImpl.VideoWindowListener.onVideoPreviewSurfaceReady
		public partial class VideoPreviewSurfaceReadyEventArgs : global::System.EventArgs {
			public VideoPreviewSurfaceReadyEventArgs (global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl p0, global::Android.Views.SurfaceView p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl p0;

			public global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl P0 {
				get { return p0; }
			}

			global::Android.Views.SurfaceView p1;

			public global::Android.Views.SurfaceView P1 {
				get { return p1; }
			}

		}

		// event args for org.linphone.mediastream.video.AndroidVideoWindowImpl.VideoWindowListener.onVideoRenderingSurfaceDestroyed
		public partial class VideoRenderingSurfaceDestroyedEventArgs : global::System.EventArgs {
			public VideoRenderingSurfaceDestroyedEventArgs (global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl p0)
			{
				this.p0 = p0;
			}

			global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl p0;

			public global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl P0 {
				get { return p0; }
			}

		}

		// event args for org.linphone.mediastream.video.AndroidVideoWindowImpl.VideoWindowListener.onVideoRenderingSurfaceReady
		public partial class VideoRenderingSurfaceReadyEventArgs : global::System.EventArgs {
			public VideoRenderingSurfaceReadyEventArgs (global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl p0, global::Android.Views.SurfaceView p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl p0;

			public global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl P0 {
				get { return p0; }
			}

			global::Android.Views.SurfaceView p1;

			public global::Android.Views.SurfaceView P1 {
				get { return p1; }
			}

		}

		[global::Android.Runtime.Register ("mono/org/linphone/mediastream/video/AndroidVideoWindowImpl_VideoWindowListenerImplementor")]
		internal sealed partial class IVideoWindowListenerImplementor : global::Java.Lang.Object, IVideoWindowListener {

			object sender;

			public IVideoWindowListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/linphone/mediastream/video/AndroidVideoWindowImpl_VideoWindowListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

			#pragma warning disable 0649
			public EventHandler<VideoPreviewSurfaceDestroyedEventArgs> OnVideoPreviewSurfaceDestroyedHandler;
			#pragma warning restore 0649

			public void OnVideoPreviewSurfaceDestroyed (global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl p0)
			{
				var __h = OnVideoPreviewSurfaceDestroyedHandler;
				if (__h != null)
					__h (sender, new VideoPreviewSurfaceDestroyedEventArgs (p0));
			}

			#pragma warning disable 0649
			public EventHandler<VideoPreviewSurfaceReadyEventArgs> OnVideoPreviewSurfaceReadyHandler;
			#pragma warning restore 0649

			public void OnVideoPreviewSurfaceReady (global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl p0, global::Android.Views.SurfaceView p1)
			{
				var __h = OnVideoPreviewSurfaceReadyHandler;
				if (__h != null)
					__h (sender, new VideoPreviewSurfaceReadyEventArgs (p0, p1));
			}

			#pragma warning disable 0649
			public EventHandler<VideoRenderingSurfaceDestroyedEventArgs> OnVideoRenderingSurfaceDestroyedHandler;
			#pragma warning restore 0649

			public void OnVideoRenderingSurfaceDestroyed (global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl p0)
			{
				var __h = OnVideoRenderingSurfaceDestroyedHandler;
				if (__h != null)
					__h (sender, new VideoRenderingSurfaceDestroyedEventArgs (p0));
			}

			#pragma warning disable 0649
			public EventHandler<VideoRenderingSurfaceReadyEventArgs> OnVideoRenderingSurfaceReadyHandler;
			#pragma warning restore 0649

			public void OnVideoRenderingSurfaceReady (global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl p0, global::Android.Views.SurfaceView p1)
			{
				var __h = OnVideoRenderingSurfaceReadyHandler;
				if (__h != null)
					__h (sender, new VideoRenderingSurfaceReadyEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IVideoWindowListenerImplementor value)
			{
				return value.OnVideoPreviewSurfaceDestroyedHandler == null && value.OnVideoPreviewSurfaceReadyHandler == null && value.OnVideoRenderingSurfaceDestroyedHandler == null && value.OnVideoRenderingSurfaceReadyHandler == null;
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/linphone/mediastream/video/AndroidVideoWindowImpl", typeof (AndroidVideoWindowImpl));

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

		protected AndroidVideoWindowImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.linphone.mediastream.video']/class[@name='AndroidVideoWindowImpl']/constructor[@name='AndroidVideoWindowImpl' and count(parameter)=3 and parameter[1][@type='android.view.SurfaceView'] and parameter[2][@type='android.view.SurfaceView'] and parameter[3][@type='org.linphone.mediastream.video.AndroidVideoWindowImpl.VideoWindowListener']]"
		[Register (".ctor", "(Landroid/view/SurfaceView;Landroid/view/SurfaceView;Lorg/linphone/mediastream/video/AndroidVideoWindowImpl$VideoWindowListener;)V", "")]
		public unsafe AndroidVideoWindowImpl (global::Android.Views.SurfaceView p0, global::Android.Views.SurfaceView p1, global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl.IVideoWindowListener p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/view/SurfaceView;Landroid/view/SurfaceView;Lorg/linphone/mediastream/video/AndroidVideoWindowImpl$VideoWindowListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.linphone.mediastream.video']/class[@name='AndroidVideoWindowImpl']/constructor[@name='AndroidVideoWindowImpl' and count(parameter)=2 and parameter[1][@type='android.view.SurfaceView'] and parameter[2][@type='android.view.SurfaceView']]"
		[Register (".ctor", "(Landroid/view/SurfaceView;Landroid/view/SurfaceView;)V", "")]
		public unsafe AndroidVideoWindowImpl (global::Android.Views.SurfaceView p0, global::Android.Views.SurfaceView p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/view/SurfaceView;Landroid/view/SurfaceView;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_getBitmap;
#pragma warning disable 0169
		static Delegate GetGetBitmapHandler ()
		{
			if (cb_getBitmap == null)
				cb_getBitmap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBitmap);
			return cb_getBitmap;
		}

		static IntPtr n_GetBitmap (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Bitmap);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Bitmap Bitmap {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video']/class[@name='AndroidVideoWindowImpl']/method[@name='getBitmap' and count(parameter)=0]"
			[Register ("getBitmap", "()Landroid/graphics/Bitmap;", "GetGetBitmapHandler")]
			get {
				const string __id = "getBitmap.()Landroid/graphics/Bitmap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSurface;
#pragma warning disable 0169
		static Delegate GetGetSurfaceHandler ()
		{
			if (cb_getSurface == null)
				cb_getSurface = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSurface);
			return cb_getSurface;
		}

		static IntPtr n_GetSurface (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Surface);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.Surface Surface {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video']/class[@name='AndroidVideoWindowImpl']/method[@name='getSurface' and count(parameter)=0]"
			[Register ("getSurface", "()Landroid/view/Surface;", "GetGetSurfaceHandler")]
			get {
				const string __id = "getSurface.()Landroid/view/Surface;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.Surface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video']/class[@name='AndroidVideoWindowImpl']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		public virtual unsafe void Init ()
		{
			const string __id = "init.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video']/class[@name='AndroidVideoWindowImpl']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_requestRender;
#pragma warning disable 0169
		static Delegate GetRequestRenderHandler ()
		{
			if (cb_requestRender == null)
				cb_requestRender = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_RequestRender);
			return cb_requestRender;
		}

		static void n_RequestRender (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestRender ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video']/class[@name='AndroidVideoWindowImpl']/method[@name='requestRender' and count(parameter)=0]"
		[Register ("requestRender", "()V", "GetRequestRenderHandler")]
		public virtual unsafe void RequestRender ()
		{
			const string __id = "requestRender.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video']/class[@name='AndroidVideoWindowImpl']/method[@name='rotationToAngle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("rotationToAngle", "(I)I", "")]
		public static unsafe int RotationToAngle (int p0)
		{
			const string __id = "rotationToAngle.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setListener_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_VideoWindowListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_VideoWindowListener_Handler ()
		{
			if (cb_setListener_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_VideoWindowListener_ == null)
				cb_setListener_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_VideoWindowListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetListener_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_VideoWindowListener_);
			return cb_setListener_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_VideoWindowListener_;
		}

		static void n_SetListener_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_VideoWindowListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl.IVideoWindowListener)global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl.IVideoWindowListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video']/class[@name='AndroidVideoWindowImpl']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='org.linphone.mediastream.video.AndroidVideoWindowImpl.VideoWindowListener']]"
		[Register ("setListener", "(Lorg/linphone/mediastream/video/AndroidVideoWindowImpl$VideoWindowListener;)V", "GetSetListener_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_VideoWindowListener_Handler")]
		public virtual unsafe void SetListener (global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl.IVideoWindowListener p0)
		{
			const string __id = "setListener.(Lorg/linphone/mediastream/video/AndroidVideoWindowImpl$VideoWindowListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_setOpenGLESDisplay_J;
#pragma warning disable 0169
		static Delegate GetSetOpenGLESDisplay_JHandler ()
		{
			if (cb_setOpenGLESDisplay_J == null)
				cb_setOpenGLESDisplay_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetOpenGLESDisplay_J);
			return cb_setOpenGLESDisplay_J;
		}

		static void n_SetOpenGLESDisplay_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOpenGLESDisplay (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video']/class[@name='AndroidVideoWindowImpl']/method[@name='setOpenGLESDisplay' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setOpenGLESDisplay", "(J)V", "GetSetOpenGLESDisplay_JHandler")]
		public virtual unsafe void SetOpenGLESDisplay (long p0)
		{
			const string __id = "setOpenGLESDisplay.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_update;
#pragma warning disable 0169
		static Delegate GetUpdateHandler ()
		{
			if (cb_update == null)
				cb_update = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Update);
			return cb_update;
		}

		static void n_Update (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Update ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.mediastream.video']/class[@name='AndroidVideoWindowImpl']/method[@name='update' and count(parameter)=0]"
		[Register ("update", "()V", "GetUpdateHandler")]
		public virtual unsafe void Update ()
		{
			const string __id = "update.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		#region "Event implementation for Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl.IVideoWindowListener"

		global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl.IVideoWindowListenerImplementor __CreateIVideoWindowListenerImplementor ()
		{
			return new global::Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl.IVideoWindowListenerImplementor (this);
		}

		#endregion

	}
}
