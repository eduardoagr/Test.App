using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Opencsv {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.opencsv']/class[@name='ResultSetHelperService']"
	[global::Android.Runtime.Register ("com/opencsv/ResultSetHelperService", DoNotGenerateAcw=true)]
	public partial class ResultSetHelperService : global::Java.Lang.Object, global::Com.Opencsv.IResultSetHelper {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv']/class[@name='ResultSetHelperService']/field[@name='CLOBBUFFERSIZE']"
		[Register ("CLOBBUFFERSIZE")]
		public const int Clobbuffersize = (int) 2048;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/opencsv/ResultSetHelperService", typeof (ResultSetHelperService));

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

		protected ResultSetHelperService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='ResultSetHelperService']/constructor[@name='ResultSetHelperService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResultSetHelperService () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getColumnNames_Ljava_sql_ResultSet_;
#pragma warning disable 0169
		static Delegate GetGetColumnNames_Ljava_sql_ResultSet_Handler ()
		{
			if (cb_getColumnNames_Ljava_sql_ResultSet_ == null)
				cb_getColumnNames_Ljava_sql_ResultSet_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetColumnNames_Ljava_sql_ResultSet_);
			return cb_getColumnNames_Ljava_sql_ResultSet_;
		}

		static IntPtr n_GetColumnNames_Ljava_sql_ResultSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.ResultSetHelperService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rs = (global::Java.Sql.IResultSet)global::Java.Lang.Object.GetObject<global::Java.Sql.IResultSet> (native_rs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetColumnNames (rs));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='ResultSetHelperService']/method[@name='getColumnNames' and count(parameter)=1 and parameter[1][@type='java.sql.ResultSet']]"
		[Register ("getColumnNames", "(Ljava/sql/ResultSet;)[Ljava/lang/String;", "GetGetColumnNames_Ljava_sql_ResultSet_Handler")]
		public virtual unsafe string[] GetColumnNames (global::Java.Sql.IResultSet rs)
		{
			const string __id = "getColumnNames.(Ljava/sql/ResultSet;)[Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rs).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				global::System.GC.KeepAlive (rs);
			}
		}

		static Delegate cb_getColumnValues_Ljava_sql_ResultSet_;
#pragma warning disable 0169
		static Delegate GetGetColumnValues_Ljava_sql_ResultSet_Handler ()
		{
			if (cb_getColumnValues_Ljava_sql_ResultSet_ == null)
				cb_getColumnValues_Ljava_sql_ResultSet_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetColumnValues_Ljava_sql_ResultSet_);
			return cb_getColumnValues_Ljava_sql_ResultSet_;
		}

		static IntPtr n_GetColumnValues_Ljava_sql_ResultSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.ResultSetHelperService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rs = (global::Java.Sql.IResultSet)global::Java.Lang.Object.GetObject<global::Java.Sql.IResultSet> (native_rs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetColumnValues (rs));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='ResultSetHelperService']/method[@name='getColumnValues' and count(parameter)=1 and parameter[1][@type='java.sql.ResultSet']]"
		[Register ("getColumnValues", "(Ljava/sql/ResultSet;)[Ljava/lang/String;", "GetGetColumnValues_Ljava_sql_ResultSet_Handler")]
		public virtual unsafe string[] GetColumnValues (global::Java.Sql.IResultSet rs)
		{
			const string __id = "getColumnValues.(Ljava/sql/ResultSet;)[Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rs).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				global::System.GC.KeepAlive (rs);
			}
		}

		static Delegate cb_getColumnValues_Ljava_sql_ResultSet_Z;
#pragma warning disable 0169
		static Delegate GetGetColumnValues_Ljava_sql_ResultSet_ZHandler ()
		{
			if (cb_getColumnValues_Ljava_sql_ResultSet_Z == null)
				cb_getColumnValues_Ljava_sql_ResultSet_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_L) n_GetColumnValues_Ljava_sql_ResultSet_Z);
			return cb_getColumnValues_Ljava_sql_ResultSet_Z;
		}

		static IntPtr n_GetColumnValues_Ljava_sql_ResultSet_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_rs, bool trim)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.ResultSetHelperService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rs = (global::Java.Sql.IResultSet)global::Java.Lang.Object.GetObject<global::Java.Sql.IResultSet> (native_rs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetColumnValues (rs, trim));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='ResultSetHelperService']/method[@name='getColumnValues' and count(parameter)=2 and parameter[1][@type='java.sql.ResultSet'] and parameter[2][@type='boolean']]"
		[Register ("getColumnValues", "(Ljava/sql/ResultSet;Z)[Ljava/lang/String;", "GetGetColumnValues_Ljava_sql_ResultSet_ZHandler")]
		public virtual unsafe string[] GetColumnValues (global::Java.Sql.IResultSet rs, bool trim)
		{
			const string __id = "getColumnValues.(Ljava/sql/ResultSet;Z)[Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((rs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rs).Handle);
				__args [1] = new JniArgumentValue (trim);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				global::System.GC.KeepAlive (rs);
			}
		}

		static Delegate cb_getColumnValues_Ljava_sql_ResultSet_ZLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetColumnValues_Ljava_sql_ResultSet_ZLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getColumnValues_Ljava_sql_ResultSet_ZLjava_lang_String_Ljava_lang_String_ == null)
				cb_getColumnValues_Ljava_sql_ResultSet_ZLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZLL_L) n_GetColumnValues_Ljava_sql_ResultSet_ZLjava_lang_String_Ljava_lang_String_);
			return cb_getColumnValues_Ljava_sql_ResultSet_ZLjava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetColumnValues_Ljava_sql_ResultSet_ZLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rs, bool trim, IntPtr native_timeFormatString, IntPtr native_dateFormatString)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.ResultSetHelperService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rs = (global::Java.Sql.IResultSet)global::Java.Lang.Object.GetObject<global::Java.Sql.IResultSet> (native_rs, JniHandleOwnership.DoNotTransfer);
			var timeFormatString = JNIEnv.GetString (native_timeFormatString, JniHandleOwnership.DoNotTransfer);
			var dateFormatString = JNIEnv.GetString (native_dateFormatString, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetColumnValues (rs, trim, timeFormatString, dateFormatString));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='ResultSetHelperService']/method[@name='getColumnValues' and count(parameter)=4 and parameter[1][@type='java.sql.ResultSet'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("getColumnValues", "(Ljava/sql/ResultSet;ZLjava/lang/String;Ljava/lang/String;)[Ljava/lang/String;", "GetGetColumnValues_Ljava_sql_ResultSet_ZLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string[] GetColumnValues (global::Java.Sql.IResultSet rs, bool trim, string timeFormatString, string dateFormatString)
		{
			const string __id = "getColumnValues.(Ljava/sql/ResultSet;ZLjava/lang/String;Ljava/lang/String;)[Ljava/lang/String;";
			IntPtr native_timeFormatString = JNIEnv.NewString (timeFormatString);
			IntPtr native_dateFormatString = JNIEnv.NewString (dateFormatString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((rs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rs).Handle);
				__args [1] = new JniArgumentValue (trim);
				__args [2] = new JniArgumentValue (native_timeFormatString);
				__args [3] = new JniArgumentValue (native_dateFormatString);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				JNIEnv.DeleteLocalRef (native_timeFormatString);
				JNIEnv.DeleteLocalRef (native_dateFormatString);
				global::System.GC.KeepAlive (rs);
			}
		}

		static Delegate cb_handleBigDecimal_Ljava_math_BigDecimal_;
#pragma warning disable 0169
		static Delegate GetHandleBigDecimal_Ljava_math_BigDecimal_Handler ()
		{
			if (cb_handleBigDecimal_Ljava_math_BigDecimal_ == null)
				cb_handleBigDecimal_Ljava_math_BigDecimal_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_HandleBigDecimal_Ljava_math_BigDecimal_);
			return cb_handleBigDecimal_Ljava_math_BigDecimal_;
		}

		static IntPtr n_HandleBigDecimal_Ljava_math_BigDecimal_ (IntPtr jnienv, IntPtr native__this, IntPtr native__decimal)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.ResultSetHelperService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @decimal = global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (native__decimal, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.HandleBigDecimal (@decimal));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='ResultSetHelperService']/method[@name='handleBigDecimal' and count(parameter)=1 and parameter[1][@type='java.math.BigDecimal']]"
		[Register ("handleBigDecimal", "(Ljava/math/BigDecimal;)Ljava/lang/String;", "GetHandleBigDecimal_Ljava_math_BigDecimal_Handler")]
		protected virtual unsafe string HandleBigDecimal (global::Java.Math.BigDecimal @decimal)
		{
			const string __id = "handleBigDecimal.(Ljava/math/BigDecimal;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@decimal == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @decimal).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (@decimal);
			}
		}

		static Delegate cb_handleDate_Ljava_sql_ResultSet_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHandleDate_Ljava_sql_ResultSet_ILjava_lang_String_Handler ()
		{
			if (cb_handleDate_Ljava_sql_ResultSet_ILjava_lang_String_ == null)
				cb_handleDate_Ljava_sql_ResultSet_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_L) n_HandleDate_Ljava_sql_ResultSet_ILjava_lang_String_);
			return cb_handleDate_Ljava_sql_ResultSet_ILjava_lang_String_;
		}

		static IntPtr n_HandleDate_Ljava_sql_ResultSet_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rs, int columnIndex, IntPtr native_dateFormatString)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.ResultSetHelperService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rs = (global::Java.Sql.IResultSet)global::Java.Lang.Object.GetObject<global::Java.Sql.IResultSet> (native_rs, JniHandleOwnership.DoNotTransfer);
			var dateFormatString = JNIEnv.GetString (native_dateFormatString, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.HandleDate (rs, columnIndex, dateFormatString));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='ResultSetHelperService']/method[@name='handleDate' and count(parameter)=3 and parameter[1][@type='java.sql.ResultSet'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("handleDate", "(Ljava/sql/ResultSet;ILjava/lang/String;)Ljava/lang/String;", "GetHandleDate_Ljava_sql_ResultSet_ILjava_lang_String_Handler")]
		protected virtual unsafe string HandleDate (global::Java.Sql.IResultSet rs, int columnIndex, string dateFormatString)
		{
			const string __id = "handleDate.(Ljava/sql/ResultSet;ILjava/lang/String;)Ljava/lang/String;";
			IntPtr native_dateFormatString = JNIEnv.NewString (dateFormatString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((rs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rs).Handle);
				__args [1] = new JniArgumentValue (columnIndex);
				__args [2] = new JniArgumentValue (native_dateFormatString);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_dateFormatString);
				global::System.GC.KeepAlive (rs);
			}
		}

		static Delegate cb_handleInteger_Ljava_sql_ResultSet_I;
#pragma warning disable 0169
		static Delegate GetHandleInteger_Ljava_sql_ResultSet_IHandler ()
		{
			if (cb_handleInteger_Ljava_sql_ResultSet_I == null)
				cb_handleInteger_Ljava_sql_ResultSet_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_HandleInteger_Ljava_sql_ResultSet_I);
			return cb_handleInteger_Ljava_sql_ResultSet_I;
		}

		static IntPtr n_HandleInteger_Ljava_sql_ResultSet_I (IntPtr jnienv, IntPtr native__this, IntPtr native_rs, int columnIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.ResultSetHelperService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rs = (global::Java.Sql.IResultSet)global::Java.Lang.Object.GetObject<global::Java.Sql.IResultSet> (native_rs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.HandleInteger (rs, columnIndex));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='ResultSetHelperService']/method[@name='handleInteger' and count(parameter)=2 and parameter[1][@type='java.sql.ResultSet'] and parameter[2][@type='int']]"
		[Register ("handleInteger", "(Ljava/sql/ResultSet;I)Ljava/lang/String;", "GetHandleInteger_Ljava_sql_ResultSet_IHandler")]
		protected virtual unsafe string HandleInteger (global::Java.Sql.IResultSet rs, int columnIndex)
		{
			const string __id = "handleInteger.(Ljava/sql/ResultSet;I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((rs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rs).Handle);
				__args [1] = new JniArgumentValue (columnIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (rs);
			}
		}

		static Delegate cb_handleLong_Ljava_sql_ResultSet_I;
#pragma warning disable 0169
		static Delegate GetHandleLong_Ljava_sql_ResultSet_IHandler ()
		{
			if (cb_handleLong_Ljava_sql_ResultSet_I == null)
				cb_handleLong_Ljava_sql_ResultSet_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_HandleLong_Ljava_sql_ResultSet_I);
			return cb_handleLong_Ljava_sql_ResultSet_I;
		}

		static IntPtr n_HandleLong_Ljava_sql_ResultSet_I (IntPtr jnienv, IntPtr native__this, IntPtr native_rs, int columnIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.ResultSetHelperService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rs = (global::Java.Sql.IResultSet)global::Java.Lang.Object.GetObject<global::Java.Sql.IResultSet> (native_rs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.HandleLong (rs, columnIndex));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='ResultSetHelperService']/method[@name='handleLong' and count(parameter)=2 and parameter[1][@type='java.sql.ResultSet'] and parameter[2][@type='int']]"
		[Register ("handleLong", "(Ljava/sql/ResultSet;I)Ljava/lang/String;", "GetHandleLong_Ljava_sql_ResultSet_IHandler")]
		protected virtual unsafe string HandleLong (global::Java.Sql.IResultSet rs, int columnIndex)
		{
			const string __id = "handleLong.(Ljava/sql/ResultSet;I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((rs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rs).Handle);
				__args [1] = new JniArgumentValue (columnIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (rs);
			}
		}

		static Delegate cb_handleObject_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetHandleObject_Ljava_lang_Object_Handler ()
		{
			if (cb_handleObject_Ljava_lang_Object_ == null)
				cb_handleObject_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_HandleObject_Ljava_lang_Object_);
			return cb_handleObject_Ljava_lang_Object_;
		}

		static IntPtr n_HandleObject_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.ResultSetHelperService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.HandleObject (obj));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='ResultSetHelperService']/method[@name='handleObject' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("handleObject", "(Ljava/lang/Object;)Ljava/lang/String;", "GetHandleObject_Ljava_lang_Object_Handler")]
		protected virtual unsafe string HandleObject (global::Java.Lang.Object obj)
		{
			const string __id = "handleObject.(Ljava/lang/Object;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		static Delegate cb_handleTime_Ljava_sql_Time_;
#pragma warning disable 0169
		static Delegate GetHandleTime_Ljava_sql_Time_Handler ()
		{
			if (cb_handleTime_Ljava_sql_Time_ == null)
				cb_handleTime_Ljava_sql_Time_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_HandleTime_Ljava_sql_Time_);
			return cb_handleTime_Ljava_sql_Time_;
		}

		static IntPtr n_HandleTime_Ljava_sql_Time_ (IntPtr jnienv, IntPtr native__this, IntPtr native_time)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.ResultSetHelperService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var time = global::Java.Lang.Object.GetObject<global::Java.Sql.Time> (native_time, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.HandleTime (time));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='ResultSetHelperService']/method[@name='handleTime' and count(parameter)=1 and parameter[1][@type='java.sql.Time']]"
		[Register ("handleTime", "(Ljava/sql/Time;)Ljava/lang/String;", "GetHandleTime_Ljava_sql_Time_Handler")]
		protected virtual unsafe string HandleTime (global::Java.Sql.Time time)
		{
			const string __id = "handleTime.(Ljava/sql/Time;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((time == null) ? IntPtr.Zero : ((global::Java.Lang.Object) time).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (time);
			}
		}

		static Delegate cb_handleTimestamp_Ljava_sql_Timestamp_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHandleTimestamp_Ljava_sql_Timestamp_Ljava_lang_String_Handler ()
		{
			if (cb_handleTimestamp_Ljava_sql_Timestamp_Ljava_lang_String_ == null)
				cb_handleTimestamp_Ljava_sql_Timestamp_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_HandleTimestamp_Ljava_sql_Timestamp_Ljava_lang_String_);
			return cb_handleTimestamp_Ljava_sql_Timestamp_Ljava_lang_String_;
		}

		static IntPtr n_HandleTimestamp_Ljava_sql_Timestamp_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_timestamp, IntPtr native_timestampFormatString)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.ResultSetHelperService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var timestamp = global::Java.Lang.Object.GetObject<global::Java.Sql.Timestamp> (native_timestamp, JniHandleOwnership.DoNotTransfer);
			var timestampFormatString = JNIEnv.GetString (native_timestampFormatString, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.HandleTimestamp (timestamp, timestampFormatString));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='ResultSetHelperService']/method[@name='handleTimestamp' and count(parameter)=2 and parameter[1][@type='java.sql.Timestamp'] and parameter[2][@type='java.lang.String']]"
		[Register ("handleTimestamp", "(Ljava/sql/Timestamp;Ljava/lang/String;)Ljava/lang/String;", "GetHandleTimestamp_Ljava_sql_Timestamp_Ljava_lang_String_Handler")]
		protected virtual unsafe string HandleTimestamp (global::Java.Sql.Timestamp timestamp, string timestampFormatString)
		{
			const string __id = "handleTimestamp.(Ljava/sql/Timestamp;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_timestampFormatString = JNIEnv.NewString (timestampFormatString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((timestamp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timestamp).Handle);
				__args [1] = new JniArgumentValue (native_timestampFormatString);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_timestampFormatString);
				global::System.GC.KeepAlive (timestamp);
			}
		}

		static Delegate cb_setDateFormat_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDateFormat_Ljava_lang_String_Handler ()
		{
			if (cb_setDateFormat_Ljava_lang_String_ == null)
				cb_setDateFormat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDateFormat_Ljava_lang_String_);
			return cb_setDateFormat_Ljava_lang_String_;
		}

		static void n_SetDateFormat_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dateFormat)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.ResultSetHelperService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dateFormat = JNIEnv.GetString (native_dateFormat, JniHandleOwnership.DoNotTransfer);
			__this.SetDateFormat (dateFormat);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='ResultSetHelperService']/method[@name='setDateFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDateFormat", "(Ljava/lang/String;)V", "GetSetDateFormat_Ljava_lang_String_Handler")]
		public virtual unsafe void SetDateFormat (string dateFormat)
		{
			const string __id = "setDateFormat.(Ljava/lang/String;)V";
			IntPtr native_dateFormat = JNIEnv.NewString (dateFormat);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_dateFormat);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_dateFormat);
			}
		}

		static Delegate cb_setDateTimeFormat_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDateTimeFormat_Ljava_lang_String_Handler ()
		{
			if (cb_setDateTimeFormat_Ljava_lang_String_ == null)
				cb_setDateTimeFormat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDateTimeFormat_Ljava_lang_String_);
			return cb_setDateTimeFormat_Ljava_lang_String_;
		}

		static void n_SetDateTimeFormat_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dateTimeFormat)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.ResultSetHelperService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dateTimeFormat = JNIEnv.GetString (native_dateTimeFormat, JniHandleOwnership.DoNotTransfer);
			__this.SetDateTimeFormat (dateTimeFormat);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='ResultSetHelperService']/method[@name='setDateTimeFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDateTimeFormat", "(Ljava/lang/String;)V", "GetSetDateTimeFormat_Ljava_lang_String_Handler")]
		public virtual unsafe void SetDateTimeFormat (string dateTimeFormat)
		{
			const string __id = "setDateTimeFormat.(Ljava/lang/String;)V";
			IntPtr native_dateTimeFormat = JNIEnv.NewString (dateTimeFormat);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_dateTimeFormat);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_dateTimeFormat);
			}
		}

	}
}
