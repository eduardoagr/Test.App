using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Opencsv.Bean {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.opencsv.bean']/class[@name='IterableCSVToBeanBuilder']"
	[global::Android.Runtime.Register ("com/opencsv/bean/IterableCSVToBeanBuilder", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class IterableCSVToBeanBuilder : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv.bean']/class[@name='IterableCSVToBeanBuilder']/field[@name='NO_MAPPING_STRATEGY_DEFINED']"
		[Register ("NO_MAPPING_STRATEGY_DEFINED")]
		public const string NoMappingStrategyDefined = (string) "Unable to instantiate IterableCSVToBeanBuilder because there is no MappingStrategy defined.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv.bean']/class[@name='IterableCSVToBeanBuilder']/field[@name='NO_READER_DEFINED']"
		[Register ("NO_READER_DEFINED")]
		public const string NoReaderDefined = (string) "Unable to instantiate IterableCSVToBeanBuilder because there is no CSVReader defined.";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/opencsv/bean/IterableCSVToBeanBuilder", typeof (IterableCSVToBeanBuilder));

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

		protected IterableCSVToBeanBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv.bean']/class[@name='IterableCSVToBeanBuilder']/constructor[@name='IterableCSVToBeanBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IterableCSVToBeanBuilder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getCsvReader;
#pragma warning disable 0169
		static Delegate GetGetCsvReaderHandler ()
		{
			if (cb_getCsvReader == null)
				cb_getCsvReader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCsvReader);
			return cb_getCsvReader;
		}

		static IntPtr n_GetCsvReader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IterableCSVToBeanBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CsvReader);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Com.Opencsv.CSVReader CsvReader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='IterableCSVToBeanBuilder']/method[@name='getCsvReader' and count(parameter)=0]"
			[Register ("getCsvReader", "()Lcom/opencsv/CSVReader;", "GetGetCsvReaderHandler")]
			get {
				const string __id = "getCsvReader.()Lcom/opencsv/CSVReader;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFilter;
#pragma warning disable 0169
		static Delegate GetGetFilterHandler ()
		{
			if (cb_getFilter == null)
				cb_getFilter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFilter);
			return cb_getFilter;
		}

		static IntPtr n_GetFilter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IterableCSVToBeanBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Filter);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Java.Lang.Object Filter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='IterableCSVToBeanBuilder']/method[@name='getFilter' and count(parameter)=0]"
			[Register ("getFilter", "()Ljava/lang/Object;", "GetGetFilterHandler")]
			get {
				const string __id = "getFilter.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStrategy;
#pragma warning disable 0169
		static Delegate GetGetStrategyHandler ()
		{
			if (cb_getStrategy == null)
				cb_getStrategy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStrategy);
			return cb_getStrategy;
		}

		static IntPtr n_GetStrategy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IterableCSVToBeanBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Strategy);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Com.Opencsv.Bean.IMappingStrategy Strategy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='IterableCSVToBeanBuilder']/method[@name='getStrategy' and count(parameter)=0]"
			[Register ("getStrategy", "()Lcom/opencsv/bean/MappingStrategy;", "GetGetStrategyHandler")]
			get {
				const string __id = "getStrategy.()Lcom/opencsv/bean/MappingStrategy;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IMappingStrategy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IterableCSVToBeanBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='IterableCSVToBeanBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lcom/opencsv/bean/IterableCSVToBean;", "GetBuildHandler")]
		public virtual unsafe global::Com.Opencsv.Bean.IterableCSVToBean Build ()
		{
			const string __id = "build.()Lcom/opencsv/bean/IterableCSVToBean;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IterableCSVToBean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withFilter_Lcom_opencsv_bean_CsvToBeanFilter_;
#pragma warning disable 0169
		static Delegate GetWithFilter_Lcom_opencsv_bean_CsvToBeanFilter_Handler ()
		{
			if (cb_withFilter_Lcom_opencsv_bean_CsvToBeanFilter_ == null)
				cb_withFilter_Lcom_opencsv_bean_CsvToBeanFilter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithFilter_Lcom_opencsv_bean_CsvToBeanFilter_);
			return cb_withFilter_Lcom_opencsv_bean_CsvToBeanFilter_;
		}

		static IntPtr n_WithFilter_Lcom_opencsv_bean_CsvToBeanFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IterableCSVToBeanBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var filter = (global::Com.Opencsv.Bean.ICsvToBeanFilter)global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.ICsvToBeanFilter> (native_filter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithFilter (filter));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='IterableCSVToBeanBuilder']/method[@name='withFilter' and count(parameter)=1 and parameter[1][@type='com.opencsv.bean.CsvToBeanFilter']]"
		[Register ("withFilter", "(Lcom/opencsv/bean/CsvToBeanFilter;)Lcom/opencsv/bean/IterableCSVToBeanBuilder;", "GetWithFilter_Lcom_opencsv_bean_CsvToBeanFilter_Handler")]
		public virtual unsafe global::Com.Opencsv.Bean.IterableCSVToBeanBuilder WithFilter (global::Com.Opencsv.Bean.ICsvToBeanFilter filter)
		{
			const string __id = "withFilter.(Lcom/opencsv/bean/CsvToBeanFilter;)Lcom/opencsv/bean/IterableCSVToBeanBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((filter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) filter).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IterableCSVToBeanBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (filter);
			}
		}

		static Delegate cb_withMapper_Lcom_opencsv_bean_MappingStrategy_;
#pragma warning disable 0169
		static Delegate GetWithMapper_Lcom_opencsv_bean_MappingStrategy_Handler ()
		{
			if (cb_withMapper_Lcom_opencsv_bean_MappingStrategy_ == null)
				cb_withMapper_Lcom_opencsv_bean_MappingStrategy_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithMapper_Lcom_opencsv_bean_MappingStrategy_);
			return cb_withMapper_Lcom_opencsv_bean_MappingStrategy_;
		}

		static IntPtr n_WithMapper_Lcom_opencsv_bean_MappingStrategy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mappingStrategy)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IterableCSVToBeanBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mappingStrategy = (global::Com.Opencsv.Bean.IMappingStrategy)global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IMappingStrategy> (native_mappingStrategy, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithMapper (mappingStrategy));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='IterableCSVToBeanBuilder']/method[@name='withMapper' and count(parameter)=1 and parameter[1][@type='com.opencsv.bean.MappingStrategy&lt;T&gt;']]"
		[Register ("withMapper", "(Lcom/opencsv/bean/MappingStrategy;)Lcom/opencsv/bean/IterableCSVToBeanBuilder;", "GetWithMapper_Lcom_opencsv_bean_MappingStrategy_Handler")]
		public virtual unsafe global::Com.Opencsv.Bean.IterableCSVToBeanBuilder WithMapper (global::Com.Opencsv.Bean.IMappingStrategy mappingStrategy)
		{
			const string __id = "withMapper.(Lcom/opencsv/bean/MappingStrategy;)Lcom/opencsv/bean/IterableCSVToBeanBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mappingStrategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mappingStrategy).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IterableCSVToBeanBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (mappingStrategy);
			}
		}

		static Delegate cb_withReader_Lcom_opencsv_CSVReader_;
#pragma warning disable 0169
		static Delegate GetWithReader_Lcom_opencsv_CSVReader_Handler ()
		{
			if (cb_withReader_Lcom_opencsv_CSVReader_ == null)
				cb_withReader_Lcom_opencsv_CSVReader_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithReader_Lcom_opencsv_CSVReader_);
			return cb_withReader_Lcom_opencsv_CSVReader_;
		}

		static IntPtr n_WithReader_Lcom_opencsv_CSVReader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_reader)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IterableCSVToBeanBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var reader = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReader> (native_reader, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithReader (reader));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='IterableCSVToBeanBuilder']/method[@name='withReader' and count(parameter)=1 and parameter[1][@type='com.opencsv.CSVReader']]"
		[Register ("withReader", "(Lcom/opencsv/CSVReader;)Lcom/opencsv/bean/IterableCSVToBeanBuilder;", "GetWithReader_Lcom_opencsv_CSVReader_Handler")]
		public virtual unsafe global::Com.Opencsv.Bean.IterableCSVToBeanBuilder WithReader (global::Com.Opencsv.CSVReader reader)
		{
			const string __id = "withReader.(Lcom/opencsv/CSVReader;)Lcom/opencsv/bean/IterableCSVToBeanBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IterableCSVToBeanBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (reader);
			}
		}

	}
}
