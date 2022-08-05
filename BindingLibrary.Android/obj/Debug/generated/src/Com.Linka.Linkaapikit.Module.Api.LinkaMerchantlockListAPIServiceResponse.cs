using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linka.Linkaapikit.Module.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantlockListAPIServiceResponse']"
	[global::Android.Runtime.Register ("com/linka/linkaapikit/module/api/LinkaMerchantlockListAPIServiceResponse", DoNotGenerateAcw=true)]
	public partial class LinkaMerchantlockListAPIServiceResponse : global::Com.Linka.Linkaapikit.Module.Api.LinkaAPIServiceResponse {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantlockListAPIServiceResponse.Data']"
		[global::Android.Runtime.Register ("com/linka/linkaapikit/module/api/LinkaMerchantlockListAPIServiceResponse$Data", DoNotGenerateAcw=true)]
		public partial class Data : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantlockListAPIServiceResponse.Data']/field[@name='access_key_admin']"
			[Register ("access_key_admin")]
			public string AccessKeyAdmin {
				get {
					const string __id = "access_key_admin.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "access_key_admin.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantlockListAPIServiceResponse.Data']/field[@name='access_key_admin_2']"
			[Register ("access_key_admin_2")]
			public string AccessKeyAdmin2 {
				get {
					const string __id = "access_key_admin_2.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "access_key_admin_2.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantlockListAPIServiceResponse.Data']/field[@name='access_key_master']"
			[Register ("access_key_master")]
			public string AccessKeyMaster {
				get {
					const string __id = "access_key_master.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "access_key_master.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantlockListAPIServiceResponse.Data']/field[@name='access_key_master_2']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantlockListAPIServiceResponse.Data']/field[@name='access_key_user']"
			[Register ("access_key_user")]
			public string AccessKeyUser {
				get {
					const string __id = "access_key_user.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "access_key_user.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantlockListAPIServiceResponse.Data']/field[@name='access_key_user_2']"
			[Register ("access_key_user_2")]
			public string AccessKeyUser2 {
				get {
					const string __id = "access_key_user_2.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "access_key_user_2.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantlockListAPIServiceResponse.Data']/field[@name='createdAt']"
			[Register ("createdAt")]
			public string CreatedAt {
				get {
					const string __id = "createdAt.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "createdAt.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantlockListAPIServiceResponse.Data']/field[@name='is_key_registered']"
			[Register ("is_key_registered")]
			public bool IsKeyRegistered {
				get {
					const string __id = "is_key_registered.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "is_key_registered.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantlockListAPIServiceResponse.Data']/field[@name='is_key_revoked']"
			[Register ("is_key_revoked")]
			public bool IsKeyRevoked {
				get {
					const string __id = "is_key_revoked.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "is_key_revoked.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantlockListAPIServiceResponse.Data']/field[@name='is_locked']"
			[Register ("is_locked")]
			public bool IsLocked {
				get {
					const string __id = "is_locked.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "is_locked.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantlockListAPIServiceResponse.Data']/field[@name='is_suspended']"
			[Register ("is_suspended")]
			public bool IsSuspended {
				get {
					const string __id = "is_suspended.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "is_suspended.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantlockListAPIServiceResponse.Data']/field[@name='latitude']"
			[Register ("latitude")]
			public double Latitude {
				get {
					const string __id = "latitude.D";

					var __v = _members.InstanceFields.GetDoubleValue (__id, this);
					return __v;
				}
				set {
					const string __id = "latitude.D";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantlockListAPIServiceResponse.Data']/field[@name='lock_serial_no']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantlockListAPIServiceResponse.Data']/field[@name='longitude']"
			[Register ("longitude")]
			public double Longitude {
				get {
					const string __id = "longitude.D";

					var __v = _members.InstanceFields.GetDoubleValue (__id, this);
					return __v;
				}
				set {
					const string __id = "longitude.D";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantlockListAPIServiceResponse.Data']/field[@name='merchant_id']"
			[Register ("merchant_id")]
			public string MerchantId {
				get {
					const string __id = "merchant_id.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "merchant_id.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantlockListAPIServiceResponse.Data']/field[@name='modifiedAt']"
			[Register ("modifiedAt")]
			public string ModifiedAt {
				get {
					const string __id = "modifiedAt.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "modifiedAt.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantlockListAPIServiceResponse.Data']/field[@name='name']"
			[Register ("name")]
			public string Name {
				get {
					const string __id = "name.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "name.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantlockListAPIServiceResponse.Data']/field[@name='removed']"
			[Register ("removed")]
			public bool Removed {
				get {
					const string __id = "removed.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "removed.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantlockListAPIServiceResponse.Data']/field[@name='_id']"
			[Register ("_id")]
			public string Id {
				get {
					const string __id = "_id.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "_id.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/api/LinkaMerchantlockListAPIServiceResponse$Data", typeof (Data));

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

			protected Data (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantlockListAPIServiceResponse.Data']/constructor[@name='LinkaMerchantlockListAPIServiceResponse.Data' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Data () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/api/LinkaMerchantlockListAPIServiceResponse", typeof (LinkaMerchantlockListAPIServiceResponse));

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

		protected LinkaMerchantlockListAPIServiceResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantlockListAPIServiceResponse']/constructor[@name='LinkaMerchantlockListAPIServiceResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LinkaMerchantlockListAPIServiceResponse () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
