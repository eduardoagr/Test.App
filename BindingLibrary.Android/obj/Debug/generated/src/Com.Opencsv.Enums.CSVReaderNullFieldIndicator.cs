using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Opencsv.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.opencsv.enums']/class[@name='CSVReaderNullFieldIndicator']"
	[global::Android.Runtime.Register ("com/opencsv/enums/CSVReaderNullFieldIndicator", DoNotGenerateAcw=true)]
	public sealed partial class CSVReaderNullFieldIndicator : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv.enums']/class[@name='CSVReaderNullFieldIndicator']/field[@name='BOTH']"
		[Register ("BOTH")]
		public static global::Com.Opencsv.Enums.CSVReaderNullFieldIndicator Both {
			get {
				const string __id = "BOTH.Lcom/opencsv/enums/CSVReaderNullFieldIndicator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.Enums.CSVReaderNullFieldIndicator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv.enums']/class[@name='CSVReaderNullFieldIndicator']/field[@name='EMPTY_QUOTES']"
		[Register ("EMPTY_QUOTES")]
		public static global::Com.Opencsv.Enums.CSVReaderNullFieldIndicator EmptyQuotes {
			get {
				const string __id = "EMPTY_QUOTES.Lcom/opencsv/enums/CSVReaderNullFieldIndicator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.Enums.CSVReaderNullFieldIndicator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv.enums']/class[@name='CSVReaderNullFieldIndicator']/field[@name='EMPTY_SEPARATORS']"
		[Register ("EMPTY_SEPARATORS")]
		public static global::Com.Opencsv.Enums.CSVReaderNullFieldIndicator EmptySeparators {
			get {
				const string __id = "EMPTY_SEPARATORS.Lcom/opencsv/enums/CSVReaderNullFieldIndicator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.Enums.CSVReaderNullFieldIndicator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.opencsv.enums']/class[@name='CSVReaderNullFieldIndicator']/field[@name='NEITHER']"
		[Register ("NEITHER")]
		public static global::Com.Opencsv.Enums.CSVReaderNullFieldIndicator Neither {
			get {
				const string __id = "NEITHER.Lcom/opencsv/enums/CSVReaderNullFieldIndicator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.Enums.CSVReaderNullFieldIndicator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/opencsv/enums/CSVReaderNullFieldIndicator", typeof (CSVReaderNullFieldIndicator));

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

		internal CSVReaderNullFieldIndicator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.enums']/class[@name='CSVReaderNullFieldIndicator']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/opencsv/enums/CSVReaderNullFieldIndicator;", "")]
		public static unsafe global::Com.Opencsv.Enums.CSVReaderNullFieldIndicator ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/opencsv/enums/CSVReaderNullFieldIndicator;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Opencsv.Enums.CSVReaderNullFieldIndicator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.opencsv.enums']/class[@name='CSVReaderNullFieldIndicator']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/opencsv/enums/CSVReaderNullFieldIndicator;", "")]
		public static unsafe global::Com.Opencsv.Enums.CSVReaderNullFieldIndicator[] Values ()
		{
			const string __id = "values.()[Lcom/opencsv/enums/CSVReaderNullFieldIndicator;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Opencsv.Enums.CSVReaderNullFieldIndicator[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Opencsv.Enums.CSVReaderNullFieldIndicator));
			} finally {
			}
		}

	}
}
