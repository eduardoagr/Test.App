using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linka.Linkaapikit.Module.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']"
	[global::Android.Runtime.Register ("com/linka/linkaapikit/module/model/Linka", DoNotGenerateAcw=true)]
	public partial class Linka : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='actuations']"
		[Register ("actuations")]
		public long Actuations {
			get {
				const string __id = "actuations.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "actuations.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='api_user_id']"
		[Register ("api_user_id")]
		public string ApiUserId {
			get {
				const string __id = "api_user_id.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "api_user_id.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='authState']"
		[Register ("authState")]
		public int AuthState {
			get {
				const string __id = "authState.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "authState.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='awaitsForAutoUnlocking']"
		[Register ("awaitsForAutoUnlocking")]
		public bool AwaitsForAutoUnlocking {
			get {
				const string __id = "awaitsForAutoUnlocking.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "awaitsForAutoUnlocking.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='batteryPercent']"
		[Register ("batteryPercent")]
		public int BatteryPercent {
			get {
				const string __id = "batteryPercent.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "batteryPercent.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='canRecordBatteryCriticallyLow']"
		[Register ("canRecordBatteryCriticallyLow")]
		public bool CanRecordBatteryCriticallyLow {
			get {
				const string __id = "canRecordBatteryCriticallyLow.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "canRecordBatteryCriticallyLow.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='canRecordBatteryLow']"
		[Register ("canRecordBatteryLow")]
		public bool CanRecordBatteryLow {
			get {
				const string __id = "canRecordBatteryLow.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "canRecordBatteryLow.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='canRecordStall']"
		[Register ("canRecordStall")]
		public bool CanRecordStall {
			get {
				const string __id = "canRecordStall.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "canRecordStall.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='fw_version']"
		[Register ("fw_version")]
		public string FwVersion {
			get {
				const string __id = "fw_version.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "fw_version.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='isConnected']"
		[Register ("isConnected")]
		public bool IsConnected {
			get {
				const string __id = "isConnected.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isConnected.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='isLocked']"
		[Register ("isLocked")]
		public bool IsLocked {
			get {
				const string __id = "isLocked.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isLocked.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='isLocking']"
		[Register ("isLocking")]
		public bool IsLocking {
			get {
				const string __id = "isLocking.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isLocking.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='isRecorded']"
		[Register ("isRecorded")]
		public bool IsRecorded {
			get {
				const string __id = "isRecorded.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isRecorded.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='isUnlocked']"
		[Register ("isUnlocked")]
		public bool IsUnlocked {
			get {
				const string __id = "isUnlocked.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isUnlocked.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='isUnlocking']"
		[Register ("isUnlocking")]
		public bool IsUnlocking {
			get {
				const string __id = "isUnlocking.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isUnlocking.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='latitude']"
		[Register ("latitude")]
		public string Latitude {
			get {
				const string __id = "latitude.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "latitude.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='lockState']"
		[Register ("lockState")]
		public int LockState {
			get {
				const string __id = "lockState.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "lockState.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='lock_address']"
		[Register ("lock_address")]
		public string LockAddress {
			get {
				const string __id = "lock_address.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "lock_address.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='lock_mac_address']"
		[Register ("lock_mac_address")]
		public string LockMacAddress {
			get {
				const string __id = "lock_mac_address.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "lock_mac_address.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='lock_name']"
		[Register ("lock_name")]
		public string LockName {
			get {
				const string __id = "lock_name.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "lock_name.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='longitude']"
		[Register ("longitude")]
		public string Longitude {
			get {
				const string __id = "longitude.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "longitude.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='pac']"
		[Register ("pac")]
		public int Pac {
			get {
				const string __id = "pac.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "pac.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='rssi']"
		[Register ("rssi")]
		public int Rssi {
			get {
				const string __id = "rssi.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "rssi.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='settings_audible_locking_unlocking']"
		[Register ("settings_audible_locking_unlocking")]
		public bool SettingsAudibleLockingUnlocking {
			get {
				const string __id = "settings_audible_locking_unlocking.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "settings_audible_locking_unlocking.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='settings_auto_unlocking']"
		[Register ("settings_auto_unlocking")]
		public bool SettingsAutoUnlocking {
			get {
				const string __id = "settings_auto_unlocking.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "settings_auto_unlocking.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='settings_passcode_is_set']"
		[Register ("settings_passcode_is_set")]
		public bool SettingsPasscodeIsSet {
			get {
				const string __id = "settings_passcode_is_set.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "settings_passcode_is_set.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='settings_tamper_siren']"
		[Register ("settings_tamper_siren")]
		public bool SettingsTamperSiren {
			get {
				const string __id = "settings_tamper_siren.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "settings_tamper_siren.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='tamperStatus']"
		[Register ("tamperStatus")]
		public long TamperStatus {
			get {
				const string __id = "tamperStatus.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "tamperStatus.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='temperature']"
		[Register ("temperature")]
		public double Temperature {
			get {
				const string __id = "temperature.D";

				var __v = _members.InstanceFields.GetDoubleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "temperature.D";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='timestamp_locked']"
		[Register ("timestamp_locked")]
		public string TimestampLocked {
			get {
				const string __id = "timestamp_locked.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "timestamp_locked.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/field[@name='timestamp_unlocked']"
		[Register ("timestamp_unlocked")]
		public string TimestampUnlocked {
			get {
				const string __id = "timestamp_unlocked.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "timestamp_unlocked.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/model/Linka", typeof (Linka));

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

		protected Linka (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/constructor[@name='Linka' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Linka () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getAccess_key_admin_2;
#pragma warning disable 0169
		static Delegate GetGetAccess_key_admin_2Handler ()
		{
			if (cb_getAccess_key_admin_2 == null)
				cb_getAccess_key_admin_2 = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAccess_key_admin_2);
			return cb_getAccess_key_admin_2;
		}

		static IntPtr n_GetAccess_key_admin_2 (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Access_key_admin_2);
		}
#pragma warning restore 0169

		static Delegate cb_setAccess_key_admin_2_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccess_key_admin_2_Ljava_lang_String_Handler ()
		{
			if (cb_setAccess_key_admin_2_Ljava_lang_String_ == null)
				cb_setAccess_key_admin_2_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAccess_key_admin_2_Ljava_lang_String_);
			return cb_setAccess_key_admin_2_Ljava_lang_String_;
		}

		static void n_SetAccess_key_admin_2_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_access_key_admin_2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var access_key_admin_2 = JNIEnv.GetString (native_access_key_admin_2, JniHandleOwnership.DoNotTransfer);
			__this.Access_key_admin_2 = access_key_admin_2;
		}
#pragma warning restore 0169

		public virtual unsafe string Access_key_admin_2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/method[@name='getAccess_key_admin_2' and count(parameter)=0]"
			[Register ("getAccess_key_admin_2", "()Ljava/lang/String;", "GetGetAccess_key_admin_2Handler")]
			get {
				const string __id = "getAccess_key_admin_2.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/method[@name='setAccess_key_admin_2' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccess_key_admin_2", "(Ljava/lang/String;)V", "GetSetAccess_key_admin_2_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAccess_key_admin_2.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getApi_user_id;
#pragma warning disable 0169
		static Delegate GetGetApi_user_idHandler ()
		{
			if (cb_getApi_user_id == null)
				cb_getApi_user_id = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetApi_user_id);
			return cb_getApi_user_id;
		}

		static IntPtr n_GetApi_user_id (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Api_user_id);
		}
#pragma warning restore 0169

		static Delegate cb_setApi_user_id_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetApi_user_id_Ljava_lang_String_Handler ()
		{
			if (cb_setApi_user_id_Ljava_lang_String_ == null)
				cb_setApi_user_id_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetApi_user_id_Ljava_lang_String_);
			return cb_setApi_user_id_Ljava_lang_String_;
		}

		static void n_SetApi_user_id_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_api_user_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var api_user_id = JNIEnv.GetString (native_api_user_id, JniHandleOwnership.DoNotTransfer);
			__this.Api_user_id = api_user_id;
		}
#pragma warning restore 0169

		public virtual unsafe string Api_user_id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/method[@name='getApi_user_id' and count(parameter)=0]"
			[Register ("getApi_user_id", "()Ljava/lang/String;", "GetGetApi_user_idHandler")]
			get {
				const string __id = "getApi_user_id.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/method[@name='setApi_user_id' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setApi_user_id", "(Ljava/lang/String;)V", "GetSetApi_user_id_Ljava_lang_String_Handler")]
			set {
				const string __id = "setApi_user_id.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBatteryRemainingRepresentation;
#pragma warning disable 0169
		static Delegate GetGetBatteryRemainingRepresentationHandler ()
		{
			if (cb_getBatteryRemainingRepresentation == null)
				cb_getBatteryRemainingRepresentation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBatteryRemainingRepresentation);
			return cb_getBatteryRemainingRepresentation;
		}

		static IntPtr n_GetBatteryRemainingRepresentation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BatteryRemainingRepresentation);
		}
#pragma warning restore 0169

		public virtual unsafe string BatteryRemainingRepresentation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/method[@name='getBatteryRemainingRepresentation' and count(parameter)=0]"
			[Register ("getBatteryRemainingRepresentation", "()Ljava/lang/String;", "GetGetBatteryRemainingRepresentationHandler")]
			get {
				const string __id = "getBatteryRemainingRepresentation.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetId);
			return cb_getId;
		}

		static long n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id;
		}
#pragma warning restore 0169

		static Delegate cb_setId_J;
#pragma warning disable 0169
		static Delegate GetSetId_JHandler ()
		{
			if (cb_setId_J == null)
				cb_setId_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetId_J);
			return cb_setId_J;
		}

		static void n_SetId_J (IntPtr jnienv, IntPtr native__this, long id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Id = id;
		}
#pragma warning restore 0169

		public virtual unsafe long Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()J", "GetGetIdHandler")]
			get {
				const string __id = "getId.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setId", "(J)V", "GetSetId_JHandler")]
			set {
				const string __id = "setId.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isTamperAlert;
#pragma warning disable 0169
		static Delegate GetIsTamperAlertHandler ()
		{
			if (cb_isTamperAlert == null)
				cb_isTamperAlert = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsTamperAlert);
			return cb_isTamperAlert;
		}

		static bool n_IsTamperAlert (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTamperAlert;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsTamperAlert {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/method[@name='isTamperAlert' and count(parameter)=0]"
			[Register ("isTamperAlert", "()Z", "GetIsTamperAlertHandler")]
			get {
				const string __id = "isTamperAlert.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe global::System.Collections.Generic.IList<global::Com.Linka.Linkaapikit.Module.Model.Linka> Linkas {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/method[@name='getLinkas' and count(parameter)=0]"
			[Register ("getLinkas", "()Ljava/util/List;", "")]
			get {
				const string __id = "getLinkas.()Ljava/util/List;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Android.Runtime.JavaList<global::Com.Linka.Linkaapikit.Module.Model.Linka>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMACAddress;
#pragma warning disable 0169
		static Delegate GetGetMACAddressHandler ()
		{
			if (cb_getMACAddress == null)
				cb_getMACAddress = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMACAddress);
			return cb_getMACAddress;
		}

		static IntPtr n_GetMACAddress (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MACAddress);
		}
#pragma warning restore 0169

		public virtual unsafe string MACAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/method[@name='getMACAddress' and count(parameter)=0]"
			[Register ("getMACAddress", "()Ljava/lang/String;", "GetGetMACAddressHandler")]
			get {
				const string __id = "getMACAddress.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUUIDAddress;
#pragma warning disable 0169
		static Delegate GetGetUUIDAddressHandler ()
		{
			if (cb_getUUIDAddress == null)
				cb_getUUIDAddress = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUUIDAddress);
			return cb_getUUIDAddress;
		}

		static IntPtr n_GetUUIDAddress (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UUIDAddress);
		}
#pragma warning restore 0169

		public virtual unsafe string UUIDAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/method[@name='getUUIDAddress' and count(parameter)=0]"
			[Register ("getUUIDAddress", "()Ljava/lang/String;", "GetGetUUIDAddressHandler")]
			get {
				const string __id = "getUUIDAddress.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getV2_access_key_admin_2;
#pragma warning disable 0169
		static Delegate GetGetV2_access_key_admin_2Handler ()
		{
			if (cb_getV2_access_key_admin_2 == null)
				cb_getV2_access_key_admin_2 = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetV2_access_key_admin_2);
			return cb_getV2_access_key_admin_2;
		}

		static IntPtr n_GetV2_access_key_admin_2 (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.V2_access_key_admin_2);
		}
#pragma warning restore 0169

		static Delegate cb_setV2_access_key_admin_2_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetV2_access_key_admin_2_Ljava_lang_String_Handler ()
		{
			if (cb_setV2_access_key_admin_2_Ljava_lang_String_ == null)
				cb_setV2_access_key_admin_2_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetV2_access_key_admin_2_Ljava_lang_String_);
			return cb_setV2_access_key_admin_2_Ljava_lang_String_;
		}

		static void n_SetV2_access_key_admin_2_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_v2_access_key_admin_2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var v2_access_key_admin_2 = JNIEnv.GetString (native_v2_access_key_admin_2, JniHandleOwnership.DoNotTransfer);
			__this.V2_access_key_admin_2 = v2_access_key_admin_2;
		}
#pragma warning restore 0169

		public virtual unsafe string V2_access_key_admin_2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/method[@name='getV2_access_key_admin_2' and count(parameter)=0]"
			[Register ("getV2_access_key_admin_2", "()Ljava/lang/String;", "GetGetV2_access_key_admin_2Handler")]
			get {
				const string __id = "getV2_access_key_admin_2.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/method[@name='setV2_access_key_admin_2' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setV2_access_key_admin_2", "(Ljava/lang/String;)V", "GetSetV2_access_key_admin_2_Ljava_lang_String_Handler")]
			set {
				const string __id = "setV2_access_key_admin_2.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAdminKey_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetGetAdminKey_Ljava_lang_Boolean_Handler ()
		{
			if (cb_getAdminKey_Ljava_lang_Boolean_ == null)
				cb_getAdminKey_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAdminKey_Ljava_lang_Boolean_);
			return cb_getAdminKey_Ljava_lang_Boolean_;
		}

		static IntPtr n_GetAdminKey_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_isV2Lock)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var isV2Lock = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_isV2Lock, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAdminKey (isV2Lock));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/method[@name='getAdminKey' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("getAdminKey", "(Ljava/lang/Boolean;)Ljava/lang/String;", "GetGetAdminKey_Ljava_lang_Boolean_Handler")]
		public virtual unsafe string GetAdminKey (global::Java.Lang.Boolean isV2Lock)
		{
			const string __id = "getAdminKey.(Ljava/lang/Boolean;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((isV2Lock == null) ? IntPtr.Zero : ((global::Java.Lang.Object) isV2Lock).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (isV2Lock);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/method[@name='getName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.linka.linkaapikit.module.Lock.BLE.BluetoothLEDevice']]"
		[Register ("getName", "(Ljava/lang/String;Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLEDevice;)Ljava/lang/String;", "")]
		public static unsafe string GetName (string lock_mac_address, global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLEDevice item)
		{
			const string __id = "getName.(Ljava/lang/String;Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLEDevice;)Ljava/lang/String;";
			IntPtr native_lock_mac_address = JNIEnv.NewString (lock_mac_address);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_lock_mac_address);
				__args [1] = new JniArgumentValue ((item == null) ? IntPtr.Zero : ((global::Java.Lang.Object) item).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_lock_mac_address);
				global::System.GC.KeepAlive (item);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/method[@name='makeLinka' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.Lock.BLE.BluetoothLEDevice']]"
		[Register ("makeLinka", "(Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLEDevice;)Lcom/linka/linkaapikit/module/model/Linka;", "")]
		public static unsafe global::Com.Linka.Linkaapikit.Module.Model.Linka MakeLinka (global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLEDevice item)
		{
			const string __id = "makeLinka.(Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLEDevice;)Lcom/linka/linkaapikit/module/model/Linka;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((item == null) ? IntPtr.Zero : ((global::Java.Lang.Object) item).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (item);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/method[@name='makeLinka' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("makeLinka", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/linka/linkaapikit/module/model/Linka;", "")]
		public static unsafe global::Com.Linka.Linkaapikit.Module.Model.Linka MakeLinka (string lock_address, string lock_name, string lock_mac_address)
		{
			const string __id = "makeLinka.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/linka/linkaapikit/module/model/Linka;";
			IntPtr native_lock_address = JNIEnv.NewString (lock_address);
			IntPtr native_lock_name = JNIEnv.NewString (lock_name);
			IntPtr native_lock_mac_address = JNIEnv.NewString (lock_mac_address);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_lock_address);
				__args [1] = new JniArgumentValue (native_lock_name);
				__args [2] = new JniArgumentValue (native_lock_mac_address);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_lock_address);
				JNIEnv.DeleteLocalRef (native_lock_name);
				JNIEnv.DeleteLocalRef (native_lock_mac_address);
			}
		}

		static Delegate cb_recordLockActivity_B;
#pragma warning disable 0169
		static Delegate GetRecordLockActivity_BHandler ()
		{
			if (cb_recordLockActivity_B == null)
				cb_recordLockActivity_B = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPB_V) n_RecordLockActivity_B);
			return cb_recordLockActivity_B;
		}

		static void n_RecordLockActivity_B (IntPtr jnienv, IntPtr native__this, sbyte state)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordLockActivity (state);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/method[@name='recordLockActivity' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("recordLockActivity", "(B)V", "GetRecordLockActivity_BHandler")]
		public virtual unsafe void RecordLockActivity (sbyte state)
		{
			const string __id = "recordLockActivity.(B)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (state);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_saveLatLng_Ljava_lang_Double_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSaveLatLng_Ljava_lang_Double_Ljava_lang_Double_Handler ()
		{
			if (cb_saveLatLng_Ljava_lang_Double_Ljava_lang_Double_ == null)
				cb_saveLatLng_Ljava_lang_Double_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SaveLatLng_Ljava_lang_Double_Ljava_lang_Double_);
			return cb_saveLatLng_Ljava_lang_Double_Ljava_lang_Double_;
		}

		static void n_SaveLatLng_Ljava_lang_Double_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_longitude, IntPtr native_latitude)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var longitude = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_longitude, JniHandleOwnership.DoNotTransfer);
			var latitude = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_latitude, JniHandleOwnership.DoNotTransfer);
			__this.SaveLatLng (longitude, latitude);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/method[@name='saveLatLng' and count(parameter)=2 and parameter[1][@type='java.lang.Double'] and parameter[2][@type='java.lang.Double']]"
		[Register ("saveLatLng", "(Ljava/lang/Double;Ljava/lang/Double;)V", "GetSaveLatLng_Ljava_lang_Double_Ljava_lang_Double_Handler")]
		public virtual unsafe void SaveLatLng (global::Java.Lang.Double longitude, global::Java.Lang.Double latitude)
		{
			const string __id = "saveLatLng.(Ljava/lang/Double;Ljava/lang/Double;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((longitude == null) ? IntPtr.Zero : ((global::Java.Lang.Object) longitude).Handle);
				__args [1] = new JniArgumentValue ((latitude == null) ? IntPtr.Zero : ((global::Java.Lang.Object) latitude).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (longitude);
				global::System.GC.KeepAlive (latitude);
			}
		}

		static Delegate cb_saveSettings;
#pragma warning disable 0169
		static Delegate GetSaveSettingsHandler ()
		{
			if (cb_saveSettings == null)
				cb_saveSettings = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_SaveSettings);
			return cb_saveSettings;
		}

		static bool n_SaveSettings (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SaveSettings ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/method[@name='saveSettings' and count(parameter)=0]"
		[Register ("saveSettings", "()Z", "GetSaveSettingsHandler")]
		public virtual unsafe bool SaveSettings ()
		{
			const string __id = "saveSettings.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setAdminKeys_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAdminKeys_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setAdminKeys_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setAdminKeys_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetAdminKeys_Ljava_lang_String_Ljava_lang_String_);
			return cb_setAdminKeys_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetAdminKeys_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_v2_access_key_admin_2, IntPtr native_access_key_admin_2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var v2_access_key_admin_2 = JNIEnv.GetString (native_v2_access_key_admin_2, JniHandleOwnership.DoNotTransfer);
			var access_key_admin_2 = JNIEnv.GetString (native_access_key_admin_2, JniHandleOwnership.DoNotTransfer);
			__this.SetAdminKeys (v2_access_key_admin_2, access_key_admin_2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/method[@name='setAdminKeys' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setAdminKeys", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetAdminKeys_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAdminKeys (string v2_access_key_admin_2, string access_key_admin_2)
		{
			const string __id = "setAdminKeys.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_v2_access_key_admin_2 = JNIEnv.NewString (v2_access_key_admin_2);
			IntPtr native_access_key_admin_2 = JNIEnv.NewString (access_key_admin_2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_v2_access_key_admin_2);
				__args [1] = new JniArgumentValue (native_access_key_admin_2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_v2_access_key_admin_2);
				JNIEnv.DeleteLocalRef (native_access_key_admin_2);
			}
		}

		static Delegate cb_updateBatteryPercent_I;
#pragma warning disable 0169
		static Delegate GetUpdateBatteryPercent_IHandler ()
		{
			if (cb_updateBatteryPercent_I == null)
				cb_updateBatteryPercent_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_UpdateBatteryPercent_I);
			return cb_updateBatteryPercent_I;
		}

		static void n_UpdateBatteryPercent_I (IntPtr jnienv, IntPtr native__this, int percent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateBatteryPercent (percent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/method[@name='updateBatteryPercent' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("updateBatteryPercent", "(I)V", "GetUpdateBatteryPercent_IHandler")]
		public virtual unsafe void UpdateBatteryPercent (int percent)
		{
			const string __id = "updateBatteryPercent.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (percent);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateRSSI_ZI;
#pragma warning disable 0169
		static Delegate GetUpdateRSSI_ZIHandler ()
		{
			if (cb_updateRSSI_ZI == null)
				cb_updateRSSI_ZI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZI_Z) n_UpdateRSSI_ZI);
			return cb_updateRSSI_ZI;
		}

		static bool n_UpdateRSSI_ZI (IntPtr jnienv, IntPtr native__this, bool discoverable, int rssi)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UpdateRSSI (discoverable, rssi);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='Linka']/method[@name='updateRSSI' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='int']]"
		[Register ("updateRSSI", "(ZI)Z", "GetUpdateRSSI_ZIHandler")]
		public virtual unsafe bool UpdateRSSI (bool discoverable, int rssi)
		{
			const string __id = "updateRSSI.(ZI)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (discoverable);
				__args [1] = new JniArgumentValue (rssi);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
