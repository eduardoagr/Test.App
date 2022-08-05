using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linka.Linkaapikit.Module.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']"
	[global::Android.Runtime.Register ("com/linka/linkaapikit/module/api/SettingConfiguration", DoNotGenerateAcw=true)]
	public partial class SettingConfiguration : global::Com.Linka.Linkaapikit.Module.Api.LinkaAPIServiceResponse {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='assistNow']"
		[Register ("assistNow")]
		public int AssistNow {
			get {
				const string __id = "assistNow.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "assistNow.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='audio']"
		[Register ("audio")]
		public int Audio {
			get {
				const string __id = "audio.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "audio.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='disconnectedLock']"
		[Register ("disconnectedLock")]
		public int DisconnectedLock {
			get {
				const string __id = "disconnectedLock.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "disconnectedLock.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='fullGps']"
		[Register ("fullGps")]
		public int FullGps {
			get {
				const string __id = "fullGps.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "fullGps.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='gnssFilter']"
		[Register ("gnssFilter")]
		public int GnssFilter {
			get {
				const string __id = "gnssFilter.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "gnssFilter.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='gnssMode']"
		[Register ("gnssMode")]
		public int GnssMode {
			get {
				const string __id = "gnssMode.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "gnssMode.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='gpsOffBatteryPercent']"
		[Register ("gpsOffBatteryPercent")]
		public int GpsOffBatteryPercent {
			get {
				const string __id = "gpsOffBatteryPercent.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "gpsOffBatteryPercent.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='lockBattery']"
		[Register ("lockBattery")]
		public int LockBattery {
			get {
				const string __id = "lockBattery.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "lockBattery.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='lockedInterval']"
		[Register ("lockedInterval")]
		public int LockedInterval {
			get {
				const string __id = "lockedInterval.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "lockedInterval.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='lockedSleep']"
		[Register ("lockedSleep")]
		public int LockedSleep {
			get {
				const string __id = "lockedSleep.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "lockedSleep.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='lockWithMovement']"
		[Register ("lockWithMovement")]
		public int LockWithMovement {
			get {
				const string __id = "lockWithMovement.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "lockWithMovement.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='loopControl']"
		[Register ("loopControl")]
		public int LoopControl {
			get {
				const string __id = "loopControl.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "loopControl.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='modemType']"
		[Register ("modemType")]
		public int ModemType {
			get {
				const string __id = "modemType.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "modemType.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='motorSpeed']"
		[Register ("motorSpeed")]
		public int MotorSpeed {
			get {
				const string __id = "motorSpeed.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "motorSpeed.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='networkCode']"
		[Register ("networkCode")]
		public int NetworkCode {
			get {
				const string __id = "networkCode.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "networkCode.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='periodAInterval']"
		[Register ("periodAInterval")]
		public int PeriodAInterval {
			get {
				const string __id = "periodAInterval.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "periodAInterval.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='periodAStart']"
		[Register ("periodAStart")]
		public int PeriodAStart {
			get {
				const string __id = "periodAStart.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "periodAStart.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='periodBInterval']"
		[Register ("periodBInterval")]
		public int PeriodBInterval {
			get {
				const string __id = "periodBInterval.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "periodBInterval.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='periodBStart']"
		[Register ("periodBStart")]
		public int PeriodBStart {
			get {
				const string __id = "periodBStart.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "periodBStart.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='sleepBattery']"
		[Register ("sleepBattery")]
		public int SleepBattery {
			get {
				const string __id = "sleepBattery.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "sleepBattery.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='statePing']"
		[Register ("statePing")]
		public int StatePing {
			get {
				const string __id = "statePing.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "statePing.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='theftDuration']"
		[Register ("theftDuration")]
		public int TheftDuration {
			get {
				const string __id = "theftDuration.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "theftDuration.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='theftInterval']"
		[Register ("theftInterval")]
		public int TheftInterval {
			get {
				const string __id = "theftInterval.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "theftInterval.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='unlockBattery']"
		[Register ("unlockBattery")]
		public int UnlockBattery {
			get {
				const string __id = "unlockBattery.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "unlockBattery.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='unlockedDuration']"
		[Register ("unlockedDuration")]
		public int UnlockedDuration {
			get {
				const string __id = "unlockedDuration.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "unlockedDuration.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='unlockedInterval']"
		[Register ("unlockedInterval")]
		public int UnlockedInterval {
			get {
				const string __id = "unlockedInterval.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "unlockedInterval.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='unlockedMovement']"
		[Register ("unlockedMovement")]
		public int UnlockedMovement {
			get {
				const string __id = "unlockedMovement.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "unlockedMovement.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='unlockedSleep']"
		[Register ("unlockedSleep")]
		public int UnlockedSleep {
			get {
				const string __id = "unlockedSleep.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "unlockedSleep.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/field[@name='volume']"
		[Register ("volume")]
		public int Volume {
			get {
				const string __id = "volume.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "volume.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linka/linkaapikit/module/api/SettingConfiguration", typeof (SettingConfiguration));

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

		protected SettingConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linka.linkaapikit.module.api']/class[@name='SettingConfiguration']/constructor[@name='SettingConfiguration' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SettingConfiguration () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

	}
}
