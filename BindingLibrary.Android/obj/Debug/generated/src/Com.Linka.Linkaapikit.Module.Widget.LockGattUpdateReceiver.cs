using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linka.Linkaapikit.Module.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockGattUpdateReceiver']"
	[global::Android.Runtime.Register ("com/linka/linkaapikit/module/widget/LockGattUpdateReceiver", DoNotGenerateAcw=true)]
	public partial class LockGattUpdateReceiver : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/widget/LockGattUpdateReceiver", typeof (LockGattUpdateReceiver));

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

		protected LockGattUpdateReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getVersionInfo;
#pragma warning disable 0169
		static Delegate GetGetVersionInfoHandler ()
		{
			if (cb_getVersionInfo == null)
				cb_getVersionInfo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVersionInfo);
			return cb_getVersionInfo;
		}

		static IntPtr n_GetVersionInfo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockGattUpdateReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VersionInfo);
		}
#pragma warning restore 0169

		public virtual unsafe string VersionInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockGattUpdateReceiver']/method[@name='getVersionInfo' and count(parameter)=0]"
			[Register ("getVersionInfo", "()Ljava/lang/String;", "GetGetVersionInfoHandler")]
			get {
				const string __id = "getVersionInfo.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_e;
#pragma warning disable 0169
		static Delegate GetEHandler ()
		{
			if (cb_e == null)
				cb_e = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_E);
			return cb_e;
		}

		static void n_E (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockGattUpdateReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.E ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockGattUpdateReceiver']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()V", "GetEHandler")]
		protected virtual unsafe void E ()
		{
			const string __id = "e.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_f;
#pragma warning disable 0169
		static Delegate GetFHandler ()
		{
			if (cb_f == null)
				cb_f = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_F);
			return cb_f;
		}

		static void n_F (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockGattUpdateReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.F ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockGattUpdateReceiver']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()V", "GetFHandler")]
		protected virtual unsafe void F ()
		{
			const string __id = "f.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
