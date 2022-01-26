using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Android.Pushservice.Message {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']"
	[global::Android.Runtime.Register ("com/baidu/android/pushservice/message/PublicMsg", DoNotGenerateAcw=true)]
	public partial class PublicMsg : global::Java.Lang.Object, global::Android.OS.IParcelable {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='FLAG_NEED_CLEAR']"
		[Register ("FLAG_NEED_CLEAR")]
		public const int FlagNeedClear = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='FLAG_NEED_SOUND']"
		[Register ("FLAG_NEED_SOUND")]
		public const int FlagNeedSound = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='FLAG_NEED_VIBRATE']"
		[Register ("FLAG_NEED_VIBRATE")]
		public const int FlagNeedVibrate = (int) 2;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mAdvertiseBigPictureClickUrl']"
		[Register ("mAdvertiseBigPictureClickUrl")]
		public string MAdvertiseBigPictureClickUrl {
			get {
				const string __id = "mAdvertiseBigPictureClickUrl.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAdvertiseBigPictureClickUrl.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mAdvertiseBigPictureContent']"
		[Register ("mAdvertiseBigPictureContent")]
		public string MAdvertiseBigPictureContent {
			get {
				const string __id = "mAdvertiseBigPictureContent.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAdvertiseBigPictureContent.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mAdvertiseBigPictureTitle']"
		[Register ("mAdvertiseBigPictureTitle")]
		public string MAdvertiseBigPictureTitle {
			get {
				const string __id = "mAdvertiseBigPictureTitle.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAdvertiseBigPictureTitle.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mAdvertiseBigPictureUrl']"
		[Register ("mAdvertiseBigPictureUrl")]
		public string MAdvertiseBigPictureUrl {
			get {
				const string __id = "mAdvertiseBigPictureUrl.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAdvertiseBigPictureUrl.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mAdvertiseClickUrl']"
		[Register ("mAdvertiseClickUrl")]
		public string MAdvertiseClickUrl {
			get {
				const string __id = "mAdvertiseClickUrl.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAdvertiseClickUrl.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mAdvertiseDetailClickUrl']"
		[Register ("mAdvertiseDetailClickUrl")]
		public string MAdvertiseDetailClickUrl {
			get {
				const string __id = "mAdvertiseDetailClickUrl.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAdvertiseDetailClickUrl.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mAdvertiseDownloadClickUrl']"
		[Register ("mAdvertiseDownloadClickUrl")]
		public string MAdvertiseDownloadClickUrl {
			get {
				const string __id = "mAdvertiseDownloadClickUrl.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAdvertiseDownloadClickUrl.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mAdvertiseLargeIconUrl']"
		[Register ("mAdvertiseLargeIconUrl")]
		public string MAdvertiseLargeIconUrl {
			get {
				const string __id = "mAdvertiseLargeIconUrl.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAdvertiseLargeIconUrl.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mAdvertiseSmallIconUrl']"
		[Register ("mAdvertiseSmallIconUrl")]
		public string MAdvertiseSmallIconUrl {
			get {
				const string __id = "mAdvertiseSmallIconUrl.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAdvertiseSmallIconUrl.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mAdvertiseStyle']"
		[Register ("mAdvertiseStyle")]
		public int MAdvertiseStyle {
			get {
				const string __id = "mAdvertiseStyle.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mAdvertiseStyle.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mAppId']"
		[Register ("mAppId")]
		public string MAppId {
			get {
				const string __id = "mAppId.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAppId.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mCustomContent']"
		[Register ("mCustomContent")]
		public string MCustomContent {
			get {
				const string __id = "mCustomContent.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mCustomContent.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mDescription']"
		[Register ("mDescription")]
		public string MDescription {
			get {
				const string __id = "mDescription.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDescription.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mIsSupportApp']"
		[Register ("mIsSupportApp")]
		public bool MIsSupportApp {
			get {
				const string __id = "mIsSupportApp.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mIsSupportApp.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mMsgId']"
		[Register ("mMsgId")]
		public string MMsgId {
			get {
				const string __id = "mMsgId.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mMsgId.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mNetType']"
		[Register ("mNetType")]
		public int MNetType {
			get {
				const string __id = "mNetType.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mNetType.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mNotificationBasicStyle']"
		[Register ("mNotificationBasicStyle")]
		public int MNotificationBasicStyle {
			get {
				const string __id = "mNotificationBasicStyle.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mNotificationBasicStyle.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mNotificationBuilder']"
		[Register ("mNotificationBuilder")]
		public int MNotificationBuilder {
			get {
				const string __id = "mNotificationBuilder.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mNotificationBuilder.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mOpenType']"
		[Register ("mOpenType")]
		public int MOpenType {
			get {
				const string __id = "mOpenType.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mOpenType.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mPkgContent']"
		[Register ("mPkgContent")]
		public string MPkgContent {
			get {
				const string __id = "mPkgContent.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mPkgContent.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mPkgName']"
		[Register ("mPkgName")]
		public string MPkgName {
			get {
				const string __id = "mPkgName.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mPkgName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mPkgVercode']"
		[Register ("mPkgVercode")]
		public int MPkgVercode {
			get {
				const string __id = "mPkgVercode.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mPkgVercode.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mSupportAppname']"
		[Register ("mSupportAppname")]
		public string MSupportAppname {
			get {
				const string __id = "mSupportAppname.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mSupportAppname.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mTitle']"
		[Register ("mTitle")]
		public string MTitle {
			get {
				const string __id = "mTitle.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mTitle.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mUrl']"
		[Register ("mUrl")]
		public string MUrl {
			get {
				const string __id = "mUrl.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mUrl.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/field[@name='mUserConfirm']"
		[Register ("mUserConfirm")]
		public int MUserConfirm {
			get {
				const string __id = "mUserConfirm.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mUserConfirm.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/baidu/android/pushservice/message/PublicMsg", typeof (PublicMsg));

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

		protected PublicMsg (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/constructor[@name='PublicMsg' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PublicMsg () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Android.Pushservice.Message.PublicMsg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getLauncherActivityName_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLauncherActivityName_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_getLauncherActivityName_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_getLauncherActivityName_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetLauncherActivityName_Landroid_content_Context_Ljava_lang_String_);
			return cb_getLauncherActivityName_Landroid_content_Context_Ljava_lang_String_;
		}

		static IntPtr n_GetLauncherActivityName_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Android.Pushservice.Message.PublicMsg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetLauncherActivityName (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/method[@name='getLauncherActivityName' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getLauncherActivityName", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "GetGetLauncherActivityName_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe string GetLauncherActivityName (global::Android.Content.Context p0, string p1)
		{
			const string __id = "getLauncherActivityName.(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_handle_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHandle_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_handle_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_handle_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Handle_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_);
			return cb_handle_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Handle_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Android.Pushservice.Message.PublicMsg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Handle (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/method[@name='handle' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("handle", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "GetHandle_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler")]
		public new virtual unsafe void Handle (global::Android.Content.Context p0, string p1, string p2)
		{
			const string __id = "handle.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_handlePrivateNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetHandlePrivateNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBarrayBHandler ()
		{
			if (cb_handlePrivateNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBarrayB == null)
				cb_handlePrivateNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLL_V) n_HandlePrivateNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBarrayB);
			return cb_handlePrivateNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBarrayB;
		}

		static void n_HandlePrivateNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Android.Pushservice.Message.PublicMsg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = (byte[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p5 = (byte[]) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.HandlePrivateNotification (p0, p1, p2, p3, p4, p5);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/method[@name='handlePrivateNotification' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]']]"
		[Register ("handlePrivateNotification", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[B[B)V", "GetHandlePrivateNotification_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayBarrayBHandler")]
		public virtual unsafe void HandlePrivateNotification (global::Android.Content.Context p0, string p1, string p2, string p3, byte[] p4, byte[] p5)
		{
			const string __id = "handlePrivateNotification.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[B[B)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
				if (p5 != null) {
					JNIEnv.CopyArray (native_p5, p5);
					JNIEnv.DeleteLocalRef (native_p5);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p4);
				global::System.GC.KeepAlive (p5);
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Android.Pushservice.Message.PublicMsg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice.message']/class[@name='PublicMsg']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((int) p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
