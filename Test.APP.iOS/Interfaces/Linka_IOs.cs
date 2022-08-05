//using System;

//using Test.APP.Interfaces;
//using Test.APP.iOS;

//using Xamarin.Forms;

//[assembly: Dependency(typeof(Linka_IOs))]
//namespace Test.APP.iOS
//{
//    public class Linka_IOs : ILinka, ILinkaCallbacks
//    {
//        private ILinkaCallbacks Callbacks
//        {
//            get; set;
//        }
//        private string _MerchantApiKey;
//        private string _MerchantSecretKey;
//        private string _AccessToken;
//        private LinkaFrameworkProxyManager proxy
//        {
//            get; set;
//        }
//        public bool Initialized { get; set; } = false;
//        public ILinka Initialize(ILinkaCallbacks LinkaCallbacks, string MerchantApiKey, string MerchantSecretKey)
//        {
//            Initialized = true;
//            Callbacks = LinkaCallbacks;
//            proxy = new LinkaFrameworkProxyManager();
//            LinkaFrameworkProxyManagerDelegate frameworkProxyManagerDelegate = new LinkaFrameworkProxyManagerDelegateImp(proxy, this);
//            proxy.InitForMerchantAPIKey(MerchantApiKey, MerchantSecretKey, frameworkProxyManagerDelegate);
//            return this;
//        }
//        public string AccessToken()
//        {
//            return _AccessToken;
//        }
//        public void FetchAccessToken()
//        {
//            proxy.FetchAccessKeyWithCompletion(s => this.OnTokenResponse(s), s => this.OnTokenError(s));
//        }

//        public string GetMerchantAPIKey()
//        {
//            return _MerchantApiKey;
//        }
//        public string GetMerchantSecretKey()
//        {
//            return _MerchantSecretKey;
//        }
//        public bool Lock(string macAddress)
//        {
//            return proxy.LockWithMacAddress(macAddress);
//        }
//        public bool UnLock(string macAddress)
//        {
//            return proxy.UnLockWithMacAddress(macAddress);
//        }
//        public bool Query(string macAddress)
//        {
//            return proxy.QueryWithMacAddress(macAddress);
//        }
//        #region Callbacks
//        public void ErrorAppNotInForeground()
//        {
//            if (Initialized)
//                Callbacks.ErrorAppNotInForeground();
//        }
//        public void ErrorBluetoothOff()
//        {
//            if (Initialized)
//                Callbacks.ErrorBluetoothOff();
//        }
//        public void ErrorConnectionTimeout()
//        {
//            if (Initialized)
//                Callbacks.ErrorConnectionTimeout();
//        }
//        public void ErrorGpsOff()
//        {
//            if (Initialized)
//                Callbacks.ErrorGpsOff();
//        }
//        public void ErrorInternetOff()
//        {
//            if (Initialized)
//                Callbacks.ErrorInternetOff();
//        }
//        public void ErrorInvalidAccessToken()
//        {
//            if (Initialized)
//                Callbacks.ErrorInvalidAccessToken();
//        }
//        public void ErrorLocationOff()
//        {
//            if (Initialized)
//                Callbacks.ErrorLocationOff();
//        }
//        public void ErrorLockBlock()
//        {
//            if (Initialized)
//                Callbacks.ErrorLockBlock();
//        }
//        public void ErrorLockJam()
//        {
//            if (Initialized)
//                Callbacks.ErrorLockJam();
//        }
//        public void ErrorLockStall()
//        {
//            if (Initialized)
//                Callbacks.ErrorLockStall();
//        }
//        public void ErrorLockingTimeout()
//        {
//            if (Initialized)
//                Callbacks.ErrorLockingTimeout();
//        }
//        public void ErrorMacAddress(string errorMsg)
//        {
//            if (Initialized)
//                Callbacks.ErrorMacAddress(errorMsg);
//        }
//        public void ErrorScanningTimeout()
//        {
//            if (Initialized)
//                Callbacks.ErrorScanningTimeout();
//        }
//        public void ErrorUnexpectedDisconnect()
//        {
//            if (Initialized)
//                Callbacks.ErrorUnexpectedDisconnect();
//        }
//        public void ErrorUnlockingTimeout()
//        {
//            if (Initialized)
//                Callbacks.ErrorUnlockingTimeout();
//        }
//        public void OnBatteryPercent(int batteryPercent)
//        {
//            if (Initialized)
//                Callbacks.OnBatteryPercent(batteryPercent);
//        }
//        public void OnConnected()
//        {
//            if (Initialized)
//                Callbacks.OnConnected();
//        }
//        public void OnInvalidMac()
//        {
//            if (Initialized)
//                Callbacks.OnInvalidMac();
//        }
//        public void OnLock()
//        {
//            if (Initialized)
//                Callbacks.OnLock();
//        }
//        public void OnLockStarted()
//        {
//            if (Initialized)
//                Callbacks.OnLockStarted();
//        }
//        public void OnPairingSuccess()
//        {
//            if (Initialized)
//                Callbacks.OnPairingSuccess();
//        }
//        public void OnQueryLocked()
//        {
//            proxy.DisconnectWithExistingController();
//            if (Initialized)
//                Callbacks.OnQueryLocked();
//        }
//        public void OnQueryUnlocked()
//        {
//            proxy.DisconnectWithExistingController();
//            if (Initialized)
//                Callbacks.OnQueryUnlocked();
//        }
//        public void OnScanFound()
//        {
//            if (Initialized)
//                Callbacks.OnScanFound();
//        }
//        public void OnTokenError(string error)
//        {
//            if (Initialized)
//                Callbacks.OnTokenError(error);
//        }
//        public void OnTokenResponse(string token)
//        {
//            _AccessToken = token;
//            if (Initialized)
//                Callbacks.OnTokenResponse(token);
//        }
//        public void OnUnlock()
//        {
//            if (Initialized)
//                Callbacks.OnUnlock();
//        }
//        public void OnUnlockStarted()
//        {
//            if (Initialized)
//                Callbacks.OnUnlockStarted();
//        }
//        public void PairTimeout()
//        {
//            if (Initialized)
//                Callbacks.PairTimeout();
//        }


//        public void ErrorMacAddressWithErrorMsg(string errorMsg)
//        {
//            if (Initialized)
//                Callbacks.ErrorMacAddress(errorMsg);
//        }
//        public void OnBatteryPercentWithBatteryPercent(nint batteryPercent)
//        {
//            if (Initialized)
//                Callbacks.OnBatteryPercent((int)batteryPercent);
//        }

//        public void ErrorOtherWithCode(string code)
//        {
//            if (Initialized)
//                Callbacks.ErrorOtherWithCode(code);
//        }
//        public void ErrorLockMoving()
//        {
//            if (Initialized)
//                Callbacks.ErrorLockMoving();
//        }
//        public void OnPairingUp()
//        {
//            if (Initialized)
//                Callbacks.OnPairingUp();
//        }
//        #endregion
//    }
//    internal class LinkaFrameworkProxyManagerDelegateImp : LinkaFrameworkProxyManagerDelegate
//    {
//        private LinkaFrameworkProxyManager _proxy;
//        private ILinkaCallbacks _callbacks;
//        public LinkaFrameworkProxyManagerDelegateImp(LinkaFrameworkProxyManager proxy, ILinkaCallbacks callbacks)
//        {
//            _callbacks = callbacks;
//            _proxy = proxy;
//        }

//        public override void ErrorAppNotInForeground()
//        {
//            _callbacks.ErrorAppNotInForeground();
//        }
//        public override void ErrorBluetoothOff()
//        {
//            _callbacks.ErrorBluetoothOff();
//        }
//        public override void ErrorConnectionTimeout()
//        {
//            _callbacks.ErrorConnectionTimeout();
//        }
//        public override void ErrorInternetOff()
//        {
//            _callbacks.ErrorInternetOff();
//        }
//        public override void ErrorInvalidAccessToken()
//        {
//            _callbacks.ErrorInvalidAccessToken();
//        }
//        public override void ErrorLockingTimeout()
//        {
//            _callbacks.ErrorLockingTimeout();
//        }
//        public override void ErrorLockJam()
//        {
//            _callbacks.ErrorLockJam();
//        }
//        public override void ErrorLockMoving()
//        {
//            _callbacks.ErrorLockMoving();
//        }
//        public override void ErrorLockStall()
//        {
//            _callbacks.ErrorLockStall();
//        }
//        public override void ErrorMacAddressWithErrorMsg(string errorMsg)
//        {
//            _callbacks.ErrorMacAddress(errorMsg);
//        }
//        public override void ErrorOtherWithCode(string code)
//        {
//            _callbacks.ErrorOtherWithCode(code);
//        }
//        public override void ErrorScanningTimeout()
//        {
//            _callbacks.ErrorScanningTimeout();
//        }
//        public override void ErrorUnexpectedDisconnect()
//        {
//            _callbacks.ErrorUnexpectedDisconnect();
//        }
//        public override void ErrorUnlockingTimeout()
//        {
//            _callbacks.ErrorUnlockingTimeout();
//        }
//        public override void OnBatteryPercentWithBatteryPercent(nint batteryPercent)
//        {
//            _callbacks.OnBatteryPercent((int)batteryPercent);
//        }
//        public override void OnConnected()
//        {
//            _callbacks.ErrorAppNotInForeground();
//        }
//        public override void OnLock()
//        {
//            _callbacks.ErrorAppNotInForeground();
//        }
//        public override void OnLockStarted()
//        {
//            _callbacks.ErrorAppNotInForeground();
//        }
//        public override void OnPairingSuccess()
//        {
//            _callbacks.ErrorAppNotInForeground();
//        }
//        public override void OnPairingUp()
//        {
//            _callbacks.OnPairingUp();
//        }
//        public override void OnQueryLocked()
//        {
//            _proxy.DisconnectWithExistingController();
//            _callbacks.OnQueryLocked();
//        }
//        public override void OnQueryUnlocked()
//        {
//            _proxy.DisconnectWithExistingController();
//            _callbacks.OnQueryUnlocked();
//        }
//        public override void OnScanFound()
//        {
//            _callbacks.OnScanFound();
//        }
//        public override void OnUnlock()
//        {
//            _callbacks.OnUnlock();
//        }
//        public override void OnUnlockStarted()
//        {
//            _callbacks.OnUnlockStarted();
//        }
//    }
//}