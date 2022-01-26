package crc64ef98f2062aecbcb3;


public class BaiduPushReceiver
	extends com.baidu.android.pushservice.PushMessageReceiver
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBind:(Landroid/content/Context;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V:GetOnBind_Landroid_content_Context_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler\n" +
			"n_onMessage:(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V:GetOnMessage_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler\n" +
			"n_onNotificationArrived:(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V:GetOnNotificationArrived_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler\n" +
			"n_onNotificationClicked:(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V:GetOnNotificationClicked_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler\n" +
			"n_onUnbind:(Landroid/content/Context;ILjava/lang/String;)V:GetOnUnbind_Landroid_content_Context_ILjava_lang_String_Handler\n" +
			"n_onDelTags:(Landroid/content/Context;ILjava/util/List;Ljava/util/List;Ljava/lang/String;)V:GetOnDelTags_Landroid_content_Context_ILjava_util_List_Ljava_util_List_Ljava_lang_String_Handler\n" +
			"n_onListTags:(Landroid/content/Context;ILjava/util/List;Ljava/lang/String;)V:GetOnListTags_Landroid_content_Context_ILjava_util_List_Ljava_lang_String_Handler\n" +
			"n_onSetTags:(Landroid/content/Context;ILjava/util/List;Ljava/util/List;Ljava/lang/String;)V:GetOnSetTags_Landroid_content_Context_ILjava_util_List_Ljava_util_List_Ljava_lang_String_Handler\n" +
			"";
		mono.android.Runtime.register ("LinphoneXamarin.Android.BaiduPushReceiver, LinphoneXamarin.Android", BaiduPushReceiver.class, __md_methods);
	}


	public BaiduPushReceiver ()
	{
		super ();
		if (getClass () == BaiduPushReceiver.class)
			mono.android.TypeManager.Activate ("LinphoneXamarin.Android.BaiduPushReceiver, LinphoneXamarin.Android", "", this, new java.lang.Object[] {  });
	}


	public void onBind (android.content.Context p0, int p1, java.lang.String p2, java.lang.String p3, java.lang.String p4, java.lang.String p5)
	{
		n_onBind (p0, p1, p2, p3, p4, p5);
	}

	private native void n_onBind (android.content.Context p0, int p1, java.lang.String p2, java.lang.String p3, java.lang.String p4, java.lang.String p5);


	public void onMessage (android.content.Context p0, java.lang.String p1, java.lang.String p2)
	{
		n_onMessage (p0, p1, p2);
	}

	private native void n_onMessage (android.content.Context p0, java.lang.String p1, java.lang.String p2);


	public void onNotificationArrived (android.content.Context p0, java.lang.String p1, java.lang.String p2, java.lang.String p3)
	{
		n_onNotificationArrived (p0, p1, p2, p3);
	}

	private native void n_onNotificationArrived (android.content.Context p0, java.lang.String p1, java.lang.String p2, java.lang.String p3);


	public void onNotificationClicked (android.content.Context p0, java.lang.String p1, java.lang.String p2, java.lang.String p3)
	{
		n_onNotificationClicked (p0, p1, p2, p3);
	}

	private native void n_onNotificationClicked (android.content.Context p0, java.lang.String p1, java.lang.String p2, java.lang.String p3);


	public void onUnbind (android.content.Context p0, int p1, java.lang.String p2)
	{
		n_onUnbind (p0, p1, p2);
	}

	private native void n_onUnbind (android.content.Context p0, int p1, java.lang.String p2);


	public void onDelTags (android.content.Context p0, int p1, java.util.List p2, java.util.List p3, java.lang.String p4)
	{
		n_onDelTags (p0, p1, p2, p3, p4);
	}

	private native void n_onDelTags (android.content.Context p0, int p1, java.util.List p2, java.util.List p3, java.lang.String p4);


	public void onListTags (android.content.Context p0, int p1, java.util.List p2, java.lang.String p3)
	{
		n_onListTags (p0, p1, p2, p3);
	}

	private native void n_onListTags (android.content.Context p0, int p1, java.util.List p2, java.lang.String p3);


	public void onSetTags (android.content.Context p0, int p1, java.util.List p2, java.util.List p3, java.lang.String p4)
	{
		n_onSetTags (p0, p1, p2, p3, p4);
	}

	private native void n_onSetTags (android.content.Context p0, int p1, java.util.List p2, java.util.List p3, java.lang.String p4);

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
