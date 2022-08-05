using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Opencsv.Bean {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.opencsv.bean']/interface[@name='CsvToBeanFilter']"
	[Register ("com/opencsv/bean/CsvToBeanFilter", "", "Com.Opencsv.Bean.ICsvToBeanFilterInvoker")]
	public partial interface ICsvToBeanFilter : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/interface[@name='CsvToBeanFilter']/method[@name='allowLine' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("allowLine", "([Ljava/lang/String;)Z", "GetAllowLine_arrayLjava_lang_String_Handler:Com.Opencsv.Bean.ICsvToBeanFilterInvoker, BindingLibrary.Android")]
		bool AllowLine (string[] p0);

	}

	[global::Android.Runtime.Register ("com/opencsv/bean/CsvToBeanFilter", DoNotGenerateAcw=true)]
	internal partial class ICsvToBeanFilterInvoker : global::Java.Lang.Object, ICsvToBeanFilter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/opencsv/bean/CsvToBeanFilter", typeof (ICsvToBeanFilterInvoker));

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

		public static ICsvToBeanFilter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICsvToBeanFilter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.opencsv.bean.CsvToBeanFilter'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICsvToBeanFilterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_allowLine_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAllowLine_arrayLjava_lang_String_Handler ()
		{
			if (cb_allowLine_arrayLjava_lang_String_ == null)
				cb_allowLine_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_AllowLine_arrayLjava_lang_String_);
			return cb_allowLine_arrayLjava_lang_String_;
		}

		static bool n_AllowLine_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.ICsvToBeanFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			bool __ret = __this.AllowLine (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_allowLine_arrayLjava_lang_String_;
		public unsafe bool AllowLine (string[] p0)
		{
			if (id_allowLine_arrayLjava_lang_String_ == IntPtr.Zero)
				id_allowLine_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "allowLine", "([Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_allowLine_arrayLjava_lang_String_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}
}
