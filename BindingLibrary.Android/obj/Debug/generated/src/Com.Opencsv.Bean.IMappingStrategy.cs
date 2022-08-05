using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Opencsv.Bean {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.opencsv.bean']/interface[@name='MappingStrategy']"
	[Register ("com/opencsv/bean/MappingStrategy", "", "Com.Opencsv.Bean.IMappingStrategyInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IMappingStrategy : IJavaObject, IJavaPeerable {
		bool IsAnnotationDriven {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/interface[@name='MappingStrategy']/method[@name='isAnnotationDriven' and count(parameter)=0]"
			[Register ("isAnnotationDriven", "()Z", "GetIsAnnotationDrivenHandler:Com.Opencsv.Bean.IMappingStrategyInvoker, BindingLibrary.Android")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/interface[@name='MappingStrategy']/method[@name='captureHeader' and count(parameter)=1 and parameter[1][@type='com.opencsv.CSVReader']]"
		[Register ("captureHeader", "(Lcom/opencsv/CSVReader;)V", "GetCaptureHeader_Lcom_opencsv_CSVReader_Handler:Com.Opencsv.Bean.IMappingStrategyInvoker, BindingLibrary.Android")]
		void CaptureHeader (global::Com.Opencsv.CSVReader p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/interface[@name='MappingStrategy']/method[@name='createBean' and count(parameter)=0]"
		[Register ("createBean", "()Ljava/lang/Object;", "GetCreateBeanHandler:Com.Opencsv.Bean.IMappingStrategyInvoker, BindingLibrary.Android")]
		global::Java.Lang.Object CreateBean ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/interface[@name='MappingStrategy']/method[@name='findField' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("findField", "(I)Lcom/opencsv/bean/BeanField;", "GetFindField_IHandler:Com.Opencsv.Bean.IMappingStrategyInvoker, BindingLibrary.Android")]
		global::Com.Opencsv.Bean.BeanField FindField (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/interface[@name='MappingStrategy']/method[@name='getColumnIndex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getColumnIndex", "(Ljava/lang/String;)Ljava/lang/Integer;", "GetGetColumnIndex_Ljava_lang_String_Handler:Com.Opencsv.Bean.IMappingStrategyInvoker, BindingLibrary.Android")]
		global::Java.Lang.Integer GetColumnIndex (string p0);

	}

	[global::Android.Runtime.Register ("com/opencsv/bean/MappingStrategy", DoNotGenerateAcw=true)]
	internal partial class IMappingStrategyInvoker : global::Java.Lang.Object, IMappingStrategy {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/opencsv/bean/MappingStrategy", typeof (IMappingStrategyInvoker));

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

		public static IMappingStrategy GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMappingStrategy> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.opencsv.bean.MappingStrategy'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMappingStrategyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isAnnotationDriven;
#pragma warning disable 0169
		static Delegate GetIsAnnotationDrivenHandler ()
		{
			if (cb_isAnnotationDriven == null)
				cb_isAnnotationDriven = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAnnotationDriven);
			return cb_isAnnotationDriven;
		}

		static bool n_IsAnnotationDriven (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IMappingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAnnotationDriven;
		}
#pragma warning restore 0169

		IntPtr id_isAnnotationDriven;
		public unsafe bool IsAnnotationDriven {
			get {
				if (id_isAnnotationDriven == IntPtr.Zero)
					id_isAnnotationDriven = JNIEnv.GetMethodID (class_ref, "isAnnotationDriven", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAnnotationDriven);
			}
		}

		static Delegate cb_captureHeader_Lcom_opencsv_CSVReader_;
#pragma warning disable 0169
		static Delegate GetCaptureHeader_Lcom_opencsv_CSVReader_Handler ()
		{
			if (cb_captureHeader_Lcom_opencsv_CSVReader_ == null)
				cb_captureHeader_Lcom_opencsv_CSVReader_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CaptureHeader_Lcom_opencsv_CSVReader_);
			return cb_captureHeader_Lcom_opencsv_CSVReader_;
		}

		static void n_CaptureHeader_Lcom_opencsv_CSVReader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IMappingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReader> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CaptureHeader (p0);
		}
#pragma warning restore 0169

		IntPtr id_captureHeader_Lcom_opencsv_CSVReader_;
		public unsafe void CaptureHeader (global::Com.Opencsv.CSVReader p0)
		{
			if (id_captureHeader_Lcom_opencsv_CSVReader_ == IntPtr.Zero)
				id_captureHeader_Lcom_opencsv_CSVReader_ = JNIEnv.GetMethodID (class_ref, "captureHeader", "(Lcom/opencsv/CSVReader;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_captureHeader_Lcom_opencsv_CSVReader_, __args);
		}

		static Delegate cb_createBean;
#pragma warning disable 0169
		static Delegate GetCreateBeanHandler ()
		{
			if (cb_createBean == null)
				cb_createBean = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CreateBean);
			return cb_createBean;
		}

		static IntPtr n_CreateBean (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IMappingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateBean ());
		}
#pragma warning restore 0169

		IntPtr id_createBean;
		public unsafe global::Java.Lang.Object CreateBean ()
		{
			if (id_createBean == IntPtr.Zero)
				id_createBean = JNIEnv.GetMethodID (class_ref, "createBean", "()Ljava/lang/Object;");
			return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createBean), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_findField_I;
#pragma warning disable 0169
		static Delegate GetFindField_IHandler ()
		{
			if (cb_findField_I == null)
				cb_findField_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_FindField_I);
			return cb_findField_I;
		}

		static IntPtr n_FindField_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IMappingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FindField (p0));
		}
#pragma warning restore 0169

		IntPtr id_findField_I;
		public unsafe global::Com.Opencsv.Bean.BeanField FindField (int p0)
		{
			if (id_findField_I == IntPtr.Zero)
				id_findField_I = JNIEnv.GetMethodID (class_ref, "findField", "(I)Lcom/opencsv/bean/BeanField;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.BeanField> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_findField_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getColumnIndex_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetColumnIndex_Ljava_lang_String_Handler ()
		{
			if (cb_getColumnIndex_Ljava_lang_String_ == null)
				cb_getColumnIndex_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetColumnIndex_Ljava_lang_String_);
			return cb_getColumnIndex_Ljava_lang_String_;
		}

		static IntPtr n_GetColumnIndex_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IMappingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetColumnIndex (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getColumnIndex_Ljava_lang_String_;
		public unsafe global::Java.Lang.Integer GetColumnIndex (string p0)
		{
			if (id_getColumnIndex_Ljava_lang_String_ == IntPtr.Zero)
				id_getColumnIndex_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getColumnIndex", "(Ljava/lang/String;)Ljava/lang/Integer;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getColumnIndex_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
