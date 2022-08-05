using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Opencsv.Stream.Reader {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.opencsv.stream.reader']/class[@name='LineReader']"
	[global::Android.Runtime.Register ("com/opencsv/stream/reader/LineReader", DoNotGenerateAcw=true)]
	public partial class LineReader : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/opencsv/stream/reader/LineReader", typeof (LineReader));

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

		protected LineReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.opencsv.stream.reader']/class[@name='LineReader']/constructor[@name='LineReader' and count(parameter)=2 and parameter[1][@type='java.io.BufferedReader'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/io/BufferedReader;Z)V", "")]
		public unsafe LineReader (global::Java.IO.BufferedReader reader, bool keepCarriageReturns) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/BufferedReader;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [1] = new JniArgumentValue (keepCarriageReturns);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (reader);
			}
		}

		static Delegate cb_readLine;
#pragma warning disable 0169
		static Delegate GetReadLineHandler ()
		{
			if (cb_readLine == null)
				cb_readLine = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ReadLine);
			return cb_readLine;
		}

		static IntPtr n_ReadLine (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Opencsv.Stream.Reader.LineReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReadLine ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.stream.reader']/class[@name='LineReader']/method[@name='readLine' and count(parameter)=0]"
		[Register ("readLine", "()Ljava/lang/String;", "GetReadLineHandler")]
		public virtual unsafe string ReadLine ()
		{
			const string __id = "readLine.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
