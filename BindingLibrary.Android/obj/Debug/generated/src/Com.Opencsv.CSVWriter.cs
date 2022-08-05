using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Opencsv {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']"
	[global::Android.Runtime.Register ("com/opencsv/CSVWriter", DoNotGenerateAcw=true)]
	public partial class CSVWriter : global::Java.Lang.Object, global::Java.IO.ICloseable, global::Java.IO.IFlushable {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/field[@name='DEFAULT_ESCAPE_CHARACTER']"
		[Register ("DEFAULT_ESCAPE_CHARACTER")]
		public const char DefaultEscapeCharacter = (char) (char)34;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/field[@name='DEFAULT_LINE_END']"
		[Register ("DEFAULT_LINE_END")]
		public const string DefaultLineEnd = (string) "\u000a";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/field[@name='DEFAULT_QUOTE_CHARACTER']"
		[Register ("DEFAULT_QUOTE_CHARACTER")]
		public const char DefaultQuoteCharacter = (char) (char)34;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/field[@name='DEFAULT_SEPARATOR']"
		[Register ("DEFAULT_SEPARATOR")]
		public const char DefaultSeparator = (char) (char)44;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/field[@name='INITIAL_STRING_SIZE']"
		[Register ("INITIAL_STRING_SIZE")]
		public const int InitialStringSize = (int) 1024;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/field[@name='NO_ESCAPE_CHARACTER']"
		[Register ("NO_ESCAPE_CHARACTER")]
		public const char NoEscapeCharacter = (char) (char)0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/field[@name='NO_QUOTE_CHARACTER']"
		[Register ("NO_QUOTE_CHARACTER")]
		public const char NoQuoteCharacter = (char) (char)0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/field[@name='RFC4180_LINE_END']"
		[Register ("RFC4180_LINE_END")]
		public const string Rfc4180LineEnd = (string) "\u000d\u000a";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/opencsv/CSVWriter", typeof (CSVWriter));

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

		protected CSVWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/constructor[@name='CSVWriter' and count(parameter)=1 and parameter[1][@type='java.io.Writer']]"
		[Register (".ctor", "(Ljava/io/Writer;)V", "")]
		public unsafe CSVWriter (global::Java.IO.Writer writer) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Writer;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((writer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) writer).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (writer);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/constructor[@name='CSVWriter' and count(parameter)=2 and parameter[1][@type='java.io.Writer'] and parameter[2][@type='char']]"
		[Register (".ctor", "(Ljava/io/Writer;C)V", "")]
		public unsafe CSVWriter (global::Java.IO.Writer writer, char separator) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Writer;C)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((writer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) writer).Handle);
				__args [1] = new JniArgumentValue (separator);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (writer);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/constructor[@name='CSVWriter' and count(parameter)=3 and parameter[1][@type='java.io.Writer'] and parameter[2][@type='char'] and parameter[3][@type='char']]"
		[Register (".ctor", "(Ljava/io/Writer;CC)V", "")]
		public unsafe CSVWriter (global::Java.IO.Writer writer, char separator, char quotechar) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Writer;CC)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((writer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) writer).Handle);
				__args [1] = new JniArgumentValue (separator);
				__args [2] = new JniArgumentValue (quotechar);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (writer);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/constructor[@name='CSVWriter' and count(parameter)=4 and parameter[1][@type='java.io.Writer'] and parameter[2][@type='char'] and parameter[3][@type='char'] and parameter[4][@type='char']]"
		[Register (".ctor", "(Ljava/io/Writer;CCC)V", "")]
		public unsafe CSVWriter (global::Java.IO.Writer writer, char separator, char escapechar, char quotechar) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Writer;CCC)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((writer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) writer).Handle);
				__args [1] = new JniArgumentValue (separator);
				__args [2] = new JniArgumentValue (escapechar);
				__args [3] = new JniArgumentValue (quotechar);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (writer);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/constructor[@name='CSVWriter' and count(parameter)=5 and parameter[1][@type='java.io.Writer'] and parameter[2][@type='char'] and parameter[3][@type='char'] and parameter[4][@type='char'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/io/Writer;CCCLjava/lang/String;)V", "")]
		public unsafe CSVWriter (global::Java.IO.Writer writer, char separator, char escapechar, char quotechar, string lineEnd) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Writer;CCCLjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_lineEnd = JNIEnv.NewString (lineEnd);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((writer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) writer).Handle);
				__args [1] = new JniArgumentValue (separator);
				__args [2] = new JniArgumentValue (escapechar);
				__args [3] = new JniArgumentValue (quotechar);
				__args [4] = new JniArgumentValue (native_lineEnd);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_lineEnd);
				global::System.GC.KeepAlive (writer);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/constructor[@name='CSVWriter' and count(parameter)=4 and parameter[1][@type='java.io.Writer'] and parameter[2][@type='char'] and parameter[3][@type='char'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/io/Writer;CCLjava/lang/String;)V", "")]
		public unsafe CSVWriter (global::Java.IO.Writer writer, char separator, char quotechar, string lineEnd) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Writer;CCLjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_lineEnd = JNIEnv.NewString (lineEnd);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((writer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) writer).Handle);
				__args [1] = new JniArgumentValue (separator);
				__args [2] = new JniArgumentValue (quotechar);
				__args [3] = new JniArgumentValue (native_lineEnd);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_lineEnd);
				global::System.GC.KeepAlive (writer);
			}
		}

		static Delegate cb_checkError;
#pragma warning disable 0169
		static Delegate GetCheckErrorHandler ()
		{
			if (cb_checkError == null)
				cb_checkError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_CheckError);
			return cb_checkError;
		}

		static bool n_CheckError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckError ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/method[@name='checkError' and count(parameter)=0]"
		[Register ("checkError", "()Z", "GetCheckErrorHandler")]
		public virtual unsafe bool CheckError ()
		{
			const string __id = "checkError.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public virtual unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_flushQuietly;
#pragma warning disable 0169
		static Delegate GetFlushQuietlyHandler ()
		{
			if (cb_flushQuietly == null)
				cb_flushQuietly = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_FlushQuietly);
			return cb_flushQuietly;
		}

		static void n_FlushQuietly (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FlushQuietly ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/method[@name='flushQuietly' and count(parameter)=0]"
		[Register ("flushQuietly", "()V", "GetFlushQuietlyHandler")]
		public virtual unsafe void FlushQuietly ()
		{
			const string __id = "flushQuietly.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_processLine_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetProcessLine_Ljava_lang_String_Handler ()
		{
			if (cb_processLine_Ljava_lang_String_ == null)
				cb_processLine_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ProcessLine_Ljava_lang_String_);
			return cb_processLine_Ljava_lang_String_;
		}

		static IntPtr n_ProcessLine_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nextElement)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var nextElement = JNIEnv.GetString (native_nextElement, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ProcessLine (nextElement));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/method[@name='processLine' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("processLine", "(Ljava/lang/String;)Ljava/lang/StringBuilder;", "GetProcessLine_Ljava_lang_String_Handler")]
		protected virtual unsafe global::Java.Lang.StringBuilder ProcessLine (string nextElement)
		{
			const string __id = "processLine.(Ljava/lang/String;)Ljava/lang/StringBuilder;";
			IntPtr native_nextElement = JNIEnv.NewString (nextElement);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_nextElement);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_nextElement);
			}
		}

		static Delegate cb_setResultService_Lcom_opencsv_ResultSetHelper_;
#pragma warning disable 0169
		static Delegate GetSetResultService_Lcom_opencsv_ResultSetHelper_Handler ()
		{
			if (cb_setResultService_Lcom_opencsv_ResultSetHelper_ == null)
				cb_setResultService_Lcom_opencsv_ResultSetHelper_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetResultService_Lcom_opencsv_ResultSetHelper_);
			return cb_setResultService_Lcom_opencsv_ResultSetHelper_;
		}

		static void n_SetResultService_Lcom_opencsv_ResultSetHelper_ (IntPtr jnienv, IntPtr native__this, IntPtr native_resultService)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var resultService = (global::Com.Opencsv.IResultSetHelper)global::Java.Lang.Object.GetObject<global::Com.Opencsv.IResultSetHelper> (native_resultService, JniHandleOwnership.DoNotTransfer);
			__this.SetResultService (resultService);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/method[@name='setResultService' and count(parameter)=1 and parameter[1][@type='com.opencsv.ResultSetHelper']]"
		[Register ("setResultService", "(Lcom/opencsv/ResultSetHelper;)V", "GetSetResultService_Lcom_opencsv_ResultSetHelper_Handler")]
		public virtual unsafe void SetResultService (global::Com.Opencsv.IResultSetHelper resultService)
		{
			const string __id = "setResultService.(Lcom/opencsv/ResultSetHelper;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((resultService == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultService).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (resultService);
			}
		}

		static Delegate cb_writeAll_Ljava_sql_ResultSet_Z;
#pragma warning disable 0169
		static Delegate GetWriteAll_Ljava_sql_ResultSet_ZHandler ()
		{
			if (cb_writeAll_Ljava_sql_ResultSet_Z == null)
				cb_writeAll_Ljava_sql_ResultSet_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_I) n_WriteAll_Ljava_sql_ResultSet_Z);
			return cb_writeAll_Ljava_sql_ResultSet_Z;
		}

		static int n_WriteAll_Ljava_sql_ResultSet_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_rs, bool includeColumnNames)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rs = (global::Java.Sql.IResultSet)global::Java.Lang.Object.GetObject<global::Java.Sql.IResultSet> (native_rs, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.WriteAll (rs, includeColumnNames);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/method[@name='writeAll' and count(parameter)=2 and parameter[1][@type='java.sql.ResultSet'] and parameter[2][@type='boolean']]"
		[Register ("writeAll", "(Ljava/sql/ResultSet;Z)I", "GetWriteAll_Ljava_sql_ResultSet_ZHandler")]
		public virtual unsafe int WriteAll (global::Java.Sql.IResultSet rs, bool includeColumnNames)
		{
			const string __id = "writeAll.(Ljava/sql/ResultSet;Z)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((rs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rs).Handle);
				__args [1] = new JniArgumentValue (includeColumnNames);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (rs);
			}
		}

		static Delegate cb_writeAll_Ljava_sql_ResultSet_ZZ;
#pragma warning disable 0169
		static Delegate GetWriteAll_Ljava_sql_ResultSet_ZZHandler ()
		{
			if (cb_writeAll_Ljava_sql_ResultSet_ZZ == null)
				cb_writeAll_Ljava_sql_ResultSet_ZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZZ_I) n_WriteAll_Ljava_sql_ResultSet_ZZ);
			return cb_writeAll_Ljava_sql_ResultSet_ZZ;
		}

		static int n_WriteAll_Ljava_sql_ResultSet_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_rs, bool includeColumnNames, bool trim)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rs = (global::Java.Sql.IResultSet)global::Java.Lang.Object.GetObject<global::Java.Sql.IResultSet> (native_rs, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.WriteAll (rs, includeColumnNames, trim);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/method[@name='writeAll' and count(parameter)=3 and parameter[1][@type='java.sql.ResultSet'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("writeAll", "(Ljava/sql/ResultSet;ZZ)I", "GetWriteAll_Ljava_sql_ResultSet_ZZHandler")]
		public virtual unsafe int WriteAll (global::Java.Sql.IResultSet rs, bool includeColumnNames, bool trim)
		{
			const string __id = "writeAll.(Ljava/sql/ResultSet;ZZ)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((rs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rs).Handle);
				__args [1] = new JniArgumentValue (includeColumnNames);
				__args [2] = new JniArgumentValue (trim);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (rs);
			}
		}

		static Delegate cb_writeAll_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetWriteAll_Ljava_util_List_Handler ()
		{
			if (cb_writeAll_Ljava_util_List_ == null)
				cb_writeAll_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_WriteAll_Ljava_util_List_);
			return cb_writeAll_Ljava_util_List_;
		}

		static void n_WriteAll_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_allLines)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var allLines = global::Android.Runtime.JavaList<string[]>.FromJniHandle (native_allLines, JniHandleOwnership.DoNotTransfer);
			__this.WriteAll (allLines);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/method[@name='writeAll' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String[]&gt;']]"
		[Register ("writeAll", "(Ljava/util/List;)V", "GetWriteAll_Ljava_util_List_Handler")]
		public virtual unsafe void WriteAll (global::System.Collections.Generic.IList<string[]> allLines)
		{
			const string __id = "writeAll.(Ljava/util/List;)V";
			IntPtr native_allLines = global::Android.Runtime.JavaList<string[]>.ToLocalJniHandle (allLines);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_allLines);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_allLines);
				global::System.GC.KeepAlive (allLines);
			}
		}

		static Delegate cb_writeAll_Ljava_util_List_Z;
#pragma warning disable 0169
		static Delegate GetWriteAll_Ljava_util_List_ZHandler ()
		{
			if (cb_writeAll_Ljava_util_List_Z == null)
				cb_writeAll_Ljava_util_List_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_WriteAll_Ljava_util_List_Z);
			return cb_writeAll_Ljava_util_List_Z;
		}

		static void n_WriteAll_Ljava_util_List_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_allLines, bool applyQuotesToAll)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var allLines = global::Android.Runtime.JavaList<string[]>.FromJniHandle (native_allLines, JniHandleOwnership.DoNotTransfer);
			__this.WriteAll (allLines, applyQuotesToAll);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/method[@name='writeAll' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String[]&gt;'] and parameter[2][@type='boolean']]"
		[Register ("writeAll", "(Ljava/util/List;Z)V", "GetWriteAll_Ljava_util_List_ZHandler")]
		public virtual unsafe void WriteAll (global::System.Collections.Generic.IList<string[]> allLines, bool applyQuotesToAll)
		{
			const string __id = "writeAll.(Ljava/util/List;Z)V";
			IntPtr native_allLines = global::Android.Runtime.JavaList<string[]>.ToLocalJniHandle (allLines);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_allLines);
				__args [1] = new JniArgumentValue (applyQuotesToAll);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_allLines);
				global::System.GC.KeepAlive (allLines);
			}
		}

		static Delegate cb_writeColumnNames_Ljava_sql_ResultSet_;
#pragma warning disable 0169
		static Delegate GetWriteColumnNames_Ljava_sql_ResultSet_Handler ()
		{
			if (cb_writeColumnNames_Ljava_sql_ResultSet_ == null)
				cb_writeColumnNames_Ljava_sql_ResultSet_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_WriteColumnNames_Ljava_sql_ResultSet_);
			return cb_writeColumnNames_Ljava_sql_ResultSet_;
		}

		static void n_WriteColumnNames_Ljava_sql_ResultSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rs = (global::Java.Sql.IResultSet)global::Java.Lang.Object.GetObject<global::Java.Sql.IResultSet> (native_rs, JniHandleOwnership.DoNotTransfer);
			__this.WriteColumnNames (rs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/method[@name='writeColumnNames' and count(parameter)=1 and parameter[1][@type='java.sql.ResultSet']]"
		[Register ("writeColumnNames", "(Ljava/sql/ResultSet;)V", "GetWriteColumnNames_Ljava_sql_ResultSet_Handler")]
		protected virtual unsafe void WriteColumnNames (global::Java.Sql.IResultSet rs)
		{
			const string __id = "writeColumnNames.(Ljava/sql/ResultSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rs).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (rs);
			}
		}

		static Delegate cb_writeNext_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWriteNext_arrayLjava_lang_String_Handler ()
		{
			if (cb_writeNext_arrayLjava_lang_String_ == null)
				cb_writeNext_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_WriteNext_arrayLjava_lang_String_);
			return cb_writeNext_arrayLjava_lang_String_;
		}

		static void n_WriteNext_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nextLine)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var nextLine = (string[]) JNIEnv.GetArray (native_nextLine, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.WriteNext (nextLine);
			if (nextLine != null)
				JNIEnv.CopyArray (nextLine, native_nextLine);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/method[@name='writeNext' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("writeNext", "([Ljava/lang/String;)V", "GetWriteNext_arrayLjava_lang_String_Handler")]
		public virtual unsafe void WriteNext (string[] nextLine)
		{
			const string __id = "writeNext.([Ljava/lang/String;)V";
			IntPtr native_nextLine = JNIEnv.NewArray (nextLine);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_nextLine);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (nextLine != null) {
					JNIEnv.CopyArray (native_nextLine, nextLine);
					JNIEnv.DeleteLocalRef (native_nextLine);
				}
				global::System.GC.KeepAlive (nextLine);
			}
		}

		static Delegate cb_writeNext_arrayLjava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetWriteNext_arrayLjava_lang_String_ZHandler ()
		{
			if (cb_writeNext_arrayLjava_lang_String_Z == null)
				cb_writeNext_arrayLjava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_WriteNext_arrayLjava_lang_String_Z);
			return cb_writeNext_arrayLjava_lang_String_Z;
		}

		static void n_WriteNext_arrayLjava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_nextLine, bool applyQuotesToAll)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var nextLine = (string[]) JNIEnv.GetArray (native_nextLine, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.WriteNext (nextLine, applyQuotesToAll);
			if (nextLine != null)
				JNIEnv.CopyArray (nextLine, native_nextLine);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVWriter']/method[@name='writeNext' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='boolean']]"
		[Register ("writeNext", "([Ljava/lang/String;Z)V", "GetWriteNext_arrayLjava_lang_String_ZHandler")]
		public virtual unsafe void WriteNext (string[] nextLine, bool applyQuotesToAll)
		{
			const string __id = "writeNext.([Ljava/lang/String;Z)V";
			IntPtr native_nextLine = JNIEnv.NewArray (nextLine);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_nextLine);
				__args [1] = new JniArgumentValue (applyQuotesToAll);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (nextLine != null) {
					JNIEnv.CopyArray (native_nextLine, nextLine);
					JNIEnv.DeleteLocalRef (native_nextLine);
				}
				global::System.GC.KeepAlive (nextLine);
			}
		}

	}
}
