using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linka.Linkaapikit.Module.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/interface[@name='LinkaMerchantAPIProtocol']"
	[Register ("com/linka/linkaapikit/module/api/LinkaMerchantAPIProtocol", "", "Com.Linka.Linkaapikit.Module.Api.ILinkaMerchantAPIProtocolInvoker")]
	public partial interface ILinkaMerchantAPIProtocol : IJavaObject, IJavaPeerable {
		global::Android.Locations.Location LastKnownLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/interface[@name='LinkaMerchantAPIProtocol']/method[@name='getLastKnownLocation' and count(parameter)=0]"
			[Register ("getLastKnownLocation", "()Landroid/location/Location;", "GetGetLastKnownLocationHandler:Com.Linka.Linkaapikit.Module.Api.ILinkaMerchantAPIProtocolInvoker, BindingLibrary.Android")]
			get; 
		}

		string SecureAndroidId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/interface[@name='LinkaMerchantAPIProtocol']/method[@name='getSecureAndroidId' and count(parameter)=0]"
			[Register ("getSecureAndroidId", "()Ljava/lang/String;", "GetGetSecureAndroidIdHandler:Com.Linka.Linkaapikit.Module.Api.ILinkaMerchantAPIProtocolInvoker, BindingLibrary.Android")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/interface[@name='LinkaMerchantAPIProtocol']/method[@name='LinkaMerchantAPI_getAPIKey' and count(parameter)=0]"
		[Register ("LinkaMerchantAPI_getAPIKey", "()Ljava/lang/String;", "GetLinkaMerchantAPI_getAPIKeyHandler:Com.Linka.Linkaapikit.Module.Api.ILinkaMerchantAPIProtocolInvoker, BindingLibrary.Android")]
		string LinkaMerchantAPI_getAPIKey ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/interface[@name='LinkaMerchantAPIProtocol']/method[@name='LinkaMerchantAPI_getIsButtonUsed' and count(parameter)=0]"
		[Register ("LinkaMerchantAPI_getIsButtonUsed", "()Z", "GetLinkaMerchantAPI_getIsButtonUsedHandler:Com.Linka.Linkaapikit.Module.Api.ILinkaMerchantAPIProtocolInvoker, BindingLibrary.Android")]
		bool LinkaMerchantAPI_getIsButtonUsed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/interface[@name='LinkaMerchantAPIProtocol']/method[@name='LinkaMerchantAPI_getSecretKey' and count(parameter)=0]"
		[Register ("LinkaMerchantAPI_getSecretKey", "()Ljava/lang/String;", "GetLinkaMerchantAPI_getSecretKeyHandler:Com.Linka.Linkaapikit.Module.Api.ILinkaMerchantAPIProtocolInvoker, BindingLibrary.Android")]
		string LinkaMerchantAPI_getSecretKey ();

	}

	[global::Android.Runtime.Register ("com/linka/linkaapikit/module/api/LinkaMerchantAPIProtocol", DoNotGenerateAcw=true)]
	internal partial class ILinkaMerchantAPIProtocolInvoker : global::Java.Lang.Object, ILinkaMerchantAPIProtocol {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/api/LinkaMerchantAPIProtocol", typeof (ILinkaMerchantAPIProtocolInvoker));

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

		public static ILinkaMerchantAPIProtocol GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILinkaMerchantAPIProtocol> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linka.linkaapikit.module.api.LinkaMerchantAPIProtocol'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILinkaMerchantAPIProtocolInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getLastKnownLocation;
#pragma warning disable 0169
		static Delegate GetGetLastKnownLocationHandler ()
		{
			if (cb_getLastKnownLocation == null)
				cb_getLastKnownLocation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLastKnownLocation);
			return cb_getLastKnownLocation;
		}

		static IntPtr n_GetLastKnownLocation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Api.ILinkaMerchantAPIProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastKnownLocation);
		}
#pragma warning restore 0169

		IntPtr id_getLastKnownLocation;
		public unsafe global::Android.Locations.Location LastKnownLocation {
			get {
				if (id_getLastKnownLocation == IntPtr.Zero)
					id_getLastKnownLocation = JNIEnv.GetMethodID (class_ref, "getLastKnownLocation", "()Landroid/location/Location;");
				return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastKnownLocation), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSecureAndroidId;
#pragma warning disable 0169
		static Delegate GetGetSecureAndroidIdHandler ()
		{
			if (cb_getSecureAndroidId == null)
				cb_getSecureAndroidId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSecureAndroidId);
			return cb_getSecureAndroidId;
		}

		static IntPtr n_GetSecureAndroidId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Api.ILinkaMerchantAPIProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SecureAndroidId);
		}
#pragma warning restore 0169

		IntPtr id_getSecureAndroidId;
		public unsafe string SecureAndroidId {
			get {
				if (id_getSecureAndroidId == IntPtr.Zero)
					id_getSecureAndroidId = JNIEnv.GetMethodID (class_ref, "getSecureAndroidId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSecureAndroidId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_LinkaMerchantAPI_getAPIKey;
#pragma warning disable 0169
		static Delegate GetLinkaMerchantAPI_getAPIKeyHandler ()
		{
			if (cb_LinkaMerchantAPI_getAPIKey == null)
				cb_LinkaMerchantAPI_getAPIKey = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_LinkaMerchantAPI_getAPIKey);
			return cb_LinkaMerchantAPI_getAPIKey;
		}

		static IntPtr n_LinkaMerchantAPI_getAPIKey (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Api.ILinkaMerchantAPIProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LinkaMerchantAPI_getAPIKey ());
		}
#pragma warning restore 0169

		IntPtr id_LinkaMerchantAPI_getAPIKey;
		public unsafe string LinkaMerchantAPI_getAPIKey ()
		{
			if (id_LinkaMerchantAPI_getAPIKey == IntPtr.Zero)
				id_LinkaMerchantAPI_getAPIKey = JNIEnv.GetMethodID (class_ref, "LinkaMerchantAPI_getAPIKey", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_LinkaMerchantAPI_getAPIKey), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_LinkaMerchantAPI_getIsButtonUsed;
#pragma warning disable 0169
		static Delegate GetLinkaMerchantAPI_getIsButtonUsedHandler ()
		{
			if (cb_LinkaMerchantAPI_getIsButtonUsed == null)
				cb_LinkaMerchantAPI_getIsButtonUsed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_LinkaMerchantAPI_getIsButtonUsed);
			return cb_LinkaMerchantAPI_getIsButtonUsed;
		}

		static bool n_LinkaMerchantAPI_getIsButtonUsed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Api.ILinkaMerchantAPIProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LinkaMerchantAPI_getIsButtonUsed ();
		}
#pragma warning restore 0169

		IntPtr id_LinkaMerchantAPI_getIsButtonUsed;
		public unsafe bool LinkaMerchantAPI_getIsButtonUsed ()
		{
			if (id_LinkaMerchantAPI_getIsButtonUsed == IntPtr.Zero)
				id_LinkaMerchantAPI_getIsButtonUsed = JNIEnv.GetMethodID (class_ref, "LinkaMerchantAPI_getIsButtonUsed", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_LinkaMerchantAPI_getIsButtonUsed);
		}

		static Delegate cb_LinkaMerchantAPI_getSecretKey;
#pragma warning disable 0169
		static Delegate GetLinkaMerchantAPI_getSecretKeyHandler ()
		{
			if (cb_LinkaMerchantAPI_getSecretKey == null)
				cb_LinkaMerchantAPI_getSecretKey = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_LinkaMerchantAPI_getSecretKey);
			return cb_LinkaMerchantAPI_getSecretKey;
		}

		static IntPtr n_LinkaMerchantAPI_getSecretKey (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Api.ILinkaMerchantAPIProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LinkaMerchantAPI_getSecretKey ());
		}
#pragma warning restore 0169

		IntPtr id_LinkaMerchantAPI_getSecretKey;
		public unsafe string LinkaMerchantAPI_getSecretKey ()
		{
			if (id_LinkaMerchantAPI_getSecretKey == IntPtr.Zero)
				id_LinkaMerchantAPI_getSecretKey = JNIEnv.GetMethodID (class_ref, "LinkaMerchantAPI_getSecretKey", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_LinkaMerchantAPI_getSecretKey), JniHandleOwnership.TransferLocalRef);
		}

	}
}
