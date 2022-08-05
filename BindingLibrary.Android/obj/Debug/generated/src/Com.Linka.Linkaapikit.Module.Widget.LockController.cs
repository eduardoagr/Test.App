using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linka.Linkaapikit.Module.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']"
	[global::Android.Runtime.Register ("com/linka/linkaapikit/module/widget/LockController", DoNotGenerateAcw=true)]
	public partial class LockController : global::Java.Lang.Object, global::Java.IO.ISerializable {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/field[@name='access_key_master_2']"
		[Register ("access_key_master_2")]
		public string AccessKeyMaster2 {
			get {
				const string __id = "access_key_master_2.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "access_key_master_2.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/field[@name='authenticationCountSeconds']"
		[Register ("authenticationCountSeconds")]
		public int AuthenticationCountSeconds {
			get {
				const string __id = "authenticationCountSeconds.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "authenticationCountSeconds.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/field[@name='AUTHENTICATION_SECONDS_COMMAND']"
		[Register ("AUTHENTICATION_SECONDS_COMMAND")]
		public int AuthenticationSecondsCommand {
			get {
				const string __id = "AUTHENTICATION_SECONDS_COMMAND.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "AUTHENTICATION_SECONDS_COMMAND.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/field[@name='DisableAutomaticDisconnect']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/field[@name='isButtonUsedForLocking']"
		[Register ("isButtonUsedForLocking")]
		public bool IsButtonUsedForLocking {
			get {
				const string __id = "isButtonUsedForLocking.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isButtonUsedForLocking.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/field[@name='isCRCFactoryReset']"
		[Register ("isCRCFactoryReset")]
		public bool IsCRCFactoryReset {
			get {
				const string __id = "isCRCFactoryReset.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isCRCFactoryReset.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/field[@name='isCRCKeyMismatch']"
		[Register ("isCRCKeyMismatch")]
		public bool IsCRCKeyMismatch {
			get {
				const string __id = "isCRCKeyMismatch.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isCRCKeyMismatch.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/field[@name='lockControllerPacketCallback']"
		[Register ("lockControllerPacketCallback")]
		public global::Com.Linka.Linkaapikit.Module.Widget.LockController.ILockControllerPacketCallback LockControllerPacketCallback {
			get {
				const string __id = "lockControllerPacketCallback.Lcom/linka/linkaapikit/module/widget/LockController$LockControllerPacketCallback;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController.ILockControllerPacketCallback> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "lockControllerPacketCallback.Lcom/linka/linkaapikit/module/widget/LockController$LockControllerPacketCallback;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/field[@name='lockD2crc']"
		[Register ("lockD2crc")]
		public int LockD2crc {
			get {
				const string __id = "lockD2crc.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "lockD2crc.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/field[@name='lockLog']"
		[Register ("lockLog")]
		public string LockLog {
			get {
				const string __id = "lockLog.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "lockLog.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/field[@name='P']"
		[Register ("P")]
		protected global::Com.Linka.Linkaapikit.Module.Model.Linka P {
			get {
				const string __id = "P.Lcom/linka/linkaapikit/module/model/Linka;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "P.Lcom/linka/linkaapikit/module/model/Linka;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/field[@name='PostLockDelaySeconds']"
		[Register ("PostLockDelaySeconds")]
		public static int PostLockDelaySeconds {
			get {
				const string __id = "PostLockDelaySeconds.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "PostLockDelaySeconds.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/field[@name='settingConfiguration']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/field[@name='shouldRefreshBluetoothCache']"
		[Register ("shouldRefreshBluetoothCache")]
		public bool ShouldRefreshBluetoothCache {
			get {
				const string __id = "shouldRefreshBluetoothCache.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "shouldRefreshBluetoothCache.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/field[@name='shouldSendCRCMismatchNotifacation']"
		[Register ("shouldSendCRCMismatchNotifacation")]
		public bool ShouldSendCRCMismatchNotifacation {
			get {
				const string __id = "shouldSendCRCMismatchNotifacation.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "shouldSendCRCMismatchNotifacation.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController.AlarmSensitivity']"
		[global::Android.Runtime.Register ("com/linka/linkaapikit/module/widget/LockController$AlarmSensitivity", DoNotGenerateAcw=true)]
		public sealed partial class AlarmSensitivity : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController.AlarmSensitivity']/field[@name='GARAGE']"
			[Register ("GARAGE")]
			public static global::Com.Linka.Linkaapikit.Module.Widget.LockController.AlarmSensitivity Garage {
				get {
					const string __id = "GARAGE.Lcom/linka/linkaapikit/module/widget/LockController$AlarmSensitivity;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController.AlarmSensitivity> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController.AlarmSensitivity']/field[@name='METRO']"
			[Register ("METRO")]
			public static global::Com.Linka.Linkaapikit.Module.Widget.LockController.AlarmSensitivity Metro {
				get {
					const string __id = "METRO.Lcom/linka/linkaapikit/module/widget/LockController$AlarmSensitivity;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController.AlarmSensitivity> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController.AlarmSensitivity']/field[@name='SUBURBAN']"
			[Register ("SUBURBAN")]
			public static global::Com.Linka.Linkaapikit.Module.Widget.LockController.AlarmSensitivity Suburban {
				get {
					const string __id = "SUBURBAN.Lcom/linka/linkaapikit/module/widget/LockController$AlarmSensitivity;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController.AlarmSensitivity> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/widget/LockController$AlarmSensitivity", typeof (AlarmSensitivity));

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

			internal AlarmSensitivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController.AlarmSensitivity']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/linka/linkaapikit/module/widget/LockController$AlarmSensitivity;", "")]
			public static unsafe global::Com.Linka.Linkaapikit.Module.Widget.LockController.AlarmSensitivity ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/linka/linkaapikit/module/widget/LockController$AlarmSensitivity;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController.AlarmSensitivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController.AlarmSensitivity']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/linka/linkaapikit/module/widget/LockController$AlarmSensitivity;", "")]
			public static unsafe global::Com.Linka.Linkaapikit.Module.Widget.LockController.AlarmSensitivity[] Values ()
			{
				const string __id = "values.()[Lcom/linka/linkaapikit/module/widget/LockController$AlarmSensitivity;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Linka.Linkaapikit.Module.Widget.LockController.AlarmSensitivity[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Linka.Linkaapikit.Module.Widget.LockController.AlarmSensitivity));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/interface[@name='LockController.LinkaBLEConnectionManager']"
		[Register ("com/linka/linkaapikit/module/widget/LockController$LinkaBLEConnectionManager", "", "Com.Linka.Linkaapikit.Module.Widget.LockController/ILinkaBLEConnectionManagerInvoker")]
		public partial interface ILinkaBLEConnectionManager : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/interface[@name='LockController.LinkaBLEConnectionManager']/method[@name='onConnect' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.widget.LockController']]"
			[Register ("onConnect", "(Lcom/linka/linkaapikit/module/widget/LockController;)V", "GetOnConnect_Lcom_linka_linkaapikit_module_widget_LockController_Handler:Com.Linka.Linkaapikit.Module.Widget.LockController/ILinkaBLEConnectionManagerInvoker, BindingLibrary.Android")]
			void OnConnect (global::Com.Linka.Linkaapikit.Module.Widget.LockController p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/interface[@name='LockController.LinkaBLEConnectionManager']/method[@name='onLostConnection' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.widget.LockController']]"
			[Register ("onLostConnection", "(Lcom/linka/linkaapikit/module/widget/LockController;)V", "GetOnLostConnection_Lcom_linka_linkaapikit_module_widget_LockController_Handler:Com.Linka.Linkaapikit.Module.Widget.LockController/ILinkaBLEConnectionManagerInvoker, BindingLibrary.Android")]
			void OnLostConnection (global::Com.Linka.Linkaapikit.Module.Widget.LockController p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/interface[@name='LockController.LinkaBLEConnectionManager']/method[@name='onReadRSSI' and count(parameter)=2 and parameter[1][@type='com.linka.linkaapikit.module.widget.LockController'] and parameter[2][@type='int']]"
			[Register ("onReadRSSI", "(Lcom/linka/linkaapikit/module/widget/LockController;I)V", "GetOnReadRSSI_Lcom_linka_linkaapikit_module_widget_LockController_IHandler:Com.Linka.Linkaapikit.Module.Widget.LockController/ILinkaBLEConnectionManagerInvoker, BindingLibrary.Android")]
			void OnReadRSSI (global::Com.Linka.Linkaapikit.Module.Widget.LockController p0, int p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/interface[@name='LockController.LinkaBLEConnectionManager']/method[@name='onSettled' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.widget.LockController']]"
			[Register ("onSettled", "(Lcom/linka/linkaapikit/module/widget/LockController;)V", "GetOnSettled_Lcom_linka_linkaapikit_module_widget_LockController_Handler:Com.Linka.Linkaapikit.Module.Widget.LockController/ILinkaBLEConnectionManagerInvoker, BindingLibrary.Android")]
			void OnSettled (global::Com.Linka.Linkaapikit.Module.Widget.LockController p0);

		}

		[global::Android.Runtime.Register ("com/linka/linkaapikit/module/widget/LockController$LinkaBLEConnectionManager", DoNotGenerateAcw=true)]
		internal partial class ILinkaBLEConnectionManagerInvoker : global::Java.Lang.Object, ILinkaBLEConnectionManager {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/widget/LockController$LinkaBLEConnectionManager", typeof (ILinkaBLEConnectionManagerInvoker));

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

			public static ILinkaBLEConnectionManager GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ILinkaBLEConnectionManager> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linka.linkaapikit.module.widget.LockController.LinkaBLEConnectionManager'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ILinkaBLEConnectionManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onConnect_Lcom_linka_linkaapikit_module_widget_LockController_;
#pragma warning disable 0169
			static Delegate GetOnConnect_Lcom_linka_linkaapikit_module_widget_LockController_Handler ()
			{
				if (cb_onConnect_Lcom_linka_linkaapikit_module_widget_LockController_ == null)
					cb_onConnect_Lcom_linka_linkaapikit_module_widget_LockController_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnConnect_Lcom_linka_linkaapikit_module_widget_LockController_);
				return cb_onConnect_Lcom_linka_linkaapikit_module_widget_LockController_;
			}

			static void n_OnConnect_Lcom_linka_linkaapikit_module_widget_LockController_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController.ILinkaBLEConnectionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnConnect (p0);
			}
#pragma warning restore 0169

			IntPtr id_onConnect_Lcom_linka_linkaapikit_module_widget_LockController_;
			public unsafe void OnConnect (global::Com.Linka.Linkaapikit.Module.Widget.LockController p0)
			{
				if (id_onConnect_Lcom_linka_linkaapikit_module_widget_LockController_ == IntPtr.Zero)
					id_onConnect_Lcom_linka_linkaapikit_module_widget_LockController_ = JNIEnv.GetMethodID (class_ref, "onConnect", "(Lcom/linka/linkaapikit/module/widget/LockController;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnect_Lcom_linka_linkaapikit_module_widget_LockController_, __args);
			}

			static Delegate cb_onLostConnection_Lcom_linka_linkaapikit_module_widget_LockController_;
#pragma warning disable 0169
			static Delegate GetOnLostConnection_Lcom_linka_linkaapikit_module_widget_LockController_Handler ()
			{
				if (cb_onLostConnection_Lcom_linka_linkaapikit_module_widget_LockController_ == null)
					cb_onLostConnection_Lcom_linka_linkaapikit_module_widget_LockController_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnLostConnection_Lcom_linka_linkaapikit_module_widget_LockController_);
				return cb_onLostConnection_Lcom_linka_linkaapikit_module_widget_LockController_;
			}

			static void n_OnLostConnection_Lcom_linka_linkaapikit_module_widget_LockController_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController.ILinkaBLEConnectionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLostConnection (p0);
			}
#pragma warning restore 0169

			IntPtr id_onLostConnection_Lcom_linka_linkaapikit_module_widget_LockController_;
			public unsafe void OnLostConnection (global::Com.Linka.Linkaapikit.Module.Widget.LockController p0)
			{
				if (id_onLostConnection_Lcom_linka_linkaapikit_module_widget_LockController_ == IntPtr.Zero)
					id_onLostConnection_Lcom_linka_linkaapikit_module_widget_LockController_ = JNIEnv.GetMethodID (class_ref, "onLostConnection", "(Lcom/linka/linkaapikit/module/widget/LockController;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLostConnection_Lcom_linka_linkaapikit_module_widget_LockController_, __args);
			}

			static Delegate cb_onReadRSSI_Lcom_linka_linkaapikit_module_widget_LockController_I;
#pragma warning disable 0169
			static Delegate GetOnReadRSSI_Lcom_linka_linkaapikit_module_widget_LockController_IHandler ()
			{
				if (cb_onReadRSSI_Lcom_linka_linkaapikit_module_widget_LockController_I == null)
					cb_onReadRSSI_Lcom_linka_linkaapikit_module_widget_LockController_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnReadRSSI_Lcom_linka_linkaapikit_module_widget_LockController_I);
				return cb_onReadRSSI_Lcom_linka_linkaapikit_module_widget_LockController_I;
			}

			static void n_OnReadRSSI_Lcom_linka_linkaapikit_module_widget_LockController_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController.ILinkaBLEConnectionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnReadRSSI (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onReadRSSI_Lcom_linka_linkaapikit_module_widget_LockController_I;
			public unsafe void OnReadRSSI (global::Com.Linka.Linkaapikit.Module.Widget.LockController p0, int p1)
			{
				if (id_onReadRSSI_Lcom_linka_linkaapikit_module_widget_LockController_I == IntPtr.Zero)
					id_onReadRSSI_Lcom_linka_linkaapikit_module_widget_LockController_I = JNIEnv.GetMethodID (class_ref, "onReadRSSI", "(Lcom/linka/linkaapikit/module/widget/LockController;I)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReadRSSI_Lcom_linka_linkaapikit_module_widget_LockController_I, __args);
			}

			static Delegate cb_onSettled_Lcom_linka_linkaapikit_module_widget_LockController_;
#pragma warning disable 0169
			static Delegate GetOnSettled_Lcom_linka_linkaapikit_module_widget_LockController_Handler ()
			{
				if (cb_onSettled_Lcom_linka_linkaapikit_module_widget_LockController_ == null)
					cb_onSettled_Lcom_linka_linkaapikit_module_widget_LockController_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSettled_Lcom_linka_linkaapikit_module_widget_LockController_);
				return cb_onSettled_Lcom_linka_linkaapikit_module_widget_LockController_;
			}

			static void n_OnSettled_Lcom_linka_linkaapikit_module_widget_LockController_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController.ILinkaBLEConnectionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSettled (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSettled_Lcom_linka_linkaapikit_module_widget_LockController_;
			public unsafe void OnSettled (global::Com.Linka.Linkaapikit.Module.Widget.LockController p0)
			{
				if (id_onSettled_Lcom_linka_linkaapikit_module_widget_LockController_ == IntPtr.Zero)
					id_onSettled_Lcom_linka_linkaapikit_module_widget_LockController_ = JNIEnv.GetMethodID (class_ref, "onSettled", "(Lcom/linka/linkaapikit/module/widget/LockController;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSettled_Lcom_linka_linkaapikit_module_widget_LockController_, __args);
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/interface[@name='LockController.LockControllerPacketCallback']"
		[Register ("com/linka/linkaapikit/module/widget/LockController$LockControllerPacketCallback", "", "Com.Linka.Linkaapikit.Module.Widget.LockController/ILockControllerPacketCallbackInvoker")]
		public partial interface ILockControllerPacketCallback : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/interface[@name='LockController.LockControllerPacketCallback']/method[@name='onTimeout' and count(parameter)=0]"
			[Register ("onTimeout", "()V", "GetOnTimeoutHandler:Com.Linka.Linkaapikit.Module.Widget.LockController/ILockControllerPacketCallbackInvoker, BindingLibrary.Android")]
			void OnTimeout ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/interface[@name='LockController.LockControllerPacketCallback']/method[@name='onUpdateCounter' and count(parameter)=0]"
			[Register ("onUpdateCounter", "()V", "GetOnUpdateCounterHandler:Com.Linka.Linkaapikit.Module.Widget.LockController/ILockControllerPacketCallbackInvoker, BindingLibrary.Android")]
			void OnUpdateCounter ();

		}

		[global::Android.Runtime.Register ("com/linka/linkaapikit/module/widget/LockController$LockControllerPacketCallback", DoNotGenerateAcw=true)]
		internal partial class ILockControllerPacketCallbackInvoker : global::Java.Lang.Object, ILockControllerPacketCallback {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/widget/LockController$LockControllerPacketCallback", typeof (ILockControllerPacketCallbackInvoker));

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

			public static ILockControllerPacketCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ILockControllerPacketCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linka.linkaapikit.module.widget.LockController.LockControllerPacketCallback'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ILockControllerPacketCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onTimeout;
#pragma warning disable 0169
			static Delegate GetOnTimeoutHandler ()
			{
				if (cb_onTimeout == null)
					cb_onTimeout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnTimeout);
				return cb_onTimeout;
			}

			static void n_OnTimeout (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController.ILockControllerPacketCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTimeout ();
			}
#pragma warning restore 0169

			IntPtr id_onTimeout;
			public unsafe void OnTimeout ()
			{
				if (id_onTimeout == IntPtr.Zero)
					id_onTimeout = JNIEnv.GetMethodID (class_ref, "onTimeout", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTimeout);
			}

			static Delegate cb_onUpdateCounter;
#pragma warning disable 0169
			static Delegate GetOnUpdateCounterHandler ()
			{
				if (cb_onUpdateCounter == null)
					cb_onUpdateCounter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnUpdateCounter);
				return cb_onUpdateCounter;
			}

			static void n_OnUpdateCounter (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController.ILockControllerPacketCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnUpdateCounter ();
			}
#pragma warning restore 0169

			IntPtr id_onUpdateCounter;
			public unsafe void OnUpdateCounter ()
			{
				if (id_onUpdateCounter == IntPtr.Zero)
					id_onUpdateCounter = JNIEnv.GetMethodID (class_ref, "onUpdateCounter", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpdateCounter);
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/interface[@name='LockController.OnRefreshListener']"
		[Register ("com/linka/linkaapikit/module/widget/LockController$OnRefreshListener", "", "Com.Linka.Linkaapikit.Module.Widget.LockController/IOnRefreshListenerInvoker")]
		public partial interface IOnRefreshListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/interface[@name='LockController.OnRefreshListener']/method[@name='onRefresh' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.widget.LockController']]"
			[Register ("onRefresh", "(Lcom/linka/linkaapikit/module/widget/LockController;)V", "GetOnRefresh_Lcom_linka_linkaapikit_module_widget_LockController_Handler:Com.Linka.Linkaapikit.Module.Widget.LockController/IOnRefreshListenerInvoker, BindingLibrary.Android")]
			void OnRefresh (global::Com.Linka.Linkaapikit.Module.Widget.LockController p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/interface[@name='LockController.OnRefreshListener']/method[@name='onRefreshSettings' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.widget.LockController']]"
			[Register ("onRefreshSettings", "(Lcom/linka/linkaapikit/module/widget/LockController;)V", "GetOnRefreshSettings_Lcom_linka_linkaapikit_module_widget_LockController_Handler:Com.Linka.Linkaapikit.Module.Widget.LockController/IOnRefreshListenerInvoker, BindingLibrary.Android")]
			void OnRefreshSettings (global::Com.Linka.Linkaapikit.Module.Widget.LockController p0);

		}

		[global::Android.Runtime.Register ("com/linka/linkaapikit/module/widget/LockController$OnRefreshListener", DoNotGenerateAcw=true)]
		internal partial class IOnRefreshListenerInvoker : global::Java.Lang.Object, IOnRefreshListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/widget/LockController$OnRefreshListener", typeof (IOnRefreshListenerInvoker));

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

			public static IOnRefreshListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnRefreshListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linka.linkaapikit.module.widget.LockController.OnRefreshListener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnRefreshListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onRefresh_Lcom_linka_linkaapikit_module_widget_LockController_;
#pragma warning disable 0169
			static Delegate GetOnRefresh_Lcom_linka_linkaapikit_module_widget_LockController_Handler ()
			{
				if (cb_onRefresh_Lcom_linka_linkaapikit_module_widget_LockController_ == null)
					cb_onRefresh_Lcom_linka_linkaapikit_module_widget_LockController_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnRefresh_Lcom_linka_linkaapikit_module_widget_LockController_);
				return cb_onRefresh_Lcom_linka_linkaapikit_module_widget_LockController_;
			}

			static void n_OnRefresh_Lcom_linka_linkaapikit_module_widget_LockController_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController.IOnRefreshListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnRefresh (p0);
			}
#pragma warning restore 0169

			IntPtr id_onRefresh_Lcom_linka_linkaapikit_module_widget_LockController_;
			public unsafe void OnRefresh (global::Com.Linka.Linkaapikit.Module.Widget.LockController p0)
			{
				if (id_onRefresh_Lcom_linka_linkaapikit_module_widget_LockController_ == IntPtr.Zero)
					id_onRefresh_Lcom_linka_linkaapikit_module_widget_LockController_ = JNIEnv.GetMethodID (class_ref, "onRefresh", "(Lcom/linka/linkaapikit/module/widget/LockController;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRefresh_Lcom_linka_linkaapikit_module_widget_LockController_, __args);
			}

			static Delegate cb_onRefreshSettings_Lcom_linka_linkaapikit_module_widget_LockController_;
#pragma warning disable 0169
			static Delegate GetOnRefreshSettings_Lcom_linka_linkaapikit_module_widget_LockController_Handler ()
			{
				if (cb_onRefreshSettings_Lcom_linka_linkaapikit_module_widget_LockController_ == null)
					cb_onRefreshSettings_Lcom_linka_linkaapikit_module_widget_LockController_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnRefreshSettings_Lcom_linka_linkaapikit_module_widget_LockController_);
				return cb_onRefreshSettings_Lcom_linka_linkaapikit_module_widget_LockController_;
			}

			static void n_OnRefreshSettings_Lcom_linka_linkaapikit_module_widget_LockController_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController.IOnRefreshListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnRefreshSettings (p0);
			}
#pragma warning restore 0169

			IntPtr id_onRefreshSettings_Lcom_linka_linkaapikit_module_widget_LockController_;
			public unsafe void OnRefreshSettings (global::Com.Linka.Linkaapikit.Module.Widget.LockController p0)
			{
				if (id_onRefreshSettings_Lcom_linka_linkaapikit_module_widget_LockController_ == IntPtr.Zero)
					id_onRefreshSettings_Lcom_linka_linkaapikit_module_widget_LockController_ = JNIEnv.GetMethodID (class_ref, "onRefreshSettings", "(Lcom/linka/linkaapikit/module/widget/LockController;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRefreshSettings_Lcom_linka_linkaapikit_module_widget_LockController_, __args);
			}

		}

		// event args for com.linka.linkaapikit.module.widget.LockController.OnRefreshListener.onRefresh
		public partial class RefreshEventArgs : global::System.EventArgs {
			public RefreshEventArgs (global::Com.Linka.Linkaapikit.Module.Widget.LockController p0)
			{
				this.p0 = p0;
			}

			global::Com.Linka.Linkaapikit.Module.Widget.LockController p0;

			public global::Com.Linka.Linkaapikit.Module.Widget.LockController P0 {
				get { return p0; }
			}

		}

		// event args for com.linka.linkaapikit.module.widget.LockController.OnRefreshListener.onRefreshSettings
		public partial class RefreshSettingsEventArgs : global::System.EventArgs {
			public RefreshSettingsEventArgs (global::Com.Linka.Linkaapikit.Module.Widget.LockController p0)
			{
				this.p0 = p0;
			}

			global::Com.Linka.Linkaapikit.Module.Widget.LockController p0;

			public global::Com.Linka.Linkaapikit.Module.Widget.LockController P0 {
				get { return p0; }
			}

		}

		[global::Android.Runtime.Register ("mono/com/linka/linkaapikit/module/widget/LockController_OnRefreshListenerImplementor")]
		internal sealed partial class IOnRefreshListenerImplementor : global::Java.Lang.Object, IOnRefreshListener {

			object sender;

			public IOnRefreshListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/linka/linkaapikit/module/widget/LockController_OnRefreshListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

			#pragma warning disable 0649
			public EventHandler<RefreshEventArgs> OnRefreshHandler;
			#pragma warning restore 0649

			public void OnRefresh (global::Com.Linka.Linkaapikit.Module.Widget.LockController p0)
			{
				var __h = OnRefreshHandler;
				if (__h != null)
					__h (sender, new RefreshEventArgs (p0));
			}

			#pragma warning disable 0649
			public EventHandler<RefreshSettingsEventArgs> OnRefreshSettingsHandler;
			#pragma warning restore 0649

			public void OnRefreshSettings (global::Com.Linka.Linkaapikit.Module.Widget.LockController p0)
			{
				var __h = OnRefreshSettingsHandler;
				if (__h != null)
					__h (sender, new RefreshSettingsEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnRefreshListenerImplementor value)
			{
				return value.OnRefreshHandler == null && value.OnRefreshSettingsHandler == null;
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/widget/LockController", typeof (LockController));

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

		protected LockController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Linka);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Linka.Linkaapikit.Module.Model.Linka Linka {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='getLinka' and count(parameter)=0]"
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

		static Delegate cb_deinitialize;
#pragma warning disable 0169
		static Delegate GetDeinitializeHandler ()
		{
			if (cb_deinitialize == null)
				cb_deinitialize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Deinitialize);
			return cb_deinitialize;
		}

		static void n_Deinitialize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Deinitialize ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='deinitialize' and count(parameter)=0]"
		[Register ("deinitialize", "()V", "GetDeinitializeHandler")]
		public virtual unsafe void Deinitialize ()
		{
			const string __id = "deinitialize.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_doBond;
#pragma warning disable 0169
		static Delegate GetDoBondHandler ()
		{
			if (cb_doBond == null)
				cb_doBond = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_DoBond);
			return cb_doBond;
		}

		static bool n_DoBond (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoBond ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doBond' and count(parameter)=0]"
		[Register ("doBond", "()Z", "GetDoBondHandler")]
		public virtual unsafe bool DoBond ()
		{
			const string __id = "doBond.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doConnectDevice;
#pragma warning disable 0169
		static Delegate GetDoConnectDeviceHandler ()
		{
			if (cb_doConnectDevice == null)
				cb_doConnectDevice = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DoConnectDevice);
			return cb_doConnectDevice;
		}

		static void n_DoConnectDevice (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoConnectDevice ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doConnectDevice' and count(parameter)=0]"
		[Register ("doConnectDevice", "()V", "GetDoConnectDeviceHandler")]
		public virtual unsafe void DoConnectDevice ()
		{
			const string __id = "doConnectDevice.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_doConnectDevice_Z;
#pragma warning disable 0169
		static Delegate GetDoConnectDevice_ZHandler ()
		{
			if (cb_doConnectDevice_Z == null)
				cb_doConnectDevice_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_DoConnectDevice_Z);
			return cb_doConnectDevice_Z;
		}

		static void n_DoConnectDevice_Z (IntPtr jnienv, IntPtr native__this, bool isFirstTimeConnecting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoConnectDevice (isFirstTimeConnecting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doConnectDevice' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("doConnectDevice", "(Z)V", "GetDoConnectDevice_ZHandler")]
		public virtual unsafe void DoConnectDevice (bool isFirstTimeConnecting)
		{
			const string __id = "doConnectDevice.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isFirstTimeConnecting);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_doDefaultSettings;
#pragma warning disable 0169
		static Delegate GetDoDefaultSettingsHandler ()
		{
			if (cb_doDefaultSettings == null)
				cb_doDefaultSettings = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DoDefaultSettings);
			return cb_doDefaultSettings;
		}

		static void n_DoDefaultSettings (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoDefaultSettings ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doDefaultSettings' and count(parameter)=0]"
		[Register ("doDefaultSettings", "()V", "GetDoDefaultSettingsHandler")]
		public virtual unsafe void DoDefaultSettings ()
		{
			const string __id = "doDefaultSettings.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_doDeleteAllBonds;
#pragma warning disable 0169
		static Delegate GetDoDeleteAllBondsHandler ()
		{
			if (cb_doDeleteAllBonds == null)
				cb_doDeleteAllBonds = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_DoDeleteAllBonds);
			return cb_doDeleteAllBonds;
		}

		static bool n_DoDeleteAllBonds (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoDeleteAllBonds ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doDeleteAllBonds' and count(parameter)=0]"
		[Register ("doDeleteAllBonds", "()Z", "GetDoDeleteAllBondsHandler")]
		public virtual unsafe bool DoDeleteAllBonds ()
		{
			const string __id = "doDeleteAllBonds.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoDisconnectDevice ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doDisconnectDevice' and count(parameter)=0]"
		[Register ("doDisconnectDevice", "()V", "GetDoDisconnectDeviceHandler")]
		public virtual unsafe void DoDisconnectDevice ()
		{
			const string __id = "doDisconnectDevice.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_doFwUpg;
#pragma warning disable 0169
		static Delegate GetDoFwUpgHandler ()
		{
			if (cb_doFwUpg == null)
				cb_doFwUpg = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_DoFwUpg);
			return cb_doFwUpg;
		}

		static int n_DoFwUpg (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoFwUpg ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doFwUpg' and count(parameter)=0]"
		[Register ("doFwUpg", "()I", "GetDoFwUpgHandler")]
		public virtual unsafe int DoFwUpg ()
		{
			const string __id = "doFwUpg.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoLock ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doLock' and count(parameter)=0]"
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

		static Delegate cb_doQuickCommandLock_I;
#pragma warning disable 0169
		static Delegate GetDoQuickCommandLock_IHandler ()
		{
			if (cb_doQuickCommandLock_I == null)
				cb_doQuickCommandLock_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoQuickCommandLock_I);
			return cb_doQuickCommandLock_I;
		}

		static bool n_DoQuickCommandLock_I (IntPtr jnienv, IntPtr native__this, int counter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoQuickCommandLock (counter);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doQuickCommandLock' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doQuickCommandLock", "(I)Z", "GetDoQuickCommandLock_IHandler")]
		public virtual unsafe bool DoQuickCommandLock (int counter)
		{
			const string __id = "doQuickCommandLock.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (counter);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doQuickCommandScanning;
#pragma warning disable 0169
		static Delegate GetDoQuickCommandScanningHandler ()
		{
			if (cb_doQuickCommandScanning == null)
				cb_doQuickCommandScanning = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_DoQuickCommandScanning);
			return cb_doQuickCommandScanning;
		}

		static bool n_DoQuickCommandScanning (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoQuickCommandScanning ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doQuickCommandScanning' and count(parameter)=0]"
		[Register ("doQuickCommandScanning", "()Z", "GetDoQuickCommandScanningHandler")]
		public virtual unsafe bool DoQuickCommandScanning ()
		{
			const string __id = "doQuickCommandScanning.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doQuickCommandUnlock_I;
#pragma warning disable 0169
		static Delegate GetDoQuickCommandUnlock_IHandler ()
		{
			if (cb_doQuickCommandUnlock_I == null)
				cb_doQuickCommandUnlock_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoQuickCommandUnlock_I);
			return cb_doQuickCommandUnlock_I;
		}

		static bool n_DoQuickCommandUnlock_I (IntPtr jnienv, IntPtr native__this, int counter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoQuickCommandUnlock (counter);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doQuickCommandUnlock' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doQuickCommandUnlock", "(I)Z", "GetDoQuickCommandUnlock_IHandler")]
		public virtual unsafe bool DoQuickCommandUnlock (int counter)
		{
			const string __id = "doQuickCommandUnlock.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (counter);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doReadActuations;
#pragma warning disable 0169
		static Delegate GetDoReadActuationsHandler ()
		{
			if (cb_doReadActuations == null)
				cb_doReadActuations = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_DoReadActuations);
			return cb_doReadActuations;
		}

		static bool n_DoReadActuations (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoReadActuations ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doReadActuations' and count(parameter)=0]"
		[Register ("doReadActuations", "()Z", "GetDoReadActuationsHandler")]
		public virtual unsafe bool DoReadActuations ()
		{
			const string __id = "doReadActuations.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doReadAudioSetting;
#pragma warning disable 0169
		static Delegate GetDoReadAudioSettingHandler ()
		{
			if (cb_doReadAudioSetting == null)
				cb_doReadAudioSetting = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_DoReadAudioSetting);
			return cb_doReadAudioSetting;
		}

		static bool n_DoReadAudioSetting (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoReadAudioSetting ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doReadAudioSetting' and count(parameter)=0]"
		[Register ("doReadAudioSetting", "()Z", "GetDoReadAudioSettingHandler")]
		public virtual unsafe bool DoReadAudioSetting ()
		{
			const string __id = "doReadAudioSetting.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doReadFactoryResetSetting;
#pragma warning disable 0169
		static Delegate GetDoReadFactoryResetSettingHandler ()
		{
			if (cb_doReadFactoryResetSetting == null)
				cb_doReadFactoryResetSetting = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DoReadFactoryResetSetting);
			return cb_doReadFactoryResetSetting;
		}

		static void n_DoReadFactoryResetSetting (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoReadFactoryResetSetting ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doReadFactoryResetSetting' and count(parameter)=0]"
		[Register ("doReadFactoryResetSetting", "()V", "GetDoReadFactoryResetSettingHandler")]
		public virtual unsafe void DoReadFactoryResetSetting ()
		{
			const string __id = "doReadFactoryResetSetting.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_doReadGpsOffBattery;
#pragma warning disable 0169
		static Delegate GetDoReadGpsOffBatteryHandler ()
		{
			if (cb_doReadGpsOffBattery == null)
				cb_doReadGpsOffBattery = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_DoReadGpsOffBattery);
			return cb_doReadGpsOffBattery;
		}

		static bool n_DoReadGpsOffBattery (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoReadGpsOffBattery ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doReadGpsOffBattery' and count(parameter)=0]"
		[Register ("doReadGpsOffBattery", "()Z", "GetDoReadGpsOffBatteryHandler")]
		public virtual unsafe bool DoReadGpsOffBattery ()
		{
			const string __id = "doReadGpsOffBattery.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doReadKeyfob;
#pragma warning disable 0169
		static Delegate GetDoReadKeyfobHandler ()
		{
			if (cb_doReadKeyfob == null)
				cb_doReadKeyfob = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_DoReadKeyfob);
			return cb_doReadKeyfob;
		}

		static bool n_DoReadKeyfob (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoReadKeyfob ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doReadKeyfob' and count(parameter)=0]"
		[Register ("doReadKeyfob", "()Z", "GetDoReadKeyfobHandler")]
		public virtual unsafe bool DoReadKeyfob ()
		{
			const string __id = "doReadKeyfob.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doReadLockSleep;
#pragma warning disable 0169
		static Delegate GetDoReadLockSleepHandler ()
		{
			if (cb_doReadLockSleep == null)
				cb_doReadLockSleep = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_DoReadLockSleep);
			return cb_doReadLockSleep;
		}

		static bool n_DoReadLockSleep (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoReadLockSleep ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doReadLockSleep' and count(parameter)=0]"
		[Register ("doReadLockSleep", "()Z", "GetDoReadLockSleepHandler")]
		public virtual unsafe bool DoReadLockSleep ()
		{
			const string __id = "doReadLockSleep.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doReadPAC;
#pragma warning disable 0169
		static Delegate GetDoReadPACHandler ()
		{
			if (cb_doReadPAC == null)
				cb_doReadPAC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_DoReadPAC);
			return cb_doReadPAC;
		}

		static bool n_DoReadPAC (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoReadPAC ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doReadPAC' and count(parameter)=0]"
		[Register ("doReadPAC", "()Z", "GetDoReadPACHandler")]
		public virtual unsafe bool DoReadPAC ()
		{
			const string __id = "doReadPAC.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doReadUnlockedDisconnectedSleep;
#pragma warning disable 0169
		static Delegate GetDoReadUnlockedDisconnectedSleepHandler ()
		{
			if (cb_doReadUnlockedDisconnectedSleep == null)
				cb_doReadUnlockedDisconnectedSleep = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_DoReadUnlockedDisconnectedSleep);
			return cb_doReadUnlockedDisconnectedSleep;
		}

		static bool n_DoReadUnlockedDisconnectedSleep (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoReadUnlockedDisconnectedSleep ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doReadUnlockedDisconnectedSleep' and count(parameter)=0]"
		[Register ("doReadUnlockedDisconnectedSleep", "()Z", "GetDoReadUnlockedDisconnectedSleepHandler")]
		public virtual unsafe bool DoReadUnlockedDisconnectedSleep ()
		{
			const string __id = "doReadUnlockedDisconnectedSleep.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doSetAlarmSensitivity_Lcom_linka_linkaapikit_module_widget_LockController_AlarmSensitivity_;
#pragma warning disable 0169
		static Delegate GetDoSetAlarmSensitivity_Lcom_linka_linkaapikit_module_widget_LockController_AlarmSensitivity_Handler ()
		{
			if (cb_doSetAlarmSensitivity_Lcom_linka_linkaapikit_module_widget_LockController_AlarmSensitivity_ == null)
				cb_doSetAlarmSensitivity_Lcom_linka_linkaapikit_module_widget_LockController_AlarmSensitivity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_DoSetAlarmSensitivity_Lcom_linka_linkaapikit_module_widget_LockController_AlarmSensitivity_);
			return cb_doSetAlarmSensitivity_Lcom_linka_linkaapikit_module_widget_LockController_AlarmSensitivity_;
		}

		static bool n_DoSetAlarmSensitivity_Lcom_linka_linkaapikit_module_widget_LockController_AlarmSensitivity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sensitivity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var sensitivity = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController.AlarmSensitivity> (native_sensitivity, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DoSetAlarmSensitivity (sensitivity);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doSetAlarmSensitivity' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.widget.LockController.AlarmSensitivity']]"
		[Register ("doSetAlarmSensitivity", "(Lcom/linka/linkaapikit/module/widget/LockController$AlarmSensitivity;)Z", "GetDoSetAlarmSensitivity_Lcom_linka_linkaapikit_module_widget_LockController_AlarmSensitivity_Handler")]
		public virtual unsafe bool DoSetAlarmSensitivity (global::Com.Linka.Linkaapikit.Module.Widget.LockController.AlarmSensitivity sensitivity)
		{
			const string __id = "doSetAlarmSensitivity.(Lcom/linka/linkaapikit/module/widget/LockController$AlarmSensitivity;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sensitivity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sensitivity).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (sensitivity);
			}
		}

		static Delegate cb_doSetUnlockedBumpThreshold_I;
#pragma warning disable 0169
		static Delegate GetDoSetUnlockedBumpThreshold_IHandler ()
		{
			if (cb_doSetUnlockedBumpThreshold_I == null)
				cb_doSetUnlockedBumpThreshold_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoSetUnlockedBumpThreshold_I);
			return cb_doSetUnlockedBumpThreshold_I;
		}

		static bool n_DoSetUnlockedBumpThreshold_I (IntPtr jnienv, IntPtr native__this, int lockingWithMovement)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoSetUnlockedBumpThreshold (lockingWithMovement);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doSetUnlockedBumpThreshold' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doSetUnlockedBumpThreshold", "(I)Z", "GetDoSetUnlockedBumpThreshold_IHandler")]
		public virtual unsafe bool DoSetUnlockedBumpThreshold (int lockingWithMovement)
		{
			const string __id = "doSetUnlockedBumpThreshold.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (lockingWithMovement);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doSiren_I;
#pragma warning disable 0169
		static Delegate GetDoSiren_IHandler ()
		{
			if (cb_doSiren_I == null)
				cb_doSiren_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_DoSiren_I);
			return cb_doSiren_I;
		}

		static void n_DoSiren_I (IntPtr jnienv, IntPtr native__this, int seconds)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoSiren (seconds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doSiren' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doSiren", "(I)V", "GetDoSiren_IHandler")]
		public virtual unsafe void DoSiren (int seconds)
		{
			const string __id = "doSiren.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (seconds);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoSleep ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doSleep' and count(parameter)=0]"
		[Register ("doSleep", "()V", "GetDoSleepHandler")]
		public virtual unsafe void DoSleep ()
		{
			const string __id = "doSleep.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_doStop;
#pragma warning disable 0169
		static Delegate GetDoStopHandler ()
		{
			if (cb_doStop == null)
				cb_doStop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DoStop);
			return cb_doStop;
		}

		static void n_DoStop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoStop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doStop' and count(parameter)=0]"
		[Register ("doStop", "()V", "GetDoStopHandler")]
		public virtual unsafe void DoStop ()
		{
			const string __id = "doStop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_doUnbond;
#pragma warning disable 0169
		static Delegate GetDoUnbondHandler ()
		{
			if (cb_doUnbond == null)
				cb_doUnbond = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DoUnbond);
			return cb_doUnbond;
		}

		static void n_DoUnbond (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoUnbond ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doUnbond' and count(parameter)=0]"
		[Register ("doUnbond", "()V", "GetDoUnbondHandler")]
		public virtual unsafe void DoUnbond ()
		{
			const string __id = "doUnbond.()V";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoUnlock ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doUnlock' and count(parameter)=0]"
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

		static Delegate cb_doWriteAssistNow_I;
#pragma warning disable 0169
		static Delegate GetDoWriteAssistNow_IHandler ()
		{
			if (cb_doWriteAssistNow_I == null)
				cb_doWriteAssistNow_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteAssistNow_I);
			return cb_doWriteAssistNow_I;
		}

		static bool n_DoWriteAssistNow_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteAssistNow (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteAssistNow' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteAssistNow", "(I)Z", "GetDoWriteAssistNow_IHandler")]
		public virtual unsafe bool DoWriteAssistNow (int setting)
		{
			const string __id = "doWriteAssistNow.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteAudioSetting_I;
#pragma warning disable 0169
		static Delegate GetDoWriteAudioSetting_IHandler ()
		{
			if (cb_doWriteAudioSetting_I == null)
				cb_doWriteAudioSetting_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteAudioSetting_I);
			return cb_doWriteAudioSetting_I;
		}

		static bool n_DoWriteAudioSetting_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteAudioSetting (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteAudioSetting' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteAudioSetting", "(I)Z", "GetDoWriteAudioSetting_IHandler")]
		public virtual unsafe bool DoWriteAudioSetting (int setting)
		{
			const string __id = "doWriteAudioSetting.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteAutolock_I;
#pragma warning disable 0169
		static Delegate GetDoWriteAutolock_IHandler ()
		{
			if (cb_doWriteAutolock_I == null)
				cb_doWriteAutolock_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteAutolock_I);
			return cb_doWriteAutolock_I;
		}

		static bool n_DoWriteAutolock_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteAutolock (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteAutolock' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteAutolock", "(I)Z", "GetDoWriteAutolock_IHandler")]
		public virtual unsafe bool DoWriteAutolock (int setting)
		{
			const string __id = "doWriteAutolock.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteDisconnectedLock_I;
#pragma warning disable 0169
		static Delegate GetDoWriteDisconnectedLock_IHandler ()
		{
			if (cb_doWriteDisconnectedLock_I == null)
				cb_doWriteDisconnectedLock_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteDisconnectedLock_I);
			return cb_doWriteDisconnectedLock_I;
		}

		static bool n_DoWriteDisconnectedLock_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteDisconnectedLock (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteDisconnectedLock' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteDisconnectedLock", "(I)Z", "GetDoWriteDisconnectedLock_IHandler")]
		public virtual unsafe bool DoWriteDisconnectedLock (int setting)
		{
			const string __id = "doWriteDisconnectedLock.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteFactoryResetSetting_I;
#pragma warning disable 0169
		static Delegate GetDoWriteFactoryResetSetting_IHandler ()
		{
			if (cb_doWriteFactoryResetSetting_I == null)
				cb_doWriteFactoryResetSetting_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_DoWriteFactoryResetSetting_I);
			return cb_doWriteFactoryResetSetting_I;
		}

		static void n_DoWriteFactoryResetSetting_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoWriteFactoryResetSetting (value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteFactoryResetSetting' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteFactoryResetSetting", "(I)V", "GetDoWriteFactoryResetSetting_IHandler")]
		public virtual unsafe void DoWriteFactoryResetSetting (int value)
		{
			const string __id = "doWriteFactoryResetSetting.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_doWriteFullGps_I;
#pragma warning disable 0169
		static Delegate GetDoWriteFullGps_IHandler ()
		{
			if (cb_doWriteFullGps_I == null)
				cb_doWriteFullGps_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteFullGps_I);
			return cb_doWriteFullGps_I;
		}

		static bool n_DoWriteFullGps_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteFullGps (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteFullGps' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteFullGps", "(I)Z", "GetDoWriteFullGps_IHandler")]
		public virtual unsafe bool DoWriteFullGps (int setting)
		{
			const string __id = "doWriteFullGps.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteGnssFilter_I;
#pragma warning disable 0169
		static Delegate GetDoWriteGnssFilter_IHandler ()
		{
			if (cb_doWriteGnssFilter_I == null)
				cb_doWriteGnssFilter_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteGnssFilter_I);
			return cb_doWriteGnssFilter_I;
		}

		static bool n_DoWriteGnssFilter_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteGnssFilter (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteGnssFilter' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteGnssFilter", "(I)Z", "GetDoWriteGnssFilter_IHandler")]
		public virtual unsafe bool DoWriteGnssFilter (int setting)
		{
			const string __id = "doWriteGnssFilter.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteGnssMode_I;
#pragma warning disable 0169
		static Delegate GetDoWriteGnssMode_IHandler ()
		{
			if (cb_doWriteGnssMode_I == null)
				cb_doWriteGnssMode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteGnssMode_I);
			return cb_doWriteGnssMode_I;
		}

		static bool n_DoWriteGnssMode_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteGnssMode (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteGnssMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteGnssMode", "(I)Z", "GetDoWriteGnssMode_IHandler")]
		public virtual unsafe bool DoWriteGnssMode (int setting)
		{
			const string __id = "doWriteGnssMode.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteGpsMode_I;
#pragma warning disable 0169
		static Delegate GetDoWriteGpsMode_IHandler ()
		{
			if (cb_doWriteGpsMode_I == null)
				cb_doWriteGpsMode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteGpsMode_I);
			return cb_doWriteGpsMode_I;
		}

		static bool n_DoWriteGpsMode_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteGpsMode (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteGpsMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteGpsMode", "(I)Z", "GetDoWriteGpsMode_IHandler")]
		public virtual unsafe bool DoWriteGpsMode (int setting)
		{
			const string __id = "doWriteGpsMode.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteGpsOffBattery_I;
#pragma warning disable 0169
		static Delegate GetDoWriteGpsOffBattery_IHandler ()
		{
			if (cb_doWriteGpsOffBattery_I == null)
				cb_doWriteGpsOffBattery_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteGpsOffBattery_I);
			return cb_doWriteGpsOffBattery_I;
		}

		static bool n_DoWriteGpsOffBattery_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteGpsOffBattery (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteGpsOffBattery' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteGpsOffBattery", "(I)Z", "GetDoWriteGpsOffBattery_IHandler")]
		public virtual unsafe bool DoWriteGpsOffBattery (int setting)
		{
			const string __id = "doWriteGpsOffBattery.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteIpAddr_I;
#pragma warning disable 0169
		static Delegate GetDoWriteIpAddr_IHandler ()
		{
			if (cb_doWriteIpAddr_I == null)
				cb_doWriteIpAddr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteIpAddr_I);
			return cb_doWriteIpAddr_I;
		}

		static bool n_DoWriteIpAddr_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteIpAddr (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteIpAddr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteIpAddr", "(I)Z", "GetDoWriteIpAddr_IHandler")]
		public virtual unsafe bool DoWriteIpAddr (int setting)
		{
			const string __id = "doWriteIpAddr.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteKeyfobSettings_Ljava_math_BigInteger_Ljava_math_BigInteger_Ljava_math_BigInteger_II;
#pragma warning disable 0169
		static Delegate GetDoWriteKeyfobSettings_Ljava_math_BigInteger_Ljava_math_BigInteger_Ljava_math_BigInteger_IIHandler ()
		{
			if (cb_doWriteKeyfobSettings_Ljava_math_BigInteger_Ljava_math_BigInteger_Ljava_math_BigInteger_II == null)
				cb_doWriteKeyfobSettings_Ljava_math_BigInteger_Ljava_math_BigInteger_Ljava_math_BigInteger_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLII_V) n_DoWriteKeyfobSettings_Ljava_math_BigInteger_Ljava_math_BigInteger_Ljava_math_BigInteger_II);
			return cb_doWriteKeyfobSettings_Ljava_math_BigInteger_Ljava_math_BigInteger_Ljava_math_BigInteger_II;
		}

		static void n_DoWriteKeyfobSettings_Ljava_math_BigInteger_Ljava_math_BigInteger_Ljava_math_BigInteger_II (IntPtr jnienv, IntPtr native__this, IntPtr native_uuid0, IntPtr native_macId, IntPtr native_uuid1, int major, int minor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uuid0 = global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (native_uuid0, JniHandleOwnership.DoNotTransfer);
			var macId = global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (native_macId, JniHandleOwnership.DoNotTransfer);
			var uuid1 = global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (native_uuid1, JniHandleOwnership.DoNotTransfer);
			__this.DoWriteKeyfobSettings (uuid0, macId, uuid1, major, minor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteKeyfobSettings' and count(parameter)=5 and parameter[1][@type='java.math.BigInteger'] and parameter[2][@type='java.math.BigInteger'] and parameter[3][@type='java.math.BigInteger'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("doWriteKeyfobSettings", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;II)V", "GetDoWriteKeyfobSettings_Ljava_math_BigInteger_Ljava_math_BigInteger_Ljava_math_BigInteger_IIHandler")]
		public virtual unsafe void DoWriteKeyfobSettings (global::Java.Math.BigInteger uuid0, global::Java.Math.BigInteger macId, global::Java.Math.BigInteger uuid1, int major, int minor)
		{
			const string __id = "doWriteKeyfobSettings.(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((uuid0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uuid0).Handle);
				__args [1] = new JniArgumentValue ((macId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) macId).Handle);
				__args [2] = new JniArgumentValue ((uuid1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uuid1).Handle);
				__args [3] = new JniArgumentValue (major);
				__args [4] = new JniArgumentValue (minor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (uuid0);
				global::System.GC.KeepAlive (macId);
				global::System.GC.KeepAlive (uuid1);
			}
		}

		static Delegate cb_doWriteLeoSpeed_I;
#pragma warning disable 0169
		static Delegate GetDoWriteLeoSpeed_IHandler ()
		{
			if (cb_doWriteLeoSpeed_I == null)
				cb_doWriteLeoSpeed_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteLeoSpeed_I);
			return cb_doWriteLeoSpeed_I;
		}

		static bool n_DoWriteLeoSpeed_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteLeoSpeed (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteLeoSpeed' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteLeoSpeed", "(I)Z", "GetDoWriteLeoSpeed_IHandler")]
		public virtual unsafe bool DoWriteLeoSpeed (int setting)
		{
			const string __id = "doWriteLeoSpeed.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteLockBattery_I;
#pragma warning disable 0169
		static Delegate GetDoWriteLockBattery_IHandler ()
		{
			if (cb_doWriteLockBattery_I == null)
				cb_doWriteLockBattery_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteLockBattery_I);
			return cb_doWriteLockBattery_I;
		}

		static bool n_DoWriteLockBattery_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteLockBattery (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteLockBattery' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteLockBattery", "(I)Z", "GetDoWriteLockBattery_IHandler")]
		public virtual unsafe bool DoWriteLockBattery (int setting)
		{
			const string __id = "doWriteLockBattery.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteLockSleep_I;
#pragma warning disable 0169
		static Delegate GetDoWriteLockSleep_IHandler ()
		{
			if (cb_doWriteLockSleep_I == null)
				cb_doWriteLockSleep_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteLockSleep_I);
			return cb_doWriteLockSleep_I;
		}

		static bool n_DoWriteLockSleep_I (IntPtr jnienv, IntPtr native__this, int sleepSeconds)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteLockSleep (sleepSeconds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteLockSleep' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteLockSleep", "(I)Z", "GetDoWriteLockSleep_IHandler")]
		public virtual unsafe bool DoWriteLockSleep (int sleepSeconds)
		{
			const string __id = "doWriteLockSleep.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sleepSeconds);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteLockedPing_I;
#pragma warning disable 0169
		static Delegate GetDoWriteLockedPing_IHandler ()
		{
			if (cb_doWriteLockedPing_I == null)
				cb_doWriteLockedPing_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteLockedPing_I);
			return cb_doWriteLockedPing_I;
		}

		static bool n_DoWriteLockedPing_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteLockedPing (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteLockedPing' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteLockedPing", "(I)Z", "GetDoWriteLockedPing_IHandler")]
		public virtual unsafe bool DoWriteLockedPing (int setting)
		{
			const string __id = "doWriteLockedPing.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteLoopControl_I;
#pragma warning disable 0169
		static Delegate GetDoWriteLoopControl_IHandler ()
		{
			if (cb_doWriteLoopControl_I == null)
				cb_doWriteLoopControl_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteLoopControl_I);
			return cb_doWriteLoopControl_I;
		}

		static bool n_DoWriteLoopControl_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteLoopControl (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteLoopControl' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteLoopControl", "(I)Z", "GetDoWriteLoopControl_IHandler")]
		public virtual unsafe bool DoWriteLoopControl (int setting)
		{
			const string __id = "doWriteLoopControl.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteModemType_I;
#pragma warning disable 0169
		static Delegate GetDoWriteModemType_IHandler ()
		{
			if (cb_doWriteModemType_I == null)
				cb_doWriteModemType_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteModemType_I);
			return cb_doWriteModemType_I;
		}

		static bool n_DoWriteModemType_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteModemType (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteModemType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteModemType", "(I)Z", "GetDoWriteModemType_IHandler")]
		public virtual unsafe bool DoWriteModemType (int setting)
		{
			const string __id = "doWriteModemType.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteNetworkCode_I;
#pragma warning disable 0169
		static Delegate GetDoWriteNetworkCode_IHandler ()
		{
			if (cb_doWriteNetworkCode_I == null)
				cb_doWriteNetworkCode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteNetworkCode_I);
			return cb_doWriteNetworkCode_I;
		}

		static bool n_DoWriteNetworkCode_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteNetworkCode (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteNetworkCode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteNetworkCode", "(I)Z", "GetDoWriteNetworkCode_IHandler")]
		public virtual unsafe bool DoWriteNetworkCode (int setting)
		{
			const string __id = "doWriteNetworkCode.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWritePAC_I;
#pragma warning disable 0169
		static Delegate GetDoWritePAC_IHandler ()
		{
			if (cb_doWritePAC_I == null)
				cb_doWritePAC_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWritePAC_I);
			return cb_doWritePAC_I;
		}

		static bool n_DoWritePAC_I (IntPtr jnienv, IntPtr native__this, int pac)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWritePAC (pac);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWritePAC' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWritePAC", "(I)Z", "GetDoWritePAC_IHandler")]
		public virtual unsafe bool DoWritePAC (int pac)
		{
			const string __id = "doWritePAC.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pac);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWritePeriodAInterval_I;
#pragma warning disable 0169
		static Delegate GetDoWritePeriodAInterval_IHandler ()
		{
			if (cb_doWritePeriodAInterval_I == null)
				cb_doWritePeriodAInterval_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWritePeriodAInterval_I);
			return cb_doWritePeriodAInterval_I;
		}

		static bool n_DoWritePeriodAInterval_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWritePeriodAInterval (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWritePeriodAInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWritePeriodAInterval", "(I)Z", "GetDoWritePeriodAInterval_IHandler")]
		public virtual unsafe bool DoWritePeriodAInterval (int setting)
		{
			const string __id = "doWritePeriodAInterval.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWritePeriodAStart_I;
#pragma warning disable 0169
		static Delegate GetDoWritePeriodAStart_IHandler ()
		{
			if (cb_doWritePeriodAStart_I == null)
				cb_doWritePeriodAStart_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWritePeriodAStart_I);
			return cb_doWritePeriodAStart_I;
		}

		static bool n_DoWritePeriodAStart_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWritePeriodAStart (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWritePeriodAStart' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWritePeriodAStart", "(I)Z", "GetDoWritePeriodAStart_IHandler")]
		public virtual unsafe bool DoWritePeriodAStart (int setting)
		{
			const string __id = "doWritePeriodAStart.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWritePeriodBInterval_I;
#pragma warning disable 0169
		static Delegate GetDoWritePeriodBInterval_IHandler ()
		{
			if (cb_doWritePeriodBInterval_I == null)
				cb_doWritePeriodBInterval_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWritePeriodBInterval_I);
			return cb_doWritePeriodBInterval_I;
		}

		static bool n_DoWritePeriodBInterval_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWritePeriodBInterval (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWritePeriodBInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWritePeriodBInterval", "(I)Z", "GetDoWritePeriodBInterval_IHandler")]
		public virtual unsafe bool DoWritePeriodBInterval (int setting)
		{
			const string __id = "doWritePeriodBInterval.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWritePeriodBStart_I;
#pragma warning disable 0169
		static Delegate GetDoWritePeriodBStart_IHandler ()
		{
			if (cb_doWritePeriodBStart_I == null)
				cb_doWritePeriodBStart_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWritePeriodBStart_I);
			return cb_doWritePeriodBStart_I;
		}

		static bool n_DoWritePeriodBStart_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWritePeriodBStart (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWritePeriodBStart' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWritePeriodBStart", "(I)Z", "GetDoWritePeriodBStart_IHandler")]
		public virtual unsafe bool DoWritePeriodBStart (int setting)
		{
			const string __id = "doWritePeriodBStart.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteRemoteCommands_I;
#pragma warning disable 0169
		static Delegate GetDoWriteRemoteCommands_IHandler ()
		{
			if (cb_doWriteRemoteCommands_I == null)
				cb_doWriteRemoteCommands_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteRemoteCommands_I);
			return cb_doWriteRemoteCommands_I;
		}

		static bool n_DoWriteRemoteCommands_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteRemoteCommands (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteRemoteCommands' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteRemoteCommands", "(I)Z", "GetDoWriteRemoteCommands_IHandler")]
		public virtual unsafe bool DoWriteRemoteCommands (int setting)
		{
			const string __id = "doWriteRemoteCommands.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteSleepBattery_I;
#pragma warning disable 0169
		static Delegate GetDoWriteSleepBattery_IHandler ()
		{
			if (cb_doWriteSleepBattery_I == null)
				cb_doWriteSleepBattery_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteSleepBattery_I);
			return cb_doWriteSleepBattery_I;
		}

		static bool n_DoWriteSleepBattery_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteSleepBattery (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteSleepBattery' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteSleepBattery", "(I)Z", "GetDoWriteSleepBattery_IHandler")]
		public virtual unsafe bool DoWriteSleepBattery (int setting)
		{
			const string __id = "doWriteSleepBattery.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteStatePing_I;
#pragma warning disable 0169
		static Delegate GetDoWriteStatePing_IHandler ()
		{
			if (cb_doWriteStatePing_I == null)
				cb_doWriteStatePing_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteStatePing_I);
			return cb_doWriteStatePing_I;
		}

		static bool n_DoWriteStatePing_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteStatePing (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteStatePing' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteStatePing", "(I)Z", "GetDoWriteStatePing_IHandler")]
		public virtual unsafe bool DoWriteStatePing (int setting)
		{
			const string __id = "doWriteStatePing.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteTheftDuration_I;
#pragma warning disable 0169
		static Delegate GetDoWriteTheftDuration_IHandler ()
		{
			if (cb_doWriteTheftDuration_I == null)
				cb_doWriteTheftDuration_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteTheftDuration_I);
			return cb_doWriteTheftDuration_I;
		}

		static bool n_DoWriteTheftDuration_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteTheftDuration (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteTheftDuration' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteTheftDuration", "(I)Z", "GetDoWriteTheftDuration_IHandler")]
		public virtual unsafe bool DoWriteTheftDuration (int setting)
		{
			const string __id = "doWriteTheftDuration.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteTheftInterval_I;
#pragma warning disable 0169
		static Delegate GetDoWriteTheftInterval_IHandler ()
		{
			if (cb_doWriteTheftInterval_I == null)
				cb_doWriteTheftInterval_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteTheftInterval_I);
			return cb_doWriteTheftInterval_I;
		}

		static bool n_DoWriteTheftInterval_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteTheftInterval (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteTheftInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteTheftInterval", "(I)Z", "GetDoWriteTheftInterval_IHandler")]
		public virtual unsafe bool DoWriteTheftInterval (int setting)
		{
			const string __id = "doWriteTheftInterval.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteUnlockBattery_I;
#pragma warning disable 0169
		static Delegate GetDoWriteUnlockBattery_IHandler ()
		{
			if (cb_doWriteUnlockBattery_I == null)
				cb_doWriteUnlockBattery_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteUnlockBattery_I);
			return cb_doWriteUnlockBattery_I;
		}

		static bool n_DoWriteUnlockBattery_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteUnlockBattery (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteUnlockBattery' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteUnlockBattery", "(I)Z", "GetDoWriteUnlockBattery_IHandler")]
		public virtual unsafe bool DoWriteUnlockBattery (int setting)
		{
			const string __id = "doWriteUnlockBattery.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteUnlockDuration_I;
#pragma warning disable 0169
		static Delegate GetDoWriteUnlockDuration_IHandler ()
		{
			if (cb_doWriteUnlockDuration_I == null)
				cb_doWriteUnlockDuration_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteUnlockDuration_I);
			return cb_doWriteUnlockDuration_I;
		}

		static bool n_DoWriteUnlockDuration_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteUnlockDuration (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteUnlockDuration' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteUnlockDuration", "(I)Z", "GetDoWriteUnlockDuration_IHandler")]
		public virtual unsafe bool DoWriteUnlockDuration (int setting)
		{
			const string __id = "doWriteUnlockDuration.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteUnlockedDisconnectedSleep_I;
#pragma warning disable 0169
		static Delegate GetDoWriteUnlockedDisconnectedSleep_IHandler ()
		{
			if (cb_doWriteUnlockedDisconnectedSleep_I == null)
				cb_doWriteUnlockedDisconnectedSleep_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteUnlockedDisconnectedSleep_I);
			return cb_doWriteUnlockedDisconnectedSleep_I;
		}

		static bool n_DoWriteUnlockedDisconnectedSleep_I (IntPtr jnienv, IntPtr native__this, int sleepSeconds)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteUnlockedDisconnectedSleep (sleepSeconds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteUnlockedDisconnectedSleep' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteUnlockedDisconnectedSleep", "(I)Z", "GetDoWriteUnlockedDisconnectedSleep_IHandler")]
		public virtual unsafe bool DoWriteUnlockedDisconnectedSleep (int sleepSeconds)
		{
			const string __id = "doWriteUnlockedDisconnectedSleep.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sleepSeconds);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteUnlockedMovement_I;
#pragma warning disable 0169
		static Delegate GetDoWriteUnlockedMovement_IHandler ()
		{
			if (cb_doWriteUnlockedMovement_I == null)
				cb_doWriteUnlockedMovement_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteUnlockedMovement_I);
			return cb_doWriteUnlockedMovement_I;
		}

		static bool n_DoWriteUnlockedMovement_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteUnlockedMovement (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteUnlockedMovement' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteUnlockedMovement", "(I)Z", "GetDoWriteUnlockedMovement_IHandler")]
		public virtual unsafe bool DoWriteUnlockedMovement (int setting)
		{
			const string __id = "doWriteUnlockedMovement.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteUnlockedPing_I;
#pragma warning disable 0169
		static Delegate GetDoWriteUnlockedPing_IHandler ()
		{
			if (cb_doWriteUnlockedPing_I == null)
				cb_doWriteUnlockedPing_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteUnlockedPing_I);
			return cb_doWriteUnlockedPing_I;
		}

		static bool n_DoWriteUnlockedPing_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteUnlockedPing (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteUnlockedPing' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteUnlockedPing", "(I)Z", "GetDoWriteUnlockedPing_IHandler")]
		public virtual unsafe bool DoWriteUnlockedPing (int setting)
		{
			const string __id = "doWriteUnlockedPing.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doWriteVolume_I;
#pragma warning disable 0169
		static Delegate GetDoWriteVolume_IHandler ()
		{
			if (cb_doWriteVolume_I == null)
				cb_doWriteVolume_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_DoWriteVolume_I);
			return cb_doWriteVolume_I;
		}

		static bool n_DoWriteVolume_I (IntPtr jnienv, IntPtr native__this, int setting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWriteVolume (setting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doWriteVolume' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doWriteVolume", "(I)Z", "GetDoWriteVolume_IHandler")]
		public virtual unsafe bool DoWriteVolume (int setting)
		{
			const string __id = "doWriteVolume.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doresetReboot;
#pragma warning disable 0169
		static Delegate GetDoresetRebootHandler ()
		{
			if (cb_doresetReboot == null)
				cb_doresetReboot = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DoresetReboot);
			return cb_doresetReboot;
		}

		static void n_DoresetReboot (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoresetReboot ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='doresetReboot' and count(parameter)=0]"
		[Register ("doresetReboot", "()V", "GetDoresetRebootHandler")]
		public virtual unsafe void DoresetReboot ()
		{
			const string __id = "doresetReboot.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_emptyEncryptedSettingsQueue;
#pragma warning disable 0169
		static Delegate GetEmptyEncryptedSettingsQueueHandler ()
		{
			if (cb_emptyEncryptedSettingsQueue == null)
				cb_emptyEncryptedSettingsQueue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_EmptyEncryptedSettingsQueue);
			return cb_emptyEncryptedSettingsQueue;
		}

		static void n_EmptyEncryptedSettingsQueue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EmptyEncryptedSettingsQueue ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='emptyEncryptedSettingsQueue' and count(parameter)=0]"
		[Register ("emptyEncryptedSettingsQueue", "()V", "GetEmptyEncryptedSettingsQueueHandler")]
		public virtual unsafe void EmptyEncryptedSettingsQueue ()
		{
			const string __id = "emptyEncryptedSettingsQueue.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='incrementMacAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("incrementMacAddress", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string IncrementMacAddress (string mId)
		{
			const string __id = "incrementMacAddress.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_mId = JNIEnv.NewString (mId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_mId);
			}
		}

		static Delegate cb_initialize;
#pragma warning disable 0169
		static Delegate GetInitializeHandler ()
		{
			if (cb_initialize == null)
				cb_initialize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Initialize);
			return cb_initialize;
		}

		static void n_Initialize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Initialize ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='initialize' and count(parameter)=0]"
		[Register ("initialize", "()V", "GetInitializeHandler")]
		public virtual unsafe void Initialize ()
		{
			const string __id = "initialize.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='keyfobMacFromInt' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("keyfobMacFromInt", "(J)Ljava/lang/String;", "")]
		public static unsafe string KeyfobMacFromInt (long i)
		{
			const string __id = "keyfobMacFromInt.(J)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_refreshBluetoothCache;
#pragma warning disable 0169
		static Delegate GetRefreshBluetoothCacheHandler ()
		{
			if (cb_refreshBluetoothCache == null)
				cb_refreshBluetoothCache = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_RefreshBluetoothCache);
			return cb_refreshBluetoothCache;
		}

		static void n_RefreshBluetoothCache (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RefreshBluetoothCache ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='refreshBluetoothCache' and count(parameter)=0]"
		[Register ("refreshBluetoothCache", "()V", "GetRefreshBluetoothCacheHandler")]
		public virtual unsafe void RefreshBluetoothCache ()
		{
			const string __id = "refreshBluetoothCache.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeFactoryResetCallback;
#pragma warning disable 0169
		static Delegate GetRemoveFactoryResetCallbackHandler ()
		{
			if (cb_removeFactoryResetCallback == null)
				cb_removeFactoryResetCallback = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_RemoveFactoryResetCallback);
			return cb_removeFactoryResetCallback;
		}

		static void n_RemoveFactoryResetCallback (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveFactoryResetCallback ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='removeFactoryResetCallback' and count(parameter)=0]"
		[Register ("removeFactoryResetCallback", "()V", "GetRemoveFactoryResetCallbackHandler")]
		public virtual unsafe void RemoveFactoryResetCallback ()
		{
			const string __id = "removeFactoryResetCallback.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_revokeKeyfob;
#pragma warning disable 0169
		static Delegate GetRevokeKeyfobHandler ()
		{
			if (cb_revokeKeyfob == null)
				cb_revokeKeyfob = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_RevokeKeyfob);
			return cb_revokeKeyfob;
		}

		static void n_RevokeKeyfob (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RevokeKeyfob ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='revokeKeyfob' and count(parameter)=0]"
		[Register ("revokeKeyfob", "()V", "GetRevokeKeyfobHandler")]
		public virtual unsafe void RevokeKeyfob ()
		{
			const string __id = "revokeKeyfob.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setConnectionManager_Lcom_linka_linkaapikit_module_widget_LockController_LinkaBLEConnectionManager_;
#pragma warning disable 0169
		static Delegate GetSetConnectionManager_Lcom_linka_linkaapikit_module_widget_LockController_LinkaBLEConnectionManager_Handler ()
		{
			if (cb_setConnectionManager_Lcom_linka_linkaapikit_module_widget_LockController_LinkaBLEConnectionManager_ == null)
				cb_setConnectionManager_Lcom_linka_linkaapikit_module_widget_LockController_LinkaBLEConnectionManager_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetConnectionManager_Lcom_linka_linkaapikit_module_widget_LockController_LinkaBLEConnectionManager_);
			return cb_setConnectionManager_Lcom_linka_linkaapikit_module_widget_LockController_LinkaBLEConnectionManager_;
		}

		static void n_SetConnectionManager_Lcom_linka_linkaapikit_module_widget_LockController_LinkaBLEConnectionManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_connectionManager)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var connectionManager = (global::Com.Linka.Linkaapikit.Module.Widget.LockController.ILinkaBLEConnectionManager)global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController.ILinkaBLEConnectionManager> (native_connectionManager, JniHandleOwnership.DoNotTransfer);
			__this.SetConnectionManager (connectionManager);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='setConnectionManager' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.widget.LockController.LinkaBLEConnectionManager']]"
		[Register ("setConnectionManager", "(Lcom/linka/linkaapikit/module/widget/LockController$LinkaBLEConnectionManager;)V", "GetSetConnectionManager_Lcom_linka_linkaapikit_module_widget_LockController_LinkaBLEConnectionManager_Handler")]
		public virtual unsafe void SetConnectionManager (global::Com.Linka.Linkaapikit.Module.Widget.LockController.ILinkaBLEConnectionManager connectionManager)
		{
			const string __id = "setConnectionManager.(Lcom/linka/linkaapikit/module/widget/LockController$LinkaBLEConnectionManager;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((connectionManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connectionManager).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (connectionManager);
			}
		}

		static Delegate cb_setFactoryResetCallbacks_Lcom_linka_linkaapikit_module_model_RevocationController_FactoryResetCallback_;
#pragma warning disable 0169
		static Delegate GetSetFactoryResetCallbacks_Lcom_linka_linkaapikit_module_model_RevocationController_FactoryResetCallback_Handler ()
		{
			if (cb_setFactoryResetCallbacks_Lcom_linka_linkaapikit_module_model_RevocationController_FactoryResetCallback_ == null)
				cb_setFactoryResetCallbacks_Lcom_linka_linkaapikit_module_model_RevocationController_FactoryResetCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFactoryResetCallbacks_Lcom_linka_linkaapikit_module_model_RevocationController_FactoryResetCallback_);
			return cb_setFactoryResetCallbacks_Lcom_linka_linkaapikit_module_model_RevocationController_FactoryResetCallback_;
		}

		static void n_SetFactoryResetCallbacks_Lcom_linka_linkaapikit_module_model_RevocationController_FactoryResetCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Linka.Linkaapikit.Module.Model.RevocationController.IFactoryResetCallback)global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.RevocationController.IFactoryResetCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SetFactoryResetCallbacks (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='setFactoryResetCallbacks' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.model.RevocationController.FactoryResetCallback']]"
		[Register ("setFactoryResetCallbacks", "(Lcom/linka/linkaapikit/module/model/RevocationController$FactoryResetCallback;)V", "GetSetFactoryResetCallbacks_Lcom_linka_linkaapikit_module_model_RevocationController_FactoryResetCallback_Handler")]
		public virtual unsafe void SetFactoryResetCallbacks (global::Com.Linka.Linkaapikit.Module.Model.RevocationController.IFactoryResetCallback @callback)
		{
			const string __id = "setFactoryResetCallbacks.(Lcom/linka/linkaapikit/module/model/RevocationController$FactoryResetCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_setOnRefreshListener_Lcom_linka_linkaapikit_module_widget_LockController_OnRefreshListener_;
#pragma warning disable 0169
		static Delegate GetSetOnRefreshListener_Lcom_linka_linkaapikit_module_widget_LockController_OnRefreshListener_Handler ()
		{
			if (cb_setOnRefreshListener_Lcom_linka_linkaapikit_module_widget_LockController_OnRefreshListener_ == null)
				cb_setOnRefreshListener_Lcom_linka_linkaapikit_module_widget_LockController_OnRefreshListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnRefreshListener_Lcom_linka_linkaapikit_module_widget_LockController_OnRefreshListener_);
			return cb_setOnRefreshListener_Lcom_linka_linkaapikit_module_widget_LockController_OnRefreshListener_;
		}

		static void n_SetOnRefreshListener_Lcom_linka_linkaapikit_module_widget_LockController_OnRefreshListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onRefreshListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var onRefreshListener = (global::Com.Linka.Linkaapikit.Module.Widget.LockController.IOnRefreshListener)global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController.IOnRefreshListener> (native_onRefreshListener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnRefreshListener (onRefreshListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LockController']/method[@name='setOnRefreshListener' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.widget.LockController.OnRefreshListener']]"
		[Register ("setOnRefreshListener", "(Lcom/linka/linkaapikit/module/widget/LockController$OnRefreshListener;)V", "GetSetOnRefreshListener_Lcom_linka_linkaapikit_module_widget_LockController_OnRefreshListener_Handler")]
		public virtual unsafe void SetOnRefreshListener (global::Com.Linka.Linkaapikit.Module.Widget.LockController.IOnRefreshListener onRefreshListener)
		{
			const string __id = "setOnRefreshListener.(Lcom/linka/linkaapikit/module/widget/LockController$OnRefreshListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onRefreshListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onRefreshListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (onRefreshListener);
			}
		}

		#region "Event implementation for Com.Linka.Linkaapikit.Module.Widget.LockController.IOnRefreshListener"

		public event EventHandler<global::Com.Linka.Linkaapikit.Module.Widget.LockController.RefreshEventArgs> Refresh {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linka.Linkaapikit.Module.Widget.LockController.IOnRefreshListener, global::Com.Linka.Linkaapikit.Module.Widget.LockController.IOnRefreshListenerImplementor>(
				ref weak_implementor_SetOnRefreshListener,
				__CreateIOnRefreshListenerImplementor,
				SetOnRefreshListener,
				__h => __h.OnRefreshHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linka.Linkaapikit.Module.Widget.LockController.IOnRefreshListener, global::Com.Linka.Linkaapikit.Module.Widget.LockController.IOnRefreshListenerImplementor>(
				ref weak_implementor_SetOnRefreshListener,
				global::Com.Linka.Linkaapikit.Module.Widget.LockController.IOnRefreshListenerImplementor.__IsEmpty,
				__v => SetOnRefreshListener (null),
				__h => __h.OnRefreshHandler -= value);
			}
		}

		public event EventHandler<global::Com.Linka.Linkaapikit.Module.Widget.LockController.RefreshSettingsEventArgs> RefreshSettings {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linka.Linkaapikit.Module.Widget.LockController.IOnRefreshListener, global::Com.Linka.Linkaapikit.Module.Widget.LockController.IOnRefreshListenerImplementor>(
				ref weak_implementor_SetOnRefreshListener,
				__CreateIOnRefreshListenerImplementor,
				SetOnRefreshListener,
				__h => __h.OnRefreshSettingsHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linka.Linkaapikit.Module.Widget.LockController.IOnRefreshListener, global::Com.Linka.Linkaapikit.Module.Widget.LockController.IOnRefreshListenerImplementor>(
				ref weak_implementor_SetOnRefreshListener,
				global::Com.Linka.Linkaapikit.Module.Widget.LockController.IOnRefreshListenerImplementor.__IsEmpty,
				__v => SetOnRefreshListener (null),
				__h => __h.OnRefreshSettingsHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnRefreshListener;

		global::Com.Linka.Linkaapikit.Module.Widget.LockController.IOnRefreshListenerImplementor __CreateIOnRefreshListenerImplementor ()
		{
			return new global::Com.Linka.Linkaapikit.Module.Widget.LockController.IOnRefreshListenerImplementor (this);
		}

		#endregion

	}
}
