using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linka.Linkaapikit.Module.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceResponse']"
	[global::Android.Runtime.Register ("com/linka/linkaapikit/module/api/LinkaAPIServiceResponse", DoNotGenerateAcw=true)]
	public partial class LinkaAPIServiceResponse : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceResponse']/field[@name='message']"
		[Register ("message")]
		public string Message {
			get {
				const string __id = "message.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "message.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceResponse']/field[@name='status']"
		[Register ("status")]
		public string Status {
			get {
				const string __id = "status.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "status.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceResponse']/field[@name='statusCode']"
		[Register ("statusCode")]
		public int StatusCode {
			get {
				const string __id = "statusCode.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "statusCode.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceResponse.GenMasterKeyResponse']"
		[global::Android.Runtime.Register ("com/linka/linkaapikit/module/api/LinkaAPIServiceResponse$GenMasterKeyResponse", DoNotGenerateAcw=true)]
		public partial class GenMasterKeyResponse : global::Com.Linka.Linkaapikit.Module.Api.LinkaAPIServiceResponse {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceResponse.GenMasterKeyResponse.Data']"
			[global::Android.Runtime.Register ("com/linka/linkaapikit/module/api/LinkaAPIServiceResponse$GenMasterKeyResponse$Data", DoNotGenerateAcw=true)]
			public partial class Data : global::Java.Lang.Object {

				// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceResponse.GenMasterKeyResponse.Data']/field[@name='access_key_master']"
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


				// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceResponse.GenMasterKeyResponse.Data']/field[@name='access_key_master_2']"
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


				// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceResponse.GenMasterKeyResponse.Data']/field[@name='access_key_origin']"
				[Register ("access_key_origin")]
				public string AccessKeyOrigin {
					get {
						const string __id = "access_key_origin.Ljava/lang/String;";

						var __v = _members.InstanceFields.GetObjectValue (__id, this);
						return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
					set {
						const string __id = "access_key_origin.Ljava/lang/String;";

						IntPtr native_value = JNIEnv.NewString (value);
						try {
							_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceResponse.GenMasterKeyResponse.Data']/field[@name='access_key_origin_v2']"
				[Register ("access_key_origin_v2")]
				public string AccessKeyOriginV2 {
					get {
						const string __id = "access_key_origin_v2.Ljava/lang/String;";

						var __v = _members.InstanceFields.GetObjectValue (__id, this);
						return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
					set {
						const string __id = "access_key_origin_v2.Ljava/lang/String;";

						IntPtr native_value = JNIEnv.NewString (value);
						try {
							_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}

				static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/api/LinkaAPIServiceResponse$GenMasterKeyResponse$Data", typeof (Data));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceResponse.GenMasterKeyResponse.Data']/constructor[@name='LinkaAPIServiceResponse.GenMasterKeyResponse.Data' and count(parameter)=0]"
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

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/api/LinkaAPIServiceResponse$GenMasterKeyResponse", typeof (GenMasterKeyResponse));

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

			protected GenMasterKeyResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceResponse.GenMasterKeyResponse']/constructor[@name='LinkaAPIServiceResponse.GenMasterKeyResponse' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe GenMasterKeyResponse () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceResponse.GetKeyfobResponse']"
		[global::Android.Runtime.Register ("com/linka/linkaapikit/module/api/LinkaAPIServiceResponse$GetKeyfobResponse", DoNotGenerateAcw=true)]
		public partial class GetKeyfobResponse : global::Com.Linka.Linkaapikit.Module.Api.LinkaAPIServiceResponse {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceResponse.GetKeyfobResponse.Data']"
			[global::Android.Runtime.Register ("com/linka/linkaapikit/module/api/LinkaAPIServiceResponse$GetKeyfobResponse$Data", DoNotGenerateAcw=true)]
			public partial class Data : global::Java.Lang.Object {

				// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceResponse.GetKeyfobResponse.Data']/field[@name='mac_address']"
				[Register ("mac_address")]
				public string MacAddress {
					get {
						const string __id = "mac_address.Ljava/lang/String;";

						var __v = _members.InstanceFields.GetObjectValue (__id, this);
						return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
					set {
						const string __id = "mac_address.Ljava/lang/String;";

						IntPtr native_value = JNIEnv.NewString (value);
						try {
							_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceResponse.GetKeyfobResponse.Data']/field[@name='major']"
				[Register ("major")]
				public string Major {
					get {
						const string __id = "major.Ljava/lang/String;";

						var __v = _members.InstanceFields.GetObjectValue (__id, this);
						return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
					set {
						const string __id = "major.Ljava/lang/String;";

						IntPtr native_value = JNIEnv.NewString (value);
						try {
							_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceResponse.GetKeyfobResponse.Data']/field[@name='minor']"
				[Register ("minor")]
				public string Minor {
					get {
						const string __id = "minor.Ljava/lang/String;";

						var __v = _members.InstanceFields.GetObjectValue (__id, this);
						return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
					set {
						const string __id = "minor.Ljava/lang/String;";

						IntPtr native_value = JNIEnv.NewString (value);
						try {
							_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceResponse.GetKeyfobResponse.Data']/field[@name='uuid']"
				[Register ("uuid")]
				public string Uuid {
					get {
						const string __id = "uuid.Ljava/lang/String;";

						var __v = _members.InstanceFields.GetObjectValue (__id, this);
						return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
					set {
						const string __id = "uuid.Ljava/lang/String;";

						IntPtr native_value = JNIEnv.NewString (value);
						try {
							_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}

				static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/api/LinkaAPIServiceResponse$GetKeyfobResponse$Data", typeof (Data));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceResponse.GetKeyfobResponse.Data']/constructor[@name='LinkaAPIServiceResponse.GetKeyfobResponse.Data' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.api.LinkaAPIServiceResponse.GetKeyfobResponse']]"
				[Register (".ctor", "(Lcom/linka/linkaapikit/module/api/LinkaAPIServiceResponse$GetKeyfobResponse;)V", "")]
				public unsafe Data (global::Com.Linka.Linkaapikit.Module.Api.LinkaAPIServiceResponse.GetKeyfobResponse __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/api/LinkaAPIServiceResponse$GetKeyfobResponse", typeof (GetKeyfobResponse));

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

			protected GetKeyfobResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceResponse.GetKeyfobResponse']/constructor[@name='LinkaAPIServiceResponse.GetKeyfobResponse' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.api.LinkaAPIServiceResponse']]"
			[Register (".ctor", "(Lcom/linka/linkaapikit/module/api/LinkaAPIServiceResponse;)V", "")]
			public unsafe GetKeyfobResponse (global::Com.Linka.Linkaapikit.Module.Api.LinkaAPIServiceResponse __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/api/LinkaAPIServiceResponse", typeof (LinkaAPIServiceResponse));

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

		protected LinkaAPIServiceResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceResponse']/constructor[@name='LinkaAPIServiceResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LinkaAPIServiceResponse () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceResponse']/method[@name='isError' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.api.LinkaAPIServiceResponse']]"
		[Register ("isError", "(Lcom/linka/linkaapikit/module/api/LinkaAPIServiceResponse;)Z", "")]
		public static unsafe bool IsError (global::Com.Linka.Linkaapikit.Module.Api.LinkaAPIServiceResponse responseData)
		{
			const string __id = "isError.(Lcom/linka/linkaapikit/module/api/LinkaAPIServiceResponse;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((responseData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) responseData).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (responseData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceResponse']/method[@name='isNetworkError' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.api.LinkaAPIServiceResponse']]"
		[Register ("isNetworkError", "(Lcom/linka/linkaapikit/module/api/LinkaAPIServiceResponse;)Z", "")]
		public static unsafe bool IsNetworkError (global::Com.Linka.Linkaapikit.Module.Api.LinkaAPIServiceResponse responseData)
		{
			const string __id = "isNetworkError.(Lcom/linka/linkaapikit/module/api/LinkaAPIServiceResponse;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((responseData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) responseData).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (responseData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceResponse']/method[@name='isSuccess' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.api.LinkaAPIServiceResponse']]"
		[Register ("isSuccess", "(Lcom/linka/linkaapikit/module/api/LinkaAPIServiceResponse;)Z", "")]
		public static unsafe bool IsSuccess (global::Com.Linka.Linkaapikit.Module.Api.LinkaAPIServiceResponse responseData)
		{
			const string __id = "isSuccess.(Lcom/linka/linkaapikit/module/api/LinkaAPIServiceResponse;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((responseData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) responseData).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (responseData);
			}
		}

	}
}
