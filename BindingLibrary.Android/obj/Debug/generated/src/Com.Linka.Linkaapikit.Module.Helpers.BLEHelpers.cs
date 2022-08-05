using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linka.Linkaapikit.Module.Helpers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.helpers']/class[@name='BLEHelpers']"
	[global::Android.Runtime.Register ("com/linka/linkaapikit/module/helpers/BLEHelpers", DoNotGenerateAcw=true)]
	public partial class BLEHelpers : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.helpers']/class[@name='BLEHelpers']/field[@name='REQUEST_ENABLE_BT']"
		[Register ("REQUEST_ENABLE_BT")]
		public const int RequestEnableBt = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.helpers']/class[@name='BLEHelpers']/field[@name='SCAN_PERIOD']"
		[Register ("SCAN_PERIOD")]
		public const long ScanPeriod = (long) 30000;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/helpers/BLEHelpers", typeof (BLEHelpers));

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

		protected BLEHelpers (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.helpers']/class[@name='BLEHelpers']/constructor[@name='BLEHelpers' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BLEHelpers () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.helpers']/class[@name='BLEHelpers']/method[@name='checkBLESupportForAdapter' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkBLESupportForAdapter", "(Landroid/content/Context;)Landroid/bluetooth/BluetoothAdapter;", "")]
		public static unsafe global::Android.Bluetooth.BluetoothAdapter CheckBLESupportForAdapter (global::Android.Content.Context context)
		{
			const string __id = "checkBLESupportForAdapter.(Landroid/content/Context;)Landroid/bluetooth/BluetoothAdapter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothAdapter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.helpers']/class[@name='BLEHelpers']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initialize", "(Landroid/content/Context;)V", "")]
		public static unsafe void Initialize (global::Android.Content.Context context)
		{
			const string __id = "initialize.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.helpers']/class[@name='BLEHelpers']/method[@name='isValidLinkaLock' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.Lock.BLE.BluetoothLEDevice']]"
		[Register ("isValidLinkaLock", "(Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLEDevice;)Z", "")]
		public static unsafe bool IsValidLinkaLock (global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLEDevice device)
		{
			const string __id = "isValidLinkaLock.(Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLEDevice;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (device);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.helpers']/class[@name='BLEHelpers']/method[@name='makeBluetoothLEDevice' and count(parameter)=4 and parameter[1][@type='android.bluetooth.BluetoothDevice'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='boolean']]"
		[Register ("makeBluetoothLEDevice", "(Landroid/bluetooth/BluetoothDevice;I[BZ)Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLEDevice;", "")]
		public static unsafe global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLEDevice MakeBluetoothLEDevice (global::Android.Bluetooth.BluetoothDevice device, int rssi, byte[] scanrecord, bool bonded)
		{
			const string __id = "makeBluetoothLEDevice.(Landroid/bluetooth/BluetoothDevice;I[BZ)Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLEDevice;";
			IntPtr native_scanrecord = JNIEnv.NewArray (scanrecord);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				__args [1] = new JniArgumentValue (rssi);
				__args [2] = new JniArgumentValue (native_scanrecord);
				__args [3] = new JniArgumentValue (bonded);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLEDevice> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (scanrecord != null) {
					JNIEnv.CopyArray (native_scanrecord, scanrecord);
					JNIEnv.DeleteLocalRef (native_scanrecord);
				}
				global::System.GC.KeepAlive (device);
				global::System.GC.KeepAlive (scanrecord);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.helpers']/class[@name='BLEHelpers']/method[@name='upsertBluetoothLEDeviceList' and count(parameter)=5 and parameter[1][@type='java.util.List&lt;com.linka.linkaapikit.module.Lock.BLE.BluetoothLEDevice&gt;'] and parameter[2][@type='java.util.List&lt;com.linka.linkaapikit.module.model.Linka&gt;'] and parameter[3][@type='android.bluetooth.BluetoothDevice'] and parameter[4][@type='int'] and parameter[5][@type='byte[]']]"
		[Register ("upsertBluetoothLEDeviceList", "(Ljava/util/List;Ljava/util/List;Landroid/bluetooth/BluetoothDevice;I[B)Lcom/linka/linkaapikit/module/model/Linka;", "")]
		public static unsafe global::Com.Linka.Linkaapikit.Module.Model.Linka UpsertBluetoothLEDeviceList (global::System.Collections.Generic.IList<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLEDevice> devices, global::System.Collections.Generic.IList<global::Com.Linka.Linkaapikit.Module.Model.Linka> linkaList, global::Android.Bluetooth.BluetoothDevice device, int rssi, byte[] scanrecord)
		{
			const string __id = "upsertBluetoothLEDeviceList.(Ljava/util/List;Ljava/util/List;Landroid/bluetooth/BluetoothDevice;I[B)Lcom/linka/linkaapikit/module/model/Linka;";
			IntPtr native_devices = global::Android.Runtime.JavaList<global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLEDevice>.ToLocalJniHandle (devices);
			IntPtr native_linkaList = global::Android.Runtime.JavaList<global::Com.Linka.Linkaapikit.Module.Model.Linka>.ToLocalJniHandle (linkaList);
			IntPtr native_scanrecord = JNIEnv.NewArray (scanrecord);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_devices);
				__args [1] = new JniArgumentValue (native_linkaList);
				__args [2] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				__args [3] = new JniArgumentValue (rssi);
				__args [4] = new JniArgumentValue (native_scanrecord);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_devices);
				JNIEnv.DeleteLocalRef (native_linkaList);
				if (scanrecord != null) {
					JNIEnv.CopyArray (native_scanrecord, scanrecord);
					JNIEnv.DeleteLocalRef (native_scanrecord);
				}
				global::System.GC.KeepAlive (devices);
				global::System.GC.KeepAlive (linkaList);
				global::System.GC.KeepAlive (device);
				global::System.GC.KeepAlive (scanrecord);
			}
		}

	}
}
