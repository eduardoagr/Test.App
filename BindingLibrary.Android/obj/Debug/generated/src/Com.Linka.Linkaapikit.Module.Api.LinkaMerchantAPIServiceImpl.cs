using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linka.Linkaapikit.Module.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl']"
	[global::Android.Runtime.Register ("com/linka/linkaapikit/module/api/LinkaMerchantAPIServiceImpl", DoNotGenerateAcw=true)]
	public partial class LinkaMerchantAPIServiceImpl : global::Java.Lang.Object {
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/interface[@name='LinkaMerchantAPIServiceImpl.LinkaMerchantAPICallbacks']"
		[Register ("com/linka/linkaapikit/module/api/LinkaMerchantAPIServiceImpl$LinkaMerchantAPICallbacks", "", "Com.Linka.Linkaapikit.Module.Api.LinkaMerchantAPIServiceImpl/ILinkaMerchantAPICallbacksInvoker")]
		public partial interface ILinkaMerchantAPICallbacks : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/interface[@name='LinkaMerchantAPIServiceImpl.LinkaMerchantAPICallbacks']/method[@name='callback' and count(parameter)=4 and parameter[1][@type='com.linka.linkaapikit.module.model.Linka'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
			[Register ("callback", "(Lcom/linka/linkaapikit/module/model/Linka;ZZI)V", "GetCallback_Lcom_linka_linkaapikit_module_model_Linka_ZZIHandler:Com.Linka.Linkaapikit.Module.Api.LinkaMerchantAPIServiceImpl/ILinkaMerchantAPICallbacksInvoker, BindingLibrary.Android")]
			void Callback (global::Com.Linka.Linkaapikit.Module.Model.Linka p0, bool p1, bool p2, int p3);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/interface[@name='LinkaMerchantAPIServiceImpl.LinkaMerchantAPICallbacks']/method[@name='progressCallback' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='int']]"
			[Register ("progressCallback", "(ZI)V", "GetProgressCallback_ZIHandler:Com.Linka.Linkaapikit.Module.Api.LinkaMerchantAPIServiceImpl/ILinkaMerchantAPICallbacksInvoker, BindingLibrary.Android")]
			void ProgressCallback (bool p0, int p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/interface[@name='LinkaMerchantAPIServiceImpl.LinkaMerchantAPICallbacks']/method[@name='successCallback' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.widget.LockController']]"
			[Register ("successCallback", "(Lcom/linka/linkaapikit/module/widget/LockController;)V", "GetSuccessCallback_Lcom_linka_linkaapikit_module_widget_LockController_Handler:Com.Linka.Linkaapikit.Module.Api.LinkaMerchantAPIServiceImpl/ILinkaMerchantAPICallbacksInvoker, BindingLibrary.Android")]
			void SuccessCallback (global::Com.Linka.Linkaapikit.Module.Widget.LockController p0);

		}

		[global::Android.Runtime.Register ("com/linka/linkaapikit/module/api/LinkaMerchantAPIServiceImpl$LinkaMerchantAPICallbacks", DoNotGenerateAcw=true)]
		internal partial class ILinkaMerchantAPICallbacksInvoker : global::Java.Lang.Object, ILinkaMerchantAPICallbacks {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/api/LinkaMerchantAPIServiceImpl$LinkaMerchantAPICallbacks", typeof (ILinkaMerchantAPICallbacksInvoker));

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

			public static ILinkaMerchantAPICallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ILinkaMerchantAPICallbacks> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linka.linkaapikit.module.api.LinkaMerchantAPIServiceImpl.LinkaMerchantAPICallbacks'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ILinkaMerchantAPICallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_callback_Lcom_linka_linkaapikit_module_model_Linka_ZZI;
#pragma warning disable 0169
			static Delegate GetCallback_Lcom_linka_linkaapikit_module_model_Linka_ZZIHandler ()
			{
				if (cb_callback_Lcom_linka_linkaapikit_module_model_Linka_ZZI == null)
					cb_callback_Lcom_linka_linkaapikit_module_model_Linka_ZZI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZZI_V) n_Callback_Lcom_linka_linkaapikit_module_model_Linka_ZZI);
				return cb_callback_Lcom_linka_linkaapikit_module_model_Linka_ZZI;
			}

			static void n_Callback_Lcom_linka_linkaapikit_module_model_Linka_ZZI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, bool p2, int p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Api.LinkaMerchantAPIServiceImpl.ILinkaMerchantAPICallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.Linka> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Callback (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_callback_Lcom_linka_linkaapikit_module_model_Linka_ZZI;
			public unsafe void Callback (global::Com.Linka.Linkaapikit.Module.Model.Linka p0, bool p1, bool p2, int p3)
			{
				if (id_callback_Lcom_linka_linkaapikit_module_model_Linka_ZZI == IntPtr.Zero)
					id_callback_Lcom_linka_linkaapikit_module_model_Linka_ZZI = JNIEnv.GetMethodID (class_ref, "callback", "(Lcom/linka/linkaapikit/module/model/Linka;ZZI)V");
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_callback_Lcom_linka_linkaapikit_module_model_Linka_ZZI, __args);
			}

			static Delegate cb_progressCallback_ZI;
#pragma warning disable 0169
			static Delegate GetProgressCallback_ZIHandler ()
			{
				if (cb_progressCallback_ZI == null)
					cb_progressCallback_ZI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZI_V) n_ProgressCallback_ZI);
				return cb_progressCallback_ZI;
			}

			static void n_ProgressCallback_ZI (IntPtr jnienv, IntPtr native__this, bool p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Api.LinkaMerchantAPIServiceImpl.ILinkaMerchantAPICallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ProgressCallback (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_progressCallback_ZI;
			public unsafe void ProgressCallback (bool p0, int p1)
			{
				if (id_progressCallback_ZI == IntPtr.Zero)
					id_progressCallback_ZI = JNIEnv.GetMethodID (class_ref, "progressCallback", "(ZI)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_progressCallback_ZI, __args);
			}

			static Delegate cb_successCallback_Lcom_linka_linkaapikit_module_widget_LockController_;
#pragma warning disable 0169
			static Delegate GetSuccessCallback_Lcom_linka_linkaapikit_module_widget_LockController_Handler ()
			{
				if (cb_successCallback_Lcom_linka_linkaapikit_module_widget_LockController_ == null)
					cb_successCallback_Lcom_linka_linkaapikit_module_widget_LockController_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SuccessCallback_Lcom_linka_linkaapikit_module_widget_LockController_);
				return cb_successCallback_Lcom_linka_linkaapikit_module_widget_LockController_;
			}

			static void n_SuccessCallback_Lcom_linka_linkaapikit_module_widget_LockController_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Api.LinkaMerchantAPIServiceImpl.ILinkaMerchantAPICallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SuccessCallback (p0);
			}
#pragma warning restore 0169

			IntPtr id_successCallback_Lcom_linka_linkaapikit_module_widget_LockController_;
			public unsafe void SuccessCallback (global::Com.Linka.Linkaapikit.Module.Widget.LockController p0)
			{
				if (id_successCallback_Lcom_linka_linkaapikit_module_widget_LockController_ == IntPtr.Zero)
					id_successCallback_Lcom_linka_linkaapikit_module_widget_LockController_ = JNIEnv.GetMethodID (class_ref, "successCallback", "(Lcom/linka/linkaapikit/module/widget/LockController;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_successCallback_Lcom_linka_linkaapikit_module_widget_LockController_, __args);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl.MerchantErrors']"
		[global::Android.Runtime.Register ("com/linka/linkaapikit/module/api/LinkaMerchantAPIServiceImpl$MerchantErrors", DoNotGenerateAcw=true)]
		public partial class MerchantErrors : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl.MerchantErrors']/field[@name='access_token']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl.MerchantErrors']/field[@name='api_version']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl.MerchantErrors']/field[@name='app_name']"
			[Register ("app_name")]
			public string AppName {
				get {
					const string __id = "app_name.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "app_name.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl.MerchantErrors']/field[@name='app_version']"
			[Register ("app_version")]
			public string AppVersion {
				get {
					const string __id = "app_version.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "app_version.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl.MerchantErrors']/field[@name='battery_percent']"
			[Register ("battery_percent")]
			public string BatteryPercent {
				get {
					const string __id = "battery_percent.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "battery_percent.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl.MerchantErrors']/field[@name='code']"
			[Register ("code")]
			public int Code {
				get {
					const string __id = "code.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "code.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl.MerchantErrors']/field[@name='desc']"
			[Register ("desc")]
			public string Desc {
				get {
					const string __id = "desc.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "desc.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl.MerchantErrors']/field[@name='fw_version']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl.MerchantErrors']/field[@name='latitude']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl.MerchantErrors']/field[@name='lock_serial_no']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl.MerchantErrors']/field[@name='longitude']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl.MerchantErrors']/field[@name='os_version']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl.MerchantErrors']/field[@name='phone']"
			[Register ("phone")]
			public string Phone {
				get {
					const string __id = "phone.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "phone.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl.MerchantErrors']/field[@name='platform']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl.MerchantErrors']/field[@name='uuid']"
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

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/api/LinkaMerchantAPIServiceImpl$MerchantErrors", typeof (MerchantErrors));

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

			protected MerchantErrors (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl.MerchantErrors']/constructor[@name='LinkaMerchantAPIServiceImpl.MerchantErrors' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe MerchantErrors () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/api/LinkaMerchantAPIServiceImpl", typeof (LinkaMerchantAPIServiceImpl));

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

		protected LinkaMerchantAPIServiceImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl']/constructor[@name='LinkaMerchantAPIServiceImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LinkaMerchantAPIServiceImpl () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl']/method[@name='getAccessToken' and count(parameter)=0]"
			[Register ("getAccessToken", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getAccessToken.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe bool HasAccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl']/method[@name='hasAccessToken' and count(parameter)=0]"
			[Register ("hasAccessToken", "()Z", "")]
			get {
				const string __id = "hasAccessToken.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe string UserID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl']/method[@name='getUserID' and count(parameter)=0]"
			[Register ("getUserID", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getUserID.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl']/method[@name='bond_lock' and count(parameter)=2 and parameter[1][@type='com.linka.linkaapikit.module.model.Linka'] and parameter[2][@type='com.linka.linkaapikit.module.api.ResponseCallback']]"
		[Register ("bond_lock", "(Lcom/linka/linkaapikit/module/model/Linka;Lcom/linka/linkaapikit/module/api/ResponseCallback;)V", "")]
		public static unsafe void Bond_lock (global::Com.Linka.Linkaapikit.Module.Model.Linka linka, global::Com.Linka.Linkaapikit.Module.Api.ResponseCallback responseCallback)
		{
			const string __id = "bond_lock.(Lcom/linka/linkaapikit/module/model/Linka;Lcom/linka/linkaapikit/module/api/ResponseCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((linka == null) ? IntPtr.Zero : ((global::Java.Lang.Object) linka).Handle);
				__args [1] = new JniArgumentValue ((responseCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) responseCallback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (linka);
				global::System.GC.KeepAlive (responseCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl']/method[@name='clearAccessToken' and count(parameter)=0]"
		[Register ("clearAccessToken", "()V", "")]
		public static unsafe void ClearAccessToken ()
		{
			const string __id = "clearAccessToken.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl']/method[@name='doErrors' and count(parameter)=2 and parameter[1][@type='com.linka.linkaapikit.module.api.LinkaAPIServiceResponse'] and parameter[2][@type='android.content.Context']]"
		[Register ("doErrors", "(Lcom/linka/linkaapikit/module/api/LinkaAPIServiceResponse;Landroid/content/Context;)Z", "")]
		public static unsafe bool DoErrors (global::Com.Linka.Linkaapikit.Module.Api.LinkaAPIServiceResponse responseData, global::Android.Content.Context context)
		{
			const string __id = "doErrors.(Lcom/linka/linkaapikit/module/api/LinkaAPIServiceResponse;Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((responseData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) responseData).Handle);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (responseData);
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl']/method[@name='fetch_access_token' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.api.ResponseCallback']]"
		[Register ("fetch_access_token", "(Lcom/linka/linkaapikit/module/api/ResponseCallback;)V", "")]
		public static unsafe void Fetch_access_token (global::Com.Linka.Linkaapikit.Module.Api.ResponseCallback responseCallback)
		{
			const string __id = "fetch_access_token.(Lcom/linka/linkaapikit/module/api/ResponseCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((responseCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) responseCallback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (responseCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl']/method[@name='isNetworkAvailable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isNetworkAvailable", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsNetworkAvailable (global::Android.Content.Context context)
		{
			const string __id = "isNetworkAvailable.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl']/method[@name='pairUpWithLockNumber' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.linka.linkaapikit.module.api.LinkaMerchantAPIServiceImpl.LinkaMerchantAPICallbacks']]"
		[Register ("pairUpWithLockNumber", "(ILcom/linka/linkaapikit/module/api/LinkaMerchantAPIServiceImpl$LinkaMerchantAPICallbacks;)V", "")]
		public static unsafe void PairUpWithLockNumber (int lock_number, global::Com.Linka.Linkaapikit.Module.Api.LinkaMerchantAPIServiceImpl.ILinkaMerchantAPICallbacks linkaMerchantAPICallbacks)
		{
			const string __id = "pairUpWithLockNumber.(ILcom/linka/linkaapikit/module/api/LinkaMerchantAPIServiceImpl$LinkaMerchantAPICallbacks;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (lock_number);
				__args [1] = new JniArgumentValue ((linkaMerchantAPICallbacks == null) ? IntPtr.Zero : ((global::Java.Lang.Object) linkaMerchantAPICallbacks).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (linkaMerchantAPICallbacks);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl']/method[@name='register_new_lock_keys' and count(parameter)=4 and parameter[1][@type='com.linka.linkaapikit.module.model.Linka'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.linka.linkaapikit.module.api.ResponseCallback']]"
		[Register ("register_new_lock_keys", "(Lcom/linka/linkaapikit/module/model/Linka;Ljava/lang/String;Ljava/lang/String;Lcom/linka/linkaapikit/module/api/ResponseCallback;)V", "")]
		public static unsafe void Register_new_lock_keys (global::Com.Linka.Linkaapikit.Module.Model.Linka linka, string access_key_master_2, string access_key_master, global::Com.Linka.Linkaapikit.Module.Api.ResponseCallback responseCallback)
		{
			const string __id = "register_new_lock_keys.(Lcom/linka/linkaapikit/module/model/Linka;Ljava/lang/String;Ljava/lang/String;Lcom/linka/linkaapikit/module/api/ResponseCallback;)V";
			IntPtr native_access_key_master_2 = JNIEnv.NewString (access_key_master_2);
			IntPtr native_access_key_master = JNIEnv.NewString (access_key_master);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((linka == null) ? IntPtr.Zero : ((global::Java.Lang.Object) linka).Handle);
				__args [1] = new JniArgumentValue (native_access_key_master_2);
				__args [2] = new JniArgumentValue (native_access_key_master);
				__args [3] = new JniArgumentValue ((responseCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) responseCallback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_access_key_master_2);
				JNIEnv.DeleteLocalRef (native_access_key_master);
				global::System.GC.KeepAlive (linka);
				global::System.GC.KeepAlive (responseCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl']/method[@name='saveAccessToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("saveAccessToken", "(Ljava/lang/String;)V", "")]
		public static unsafe void SaveAccessToken (string access_token)
		{
			const string __id = "saveAccessToken.(Ljava/lang/String;)V";
			IntPtr native_access_token = JNIEnv.NewString (access_token);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_access_token);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_access_token);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl']/method[@name='sdk_remote_lock' and count(parameter)=2 and parameter[1][@type='com.linka.linkaapikit.module.model.Linka'] and parameter[2][@type='com.linka.linkaapikit.module.api.ResponseCallback']]"
		[Register ("sdk_remote_lock", "(Lcom/linka/linkaapikit/module/model/Linka;Lcom/linka/linkaapikit/module/api/ResponseCallback;)V", "")]
		public static unsafe void Sdk_remote_lock (global::Com.Linka.Linkaapikit.Module.Model.Linka linka, global::Com.Linka.Linkaapikit.Module.Api.ResponseCallback responseCallback)
		{
			const string __id = "sdk_remote_lock.(Lcom/linka/linkaapikit/module/model/Linka;Lcom/linka/linkaapikit/module/api/ResponseCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((linka == null) ? IntPtr.Zero : ((global::Java.Lang.Object) linka).Handle);
				__args [1] = new JniArgumentValue ((responseCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) responseCallback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (linka);
				global::System.GC.KeepAlive (responseCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl']/method[@name='sdk_remote_unlock' and count(parameter)=2 and parameter[1][@type='com.linka.linkaapikit.module.model.Linka'] and parameter[2][@type='com.linka.linkaapikit.module.api.ResponseCallback']]"
		[Register ("sdk_remote_unlock", "(Lcom/linka/linkaapikit/module/model/Linka;Lcom/linka/linkaapikit/module/api/ResponseCallback;)V", "")]
		public static unsafe void Sdk_remote_unlock (global::Com.Linka.Linkaapikit.Module.Model.Linka linka, global::Com.Linka.Linkaapikit.Module.Api.ResponseCallback responseCallback)
		{
			const string __id = "sdk_remote_unlock.(Lcom/linka/linkaapikit/module/model/Linka;Lcom/linka/linkaapikit/module/api/ResponseCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((linka == null) ? IntPtr.Zero : ((global::Java.Lang.Object) linka).Handle);
				__args [1] = new JniArgumentValue ((responseCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) responseCallback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (linka);
				global::System.GC.KeepAlive (responseCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl']/method[@name='tryDeclareLockOwnership' and count(parameter)=2 and parameter[1][@type='com.linka.linkaapikit.module.Lock.BLE.BluetoothLEDevice'] and parameter[2][@type='com.linka.linkaapikit.module.api.LinkaMerchantAPIServiceImpl.LinkaMerchantAPICallbacks']]"
		[Register ("tryDeclareLockOwnership", "(Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLEDevice;Lcom/linka/linkaapikit/module/api/LinkaMerchantAPIServiceImpl$LinkaMerchantAPICallbacks;)V", "")]
		public static unsafe void TryDeclareLockOwnership (global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLEDevice p, global::Com.Linka.Linkaapikit.Module.Api.LinkaMerchantAPIServiceImpl.ILinkaMerchantAPICallbacks linkaMerchantAPICallbacks)
		{
			const string __id = "tryDeclareLockOwnership.(Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLEDevice;Lcom/linka/linkaapikit/module/api/LinkaMerchantAPIServiceImpl$LinkaMerchantAPICallbacks;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				__args [1] = new JniArgumentValue ((linkaMerchantAPICallbacks == null) ? IntPtr.Zero : ((global::Java.Lang.Object) linkaMerchantAPICallbacks).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p);
				global::System.GC.KeepAlive (linkaMerchantAPICallbacks);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl']/method[@name='tryPreparePairingUp' and count(parameter)=2 and parameter[1][@type='com.linka.linkaapikit.module.Lock.BLE.BluetoothLEDevice'] and parameter[2][@type='com.linka.linkaapikit.module.api.LinkaMerchantAPIServiceImpl.LinkaMerchantAPICallbacks']]"
		[Register ("tryPreparePairingUp", "(Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLEDevice;Lcom/linka/linkaapikit/module/api/LinkaMerchantAPIServiceImpl$LinkaMerchantAPICallbacks;)V", "")]
		public static unsafe void TryPreparePairingUp (global::Com.Linka.Linkaapikit.Module.Lock.BLE.BluetoothLEDevice p, global::Com.Linka.Linkaapikit.Module.Api.LinkaMerchantAPIServiceImpl.ILinkaMerchantAPICallbacks linkaMerchantAPICallbacks)
		{
			const string __id = "tryPreparePairingUp.(Lcom/linka/linkaapikit/module/Lock/BLE/BluetoothLEDevice;Lcom/linka/linkaapikit/module/api/LinkaMerchantAPIServiceImpl$LinkaMerchantAPICallbacks;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				__args [1] = new JniArgumentValue ((linkaMerchantAPICallbacks == null) ? IntPtr.Zero : ((global::Java.Lang.Object) linkaMerchantAPICallbacks).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p);
				global::System.GC.KeepAlive (linkaMerchantAPICallbacks);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaMerchantAPIServiceImpl']/method[@name='tryPreparePairingUpV2' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.linka.linkaapikit.module.api.LinkaMerchantAPIServiceImpl.LinkaMerchantAPICallbacks']]"
		[Register ("tryPreparePairingUpV2", "(Ljava/lang/String;Lcom/linka/linkaapikit/module/api/LinkaMerchantAPIServiceImpl$LinkaMerchantAPICallbacks;)V", "")]
		public static unsafe void TryPreparePairingUpV2 (string lock_address, global::Com.Linka.Linkaapikit.Module.Api.LinkaMerchantAPIServiceImpl.ILinkaMerchantAPICallbacks linkaMerchantAPICallbacks)
		{
			const string __id = "tryPreparePairingUpV2.(Ljava/lang/String;Lcom/linka/linkaapikit/module/api/LinkaMerchantAPIServiceImpl$LinkaMerchantAPICallbacks;)V";
			IntPtr native_lock_address = JNIEnv.NewString (lock_address);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_lock_address);
				__args [1] = new JniArgumentValue ((linkaMerchantAPICallbacks == null) ? IntPtr.Zero : ((global::Java.Lang.Object) linkaMerchantAPICallbacks).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_lock_address);
				global::System.GC.KeepAlive (linkaMerchantAPICallbacks);
			}
		}

	}
}
