package crc64ef98f2062aecbcb3;


public class MyLabelRenderer
	extends crc64720bb2db43a66fe9.ButtonRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("LinphoneXamarin.Android.MyLabelRenderer, LinphoneXamarin.Android", MyLabelRenderer.class, __md_methods);
	}


	public MyLabelRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == MyLabelRenderer.class)
			mono.android.TypeManager.Activate ("LinphoneXamarin.Android.MyLabelRenderer, LinphoneXamarin.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public MyLabelRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == MyLabelRenderer.class)
			mono.android.TypeManager.Activate ("LinphoneXamarin.Android.MyLabelRenderer, LinphoneXamarin.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public MyLabelRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MyLabelRenderer.class)
			mono.android.TypeManager.Activate ("LinphoneXamarin.Android.MyLabelRenderer, LinphoneXamarin.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
