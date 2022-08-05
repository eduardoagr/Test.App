namespace Test.APP.Interfaces
{
    public interface ILinkaCallbacks
    {
        void ErrorAppNotInForeground();
        void ErrorBluetoothOff();
        void ErrorConnectionTimeout();
        void ErrorGpsOff();
        void ErrorInternetOff();
        void ErrorInvalidAccessToken();
        void ErrorLocationOff();
        void ErrorLockBlock();
        void ErrorLockJam();
        void ErrorLockMoving();
        void ErrorLockStall();
        void ErrorLockingTimeout();
        void ErrorMacAddress(string errorMsg);
        void ErrorOtherWithCode(string code);
        void ErrorScanningTimeout();
        void ErrorUnexpectedDisconnect();
        void ErrorUnlockingTimeout();
        void OnBatteryPercent(int batteryPercent);
        void OnConnected();
        void OnInvalidMac();
        void OnLock();
        void OnLockStarted();
        void OnPairingSuccess();
        void OnQueryLocked();
        void OnQueryUnlocked();
        void OnScanFound();
        void OnTokenError(string error);
        void OnTokenResponse(string token);
        void OnUnlock();
        void OnUnlockStarted();
        void PairTimeout();

        void OnPairingUp();
    }
}
