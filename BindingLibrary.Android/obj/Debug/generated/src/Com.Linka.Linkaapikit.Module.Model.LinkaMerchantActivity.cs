using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linka.Linkaapikit.Module.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantActivity']"
	[global::Android.Runtime.Register ("com/linka/linkaapikit/module/model/LinkaMerchantActivity", DoNotGenerateAcw=true)]
	public partial class LinkaMerchantActivity : global::Java.Lang.Object, global::Java.IO.ISerializable {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantActivity']/field[@name='actuations']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantActivity']/field[@name='alarm']"
		[Register ("alarm")]
		public bool Alarm {
			get {
				const string __id = "alarm.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "alarm.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantActivity']/field[@name='api_version']"
		[Register ("api_version")]
		public string ApiVersion {
			get {
				const string __id = "api_version.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "api_version.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantActivity']/field[@name='battery_percent']"
		[Register ("battery_percent")]
		public int BatteryPercent {
			get {
				const string __id = "battery_percent.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "battery_percent.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantActivity']/field[@name='fw_version']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantActivity']/field[@name='latitude']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantActivity']/field[@name='LINKA_ACTIVITY_ON_CHANGE']"
		[Register ("LINKA_ACTIVITY_ON_CHANGE")]
		public const string LinkaActivityOnChange = (string) "LINKA_ACTIVITY_ON_CHANGE";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantActivity']/field[@name='linka_activity_status']"
		[Register ("linka_activity_status")]
		public int LinkaActivityStatus {
			get {
				const string __id = "linka_activity_status.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "linka_activity_status.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantActivity']/field[@name='linka_id']"
		[Register ("linka_id")]
		public long LinkaId {
			get {
				const string __id = "linka_id.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "linka_id.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantActivity']/field[@name='linka_uuid']"
		[Register ("linka_uuid")]
		public string LinkaUuid {
			get {
				const string __id = "linka_uuid.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "linka_uuid.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantActivity']/field[@name='lock_serial_no']"
		[Register ("lock_serial_no")]
		public string LockSerialNo {
			get {
				const string __id = "lock_serial_no.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "lock_serial_no.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantActivity']/field[@name='longitude']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantActivity']/field[@name='msg_desc']"
		[Register ("msg_desc")]
		public string MsgDesc {
			get {
				const string __id = "msg_desc.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "msg_desc.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantActivity']/field[@name='os_version']"
		[Register ("os_version")]
		public string OsVersion {
			get {
				const string __id = "os_version.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "os_version.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantActivity']/field[@name='pac']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantActivity']/field[@name='platform']"
		[Register ("platform")]
		public string Platform {
			get {
				const string __id = "platform.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "platform.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantActivity']/field[@name='temperature']"
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/model/LinkaMerchantActivity", typeof (LinkaMerchantActivity));

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

		protected LinkaMerchantActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantActivity']/constructor[@name='LinkaMerchantActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LinkaMerchantActivity () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe string AppVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantActivity']/method[@name='getAppVersion' and count(parameter)=0]"
			[Register ("getAppVersion", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getAppVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string DeviceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantActivity']/method[@name='getDeviceName' and count(parameter)=0]"
			[Register ("getDeviceName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDeviceName.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantActivity']/method[@name='getApplicationName' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getApplicationName", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetApplicationName (global::Android.Content.Context context)
		{
			const string __id = "getApplicationName.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantActivity']/method[@name='removeAllActivitiesForLinka' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.model.Linka']]"
		[Register ("removeAllActivitiesForLinka", "(Lcom/linka/linkaapikit/module/model/Linka;)Z", "")]
		public static unsafe bool RemoveAllActivitiesForLinka (global::Com.Linka.Linkaapikit.Module.Model.Linka linka)
		{
			const string __id = "removeAllActivitiesForLinka.(Lcom/linka/linkaapikit/module/model/Linka;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((linka == null) ? IntPtr.Zero : ((global::Java.Lang.Object) linka).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (linka);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='LinkaMerchantActivity']/method[@name='saveLinkaMerchantError' and count(parameter)=2 and parameter[1][@type='com.linka.linkaapikit.module.model.Linka'] and parameter[2][@type='int']]"
		[Register ("saveLinkaMerchantError", "(Lcom/linka/linkaapikit/module/model/Linka;I)V", "")]
		public static unsafe void SaveLinkaMerchantError (global::Com.Linka.Linkaapikit.Module.Model.Linka linka, int merchantError)
		{
			const string __id = "saveLinkaMerchantError.(Lcom/linka/linkaapikit/module/model/Linka;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((linka == null) ? IntPtr.Zero : ((global::Java.Lang.Object) linka).Handle);
				__args [1] = new JniArgumentValue (merchantError);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (linka);
			}
		}

	}
}
