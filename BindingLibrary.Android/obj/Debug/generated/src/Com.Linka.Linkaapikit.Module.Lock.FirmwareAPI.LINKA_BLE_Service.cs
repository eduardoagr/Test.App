using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linka.Linkaapikit.Module.Lock.FirmwareAPI {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.FirmwareAPI']/class[@name='LINKA_BLE_Service']"
	[global::Android.Runtime.Register ("com/linka/linkaapikit/module/Lock/FirmwareAPI/LINKA_BLE_Service", DoNotGenerateAcw=true)]
	public partial class LINKA_BLE_Service : global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.FirmwareAPI']/class[@name='LINKA_BLE_Service.BluetoothGattCharacteristicBundle']"
		[global::Android.Runtime.Register ("com/linka/linkaapikit/module/Lock/FirmwareAPI/LINKA_BLE_Service$BluetoothGattCharacteristicBundle", DoNotGenerateAcw=true)]
		public partial class BluetoothGattCharacteristicBundle : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.FirmwareAPI']/class[@name='LINKA_BLE_Service.BluetoothGattCharacteristicBundle']/field[@name='mGattCharacteristics']"
			[Register ("mGattCharacteristics")]
			public global::System.Collections.IList MGattCharacteristics {
				get {
					const string __id = "mGattCharacteristics.Ljava/util/ArrayList;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "mGattCharacteristics.Ljava/util/ArrayList;";

					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.FirmwareAPI']/class[@name='LINKA_BLE_Service.BluetoothGattCharacteristicBundle']/field[@name='mNotifyCharacteristic']"
			[Register ("mNotifyCharacteristic")]
			public global::Android.Bluetooth.BluetoothGattCharacteristic MNotifyCharacteristic {
				get {
					const string __id = "mNotifyCharacteristic.Landroid/bluetooth/BluetoothGattCharacteristic;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattCharacteristic> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "mNotifyCharacteristic.Landroid/bluetooth/BluetoothGattCharacteristic;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.FirmwareAPI']/class[@name='LINKA_BLE_Service.BluetoothGattCharacteristicBundle']/field[@name='m_CharLockData']"
			[Register ("m_CharLockData")]
			public global::Android.Bluetooth.BluetoothGattCharacteristic MCharLockData {
				get {
					const string __id = "m_CharLockData.Landroid/bluetooth/BluetoothGattCharacteristic;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattCharacteristic> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "m_CharLockData.Landroid/bluetooth/BluetoothGattCharacteristic;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.FirmwareAPI']/class[@name='LINKA_BLE_Service.BluetoothGattCharacteristicBundle']/field[@name='m_CharLockStatus']"
			[Register ("m_CharLockStatus")]
			public global::Android.Bluetooth.BluetoothGattCharacteristic MCharLockStatus {
				get {
					const string __id = "m_CharLockStatus.Landroid/bluetooth/BluetoothGattCharacteristic;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattCharacteristic> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "m_CharLockStatus.Landroid/bluetooth/BluetoothGattCharacteristic;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.FirmwareAPI']/class[@name='LINKA_BLE_Service.BluetoothGattCharacteristicBundle']/field[@name='m_uartCharacteristic']"
			[Register ("m_uartCharacteristic")]
			public global::Android.Bluetooth.BluetoothGattCharacteristic MUartCharacteristic {
				get {
					const string __id = "m_uartCharacteristic.Landroid/bluetooth/BluetoothGattCharacteristic;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattCharacteristic> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "m_uartCharacteristic.Landroid/bluetooth/BluetoothGattCharacteristic;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/Lock/FirmwareAPI/LINKA_BLE_Service$BluetoothGattCharacteristicBundle", typeof (BluetoothGattCharacteristicBundle));

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

			protected BluetoothGattCharacteristicBundle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.FirmwareAPI']/class[@name='LINKA_BLE_Service.BluetoothGattCharacteristicBundle']/constructor[@name='LINKA_BLE_Service.BluetoothGattCharacteristicBundle' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe BluetoothGattCharacteristicBundle () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.FirmwareAPI']/class[@name='LINKA_BLE_Service.LocalBinder']"
		[global::Android.Runtime.Register ("com/linka/linkaapikit/module/Lock/FirmwareAPI/LINKA_BLE_Service$LocalBinder", DoNotGenerateAcw=true)]
		public partial class LocalBinder : global::Android.OS.Binder {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/Lock/FirmwareAPI/LINKA_BLE_Service$LocalBinder", typeof (LocalBinder));

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

			protected LocalBinder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.FirmwareAPI']/class[@name='LINKA_BLE_Service.LocalBinder']/constructor[@name='LINKA_BLE_Service.LocalBinder' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.Lock.FirmwareAPI.LINKA_BLE_Service']]"
			[Register (".ctor", "(Lcom/linka/linkaapikit/module/Lock/FirmwareAPI/LINKA_BLE_Service;)V", "")]
			public unsafe LocalBinder (global::Com.Linka.Linkaapikit.Module.Lock.FirmwareAPI.LINKA_BLE_Service __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate cb_getService;
#pragma warning disable 0169
			static Delegate GetGetServiceHandler ()
			{
				if (cb_getService == null)
					cb_getService = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetService);
				return cb_getService;
			}

			static IntPtr n_GetService (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.FirmwareAPI.LINKA_BLE_Service.LocalBinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Service);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Linka.Linkaapikit.Module.Lock.FirmwareAPI.LINKA_BLE_Service Service {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.FirmwareAPI']/class[@name='LINKA_BLE_Service.LocalBinder']/method[@name='getService' and count(parameter)=0]"
				[Register ("getService", "()Lcom/linka/linkaapikit/module/Lock/FirmwareAPI/LINKA_BLE_Service;", "GetGetServiceHandler")]
				get {
					const string __id = "getService.()Lcom/linka/linkaapikit/module/Lock/FirmwareAPI/LINKA_BLE_Service;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.FirmwareAPI.LINKA_BLE_Service> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/Lock/FirmwareAPI/LINKA_BLE_Service", typeof (LINKA_BLE_Service));

		internal static new IntPtr class_ref {
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

		protected LINKA_BLE_Service (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.FirmwareAPI']/class[@name='LINKA_BLE_Service']/constructor[@name='LINKA_BLE_Service' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LINKA_BLE_Service () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_a_Landroid_bluetooth_BluetoothGatt_;
#pragma warning disable 0169
		static Delegate GetA_Landroid_bluetooth_BluetoothGatt_Handler ()
		{
			if (cb_a_Landroid_bluetooth_BluetoothGatt_ == null)
				cb_a_Landroid_bluetooth_BluetoothGatt_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_A_Landroid_bluetooth_BluetoothGatt_);
			return cb_a_Landroid_bluetooth_BluetoothGatt_;
		}

		static void n_A_Landroid_bluetooth_BluetoothGatt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_gatt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.FirmwareAPI.LINKA_BLE_Service> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var gatt = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_gatt, JniHandleOwnership.DoNotTransfer);
			__this.A (gatt);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.FirmwareAPI']/class[@name='LINKA_BLE_Service']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGatt']]"
		[Register ("a", "(Landroid/bluetooth/BluetoothGatt;)V", "GetA_Landroid_bluetooth_BluetoothGatt_Handler")]
		public virtual unsafe void A (global::Android.Bluetooth.BluetoothGatt gatt)
		{
			const string __id = "a.(Landroid/bluetooth/BluetoothGatt;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((gatt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gatt).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (gatt);
			}
		}

		static Delegate cb_a_arrayBLandroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_FirmwareAPI_LINKA_BLE_Service_BluetoothGattCharacteristicBundle_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_;
#pragma warning disable 0169
		static Delegate GetA_arrayBLandroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_FirmwareAPI_LINKA_BLE_Service_BluetoothGattCharacteristicBundle_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_Handler ()
		{
			if (cb_a_arrayBLandroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_FirmwareAPI_LINKA_BLE_Service_BluetoothGattCharacteristicBundle_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ == null)
				cb_a_arrayBLandroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_FirmwareAPI_LINKA_BLE_Service_BluetoothGattCharacteristicBundle_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_Z) n_A_arrayBLandroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_FirmwareAPI_LINKA_BLE_Service_BluetoothGattCharacteristicBundle_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_);
			return cb_a_arrayBLandroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_FirmwareAPI_LINKA_BLE_Service_BluetoothGattCharacteristicBundle_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_;
		}

		static bool n_A_arrayBLandroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_FirmwareAPI_LINKA_BLE_Service_BluetoothGattCharacteristicBundle_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data, IntPtr native_gatt, IntPtr native_bundle, IntPtr native_actions)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.FirmwareAPI.LINKA_BLE_Service> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var gatt = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_gatt, JniHandleOwnership.DoNotTransfer);
			var bundle = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.FirmwareAPI.LINKA_BLE_Service.BluetoothGattCharacteristicBundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			var actions = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions> (native_actions, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.A (data, gatt, bundle, actions);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.FirmwareAPI']/class[@name='LINKA_BLE_Service']/method[@name='a' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='android.bluetooth.BluetoothGatt'] and parameter[3][@type='com.linka.linkaapikit.module.Lock.FirmwareAPI.LINKA_BLE_Service.BluetoothGattCharacteristicBundle'] and parameter[4][@type='com.linka.linkaapikit.module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions']]"
		[Register ("a", "([BLandroid/bluetooth/BluetoothGatt;Lcom/linka/linkaapikit/module/Lock/FirmwareAPI/LINKA_BLE_Service$BluetoothGattCharacteristicBundle;Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLeQueuedService$BluetoothGattQueuedActions;)Z", "GetA_arrayBLandroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_FirmwareAPI_LINKA_BLE_Service_BluetoothGattCharacteristicBundle_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_Handler")]
		public virtual unsafe bool A (byte[] data, global::Android.Bluetooth.BluetoothGatt gatt, global::Com.Linka.Linkaapikit.Module.Lock.FirmwareAPI.LINKA_BLE_Service.BluetoothGattCharacteristicBundle bundle, global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions actions)
		{
			const string __id = "a.([BLandroid/bluetooth/BluetoothGatt;Lcom/linka/linkaapikit/module/Lock/FirmwareAPI/LINKA_BLE_Service$BluetoothGattCharacteristicBundle;Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLeQueuedService$BluetoothGattQueuedActions;)Z";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue ((gatt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gatt).Handle);
				__args [2] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				__args [3] = new JniArgumentValue ((actions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actions).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
				global::System.GC.KeepAlive (gatt);
				global::System.GC.KeepAlive (bundle);
				global::System.GC.KeepAlive (actions);
			}
		}

		static Delegate cb_a_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_a_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_a_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_A_Ljava_lang_String_Ljava_lang_String_);
			return cb_a_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_A_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message, IntPtr native_tag)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.FirmwareAPI.LINKA_BLE_Service> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			var tag = JNIEnv.GetString (native_tag, JniHandleOwnership.DoNotTransfer);
			__this.A (message, tag);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.FirmwareAPI']/class[@name='LINKA_BLE_Service']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/String;)V", "GetA_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void A (string message, string tag)
		{
			const string __id = "a.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (native_tag);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				JNIEnv.DeleteLocalRef (native_tag);
			}
		}

		static Delegate cb_a_Ljava_util_UUID_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_FirmwareAPI_LINKA_BLE_Service_BluetoothGattCharacteristicBundle_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_util_UUID_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_FirmwareAPI_LINKA_BLE_Service_BluetoothGattCharacteristicBundle_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_Handler ()
		{
			if (cb_a_Ljava_util_UUID_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_FirmwareAPI_LINKA_BLE_Service_BluetoothGattCharacteristicBundle_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ == null)
				cb_a_Ljava_util_UUID_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_FirmwareAPI_LINKA_BLE_Service_BluetoothGattCharacteristicBundle_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_Z) n_A_Ljava_util_UUID_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_FirmwareAPI_LINKA_BLE_Service_BluetoothGattCharacteristicBundle_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_);
			return cb_a_Ljava_util_UUID_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_FirmwareAPI_LINKA_BLE_Service_BluetoothGattCharacteristicBundle_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_;
		}

		static bool n_A_Ljava_util_UUID_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_FirmwareAPI_LINKA_BLE_Service_BluetoothGattCharacteristicBundle_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uuid, IntPtr native_gatt, IntPtr native_bundle, IntPtr native_actions)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.FirmwareAPI.LINKA_BLE_Service> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uuid = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_uuid, JniHandleOwnership.DoNotTransfer);
			var gatt = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_gatt, JniHandleOwnership.DoNotTransfer);
			var bundle = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.FirmwareAPI.LINKA_BLE_Service.BluetoothGattCharacteristicBundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			var actions = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions> (native_actions, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.A (uuid, gatt, bundle, actions);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.FirmwareAPI']/class[@name='LINKA_BLE_Service']/method[@name='a' and count(parameter)=4 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='android.bluetooth.BluetoothGatt'] and parameter[3][@type='com.linka.linkaapikit.module.Lock.FirmwareAPI.LINKA_BLE_Service.BluetoothGattCharacteristicBundle'] and parameter[4][@type='com.linka.linkaapikit.module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions']]"
		[Register ("a", "(Ljava/util/UUID;Landroid/bluetooth/BluetoothGatt;Lcom/linka/linkaapikit/module/Lock/FirmwareAPI/LINKA_BLE_Service$BluetoothGattCharacteristicBundle;Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLeQueuedService$BluetoothGattQueuedActions;)Z", "GetA_Ljava_util_UUID_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_FirmwareAPI_LINKA_BLE_Service_BluetoothGattCharacteristicBundle_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_Handler")]
		public virtual unsafe bool A (global::Java.Util.UUID uuid, global::Android.Bluetooth.BluetoothGatt gatt, global::Com.Linka.Linkaapikit.Module.Lock.FirmwareAPI.LINKA_BLE_Service.BluetoothGattCharacteristicBundle bundle, global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions actions)
		{
			const string __id = "a.(Ljava/util/UUID;Landroid/bluetooth/BluetoothGatt;Lcom/linka/linkaapikit/module/Lock/FirmwareAPI/LINKA_BLE_Service$BluetoothGattCharacteristicBundle;Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLeQueuedService$BluetoothGattQueuedActions;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((uuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uuid).Handle);
				__args [1] = new JniArgumentValue ((gatt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gatt).Handle);
				__args [2] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				__args [3] = new JniArgumentValue ((actions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actions).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (uuid);
				global::System.GC.KeepAlive (gatt);
				global::System.GC.KeepAlive (bundle);
				global::System.GC.KeepAlive (actions);
			}
		}

		static Delegate cb_b_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_;
#pragma warning disable 0169
		static Delegate GetB_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_Handler ()
		{
			if (cb_b_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ == null)
				cb_b_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_B_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_);
			return cb_b_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_;
		}

		static IntPtr n_B_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_gatt, IntPtr native_actions)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.FirmwareAPI.LINKA_BLE_Service> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var gatt = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_gatt, JniHandleOwnership.DoNotTransfer);
			var actions = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions> (native_actions, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.B (gatt, actions));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.FirmwareAPI']/class[@name='LINKA_BLE_Service']/method[@name='b' and count(parameter)=2 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='com.linka.linkaapikit.module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions']]"
		[Register ("b", "(Landroid/bluetooth/BluetoothGatt;Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLeQueuedService$BluetoothGattQueuedActions;)Lcom/linka/linkaapikit/module/Lock/FirmwareAPI/LINKA_BLE_Service$BluetoothGattCharacteristicBundle;", "GetB_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_Handler")]
		public virtual unsafe global::Com.Linka.Linkaapikit.Module.Lock.FirmwareAPI.LINKA_BLE_Service.BluetoothGattCharacteristicBundle B (global::Android.Bluetooth.BluetoothGatt gatt, global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions actions)
		{
			const string __id = "b.(Landroid/bluetooth/BluetoothGatt;Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLeQueuedService$BluetoothGattQueuedActions;)Lcom/linka/linkaapikit/module/Lock/FirmwareAPI/LINKA_BLE_Service$BluetoothGattCharacteristicBundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((gatt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gatt).Handle);
				__args [1] = new JniArgumentValue ((actions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actions).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.FirmwareAPI.LINKA_BLE_Service.BluetoothGattCharacteristicBundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (gatt);
				global::System.GC.KeepAlive (actions);
			}
		}

	}
}
