using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Opencsv.Bean {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.opencsv.bean']/class[@name='IterableCSVToBean']"
	[global::Android.Runtime.Register ("com/opencsv/bean/IterableCSVToBean", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class IterableCSVToBean : global::Com.Opencsv.Bean.AbstractCSVToBean, global::Java.Lang.IIterable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/opencsv/bean/IterableCSVToBean", typeof (IterableCSVToBean));

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

		protected IterableCSVToBean (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv.bean']/class[@name='IterableCSVToBean']/constructor[@name='IterableCSVToBean' and count(parameter)=3 and parameter[1][@type='com.opencsv.CSVReader'] and parameter[2][@type='com.opencsv.bean.MappingStrategy&lt;T&gt;'] and parameter[3][@type='com.opencsv.bean.CsvToBeanFilter']]"
		[Register (".ctor", "(Lcom/opencsv/CSVReader;Lcom/opencsv/bean/MappingStrategy;Lcom/opencsv/bean/CsvToBeanFilter;)V", "")]
		public unsafe IterableCSVToBean (global::Com.Opencsv.CSVReader csvReader, global::Com.Opencsv.Bean.IMappingStrategy strategy, global::Com.Opencsv.Bean.ICsvToBeanFilter filter) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/opencsv/CSVReader;Lcom/opencsv/bean/MappingStrategy;Lcom/opencsv/bean/CsvToBeanFilter;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((csvReader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) csvReader).Handle);
				__args [1] = new JniArgumentValue ((strategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) strategy).Handle);
				__args [2] = new JniArgumentValue ((filter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) filter).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (csvReader);
				global::System.GC.KeepAlive (strategy);
				global::System.GC.KeepAlive (filter);
			}
		}

		static Delegate cb_getCSVReader;
#pragma warning disable 0169
		static Delegate GetGetCSVReaderHandler ()
		{
			if (cb_getCSVReader == null)
				cb_getCSVReader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCSVReader);
			return cb_getCSVReader;
		}

		static IntPtr n_GetCSVReader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IterableCSVToBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CSVReader);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Com.Opencsv.CSVReader CSVReader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='IterableCSVToBean']/method[@name='getCSVReader' and count(parameter)=0]"
			[Register ("getCSVReader", "()Lcom/opencsv/CSVReader;", "GetGetCSVReaderHandler")]
			get {
				const string __id = "getCSVReader.()Lcom/opencsv/CSVReader;";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IterableCSVToBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Filter);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Com.Opencsv.Bean.ICsvToBeanFilter Filter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='IterableCSVToBean']/method[@name='getFilter' and count(parameter)=0]"
			[Register ("getFilter", "()Lcom/opencsv/bean/CsvToBeanFilter;", "GetGetFilterHandler")]
			get {
				const string __id = "getFilter.()Lcom/opencsv/bean/CsvToBeanFilter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.ICsvToBeanFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IterableCSVToBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Strategy);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Com.Opencsv.Bean.IMappingStrategy Strategy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='IterableCSVToBean']/method[@name='getStrategy' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IterableCSVToBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='IterableCSVToBean']/method[@name='iterator' and count(parameter)=0]"
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

		static Delegate cb_nextLine;
#pragma warning disable 0169
		static Delegate GetNextLineHandler ()
		{
			if (cb_nextLine == null)
				cb_nextLine = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NextLine);
			return cb_nextLine;
		}

		static IntPtr n_NextLine (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IterableCSVToBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NextLine ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='IterableCSVToBean']/method[@name='nextLine' and count(parameter)=0]"
		[Register ("nextLine", "()Ljava/lang/Object;", "GetNextLineHandler")]
		public virtual unsafe global::Java.Lang.Object NextLine ()
		{
			const string __id = "nextLine.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
