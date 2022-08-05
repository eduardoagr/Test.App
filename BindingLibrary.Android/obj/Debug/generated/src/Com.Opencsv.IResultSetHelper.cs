using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Opencsv {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.opencsv']/interface[@name='ResultSetHelper']"
	[Register ("com/opencsv/ResultSetHelper", "", "Com.Opencsv.IResultSetHelperInvoker")]
	public partial interface IResultSetHelper : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/interface[@name='ResultSetHelper']/method[@name='getColumnNames' and count(parameter)=1 and parameter[1][@type='java.sql.ResultSet']]"
		[Register ("getColumnNames", "(Ljava/sql/ResultSet;)[Ljava/lang/String;", "GetGetColumnNames_Ljava_sql_ResultSet_Handler:Com.Opencsv.IResultSetHelperInvoker, BindingLibrary.Android")]
		string[] GetColumnNames (global::Java.Sql.IResultSet p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/interface[@name='ResultSetHelper']/method[@name='getColumnValues' and count(parameter)=1 and parameter[1][@type='java.sql.ResultSet']]"
		[Register ("getColumnValues", "(Ljava/sql/ResultSet;)[Ljava/lang/String;", "GetGetColumnValues_Ljava_sql_ResultSet_Handler:Com.Opencsv.IResultSetHelperInvoker, BindingLibrary.Android")]
		string[] GetColumnValues (global::Java.Sql.IResultSet p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/interface[@name='ResultSetHelper']/method[@name='getColumnValues' and count(parameter)=2 and parameter[1][@type='java.sql.ResultSet'] and parameter[2][@type='boolean']]"
		[Register ("getColumnValues", "(Ljava/sql/ResultSet;Z)[Ljava/lang/String;", "GetGetColumnValues_Ljava_sql_ResultSet_ZHandler:Com.Opencsv.IResultSetHelperInvoker, BindingLibrary.Android")]
		string[] GetColumnValues (global::Java.Sql.IResultSet p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/interface[@name='ResultSetHelper']/method[@name='getColumnValues' and count(parameter)=4 and parameter[1][@type='java.sql.ResultSet'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("getColumnValues", "(Ljava/sql/ResultSet;ZLjava/lang/String;Ljava/lang/String;)[Ljava/lang/String;", "GetGetColumnValues_Ljava_sql_ResultSet_ZLjava_lang_String_Ljava_lang_String_Handler:Com.Opencsv.IResultSetHelperInvoker, BindingLibrary.Android")]
		string[] GetColumnValues (global::Java.Sql.IResultSet p0, bool p1, string p2, string p3);

	}

	[global::Android.Runtime.Register ("com/opencsv/ResultSetHelper", DoNotGenerateAcw=true)]
	internal partial class IResultSetHelperInvoker : global::Java.Lang.Object, IResultSetHelper {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/opencsv/ResultSetHelper", typeof (IResultSetHelperInvoker));

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

		public static IResultSetHelper GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResultSetHelper> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.opencsv.ResultSetHelper'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResultSetHelperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getColumnNames_Ljava_sql_ResultSet_;
#pragma warning disable 0169
		static Delegate GetGetColumnNames_Ljava_sql_ResultSet_Handler ()
		{
			if (cb_getColumnNames_Ljava_sql_ResultSet_ == null)
				cb_getColumnNames_Ljava_sql_ResultSet_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetColumnNames_Ljava_sql_ResultSet_);
			return cb_getColumnNames_Ljava_sql_ResultSet_;
		}

		static IntPtr n_GetColumnNames_Ljava_sql_ResultSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.IResultSetHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Sql.IResultSet)global::Java.Lang.Object.GetObject<global::Java.Sql.IResultSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetColumnNames (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getColumnNames_Ljava_sql_ResultSet_;
		public unsafe string[] GetColumnNames (global::Java.Sql.IResultSet p0)
		{
			if (id_getColumnNames_Ljava_sql_ResultSet_ == IntPtr.Zero)
				id_getColumnNames_Ljava_sql_ResultSet_ = JNIEnv.GetMethodID (class_ref, "getColumnNames", "(Ljava/sql/ResultSet;)[Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getColumnNames_Ljava_sql_ResultSet_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
			return __ret;
		}

		static Delegate cb_getColumnValues_Ljava_sql_ResultSet_;
#pragma warning disable 0169
		static Delegate GetGetColumnValues_Ljava_sql_ResultSet_Handler ()
		{
			if (cb_getColumnValues_Ljava_sql_ResultSet_ == null)
				cb_getColumnValues_Ljava_sql_ResultSet_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetColumnValues_Ljava_sql_ResultSet_);
			return cb_getColumnValues_Ljava_sql_ResultSet_;
		}

		static IntPtr n_GetColumnValues_Ljava_sql_ResultSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.IResultSetHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Sql.IResultSet)global::Java.Lang.Object.GetObject<global::Java.Sql.IResultSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetColumnValues (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getColumnValues_Ljava_sql_ResultSet_;
		public unsafe string[] GetColumnValues (global::Java.Sql.IResultSet p0)
		{
			if (id_getColumnValues_Ljava_sql_ResultSet_ == IntPtr.Zero)
				id_getColumnValues_Ljava_sql_ResultSet_ = JNIEnv.GetMethodID (class_ref, "getColumnValues", "(Ljava/sql/ResultSet;)[Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getColumnValues_Ljava_sql_ResultSet_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
			return __ret;
		}

		static Delegate cb_getColumnValues_Ljava_sql_ResultSet_Z;
#pragma warning disable 0169
		static Delegate GetGetColumnValues_Ljava_sql_ResultSet_ZHandler ()
		{
			if (cb_getColumnValues_Ljava_sql_ResultSet_Z == null)
				cb_getColumnValues_Ljava_sql_ResultSet_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_L) n_GetColumnValues_Ljava_sql_ResultSet_Z);
			return cb_getColumnValues_Ljava_sql_ResultSet_Z;
		}

		static IntPtr n_GetColumnValues_Ljava_sql_ResultSet_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.IResultSetHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Sql.IResultSet)global::Java.Lang.Object.GetObject<global::Java.Sql.IResultSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetColumnValues (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getColumnValues_Ljava_sql_ResultSet_Z;
		public unsafe string[] GetColumnValues (global::Java.Sql.IResultSet p0, bool p1)
		{
			if (id_getColumnValues_Ljava_sql_ResultSet_Z == IntPtr.Zero)
				id_getColumnValues_Ljava_sql_ResultSet_Z = JNIEnv.GetMethodID (class_ref, "getColumnValues", "(Ljava/sql/ResultSet;Z)[Ljava/lang/String;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			var __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getColumnValues_Ljava_sql_ResultSet_Z, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
			return __ret;
		}

		static Delegate cb_getColumnValues_Ljava_sql_ResultSet_ZLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetColumnValues_Ljava_sql_ResultSet_ZLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getColumnValues_Ljava_sql_ResultSet_ZLjava_lang_String_Ljava_lang_String_ == null)
				cb_getColumnValues_Ljava_sql_ResultSet_ZLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZLL_L) n_GetColumnValues_Ljava_sql_ResultSet_ZLjava_lang_String_Ljava_lang_String_);
			return cb_getColumnValues_Ljava_sql_ResultSet_ZLjava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetColumnValues_Ljava_sql_ResultSet_ZLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.IResultSetHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Sql.IResultSet)global::Java.Lang.Object.GetObject<global::Java.Sql.IResultSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetColumnValues (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getColumnValues_Ljava_sql_ResultSet_ZLjava_lang_String_Ljava_lang_String_;
		public unsafe string[] GetColumnValues (global::Java.Sql.IResultSet p0, bool p1, string p2, string p3)
		{
			if (id_getColumnValues_Ljava_sql_ResultSet_ZLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getColumnValues_Ljava_sql_ResultSet_ZLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getColumnValues", "(Ljava/sql/ResultSet;ZLjava/lang/String;Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			var __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getColumnValues_Ljava_sql_ResultSet_ZLjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

	}
}
