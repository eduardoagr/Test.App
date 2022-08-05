using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linka.Linkaapikit.Module.Lock.BLE {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']"
	[global::Android.Runtime.Register ("com/linka/linkaapikit/module/Lock/BLE/BluetoothLeQueuedService", DoNotGenerateAcw=true)]
	public partial class BluetoothLeQueuedService : global::Android.App.Service {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/field[@name='ACTION_BOND_STATE_CHANGED']"
		[Register ("ACTION_BOND_STATE_CHANGED")]
		public const string ActionBondStateChanged = (string) "android.bluetooth.device.action.BOND_STATE_CHANGED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/field[@name='ACTION_DATA_AVAILABLE']"
		[Register ("ACTION_DATA_AVAILABLE")]
		public const string ActionDataAvailable = (string) "com.example.bluetooth.le.ACTION_DATA_AVAILABLE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/field[@name='ACTION_GATT_CONNECTED']"
		[Register ("ACTION_GATT_CONNECTED")]
		public const string ActionGattConnected = (string) "com.example.bluetooth.le.ACTION_GATT_CONNECTED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/field[@name='ACTION_GATT_DISCONNECTED']"
		[Register ("ACTION_GATT_DISCONNECTED")]
		public const string ActionGattDisconnected = (string) "com.example.bluetooth.le.ACTION_GATT_DISCONNECTED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/field[@name='ACTION_GATT_SERVICES_DISCOVERED']"
		[Register ("ACTION_GATT_SERVICES_DISCOVERED")]
		public const string ActionGattServicesDiscovered = (string) "com.example.bluetooth.le.ACTION_GATT_SERVICES_DISCOVERED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/field[@name='ACTION_REMOTE_RSSI_UPDATED']"
		[Register ("ACTION_REMOTE_RSSI_UPDATED")]
		public const string ActionRemoteRssiUpdated = (string) "com.example.bluetooth.le.ACTION_REMOTE_RSSI_UPDATED";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/field[@name='allowReconnect']"
		[Register ("allowReconnect")]
		public bool AllowReconnect {
			get {
				const string __id = "allowReconnect.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "allowReconnect.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/field[@name='b']"
		[Register ("b")]
		protected global::Android.Bluetooth.BluetoothAdapter B {
			get {
				const string __id = "b.Landroid/bluetooth/BluetoothAdapter;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothAdapter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "b.Landroid/bluetooth/BluetoothAdapter;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/field[@name='EXTRA_CHARACTERISTIC']"
		[Register ("EXTRA_CHARACTERISTIC")]
		public const string ExtraCharacteristic = (string) "com.example.bluetooth.le.EXTRA_CHARACTERISTIC";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/field[@name='EXTRA_DATA']"
		[Register ("EXTRA_DATA")]
		public const string ExtraData = (string) "com.example.bluetooth.le.EXTRA_DATA";

		// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService.BluetoothGattQueuedActions']"
		[global::Android.Runtime.Register ("com/linka/linkaapikit/module/Lock/BLE/BluetoothLeQueuedService$BluetoothGattQueuedActions", DoNotGenerateAcw=true)]
		public partial class BluetoothGattQueuedActions : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService.BluetoothGattQueuedActions']/field[@name='characteristicReadQueue']"
			[Register ("characteristicReadQueue")]
			public global::Java.Util.IQueue CharacteristicReadQueue {
				get {
					const string __id = "characteristicReadQueue.Ljava/util/Queue;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Util.IQueue> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "characteristicReadQueue.Ljava/util/Queue;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService.BluetoothGattQueuedActions']/field[@name='characteristicWriteQueue']"
			[Register ("characteristicWriteQueue")]
			public global::Java.Util.IQueue CharacteristicWriteQueue {
				get {
					const string __id = "characteristicWriteQueue.Ljava/util/Queue;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Util.IQueue> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "characteristicWriteQueue.Ljava/util/Queue;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService.BluetoothGattQueuedActions']/field[@name='descriptorWriteQueue']"
			[Register ("descriptorWriteQueue")]
			public global::Java.Util.IQueue DescriptorWriteQueue {
				get {
					const string __id = "descriptorWriteQueue.Ljava/util/Queue;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Util.IQueue> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "descriptorWriteQueue.Ljava/util/Queue;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/Lock/BLE/BluetoothLeQueuedService$BluetoothGattQueuedActions", typeof (BluetoothGattQueuedActions));

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

			protected BluetoothGattQueuedActions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService.BluetoothGattQueuedActions']/constructor[@name='BluetoothLeQueuedService.BluetoothGattQueuedActions' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe BluetoothGattQueuedActions () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/Lock/BLE/BluetoothLeQueuedService", typeof (BluetoothLeQueuedService));

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

		protected BluetoothLeQueuedService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/constructor[@name='BluetoothLeQueuedService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BluetoothLeQueuedService () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_a_Ljava_lang_String_Landroid_bluetooth_BluetoothGatt_I;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_Landroid_bluetooth_BluetoothGatt_IHandler ()
		{
			if (cb_a_Ljava_lang_String_Landroid_bluetooth_BluetoothGatt_I == null)
				cb_a_Ljava_lang_String_Landroid_bluetooth_BluetoothGatt_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_A_Ljava_lang_String_Landroid_bluetooth_BluetoothGatt_I);
			return cb_a_Ljava_lang_String_Landroid_bluetooth_BluetoothGatt_I;
		}

		static void n_A_Ljava_lang_String_Landroid_bluetooth_BluetoothGatt_I (IntPtr jnienv, IntPtr native__this, IntPtr native_action, IntPtr native_gatt, int rssi)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var action = JNIEnv.GetString (native_action, JniHandleOwnership.DoNotTransfer);
			var gatt = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_gatt, JniHandleOwnership.DoNotTransfer);
			__this.A (action, gatt, rssi);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.bluetooth.BluetoothGatt'] and parameter[3][@type='int']]"
		[Register ("a", "(Ljava/lang/String;Landroid/bluetooth/BluetoothGatt;I)V", "GetA_Ljava_lang_String_Landroid_bluetooth_BluetoothGatt_IHandler")]
		protected virtual unsafe void A (string action, global::Android.Bluetooth.BluetoothGatt gatt, int rssi)
		{
			const string __id = "a.(Ljava/lang/String;Landroid/bluetooth/BluetoothGatt;I)V";
			IntPtr native_action = JNIEnv.NewString (action);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_action);
				__args [1] = new JniArgumentValue ((gatt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gatt).Handle);
				__args [2] = new JniArgumentValue (rssi);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_action);
				global::System.GC.KeepAlive (gatt);
			}
		}

		static Delegate cb_a_Ljava_lang_String_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_Handler ()
		{
			if (cb_a_Ljava_lang_String_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_ == null)
				cb_a_Ljava_lang_String_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_A_Ljava_lang_String_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_);
			return cb_a_Ljava_lang_String_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_;
		}

		static void n_A_Ljava_lang_String_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_action, IntPtr native_characteristic, IntPtr native_gatt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var action = JNIEnv.GetString (native_action, JniHandleOwnership.DoNotTransfer);
			var characteristic = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattCharacteristic> (native_characteristic, JniHandleOwnership.DoNotTransfer);
			var gatt = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_gatt, JniHandleOwnership.DoNotTransfer);
			__this.A (action, characteristic, gatt);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.bluetooth.BluetoothGattCharacteristic'] and parameter[3][@type='android.bluetooth.BluetoothGatt']]"
		[Register ("a", "(Ljava/lang/String;Landroid/bluetooth/BluetoothGattCharacteristic;Landroid/bluetooth/BluetoothGatt;)V", "GetA_Ljava_lang_String_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_Handler")]
		protected virtual unsafe void A (string action, global::Android.Bluetooth.BluetoothGattCharacteristic characteristic, global::Android.Bluetooth.BluetoothGatt gatt)
		{
			const string __id = "a.(Ljava/lang/String;Landroid/bluetooth/BluetoothGattCharacteristic;Landroid/bluetooth/BluetoothGatt;)V";
			IntPtr native_action = JNIEnv.NewString (action);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_action);
				__args [1] = new JniArgumentValue ((characteristic == null) ? IntPtr.Zero : ((global::Java.Lang.Object) characteristic).Handle);
				__args [2] = new JniArgumentValue ((gatt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gatt).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_action);
				global::System.GC.KeepAlive (characteristic);
				global::System.GC.KeepAlive (gatt);
			}
		}

		static Delegate cb_close_Landroid_bluetooth_BluetoothGatt_;
#pragma warning disable 0169
		static Delegate GetClose_Landroid_bluetooth_BluetoothGatt_Handler ()
		{
			if (cb_close_Landroid_bluetooth_BluetoothGatt_ == null)
				cb_close_Landroid_bluetooth_BluetoothGatt_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Close_Landroid_bluetooth_BluetoothGatt_);
			return cb_close_Landroid_bluetooth_BluetoothGatt_;
		}

		static void n_Close_Landroid_bluetooth_BluetoothGatt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_gatt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var gatt = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_gatt, JniHandleOwnership.DoNotTransfer);
			__this.Close (gatt);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/method[@name='close' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGatt']]"
		[Register ("close", "(Landroid/bluetooth/BluetoothGatt;)V", "GetClose_Landroid_bluetooth_BluetoothGatt_Handler")]
		public virtual unsafe void Close (global::Android.Bluetooth.BluetoothGatt gatt)
		{
			const string __id = "close.(Landroid/bluetooth/BluetoothGatt;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((gatt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gatt).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (gatt);
			}
		}

		static Delegate cb_connect_Ljava_lang_String_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_String_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_Handler ()
		{
			if (cb_connect_Ljava_lang_String_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ == null)
				cb_connect_Ljava_lang_String_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Connect_Ljava_lang_String_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_);
			return cb_connect_Ljava_lang_String_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_;
		}

		static IntPtr n_Connect_Ljava_lang_String_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_address, IntPtr native_gatt, IntPtr native_actions)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var address = JNIEnv.GetString (native_address, JniHandleOwnership.DoNotTransfer);
			var gatt = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_gatt, JniHandleOwnership.DoNotTransfer);
			var actions = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions> (native_actions, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Connect (address, gatt, actions));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/method[@name='connect' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.bluetooth.BluetoothGatt'] and parameter[3][@type='com.linka.linkaapikit.module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions']]"
		[Register ("connect", "(Ljava/lang/String;Landroid/bluetooth/BluetoothGatt;Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLeQueuedService$BluetoothGattQueuedActions;)Landroid/bluetooth/BluetoothGatt;", "GetConnect_Ljava_lang_String_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_Handler")]
		public virtual unsafe global::Android.Bluetooth.BluetoothGatt Connect (string address, global::Android.Bluetooth.BluetoothGatt gatt, global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions actions)
		{
			const string __id = "connect.(Ljava/lang/String;Landroid/bluetooth/BluetoothGatt;Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLeQueuedService$BluetoothGattQueuedActions;)Landroid/bluetooth/BluetoothGatt;";
			IntPtr native_address = JNIEnv.NewString (address);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_address);
				__args [1] = new JniArgumentValue ((gatt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gatt).Handle);
				__args [2] = new JniArgumentValue ((actions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actions).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_address);
				global::System.GC.KeepAlive (gatt);
				global::System.GC.KeepAlive (actions);
			}
		}

		static Delegate cb_createBond_Landroid_bluetooth_BluetoothGatt_;
#pragma warning disable 0169
		static Delegate GetCreateBond_Landroid_bluetooth_BluetoothGatt_Handler ()
		{
			if (cb_createBond_Landroid_bluetooth_BluetoothGatt_ == null)
				cb_createBond_Landroid_bluetooth_BluetoothGatt_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_CreateBond_Landroid_bluetooth_BluetoothGatt_);
			return cb_createBond_Landroid_bluetooth_BluetoothGatt_;
		}

		static bool n_CreateBond_Landroid_bluetooth_BluetoothGatt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_gatt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var gatt = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_gatt, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CreateBond (gatt);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/method[@name='createBond' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGatt']]"
		[Register ("createBond", "(Landroid/bluetooth/BluetoothGatt;)Z", "GetCreateBond_Landroid_bluetooth_BluetoothGatt_Handler")]
		public virtual unsafe bool CreateBond (global::Android.Bluetooth.BluetoothGatt gatt)
		{
			const string __id = "createBond.(Landroid/bluetooth/BluetoothGatt;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((gatt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gatt).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (gatt);
			}
		}

		static Delegate cb_disconnect_Landroid_bluetooth_BluetoothGatt_;
#pragma warning disable 0169
		static Delegate GetDisconnect_Landroid_bluetooth_BluetoothGatt_Handler ()
		{
			if (cb_disconnect_Landroid_bluetooth_BluetoothGatt_ == null)
				cb_disconnect_Landroid_bluetooth_BluetoothGatt_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Disconnect_Landroid_bluetooth_BluetoothGatt_);
			return cb_disconnect_Landroid_bluetooth_BluetoothGatt_;
		}

		static void n_Disconnect_Landroid_bluetooth_BluetoothGatt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_gatt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var gatt = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_gatt, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect (gatt);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/method[@name='disconnect' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGatt']]"
		[Register ("disconnect", "(Landroid/bluetooth/BluetoothGatt;)V", "GetDisconnect_Landroid_bluetooth_BluetoothGatt_Handler")]
		public virtual unsafe void Disconnect (global::Android.Bluetooth.BluetoothGatt gatt)
		{
			const string __id = "disconnect.(Landroid/bluetooth/BluetoothGatt;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((gatt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gatt).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (gatt);
			}
		}

		static Delegate cb_getCharacteristicByUUID_Ljava_util_UUID_Landroid_bluetooth_BluetoothGatt_;
#pragma warning disable 0169
		static Delegate GetGetCharacteristicByUUID_Ljava_util_UUID_Landroid_bluetooth_BluetoothGatt_Handler ()
		{
			if (cb_getCharacteristicByUUID_Ljava_util_UUID_Landroid_bluetooth_BluetoothGatt_ == null)
				cb_getCharacteristicByUUID_Ljava_util_UUID_Landroid_bluetooth_BluetoothGatt_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetCharacteristicByUUID_Ljava_util_UUID_Landroid_bluetooth_BluetoothGatt_);
			return cb_getCharacteristicByUUID_Ljava_util_UUID_Landroid_bluetooth_BluetoothGatt_;
		}

		static IntPtr n_GetCharacteristicByUUID_Ljava_util_UUID_Landroid_bluetooth_BluetoothGatt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uuid, IntPtr native_gatt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uuid = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_uuid, JniHandleOwnership.DoNotTransfer);
			var gatt = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_gatt, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCharacteristicByUUID (uuid, gatt));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/method[@name='getCharacteristicByUUID' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='android.bluetooth.BluetoothGatt']]"
		[Register ("getCharacteristicByUUID", "(Ljava/util/UUID;Landroid/bluetooth/BluetoothGatt;)Landroid/bluetooth/BluetoothGattCharacteristic;", "GetGetCharacteristicByUUID_Ljava_util_UUID_Landroid_bluetooth_BluetoothGatt_Handler")]
		public virtual unsafe global::Android.Bluetooth.BluetoothGattCharacteristic GetCharacteristicByUUID (global::Java.Util.UUID uuid, global::Android.Bluetooth.BluetoothGatt gatt)
		{
			const string __id = "getCharacteristicByUUID.(Ljava/util/UUID;Landroid/bluetooth/BluetoothGatt;)Landroid/bluetooth/BluetoothGattCharacteristic;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((uuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uuid).Handle);
				__args [1] = new JniArgumentValue ((gatt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gatt).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattCharacteristic> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (uuid);
				global::System.GC.KeepAlive (gatt);
			}
		}

		static Delegate cb_getSupportedGattServices_Landroid_bluetooth_BluetoothGatt_;
#pragma warning disable 0169
		static Delegate GetGetSupportedGattServices_Landroid_bluetooth_BluetoothGatt_Handler ()
		{
			if (cb_getSupportedGattServices_Landroid_bluetooth_BluetoothGatt_ == null)
				cb_getSupportedGattServices_Landroid_bluetooth_BluetoothGatt_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetSupportedGattServices_Landroid_bluetooth_BluetoothGatt_);
			return cb_getSupportedGattServices_Landroid_bluetooth_BluetoothGatt_;
		}

		static IntPtr n_GetSupportedGattServices_Landroid_bluetooth_BluetoothGatt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_gatt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var gatt = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_gatt, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothGattService>.ToLocalJniHandle (__this.GetSupportedGattServices (gatt));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/method[@name='getSupportedGattServices' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGatt']]"
		[Register ("getSupportedGattServices", "(Landroid/bluetooth/BluetoothGatt;)Ljava/util/List;", "GetGetSupportedGattServices_Landroid_bluetooth_BluetoothGatt_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothGattService> GetSupportedGattServices (global::Android.Bluetooth.BluetoothGatt gatt)
		{
			const string __id = "getSupportedGattServices.(Landroid/bluetooth/BluetoothGatt;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((gatt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gatt).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothGattService>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (gatt);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Initialize ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/method[@name='initialize' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (intent));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
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

		static Delegate cb_readCharacteristic_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_;
#pragma warning disable 0169
		static Delegate GetReadCharacteristic_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_Handler ()
		{
			if (cb_readCharacteristic_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ == null)
				cb_readCharacteristic_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_Z) n_ReadCharacteristic_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_);
			return cb_readCharacteristic_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_;
		}

		static bool n_ReadCharacteristic_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_gatt, IntPtr native_actions)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattCharacteristic> (native_c, JniHandleOwnership.DoNotTransfer);
			var gatt = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_gatt, JniHandleOwnership.DoNotTransfer);
			var actions = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions> (native_actions, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ReadCharacteristic (c, gatt, actions);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/method[@name='readCharacteristic' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothGattCharacteristic'] and parameter[2][@type='android.bluetooth.BluetoothGatt'] and parameter[3][@type='com.linka.linkaapikit.module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions']]"
		[Register ("readCharacteristic", "(Landroid/bluetooth/BluetoothGattCharacteristic;Landroid/bluetooth/BluetoothGatt;Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLeQueuedService$BluetoothGattQueuedActions;)Z", "GetReadCharacteristic_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_Handler")]
		public virtual unsafe bool ReadCharacteristic (global::Android.Bluetooth.BluetoothGattCharacteristic c, global::Android.Bluetooth.BluetoothGatt gatt, global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions actions)
		{
			const string __id = "readCharacteristic.(Landroid/bluetooth/BluetoothGattCharacteristic;Landroid/bluetooth/BluetoothGatt;Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLeQueuedService$BluetoothGattQueuedActions;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue ((gatt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gatt).Handle);
				__args [2] = new JniArgumentValue ((actions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actions).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (c);
				global::System.GC.KeepAlive (gatt);
				global::System.GC.KeepAlive (actions);
			}
		}

		static Delegate cb_readCharacteristic_Ljava_lang_String_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_;
#pragma warning disable 0169
		static Delegate GetReadCharacteristic_Ljava_lang_String_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_Handler ()
		{
			if (cb_readCharacteristic_Ljava_lang_String_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ == null)
				cb_readCharacteristic_Ljava_lang_String_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_Z) n_ReadCharacteristic_Ljava_lang_String_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_);
			return cb_readCharacteristic_Ljava_lang_String_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_;
		}

		static bool n_ReadCharacteristic_Ljava_lang_String_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_characteristicName, IntPtr native_gatt, IntPtr native_actions)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var characteristicName = JNIEnv.GetString (native_characteristicName, JniHandleOwnership.DoNotTransfer);
			var gatt = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_gatt, JniHandleOwnership.DoNotTransfer);
			var actions = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions> (native_actions, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ReadCharacteristic (characteristicName, gatt, actions);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/method[@name='readCharacteristic' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.bluetooth.BluetoothGatt'] and parameter[3][@type='com.linka.linkaapikit.module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions']]"
		[Register ("readCharacteristic", "(Ljava/lang/String;Landroid/bluetooth/BluetoothGatt;Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLeQueuedService$BluetoothGattQueuedActions;)Z", "GetReadCharacteristic_Ljava_lang_String_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_Handler")]
		public virtual unsafe bool ReadCharacteristic (string characteristicName, global::Android.Bluetooth.BluetoothGatt gatt, global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions actions)
		{
			const string __id = "readCharacteristic.(Ljava/lang/String;Landroid/bluetooth/BluetoothGatt;Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLeQueuedService$BluetoothGattQueuedActions;)Z";
			IntPtr native_characteristicName = JNIEnv.NewString (characteristicName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_characteristicName);
				__args [1] = new JniArgumentValue ((gatt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gatt).Handle);
				__args [2] = new JniArgumentValue ((actions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actions).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_characteristicName);
				global::System.GC.KeepAlive (gatt);
				global::System.GC.KeepAlive (actions);
			}
		}

		static Delegate cb_readCharacteristicNoQueue_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_;
#pragma warning disable 0169
		static Delegate GetReadCharacteristicNoQueue_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_Handler ()
		{
			if (cb_readCharacteristicNoQueue_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_ == null)
				cb_readCharacteristicNoQueue_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_ReadCharacteristicNoQueue_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_);
			return cb_readCharacteristicNoQueue_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_;
		}

		static bool n_ReadCharacteristicNoQueue_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_characteristic, IntPtr native_gatt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var characteristic = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattCharacteristic> (native_characteristic, JniHandleOwnership.DoNotTransfer);
			var gatt = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_gatt, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ReadCharacteristicNoQueue (characteristic, gatt);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/method[@name='readCharacteristicNoQueue' and count(parameter)=2 and parameter[1][@type='android.bluetooth.BluetoothGattCharacteristic'] and parameter[2][@type='android.bluetooth.BluetoothGatt']]"
		[Register ("readCharacteristicNoQueue", "(Landroid/bluetooth/BluetoothGattCharacteristic;Landroid/bluetooth/BluetoothGatt;)Z", "GetReadCharacteristicNoQueue_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_Handler")]
		public virtual unsafe bool ReadCharacteristicNoQueue (global::Android.Bluetooth.BluetoothGattCharacteristic characteristic, global::Android.Bluetooth.BluetoothGatt gatt)
		{
			const string __id = "readCharacteristicNoQueue.(Landroid/bluetooth/BluetoothGattCharacteristic;Landroid/bluetooth/BluetoothGatt;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((characteristic == null) ? IntPtr.Zero : ((global::Java.Lang.Object) characteristic).Handle);
				__args [1] = new JniArgumentValue ((gatt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gatt).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (characteristic);
				global::System.GC.KeepAlive (gatt);
			}
		}

		static Delegate cb_setCharacteristicIndication_Landroid_bluetooth_BluetoothGattCharacteristic_ZLandroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_;
#pragma warning disable 0169
		static Delegate GetSetCharacteristicIndication_Landroid_bluetooth_BluetoothGattCharacteristic_ZLandroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_Handler ()
		{
			if (cb_setCharacteristicIndication_Landroid_bluetooth_BluetoothGattCharacteristic_ZLandroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ == null)
				cb_setCharacteristicIndication_Landroid_bluetooth_BluetoothGattCharacteristic_ZLandroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZLL_Z) n_SetCharacteristicIndication_Landroid_bluetooth_BluetoothGattCharacteristic_ZLandroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_);
			return cb_setCharacteristicIndication_Landroid_bluetooth_BluetoothGattCharacteristic_ZLandroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_;
		}

		static bool n_SetCharacteristicIndication_Landroid_bluetooth_BluetoothGattCharacteristic_ZLandroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_characteristic, bool enabled, IntPtr native_gatt, IntPtr native_actions)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var characteristic = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattCharacteristic> (native_characteristic, JniHandleOwnership.DoNotTransfer);
			var gatt = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_gatt, JniHandleOwnership.DoNotTransfer);
			var actions = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions> (native_actions, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetCharacteristicIndication (characteristic, enabled, gatt, actions);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/method[@name='setCharacteristicIndication' and count(parameter)=4 and parameter[1][@type='android.bluetooth.BluetoothGattCharacteristic'] and parameter[2][@type='boolean'] and parameter[3][@type='android.bluetooth.BluetoothGatt'] and parameter[4][@type='com.linka.linkaapikit.module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions']]"
		[Register ("setCharacteristicIndication", "(Landroid/bluetooth/BluetoothGattCharacteristic;ZLandroid/bluetooth/BluetoothGatt;Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLeQueuedService$BluetoothGattQueuedActions;)Z", "GetSetCharacteristicIndication_Landroid_bluetooth_BluetoothGattCharacteristic_ZLandroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_Handler")]
		public virtual unsafe bool SetCharacteristicIndication (global::Android.Bluetooth.BluetoothGattCharacteristic characteristic, bool enabled, global::Android.Bluetooth.BluetoothGatt gatt, global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions actions)
		{
			const string __id = "setCharacteristicIndication.(Landroid/bluetooth/BluetoothGattCharacteristic;ZLandroid/bluetooth/BluetoothGatt;Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLeQueuedService$BluetoothGattQueuedActions;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((characteristic == null) ? IntPtr.Zero : ((global::Java.Lang.Object) characteristic).Handle);
				__args [1] = new JniArgumentValue (enabled);
				__args [2] = new JniArgumentValue ((gatt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gatt).Handle);
				__args [3] = new JniArgumentValue ((actions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actions).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (characteristic);
				global::System.GC.KeepAlive (gatt);
				global::System.GC.KeepAlive (actions);
			}
		}

		static Delegate cb_setCharacteristicNotification_Landroid_bluetooth_BluetoothGattCharacteristic_ZLandroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_;
#pragma warning disable 0169
		static Delegate GetSetCharacteristicNotification_Landroid_bluetooth_BluetoothGattCharacteristic_ZLandroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_Handler ()
		{
			if (cb_setCharacteristicNotification_Landroid_bluetooth_BluetoothGattCharacteristic_ZLandroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ == null)
				cb_setCharacteristicNotification_Landroid_bluetooth_BluetoothGattCharacteristic_ZLandroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZLL_Z) n_SetCharacteristicNotification_Landroid_bluetooth_BluetoothGattCharacteristic_ZLandroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_);
			return cb_setCharacteristicNotification_Landroid_bluetooth_BluetoothGattCharacteristic_ZLandroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_;
		}

		static bool n_SetCharacteristicNotification_Landroid_bluetooth_BluetoothGattCharacteristic_ZLandroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_characteristic, bool enabled, IntPtr native_gatt, IntPtr native_actions)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var characteristic = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattCharacteristic> (native_characteristic, JniHandleOwnership.DoNotTransfer);
			var gatt = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_gatt, JniHandleOwnership.DoNotTransfer);
			var actions = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions> (native_actions, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetCharacteristicNotification (characteristic, enabled, gatt, actions);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/method[@name='setCharacteristicNotification' and count(parameter)=4 and parameter[1][@type='android.bluetooth.BluetoothGattCharacteristic'] and parameter[2][@type='boolean'] and parameter[3][@type='android.bluetooth.BluetoothGatt'] and parameter[4][@type='com.linka.linkaapikit.module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions']]"
		[Register ("setCharacteristicNotification", "(Landroid/bluetooth/BluetoothGattCharacteristic;ZLandroid/bluetooth/BluetoothGatt;Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLeQueuedService$BluetoothGattQueuedActions;)Z", "GetSetCharacteristicNotification_Landroid_bluetooth_BluetoothGattCharacteristic_ZLandroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_Handler")]
		public virtual unsafe bool SetCharacteristicNotification (global::Android.Bluetooth.BluetoothGattCharacteristic characteristic, bool enabled, global::Android.Bluetooth.BluetoothGatt gatt, global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions actions)
		{
			const string __id = "setCharacteristicNotification.(Landroid/bluetooth/BluetoothGattCharacteristic;ZLandroid/bluetooth/BluetoothGatt;Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLeQueuedService$BluetoothGattQueuedActions;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((characteristic == null) ? IntPtr.Zero : ((global::Java.Lang.Object) characteristic).Handle);
				__args [1] = new JniArgumentValue (enabled);
				__args [2] = new JniArgumentValue ((gatt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gatt).Handle);
				__args [3] = new JniArgumentValue ((actions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actions).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (characteristic);
				global::System.GC.KeepAlive (gatt);
				global::System.GC.KeepAlive (actions);
			}
		}

		static Delegate cb_writeCharacteristic_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_;
#pragma warning disable 0169
		static Delegate GetWriteCharacteristic_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_Handler ()
		{
			if (cb_writeCharacteristic_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ == null)
				cb_writeCharacteristic_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_Z) n_WriteCharacteristic_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_);
			return cb_writeCharacteristic_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_;
		}

		static bool n_WriteCharacteristic_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_characteristic, IntPtr native_gatt, IntPtr native_actions)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var characteristic = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattCharacteristic> (native_characteristic, JniHandleOwnership.DoNotTransfer);
			var gatt = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_gatt, JniHandleOwnership.DoNotTransfer);
			var actions = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions> (native_actions, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.WriteCharacteristic (characteristic, gatt, actions);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/method[@name='writeCharacteristic' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothGattCharacteristic'] and parameter[2][@type='android.bluetooth.BluetoothGatt'] and parameter[3][@type='com.linka.linkaapikit.module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions']]"
		[Register ("writeCharacteristic", "(Landroid/bluetooth/BluetoothGattCharacteristic;Landroid/bluetooth/BluetoothGatt;Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLeQueuedService$BluetoothGattQueuedActions;)Z", "GetWriteCharacteristic_Landroid_bluetooth_BluetoothGattCharacteristic_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_Handler")]
		public virtual unsafe bool WriteCharacteristic (global::Android.Bluetooth.BluetoothGattCharacteristic characteristic, global::Android.Bluetooth.BluetoothGatt gatt, global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions actions)
		{
			const string __id = "writeCharacteristic.(Landroid/bluetooth/BluetoothGattCharacteristic;Landroid/bluetooth/BluetoothGatt;Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLeQueuedService$BluetoothGattQueuedActions;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((characteristic == null) ? IntPtr.Zero : ((global::Java.Lang.Object) characteristic).Handle);
				__args [1] = new JniArgumentValue ((gatt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gatt).Handle);
				__args [2] = new JniArgumentValue ((actions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actions).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (characteristic);
				global::System.GC.KeepAlive (gatt);
				global::System.GC.KeepAlive (actions);
			}
		}

		static Delegate cb_writeDescriptor_Landroid_bluetooth_BluetoothGattDescriptor_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_;
#pragma warning disable 0169
		static Delegate GetWriteDescriptor_Landroid_bluetooth_BluetoothGattDescriptor_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_Handler ()
		{
			if (cb_writeDescriptor_Landroid_bluetooth_BluetoothGattDescriptor_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ == null)
				cb_writeDescriptor_Landroid_bluetooth_BluetoothGattDescriptor_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_Z) n_WriteDescriptor_Landroid_bluetooth_BluetoothGattDescriptor_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_);
			return cb_writeDescriptor_Landroid_bluetooth_BluetoothGattDescriptor_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_;
		}

		static bool n_WriteDescriptor_Landroid_bluetooth_BluetoothGattDescriptor_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_descriptor, IntPtr native_gatt, IntPtr native_actions)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var descriptor = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattDescriptor> (native_descriptor, JniHandleOwnership.DoNotTransfer);
			var gatt = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_gatt, JniHandleOwnership.DoNotTransfer);
			var actions = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions> (native_actions, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.WriteDescriptor (descriptor, gatt, actions);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLeQueuedService']/method[@name='writeDescriptor' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothGattDescriptor'] and parameter[2][@type='android.bluetooth.BluetoothGatt'] and parameter[3][@type='com.linka.linkaapikit.module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions']]"
		[Register ("writeDescriptor", "(Landroid/bluetooth/BluetoothGattDescriptor;Landroid/bluetooth/BluetoothGatt;Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLeQueuedService$BluetoothGattQueuedActions;)Z", "GetWriteDescriptor_Landroid_bluetooth_BluetoothGattDescriptor_Landroid_bluetooth_BluetoothGatt_Lcom_linka_linkaapikit_module_Lock_BLE_BluetoothLeQueuedService_BluetoothGattQueuedActions_Handler")]
		public virtual unsafe bool WriteDescriptor (global::Android.Bluetooth.BluetoothGattDescriptor descriptor, global::Android.Bluetooth.BluetoothGatt gatt, global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLeQueuedService.BluetoothGattQueuedActions actions)
		{
			const string __id = "writeDescriptor.(Landroid/bluetooth/BluetoothGattDescriptor;Landroid/bluetooth/BluetoothGatt;Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLeQueuedService$BluetoothGattQueuedActions;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((descriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) descriptor).Handle);
				__args [1] = new JniArgumentValue ((gatt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gatt).Handle);
				__args [2] = new JniArgumentValue ((actions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actions).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (descriptor);
				global::System.GC.KeepAlive (gatt);
				global::System.GC.KeepAlive (actions);
			}
		}

	}
}
