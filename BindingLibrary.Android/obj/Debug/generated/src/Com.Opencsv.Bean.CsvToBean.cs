using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Opencsv.Bean {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.opencsv.bean']/class[@name='CsvToBean']"
	[global::Android.Runtime.Register ("com/opencsv/bean/CsvToBean", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class CsvToBean : global::Com.Opencsv.Bean.AbstractCSVToBean {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/opencsv/bean/CsvToBean", typeof (CsvToBean));

		internal static new IntPtr class_ref {
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

		protected CsvToBean (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv.bean']/class[@name='CsvToBean']/constructor[@name='CsvToBean' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CsvToBean () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_parse_Lcom_opencsv_bean_MappingStrategy_Lcom_opencsv_CSVReader_;
#pragma warning disable 0169
		static Delegate GetParse_Lcom_opencsv_bean_MappingStrategy_Lcom_opencsv_CSVReader_Handler ()
		{
			if (cb_parse_Lcom_opencsv_bean_MappingStrategy_Lcom_opencsv_CSVReader_ == null)
				cb_parse_Lcom_opencsv_bean_MappingStrategy_Lcom_opencsv_CSVReader_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Parse_Lcom_opencsv_bean_MappingStrategy_Lcom_opencsv_CSVReader_);
			return cb_parse_Lcom_opencsv_bean_MappingStrategy_Lcom_opencsv_CSVReader_;
		}

		static IntPtr n_Parse_Lcom_opencsv_bean_MappingStrategy_Lcom_opencsv_CSVReader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapper, IntPtr native_csv)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.CsvToBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mapper = (global::Com.Opencsv.Bean.IMappingStrategy)global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IMappingStrategy> (native_mapper, JniHandleOwnership.DoNotTransfer);
			var csv = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReader> (native_csv, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle (__this.Parse (mapper, csv));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='CsvToBean']/method[@name='parse' and count(parameter)=2 and parameter[1][@type='com.opencsv.bean.MappingStrategy&lt;T&gt;'] and parameter[2][@type='com.opencsv.CSVReader']]"
		[Register ("parse", "(Lcom/opencsv/bean/MappingStrategy;Lcom/opencsv/CSVReader;)Ljava/util/List;", "GetParse_Lcom_opencsv_bean_MappingStrategy_Lcom_opencsv_CSVReader_Handler")]
		public virtual unsafe global::System.Collections.IList Parse (global::Com.Opencsv.Bean.IMappingStrategy mapper, global::Com.Opencsv.CSVReader csv)
		{
			const string __id = "parse.(Lcom/opencsv/bean/MappingStrategy;Lcom/opencsv/CSVReader;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				__args [1] = new JniArgumentValue ((csv == null) ? IntPtr.Zero : ((global::Java.Lang.Object) csv).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (mapper);
				global::System.GC.KeepAlive (csv);
			}
		}

		static Delegate cb_parse_Lcom_opencsv_bean_MappingStrategy_Lcom_opencsv_CSVReader_Lcom_opencsv_bean_CsvToBeanFilter_;
#pragma warning disable 0169
		static Delegate GetParse_Lcom_opencsv_bean_MappingStrategy_Lcom_opencsv_CSVReader_Lcom_opencsv_bean_CsvToBeanFilter_Handler ()
		{
			if (cb_parse_Lcom_opencsv_bean_MappingStrategy_Lcom_opencsv_CSVReader_Lcom_opencsv_bean_CsvToBeanFilter_ == null)
				cb_parse_Lcom_opencsv_bean_MappingStrategy_Lcom_opencsv_CSVReader_Lcom_opencsv_bean_CsvToBeanFilter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Parse_Lcom_opencsv_bean_MappingStrategy_Lcom_opencsv_CSVReader_Lcom_opencsv_bean_CsvToBeanFilter_);
			return cb_parse_Lcom_opencsv_bean_MappingStrategy_Lcom_opencsv_CSVReader_Lcom_opencsv_bean_CsvToBeanFilter_;
		}

		static IntPtr n_Parse_Lcom_opencsv_bean_MappingStrategy_Lcom_opencsv_CSVReader_Lcom_opencsv_bean_CsvToBeanFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapper, IntPtr native_csv, IntPtr native_filter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.CsvToBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mapper = (global::Com.Opencsv.Bean.IMappingStrategy)global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IMappingStrategy> (native_mapper, JniHandleOwnership.DoNotTransfer);
			var csv = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReader> (native_csv, JniHandleOwnership.DoNotTransfer);
			var filter = (global::Com.Opencsv.Bean.ICsvToBeanFilter)global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.ICsvToBeanFilter> (native_filter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle (__this.Parse (mapper, csv, filter));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='CsvToBean']/method[@name='parse' and count(parameter)=3 and parameter[1][@type='com.opencsv.bean.MappingStrategy&lt;T&gt;'] and parameter[2][@type='com.opencsv.CSVReader'] and parameter[3][@type='com.opencsv.bean.CsvToBeanFilter']]"
		[Register ("parse", "(Lcom/opencsv/bean/MappingStrategy;Lcom/opencsv/CSVReader;Lcom/opencsv/bean/CsvToBeanFilter;)Ljava/util/List;", "GetParse_Lcom_opencsv_bean_MappingStrategy_Lcom_opencsv_CSVReader_Lcom_opencsv_bean_CsvToBeanFilter_Handler")]
		public virtual unsafe global::System.Collections.IList Parse (global::Com.Opencsv.Bean.IMappingStrategy mapper, global::Com.Opencsv.CSVReader csv, global::Com.Opencsv.Bean.ICsvToBeanFilter filter)
		{
			const string __id = "parse.(Lcom/opencsv/bean/MappingStrategy;Lcom/opencsv/CSVReader;Lcom/opencsv/bean/CsvToBeanFilter;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				__args [1] = new JniArgumentValue ((csv == null) ? IntPtr.Zero : ((global::Java.Lang.Object) csv).Handle);
				__args [2] = new JniArgumentValue ((filter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) filter).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (mapper);
				global::System.GC.KeepAlive (csv);
				global::System.GC.KeepAlive (filter);
			}
		}

		static Delegate cb_parse_Lcom_opencsv_bean_MappingStrategy_Ljava_io_Reader_;
#pragma warning disable 0169
		static Delegate GetParse_Lcom_opencsv_bean_MappingStrategy_Ljava_io_Reader_Handler ()
		{
			if (cb_parse_Lcom_opencsv_bean_MappingStrategy_Ljava_io_Reader_ == null)
				cb_parse_Lcom_opencsv_bean_MappingStrategy_Ljava_io_Reader_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Parse_Lcom_opencsv_bean_MappingStrategy_Ljava_io_Reader_);
			return cb_parse_Lcom_opencsv_bean_MappingStrategy_Ljava_io_Reader_;
		}

		static IntPtr n_Parse_Lcom_opencsv_bean_MappingStrategy_Ljava_io_Reader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapper, IntPtr native_reader)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.CsvToBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mapper = (global::Com.Opencsv.Bean.IMappingStrategy)global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IMappingStrategy> (native_mapper, JniHandleOwnership.DoNotTransfer);
			var reader = global::Java.Lang.Object.GetObject<global::Java.IO.Reader> (native_reader, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle (__this.Parse (mapper, reader));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='CsvToBean']/method[@name='parse' and count(parameter)=2 and parameter[1][@type='com.opencsv.bean.MappingStrategy&lt;T&gt;'] and parameter[2][@type='java.io.Reader']]"
		[Register ("parse", "(Lcom/opencsv/bean/MappingStrategy;Ljava/io/Reader;)Ljava/util/List;", "GetParse_Lcom_opencsv_bean_MappingStrategy_Ljava_io_Reader_Handler")]
		public virtual unsafe global::System.Collections.IList Parse (global::Com.Opencsv.Bean.IMappingStrategy mapper, global::Java.IO.Reader reader)
		{
			const string __id = "parse.(Lcom/opencsv/bean/MappingStrategy;Ljava/io/Reader;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				__args [1] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (mapper);
				global::System.GC.KeepAlive (reader);
			}
		}

		static Delegate cb_parse_Lcom_opencsv_bean_MappingStrategy_Ljava_io_Reader_Lcom_opencsv_bean_CsvToBeanFilter_;
#pragma warning disable 0169
		static Delegate GetParse_Lcom_opencsv_bean_MappingStrategy_Ljava_io_Reader_Lcom_opencsv_bean_CsvToBeanFilter_Handler ()
		{
			if (cb_parse_Lcom_opencsv_bean_MappingStrategy_Ljava_io_Reader_Lcom_opencsv_bean_CsvToBeanFilter_ == null)
				cb_parse_Lcom_opencsv_bean_MappingStrategy_Ljava_io_Reader_Lcom_opencsv_bean_CsvToBeanFilter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Parse_Lcom_opencsv_bean_MappingStrategy_Ljava_io_Reader_Lcom_opencsv_bean_CsvToBeanFilter_);
			return cb_parse_Lcom_opencsv_bean_MappingStrategy_Ljava_io_Reader_Lcom_opencsv_bean_CsvToBeanFilter_;
		}

		static IntPtr n_Parse_Lcom_opencsv_bean_MappingStrategy_Ljava_io_Reader_Lcom_opencsv_bean_CsvToBeanFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapper, IntPtr native_reader, IntPtr native_filter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.CsvToBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mapper = (global::Com.Opencsv.Bean.IMappingStrategy)global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IMappingStrategy> (native_mapper, JniHandleOwnership.DoNotTransfer);
			var reader = global::Java.Lang.Object.GetObject<global::Java.IO.Reader> (native_reader, JniHandleOwnership.DoNotTransfer);
			var filter = (global::Com.Opencsv.Bean.ICsvToBeanFilter)global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.ICsvToBeanFilter> (native_filter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle (__this.Parse (mapper, reader, filter));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='CsvToBean']/method[@name='parse' and count(parameter)=3 and parameter[1][@type='com.opencsv.bean.MappingStrategy&lt;T&gt;'] and parameter[2][@type='java.io.Reader'] and parameter[3][@type='com.opencsv.bean.CsvToBeanFilter']]"
		[Register ("parse", "(Lcom/opencsv/bean/MappingStrategy;Ljava/io/Reader;Lcom/opencsv/bean/CsvToBeanFilter;)Ljava/util/List;", "GetParse_Lcom_opencsv_bean_MappingStrategy_Ljava_io_Reader_Lcom_opencsv_bean_CsvToBeanFilter_Handler")]
		public virtual unsafe global::System.Collections.IList Parse (global::Com.Opencsv.Bean.IMappingStrategy mapper, global::Java.IO.Reader reader, global::Com.Opencsv.Bean.ICsvToBeanFilter filter)
		{
			const string __id = "parse.(Lcom/opencsv/bean/MappingStrategy;Ljava/io/Reader;Lcom/opencsv/bean/CsvToBeanFilter;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				__args [1] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [2] = new JniArgumentValue ((filter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) filter).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (mapper);
				global::System.GC.KeepAlive (reader);
				global::System.GC.KeepAlive (filter);
			}
		}

		static Delegate cb_processLine_Lcom_opencsv_bean_MappingStrategy_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetProcessLine_Lcom_opencsv_bean_MappingStrategy_arrayLjava_lang_String_Handler ()
		{
			if (cb_processLine_Lcom_opencsv_bean_MappingStrategy_arrayLjava_lang_String_ == null)
				cb_processLine_Lcom_opencsv_bean_MappingStrategy_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_ProcessLine_Lcom_opencsv_bean_MappingStrategy_arrayLjava_lang_String_);
			return cb_processLine_Lcom_opencsv_bean_MappingStrategy_arrayLjava_lang_String_;
		}

		static IntPtr n_ProcessLine_Lcom_opencsv_bean_MappingStrategy_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapper, IntPtr native_line)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.CsvToBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mapper = (global::Com.Opencsv.Bean.IMappingStrategy)global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IMappingStrategy> (native_mapper, JniHandleOwnership.DoNotTransfer);
			var line = (string[]) JNIEnv.GetArray (native_line, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ProcessLine (mapper, line));
			if (line != null)
				JNIEnv.CopyArray (line, native_line);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='CsvToBean']/method[@name='processLine' and count(parameter)=2 and parameter[1][@type='com.opencsv.bean.MappingStrategy&lt;T&gt;'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("processLine", "(Lcom/opencsv/bean/MappingStrategy;[Ljava/lang/String;)Ljava/lang/Object;", "GetProcessLine_Lcom_opencsv_bean_MappingStrategy_arrayLjava_lang_String_Handler")]
		protected virtual unsafe global::Java.Lang.Object ProcessLine (global::Com.Opencsv.Bean.IMappingStrategy mapper, string[] line)
		{
			const string __id = "processLine.(Lcom/opencsv/bean/MappingStrategy;[Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_line = JNIEnv.NewArray (line);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				__args [1] = new JniArgumentValue (native_line);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (line != null) {
					JNIEnv.CopyArray (native_line, line);
					JNIEnv.DeleteLocalRef (native_line);
				}
				global::System.GC.KeepAlive (mapper);
				global::System.GC.KeepAlive (line);
			}
		}

	}
}
