namespace Adyen.Constants
{
    public class ClientConfig
    {
        //Test cloud api endpoints
        public const string CloudApiEndPointTest = "https://terminal-api-test.adyen.com";

        //Live cloud api endpoints
        public const string CloudApiEndPointEULive = "https://terminal-api-live.adyen.com";
        public const string CloudApiEndPointAULive = "https://terminal-api-live-au.adyen.com";
        public const string CloudApiEndPointUSLive = "https://terminal-api-live-us.adyen.com";
        public const string CloudApiEndPointAPSELive = "https://terminal-api-live-apse.adyen.com";
        
        public const string UserAgentSuffix = "adyen-dotnet-api-library/";
        public const string NexoProtocolVersion = "3.0";

        public const string LibName = "adyen-dotnet-api-library";
        public const string LibVersion = "15.0.0";
    }
}
