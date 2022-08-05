using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linka.Linkaapikit.Module.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LocksController']"
	[global::Android.Runtime.Register ("com/linka/linkaapikit/module/widget/LocksController", DoNotGenerateAcw=true)]
	public partial class LocksController : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LocksController']/field[@name='currentLockController']"
		[Register ("currentLockController")]
		public static global::Com.Linka.Linkaapikit.Module.Widget.LockController CurrentLockController {
			get {
				const string __id = "currentLockController.Lcom/linka/linkaapikit/module/widget/LockController;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LockController> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "currentLockController.Lcom/linka/linkaapikit/module/widget/LockController;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/widget/LocksController", typeof (LocksController));

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

		protected LocksController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LocksController']/constructor[@name='LocksController' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LocksController () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe global::Com.Linka.Linkaapikit.Module.Widget.LocksController Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LocksController']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/linka/linkaapikit/module/widget/LocksController;", "")]
			get {
				const string __id = "getInstance.()Lcom/linka/linkaapikit/module/widget/LocksController;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LocksController> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.widget']/class[@name='LocksController']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)Lcom/linka/linkaapikit/module/widget/LocksController;", "")]
		public static unsafe global::Com.Linka.Linkaapikit.Module.Widget.LocksController Init (global::Android.Content.Context context)
		{
			const string __id = "init.(Landroid/content/Context;)Lcom/linka/linkaapikit/module/widget/LocksController;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Widget.LocksController> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

	}
}
