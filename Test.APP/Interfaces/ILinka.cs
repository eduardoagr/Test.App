namespace Test.APP.Interfaces
{
    public interface ILinka
    {
        bool Initialized
        {
            get; set;
        }
        ILinka Initialize(ILinkaCallbacks LinkaCallbacks, string MerchantApiKey, string MerchantSecretKey);
        string GetMerchantAPIKey();
        string GetMerchantSecretKey();
        void FetchAccessToken();
        string AccessToken();
        bool Query(string macAddress);
        bool Lock(string macAddress);
        bool UnLock(string macAddress);
    }
}
