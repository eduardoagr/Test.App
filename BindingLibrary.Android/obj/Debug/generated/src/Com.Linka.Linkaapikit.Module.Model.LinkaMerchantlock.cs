using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linka.Linkaapikit.Module.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantlock']"
	[global::Android.Runtime.Register ("com/linka/linkaapikit/module/model/LinkaMerchantlock", DoNotGenerateAcw=true)]
	public partial class LinkaMerchantlock : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantlock.LinkaMerchantlockAccessKey']"
		[global::Android.Runtime.Register ("com/linka/linkaapikit/module/model/LinkaMerchantlock$LinkaMerchantlockAccessKey", DoNotGenerateAcw=true)]
		public partial class LinkaMerchantlockAccessKey : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantlock.LinkaMerchantlockAccessKey']/field[@name='settingConfiguration']"
			[Register ("settingConfiguration")]
			public global::Com.Linka.Linkaapikit.Module.Api.SettingConfiguration SettingConfiguration {
				get {
					const string __id = "settingConfiguration.Lcom/linka/linkaapikit/module/api/SettingConfiguration;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Api.SettingConfiguration> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "settingConfiguration.Lcom/linka/linkaapikit/module/api/SettingConfiguration;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/model/LinkaMerchantlock$LinkaMerchantlockAccessKey", typeof (LinkaMerchantlockAccessKey));

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

			protected LinkaMerchantlockAccessKey (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantlock.LinkaMerchantlockAccessKey']/constructor[@name='LinkaMerchantlock.LinkaMerchantlockAccessKey' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe LinkaMerchantlockAccessKey () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate cb_getAdminKey_2;
#pragma warning disable 0169
			static Delegate GetGetAdminKey_2Handler ()
			{
				if (cb_getAdminKey_2 == null)
					cb_getAdminKey_2 = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAdminKey_2);
				return cb_getAdminKey_2;
			}

			static IntPtr n_GetAdminKey_2 (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LinkaMerchantlock.LinkaMerchantlockAccessKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.AdminKey_2);
			}
#pragma warning restore 0169

			public virtual unsafe string AdminKey_2 {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantlock.LinkaMerchantlockAccessKey']/method[@name='getAdminKey_2' and count(parameter)=0]"
				[Register ("getAdminKey_2", "()Ljava/lang/String;", "GetGetAdminKey_2Handler")]
				get {
					const string __id = "getAdminKey_2.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getMasterKey;
#pragma warning disable 0169
			static Delegate GetGetMasterKeyHandler ()
			{
				if (cb_getMasterKey == null)
					cb_getMasterKey = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMasterKey);
				return cb_getMasterKey;
			}

			static IntPtr n_GetMasterKey (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LinkaMerchantlock.LinkaMerchantlockAccessKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.MasterKey);
			}
#pragma warning restore 0169

			public virtual unsafe string MasterKey {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantlock.LinkaMerchantlockAccessKey']/method[@name='getMasterKey' and count(parameter)=0]"
				[Register ("getMasterKey", "()Ljava/lang/String;", "GetGetMasterKeyHandler")]
				get {
					const string __id = "getMasterKey.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getV2_AdminKey_2;
#pragma warning disable 0169
			static Delegate GetGetV2_AdminKey_2Handler ()
			{
				if (cb_getV2_AdminKey_2 == null)
					cb_getV2_AdminKey_2 = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetV2_AdminKey_2);
				return cb_getV2_AdminKey_2;
			}

			static IntPtr n_GetV2_AdminKey_2 (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LinkaMerchantlock.LinkaMerchantlockAccessKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.V2_AdminKey_2);
			}
#pragma warning restore 0169

			public virtual unsafe string V2_AdminKey_2 {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantlock.LinkaMerchantlockAccessKey']/method[@name='getV2_AdminKey_2' and count(parameter)=0]"
				[Register ("getV2_AdminKey_2", "()Ljava/lang/String;", "GetGetV2_AdminKey_2Handler")]
				get {
					const string __id = "getV2_AdminKey_2.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantlock.LinkaMerchantlockAccessKey']/method[@name='makeLinkaMerchantlockAccessKey' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.api.LinkaMerchantlockAPIServiceResponse.Data']]"
			[Register ("makeLinkaMerchantlockAccessKey", "(Lcom/linka/linkaapikit/module/api/LinkaMerchantlockAPIServiceResponse$Data;)Lcom/linka/linkaapikit/module/model/LinkaMerchantlock$LinkaMerchantlockAccessKey;", "")]
			public static unsafe global::Com.Linka.Linkaapikit.Module.Model.LinkaMerchantlock.LinkaMerchantlockAccessKey MakeLinkaMerchantlockAccessKey (global::Com.Linka.Linkaapikit.Module.Api.LinkaMerchantlockAPIServiceResponse.Data mapping)
			{
				const string __id = "makeLinkaMerchantlockAccessKey.(Lcom/linka/linkaapikit/module/api/LinkaMerchantlockAPIServiceResponse$Data;)Lcom/linka/linkaapikit/module/model/LinkaMerchantlock$LinkaMerchantlockAccessKey;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((mapping == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapping).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LinkaMerchantlock.LinkaMerchantlockAccessKey> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (mapping);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/model/LinkaMerchantlock", typeof (LinkaMerchantlock));

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

		protected LinkaMerchantlock (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantlock']/constructor[@name='LinkaMerchantlock' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LinkaMerchantlock () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

	}
}
