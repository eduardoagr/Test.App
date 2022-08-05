using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Opencsv.Bean {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.opencsv.bean']/class[@name='HeaderColumnNameMappingStrategy']"
	[global::Android.Runtime.Register ("com/opencsv/bean/HeaderColumnNameMappingStrategy", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class HeaderColumnNameMappingStrategy : global::Java.Lang.Object, global::Com.Opencsv.Bean.IMappingStrategy {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv.bean']/class[@name='HeaderColumnNameMappingStrategy']/field[@name='annotationDriven']"
		[Register ("annotationDriven")]
		protected bool AnnotationDriven {
			get {
				const string __id = "annotationDriven.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "annotationDriven.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv.bean']/class[@name='HeaderColumnNameMappingStrategy']/field[@name='determinedIfAnnotationDriven']"
		[Register ("determinedIfAnnotationDriven")]
		protected bool DeterminedIfAnnotationDriven {
			get {
				const string __id = "determinedIfAnnotationDriven.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "determinedIfAnnotationDriven.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv.bean']/class[@name='HeaderColumnNameMappingStrategy']/field[@name='fieldMap']"
		[Register ("fieldMap")]
		protected global::System.Collections.IDictionary FieldMap {
			get {
				const string __id = "fieldMap.Ljava/util/Map;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "fieldMap.Ljava/util/Map;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv.bean']/class[@name='HeaderColumnNameMappingStrategy']/field[@name='header']"
		[Register ("header")]
		protected IList<string> Header {
			get {
				const string __id = "header.[Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "header.[Ljava/lang/String;";

				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv.bean']/class[@name='HeaderColumnNameMappingStrategy']/field[@name='indexLookup']"
		[Register ("indexLookup")]
		protected global::System.Collections.IDictionary IndexLookup {
			get {
				const string __id = "indexLookup.Ljava/util/Map;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "indexLookup.Ljava/util/Map;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/opencsv/bean/HeaderColumnNameMappingStrategy", typeof (HeaderColumnNameMappingStrategy));

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

		protected HeaderColumnNameMappingStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv.bean']/class[@name='HeaderColumnNameMappingStrategy']/constructor[@name='HeaderColumnNameMappingStrategy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HeaderColumnNameMappingStrategy () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isAnnotationDriven;
#pragma warning disable 0169
		static Delegate GetIsAnnotationDrivenHandler ()
		{
			if (cb_isAnnotationDriven == null)
				cb_isAnnotationDriven = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAnnotationDriven);
			return cb_isAnnotationDriven;
		}

		static bool n_IsAnnotationDriven (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.HeaderColumnNameMappingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAnnotationDriven;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAnnotationDriven {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='HeaderColumnNameMappingStrategy']/method[@name='isAnnotationDriven' and count(parameter)=0]"
			[Register ("isAnnotationDriven", "()Z", "GetIsAnnotationDrivenHandler")]
			get {
				const string __id = "isAnnotationDriven.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.HeaderColumnNameMappingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static Delegate cb_setType_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetSetType_Ljava_lang_Class_Handler ()
		{
			if (cb_setType_Ljava_lang_Class_ == null)
				cb_setType_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetType_Ljava_lang_Class_);
			return cb_setType_Ljava_lang_Class_;
		}

		static void n_SetType_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.HeaderColumnNameMappingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var type = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_type, JniHandleOwnership.DoNotTransfer);
			__this.Type = type;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Class Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='HeaderColumnNameMappingStrategy']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/Class;", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()Ljava/lang/Class;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='HeaderColumnNameMappingStrategy']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
			[Register ("setType", "(Ljava/lang/Class;)V", "GetSetType_Ljava_lang_Class_Handler")]
			set {
				const string __id = "setType.(Ljava/lang/Class;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_captureHeader_Lcom_opencsv_CSVReader_;
#pragma warning disable 0169
		static Delegate GetCaptureHeader_Lcom_opencsv_CSVReader_Handler ()
		{
			if (cb_captureHeader_Lcom_opencsv_CSVReader_ == null)
				cb_captureHeader_Lcom_opencsv_CSVReader_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CaptureHeader_Lcom_opencsv_CSVReader_);
			return cb_captureHeader_Lcom_opencsv_CSVReader_;
		}

		static void n_CaptureHeader_Lcom_opencsv_CSVReader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_reader)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.HeaderColumnNameMappingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var reader = global::Java.Lang.Object.GetObject<global::Com.Opencsv.CSVReader> (native_reader, JniHandleOwnership.DoNotTransfer);
			__this.CaptureHeader (reader);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='HeaderColumnNameMappingStrategy']/method[@name='captureHeader' and count(parameter)=1 and parameter[1][@type='com.opencsv.CSVReader']]"
		[Register ("captureHeader", "(Lcom/opencsv/CSVReader;)V", "GetCaptureHeader_Lcom_opencsv_CSVReader_Handler")]
		public virtual unsafe void CaptureHeader (global::Com.Opencsv.CSVReader reader)
		{
			const string __id = "captureHeader.(Lcom/opencsv/CSVReader;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (reader);
			}
		}

		static Delegate cb_createBean;
#pragma warning disable 0169
		static Delegate GetCreateBeanHandler ()
		{
			if (cb_createBean == null)
				cb_createBean = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CreateBean);
			return cb_createBean;
		}

		static IntPtr n_CreateBean (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.HeaderColumnNameMappingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateBean ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='HeaderColumnNameMappingStrategy']/method[@name='createBean' and count(parameter)=0]"
		[Register ("createBean", "()Ljava/lang/Object;", "GetCreateBeanHandler")]
		public virtual unsafe global::Java.Lang.Object CreateBean ()
		{
			const string __id = "createBean.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createIndexLookup_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateIndexLookup_arrayLjava_lang_String_Handler ()
		{
			if (cb_createIndexLookup_arrayLjava_lang_String_ == null)
				cb_createIndexLookup_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CreateIndexLookup_arrayLjava_lang_String_);
			return cb_createIndexLookup_arrayLjava_lang_String_;
		}

		static void n_CreateIndexLookup_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_values)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.HeaderColumnNameMappingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var values = (string[]) JNIEnv.GetArray (native_values, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.CreateIndexLookup (values);
			if (values != null)
				JNIEnv.CopyArray (values, native_values);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='HeaderColumnNameMappingStrategy']/method[@name='createIndexLookup' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("createIndexLookup", "([Ljava/lang/String;)V", "GetCreateIndexLookup_arrayLjava_lang_String_Handler")]
		protected virtual unsafe void CreateIndexLookup (string[] values)
		{
			const string __id = "createIndexLookup.([Ljava/lang/String;)V";
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_values);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
				global::System.GC.KeepAlive (values);
			}
		}

		static Delegate cb_findField_I;
#pragma warning disable 0169
		static Delegate GetFindField_IHandler ()
		{
			if (cb_findField_I == null)
				cb_findField_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_FindField_I);
			return cb_findField_I;
		}

		static IntPtr n_FindField_I (IntPtr jnienv, IntPtr native__this, int col)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.HeaderColumnNameMappingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FindField (col));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='HeaderColumnNameMappingStrategy']/method[@name='findField' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("findField", "(I)Lcom/opencsv/bean/BeanField;", "GetFindField_IHandler")]
		public virtual unsafe global::Com.Opencsv.Bean.BeanField FindField (int col)
		{
			const string __id = "findField.(I)Lcom/opencsv/bean/BeanField;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (col);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.BeanField> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_findField_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFindField_Ljava_lang_String_Handler ()
		{
			if (cb_findField_Ljava_lang_String_ == null)
				cb_findField_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_FindField_Ljava_lang_String_);
			return cb_findField_Ljava_lang_String_;
		}

		static IntPtr n_FindField_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.HeaderColumnNameMappingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FindField (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='HeaderColumnNameMappingStrategy']/method[@name='findField' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findField", "(Ljava/lang/String;)Lcom/opencsv/bean/BeanField;", "GetFindField_Ljava_lang_String_Handler")]
		protected virtual unsafe global::Com.Opencsv.Bean.BeanField FindField (string name)
		{
			const string __id = "findField.(Ljava/lang/String;)Lcom/opencsv/bean/BeanField;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.BeanField> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getColumnIndex_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetColumnIndex_Ljava_lang_String_Handler ()
		{
			if (cb_getColumnIndex_Ljava_lang_String_ == null)
				cb_getColumnIndex_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetColumnIndex_Ljava_lang_String_);
			return cb_getColumnIndex_Ljava_lang_String_;
		}

		static IntPtr n_GetColumnIndex_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.HeaderColumnNameMappingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetColumnIndex (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='HeaderColumnNameMappingStrategy']/method[@name='getColumnIndex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getColumnIndex", "(Ljava/lang/String;)Ljava/lang/Integer;", "GetGetColumnIndex_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Integer GetColumnIndex (string name)
		{
			const string __id = "getColumnIndex.(Ljava/lang/String;)Ljava/lang/Integer;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getColumnName_I;
#pragma warning disable 0169
		static Delegate GetGetColumnName_IHandler ()
		{
			if (cb_getColumnName_I == null)
				cb_getColumnName_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetColumnName_I);
			return cb_getColumnName_I;
		}

		static IntPtr n_GetColumnName_I (IntPtr jnienv, IntPtr native__this, int col)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.HeaderColumnNameMappingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetColumnName (col));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='HeaderColumnNameMappingStrategy']/method[@name='getColumnName' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getColumnName", "(I)Ljava/lang/String;", "GetGetColumnName_IHandler")]
		public virtual unsafe string GetColumnName (int col)
		{
			const string __id = "getColumnName.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (col);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_loadFieldMap;
#pragma warning disable 0169
		static Delegate GetLoadFieldMapHandler ()
		{
			if (cb_loadFieldMap == null)
				cb_loadFieldMap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_LoadFieldMap);
			return cb_loadFieldMap;
		}

		static IntPtr n_LoadFieldMap (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.HeaderColumnNameMappingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Com.Opencsv.Bean.BeanField>.ToLocalJniHandle (__this.LoadFieldMap ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='HeaderColumnNameMappingStrategy']/method[@name='loadFieldMap' and count(parameter)=0]"
		[Register ("loadFieldMap", "()Ljava/util/Map;", "GetLoadFieldMapHandler")]
		protected virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Com.Opencsv.Bean.BeanField> LoadFieldMap ()
		{
			const string __id = "loadFieldMap.()Ljava/util/Map;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaDictionary<string, global::Com.Opencsv.Bean.BeanField>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_resetIndexMap;
#pragma warning disable 0169
		static Delegate GetResetIndexMapHandler ()
		{
			if (cb_resetIndexMap == null)
				cb_resetIndexMap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ResetIndexMap);
			return cb_resetIndexMap;
		}

		static void n_ResetIndexMap (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Bean.HeaderColumnNameMappingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetIndexMap ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.bean']/class[@name='HeaderColumnNameMappingStrategy']/method[@name='resetIndexMap' and count(parameter)=0]"
		[Register ("resetIndexMap", "()V", "GetResetIndexMapHandler")]
		protected virtual unsafe void ResetIndexMap ()
		{
			const string __id = "resetIndexMap.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
