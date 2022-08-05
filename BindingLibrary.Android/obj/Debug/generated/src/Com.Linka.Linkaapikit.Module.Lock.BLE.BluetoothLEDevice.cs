using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linka.Linkaapikit.Module.Lock.BLE {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLEDevice']"
	[global::Android.Runtime.Register ("com/linka/linkaapikit/module/Lock/BLE/BluetoothLEDevice", DoNotGenerateAcw=true)]
	public partial class BluetoothLEDevice : global::Java.Lang.Object, global::Java.Lang.IComparable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/Lock/BLE/BluetoothLEDevice", typeof (BluetoothLEDevice));

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

		protected BluetoothLEDevice (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLEDevice']/constructor[@name='BluetoothLEDevice' and count(parameter)=4 and parameter[1][@type='android.bluetooth.BluetoothDevice'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='boolean']]"
		[Register (".ctor", "(Landroid/bluetooth/BluetoothDevice;I[BZ)V", "")]
		public unsafe BluetoothLEDevice (global::Android.Bluetooth.BluetoothDevice device, int rssi, byte[] scanrecord, bool bonded) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/bluetooth/BluetoothDevice;I[BZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_scanrecord = JNIEnv.NewArray (scanrecord);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				__args [1] = new JniArgumentValue (rssi);
				__args [2] = new JniArgumentValue (native_scanrecord);
				__args [3] = new JniArgumentValue (bonded);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (scanrecord != null) {
					JNIEnv.CopyArray (native_scanrecord, scanrecord);
					JNIEnv.DeleteLocalRef (native_scanrecord);
				}
				global::System.GC.KeepAlive (device);
				global::System.GC.KeepAlive (scanrecord);
			}
		}

		static Delegate cb_getAddress;
#pragma warning disable 0169
		static Delegate GetGetAddressHandler ()
		{
			if (cb_getAddress == null)
				cb_getAddress = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAddress);
			return cb_getAddress;
		}

		static IntPtr n_GetAddress (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLEDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Address);
		}
#pragma warning restore 0169

		public virtual unsafe string Address {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLEDevice']/method[@name='getAddress' and count(parameter)=0]"
			[Register ("getAddress", "()Ljava/lang/String;", "GetGetAddressHandler")]
			get {
				const string __id = "getAddress.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDevice;
#pragma warning disable 0169
		static Delegate GetGetDeviceHandler ()
		{
			if (cb_getDevice == null)
				cb_getDevice = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDevice);
			return cb_getDevice;
		}

		static IntPtr n_GetDevice (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLEDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Device);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Bluetooth.BluetoothDevice Device {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLEDevice']/method[@name='getDevice' and count(parameter)=0]"
			[Register ("getDevice", "()Landroid/bluetooth/BluetoothDevice;", "GetGetDeviceHandler")]
			get {
				const string __id = "getDevice.()Landroid/bluetooth/BluetoothDevice;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isBonded;
#pragma warning disable 0169
		static Delegate GetIsBondedHandler ()
		{
			if (cb_isBonded == null)
				cb_isBonded = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsBonded);
			return cb_isBonded;
		}

		static bool n_IsBonded (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLEDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBonded;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsBonded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLEDevice']/method[@name='isBonded' and count(parameter)=0]"
			[Register ("isBonded", "()Z", "GetIsBondedHandler")]
			get {
				const string __id = "isBonded.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLockAdData;
#pragma warning disable 0169
		static Delegate GetGetLockAdDataHandler ()
		{
			if (cb_getLockAdData == null)
				cb_getLockAdData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLockAdData);
			return cb_getLockAdData;
		}

		static IntPtr n_GetLockAdData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLEDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LockAdData);
		}
#pragma warning restore 0169

		public virtual unsafe string LockAdData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLEDevice']/method[@name='getLockAdData' and count(parameter)=0]"
			[Register ("getLockAdData", "()Ljava/lang/String;", "GetGetLockAdDataHandler")]
			get {
				const string __id = "getLockAdData.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLockAdPassState;
#pragma warning disable 0169
		static Delegate GetGetLockAdPassStateHandler ()
		{
			if (cb_getLockAdPassState == null)
				cb_getLockAdPassState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetLockAdPassState);
			return cb_getLockAdPassState;
		}

		static bool n_GetLockAdPassState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLEDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LockAdPassState;
		}
#pragma warning restore 0169

		public virtual unsafe bool LockAdPassState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLEDevice']/method[@name='getLockAdPassState' and count(parameter)=0]"
			[Register ("getLockAdPassState", "()Z", "GetGetLockAdPassStateHandler")]
			get {
				const string __id = "getLockAdPassState.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMfgScanRec;
#pragma warning disable 0169
		static Delegate GetGetMfgScanRecHandler ()
		{
			if (cb_getMfgScanRec == null)
				cb_getMfgScanRec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMfgScanRec);
			return cb_getMfgScanRec;
		}

		static IntPtr n_GetMfgScanRec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLEDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MfgScanRec);
		}
#pragma warning restore 0169

		public virtual unsafe string MfgScanRec {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLEDevice']/method[@name='getMfgScanRec' and count(parameter)=0]"
			[Register ("getMfgScanRec", "()Ljava/lang/String;", "GetGetMfgScanRecHandler")]
			get {
				const string __id = "getMfgScanRec.()Ljava/lang/String;";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLEDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLEDevice']/method[@name='getName' and count(parameter)=0]"
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

		static Delegate cb_getRSSI;
#pragma warning disable 0169
		static Delegate GetGetRSSIHandler ()
		{
			if (cb_getRSSI == null)
				cb_getRSSI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRSSI);
			return cb_getRSSI;
		}

		static int n_GetRSSI (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLEDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RSSI;
		}
#pragma warning restore 0169

		public virtual unsafe int RSSI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLEDevice']/method[@name='getRSSI' and count(parameter)=0]"
			[Register ("getRSSI", "()I", "GetGetRSSIHandler")]
			get {
				const string __id = "getRSSI.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_compareTo_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Ljava_lang_Object_Handler ()
		{
			if (cb_compareTo_Ljava_lang_Object_ == null)
				cb_compareTo_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_CompareTo_Ljava_lang_Object_);
			return cb_compareTo_Ljava_lang_Object_;
		}

		static int n_CompareTo_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_another)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLEDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var another = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_another, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (another);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLEDevice']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
		public virtual unsafe int CompareTo (global::Java.Lang.Object another)
		{
			const string __id = "compareTo.(Ljava/lang/Object;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((another == null) ? IntPtr.Zero : ((global::Java.Lang.Object) another).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (another);
			}
		}

		static Delegate cb_getScanRecord;
#pragma warning disable 0169
		static Delegate GetGetScanRecordHandler ()
		{
			if (cb_getScanRecord == null)
				cb_getScanRecord = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetScanRecord);
			return cb_getScanRecord;
		}

		static IntPtr n_GetScanRecord (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLEDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetScanRecord ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLEDevice']/method[@name='getScanRecord' and count(parameter)=0]"
		[Register ("getScanRecord", "()[B", "GetGetScanRecordHandler")]
		public virtual unsafe byte[] GetScanRecord ()
		{
			const string __id = "getScanRecord.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLEDevice']/method[@name='getUUIDFromByteArray' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("getUUIDFromByteArray", "([BI)Ljava/util/UUID;", "")]
		public static unsafe global::Java.Util.UUID GetUUIDFromByteArray (byte[] bytes, int offset)
		{
			const string __id = "getUUIDFromByteArray.([BI)Ljava/util/UUID;";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bytes);
				__args [1] = new JniArgumentValue (offset);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
				global::System.GC.KeepAlive (bytes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLEDevice']/method[@name='getUUIDReversedFromByteArray' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("getUUIDReversedFromByteArray", "([BI)Ljava/util/UUID;", "")]
		public static unsafe global::Java.Util.UUID GetUUIDReversedFromByteArray (byte[] bytes, int offset)
		{
			const string __id = "getUUIDReversedFromByteArray.([BI)Ljava/util/UUID;";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bytes);
				__args [1] = new JniArgumentValue (offset);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
				global::System.GC.KeepAlive (bytes);
			}
		}

		static Delegate cb_has128BitUUID_Ljava_util_UUID_;
#pragma warning disable 0169
		static Delegate GetHas128BitUUID_Ljava_util_UUID_Handler ()
		{
			if (cb_has128BitUUID_Ljava_util_UUID_ == null)
				cb_has128BitUUID_Ljava_util_UUID_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Has128BitUUID_Ljava_util_UUID_);
			return cb_has128BitUUID_Ljava_util_UUID_;
		}

		static bool n_Has128BitUUID_Ljava_util_UUID_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uuid)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLEDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uuid = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_uuid, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Has128BitUUID (uuid);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLEDevice']/method[@name='has128BitUUID' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
		[Register ("has128BitUUID", "(Ljava/util/UUID;)Z", "GetHas128BitUUID_Ljava_util_UUID_Handler")]
		public virtual unsafe bool Has128BitUUID (global::Java.Util.UUID uuid)
		{
			const string __id = "has128BitUUID.(Ljava/util/UUID;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uuid).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (uuid);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLEDevice']/method[@name='reverseByteArray' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("reverseByteArray", "([BI)[B", "")]
		public static unsafe byte[] ReverseByteArray (byte[] original, int offset)
		{
			const string __id = "reverseByteArray.([BI)[B";
			IntPtr native_original = JNIEnv.NewArray (original);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_original);
				__args [1] = new JniArgumentValue (offset);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (original != null) {
					JNIEnv.CopyArray (native_original, original);
					JNIEnv.DeleteLocalRef (native_original);
				}
				global::System.GC.KeepAlive (original);
			}
		}

		static Delegate cb_setSortByRSSI_Z;
#pragma warning disable 0169
		static Delegate GetSetSortByRSSI_ZHandler ()
		{
			if (cb_setSortByRSSI_Z == null)
				cb_setSortByRSSI_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetSortByRSSI_Z);
			return cb_setSortByRSSI_Z;
		}

		static void n_SetSortByRSSI_Z (IntPtr jnienv, IntPtr native__this, bool sortByRSSI)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLEDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSortByRSSI (sortByRSSI);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.Lock.BLE']/class[@name='BluetoothLEDevice']/method[@name='setSortByRSSI' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSortByRSSI", "(Z)V", "GetSetSortByRSSI_ZHandler")]
		public virtual unsafe void SetSortByRSSI (bool sortByRSSI)
		{
			const string __id = "setSortByRSSI.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sortByRSSI);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
