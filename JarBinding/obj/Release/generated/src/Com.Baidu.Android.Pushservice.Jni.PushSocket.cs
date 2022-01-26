using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Android.Pushservice.Jni {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.android.pushservice.jni']/class[@name='PushSocket']"
	[global::Android.Runtime.Register ("com/baidu/android/pushservice/jni/PushSocket", DoNotGenerateAcw=true)]
	public partial class PushSocket : global::Java.Lang.Object {
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.android.pushservice.jni']/interface[@name='PushSocket.OnCreateSocketListener']"
		[Register ("com/baidu/android/pushservice/jni/PushSocket$OnCreateSocketListener", "", "Com.Baidu.Android.Pushservice.Jni.PushSocket/IOnCreateSocketListenerInvoker")]
		public partial interface IOnCreateSocketListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice.jni']/interface[@name='PushSocket.OnCreateSocketListener']/method[@name='onConnect' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onConnect", "(I)V", "GetOnConnect_IHandler:Com.Baidu.Android.Pushservice.Jni.PushSocket/IOnCreateSocketListenerInvoker, JarBinding")]
			void OnConnect (int p0);

		}

		[global::Android.Runtime.Register ("com/baidu/android/pushservice/jni/PushSocket$OnCreateSocketListener", DoNotGenerateAcw=true)]
		internal partial class IOnCreateSocketListenerInvoker : global::Java.Lang.Object, IOnCreateSocketListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/baidu/android/pushservice/jni/PushSocket$OnCreateSocketListener", typeof (IOnCreateSocketListenerInvoker));

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

			public static IOnCreateSocketListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCreateSocketListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.baidu.android.pushservice.jni.PushSocket.OnCreateSocketListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCreateSocketListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onConnect_I;
#pragma warning disable 0169
			static Delegate GetOnConnect_IHandler ()
			{
				if (cb_onConnect_I == null)
					cb_onConnect_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnConnect_I);
				return cb_onConnect_I;
			}

			static void n_OnConnect_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Android.Pushservice.Jni.PushSocket.IOnCreateSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnConnect (p0);
			}
#pragma warning restore 0169

			IntPtr id_onConnect_I;
			public unsafe void OnConnect (int p0)
			{
				if (id_onConnect_I == IntPtr.Zero)
					id_onConnect_I = JNIEnv.GetMethodID (class_ref, "onConnect", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnect_I, __args);
			}

		}

		// event args for com.baidu.android.pushservice.jni.PushSocket.OnCreateSocketListener.onConnect
		public partial class CreateSocketEventArgs : global::System.EventArgs {
			public CreateSocketEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;

			public int P0 {
				get { return p0; }
			}

		}

		[global::Android.Runtime.Register ("mono/com/baidu/android/pushservice/jni/PushSocket_OnCreateSocketListenerImplementor")]
		internal sealed partial class IOnCreateSocketListenerImplementor : global::Java.Lang.Object, IOnCreateSocketListener {

			object sender;

			public IOnCreateSocketListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/android/pushservice/jni/PushSocket_OnCreateSocketListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

			#pragma warning disable 0649
			public EventHandler<CreateSocketEventArgs> Handler;
			#pragma warning restore 0649

			public void OnConnect (int p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new CreateSocketEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnCreateSocketListenerImplementor value)
			{
				return value.Handler == null;
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/baidu/android/pushservice/jni/PushSocket", typeof (PushSocket));

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

		protected PushSocket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public static unsafe bool IsIPv4Reachable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice.jni']/class[@name='PushSocket']/method[@name='isIPv4Reachable' and count(parameter)=0]"
			[Register ("isIPv4Reachable", "()Z", "")]
			get {
				const string __id = "isIPv4Reachable.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int LastSocketError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice.jni']/class[@name='PushSocket']/method[@name='getLastSocketError' and count(parameter)=0]"
			[Register ("getLastSocketError", "()I", "")]
			get {
				const string __id = "getLastSocketError.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe string LastSocketIP {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice.jni']/class[@name='PushSocket']/method[@name='getLastSocketIP' and count(parameter)=0]"
			[Register ("getLastSocketIP", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getLastSocketIP.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice.jni']/class[@name='PushSocket']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Z", "")]
		public static unsafe bool A ()
		{
			const string __id = "a.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice.jni']/class[@name='PushSocket']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("a", "(Landroid/content/Context;I)[B", "")]
		public static unsafe byte[] A (global::Android.Content.Context p0, int p1)
		{
			const string __id = "a.(Landroid/content/Context;I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice.jni']/class[@name='PushSocket']/method[@name='a' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("a", "([BI)S", "")]
		public static unsafe short A (byte[] p0, int p1)
		{
			const string __id = "a.([BI)S";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt16Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice.jni']/class[@name='PushSocket']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("a", "(I)V", "")]
		public static unsafe void A (int p0)
		{
			const string __id = "a.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice.jni']/class[@name='PushSocket']/method[@name='a' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("a", "(I[BI)I", "")]
		public static unsafe int A (int p0, byte[] p1, int p2)
		{
			const string __id = "a.(I[BI)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice.jni']/class[@name='PushSocket']/method[@name='b' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("b", "([BI)I", "")]
		public static unsafe int B (byte[] p0, int p1)
		{
			const string __id = "b.([BI)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice.jni']/class[@name='PushSocket']/method[@name='closeSocket' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("closeSocket", "(I)I", "")]
		public static unsafe int CloseSocket (int p0)
		{
			const string __id = "closeSocket.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.pushservice.jni']/class[@name='PushSocket']/method[@name='createSocket' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='com.baidu.android.pushservice.jni.PushSocket.OnCreateSocketListener']]"
		[Register ("createSocket", "(Ljava/lang/String;ILcom/baidu/android/pushservice/jni/PushSocket$OnCreateSocketListener;)I", "")]
		public static unsafe int CreateSocket (string p0, int p1, global::Com.Baidu.Android.Pushservice.Jni.PushSocket.IOnCreateSocketListener p2)
		{
			const string __id = "createSocket.(Ljava/lang/String;ILcom/baidu/android/pushservice/jni/PushSocket$OnCreateSocketListener;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p2);
			}
		}

	}
}
