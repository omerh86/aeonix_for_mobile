using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Linphone.Core.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.linphone.core.util']/class[@name='AndroidPlatformHelper']"
	[global::Android.Runtime.Register ("org/linphone/core/util/AndroidPlatformHelper", DoNotGenerateAcw=true)]
	public partial class AndroidPlatformHelper : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/linphone/core/util/AndroidPlatformHelper", typeof (AndroidPlatformHelper));

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

		protected AndroidPlatformHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.linphone.core.util']/class[@name='AndroidPlatformHelper']/constructor[@name='AndroidPlatformHelper' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register (".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe AndroidPlatformHelper (global::Java.Lang.Object p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_getPowerManager;
#pragma warning disable 0169
		static Delegate GetGetPowerManagerHandler ()
		{
			if (cb_getPowerManager == null)
				cb_getPowerManager = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPowerManager);
			return cb_getPowerManager;
		}

		static IntPtr n_GetPowerManager (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Core.Util.AndroidPlatformHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PowerManager);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object PowerManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.core.util']/class[@name='AndroidPlatformHelper']/method[@name='getPowerManager' and count(parameter)=0]"
			[Register ("getPowerManager", "()Ljava/lang/Object;", "GetGetPowerManagerHandler")]
			get {
				const string __id = "getPowerManager.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_acquireCpuLock;
#pragma warning disable 0169
		static Delegate GetAcquireCpuLockHandler ()
		{
			if (cb_acquireCpuLock == null)
				cb_acquireCpuLock = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_AcquireCpuLock);
			return cb_acquireCpuLock;
		}

		static void n_AcquireCpuLock (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Core.Util.AndroidPlatformHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AcquireCpuLock ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.core.util']/class[@name='AndroidPlatformHelper']/method[@name='acquireCpuLock' and count(parameter)=0]"
		[Register ("acquireCpuLock", "()V", "GetAcquireCpuLockHandler")]
		public virtual unsafe void AcquireCpuLock ()
		{
			const string __id = "acquireCpuLock.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_acquireMcastLock;
#pragma warning disable 0169
		static Delegate GetAcquireMcastLockHandler ()
		{
			if (cb_acquireMcastLock == null)
				cb_acquireMcastLock = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_AcquireMcastLock);
			return cb_acquireMcastLock;
		}

		static void n_AcquireMcastLock (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Core.Util.AndroidPlatformHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AcquireMcastLock ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.core.util']/class[@name='AndroidPlatformHelper']/method[@name='acquireMcastLock' and count(parameter)=0]"
		[Register ("acquireMcastLock", "()V", "GetAcquireMcastLockHandler")]
		public virtual unsafe void AcquireMcastLock ()
		{
			const string __id = "acquireMcastLock.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_acquireWifiLock;
#pragma warning disable 0169
		static Delegate GetAcquireWifiLockHandler ()
		{
			if (cb_acquireWifiLock == null)
				cb_acquireWifiLock = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_AcquireWifiLock);
			return cb_acquireWifiLock;
		}

		static void n_AcquireWifiLock (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Core.Util.AndroidPlatformHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AcquireWifiLock ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.core.util']/class[@name='AndroidPlatformHelper']/method[@name='acquireWifiLock' and count(parameter)=0]"
		[Register ("acquireWifiLock", "()V", "GetAcquireWifiLockHandler")]
		public virtual unsafe void AcquireWifiLock ()
		{
			const string __id = "acquireWifiLock.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getDnsServers;
#pragma warning disable 0169
		static Delegate GetGetDnsServersHandler ()
		{
			if (cb_getDnsServers == null)
				cb_getDnsServers = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDnsServers);
			return cb_getDnsServers;
		}

		static IntPtr n_GetDnsServers (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Core.Util.AndroidPlatformHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDnsServers ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.core.util']/class[@name='AndroidPlatformHelper']/method[@name='getDnsServers' and count(parameter)=0]"
		[Register ("getDnsServers", "()[Ljava/lang/String;", "GetGetDnsServersHandler")]
		public virtual unsafe string[] GetDnsServers ()
		{
			const string __id = "getDnsServers.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_releaseCpuLock;
#pragma warning disable 0169
		static Delegate GetReleaseCpuLockHandler ()
		{
			if (cb_releaseCpuLock == null)
				cb_releaseCpuLock = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ReleaseCpuLock);
			return cb_releaseCpuLock;
		}

		static void n_ReleaseCpuLock (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Core.Util.AndroidPlatformHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseCpuLock ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.core.util']/class[@name='AndroidPlatformHelper']/method[@name='releaseCpuLock' and count(parameter)=0]"
		[Register ("releaseCpuLock", "()V", "GetReleaseCpuLockHandler")]
		public virtual unsafe void ReleaseCpuLock ()
		{
			const string __id = "releaseCpuLock.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_releaseMcastLock;
#pragma warning disable 0169
		static Delegate GetReleaseMcastLockHandler ()
		{
			if (cb_releaseMcastLock == null)
				cb_releaseMcastLock = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ReleaseMcastLock);
			return cb_releaseMcastLock;
		}

		static void n_ReleaseMcastLock (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Core.Util.AndroidPlatformHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseMcastLock ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.core.util']/class[@name='AndroidPlatformHelper']/method[@name='releaseMcastLock' and count(parameter)=0]"
		[Register ("releaseMcastLock", "()V", "GetReleaseMcastLockHandler")]
		public virtual unsafe void ReleaseMcastLock ()
		{
			const string __id = "releaseMcastLock.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_releaseWifiLock;
#pragma warning disable 0169
		static Delegate GetReleaseWifiLockHandler ()
		{
			if (cb_releaseWifiLock == null)
				cb_releaseWifiLock = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ReleaseWifiLock);
			return cb_releaseWifiLock;
		}

		static void n_ReleaseWifiLock (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Linphone.Core.Util.AndroidPlatformHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseWifiLock ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.linphone.core.util']/class[@name='AndroidPlatformHelper']/method[@name='releaseWifiLock' and count(parameter)=0]"
		[Register ("releaseWifiLock", "()V", "GetReleaseWifiLockHandler")]
		public virtual unsafe void ReleaseWifiLock ()
		{
			const string __id = "releaseWifiLock.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
