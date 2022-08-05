using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linka.Linkaapikit.Module.Helpers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.helpers']/class[@name='LogHelper']"
	[global::Android.Runtime.Register ("com/linka/linkaapikit/module/helpers/LogHelper", DoNotGenerateAcw=true)]
	public partial class LogHelper : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.helpers']/class[@name='LogHelper']/field[@name='prefix']"
		[Register ("prefix")]
		public string Prefix {
			get {
				const string __id = "prefix.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "prefix.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.helpers']/class[@name='LogHelper']/field[@name='suffix']"
		[Register ("suffix")]
		public string Suffix {
			get {
				const string __id = "suffix.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "suffix.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.helpers']/class[@name='LogHelper.LogLevel']"
		[global::Android.Runtime.Register ("com/linka/linkaapikit/module/helpers/LogHelper$LogLevel", DoNotGenerateAcw=true)]
		public sealed partial class LogLevel : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.helpers']/class[@name='LogHelper.LogLevel']/field[@name='DEBUG']"
			[Register ("DEBUG")]
			public static global::Com.Linka.Linkaapikit.Module.Helpers.LogHelper.LogLevel Debug {
				get {
					const string __id = "DEBUG.Lcom/linka/linkaapikit/module/helpers/LogHelper$LogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Helpers.LogHelper.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.helpers']/class[@name='LogHelper.LogLevel']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Com.Linka.Linkaapikit.Module.Helpers.LogHelper.LogLevel Error {
				get {
					const string __id = "ERROR.Lcom/linka/linkaapikit/module/helpers/LogHelper$LogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Helpers.LogHelper.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.helpers']/class[@name='LogHelper.LogLevel']/field[@name='INFO']"
			[Register ("INFO")]
			public static global::Com.Linka.Linkaapikit.Module.Helpers.LogHelper.LogLevel Info {
				get {
					const string __id = "INFO.Lcom/linka/linkaapikit/module/helpers/LogHelper$LogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Helpers.LogHelper.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.helpers']/class[@name='LogHelper.LogLevel']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Com.Linka.Linkaapikit.Module.Helpers.LogHelper.LogLevel None {
				get {
					const string __id = "NONE.Lcom/linka/linkaapikit/module/helpers/LogHelper$LogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Helpers.LogHelper.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/helpers/LogHelper$LogLevel", typeof (LogLevel));

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

			internal LogLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.helpers']/class[@name='LogHelper.LogLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/linka/linkaapikit/module/helpers/LogHelper$LogLevel;", "")]
			public static unsafe global::Com.Linka.Linkaapikit.Module.Helpers.LogHelper.LogLevel ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/linka/linkaapikit/module/helpers/LogHelper$LogLevel;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Linka.Linkaapikit.Module.Helpers.LogHelper.LogLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.helpers']/class[@name='LogHelper.LogLevel']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/linka/linkaapikit/module/helpers/LogHelper$LogLevel;", "")]
			public static unsafe global::Com.Linka.Linkaapikit.Module.Helpers.LogHelper.LogLevel[] Values ()
			{
				const string __id = "values.()[Lcom/linka/linkaapikit/module/helpers/LogHelper$LogLevel;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Linka.Linkaapikit.Module.Helpers.LogHelper.LogLevel[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Linka.Linkaapikit.Module.Helpers.LogHelper.LogLevel));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/helpers/LogHelper", typeof (LogHelper));

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

		protected LogHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.helpers']/class[@name='LogHelper']/constructor[@name='LogHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LogHelper () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.helpers']/class[@name='LogHelper']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void D (string prefix, string suffix)
		{
			const string __id = "d.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_prefix = JNIEnv.NewString (prefix);
			IntPtr native_suffix = JNIEnv.NewString (suffix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_prefix);
				__args [1] = new JniArgumentValue (native_suffix);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
				JNIEnv.DeleteLocalRef (native_suffix);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.helpers']/class[@name='LogHelper']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void E (string prefix, string suffix)
		{
			const string __id = "e.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_prefix = JNIEnv.NewString (prefix);
			IntPtr native_suffix = JNIEnv.NewString (suffix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_prefix);
				__args [1] = new JniArgumentValue (native_suffix);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
				JNIEnv.DeleteLocalRef (native_suffix);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linka.linkaapikit.module.helpers']/class[@name='LogHelper']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void I (string prefix, string suffix)
		{
			const string __id = "i.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_prefix = JNIEnv.NewString (prefix);
			IntPtr native_suffix = JNIEnv.NewString (suffix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_prefix);
				__args [1] = new JniArgumentValue (native_suffix);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
				JNIEnv.DeleteLocalRef (native_suffix);
			}
		}

	}
}
