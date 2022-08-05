using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Opencsv {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReaderBuilder']"
	[global::Android.Runtime.Register ("com/opencsv/CSVReaderBuilder", DoNotGenerateAcw=true)]
	public partial class CSVReaderBuilder : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/opencsv/CSVReaderBuilder", typeof (CSVReaderBuilder));

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

		protected CSVReaderBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReaderBuilder']/constructor[@name='CSVReaderBuilder' and count(parameter)=1 and parameter[1][@type='java.io.Reader']]"
		[Register (".ctor", "(Ljava/io/Reader;)V", "")]
		public unsafe CSVReaderBuilder (global::Java.IO.Reader reader) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getCsvParser;
#pragma warning disable 0169
		static Delegate GetGetCsvParserHandler ()
		{
			if (cb_getCsvParser == null)
				cb_getCsvParser = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCsvParser);
			return cb_getCsvParser;
		}

		static IntPtr n_GetCsvParser (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CsvParser);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Com.Opencsv.CSVParser CsvParser {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReaderBuilder']/method[@name='getCsvParser' and count(parameter)=0]"
			[Register ("getCsvParser", "()Lcom/opencsv/CSVParser;", "GetGetCsvParserHandler")]
			get {
				const string __id = "getCsvParser.()Lcom/opencsv/CSVParser;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParser> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getReader;
#pragma warning disable 0169
		static Delegate GetGetReaderHandler ()
		{
			if (cb_getReader == null)
				cb_getReader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetReader);
			return cb_getReader;
		}

		static IntPtr n_GetReader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Reader);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Java.IO.Reader Reader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReaderBuilder']/method[@name='getReader' and count(parameter)=0]"
			[Register ("getReader", "()Ljava/io/Reader;", "GetGetReaderHandler")]
			get {
				const string __id = "getReader.()Ljava/io/Reader;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.Reader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SkipLines;
		}
#pragma warning restore 0169

		protected virtual unsafe int SkipLines {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReaderBuilder']/method[@name='getSkipLines' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReaderBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lcom/opencsv/CSVReader;", "GetBuildHandler")]
		public virtual unsafe global::Com.Opencsv.CSVReader Build ()
		{
			const string __id = "build.()Lcom/opencsv/CSVReader;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_keepCarriageReturn;
#pragma warning disable 0169
		static Delegate GetKeepCarriageReturnHandler ()
		{
			if (cb_keepCarriageReturn == null)
				cb_keepCarriageReturn = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_KeepCarriageReturn);
			return cb_keepCarriageReturn;
		}

		static bool n_KeepCarriageReturn (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KeepCarriageReturn ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReaderBuilder']/method[@name='keepCarriageReturn' and count(parameter)=0]"
		[Register ("keepCarriageReturn", "()Z", "GetKeepCarriageReturnHandler")]
		protected virtual unsafe bool KeepCarriageReturn ()
		{
			const string __id = "keepCarriageReturn.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_withCSVParser_Lcom_opencsv_CSVParser_;
#pragma warning disable 0169
		static Delegate GetWithCSVParser_Lcom_opencsv_CSVParser_Handler ()
		{
			if (cb_withCSVParser_Lcom_opencsv_CSVParser_ == null)
				cb_withCSVParser_Lcom_opencsv_CSVParser_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithCSVParser_Lcom_opencsv_CSVParser_);
			return cb_withCSVParser_Lcom_opencsv_CSVParser_;
		}

		static IntPtr n_WithCSVParser_Lcom_opencsv_CSVParser_ (IntPtr jnienv, IntPtr native__this, IntPtr native_csvParser)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var csvParser = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVParser> (native_csvParser, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithCSVParser (csvParser));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReaderBuilder']/method[@name='withCSVParser' and count(parameter)=1 and parameter[1][@type='com.opencsv.CSVParser']]"
		[Register ("withCSVParser", "(Lcom/opencsv/CSVParser;)Lcom/opencsv/CSVReaderBuilder;", "GetWithCSVParser_Lcom_opencsv_CSVParser_Handler")]
		public virtual unsafe global::Com.Opencsv.CSVReaderBuilder WithCSVParser (global::Com.Opencsv.CSVParser csvParser)
		{
			const string __id = "withCSVParser.(Lcom/opencsv/CSVParser;)Lcom/opencsv/CSVReaderBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((csvParser == null) ? IntPtr.Zero : ((global::Java.Lang.Object) csvParser).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReaderBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (csvParser);
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

		static IntPtr n_WithFieldAsNull_Lcom_opencsv_enums_CSVReaderNullFieldIndicator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_indicator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var indicator = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Enums.CSVReaderNullFieldIndicator> (native_indicator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithFieldAsNull (indicator));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReaderBuilder']/method[@name='withFieldAsNull' and count(parameter)=1 and parameter[1][@type='com.opencsv.enums.CSVReaderNullFieldIndicator']]"
		[Register ("withFieldAsNull", "(Lcom/opencsv/enums/CSVReaderNullFieldIndicator;)Lcom/opencsv/CSVReaderBuilder;", "GetWithFieldAsNull_Lcom_opencsv_enums_CSVReaderNullFieldIndicator_Handler")]
		public virtual unsafe global::Com.Opencsv.CSVReaderBuilder WithFieldAsNull (global::Com.Opencsv.Enums.CSVReaderNullFieldIndicator indicator)
		{
			const string __id = "withFieldAsNull.(Lcom/opencsv/enums/CSVReaderNullFieldIndicator;)Lcom/opencsv/CSVReaderBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((indicator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) indicator).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReaderBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (indicator);
			}
		}

		static Delegate cb_withKeepCarriageReturn_Z;
#pragma warning disable 0169
		static Delegate GetWithKeepCarriageReturn_ZHandler ()
		{
			if (cb_withKeepCarriageReturn_Z == null)
				cb_withKeepCarriageReturn_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_WithKeepCarriageReturn_Z);
			return cb_withKeepCarriageReturn_Z;
		}

		static IntPtr n_WithKeepCarriageReturn_Z (IntPtr jnienv, IntPtr native__this, bool keepCR)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithKeepCarriageReturn (keepCR));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReaderBuilder']/method[@name='withKeepCarriageReturn' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withKeepCarriageReturn", "(Z)Lcom/opencsv/CSVReaderBuilder;", "GetWithKeepCarriageReturn_ZHandler")]
		public virtual unsafe global::Com.Opencsv.CSVReaderBuilder WithKeepCarriageReturn (bool keepCR)
		{
			const string __id = "withKeepCarriageReturn.(Z)Lcom/opencsv/CSVReaderBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (keepCR);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReaderBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withSkipLines_I;
#pragma warning disable 0169
		static Delegate GetWithSkipLines_IHandler ()
		{
			if (cb_withSkipLines_I == null)
				cb_withSkipLines_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_WithSkipLines_I);
			return cb_withSkipLines_I;
		}

		static IntPtr n_WithSkipLines_I (IntPtr jnienv, IntPtr native__this, int skipLines)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithSkipLines (skipLines));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReaderBuilder']/method[@name='withSkipLines' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withSkipLines", "(I)Lcom/opencsv/CSVReaderBuilder;", "GetWithSkipLines_IHandler")]
		public virtual unsafe global::Com.Opencsv.CSVReaderBuilder WithSkipLines (int skipLines)
		{
			const string __id = "withSkipLines.(I)Lcom/opencsv/CSVReaderBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (skipLines);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReaderBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withVerifyReader_Z;
#pragma warning disable 0169
		static Delegate GetWithVerifyReader_ZHandler ()
		{
			if (cb_withVerifyReader_Z == null)
				cb_withVerifyReader_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_WithVerifyReader_Z);
			return cb_withVerifyReader_Z;
		}

		static IntPtr n_WithVerifyReader_Z (IntPtr jnienv, IntPtr native__this, bool verifyReader)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithVerifyReader (verifyReader));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv']/class[@name='CSVReaderBuilder']/method[@name='withVerifyReader' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withVerifyReader", "(Z)Lcom/opencsv/CSVReaderBuilder;", "GetWithVerifyReader_ZHandler")]
		public virtual unsafe global::Com.Opencsv.CSVReaderBuilder WithVerifyReader (bool verifyReader)
		{
			const string __id = "withVerifyReader.(Z)Lcom/opencsv/CSVReaderBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (verifyReader);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReaderBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
