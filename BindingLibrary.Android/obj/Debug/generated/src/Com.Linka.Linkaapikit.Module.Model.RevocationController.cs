using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linka.Linkaapikit.Module.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='RevocationController']"
	[global::Android.Runtime.Register ("com/linka/linkaapikit/module/model/RevocationController", DoNotGenerateAcw=true)]
	public partial class RevocationController : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='RevocationController']/field[@name='CAN_START_FACTORY_RESET']"
		[Register ("CAN_START_FACTORY_RESET")]
		public static string CanStartFactoryReset {
			get {
				const string __id = "CAN_START_FACTORY_RESET.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "CAN_START_FACTORY_RESET.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='RevocationController']/field[@name='FACTORY_RESET_SETTING']"
		[Register ("FACTORY_RESET_SETTING")]
		public static int FactoryResetSetting {
			get {
				const string __id = "FACTORY_RESET_SETTING.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "FACTORY_RESET_SETTING.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='RevocationController']/field[@name='FACTORY_RESET_SETTING_DEFAULT_VALUE']"
		[Register ("FACTORY_RESET_SETTING_DEFAULT_VALUE")]
		public static int FactoryResetSettingDefaultValue {
			get {
				const string __id = "FACTORY_RESET_SETTING_DEFAULT_VALUE.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "FACTORY_RESET_SETTING_DEFAULT_VALUE.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='RevocationController']/field[@name='FACTORY_RESET_SETTING_VALID_VALUE']"
		[Register ("FACTORY_RESET_SETTING_VALID_VALUE")]
		public static int FactoryResetSettingValidValue {
			get {
				const string __id = "FACTORY_RESET_SETTING_VALID_VALUE.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "FACTORY_RESET_SETTING_VALID_VALUE.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='RevocationController.FactoryResetCallback']"
		[Register ("com/linka/linkaapikit/module/model/RevocationController$FactoryResetCallback", "", "Com.Linka.Linkaapikit.Module.Model.RevocationController/IFactoryResetCallbackInvoker")]
		public partial interface IFactoryResetCallback : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='RevocationController.FactoryResetCallback']/method[@name='onReadSetting' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onReadSetting", "(I)V", "GetOnReadSetting_IHandler:Com.Linka.Linkaapikit.Module.Model.RevocationController/IFactoryResetCallbackInvoker, BindingLibrary.Android")]
			void OnReadSetting (int p0);

		}

		[global::Android.Runtime.Register ("com/linka/linkaapikit/module/model/RevocationController$FactoryResetCallback", DoNotGenerateAcw=true)]
		internal partial class IFactoryResetCallbackInvoker : global::Java.Lang.Object, IFactoryResetCallback {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/model/RevocationController$FactoryResetCallback", typeof (IFactoryResetCallbackInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IFactoryResetCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFactoryResetCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linka.linkaapikit.module.model.RevocationController.FactoryResetCallback'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFactoryResetCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onReadSetting_I;
#pragma warning disable 0169
			static Delegate GetOnReadSetting_IHandler ()
			{
				if (cb_onReadSetting_I == null)
					cb_onReadSetting_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnReadSetting_I);
				return cb_onReadSetting_I;
			}

			static void n_OnReadSetting_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.RevocationController.IFactoryResetCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnReadSetting (p0);
			}
#pragma warning restore 0169

			IntPtr id_onReadSetting_I;
			public unsafe void OnReadSetting (int p0)
			{
				if (id_onReadSetting_I == IntPtr.Zero)
					id_onReadSetting_I = JNIEnv.GetMethodID (class_ref, "onReadSetting", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReadSetting_I, __args);
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='RevocationController.FactoryResetDelegate']"
		[Register ("com/linka/linkaapikit/module/model/RevocationController$FactoryResetDelegate", "", "Com.Linka.Linkaapikit.Module.Model.RevocationController/IFactoryResetDelegateInvoker")]
		public partial interface IFactoryResetDelegate : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='RevocationController.FactoryResetDelegate']/method[@name='onFactoryResetComplete' and count(parameter)=0]"
			[Register ("onFactoryResetComplete", "()V", "GetOnFactoryResetCompleteHandler:Com.Linka.Linkaapikit.Module.Model.RevocationController/IFactoryResetDelegateInvoker, BindingLibrary.Android")]
			void OnFactoryResetComplete ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/interface[@name='RevocationController.FactoryResetDelegate']/method[@name='onFactoryResetError' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onFactoryResetError", "(I)V", "GetOnFactoryResetError_IHandler:Com.Linka.Linkaapikit.Module.Model.RevocationController/IFactoryResetDelegateInvoker, BindingLibrary.Android")]
			void OnFactoryResetError (int p0);

		}

		[global::Android.Runtime.Register ("com/linka/linkaapikit/module/model/RevocationController$FactoryResetDelegate", DoNotGenerateAcw=true)]
		internal partial class IFactoryResetDelegateInvoker : global::Java.Lang.Object, IFactoryResetDelegate {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/model/RevocationController$FactoryResetDelegate", typeof (IFactoryResetDelegateInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IFactoryResetDelegate GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFactoryResetDelegate> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linka.linkaapikit.module.model.RevocationController.FactoryResetDelegate'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFactoryResetDelegateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onFactoryResetComplete;
#pragma warning disable 0169
			static Delegate GetOnFactoryResetCompleteHandler ()
			{
				if (cb_onFactoryResetComplete == null)
					cb_onFactoryResetComplete = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnFactoryResetComplete);
				return cb_onFactoryResetComplete;
			}

			static void n_OnFactoryResetComplete (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.RevocationController.IFactoryResetDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnFactoryResetComplete ();
			}
#pragma warning restore 0169

			IntPtr id_onFactoryResetComplete;
			public unsafe void OnFactoryResetComplete ()
			{
				if (id_onFactoryResetComplete == IntPtr.Zero)
					id_onFactoryResetComplete = JNIEnv.GetMethodID (class_ref, "onFactoryResetComplete", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFactoryResetComplete);
			}

			static Delegate cb_onFactoryResetError_I;
#pragma warning disable 0169
			static Delegate GetOnFactoryResetError_IHandler ()
			{
				if (cb_onFactoryResetError_I == null)
					cb_onFactoryResetError_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnFactoryResetError_I);
				return cb_onFactoryResetError_I;
			}

			static void n_OnFactoryResetError_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.RevocationController.IFactoryResetDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnFactoryResetError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFactoryResetError_I;
			public unsafe void OnFactoryResetError (int p0)
			{
				if (id_onFactoryResetError_I == IntPtr.Zero)
					id_onFactoryResetError_I = JNIEnv.GetMethodID (class_ref, "onFactoryResetError", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFactoryResetError_I, __args);
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/model/RevocationController", typeof (RevocationController));

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

		protected RevocationController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='RevocationController']/constructor[@name='RevocationController' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RevocationController () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='RevocationController']/method[@name='FactoryResetErrorForceDoFactoryReset' and count(parameter)=3 and parameter[1][@type='com.linka.linkaapikit.module.model.Linka'] and parameter[2][@type='com.linka.linkaapikit.module.widget.LockController'] and parameter[3][@type='com.linka.linkaapikit.module.model.RevocationController.FactoryResetDelegate']]"
		[Register ("FactoryResetErrorForceDoFactoryReset", "(Lcom/linka/linkaapikit/module/model/Linka;Lcom/linka/linkaapikit/module/widget/LockController;Lcom/linka/linkaapikit/module/model/RevocationController$FactoryResetDelegate;)V", "")]
		public static unsafe void FactoryResetErrorForceDoFactoryReset (global::Com.Linka.Linkaapikit.Module.Model.Linka linka, global::Com.Linka.Linkaapikit.Module.Widget.LockController lockController, global::Com.Linka.Linkaapikit.Module.Model.RevocationController.IFactoryResetDelegate @delegate)
		{
			const string __id = "FactoryResetErrorForceDoFactoryReset.(Lcom/linka/linkaapikit/module/model/Linka;Lcom/linka/linkaapikit/module/widget/LockController;Lcom/linka/linkaapikit/module/model/RevocationController$FactoryResetDelegate;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((linka == null) ? IntPtr.Zero : ((global::Java.Lang.Object) linka).Handle);
				__args [1] = new JniArgumentValue ((lockController == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lockController).Handle);
				__args [2] = new JniArgumentValue ((@delegate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @delegate).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (linka);
				global::System.GC.KeepAlive (lockController);
				global::System.GC.KeepAlive (@delegate);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='RevocationController']/method[@name='doFactoryReset' and count(parameter)=3 and parameter[1][@type='com.linka.linkaapikit.module.model.Linka'] and parameter[2][@type='com.linka.linkaapikit.module.widget.LockController'] and parameter[3][@type='com.linka.linkaapikit.module.model.RevocationController.FactoryResetDelegate']]"
		[Register ("doFactoryReset", "(Lcom/linka/linkaapikit/module/model/Linka;Lcom/linka/linkaapikit/module/widget/LockController;Lcom/linka/linkaapikit/module/model/RevocationController$FactoryResetDelegate;)V", "")]
		public static unsafe void DoFactoryReset (global::Com.Linka.Linkaapikit.Module.Model.Linka linka, global::Com.Linka.Linkaapikit.Module.Widget.LockController lockController, global::Com.Linka.Linkaapikit.Module.Model.RevocationController.IFactoryResetDelegate @delegate)
		{
			const string __id = "doFactoryReset.(Lcom/linka/linkaapikit/module/model/Linka;Lcom/linka/linkaapikit/module/widget/LockController;Lcom/linka/linkaapikit/module/model/RevocationController$FactoryResetDelegate;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((linka == null) ? IntPtr.Zero : ((global::Java.Lang.Object) linka).Handle);
				__args [1] = new JniArgumentValue ((lockController == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lockController).Handle);
				__args [2] = new JniArgumentValue ((@delegate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @delegate).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (linka);
				global::System.GC.KeepAlive (lockController);
				global::System.GC.KeepAlive (@delegate);
			}
		}

		static Delegate cb_startResetMaster;
#pragma warning disable 0169
		static Delegate GetStartResetMasterHandler ()
		{
			if (cb_startResetMaster == null)
				cb_startResetMaster = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StartResetMaster);
			return cb_startResetMaster;
		}

		static void n_StartResetMaster (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Model.RevocationController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartResetMaster ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.model']/class[@name='RevocationController']/method[@name='startResetMaster' and count(parameter)=0]"
		[Register ("startResetMaster", "()V", "GetStartResetMasterHandler")]
		public virtual unsafe void StartResetMaster ()
		{
			const string __id = "startResetMaster.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
