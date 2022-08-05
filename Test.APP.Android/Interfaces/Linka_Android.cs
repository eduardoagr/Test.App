//using AndroidX.AppCompat.App;

//using Test.APP.Droid.Interfaces;
//using Test.APP.Interfaces;

//using Xamarin.Forms;

//[assembly: Dependency(typeof(Linka_Android))]
//namespace Test.APP.Droid.Interfaces
//{
//    public class Linka_Android : AppCompatActivity, ILinka, ILinkaCallbacks, ILinkaFrameworkProxyManagerDelegate
//    {
//        public bool Initialized { get; set; } = false;
//        private ILinkaCallbacks Callbacks
//        {
//            get; set;
//        }
//        private string _MerchantApiKey;
//        private string _MerchantSecretKey;
//        private string _AccessToken;
//        public ILinka Initialize(ILinkaCallbacks LinkaCallbacks, string MerchantApiKey, string MerchantSecretKey)
//        {
//            Initialized = true;
//            Callbacks = LinkaCallbacks;
//            proxyManager.InitFor(MerchantApiKey, MerchantSecretKey, this);
//            FetchAccessToken();
//            _MerchantApiKey = MerchantApiKey;
//            _MerchantSecretKey = MerchantSecretKey;
//            return this;
//        }
//        public static LinkaFrameworkProxyManager proxyManager;

//        public string AccessToken()
//        {
//            return _AccessToken;
//        }
//        public void FetchAccessToken()
//        {
//            proxyManager.FetchAccessKey();
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
//            return proxyManager.Lock(macAddress);
//        }
//        public bool UnLock(string macAddress)
//        {
//            return proxyManager.UnLock(macAddress);
//        }
//        public bool Query(string macAddress)
//        {
//            return proxyManager.Query(macAddress);
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
//        public void ErrorLockMoving()
//        {
//            if (Initialized)
//                Callbacks.ErrorLockMoving();
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

//        public void ErrorOtherWithCode(string code)
//        {
//            if (Initialized)
//                Callbacks.ErrorOtherWithCode(code);
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
//            proxyManager.DisconnectWithExistingController();
//            if (Initialized)
//                Callbacks.OnQueryLocked();
//        }
//        public void OnQueryUnlocked()
//        {
//            proxyManager.DisconnectWithExistingController();
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
//        public void OnPairingUp()
//        {
//            if (Initialized)
//                Callbacks.OnPairingUp();
//        }
//        #endregion
//    }
//}