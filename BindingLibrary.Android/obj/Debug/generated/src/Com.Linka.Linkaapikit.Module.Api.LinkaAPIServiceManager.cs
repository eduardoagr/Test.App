using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linka.Linkaapikit.Module.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceManager']"
	[global::Android.Runtime.Register ("com/linka/linkaapikit/module/api/LinkaAPIServiceManager", DoNotGenerateAcw=true)]
	public partial class LinkaAPIServiceManager : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/api/LinkaAPIServiceManager", typeof (LinkaAPIServiceManager));

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

		protected LinkaAPIServiceManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceManager']/constructor[@name='LinkaAPIServiceManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LinkaAPIServiceManager () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe global::Com.Linka.Linkaapikit.Module.Api.ILinkaMerchantAPIService InstanceMerchant {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='LinkaAPIServiceManager']/method[@name='getInstanceMerchant' and count(parameter)=0]"
			[Register ("getInstanceMerchant", "()Lcom/linka/linkaapikit/module/api/LinkaMerchantAPIService;", "")]
			get {
				const string __id = "getInstanceMerchant.()Lcom/linka/linkaapikit/module/api/LinkaMerchantAPIService;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Api.ILinkaMerchantAPIService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
