using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Opencsv {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']"
	[global::Android.Runtime.Register ("com/opencsv/CSVReader", DoNotGenerateAcw=true)]
	public partial class CSVReader : global::Java.Lang.Object, global::Java.IO.ICloseable, global::Java.Lang.IIterable {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/field[@name='DEFAULT_KEEP_CR']"
		[Register ("DEFAULT_KEEP_CR")]
		public const bool DefaultKeepCr = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/field[@name='DEFAULT_SKIP_LINES']"
		[Register ("DEFAULT_SKIP_LINES")]
		public const int DefaultSkipLines = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/field[@name='DEFAULT_VERIFY_READER']"
		[Register ("DEFAULT_VERIFY_READER")]
		public const bool DefaultVerifyReader = (bool) true;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/field[@name='READ_AHEAD_LIMIT']"
		[Register ("READ_AHEAD_LIMIT")]
		public const int ReadAheadLimit = (int) 2;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/opencsv/CSVReader", typeof (CSVReader));

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

		protected CSVReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/constructor[@name='CSVReader' and count(parameter)=1 and parameter[1][@type='java.io.Reader']]"
		[Register (".ctor", "(Ljava/io/Reader;)V", "")]
		public unsafe CSVReader (global::Java.IO.Reader reader) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Reader;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (reader);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/constructor[@name='CSVReader' and count(parameter)=2 and parameter[1][@type='java.io.Reader'] and parameter[2][@type='char']]"
		[Register (".ctor", "(Ljava/io/Reader;C)V", "")]
		public unsafe CSVReader (global::Java.IO.Reader reader, char separator) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Reader;C)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [1] = new JniArgumentValue (separator);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (reader);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/constructor[@name='CSVReader' and count(parameter)=3 and parameter[1][@type='java.io.Reader'] and parameter[2][@type='char'] and parameter[3][@type='char']]"
		[Register (".ctor", "(Ljava/io/Reader;CC)V", "")]
		public unsafe CSVReader (global::Java.IO.Reader reader, char separator, char quotechar) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Reader;CC)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [1] = new JniArgumentValue (separator);
				__args [2] = new JniArgumentValue (quotechar);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (reader);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/constructor[@name='CSVReader' and count(parameter)=4 and parameter[1][@type='java.io.Reader'] and parameter[2][@type='char'] and parameter[3][@type='char'] and parameter[4][@type='boolean']]"
		[Register (".ctor", "(Ljava/io/Reader;CCZ)V", "")]
		public unsafe CSVReader (global::Java.IO.Reader reader, char separator, char quotechar, bool strictQuotes) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Reader;CCZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [1] = new JniArgumentValue (separator);
				__args [2] = new JniArgumentValue (quotechar);
				__args [3] = new JniArgumentValue (strictQuotes);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (reader);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/constructor[@name='CSVReader' and count(parameter)=4 and parameter[1][@type='java.io.Reader'] and parameter[2][@type='char'] and parameter[3][@type='char'] and parameter[4][@type='char']]"
		[Register (".ctor", "(Ljava/io/Reader;CCC)V", "")]
		public unsafe CSVReader (global::Java.IO.Reader reader, char separator, char escape, char quotechar) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Reader;CCC)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [1] = new JniArgumentValue (separator);
				__args [2] = new JniArgumentValue (escape);
				__args [3] = new JniArgumentValue (quotechar);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (reader);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/constructor[@name='CSVReader' and count(parameter)=5 and parameter[1][@type='java.io.Reader'] and parameter[2][@type='char'] and parameter[3][@type='char'] and parameter[4][@type='char'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Ljava/io/Reader;CCCI)V", "")]
		public unsafe CSVReader (global::Java.IO.Reader reader, char separator, char escape, char quotechar, int line) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Reader;CCCI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [1] = new JniArgumentValue (separator);
				__args [2] = new JniArgumentValue (escape);
				__args [3] = new JniArgumentValue (quotechar);
				__args [4] = new JniArgumentValue (line);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (reader);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/constructor[@name='CSVReader' and count(parameter)=6 and parameter[1][@type='java.io.Reader'] and parameter[2][@type='char'] and parameter[3][@type='char'] and parameter[4][@type='char'] and parameter[5][@type='int'] and parameter[6][@type='boolean']]"
		[Register (".ctor", "(Ljava/io/Reader;CCCIZ)V", "")]
		public unsafe CSVReader (global::Java.IO.Reader reader, char separator, char escape, char quotechar, int line, bool strictQuotes) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Reader;CCCIZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [1] = new JniArgumentValue (separator);
				__args [2] = new JniArgumentValue (escape);
				__args [3] = new JniArgumentValue (quotechar);
				__args [4] = new JniArgumentValue (line);
				__args [5] = new JniArgumentValue (strictQuotes);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (reader);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/constructor[@name='CSVReader' and count(parameter)=7 and parameter[1][@type='java.io.Reader'] and parameter[2][@type='char'] and parameter[3][@type='char'] and parameter[4][@type='char'] and parameter[5][@type='int'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean']]"
		[Register (".ctor", "(Ljava/io/Reader;CCCIZZ)V", "")]
		public unsafe CSVReader (global::Java.IO.Reader reader, char separator, char escape, char quotechar, int line, bool strictQuotes, bool ignoreLeadingWhiteSpace) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Reader;CCCIZZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [1] = new JniArgumentValue (separator);
				__args [2] = new JniArgumentValue (escape);
				__args [3] = new JniArgumentValue (quotechar);
				__args [4] = new JniArgumentValue (line);
				__args [5] = new JniArgumentValue (strictQuotes);
				__args [6] = new JniArgumentValue (ignoreLeadingWhiteSpace);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (reader);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/constructor[@name='CSVReader' and count(parameter)=8 and parameter[1][@type='java.io.Reader'] and parameter[2][@type='char'] and parameter[3][@type='char'] and parameter[4][@type='char'] and parameter[5][@type='int'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean'] and parameter[8][@type='boolean']]"
		[Register (".ctor", "(Ljava/io/Reader;CCCIZZZ)V", "")]
		public unsafe CSVReader (global::Java.IO.Reader reader, char separator, char escape, char quotechar, int line, bool strictQuotes, bool keepCR, bool ignoreLeadingWhiteSpace) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Reader;CCCIZZZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [1] = new JniArgumentValue (separator);
				__args [2] = new JniArgumentValue (escape);
				__args [3] = new JniArgumentValue (quotechar);
				__args [4] = new JniArgumentValue (line);
				__args [5] = new JniArgumentValue (strictQuotes);
				__args [6] = new JniArgumentValue (keepCR);
				__args [7] = new JniArgumentValue (ignoreLeadingWhiteSpace);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (reader);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/constructor[@name='CSVReader' and count(parameter)=4 and parameter[1][@type='java.io.Reader'] and parameter[2][@type='char'] and parameter[3][@type='char'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Ljava/io/Reader;CCI)V", "")]
		public unsafe CSVReader (global::Java.IO.Reader reader, char separator, char quotechar, int line) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Reader;CCI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [1] = new JniArgumentValue (separator);
				__args [2] = new JniArgumentValue (quotechar);
				__args [3] = new JniArgumentValue (line);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (reader);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/constructor[@name='CSVReader' and count(parameter)=3 and parameter[1][@type='java.io.Reader'] and parameter[2][@type='int'] and parameter[3][@type='com.opencsv.CSVParser']]"
		[Register (".ctor", "(Ljava/io/Reader;ILcom/opencsv/CSVParser;)V", "")]
		public unsafe CSVReader (global::Java.IO.Reader reader, int line, global::Com.Opencsv.CSVParser csvParser) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Reader;ILcom/opencsv/CSVParser;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [1] = new JniArgumentValue (line);
				__args [2] = new JniArgumentValue ((csvParser == null) ? IntPtr.Zero : ((global::Java.Lang.Object) csvParser).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (reader);
				global::System.GC.KeepAlive (csvParser);
			}
		}

		static Delegate cb_getLinesRead;
#pragma warning disable 0169
		static Delegate GetGetLinesReadHandler ()
		{
			if (cb_getLinesRead == null)
				cb_getLinesRead = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetLinesRead);
			return cb_getLinesRead;
		}

		static long n_GetLinesRead (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LinesRead;
		}
#pragma warning restore 0169

		public virtual unsafe long LinesRead {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/method[@name='getLinesRead' and count(parameter)=0]"
			[Register ("getLinesRead", "()J", "GetGetLinesReadHandler")]
			get {
				const string __id = "getLinesRead.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getParser;
#pragma warning disable 0169
		static Delegate GetGetParserHandler ()
		{
			if (cb_getParser == null)
				cb_getParser = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetParser);
			return cb_getParser;
		}

		static IntPtr n_GetParser (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Parser);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Opencsv.CSVParser Parser {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/method[@name='getParser' and count(parameter)=0]"
			[Register ("getParser", "()Lcom/opencsv/CSVParser;", "GetGetParserHandler")]
			get {
				const string __id = "getParser.()Lcom/opencsv/CSVParser;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParser> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRecordsRead;
#pragma warning disable 0169
		static Delegate GetGetRecordsReadHandler ()
		{
			if (cb_getRecordsRead == null)
				cb_getRecordsRead = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetRecordsRead);
			return cb_getRecordsRead;
		}

		static long n_GetRecordsRead (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RecordsRead;
		}
#pragma warning restore 0169

		public virtual unsafe long RecordsRead {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/method[@name='getRecordsRead' and count(parameter)=0]"
			[Register ("getRecordsRead", "()J", "GetGetRecordsReadHandler")]
			get {
				const string __id = "getRecordsRead.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSkipLines;
#pragma warning disable 0169
		static Delegate GetGetSkipLinesHandler ()
		{
			if (cb_getSkipLines == null)
				cb_getSkipLines = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSkipLines);
			return cb_getSkipLines;
		}

		static int n_GetSkipLines (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SkipLines;
		}
#pragma warning restore 0169

		public virtual unsafe int SkipLines {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/method[@name='getSkipLines' and count(parameter)=0]"
			[Register ("getSkipLines", "()I", "GetGetSkipLinesHandler")]
			get {
				const string __id = "getSkipLines.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public virtual unsafe global::Java.Util.IIterator Iterator ()
		{
			const string __id = "iterator.()Ljava/util/Iterator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_keepCarriageReturns;
#pragma warning disable 0169
		static Delegate GetKeepCarriageReturnsHandler ()
		{
			if (cb_keepCarriageReturns == null)
				cb_keepCarriageReturns = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_KeepCarriageReturns);
			return cb_keepCarriageReturns;
		}

		static bool n_KeepCarriageReturns (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KeepCarriageReturns ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/method[@name='keepCarriageReturns' and count(parameter)=0]"
		[Register ("keepCarriageReturns", "()Z", "GetKeepCarriageReturnsHandler")]
		public virtual unsafe bool KeepCarriageReturns ()
		{
			const string __id = "keepCarriageReturns.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_readAll;
#pragma warning disable 0169
		static Delegate GetReadAllHandler ()
		{
			if (cb_readAll == null)
				cb_readAll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ReadAll);
			return cb_readAll;
		}

		static IntPtr n_ReadAll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string[]>.ToLocalJniHandle (__this.ReadAll ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/method[@name='readAll' and count(parameter)=0]"
		[Register ("readAll", "()Ljava/util/List;", "GetReadAllHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<string[]> ReadAll ()
		{
			const string __id = "readAll.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string[]>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readNext;
#pragma warning disable 0169
		static Delegate GetReadNextHandler ()
		{
			if (cb_readNext == null)
				cb_readNext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ReadNext);
			return cb_readNext;
		}

		static IntPtr n_ReadNext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ReadNext ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/method[@name='readNext' and count(parameter)=0]"
		[Register ("readNext", "()[Ljava/lang/String;", "GetReadNextHandler")]
		public virtual unsafe string[] ReadNext ()
		{
			const string __id = "readNext.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_verifyReader;
#pragma warning disable 0169
		static Delegate GetVerifyReaderHandler ()
		{
			if (cb_verifyReader == null)
				cb_verifyReader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_VerifyReader);
			return cb_verifyReader;
		}

		static bool n_VerifyReader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VerifyReader ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReader']/method[@name='verifyReader' and count(parameter)=0]"
		[Register ("verifyReader", "()Z", "GetVerifyReaderHandler")]
		public virtual unsafe bool VerifyReader ()
		{
			const string __id = "verifyReader.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
