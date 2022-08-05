using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linka.Linkaapikit.Module.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']"
	[global::Android.Runtime.Register ("com/linka/linkaapikit/module/model/LockConnectionService", DoNotGenerateAcw=true)]
	public partial class LockConnectionService : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/field[@name='DisableAutomaticDisconnect']"
		[Register ("DisableAutomaticDisconnect")]
		public bool DisableAutomaticDisconnect {
			get {
				const string __id = "DisableAutomaticDisconnect.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "DisableAutomaticDisconnect.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/field[@name='scanFoundAnyDevice']"
		[Register ("scanFoundAnyDevice")]
		public bool ScanFoundAnyDevice {
			get {
				const string __id = "scanFoundAnyDevice.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "scanFoundAnyDevice.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/field[@name='write_setting_audio']"
		[Register ("write_setting_audio")]
		public int WriteSettingAudio {
			get {
				const string __id = "write_setting_audio.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "write_setting_audio.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/field[@name='write_setting_locked_sleep']"
		[Register ("write_setting_locked_sleep")]
		public int WriteSettingLockedSleep {
			get {
				const string __id = "write_setting_locked_sleep.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "write_setting_locked_sleep.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/field[@name='write_setting_pac']"
		[Register ("write_setting_pac")]
		public int WriteSettingPac {
			get {
				const string __id = "write_setting_pac.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "write_setting_pac.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/field[@name='write_setting_unlocked_sleep']"
		[Register ("write_setting_unlocked_sleep")]
		public int WriteSettingUnlockedSleep {
			get {
				const string __id = "write_setting_unlocked_sleep.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "write_setting_unlocked_sleep.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService.AUDIO']"
		[global::Android.Runtime.Register ("com/linka/linkaapikit/module/model/LockConnectionService$AUDIO", DoNotGenerateAcw=true)]
		public partial class AUDIO : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService.AUDIO']/field[@name='OFF']"
			[Register ("OFF")]
			public const int Off = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService.AUDIO']/field[@name='ON']"
			[Register ("ON")]
			public const int On = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService.AUDIO']/field[@name='SIREN_ONLY']"
			[Register ("SIREN_ONLY")]
			public const int SirenOnly = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService.AUDIO']/field[@name='TONES_ONLY']"
			[Register ("TONES_ONLY")]
			public const int TonesOnly = (int) 2;

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/model/LockConnectionService$AUDIO", typeof (AUDIO));

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

			protected AUDIO (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService.AUDIO']/constructor[@name='LockConnectionService.AUDIO' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.model.LockConnectionService']]"
			[Register (".ctor", "(Lcom/linka/linkaapikit/module/model/LockConnectionService;)V", "")]
			public unsafe AUDIO (global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (__self);
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.ErrorCallbacks']"
		[Register ("com/linka/linkaapikit/module/model/LockConnectionService$ErrorCallbacks", "", "Com.Linka.Linkaapikit.Module.Model.LockConnectionService/IErrorCallbacksInvoker")]
		public partial interface IErrorCallbacks : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.ErrorCallbacks']/method[@name='errorAppNotInForeground' and count(parameter)=0]"
			[Register ("errorAppNotInForeground", "()V", "GetErrorAppNotInForegroundHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/IErrorCallbacksInvoker, BindingLibrary.Android")]
			void ErrorAppNotInForeground ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.ErrorCallbacks']/method[@name='errorBluetoothOff' and count(parameter)=0]"
			[Register ("errorBluetoothOff", "()V", "GetErrorBluetoothOffHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/IErrorCallbacksInvoker, BindingLibrary.Android")]
			void ErrorBluetoothOff ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.ErrorCallbacks']/method[@name='errorConnectionTimeout' and count(parameter)=0]"
			[Register ("errorConnectionTimeout", "()V", "GetErrorConnectionTimeoutHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/IErrorCallbacksInvoker, BindingLibrary.Android")]
			void ErrorConnectionTimeout ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.ErrorCallbacks']/method[@name='errorEmptymacAddress' and count(parameter)=0]"
			[Register ("errorEmptymacAddress", "()V", "GetErrorEmptymacAddressHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/IErrorCallbacksInvoker, BindingLibrary.Android")]
			void ErrorEmptymacAddress ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.ErrorCallbacks']/method[@name='errorGpsOff' and count(parameter)=0]"
			[Register ("errorGpsOff", "()V", "GetErrorGpsOffHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/IErrorCallbacksInvoker, BindingLibrary.Android")]
			void ErrorGpsOff ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.ErrorCallbacks']/method[@name='errorInternetOff' and count(parameter)=0]"
			[Register ("errorInternetOff", "()V", "GetErrorInternetOffHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/IErrorCallbacksInvoker, BindingLibrary.Android")]
			void ErrorInternetOff ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.ErrorCallbacks']/method[@name='errorInvalidAccessToken' and count(parameter)=0]"
			[Register ("errorInvalidAccessToken", "()V", "GetErrorInvalidAccessTokenHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/IErrorCallbacksInvoker, BindingLibrary.Android")]
			void ErrorInvalidAccessToken ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.ErrorCallbacks']/method[@name='errorLocationOff' and count(parameter)=0]"
			[Register ("errorLocationOff", "()V", "GetErrorLocationOffHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/IErrorCallbacksInvoker, BindingLibrary.Android")]
			void ErrorLocationOff ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.ErrorCallbacks']/method[@name='errorLockBlock' and count(parameter)=0]"
			[Register ("errorLockBlock", "()V", "GetErrorLockBlockHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/IErrorCallbacksInvoker, BindingLibrary.Android")]
			void ErrorLockBlock ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.ErrorCallbacks']/method[@name='errorLockJam' and count(parameter)=0]"
			[Register ("errorLockJam", "()V", "GetErrorLockJamHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/IErrorCallbacksInvoker, BindingLibrary.Android")]
			void ErrorLockJam ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.ErrorCallbacks']/method[@name='errorLockStall' and count(parameter)=0]"
			[Register ("errorLockStall", "()V", "GetErrorLockStallHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/IErrorCallbacksInvoker, BindingLibrary.Android")]
			void ErrorLockStall ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.ErrorCallbacks']/method[@name='errorLockingTimeout' and count(parameter)=0]"
			[Register ("errorLockingTimeout", "()V", "GetErrorLockingTimeoutHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/IErrorCallbacksInvoker, BindingLibrary.Android")]
			void ErrorLockingTimeout ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.ErrorCallbacks']/method[@name='errorMacAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("errorMacAddress", "(Ljava/lang/String;)V", "GetErrorMacAddress_Ljava_lang_String_Handler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/IErrorCallbacksInvoker, BindingLibrary.Android")]
			void ErrorMacAddress (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.ErrorCallbacks']/method[@name='errorOther' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("errorOther", "(I)V", "GetErrorOther_IHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/IErrorCallbacksInvoker, BindingLibrary.Android")]
			void ErrorOther (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.ErrorCallbacks']/method[@name='errorUnexpectedDisconnect' and count(parameter)=0]"
			[Register ("errorUnexpectedDisconnect", "()V", "GetErrorUnexpectedDisconnectHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/IErrorCallbacksInvoker, BindingLibrary.Android")]
			void ErrorUnexpectedDisconnect ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.ErrorCallbacks']/method[@name='errorUnlockingTimeout' and count(parameter)=0]"
			[Register ("errorUnlockingTimeout", "()V", "GetErrorUnlockingTimeoutHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/IErrorCallbacksInvoker, BindingLibrary.Android")]
			void ErrorUnlockingTimeout ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.ErrorCallbacks']/method[@name='onInvalidMac' and count(parameter)=0]"
			[Register ("onInvalidMac", "()V", "GetOnInvalidMacHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/IErrorCallbacksInvoker, BindingLibrary.Android")]
			void OnInvalidMac ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.ErrorCallbacks']/method[@name='onScanTimeout' and count(parameter)=0]"
			[Register ("onScanTimeout", "()V", "GetOnScanTimeoutHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/IErrorCallbacksInvoker, BindingLibrary.Android")]
			void OnScanTimeout ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.ErrorCallbacks']/method[@name='pairTimeout' and count(parameter)=0]"
			[Register ("pairTimeout", "()V", "GetPairTimeoutHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/IErrorCallbacksInvoker, BindingLibrary.Android")]
			void PairTimeout ();

		}

		[global::Android.Runtime.Register ("com/linka/linkaapikit/module/model/LockConnectionService$ErrorCallbacks", DoNotGenerateAcw=true)]
		internal partial class IErrorCallbacksInvoker : global::Java.Lang.Object, IErrorCallbacks {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/model/LockConnectionService$ErrorCallbacks", typeof (IErrorCallbacksInvoker));

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

			public static IErrorCallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IErrorCallbacks> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linka.linkaapikit.module.model.LockConnectionService.ErrorCallbacks'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IErrorCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_errorAppNotInForeground;
#pragma warning disable 0169
			static Delegate GetErrorAppNotInForegroundHandler ()
			{
				if (cb_errorAppNotInForeground == null)
					cb_errorAppNotInForeground = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ErrorAppNotInForeground);
				return cb_errorAppNotInForeground;
			}

			static void n_ErrorAppNotInForeground (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.IErrorCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ErrorAppNotInForeground ();
			}
#pragma warning restore 0169

			IntPtr id_errorAppNotInForeground;
			public unsafe void ErrorAppNotInForeground ()
			{
				if (id_errorAppNotInForeground == IntPtr.Zero)
					id_errorAppNotInForeground = JNIEnv.GetMethodID (class_ref, "errorAppNotInForeground", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_errorAppNotInForeground);
			}

			static Delegate cb_errorBluetoothOff;
#pragma warning disable 0169
			static Delegate GetErrorBluetoothOffHandler ()
			{
				if (cb_errorBluetoothOff == null)
					cb_errorBluetoothOff = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ErrorBluetoothOff);
				return cb_errorBluetoothOff;
			}

			static void n_ErrorBluetoothOff (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.IErrorCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ErrorBluetoothOff ();
			}
#pragma warning restore 0169

			IntPtr id_errorBluetoothOff;
			public unsafe void ErrorBluetoothOff ()
			{
				if (id_errorBluetoothOff == IntPtr.Zero)
					id_errorBluetoothOff = JNIEnv.GetMethodID (class_ref, "errorBluetoothOff", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_errorBluetoothOff);
			}

			static Delegate cb_errorConnectionTimeout;
#pragma warning disable 0169
			static Delegate GetErrorConnectionTimeoutHandler ()
			{
				if (cb_errorConnectionTimeout == null)
					cb_errorConnectionTimeout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ErrorConnectionTimeout);
				return cb_errorConnectionTimeout;
			}

			static void n_ErrorConnectionTimeout (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.IErrorCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ErrorConnectionTimeout ();
			}
#pragma warning restore 0169

			IntPtr id_errorConnectionTimeout;
			public unsafe void ErrorConnectionTimeout ()
			{
				if (id_errorConnectionTimeout == IntPtr.Zero)
					id_errorConnectionTimeout = JNIEnv.GetMethodID (class_ref, "errorConnectionTimeout", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_errorConnectionTimeout);
			}

			static Delegate cb_errorEmptymacAddress;
#pragma warning disable 0169
			static Delegate GetErrorEmptymacAddressHandler ()
			{
				if (cb_errorEmptymacAddress == null)
					cb_errorEmptymacAddress = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ErrorEmptymacAddress);
				return cb_errorEmptymacAddress;
			}

			static void n_ErrorEmptymacAddress (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.IErrorCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ErrorEmptymacAddress ();
			}
#pragma warning restore 0169

			IntPtr id_errorEmptymacAddress;
			public unsafe void ErrorEmptymacAddress ()
			{
				if (id_errorEmptymacAddress == IntPtr.Zero)
					id_errorEmptymacAddress = JNIEnv.GetMethodID (class_ref, "errorEmptymacAddress", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_errorEmptymacAddress);
			}

			static Delegate cb_errorGpsOff;
#pragma warning disable 0169
			static Delegate GetErrorGpsOffHandler ()
			{
				if (cb_errorGpsOff == null)
					cb_errorGpsOff = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ErrorGpsOff);
				return cb_errorGpsOff;
			}

			static void n_ErrorGpsOff (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.IErrorCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ErrorGpsOff ();
			}
#pragma warning restore 0169

			IntPtr id_errorGpsOff;
			public unsafe void ErrorGpsOff ()
			{
				if (id_errorGpsOff == IntPtr.Zero)
					id_errorGpsOff = JNIEnv.GetMethodID (class_ref, "errorGpsOff", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_errorGpsOff);
			}

			static Delegate cb_errorInternetOff;
#pragma warning disable 0169
			static Delegate GetErrorInternetOffHandler ()
			{
				if (cb_errorInternetOff == null)
					cb_errorInternetOff = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ErrorInternetOff);
				return cb_errorInternetOff;
			}

			static void n_ErrorInternetOff (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.IErrorCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ErrorInternetOff ();
			}
#pragma warning restore 0169

			IntPtr id_errorInternetOff;
			public unsafe void ErrorInternetOff ()
			{
				if (id_errorInternetOff == IntPtr.Zero)
					id_errorInternetOff = JNIEnv.GetMethodID (class_ref, "errorInternetOff", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_errorInternetOff);
			}

			static Delegate cb_errorInvalidAccessToken;
#pragma warning disable 0169
			static Delegate GetErrorInvalidAccessTokenHandler ()
			{
				if (cb_errorInvalidAccessToken == null)
					cb_errorInvalidAccessToken = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ErrorInvalidAccessToken);
				return cb_errorInvalidAccessToken;
			}

			static void n_ErrorInvalidAccessToken (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.IErrorCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ErrorInvalidAccessToken ();
			}
#pragma warning restore 0169

			IntPtr id_errorInvalidAccessToken;
			public unsafe void ErrorInvalidAccessToken ()
			{
				if (id_errorInvalidAccessToken == IntPtr.Zero)
					id_errorInvalidAccessToken = JNIEnv.GetMethodID (class_ref, "errorInvalidAccessToken", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_errorInvalidAccessToken);
			}

			static Delegate cb_errorLocationOff;
#pragma warning disable 0169
			static Delegate GetErrorLocationOffHandler ()
			{
				if (cb_errorLocationOff == null)
					cb_errorLocationOff = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ErrorLocationOff);
				return cb_errorLocationOff;
			}

			static void n_ErrorLocationOff (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.IErrorCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ErrorLocationOff ();
			}
#pragma warning restore 0169

			IntPtr id_errorLocationOff;
			public unsafe void ErrorLocationOff ()
			{
				if (id_errorLocationOff == IntPtr.Zero)
					id_errorLocationOff = JNIEnv.GetMethodID (class_ref, "errorLocationOff", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_errorLocationOff);
			}

			static Delegate cb_errorLockBlock;
#pragma warning disable 0169
			static Delegate GetErrorLockBlockHandler ()
			{
				if (cb_errorLockBlock == null)
					cb_errorLockBlock = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ErrorLockBlock);
				return cb_errorLockBlock;
			}

			static void n_ErrorLockBlock (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.IErrorCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ErrorLockBlock ();
			}
#pragma warning restore 0169

			IntPtr id_errorLockBlock;
			public unsafe void ErrorLockBlock ()
			{
				if (id_errorLockBlock == IntPtr.Zero)
					id_errorLockBlock = JNIEnv.GetMethodID (class_ref, "errorLockBlock", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_errorLockBlock);
			}

			static Delegate cb_errorLockJam;
#pragma warning disable 0169
			static Delegate GetErrorLockJamHandler ()
			{
				if (cb_errorLockJam == null)
					cb_errorLockJam = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ErrorLockJam);
				return cb_errorLockJam;
			}

			static void n_ErrorLockJam (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.IErrorCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ErrorLockJam ();
			}
#pragma warning restore 0169

			IntPtr id_errorLockJam;
			public unsafe void ErrorLockJam ()
			{
				if (id_errorLockJam == IntPtr.Zero)
					id_errorLockJam = JNIEnv.GetMethodID (class_ref, "errorLockJam", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_errorLockJam);
			}

			static Delegate cb_errorLockStall;
#pragma warning disable 0169
			static Delegate GetErrorLockStallHandler ()
			{
				if (cb_errorLockStall == null)
					cb_errorLockStall = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ErrorLockStall);
				return cb_errorLockStall;
			}

			static void n_ErrorLockStall (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.IErrorCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ErrorLockStall ();
			}
#pragma warning restore 0169

			IntPtr id_errorLockStall;
			public unsafe void ErrorLockStall ()
			{
				if (id_errorLockStall == IntPtr.Zero)
					id_errorLockStall = JNIEnv.GetMethodID (class_ref, "errorLockStall", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_errorLockStall);
			}

			static Delegate cb_errorLockingTimeout;
#pragma warning disable 0169
			static Delegate GetErrorLockingTimeoutHandler ()
			{
				if (cb_errorLockingTimeout == null)
					cb_errorLockingTimeout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ErrorLockingTimeout);
				return cb_errorLockingTimeout;
			}

			static void n_ErrorLockingTimeout (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.IErrorCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ErrorLockingTimeout ();
			}
#pragma warning restore 0169

			IntPtr id_errorLockingTimeout;
			public unsafe void ErrorLockingTimeout ()
			{
				if (id_errorLockingTimeout == IntPtr.Zero)
					id_errorLockingTimeout = JNIEnv.GetMethodID (class_ref, "errorLockingTimeout", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_errorLockingTimeout);
			}

			static Delegate cb_errorMacAddress_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetErrorMacAddress_Ljava_lang_String_Handler ()
			{
				if (cb_errorMacAddress_Ljava_lang_String_ == null)
					cb_errorMacAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ErrorMacAddress_Ljava_lang_String_);
				return cb_errorMacAddress_Ljava_lang_String_;
			}

			static void n_ErrorMacAddress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.IErrorCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ErrorMacAddress (p0);
			}
#pragma warning restore 0169

			IntPtr id_errorMacAddress_Ljava_lang_String_;
			public unsafe void ErrorMacAddress (string p0)
			{
				if (id_errorMacAddress_Ljava_lang_String_ == IntPtr.Zero)
					id_errorMacAddress_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "errorMacAddress", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_errorMacAddress_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_errorOther_I;
#pragma warning disable 0169
			static Delegate GetErrorOther_IHandler ()
			{
				if (cb_errorOther_I == null)
					cb_errorOther_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_ErrorOther_I);
				return cb_errorOther_I;
			}

			static void n_ErrorOther_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.IErrorCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ErrorOther (p0);
			}
#pragma warning restore 0169

			IntPtr id_errorOther_I;
			public unsafe void ErrorOther (int p0)
			{
				if (id_errorOther_I == IntPtr.Zero)
					id_errorOther_I = JNIEnv.GetMethodID (class_ref, "errorOther", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_errorOther_I, __args);
			}

			static Delegate cb_errorUnexpectedDisconnect;
#pragma warning disable 0169
			static Delegate GetErrorUnexpectedDisconnectHandler ()
			{
				if (cb_errorUnexpectedDisconnect == null)
					cb_errorUnexpectedDisconnect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ErrorUnexpectedDisconnect);
				return cb_errorUnexpectedDisconnect;
			}

			static void n_ErrorUnexpectedDisconnect (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.IErrorCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ErrorUnexpectedDisconnect ();
			}
#pragma warning restore 0169

			IntPtr id_errorUnexpectedDisconnect;
			public unsafe void ErrorUnexpectedDisconnect ()
			{
				if (id_errorUnexpectedDisconnect == IntPtr.Zero)
					id_errorUnexpectedDisconnect = JNIEnv.GetMethodID (class_ref, "errorUnexpectedDisconnect", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_errorUnexpectedDisconnect);
			}

			static Delegate cb_errorUnlockingTimeout;
#pragma warning disable 0169
			static Delegate GetErrorUnlockingTimeoutHandler ()
			{
				if (cb_errorUnlockingTimeout == null)
					cb_errorUnlockingTimeout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ErrorUnlockingTimeout);
				return cb_errorUnlockingTimeout;
			}

			static void n_ErrorUnlockingTimeout (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.IErrorCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ErrorUnlockingTimeout ();
			}
#pragma warning restore 0169

			IntPtr id_errorUnlockingTimeout;
			public unsafe void ErrorUnlockingTimeout ()
			{
				if (id_errorUnlockingTimeout == IntPtr.Zero)
					id_errorUnlockingTimeout = JNIEnv.GetMethodID (class_ref, "errorUnlockingTimeout", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_errorUnlockingTimeout);
			}

			static Delegate cb_onInvalidMac;
#pragma warning disable 0169
			static Delegate GetOnInvalidMacHandler ()
			{
				if (cb_onInvalidMac == null)
					cb_onInvalidMac = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnInvalidMac);
				return cb_onInvalidMac;
			}

			static void n_OnInvalidMac (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.IErrorCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnInvalidMac ();
			}
#pragma warning restore 0169

			IntPtr id_onInvalidMac;
			public unsafe void OnInvalidMac ()
			{
				if (id_onInvalidMac == IntPtr.Zero)
					id_onInvalidMac = JNIEnv.GetMethodID (class_ref, "onInvalidMac", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInvalidMac);
			}

			static Delegate cb_onScanTimeout;
#pragma warning disable 0169
			static Delegate GetOnScanTimeoutHandler ()
			{
				if (cb_onScanTimeout == null)
					cb_onScanTimeout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnScanTimeout);
				return cb_onScanTimeout;
			}

			static void n_OnScanTimeout (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.IErrorCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnScanTimeout ();
			}
#pragma warning restore 0169

			IntPtr id_onScanTimeout;
			public unsafe void OnScanTimeout ()
			{
				if (id_onScanTimeout == IntPtr.Zero)
					id_onScanTimeout = JNIEnv.GetMethodID (class_ref, "onScanTimeout", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScanTimeout);
			}

			static Delegate cb_pairTimeout;
#pragma warning disable 0169
			static Delegate GetPairTimeoutHandler ()
			{
				if (cb_pairTimeout == null)
					cb_pairTimeout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_PairTimeout);
				return cb_pairTimeout;
			}

			static void n_PairTimeout (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.IErrorCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.PairTimeout ();
			}
#pragma warning restore 0169

			IntPtr id_pairTimeout;
			public unsafe void PairTimeout ()
			{
				if (id_pairTimeout == IntPtr.Zero)
					id_pairTimeout = JNIEnv.GetMethodID (class_ref, "pairTimeout", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pairTimeout);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService.ERROR_OTHER']"
		[global::Android.Runtime.Register ("com/linka/linkaapikit/module/model/LockConnectionService$ERROR_OTHER", DoNotGenerateAcw=true)]
		public partial class ERROR_OTHER : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService.ERROR_OTHER']/field[@name='BLUETOOTH_PERMISSION_REQUIRED']"
			[Register ("BLUETOOTH_PERMISSION_REQUIRED")]
			public const int BluetoothPermissionRequired = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService.ERROR_OTHER']/field[@name='ERROR_LOCK_FACTORY_RESET']"
			[Register ("ERROR_LOCK_FACTORY_RESET")]
			public const int ErrorLockFactoryReset = (int) 11;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService.ERROR_OTHER']/field[@name='ERROR_LOCK_KEY_ISSUE']"
			[Register ("ERROR_LOCK_KEY_ISSUE")]
			public const int ErrorLockKeyIssue = (int) 12;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService.ERROR_OTHER']/field[@name='SCAN_START_ERROR']"
			[Register ("SCAN_START_ERROR")]
			public const int ScanStartError = (int) 1;

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/model/LockConnectionService$ERROR_OTHER", typeof (ERROR_OTHER));

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

			protected ERROR_OTHER (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService.ERROR_OTHER']/constructor[@name='LockConnectionService.ERROR_OTHER' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ERROR_OTHER () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.LockStatusCallback']"
		[Register ("com/linka/linkaapikit/module/model/LockConnectionService$LockStatusCallback", "", "Com.Linka.Linkaapikit.Module.Model.LockConnectionService/ILockStatusCallbackInvoker")]
		public partial interface ILockStatusCallback : IJavaObject, IJavaPeerable {
		}

		[global::Android.Runtime.Register ("com/linka/linkaapikit/module/model/LockConnectionService$LockStatusCallback", DoNotGenerateAcw=true)]
		internal partial class ILockStatusCallbackInvoker : global::Java.Lang.Object, ILockStatusCallback {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/model/LockConnectionService$LockStatusCallback", typeof (ILockStatusCallbackInvoker));

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

			public static ILockStatusCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ILockStatusCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linka.linkaapikit.module.model.LockConnectionService.LockStatusCallback'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ILockStatusCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.SuccessCallbacks']"
		[Register ("com/linka/linkaapikit/module/model/LockConnectionService$SuccessCallbacks", "", "Com.Linka.Linkaapikit.Module.Model.LockConnectionService/ISuccessCallbacksInvoker")]
		public partial interface ISuccessCallbacks : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.SuccessCallbacks']/method[@name='onBatteryPercent' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onBatteryPercent", "(I)V", "GetOnBatteryPercent_IHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/ISuccessCallbacksInvoker, BindingLibrary.Android")]
			void OnBatteryPercent (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.SuccessCallbacks']/method[@name='onConnected' and count(parameter)=0]"
			[Register ("onConnected", "()V", "GetOnConnectedHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/ISuccessCallbacksInvoker, BindingLibrary.Android")]
			void OnConnected ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.SuccessCallbacks']/method[@name='onLock' and count(parameter)=0]"
			[Register ("onLock", "()V", "GetOnLockHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/ISuccessCallbacksInvoker, BindingLibrary.Android")]
			void OnLock ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.SuccessCallbacks']/method[@name='onLockStarted' and count(parameter)=0]"
			[Register ("onLockStarted", "()V", "GetOnLockStartedHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/ISuccessCallbacksInvoker, BindingLibrary.Android")]
			void OnLockStarted ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.SuccessCallbacks']/method[@name='onPairingSuccess' and count(parameter)=0]"
			[Register ("onPairingSuccess", "()V", "GetOnPairingSuccessHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/ISuccessCallbacksInvoker, BindingLibrary.Android")]
			void OnPairingSuccess ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.SuccessCallbacks']/method[@name='onQueryLocked' and count(parameter)=0]"
			[Register ("onQueryLocked", "()V", "GetOnQueryLockedHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/ISuccessCallbacksInvoker, BindingLibrary.Android")]
			void OnQueryLocked ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.SuccessCallbacks']/method[@name='onQueryUnlocked' and count(parameter)=0]"
			[Register ("onQueryUnlocked", "()V", "GetOnQueryUnlockedHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/ISuccessCallbacksInvoker, BindingLibrary.Android")]
			void OnQueryUnlocked ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.SuccessCallbacks']/method[@name='onScanFound' and count(parameter)=0]"
			[Register ("onScanFound", "()V", "GetOnScanFoundHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/ISuccessCallbacksInvoker, BindingLibrary.Android")]
			void OnScanFound ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.SuccessCallbacks']/method[@name='onUnlock' and count(parameter)=0]"
			[Register ("onUnlock", "()V", "GetOnUnlockHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/ISuccessCallbacksInvoker, BindingLibrary.Android")]
			void OnUnlock ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='LockConnectionService.SuccessCallbacks']/method[@name='onUnlockStarted' and count(parameter)=0]"
			[Register ("onUnlockStarted", "()V", "GetOnUnlockStartedHandler:Com.Linka.Linkaapikit.Module.Model.LockConnectionService/ISuccessCallbacksInvoker, BindingLibrary.Android")]
			void OnUnlockStarted ();

		}

		[global::Android.Runtime.Register ("com/linka/linkaapikit/module/model/LockConnectionService$SuccessCallbacks", DoNotGenerateAcw=true)]
		internal partial class ISuccessCallbacksInvoker : global::Java.Lang.Object, ISuccessCallbacks {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/model/LockConnectionService$SuccessCallbacks", typeof (ISuccessCallbacksInvoker));

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

			public static ISuccessCallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISuccessCallbacks> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linka.linkaapikit.module.model.LockConnectionService.SuccessCallbacks'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISuccessCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onBatteryPercent_I;
#pragma warning disable 0169
			static Delegate GetOnBatteryPercent_IHandler ()
			{
				if (cb_onBatteryPercent_I == null)
					cb_onBatteryPercent_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnBatteryPercent_I);
				return cb_onBatteryPercent_I;
			}

			static void n_OnBatteryPercent_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.ISuccessCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnBatteryPercent (p0);
			}
#pragma warning restore 0169

			IntPtr id_onBatteryPercent_I;
			public unsafe void OnBatteryPercent (int p0)
			{
				if (id_onBatteryPercent_I == IntPtr.Zero)
					id_onBatteryPercent_I = JNIEnv.GetMethodID (class_ref, "onBatteryPercent", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBatteryPercent_I, __args);
			}

			static Delegate cb_onConnected;
#pragma warning disable 0169
			static Delegate GetOnConnectedHandler ()
			{
				if (cb_onConnected == null)
					cb_onConnected = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnConnected);
				return cb_onConnected;
			}

			static void n_OnConnected (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.ISuccessCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnConnected ();
			}
#pragma warning restore 0169

			IntPtr id_onConnected;
			public unsafe void OnConnected ()
			{
				if (id_onConnected == IntPtr.Zero)
					id_onConnected = JNIEnv.GetMethodID (class_ref, "onConnected", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnected);
			}

			static Delegate cb_onLock;
#pragma warning disable 0169
			static Delegate GetOnLockHandler ()
			{
				if (cb_onLock == null)
					cb_onLock = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnLock);
				return cb_onLock;
			}

			static void n_OnLock (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.ISuccessCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnLock ();
			}
#pragma warning restore 0169

			IntPtr id_onLock;
			public unsafe void OnLock ()
			{
				if (id_onLock == IntPtr.Zero)
					id_onLock = JNIEnv.GetMethodID (class_ref, "onLock", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLock);
			}

			static Delegate cb_onLockStarted;
#pragma warning disable 0169
			static Delegate GetOnLockStartedHandler ()
			{
				if (cb_onLockStarted == null)
					cb_onLockStarted = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnLockStarted);
				return cb_onLockStarted;
			}

			static void n_OnLockStarted (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.ISuccessCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnLockStarted ();
			}
#pragma warning restore 0169

			IntPtr id_onLockStarted;
			public unsafe void OnLockStarted ()
			{
				if (id_onLockStarted == IntPtr.Zero)
					id_onLockStarted = JNIEnv.GetMethodID (class_ref, "onLockStarted", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLockStarted);
			}

			static Delegate cb_onPairingSuccess;
#pragma warning disable 0169
			static Delegate GetOnPairingSuccessHandler ()
			{
				if (cb_onPairingSuccess == null)
					cb_onPairingSuccess = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnPairingSuccess);
				return cb_onPairingSuccess;
			}

			static void n_OnPairingSuccess (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.ISuccessCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPairingSuccess ();
			}
#pragma warning restore 0169

			IntPtr id_onPairingSuccess;
			public unsafe void OnPairingSuccess ()
			{
				if (id_onPairingSuccess == IntPtr.Zero)
					id_onPairingSuccess = JNIEnv.GetMethodID (class_ref, "onPairingSuccess", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPairingSuccess);
			}

			static Delegate cb_onQueryLocked;
#pragma warning disable 0169
			static Delegate GetOnQueryLockedHandler ()
			{
				if (cb_onQueryLocked == null)
					cb_onQueryLocked = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnQueryLocked);
				return cb_onQueryLocked;
			}

			static void n_OnQueryLocked (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.ISuccessCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnQueryLocked ();
			}
#pragma warning restore 0169

			IntPtr id_onQueryLocked;
			public unsafe void OnQueryLocked ()
			{
				if (id_onQueryLocked == IntPtr.Zero)
					id_onQueryLocked = JNIEnv.GetMethodID (class_ref, "onQueryLocked", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onQueryLocked);
			}

			static Delegate cb_onQueryUnlocked;
#pragma warning disable 0169
			static Delegate GetOnQueryUnlockedHandler ()
			{
				if (cb_onQueryUnlocked == null)
					cb_onQueryUnlocked = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnQueryUnlocked);
				return cb_onQueryUnlocked;
			}

			static void n_OnQueryUnlocked (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.ISuccessCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnQueryUnlocked ();
			}
#pragma warning restore 0169

			IntPtr id_onQueryUnlocked;
			public unsafe void OnQueryUnlocked ()
			{
				if (id_onQueryUnlocked == IntPtr.Zero)
					id_onQueryUnlocked = JNIEnv.GetMethodID (class_ref, "onQueryUnlocked", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onQueryUnlocked);
			}

			static Delegate cb_onScanFound;
#pragma warning disable 0169
			static Delegate GetOnScanFoundHandler ()
			{
				if (cb_onScanFound == null)
					cb_onScanFound = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnScanFound);
				return cb_onScanFound;
			}

			static void n_OnScanFound (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.ISuccessCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnScanFound ();
			}
#pragma warning restore 0169

			IntPtr id_onScanFound;
			public unsafe void OnScanFound ()
			{
				if (id_onScanFound == IntPtr.Zero)
					id_onScanFound = JNIEnv.GetMethodID (class_ref, "onScanFound", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScanFound);
			}

			static Delegate cb_onUnlock;
#pragma warning disable 0169
			static Delegate GetOnUnlockHandler ()
			{
				if (cb_onUnlock == null)
					cb_onUnlock = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnUnlock);
				return cb_onUnlock;
			}

			static void n_OnUnlock (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.ISuccessCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnUnlock ();
			}
#pragma warning restore 0169

			IntPtr id_onUnlock;
			public unsafe void OnUnlock ()
			{
				if (id_onUnlock == IntPtr.Zero)
					id_onUnlock = JNIEnv.GetMethodID (class_ref, "onUnlock", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnlock);
			}

			static Delegate cb_onUnlockStarted;
#pragma warning disable 0169
			static Delegate GetOnUnlockStartedHandler ()
			{
				if (cb_onUnlockStarted == null)
					cb_onUnlockStarted = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnUnlockStarted);
				return cb_onUnlockStarted;
			}

			static void n_OnUnlockStarted (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.ISuccessCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnUnlockStarted ();
			}
#pragma warning restore 0169

			IntPtr id_onUnlockStarted;
			public unsafe void OnUnlockStarted ()
			{
				if (id_onUnlockStarted == IntPtr.Zero)
					id_onUnlockStarted = JNIEnv.GetMethodID (class_ref, "onUnlockStarted", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnlockStarted);
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/model/LockConnectionService", typeof (LockConnectionService));

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

		protected LockConnectionService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/constructor[@name='LockConnectionService' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.linka.linkaapikit.module.model.LockConnectionService.SuccessCallbacks'] and parameter[3][@type='com.linka.linkaapikit.module.model.LockConnectionService.ErrorCallbacks']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/linka/linkaapikit/module/model/LockConnectionService$SuccessCallbacks;Lcom/linka/linkaapikit/module/model/LockConnectionService$ErrorCallbacks;)V", "")]
		public unsafe LockConnectionService (global::Android.Content.Context context, global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.ISuccessCallbacks connecting, global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.IErrorCallbacks errorCallbacks) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/linka/linkaapikit/module/model/LockConnectionService$SuccessCallbacks;Lcom/linka/linkaapikit/module/model/LockConnectionService$ErrorCallbacks;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((connecting == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connecting).Handle);
				__args [2] = new JniArgumentValue ((errorCallbacks == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorCallbacks).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (connecting);
				global::System.GC.KeepAlive (errorCallbacks);
			}
		}

		static Delegate cb_getFwVersion;
#pragma warning disable 0169
		static Delegate GetGetFwVersionHandler ()
		{
			if (cb_getFwVersion == null)
				cb_getFwVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFwVersion);
			return cb_getFwVersion;
		}

		static IntPtr n_GetFwVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FwVersion);
		}
#pragma warning restore 0169

		public virtual unsafe string FwVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='getFwVersion' and count(parameter)=0]"
			[Register ("getFwVersion", "()Ljava/lang/String;", "GetGetFwVersionHandler")]
			get {
				const string __id = "getFwVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isCharging;
#pragma warning disable 0169
		static Delegate GetIsChargingHandler ()
		{
			if (cb_isCharging == null)
				cb_isCharging = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCharging);
			return cb_isCharging;
		}

		static bool n_IsCharging (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCharging;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsCharging {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='isCharging' and count(parameter)=0]"
			[Register ("isCharging", "()Z", "GetIsChargingHandler")]
			get {
				const string __id = "isCharging.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isTether;
#pragma warning disable 0169
		static Delegate GetIsTetherHandler ()
		{
			if (cb_isTether == null)
				cb_isTether = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsTether);
			return cb_isTether;
		}

		static bool n_IsTether (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTether;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsTether {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='isTether' and count(parameter)=0]"
			[Register ("isTether", "()Z", "GetIsTetherHandler")]
			get {
				const string __id = "isTether.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLockLog;
#pragma warning disable 0169
		static Delegate GetGetLockLogHandler ()
		{
			if (cb_getLockLog == null)
				cb_getLockLog = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLockLog);
			return cb_getLockLog;
		}

		static IntPtr n_GetLockLog (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LockLog);
		}
#pragma warning restore 0169

		public virtual unsafe string LockLog {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='getLockLog' and count(parameter)=0]"
			[Register ("getLockLog", "()Ljava/lang/String;", "GetGetLockLogHandler")]
			get {
				const string __id = "getLockLog.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWrite_setting_audio;
#pragma warning disable 0169
		static Delegate GetGetWrite_setting_audioHandler ()
		{
			if (cb_getWrite_setting_audio == null)
				cb_getWrite_setting_audio = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetWrite_setting_audio);
			return cb_getWrite_setting_audio;
		}

		static int n_GetWrite_setting_audio (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Write_setting_audio;
		}
#pragma warning restore 0169

		static Delegate cb_setWrite_setting_audio_I;
#pragma warning disable 0169
		static Delegate GetSetWrite_setting_audio_IHandler ()
		{
			if (cb_setWrite_setting_audio_I == null)
				cb_setWrite_setting_audio_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetWrite_setting_audio_I);
			return cb_setWrite_setting_audio_I;
		}

		static void n_SetWrite_setting_audio_I (IntPtr jnienv, IntPtr native__this, int write_setting_audio)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write_setting_audio = write_setting_audio;
		}
#pragma warning restore 0169

		public virtual unsafe int Write_setting_audio {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='getWrite_setting_audio' and count(parameter)=0]"
			[Register ("getWrite_setting_audio", "()I", "GetGetWrite_setting_audioHandler")]
			get {
				const string __id = "getWrite_setting_audio.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='setWrite_setting_audio' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWrite_setting_audio", "(I)V", "GetSetWrite_setting_audio_IHandler")]
			set {
				const string __id = "setWrite_setting_audio.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWrite_setting_locked_sleep;
#pragma warning disable 0169
		static Delegate GetGetWrite_setting_locked_sleepHandler ()
		{
			if (cb_getWrite_setting_locked_sleep == null)
				cb_getWrite_setting_locked_sleep = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetWrite_setting_locked_sleep);
			return cb_getWrite_setting_locked_sleep;
		}

		static int n_GetWrite_setting_locked_sleep (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Write_setting_locked_sleep;
		}
#pragma warning restore 0169

		static Delegate cb_setWrite_setting_locked_sleep_I;
#pragma warning disable 0169
		static Delegate GetSetWrite_setting_locked_sleep_IHandler ()
		{
			if (cb_setWrite_setting_locked_sleep_I == null)
				cb_setWrite_setting_locked_sleep_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetWrite_setting_locked_sleep_I);
			return cb_setWrite_setting_locked_sleep_I;
		}

		static void n_SetWrite_setting_locked_sleep_I (IntPtr jnienv, IntPtr native__this, int write_setting_locked_sleep)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write_setting_locked_sleep = write_setting_locked_sleep;
		}
#pragma warning restore 0169

		public virtual unsafe int Write_setting_locked_sleep {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='getWrite_setting_locked_sleep' and count(parameter)=0]"
			[Register ("getWrite_setting_locked_sleep", "()I", "GetGetWrite_setting_locked_sleepHandler")]
			get {
				const string __id = "getWrite_setting_locked_sleep.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='setWrite_setting_locked_sleep' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWrite_setting_locked_sleep", "(I)V", "GetSetWrite_setting_locked_sleep_IHandler")]
			set {
				const string __id = "setWrite_setting_locked_sleep.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWrite_setting_unlocked_sleep;
#pragma warning disable 0169
		static Delegate GetGetWrite_setting_unlocked_sleepHandler ()
		{
			if (cb_getWrite_setting_unlocked_sleep == null)
				cb_getWrite_setting_unlocked_sleep = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetWrite_setting_unlocked_sleep);
			return cb_getWrite_setting_unlocked_sleep;
		}

		static int n_GetWrite_setting_unlocked_sleep (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Write_setting_unlocked_sleep;
		}
#pragma warning restore 0169

		static Delegate cb_setWrite_setting_unlocked_sleep_I;
#pragma warning disable 0169
		static Delegate GetSetWrite_setting_unlocked_sleep_IHandler ()
		{
			if (cb_setWrite_setting_unlocked_sleep_I == null)
				cb_setWrite_setting_unlocked_sleep_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetWrite_setting_unlocked_sleep_I);
			return cb_setWrite_setting_unlocked_sleep_I;
		}

		static void n_SetWrite_setting_unlocked_sleep_I (IntPtr jnienv, IntPtr native__this, int write_setting_unlocked_sleep)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write_setting_unlocked_sleep = write_setting_unlocked_sleep;
		}
#pragma warning restore 0169

		public virtual unsafe int Write_setting_unlocked_sleep {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='getWrite_setting_unlocked_sleep' and count(parameter)=0]"
			[Register ("getWrite_setting_unlocked_sleep", "()I", "GetGetWrite_setting_unlocked_sleepHandler")]
			get {
				const string __id = "getWrite_setting_unlocked_sleep.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='setWrite_setting_unlocked_sleep' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWrite_setting_unlocked_sleep", "(I)V", "GetSetWrite_setting_unlocked_sleep_IHandler")]
			set {
				const string __id = "setWrite_setting_unlocked_sleep.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_beginDebugLockLog;
#pragma warning disable 0169
		static Delegate GetBeginDebugLockLogHandler ()
		{
			if (cb_beginDebugLockLog == null)
				cb_beginDebugLockLog = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_BeginDebugLockLog);
			return cb_beginDebugLockLog;
		}

		static void n_BeginDebugLockLog (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BeginDebugLockLog ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='beginDebugLockLog' and count(parameter)=0]"
		[Register ("beginDebugLockLog", "()V", "GetBeginDebugLockLogHandler")]
		public virtual unsafe void BeginDebugLockLog ()
		{
			const string __id = "beginDebugLockLog.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_checkIsConnected;
#pragma warning disable 0169
		static Delegate GetCheckIsConnectedHandler ()
		{
			if (cb_checkIsConnected == null)
				cb_checkIsConnected = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_CheckIsConnected);
			return cb_checkIsConnected;
		}

		static bool n_CheckIsConnected (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckIsConnected ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='checkIsConnected' and count(parameter)=0]"
		[Register ("checkIsConnected", "()Z", "GetCheckIsConnectedHandler")]
		public virtual unsafe bool CheckIsConnected ()
		{
			const string __id = "checkIsConnected.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doFwUpgrade;
#pragma warning disable 0169
		static Delegate GetDoFwUpgradeHandler ()
		{
			if (cb_doFwUpgrade == null)
				cb_doFwUpgrade = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_DoFwUpgrade);
			return cb_doFwUpgrade;
		}

		static IntPtr n_DoFwUpgrade (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DoFwUpgrade ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='doFwUpgrade' and count(parameter)=0]"
		[Register ("doFwUpgrade", "()Lcom/linka/linkaapikit/module/widget/LockController;", "GetDoFwUpgradeHandler")]
		public virtual unsafe global::Com.Linka.Linkaapikit.Module.Widget.LockController DoFwUpgrade ()
		{
			const string __id = "doFwUpgrade.()Lcom/linka/linkaapikit/module/widget/LockController;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_doLock;
#pragma warning disable 0169
		static Delegate GetDoLockHandler ()
		{
			if (cb_doLock == null)
				cb_doLock = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_DoLock);
			return cb_doLock;
		}

		static bool n_DoLock (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoLock ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='doLock' and count(parameter)=0]"
		[Register ("doLock", "()Z", "GetDoLockHandler")]
		public virtual unsafe bool DoLock ()
		{
			const string __id = "doLock.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doRead_airplane_mode;
#pragma warning disable 0169
		static Delegate GetDoRead_airplane_modeHandler ()
		{
			if (cb_doRead_airplane_mode == null)
				cb_doRead_airplane_mode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DoRead_airplane_mode);
			return cb_doRead_airplane_mode;
		}

		static void n_DoRead_airplane_mode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoRead_airplane_mode ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='doRead_airplane_mode' and count(parameter)=0]"
		[Register ("doRead_airplane_mode", "()V", "GetDoRead_airplane_modeHandler")]
		public virtual unsafe void DoRead_airplane_mode ()
		{
			const string __id = "doRead_airplane_mode.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_doRead_setting_audio;
#pragma warning disable 0169
		static Delegate GetDoRead_setting_audioHandler ()
		{
			if (cb_doRead_setting_audio == null)
				cb_doRead_setting_audio = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DoRead_setting_audio);
			return cb_doRead_setting_audio;
		}

		static void n_DoRead_setting_audio (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoRead_setting_audio ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='doRead_setting_audio' and count(parameter)=0]"
		[Register ("doRead_setting_audio", "()V", "GetDoRead_setting_audioHandler")]
		public virtual unsafe void DoRead_setting_audio ()
		{
			const string __id = "doRead_setting_audio.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_doRead_setting_keyfob;
#pragma warning disable 0169
		static Delegate GetDoRead_setting_keyfobHandler ()
		{
			if (cb_doRead_setting_keyfob == null)
				cb_doRead_setting_keyfob = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DoRead_setting_keyfob);
			return cb_doRead_setting_keyfob;
		}

		static void n_DoRead_setting_keyfob (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoRead_setting_keyfob ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='doRead_setting_keyfob' and count(parameter)=0]"
		[Register ("doRead_setting_keyfob", "()V", "GetDoRead_setting_keyfobHandler")]
		public virtual unsafe void DoRead_setting_keyfob ()
		{
			const string __id = "doRead_setting_keyfob.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_doRead_setting_lock_sleep;
#pragma warning disable 0169
		static Delegate GetDoRead_setting_lock_sleepHandler ()
		{
			if (cb_doRead_setting_lock_sleep == null)
				cb_doRead_setting_lock_sleep = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DoRead_setting_lock_sleep);
			return cb_doRead_setting_lock_sleep;
		}

		static void n_DoRead_setting_lock_sleep (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoRead_setting_lock_sleep ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='doRead_setting_lock_sleep' and count(parameter)=0]"
		[Register ("doRead_setting_lock_sleep", "()V", "GetDoRead_setting_lock_sleepHandler")]
		public virtual unsafe void DoRead_setting_lock_sleep ()
		{
			const string __id = "doRead_setting_lock_sleep.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_doRead_setting_pac;
#pragma warning disable 0169
		static Delegate GetDoRead_setting_pacHandler ()
		{
			if (cb_doRead_setting_pac == null)
				cb_doRead_setting_pac = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DoRead_setting_pac);
			return cb_doRead_setting_pac;
		}

		static void n_DoRead_setting_pac (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoRead_setting_pac ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='doRead_setting_pac' and count(parameter)=0]"
		[Register ("doRead_setting_pac", "()V", "GetDoRead_setting_pacHandler")]
		public virtual unsafe void DoRead_setting_pac ()
		{
			const string __id = "doRead_setting_pac.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_doRead_setting_unlock_sleep;
#pragma warning disable 0169
		static Delegate GetDoRead_setting_unlock_sleepHandler ()
		{
			if (cb_doRead_setting_unlock_sleep == null)
				cb_doRead_setting_unlock_sleep = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DoRead_setting_unlock_sleep);
			return cb_doRead_setting_unlock_sleep;
		}

		static void n_DoRead_setting_unlock_sleep (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoRead_setting_unlock_sleep ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='doRead_setting_unlock_sleep' and count(parameter)=0]"
		[Register ("doRead_setting_unlock_sleep", "()V", "GetDoRead_setting_unlock_sleepHandler")]
		public virtual unsafe void DoRead_setting_unlock_sleep ()
		{
			const string __id = "doRead_setting_unlock_sleep.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_doSiren;
#pragma warning disable 0169
		static Delegate GetDoSirenHandler ()
		{
			if (cb_doSiren == null)
				cb_doSiren = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DoSiren);
			return cb_doSiren;
		}

		static void n_DoSiren (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoSiren ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='doSiren' and count(parameter)=0]"
		[Register ("doSiren", "()V", "GetDoSirenHandler")]
		public virtual unsafe void DoSiren ()
		{
			const string __id = "doSiren.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_doSleep;
#pragma warning disable 0169
		static Delegate GetDoSleepHandler ()
		{
			if (cb_doSleep == null)
				cb_doSleep = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DoSleep);
			return cb_doSleep;
		}

		static void n_DoSleep (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoSleep ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='doSleep' and count(parameter)=0]"
		[Register ("doSleep", "()V", "GetDoSleepHandler")]
		public virtual unsafe void DoSleep ()
		{
			const string __id = "doSleep.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_doUnlock;
#pragma warning disable 0169
		static Delegate GetDoUnlockHandler ()
		{
			if (cb_doUnlock == null)
				cb_doUnlock = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_DoUnlock);
			return cb_doUnlock;
		}

		static bool n_DoUnlock (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoUnlock ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='doUnlock' and count(parameter)=0]"
		[Register ("doUnlock", "()Z", "GetDoUnlockHandler")]
		public virtual unsafe bool DoUnlock ()
		{
			const string __id = "doUnlock.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_factoryResetDevice_Lcom_linka_linkaapikit_module_model_RevocationController_FactoryResetDelegate_;
#pragma warning disable 0169
		static Delegate GetFactoryResetDevice_Lcom_linka_linkaapikit_module_model_RevocationController_FactoryResetDelegate_Handler ()
		{
			if (cb_factoryResetDevice_Lcom_linka_linkaapikit_module_model_RevocationController_FactoryResetDelegate_ == null)
				cb_factoryResetDevice_Lcom_linka_linkaapikit_module_model_RevocationController_FactoryResetDelegate_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_FactoryResetDevice_Lcom_linka_linkaapikit_module_model_RevocationController_FactoryResetDelegate_);
			return cb_factoryResetDevice_Lcom_linka_linkaapikit_module_model_RevocationController_FactoryResetDelegate_;
		}

		static void n_FactoryResetDevice_Lcom_linka_linkaapikit_module_model_RevocationController_FactoryResetDelegate_ (IntPtr jnienv, IntPtr native__this, IntPtr native__delegate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @delegate = (global::Com.Linka.Linkaapikit.Module.Model.RevocationController.IFactoryResetDelegate)global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.RevocationController.IFactoryResetDelegate> (native__delegate, JniHandleOwnership.DoNotTransfer);
			__this.FactoryResetDevice (@delegate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='factoryResetDevice' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.model.RevocationController.FactoryResetDelegate']]"
		[Register ("factoryResetDevice", "(Lcom/linka/linkaapikit/module/model/RevocationController$FactoryResetDelegate;)V", "GetFactoryResetDevice_Lcom_linka_linkaapikit_module_model_RevocationController_FactoryResetDelegate_Handler")]
		public virtual unsafe void FactoryResetDevice (global::Com.Linka.Linkaapikit.Module.Model.RevocationController.IFactoryResetDelegate @delegate)
		{
			const string __id = "factoryResetDevice.(Lcom/linka/linkaapikit/module/model/RevocationController$FactoryResetDelegate;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@delegate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @delegate).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@delegate);
			}
		}

		static Delegate cb_onDisconnect;
#pragma warning disable 0169
		static Delegate GetOnDisconnectHandler ()
		{
			if (cb_onDisconnect == null)
				cb_onDisconnect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnDisconnect);
			return cb_onDisconnect;
		}

		static void n_OnDisconnect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDisconnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='onDisconnect' and count(parameter)=0]"
		[Register ("onDisconnect", "()V", "GetOnDisconnectHandler")]
		public virtual unsafe void OnDisconnect ()
		{
			const string __id = "onDisconnect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_query;
#pragma warning disable 0169
		static Delegate GetQueryHandler ()
		{
			if (cb_query == null)
				cb_query = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Query);
			return cb_query;
		}

		static bool n_Query (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Query ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='query' and count(parameter)=0]"
		[Register ("query", "()Z", "GetQueryHandler")]
		public virtual unsafe bool Query ()
		{
			const string __id = "query.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setLinkaLockNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLinkaLockNumber_Ljava_lang_String_Handler ()
		{
			if (cb_setLinkaLockNumber_Ljava_lang_String_ == null)
				cb_setLinkaLockNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLinkaLockNumber_Ljava_lang_String_);
			return cb_setLinkaLockNumber_Ljava_lang_String_;
		}

		static void n_SetLinkaLockNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_lockNumber)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var lockNumber = JNIEnv.GetString (native_lockNumber, JniHandleOwnership.DoNotTransfer);
			__this.SetLinkaLockNumber (lockNumber);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='setLinkaLockNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setLinkaLockNumber", "(Ljava/lang/String;)V", "GetSetLinkaLockNumber_Ljava_lang_String_Handler")]
		public virtual unsafe void SetLinkaLockNumber (string lockNumber)
		{
			const string __id = "setLinkaLockNumber.(Ljava/lang/String;)V";
			IntPtr native_lockNumber = JNIEnv.NewString (lockNumber);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_lockNumber);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_lockNumber);
			}
		}

		static Delegate cb_setLinkaMacAddress_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLinkaMacAddress_Ljava_lang_String_Handler ()
		{
			if (cb_setLinkaMacAddress_Ljava_lang_String_ == null)
				cb_setLinkaMacAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLinkaMacAddress_Ljava_lang_String_);
			return cb_setLinkaMacAddress_Ljava_lang_String_;
		}

		static void n_SetLinkaMacAddress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_linkaMacAddress)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var linkaMacAddress = JNIEnv.GetString (native_linkaMacAddress, JniHandleOwnership.DoNotTransfer);
			__this.SetLinkaMacAddress (linkaMacAddress);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='setLinkaMacAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setLinkaMacAddress", "(Ljava/lang/String;)V", "GetSetLinkaMacAddress_Ljava_lang_String_Handler")]
		public virtual unsafe void SetLinkaMacAddress (string linkaMacAddress)
		{
			const string __id = "setLinkaMacAddress.(Ljava/lang/String;)V";
			IntPtr native_linkaMacAddress = JNIEnv.NewString (linkaMacAddress);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_linkaMacAddress);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_linkaMacAddress);
			}
		}

		static Delegate cb_setLockStatusCallback_Lcom_linka_linkaapikit_module_model_LockConnectionService_LockStatusCallback_;
#pragma warning disable 0169
		static Delegate GetSetLockStatusCallback_Lcom_linka_linkaapikit_module_model_LockConnectionService_LockStatusCallback_Handler ()
		{
			if (cb_setLockStatusCallback_Lcom_linka_linkaapikit_module_model_LockConnectionService_LockStatusCallback_ == null)
				cb_setLockStatusCallback_Lcom_linka_linkaapikit_module_model_LockConnectionService_LockStatusCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLockStatusCallback_Lcom_linka_linkaapikit_module_model_LockConnectionService_LockStatusCallback_);
			return cb_setLockStatusCallback_Lcom_linka_linkaapikit_module_model_LockConnectionService_LockStatusCallback_;
		}

		static void n_SetLockStatusCallback_Lcom_linka_linkaapikit_module_model_LockConnectionService_LockStatusCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.ILockStatusCallback)global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.ILockStatusCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SetLockStatusCallback (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='setLockStatusCallback' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.model.LockConnectionService.LockStatusCallback']]"
		[Register ("setLockStatusCallback", "(Lcom/linka/linkaapikit/module/model/LockConnectionService$LockStatusCallback;)V", "GetSetLockStatusCallback_Lcom_linka_linkaapikit_module_model_LockConnectionService_LockStatusCallback_Handler")]
		public virtual unsafe void SetLockStatusCallback (global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService.ILockStatusCallback @callback)
		{
			const string __id = "setLockStatusCallback.(Lcom/linka/linkaapikit/module/model/LockConnectionService$LockStatusCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_setWrite_airplane_mode_Z;
#pragma warning disable 0169
		static Delegate GetSetWrite_airplane_mode_ZHandler ()
		{
			if (cb_setWrite_airplane_mode_Z == null)
				cb_setWrite_airplane_mode_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetWrite_airplane_mode_Z);
			return cb_setWrite_airplane_mode_Z;
		}

		static void n_SetWrite_airplane_mode_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetWrite_airplane_mode (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='setWrite_airplane_mode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setWrite_airplane_mode", "(Z)V", "GetSetWrite_airplane_mode_ZHandler")]
		public virtual unsafe void SetWrite_airplane_mode (bool enabled)
		{
			const string __id = "setWrite_airplane_mode.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setWrite_setting_pac_I;
#pragma warning disable 0169
		static Delegate GetSetWrite_setting_pac_IHandler ()
		{
			if (cb_setWrite_setting_pac_I == null)
				cb_setWrite_setting_pac_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetWrite_setting_pac_I);
			return cb_setWrite_setting_pac_I;
		}

		static void n_SetWrite_setting_pac_I (IntPtr jnienv, IntPtr native__this, int pac)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetWrite_setting_pac (pac);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='setWrite_setting_pac' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setWrite_setting_pac", "(I)V", "GetSetWrite_setting_pac_IHandler")]
		public virtual unsafe void SetWrite_setting_pac (int pac)
		{
			const string __id = "setWrite_setting_pac.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pac);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_tryAgainLock;
#pragma warning disable 0169
		static Delegate GetTryAgainLockHandler ()
		{
			if (cb_tryAgainLock == null)
				cb_tryAgainLock = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_TryAgainLock);
			return cb_tryAgainLock;
		}

		static void n_TryAgainLock (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TryAgainLock ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='tryAgainLock' and count(parameter)=0]"
		[Register ("tryAgainLock", "()V", "GetTryAgainLockHandler")]
		public virtual unsafe void TryAgainLock ()
		{
			const string __id = "tryAgainLock.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_tryAgainUnlock;
#pragma warning disable 0169
		static Delegate GetTryAgainUnlockHandler ()
		{
			if (cb_tryAgainUnlock == null)
				cb_tryAgainUnlock = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_TryAgainUnlock);
			return cb_tryAgainUnlock;
		}

		static void n_TryAgainUnlock (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TryAgainUnlock ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='tryAgainUnlock' and count(parameter)=0]"
		[Register ("tryAgainUnlock", "()V", "GetTryAgainUnlockHandler")]
		public virtual unsafe void TryAgainUnlock ()
		{
			const string __id = "tryAgainUnlock.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_unassignKeyfob;
#pragma warning disable 0169
		static Delegate GetUnassignKeyfobHandler ()
		{
			if (cb_unassignKeyfob == null)
				cb_unassignKeyfob = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_UnassignKeyfob);
			return cb_unassignKeyfob;
		}

		static bool n_UnassignKeyfob (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.LockConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnassignKeyfob ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LockConnectionService']/method[@name='unassignKeyfob' and count(parameter)=0]"
		[Register ("unassignKeyfob", "()Z", "GetUnassignKeyfobHandler")]
		public virtual unsafe bool UnassignKeyfob ()
		{
			const string __id = "unassignKeyfob.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
