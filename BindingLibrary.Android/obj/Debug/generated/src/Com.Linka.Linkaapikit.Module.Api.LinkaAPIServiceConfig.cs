using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linka.Linkaapikit.Module.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceConfig']"
	[global::Android.Runtime.Register ("com/linka/linkaapikit/module/api/LinkaAPIServiceConfig", DoNotGenerateAcw=true)]
	public partial class LinkaAPIServiceConfig : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceConfig']/field[@name='apiProtocol']"
		[Register ("apiProtocol")]
		public static global::Com.Linka.Linkaapikit.Module.Api.ILinkaMerchantAPIProtocol ApiProtocol {
			get {
				const string __id = "apiProtocol.Lcom/linka/linkaapikit/module/api/LinkaMerchantAPIProtocol;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Api.ILinkaMerchantAPIProtocol> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "apiProtocol.Lcom/linka/linkaapikit/module/api/LinkaMerchantAPIProtocol;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceConfig']/field[@name='API_VERSION']"
		[Register ("API_VERSION")]
		public const string ApiVersion = (string) "3.2.5";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceConfig']/field[@name='isDebug']"
		[Register ("isDebug")]
		public const bool IsDebug = (bool) true;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceConfig']/field[@name='URL']"
		[Register ("URL")]
		public const string Url = (string) "https://app.linkalock.com";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/api/LinkaAPIServiceConfig", typeof (LinkaAPIServiceConfig));

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

		protected LinkaAPIServiceConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceConfig']/constructor[@name='LinkaAPIServiceConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LinkaAPIServiceConfig () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe global::Com.Linka.Linkaapikit.Module.Api.ILinkaMerchantAPIProtocol APIProtocol {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceConfig']/method[@name='getAPIProtocol' and count(parameter)=0]"
			[Register ("getAPIProtocol", "()Lcom/linka/linkaapikit/module/api/LinkaMerchantAPIProtocol;", "")]
			get {
				const string __id = "getAPIProtocol.()Lcom/linka/linkaapikit/module/api/LinkaMerchantAPIProtocol;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Api.ILinkaMerchantAPIProtocol> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceConfig']/method[@name='setAPIProtocol' and count(parameter)=1 and parameter[1][@type='com.linka.linkaapikit.module.api.LinkaMerchantAPIProtocol']]"
			[Register ("setAPIProtocol", "(Lcom/linka/linkaapikit/module/api/LinkaMerchantAPIProtocol;)V", "")]
			set {
				const string __id = "setAPIProtocol.(Lcom/linka/linkaapikit/module/api/LinkaMerchantAPIProtocol;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public static unsafe global::Android.Content.Context ApplicationContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceConfig']/method[@name='getApplicationContext' and count(parameter)=0]"
			[Register ("getApplicationContext", "()Landroid/content/Context;", "")]
			get {
				const string __id = "getApplicationContext.()Landroid/content/Context;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Android.Locations.Location LastKnownLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceConfig']/method[@name='getLastKnownLocation' and count(parameter)=0]"
			[Register ("getLastKnownLocation", "()Landroid/location/Location;", "")]
			get {
				const string __id = "getLastKnownLocation.()Landroid/location/Location;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string SecureAndroidId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceConfig']/method[@name='getSecureAndroidId' and count(parameter)=0]"
			[Register ("getSecureAndroidId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getSecureAndroidId.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceConfig']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceConfig']/method[@name='log' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("log", "(Ljava/lang/String;)V", "")]
		public static unsafe void Log (string log)
		{
			const string __id = "log.(Ljava/lang/String;)V";
			IntPtr native_log = JNIEnv.NewString (log);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_log);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_log);
			}
		}

	}
}
