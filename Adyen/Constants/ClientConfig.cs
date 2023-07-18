namespace Adyen.Constants
{
    public class ClientConfig
    {
        //Test cloud api endpoints
        public static string CloudApiEndPointTest = "https://terminal-api-test.adyen.com";
        //Live cloud api endpoints
        public static string CloudApiEndPointEULive = "https://terminal-api-live.adyen.com";
        public static string CloudApiEndPointAULive = "https://terminal-api-live-au.adyen.com";
        public static string CloudApiEndPointUSLive = "https://terminal-api-live-us.adyen.com";

        public static string MarketpayEndPointTest = "https://cal-test.adyen.com/cal/services";
        public static string MarketpayEndPointLive = "https://cal-live.adyen.com/cal/services";
        public static string MarketPayFundApiVersion = "v5";
        public static string MarketPayAccountApiVersion = "v5";
        public static string HopApiVersion = "v1";
        public static string RecurringApiVersion = "v68";
        public static string ApiVersion = "v68";
        public static string UserAgentSuffix = "adyen-dotnet-api-library/";
        public static string NexoProtocolVersion = "3.0";

        public static string LibName = "adyen-dotnet-api-library";
        public static string LibVersion = "10.1.0";
    }
}
