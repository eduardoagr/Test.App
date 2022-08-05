using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linka.Linkaapikit.Module.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceResponse']"
	[global::Android.Runtime.Register ("com/linka/linkaapikit/module/api/LinkaMerchantAPIServiceResponse", DoNotGenerateAcw=true)]
	public partial class LinkaMerchantAPIServiceResponse : global::Com.Linka.Linkaapikit.Module.Api.LinkaAPIServiceResponse {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceResponse.Data']"
		[global::Android.Runtime.Register ("com/linka/linkaapikit/module/api/LinkaMerchantAPIServiceResponse$Data", DoNotGenerateAcw=true)]
		public partial class Data : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceResponse.Data']/field[@name='access_count']"
			[Register ("access_count")]
			public int AccessCount {
				get {
					const string __id = "access_count.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "access_count.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceResponse.Data']/field[@name='access_token']"
			[Register ("access_token")]
			public string AccessToken {
				get {
					const string __id = "access_token.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "access_token.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceResponse.Data']/field[@name='access_token_expireAt']"
			[Register ("access_token_expireAt")]
			public string AccessTokenExpireAt {
				get {
					const string __id = "access_token_expireAt.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "access_token_expireAt.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceResponse.Data']/field[@name='api_key']"
			[Register ("api_key")]
			public string ApiKey {
				get {
					const string __id = "api_key.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "api_key.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceResponse.Data']/field[@name='createdAt']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceResponse.Data']/field[@name='is_suspended']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceResponse.Data']/field[@name='modifiedAt']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceResponse.Data']/field[@name='name']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceResponse.Data']/field[@name='_id']"
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

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/api/LinkaMerchantAPIServiceResponse$Data", typeof (Data));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceResponse.Data']/constructor[@name='LinkaMerchantAPIServiceResponse.Data' and count(parameter)=0]"
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/api/LinkaMerchantAPIServiceResponse", typeof (LinkaMerchantAPIServiceResponse));

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

		protected LinkaMerchantAPIServiceResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceResponse']/constructor[@name='LinkaMerchantAPIServiceResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LinkaMerchantAPIServiceResponse () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
