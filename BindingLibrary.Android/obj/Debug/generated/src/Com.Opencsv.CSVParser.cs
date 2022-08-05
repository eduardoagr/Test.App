using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Opencsv {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']"
	[global::Android.Runtime.Register ("com/opencsv/CSVParser", DoNotGenerateAcw=true)]
	public partial class CSVParser : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/field[@name='DEFAULT_ESCAPE_CHARACTER']"
		[Register ("DEFAULT_ESCAPE_CHARACTER")]
		public const char DefaultEscapeCharacter = (char) (char)92;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/field[@name='DEFAULT_IGNORE_LEADING_WHITESPACE']"
		[Register ("DEFAULT_IGNORE_LEADING_WHITESPACE")]
		public const bool DefaultIgnoreLeadingWhitespace = (bool) true;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/field[@name='DEFAULT_IGNORE_QUOTATIONS']"
		[Register ("DEFAULT_IGNORE_QUOTATIONS")]
		public const bool DefaultIgnoreQuotations = (bool) false;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/field[@name='DEFAULT_NULL_FIELD_INDICATOR']"
		[Register ("DEFAULT_NULL_FIELD_INDICATOR")]
		public static global::Com.Opencsv.Enums.CSVReaderNullFieldIndicator DefaultNullFieldIndicator {
			get {
				const string __id = "DEFAULT_NULL_FIELD_INDICATOR.Lcom/opencsv/enums/CSVReaderNullFieldIndicator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.Enums.CSVReaderNullFieldIndicator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/field[@name='DEFAULT_QUOTE_CHARACTER']"
		[Register ("DEFAULT_QUOTE_CHARACTER")]
		public const char DefaultQuoteCharacter = (char) (char)34;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/field[@name='DEFAULT_SEPARATOR']"
		[Register ("DEFAULT_SEPARATOR")]
		public const char DefaultSeparator = (char) (char)44;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/field[@name='DEFAULT_STRICT_QUOTES']"
		[Register ("DEFAULT_STRICT_QUOTES")]
		public const bool DefaultStrictQuotes = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/field[@name='INITIAL_READ_SIZE']"
		[Register ("INITIAL_READ_SIZE")]
		public const int InitialReadSize = (int) 1024;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/field[@name='NULL_CHARACTER']"
		[Register ("NULL_CHARACTER")]
		public const char NullCharacter = (char) (char)0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/field[@name='READ_BUFFER_SIZE']"
		[Register ("READ_BUFFER_SIZE")]
		public const int ReadBufferSize = (int) 128;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/opencsv/CSVParser", typeof (CSVParser));

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

		protected CSVParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/constructor[@name='CSVParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CSVParser () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/constructor[@name='CSVParser' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register (".ctor", "(C)V", "")]
		public unsafe CSVParser (char separator) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(C)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (separator);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/constructor[@name='CSVParser' and count(parameter)=2 and parameter[1][@type='char'] and parameter[2][@type='char']]"
		[Register (".ctor", "(CC)V", "")]
		public unsafe CSVParser (char quotechar, char separator) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(CC)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (quotechar);
				__args [1] = new JniArgumentValue (separator);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/constructor[@name='CSVParser' and count(parameter)=3 and parameter[1][@type='char'] and parameter[2][@type='char'] and parameter[3][@type='char']]"
		[Register (".ctor", "(CCC)V", "")]
		public unsafe CSVParser (char quotechar, char separator, char escape) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(CCC)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (quotechar);
				__args [1] = new JniArgumentValue (separator);
				__args [2] = new JniArgumentValue (escape);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/constructor[@name='CSVParser' and count(parameter)=4 and parameter[1][@type='char'] and parameter[2][@type='char'] and parameter[3][@type='char'] and parameter[4][@type='boolean']]"
		[Register (".ctor", "(CCCZ)V", "")]
		public unsafe CSVParser (char quotechar, char separator, char escape, bool strictQuotes) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(CCCZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (quotechar);
				__args [1] = new JniArgumentValue (separator);
				__args [2] = new JniArgumentValue (escape);
				__args [3] = new JniArgumentValue (strictQuotes);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/constructor[@name='CSVParser' and count(parameter)=5 and parameter[1][@type='char'] and parameter[2][@type='char'] and parameter[3][@type='char'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
		[Register (".ctor", "(CCCZZ)V", "")]
		public unsafe CSVParser (char quotechar, char separator, char escape, bool strictQuotes, bool ignoreLeadingWhiteSpace) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(CCCZZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (quotechar);
				__args [1] = new JniArgumentValue (separator);
				__args [2] = new JniArgumentValue (escape);
				__args [3] = new JniArgumentValue (strictQuotes);
				__args [4] = new JniArgumentValue (ignoreLeadingWhiteSpace);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/constructor[@name='CSVParser' and count(parameter)=6 and parameter[1][@type='char'] and parameter[2][@type='char'] and parameter[3][@type='char'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean']]"
		[Register (".ctor", "(CCCZZZ)V", "")]
		public unsafe CSVParser (char quotechar, char separator, char escape, bool ignoreQuotations, bool strictQuotes, bool ignoreLeadingWhiteSpace) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(CCCZZZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (quotechar);
				__args [1] = new JniArgumentValue (separator);
				__args [2] = new JniArgumentValue (escape);
				__args [3] = new JniArgumentValue (ignoreQuotations);
				__args [4] = new JniArgumentValue (strictQuotes);
				__args [5] = new JniArgumentValue (ignoreLeadingWhiteSpace);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getEscape;
#pragma warning disable 0169
		static Delegate GetGetEscapeHandler ()
		{
			if (cb_getEscape == null)
				cb_getEscape = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_C) n_GetEscape);
			return cb_getEscape;
		}

		static char n_GetEscape (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Escape;
		}
#pragma warning restore 0169

		public virtual unsafe char Escape {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/method[@name='getEscape' and count(parameter)=0]"
			[Register ("getEscape", "()C", "GetGetEscapeHandler")]
			get {
				const string __id = "getEscape.()C";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualCharMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isIgnoreLeadingWhiteSpace;
#pragma warning disable 0169
		static Delegate GetIsIgnoreLeadingWhiteSpaceHandler ()
		{
			if (cb_isIgnoreLeadingWhiteSpace == null)
				cb_isIgnoreLeadingWhiteSpace = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsIgnoreLeadingWhiteSpace);
			return cb_isIgnoreLeadingWhiteSpace;
		}

		static bool n_IsIgnoreLeadingWhiteSpace (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIgnoreLeadingWhiteSpace;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsIgnoreLeadingWhiteSpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/method[@name='isIgnoreLeadingWhiteSpace' and count(parameter)=0]"
			[Register ("isIgnoreLeadingWhiteSpace", "()Z", "GetIsIgnoreLeadingWhiteSpaceHandler")]
			get {
				const string __id = "isIgnoreLeadingWhiteSpace.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isIgnoreQuotations;
#pragma warning disable 0169
		static Delegate GetIsIgnoreQuotationsHandler ()
		{
			if (cb_isIgnoreQuotations == null)
				cb_isIgnoreQuotations = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsIgnoreQuotations);
			return cb_isIgnoreQuotations;
		}

		static bool n_IsIgnoreQuotations (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIgnoreQuotations;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsIgnoreQuotations {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/method[@name='isIgnoreQuotations' and count(parameter)=0]"
			[Register ("isIgnoreQuotations", "()Z", "GetIsIgnoreQuotationsHandler")]
			get {
				const string __id = "isIgnoreQuotations.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isPending;
#pragma warning disable 0169
		static Delegate GetIsPendingHandler ()
		{
			if (cb_isPending == null)
				cb_isPending = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPending);
			return cb_isPending;
		}

		static bool n_IsPending (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPending;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsPending {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/method[@name='isPending' and count(parameter)=0]"
			[Register ("isPending", "()Z", "GetIsPendingHandler")]
			get {
				const string __id = "isPending.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isStrictQuotes;
#pragma warning disable 0169
		static Delegate GetIsStrictQuotesHandler ()
		{
			if (cb_isStrictQuotes == null)
				cb_isStrictQuotes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsStrictQuotes);
			return cb_isStrictQuotes;
		}

		static bool n_IsStrictQuotes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStrictQuotes;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsStrictQuotes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/method[@name='isStrictQuotes' and count(parameter)=0]"
			[Register ("isStrictQuotes", "()Z", "GetIsStrictQuotesHandler")]
			get {
				const string __id = "isStrictQuotes.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getQuotechar;
#pragma warning disable 0169
		static Delegate GetGetQuotecharHandler ()
		{
			if (cb_getQuotechar == null)
				cb_getQuotechar = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_C) n_GetQuotechar);
			return cb_getQuotechar;
		}

		static char n_GetQuotechar (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Quotechar;
		}
#pragma warning restore 0169

		public virtual unsafe char Quotechar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/method[@name='getQuotechar' and count(parameter)=0]"
			[Register ("getQuotechar", "()C", "GetGetQuotecharHandler")]
			get {
				const string __id = "getQuotechar.()C";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualCharMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSeparator;
#pragma warning disable 0169
		static Delegate GetGetSeparatorHandler ()
		{
			if (cb_getSeparator == null)
				cb_getSeparator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_C) n_GetSeparator);
			return cb_getSeparator;
		}

		static char n_GetSeparator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Separator;
		}
#pragma warning restore 0169

		public virtual unsafe char Separator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/method[@name='getSeparator' and count(parameter)=0]"
			[Register ("getSeparator", "()C", "GetGetSeparatorHandler")]
			get {
				const string __id = "getSeparator.()C";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualCharMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isAllWhiteSpace_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetIsAllWhiteSpace_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_isAllWhiteSpace_Ljava_lang_CharSequence_ == null)
				cb_isAllWhiteSpace_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsAllWhiteSpace_Ljava_lang_CharSequence_);
			return cb_isAllWhiteSpace_Ljava_lang_CharSequence_;
		}

		static bool n_IsAllWhiteSpace_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sb)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var sb = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_sb, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsAllWhiteSpace (sb);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/method[@name='isAllWhiteSpace' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("isAllWhiteSpace", "(Ljava/lang/CharSequence;)Z", "GetIsAllWhiteSpace_Ljava_lang_CharSequence_Handler")]
		protected virtual unsafe bool IsAllWhiteSpace (global::Java.Lang.ICharSequence sb)
		{
			const string __id = "isAllWhiteSpace.(Ljava/lang/CharSequence;)Z";
			IntPtr native_sb = CharSequence.ToLocalJniHandle (sb);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sb);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_sb);
				global::System.GC.KeepAlive (sb);
			}
		}

		protected bool IsAllWhiteSpace (string sb)
		{
			var jls_sb = sb == null ? null : new global::Java.Lang.String (sb);
			bool __result = IsAllWhiteSpace (jls_sb);
			var __rsval = __result;
			jls_sb?.Dispose ();
			return __rsval;
		}

		static Delegate cb_isNextCharacterEscapable_Ljava_lang_String_ZI;
#pragma warning disable 0169
		static Delegate GetIsNextCharacterEscapable_Ljava_lang_String_ZIHandler ()
		{
			if (cb_isNextCharacterEscapable_Ljava_lang_String_ZI == null)
				cb_isNextCharacterEscapable_Ljava_lang_String_ZI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZI_Z) n_IsNextCharacterEscapable_Ljava_lang_String_ZI);
			return cb_isNextCharacterEscapable_Ljava_lang_String_ZI;
		}

		static bool n_IsNextCharacterEscapable_Ljava_lang_String_ZI (IntPtr jnienv, IntPtr native__this, IntPtr native_nextLine, bool inQuotes, int i)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var nextLine = JNIEnv.GetString (native_nextLine, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsNextCharacterEscapable (nextLine, inQuotes, i);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/method[@name='isNextCharacterEscapable' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='int']]"
		[Register ("isNextCharacterEscapable", "(Ljava/lang/String;ZI)Z", "GetIsNextCharacterEscapable_Ljava_lang_String_ZIHandler")]
		protected virtual unsafe bool IsNextCharacterEscapable (string nextLine, bool inQuotes, int i)
		{
			const string __id = "isNextCharacterEscapable.(Ljava/lang/String;ZI)Z";
			IntPtr native_nextLine = JNIEnv.NewString (nextLine);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_nextLine);
				__args [1] = new JniArgumentValue (inQuotes);
				__args [2] = new JniArgumentValue (i);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_nextLine);
			}
		}

		static Delegate cb_nullFieldIndicator;
#pragma warning disable 0169
		static Delegate GetNullFieldIndicatorHandler ()
		{
			if (cb_nullFieldIndicator == null)
				cb_nullFieldIndicator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NullFieldIndicator);
			return cb_nullFieldIndicator;
		}

		static IntPtr n_NullFieldIndicator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NullFieldIndicator ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/method[@name='nullFieldIndicator' and count(parameter)=0]"
		[Register ("nullFieldIndicator", "()Lcom/opencsv/enums/CSVReaderNullFieldIndicator;", "GetNullFieldIndicatorHandler")]
		public virtual unsafe global::Com.Opencsv.Enums.CSVReaderNullFieldIndicator NullFieldIndicator ()
		{
			const string __id = "nullFieldIndicator.()Lcom/opencsv/enums/CSVReaderNullFieldIndicator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.Enums.CSVReaderNullFieldIndicator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_parseLine_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetParseLine_Ljava_lang_String_Handler ()
		{
			if (cb_parseLine_Ljava_lang_String_ == null)
				cb_parseLine_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ParseLine_Ljava_lang_String_);
			return cb_parseLine_Ljava_lang_String_;
		}

		static IntPtr n_ParseLine_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nextLine)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var nextLine = JNIEnv.GetString (native_nextLine, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.ParseLine (nextLine));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/method[@name='parseLine' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseLine", "(Ljava/lang/String;)[Ljava/lang/String;", "GetParseLine_Ljava_lang_String_Handler")]
		public virtual unsafe string[] ParseLine (string nextLine)
		{
			const string __id = "parseLine.(Ljava/lang/String;)[Ljava/lang/String;";
			IntPtr native_nextLine = JNIEnv.NewString (nextLine);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_nextLine);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				JNIEnv.DeleteLocalRef (native_nextLine);
			}
		}

		static Delegate cb_parseLineMulti_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetParseLineMulti_Ljava_lang_String_Handler ()
		{
			if (cb_parseLineMulti_Ljava_lang_String_ == null)
				cb_parseLineMulti_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ParseLineMulti_Ljava_lang_String_);
			return cb_parseLineMulti_Ljava_lang_String_;
		}

		static IntPtr n_ParseLineMulti_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nextLine)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var nextLine = JNIEnv.GetString (native_nextLine, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.ParseLineMulti (nextLine));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParser']/method[@name='parseLineMulti' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseLineMulti", "(Ljava/lang/String;)[Ljava/lang/String;", "GetParseLineMulti_Ljava_lang_String_Handler")]
		public virtual unsafe string[] ParseLineMulti (string nextLine)
		{
			const string __id = "parseLineMulti.(Ljava/lang/String;)[Ljava/lang/String;";
			IntPtr native_nextLine = JNIEnv.NewString (nextLine);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_nextLine);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				JNIEnv.DeleteLocalRef (native_nextLine);
			}
		}

	}
}
