using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Opencsv.Bean {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.opencsv.bean']/class[@name='HeaderColumnNameTranslateMappingStrategy']"
	[global::Android.Runtime.Register ("com/opencsv/bean/HeaderColumnNameTranslateMappingStrategy", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class HeaderColumnNameTranslateMappingStrategy : global::Com.Opencsv.Bean.HeaderColumnNameMappingStrategy {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/opencsv/bean/HeaderColumnNameTranslateMappingStrategy", typeof (HeaderColumnNameTranslateMappingStrategy));

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

		protected HeaderColumnNameTranslateMappingStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv.bean']/class[@name='HeaderColumnNameTranslateMappingStrategy']/constructor[@name='HeaderColumnNameTranslateMappingStrategy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HeaderColumnNameTranslateMappingStrategy () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.HeaderColumnNameTranslateMappingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.ColumnMapping);
		}
#pragma warning restore 0169

		static Delegate cb_setColumnMapping_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetColumnMapping_Ljava_util_Map_Handler ()
		{
			if (cb_setColumnMapping_Ljava_util_Map_ == null)
				cb_setColumnMapping_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetColumnMapping_Ljava_util_Map_);
			return cb_setColumnMapping_Ljava_util_Map_;
		}

		static void n_SetColumnMapping_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_columnMapping)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.HeaderColumnNameTranslateMappingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var columnMapping = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_columnMapping, JniHandleOwnership.DoNotTransfer);
			__this.ColumnMapping = columnMapping;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> ColumnMapping {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='HeaderColumnNameTranslateMappingStrategy']/method[@name='getColumnMapping' and count(parameter)=0]"
			[Register ("getColumnMapping", "()Ljava/util/Map;", "GetGetColumnMappingHandler")]
			get {
				const string __id = "getColumnMapping.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='HeaderColumnNameTranslateMappingStrategy']/method[@name='setColumnMapping' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setColumnMapping", "(Ljava/util/Map;)V", "GetSetColumnMapping_Ljava_util_Map_Handler")]
			set {
				const string __id = "setColumnMapping.(Ljava/util/Map;)V";
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
					global::System.GC.KeepAlive (value);
				}
			}
		}

	}
}
