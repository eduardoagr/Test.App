using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linka.Linkaapikit.Module.Lock.BLE {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeService']"
	[global::Android.Runtime.Register ("com/linka/linkaapikit/module/Lock/BLE/BluetoothLeService", DoNotGenerateAcw=true)]
	public partial class BluetoothLeService : global::Android.App.Service {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeService']/field[@name='ACTION_DATA_AVAILABLE']"
		[Register ("ACTION_DATA_AVAILABLE")]
		public const string ActionDataAvailable = (string) "com.example.bluetooth.le.ACTION_DATA_AVAILABLE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeService']/field[@name='ACTION_GATT_CONNECTED']"
		[Register ("ACTION_GATT_CONNECTED")]
		public const string ActionGattConnected = (string) "com.example.bluetooth.le.ACTION_GATT_CONNECTED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeService']/field[@name='ACTION_GATT_DISCONNECTED']"
		[Register ("ACTION_GATT_DISCONNECTED")]
		public const string ActionGattDisconnected = (string) "com.example.bluetooth.le.ACTION_GATT_DISCONNECTED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeService']/field[@name='ACTION_GATT_SERVICES_DISCOVERED']"
		[Register ("ACTION_GATT_SERVICES_DISCOVERED")]
		public const string ActionGattServicesDiscovered = (string) "com.example.bluetooth.le.ACTION_GATT_SERVICES_DISCOVERED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeService']/field[@name='EXTRA_CHARACTERISTIC']"
		[Register ("EXTRA_CHARACTERISTIC")]
		public const string ExtraCharacteristic = (string) "com.example.bluetooth.le.EXTRA_CHARACTERISTIC";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeService']/field[@name='EXTRA_DATA']"
		[Register ("EXTRA_DATA")]
		public const string ExtraData = (string) "com.example.bluetooth.le.EXTRA_DATA";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/Lock/BLE/BluetoothLeService", typeof (BluetoothLeService));

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

		protected BluetoothLeService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeService']/constructor[@name='BluetoothLeService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BluetoothLeService () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getSupportedGattServices;
#pragma warning disable 0169
		static Delegate GetGetSupportedGattServicesHandler ()
		{
			if (cb_getSupportedGattServices == null)
				cb_getSupportedGattServices = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSupportedGattServices);
			return cb_getSupportedGattServices;
		}

		static IntPtr n_GetSupportedGattServices (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothGattService>.ToLocalJniHandle (__this.SupportedGattServices);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothGattService> SupportedGattServices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeService']/method[@name='getSupportedGattServices' and count(parameter)=0]"
			[Register ("getSupportedGattServices", "()Ljava/util/List;", "GetGetSupportedGattServicesHandler")]
			get {
				const string __id = "getSupportedGattServices.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothGattService>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeService']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_connect_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_String_Handler ()
		{
			if (cb_connect_Ljava_lang_String_ == null)
				cb_connect_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Connect_Ljava_lang_String_);
			return cb_connect_Ljava_lang_String_;
		}

		static bool n_Connect_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_address)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var address = JNIEnv.GetString (native_address, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Connect (address);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeService']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("connect", "(Ljava/lang/String;)Z", "GetConnect_Ljava_lang_String_Handler")]
		public virtual unsafe bool Connect (string address)
		{
			const string __id = "connect.(Ljava/lang/String;)Z";
			IntPtr native_address = JNIEnv.NewString (address);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_address);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_address);
			}
		}

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Disconnect);
			return cb_disconnect;
		}

		static void n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeService']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler")]
		public virtual unsafe void Disconnect ()
		{
			const string __id = "disconnect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getCharacteristicByUUID_Ljava_util_UUID_;
#pragma warning disable 0169
		static Delegate GetGetCharacteristicByUUID_Ljava_util_UUID_Handler ()
		{
			if (cb_getCharacteristicByUUID_Ljava_util_UUID_ == null)
				cb_getCharacteristicByUUID_Ljava_util_UUID_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetCharacteristicByUUID_Ljava_util_UUID_);
			return cb_getCharacteristicByUUID_Ljava_util_UUID_;
		}

		static IntPtr n_GetCharacteristicByUUID_Ljava_util_UUID_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uuid)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uuid = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_uuid, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCharacteristicByUUID (uuid));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeService']/method[@name='getCharacteristicByUUID' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
		[Register ("getCharacteristicByUUID", "(Ljava/util/UUID;)Landroid/bluetooth/BluetoothGattCharacteristic;", "GetGetCharacteristicByUUID_Ljava_util_UUID_Handler")]
		public virtual unsafe global::Android.Bluetooth.BluetoothGattCharacteristic GetCharacteristicByUUID (global::Java.Util.UUID uuid)
		{
			const string __id = "getCharacteristicByUUID.(Ljava/util/UUID;)Landroid/bluetooth/BluetoothGattCharacteristic;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uuid).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattCharacteristic> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (uuid);
			}
		}

		static Delegate cb_initialize;
#pragma warning disable 0169
		static Delegate GetInitializeHandler ()
		{
			if (cb_initialize == null)
				cb_initialize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Initialize);
			return cb_initialize;
		}

		static bool n_Initialize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Initialize ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeService']/method[@name='initialize' and count(parameter)=0]"
		[Register ("initialize", "()Z", "GetInitializeHandler")]
		public virtual unsafe bool Initialize ()
		{
			const string __id = "initialize.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onBind_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnBind_Landroid_content_Intent_Handler ()
		{
			if (cb_onBind_Landroid_content_Intent_ == null)
				cb_onBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnBind_Landroid_content_Intent_);
			return cb_onBind_Landroid_content_Intent_;
		}

		static IntPtr n_OnBind_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (intent));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetOnBind_Landroid_content_Intent_Handler")]
		public override unsafe global::Android.OS.IBinder OnBind (global::Android.Content.Intent intent)
		{
			const string __id = "onBind.(Landroid/content/Intent;)Landroid/os/IBinder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (intent);
			}
		}

	}
}
