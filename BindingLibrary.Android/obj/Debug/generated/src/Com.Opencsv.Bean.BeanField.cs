using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Opencsv.Bean {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.opencsv.bean']/class[@name='BeanField']"
	[global::Android.Runtime.Register ("com/opencsv/bean/BeanField", DoNotGenerateAcw=true)]
	public partial class BeanField : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/opencsv/bean/BeanField", typeof (BeanField));

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

		protected BeanField (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv.bean']/class[@name='BeanField']/constructor[@name='BeanField' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Field'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/reflect/Field;Z)V", "")]
		public unsafe BeanField (global::Java.Lang.Reflect.Field field, bool required) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/reflect/Field;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((field == null) ? IntPtr.Zero : ((global::Java.Lang.Object) field).Handle);
				__args [1] = new JniArgumentValue (required);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (field);
			}
		}

		static Delegate cb_getField;
#pragma warning disable 0169
		static Delegate GetGetFieldHandler ()
		{
			if (cb_getField == null)
				cb_getField = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetField);
			return cb_getField;
		}

		static IntPtr n_GetField (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.BeanField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Field);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Reflect.Field Field {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='BeanField']/method[@name='getField' and count(parameter)=0]"
			[Register ("getField", "()Ljava/lang/reflect/Field;", "GetGetFieldHandler")]
			get {
				const string __id = "getField.()Ljava/lang/reflect/Field;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isRequired;
#pragma warning disable 0169
		static Delegate GetIsRequiredHandler ()
		{
			if (cb_isRequired == null)
				cb_isRequired = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRequired);
			return cb_isRequired;
		}

		static bool n_IsRequired (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.BeanField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRequired;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRequired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='BeanField']/method[@name='isRequired' and count(parameter)=0]"
			[Register ("isRequired", "()Z", "GetIsRequiredHandler")]
			get {
				const string __id = "isRequired.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_setFieldValue_Ljava_lang_Object_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFieldValue_Ljava_lang_Object_Ljava_lang_String_Handler ()
		{
			if (cb_setFieldValue_Ljava_lang_Object_Ljava_lang_String_ == null)
				cb_setFieldValue_Ljava_lang_Object_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetFieldValue_Ljava_lang_Object_Ljava_lang_String_);
			return cb_setFieldValue_Ljava_lang_Object_Ljava_lang_String_;
		}

		static void n_SetFieldValue_Ljava_lang_Object_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bean, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.BeanField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bean = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_bean, JniHandleOwnership.DoNotTransfer);
			var value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SetFieldValue (bean, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='BeanField']/method[@name='setFieldValue' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='java.lang.String']]"
		[Register ("setFieldValue", "(Ljava/lang/Object;Ljava/lang/String;)V", "GetSetFieldValue_Ljava_lang_Object_Ljava_lang_String_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe void SetFieldValue (global::Java.Lang.Object bean, string value)
		{
			const string __id = "setFieldValue.(Ljava/lang/Object;Ljava/lang/String;)V";
			IntPtr native_bean = JNIEnv.ToLocalJniHandle (bean);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bean);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_bean);
				JNIEnv.DeleteLocalRef (native_value);
				global::System.GC.KeepAlive (bean);
			}
		}

	}
}
