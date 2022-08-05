using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Opencsv.Bean {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.opencsv.bean']/class[@name='ColumnPositionMappingStrategy']"
	[global::Android.Runtime.Register ("com/opencsv/bean/ColumnPositionMappingStrategy", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class ColumnPositionMappingStrategy : global::Com.Opencsv.Bean.HeaderColumnNameMappingStrategy {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/opencsv/bean/ColumnPositionMappingStrategy", typeof (ColumnPositionMappingStrategy));

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

		protected ColumnPositionMappingStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv.bean']/class[@name='ColumnPositionMappingStrategy']/constructor[@name='ColumnPositionMappingStrategy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ColumnPositionMappingStrategy () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getColumnMapping;
#pragma warning disable 0169
		static Delegate GetGetColumnMappingHandler ()
		{
			if (cb_getColumnMapping == null)
				cb_getColumnMapping = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetColumnMapping);
			return cb_getColumnMapping;
		}

		static IntPtr n_GetColumnMapping (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.ColumnPositionMappingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetColumnMapping ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='ColumnPositionMappingStrategy']/method[@name='getColumnMapping' and count(parameter)=0]"
		[Register ("getColumnMapping", "()[Ljava/lang/String;", "GetGetColumnMappingHandler")]
		public virtual unsafe string[] GetColumnMapping ()
		{
			const string __id = "getColumnMapping.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_setColumnMapping_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetColumnMapping_arrayLjava_lang_String_Handler ()
		{
			if (cb_setColumnMapping_arrayLjava_lang_String_ == null)
				cb_setColumnMapping_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetColumnMapping_arrayLjava_lang_String_);
			return cb_setColumnMapping_arrayLjava_lang_String_;
		}

		static void n_SetColumnMapping_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_columnMapping)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.ColumnPositionMappingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var columnMapping = (string[]) JNIEnv.GetArray (native_columnMapping, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetColumnMapping (columnMapping);
			if (columnMapping != null)
				JNIEnv.CopyArray (columnMapping, native_columnMapping);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='ColumnPositionMappingStrategy']/method[@name='setColumnMapping' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("setColumnMapping", "([Ljava/lang/String;)V", "GetSetColumnMapping_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetColumnMapping (params string[] columnMapping)
		{
			const string __id = "setColumnMapping.([Ljava/lang/String;)V";
			IntPtr native_columnMapping = JNIEnv.NewArray (columnMapping);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_columnMapping);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (columnMapping != null) {
					JNIEnv.CopyArray (native_columnMapping, columnMapping);
					JNIEnv.DeleteLocalRef (native_columnMapping);
				}
				global::System.GC.KeepAlive (columnMapping);
			}
		}

	}
}
