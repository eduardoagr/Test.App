using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linka.Linkaapikit.Module.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockPairingController']"
	[global::Android.Runtime.Register ("com/linka/linkaapikit/module/widget/LockPairingController", DoNotGenerateAcw=true)]
	public partial class LockPairingController : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockPairingController']/field[@name='c']"
		[Register ("c")]
		protected bool C {
			get {
				const string __id = "c.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "c.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockPairingController']/field[@name='d']"
		[Register ("d")]
		protected bool D {
			get {
				const string __id = "d.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "d.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockPairingController']/field[@name='e']"
		[Register ("e")]
		protected bool E {
			get {
				const string __id = "e.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "e.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/widget/LockPairingController", typeof (LockPairingController));

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

		protected LockPairingController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getLinka;
#pragma warning disable 0169
		static Delegate GetGetLinkaHandler ()
		{
			if (cb_getLinka == null)
				cb_getLinka = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLinka);
			return cb_getLinka;
		}

		static IntPtr n_GetLinka (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockPairingController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Linka);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Linka.Linkaapikit.Module.Model.Linka Linka {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockPairingController']/method[@name='getLinka' and count(parameter)=0]"
			[Register ("getLinka", "()Lcom/linka/linkaapikit/module/model/Linka;", "GetGetLinkaHandler")]
			get {
				const string __id = "getLinka.()Lcom/linka/linkaapikit/module/model/Linka;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_doDisconnectDevice;
#pragma warning disable 0169
		static Delegate GetDoDisconnectDeviceHandler ()
		{
			if (cb_doDisconnectDevice == null)
				cb_doDisconnectDevice = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DoDisconnectDevice);
			return cb_doDisconnectDevice;
		}

		static void n_DoDisconnectDevice (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockPairingController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoDisconnectDevice ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockPairingController']/method[@name='doDisconnectDevice' and count(parameter)=0]"
		[Register ("doDisconnectDevice", "()V", "GetDoDisconnectDeviceHandler")]
		public virtual unsafe void DoDisconnectDevice ()
		{
			const string __id = "doDisconnectDevice.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_initialize_Z;
#pragma warning disable 0169
		static Delegate GetInitialize_ZHandler ()
		{
			if (cb_initialize_Z == null)
				cb_initialize_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_Initialize_Z);
			return cb_initialize_Z;
		}

		static void n_Initialize_Z (IntPtr jnienv, IntPtr native__this, bool autoconnect)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockPairingController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (autoconnect);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockPairingController']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("initialize", "(Z)V", "GetInitialize_ZHandler")]
		public virtual unsafe void Initialize (bool autoconnect)
		{
			const string __id = "initialize.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (autoconnect);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
