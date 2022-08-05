using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Opencsv.Bean {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.opencsv.bean']/class[@name='BeanToCsv']"
	[global::Android.Runtime.Register ("com/opencsv/bean/BeanToCsv", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class BeanToCsv : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/opencsv/bean/BeanToCsv", typeof (BeanToCsv));

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

		protected BeanToCsv (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv.bean']/class[@name='BeanToCsv']/constructor[@name='BeanToCsv' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BeanToCsv () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_processHeader_Lcom_opencsv_bean_MappingStrategy_;
#pragma warning disable 0169
		static Delegate GetProcessHeader_Lcom_opencsv_bean_MappingStrategy_Handler ()
		{
			if (cb_processHeader_Lcom_opencsv_bean_MappingStrategy_ == null)
				cb_processHeader_Lcom_opencsv_bean_MappingStrategy_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ProcessHeader_Lcom_opencsv_bean_MappingStrategy_);
			return cb_processHeader_Lcom_opencsv_bean_MappingStrategy_;
		}

		static IntPtr n_ProcessHeader_Lcom_opencsv_bean_MappingStrategy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapper)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.BeanToCsv> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mapper = (global::Com.Opencsv.Bean.IMappingStrategy)global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IMappingStrategy> (native_mapper, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.ProcessHeader (mapper));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='BeanToCsv']/method[@name='processHeader' and count(parameter)=1 and parameter[1][@type='com.opencsv.bean.MappingStrategy&lt;T&gt;']]"
		[Register ("processHeader", "(Lcom/opencsv/bean/MappingStrategy;)[Ljava/lang/String;", "GetProcessHeader_Lcom_opencsv_bean_MappingStrategy_Handler")]
		protected virtual unsafe string[] ProcessHeader (global::Com.Opencsv.Bean.IMappingStrategy mapper)
		{
			const string __id = "processHeader.(Lcom/opencsv/bean/MappingStrategy;)[Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				global::System.GC.KeepAlive (mapper);
			}
		}

		static Delegate cb_processObject_Ljava_util_List_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetProcessObject_Ljava_util_List_Ljava_lang_Object_Handler ()
		{
			if (cb_processObject_Ljava_util_List_Ljava_lang_Object_ == null)
				cb_processObject_Ljava_util_List_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_ProcessObject_Ljava_util_List_Ljava_lang_Object_);
			return cb_processObject_Ljava_util_List_Ljava_lang_Object_;
		}

		static IntPtr n_ProcessObject_Ljava_util_List_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_getters, IntPtr native_bean)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.BeanToCsv> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var getters = global::Android.Runtime.JavaList<global::Java.Lang.Reflect.Method>.FromJniHandle (native_getters, JniHandleOwnership.DoNotTransfer);
			var bean = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_bean, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.ProcessObject (getters, bean));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='BeanToCsv']/method[@name='processObject' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.reflect.Method&gt;'] and parameter[2][@type='java.lang.Object']]"
		[Register ("processObject", "(Ljava/util/List;Ljava/lang/Object;)[Ljava/lang/String;", "GetProcessObject_Ljava_util_List_Ljava_lang_Object_Handler")]
		protected virtual unsafe string[] ProcessObject (global::System.Collections.Generic.IList<global::Java.Lang.Reflect.Method> getters, global::Java.Lang.Object bean)
		{
			const string __id = "processObject.(Ljava/util/List;Ljava/lang/Object;)[Ljava/lang/String;";
			IntPtr native_getters = global::Android.Runtime.JavaList<global::Java.Lang.Reflect.Method>.ToLocalJniHandle (getters);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_getters);
				__args [1] = new JniArgumentValue ((bean == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bean).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				JNIEnv.DeleteLocalRef (native_getters);
				global::System.GC.KeepAlive (getters);
				global::System.GC.KeepAlive (bean);
			}
		}

		static Delegate cb_write_Lcom_opencsv_bean_MappingStrategy_Lcom_opencsv_CSVWriter_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetWrite_Lcom_opencsv_bean_MappingStrategy_Lcom_opencsv_CSVWriter_Ljava_util_List_Handler ()
		{
			if (cb_write_Lcom_opencsv_bean_MappingStrategy_Lcom_opencsv_CSVWriter_Ljava_util_List_ == null)
				cb_write_Lcom_opencsv_bean_MappingStrategy_Lcom_opencsv_CSVWriter_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_Z) n_Write_Lcom_opencsv_bean_MappingStrategy_Lcom_opencsv_CSVWriter_Ljava_util_List_);
			return cb_write_Lcom_opencsv_bean_MappingStrategy_Lcom_opencsv_CSVWriter_Ljava_util_List_;
		}

		static bool n_Write_Lcom_opencsv_bean_MappingStrategy_Lcom_opencsv_CSVWriter_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapper, IntPtr native_csv, IntPtr native_objects)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.BeanToCsv> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mapper = (global::Com.Opencsv.Bean.IMappingStrategy)global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IMappingStrategy> (native_mapper, JniHandleOwnership.DoNotTransfer);
			var csv = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVWriter> (native_csv, JniHandleOwnership.DoNotTransfer);
			var objects = global::Android.Runtime.JavaList.FromJniHandle (native_objects, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Write (mapper, csv, objects);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='BeanToCsv']/method[@name='write' and count(parameter)=3 and parameter[1][@type='com.opencsv.bean.MappingStrategy&lt;T&gt;'] and parameter[2][@type='com.opencsv.CSVWriter'] and parameter[3][@type='java.util.List&lt;?&gt;']]"
		[Register ("write", "(Lcom/opencsv/bean/MappingStrategy;Lcom/opencsv/CSVWriter;Ljava/util/List;)Z", "GetWrite_Lcom_opencsv_bean_MappingStrategy_Lcom_opencsv_CSVWriter_Ljava_util_List_Handler")]
		public virtual unsafe bool Write (global::Com.Opencsv.Bean.IMappingStrategy mapper, global::Com.Opencsv.CSVWriter csv, global::System.Collections.IList objects)
		{
			const string __id = "write.(Lcom/opencsv/bean/MappingStrategy;Lcom/opencsv/CSVWriter;Ljava/util/List;)Z";
			IntPtr native_objects = global::Android.Runtime.JavaList.ToLocalJniHandle (objects);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				__args [1] = new JniArgumentValue ((csv == null) ? IntPtr.Zero : ((global::Java.Lang.Object) csv).Handle);
				__args [2] = new JniArgumentValue (native_objects);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_objects);
				global::System.GC.KeepAlive (mapper);
				global::System.GC.KeepAlive (csv);
				global::System.GC.KeepAlive (objects);
			}
		}

		static Delegate cb_write_Lcom_opencsv_bean_MappingStrategy_Ljava_io_Writer_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetWrite_Lcom_opencsv_bean_MappingStrategy_Ljava_io_Writer_Ljava_util_List_Handler ()
		{
			if (cb_write_Lcom_opencsv_bean_MappingStrategy_Ljava_io_Writer_Ljava_util_List_ == null)
				cb_write_Lcom_opencsv_bean_MappingStrategy_Ljava_io_Writer_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_Z) n_Write_Lcom_opencsv_bean_MappingStrategy_Ljava_io_Writer_Ljava_util_List_);
			return cb_write_Lcom_opencsv_bean_MappingStrategy_Ljava_io_Writer_Ljava_util_List_;
		}

		static bool n_Write_Lcom_opencsv_bean_MappingStrategy_Ljava_io_Writer_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapper, IntPtr native_writer, IntPtr native_objects)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.BeanToCsv> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mapper = (global::Com.Opencsv.Bean.IMappingStrategy)global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.IMappingStrategy> (native_mapper, JniHandleOwnership.DoNotTransfer);
			var writer = global::Java.Lang.Object.GetObject<global::Java.IO.Writer> (native_writer, JniHandleOwnership.DoNotTransfer);
			var objects = global::Android.Runtime.JavaList.FromJniHandle (native_objects, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Write (mapper, writer, objects);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='BeanToCsv']/method[@name='write' and count(parameter)=3 and parameter[1][@type='com.opencsv.bean.MappingStrategy&lt;T&gt;'] and parameter[2][@type='java.io.Writer'] and parameter[3][@type='java.util.List&lt;?&gt;']]"
		[Register ("write", "(Lcom/opencsv/bean/MappingStrategy;Ljava/io/Writer;Ljava/util/List;)Z", "GetWrite_Lcom_opencsv_bean_MappingStrategy_Ljava_io_Writer_Ljava_util_List_Handler")]
		public virtual unsafe bool Write (global::Com.Opencsv.Bean.IMappingStrategy mapper, global::Java.IO.Writer writer, global::System.Collections.IList objects)
		{
			const string __id = "write.(Lcom/opencsv/bean/MappingStrategy;Ljava/io/Writer;Ljava/util/List;)Z";
			IntPtr native_objects = global::Android.Runtime.JavaList.ToLocalJniHandle (objects);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				__args [1] = new JniArgumentValue ((writer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) writer).Handle);
				__args [2] = new JniArgumentValue (native_objects);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_objects);
				global::System.GC.KeepAlive (mapper);
				global::System.GC.KeepAlive (writer);
				global::System.GC.KeepAlive (objects);
			}
		}

	}
}
