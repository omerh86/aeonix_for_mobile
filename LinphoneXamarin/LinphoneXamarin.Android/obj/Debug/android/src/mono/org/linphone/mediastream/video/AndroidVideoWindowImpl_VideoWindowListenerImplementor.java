package mono.org.linphone.mediastream.video;


public class AndroidVideoWindowImpl_VideoWindowListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		org.linphone.mediastream.video.AndroidVideoWindowImpl.VideoWindowListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onVideoPreviewSurfaceDestroyed:(Lorg/linphone/mediastream/video/AndroidVideoWindowImpl;)V:GetOnVideoPreviewSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Handler:Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl/IVideoWindowListenerInvoker, Liblinphone\n" +
			"n_onVideoPreviewSurfaceReady:(Lorg/linphone/mediastream/video/AndroidVideoWindowImpl;Landroid/view/SurfaceView;)V:GetOnVideoPreviewSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_Handler:Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl/IVideoWindowListenerInvoker, Liblinphone\n" +
			"n_onVideoRenderingSurfaceDestroyed:(Lorg/linphone/mediastream/video/AndroidVideoWindowImpl;)V:GetOnVideoRenderingSurfaceDestroyed_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Handler:Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl/IVideoWindowListenerInvoker, Liblinphone\n" +
			"n_onVideoRenderingSurfaceReady:(Lorg/linphone/mediastream/video/AndroidVideoWindowImpl;Landroid/view/SurfaceView;)V:GetOnVideoRenderingSurfaceReady_Lorg_linphone_mediastream_video_AndroidVideoWindowImpl_Landroid_view_SurfaceView_Handler:Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl/IVideoWindowListenerInvoker, Liblinphone\n" +
			"";
		mono.android.Runtime.register ("Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl+IVideoWindowListenerImplementor, Liblinphone", AndroidVideoWindowImpl_VideoWindowListenerImplementor.class, __md_methods);
	}


	public AndroidVideoWindowImpl_VideoWindowListenerImplementor ()
	{
		super ();
		if (getClass () == AndroidVideoWindowImpl_VideoWindowListenerImplementor.class)
			mono.android.TypeManager.Activate ("Org.Linphone.Mediastream.Video.AndroidVideoWindowImpl+IVideoWindowListenerImplementor, Liblinphone", "", this, new java.lang.Object[] {  });
	}


	public void onVideoPreviewSurfaceDestroyed (org.linphone.mediastream.video.AndroidVideoWindowImpl p0)
	{
		n_onVideoPreviewSurfaceDestroyed (p0);
	}

	private native void n_onVideoPreviewSurfaceDestroyed (org.linphone.mediastream.video.AndroidVideoWindowImpl p0);


	public void onVideoPreviewSurfaceReady (org.linphone.mediastream.video.AndroidVideoWindowImpl p0, android.view.SurfaceView p1)
	{
		n_onVideoPreviewSurfaceReady (p0, p1);
	}

	private native void n_onVideoPreviewSurfaceReady (org.linphone.mediastream.video.AndroidVideoWindowImpl p0, android.view.SurfaceView p1);


	public void onVideoRenderingSurfaceDestroyed (org.linphone.mediastream.video.AndroidVideoWindowImpl p0)
	{
		n_onVideoRenderingSurfaceDestroyed (p0);
	}

	private native void n_onVideoRenderingSurfaceDestroyed (org.linphone.mediastream.video.AndroidVideoWindowImpl p0);


	public void onVideoRenderingSurfaceReady (org.linphone.mediastream.video.AndroidVideoWindowImpl p0, android.view.SurfaceView p1)
	{
		n_onVideoRenderingSurfaceReady (p0, p1);
	}

	private native void n_onVideoRenderingSurfaceReady (org.linphone.mediastream.video.AndroidVideoWindowImpl p0, android.view.SurfaceView p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
