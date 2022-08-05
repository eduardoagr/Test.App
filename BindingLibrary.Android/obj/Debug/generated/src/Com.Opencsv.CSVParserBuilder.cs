using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Opencsv {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParserBuilder']"
	[global::Android.Runtime.Register ("com/opencsv/CSVParserBuilder", DoNotGenerateAcw=true)]
	public partial class CSVParserBuilder : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/opencsv/CSVParserBuilder", typeof (CSVParserBuilder));

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

		protected CSVParserBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParserBuilder']/constructor[@name='CSVParserBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CSVParserBuilder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getEscapeChar;
#pragma warning disable 0169
		static Delegate GetGetEscapeCharHandler ()
		{
			if (cb_getEscapeChar == null)
				cb_getEscapeChar = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_C) n_GetEscapeChar);
			return cb_getEscapeChar;
		}

		static char n_GetEscapeChar (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParserBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EscapeChar;
		}
#pragma warning restore 0169

		public virtual unsafe char EscapeChar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParserBuilder']/method[@name='getEscapeChar' and count(parameter)=0]"
			[Register ("getEscapeChar", "()C", "GetGetEscapeCharHandler")]
			get {
				const string __id = "getEscapeChar.()C";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParserBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIgnoreLeadingWhiteSpace;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsIgnoreLeadingWhiteSpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParserBuilder']/method[@name='isIgnoreLeadingWhiteSpace' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParserBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIgnoreQuotations;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsIgnoreQuotations {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParserBuilder']/method[@name='isIgnoreQuotations' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParserBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStrictQuotes;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsStrictQuotes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParserBuilder']/method[@name='isStrictQuotes' and count(parameter)=0]"
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

		static Delegate cb_getQuoteChar;
#pragma warning disable 0169
		static Delegate GetGetQuoteCharHandler ()
		{
			if (cb_getQuoteChar == null)
				cb_getQuoteChar = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_C) n_GetQuoteChar);
			return cb_getQuoteChar;
		}

		static char n_GetQuoteChar (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParserBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.QuoteChar;
		}
#pragma warning restore 0169

		public virtual unsafe char QuoteChar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParserBuilder']/method[@name='getQuoteChar' and count(parameter)=0]"
			[Register ("getQuoteChar", "()C", "GetGetQuoteCharHandler")]
			get {
				const string __id = "getQuoteChar.()C";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParserBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Separator;
		}
#pragma warning restore 0169

		public virtual unsafe char Separator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParserBuilder']/method[@name='getSeparator' and count(parameter)=0]"
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

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParserBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParserBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lcom/opencsv/CSVParser;", "GetBuildHandler")]
		public virtual unsafe global::Com.Opencsv.CSVParser Build ()
		{
			const string __id = "build.()Lcom/opencsv/CSVParser;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParser> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParserBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NullFieldIndicator ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParserBuilder']/method[@name='nullFieldIndicator' and count(parameter)=0]"
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

		static Delegate cb_withEscapeChar_C;
#pragma warning disable 0169
		static Delegate GetWithEscapeChar_CHandler ()
		{
			if (cb_withEscapeChar_C == null)
				cb_withEscapeChar_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPC_L) n_WithEscapeChar_C);
			return cb_withEscapeChar_C;
		}

		static IntPtr n_WithEscapeChar_C (IntPtr jnienv, IntPtr native__this, char escapeChar)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParserBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithEscapeChar (escapeChar));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParserBuilder']/method[@name='withEscapeChar' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("withEscapeChar", "(C)Lcom/opencsv/CSVParserBuilder;", "GetWithEscapeChar_CHandler")]
		public virtual unsafe global::Com.Opencsv.CSVParserBuilder WithEscapeChar (char escapeChar)
		{
			const string __id = "withEscapeChar.(C)Lcom/opencsv/CSVParserBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (escapeChar);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParserBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withFieldAsNull_Lcom_opencsv_enums_CSVReaderNullFieldIndicator_;
#pragma warning disable 0169
		static Delegate GetWithFieldAsNull_Lcom_opencsv_enums_CSVReaderNullFieldIndicator_Handler ()
		{
			if (cb_withFieldAsNull_Lcom_opencsv_enums_CSVReaderNullFieldIndicator_ == null)
				cb_withFieldAsNull_Lcom_opencsv_enums_CSVReaderNullFieldIndicator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithFieldAsNull_Lcom_opencsv_enums_CSVReaderNullFieldIndicator_);
			return cb_withFieldAsNull_Lcom_opencsv_enums_CSVReaderNullFieldIndicator_;
		}

		static IntPtr n_WithFieldAsNull_Lcom_opencsv_enums_CSVReaderNullFieldIndicator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldIndicator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParserBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fieldIndicator = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Enums.CSVReaderNullFieldIndicator> (native_fieldIndicator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithFieldAsNull (fieldIndicator));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParserBuilder']/method[@name='withFieldAsNull' and count(parameter)=1 and parameter[1][@type='com.opencsv.enums.CSVReaderNullFieldIndicator']]"
		[Register ("withFieldAsNull", "(Lcom/opencsv/enums/CSVReaderNullFieldIndicator;)Lcom/opencsv/CSVParserBuilder;", "GetWithFieldAsNull_Lcom_opencsv_enums_CSVReaderNullFieldIndicator_Handler")]
		public virtual unsafe global::Com.Opencsv.CSVParserBuilder WithFieldAsNull (global::Com.Opencsv.Enums.CSVReaderNullFieldIndicator fieldIndicator)
		{
			const string __id = "withFieldAsNull.(Lcom/opencsv/enums/CSVReaderNullFieldIndicator;)Lcom/opencsv/CSVParserBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fieldIndicator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fieldIndicator).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParserBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (fieldIndicator);
			}
		}

		static Delegate cb_withIgnoreLeadingWhiteSpace_Z;
#pragma warning disable 0169
		static Delegate GetWithIgnoreLeadingWhiteSpace_ZHandler ()
		{
			if (cb_withIgnoreLeadingWhiteSpace_Z == null)
				cb_withIgnoreLeadingWhiteSpace_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_WithIgnoreLeadingWhiteSpace_Z);
			return cb_withIgnoreLeadingWhiteSpace_Z;
		}

		static IntPtr n_WithIgnoreLeadingWhiteSpace_Z (IntPtr jnienv, IntPtr native__this, bool ignoreLeadingWhiteSpace)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParserBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithIgnoreLeadingWhiteSpace (ignoreLeadingWhiteSpace));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParserBuilder']/method[@name='withIgnoreLeadingWhiteSpace' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withIgnoreLeadingWhiteSpace", "(Z)Lcom/opencsv/CSVParserBuilder;", "GetWithIgnoreLeadingWhiteSpace_ZHandler")]
		public virtual unsafe global::Com.Opencsv.CSVParserBuilder WithIgnoreLeadingWhiteSpace (bool ignoreLeadingWhiteSpace)
		{
			const string __id = "withIgnoreLeadingWhiteSpace.(Z)Lcom/opencsv/CSVParserBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (ignoreLeadingWhiteSpace);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParserBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withIgnoreQuotations_Z;
#pragma warning disable 0169
		static Delegate GetWithIgnoreQuotations_ZHandler ()
		{
			if (cb_withIgnoreQuotations_Z == null)
				cb_withIgnoreQuotations_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_WithIgnoreQuotations_Z);
			return cb_withIgnoreQuotations_Z;
		}

		static IntPtr n_WithIgnoreQuotations_Z (IntPtr jnienv, IntPtr native__this, bool ignoreQuotations)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParserBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithIgnoreQuotations (ignoreQuotations));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParserBuilder']/method[@name='withIgnoreQuotations' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withIgnoreQuotations", "(Z)Lcom/opencsv/CSVParserBuilder;", "GetWithIgnoreQuotations_ZHandler")]
		public virtual unsafe global::Com.Opencsv.CSVParserBuilder WithIgnoreQuotations (bool ignoreQuotations)
		{
			const string __id = "withIgnoreQuotations.(Z)Lcom/opencsv/CSVParserBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (ignoreQuotations);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParserBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withQuoteChar_C;
#pragma warning disable 0169
		static Delegate GetWithQuoteChar_CHandler ()
		{
			if (cb_withQuoteChar_C == null)
				cb_withQuoteChar_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPC_L) n_WithQuoteChar_C);
			return cb_withQuoteChar_C;
		}

		static IntPtr n_WithQuoteChar_C (IntPtr jnienv, IntPtr native__this, char quoteChar)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParserBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithQuoteChar (quoteChar));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParserBuilder']/method[@name='withQuoteChar' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("withQuoteChar", "(C)Lcom/opencsv/CSVParserBuilder;", "GetWithQuoteChar_CHandler")]
		public virtual unsafe global::Com.Opencsv.CSVParserBuilder WithQuoteChar (char quoteChar)
		{
			const string __id = "withQuoteChar.(C)Lcom/opencsv/CSVParserBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (quoteChar);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParserBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withSeparator_C;
#pragma warning disable 0169
		static Delegate GetWithSeparator_CHandler ()
		{
			if (cb_withSeparator_C == null)
				cb_withSeparator_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPC_L) n_WithSeparator_C);
			return cb_withSeparator_C;
		}

		static IntPtr n_WithSeparator_C (IntPtr jnienv, IntPtr native__this, char separator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParserBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithSeparator (separator));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParserBuilder']/method[@name='withSeparator' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("withSeparator", "(C)Lcom/opencsv/CSVParserBuilder;", "GetWithSeparator_CHandler")]
		public virtual unsafe global::Com.Opencsv.CSVParserBuilder WithSeparator (char separator)
		{
			const string __id = "withSeparator.(C)Lcom/opencsv/CSVParserBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (separator);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParserBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withStrictQuotes_Z;
#pragma warning disable 0169
		static Delegate GetWithStrictQuotes_ZHandler ()
		{
			if (cb_withStrictQuotes_Z == null)
				cb_withStrictQuotes_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_WithStrictQuotes_Z);
			return cb_withStrictQuotes_Z;
		}

		static IntPtr n_WithStrictQuotes_Z (IntPtr jnienv, IntPtr native__this, bool strictQuotes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParserBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithStrictQuotes (strictQuotes));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVParserBuilder']/method[@name='withStrictQuotes' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withStrictQuotes", "(Z)Lcom/opencsv/CSVParserBuilder;", "GetWithStrictQuotes_ZHandler")]
		public virtual unsafe global::Com.Opencsv.CSVParserBuilder WithStrictQuotes (bool strictQuotes)
		{
			const string __id = "withStrictQuotes.(Z)Lcom/opencsv/CSVParserBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (strictQuotes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParserBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
