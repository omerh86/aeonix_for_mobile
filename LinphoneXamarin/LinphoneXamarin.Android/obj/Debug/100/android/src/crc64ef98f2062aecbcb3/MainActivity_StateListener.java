package crc64ef98f2062aecbcb3;


public class MainActivity_StateListener
	extends android.telephony.PhoneStateListener
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCallStateChanged:(ILjava/lang/String;)V:GetOnCallStateChanged_ILjava_lang_String_Handler\n" +
			"";
		mono.android.Runtime.register ("LinphoneXamarin.Android.MainActivity+StateListener, LinphoneXamarin.Android", MainActivity_StateListener.class, __md_methods);
	}


	public MainActivity_StateListener ()
	{
		super ();
		if (getClass () == MainActivity_StateListener.class)
			mono.android.TypeManager.Activate ("LinphoneXamarin.Android.MainActivity+StateListener, LinphoneXamarin.Android", "", this, new java.lang.Object[] {  });
	}


	public void onCallStateChanged (int p0, java.lang.String p1)
	{
		n_onCallStateChanged (p0, p1);
	}

	private native void n_onCallStateChanged (int p0, java.lang.String p1);

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
