using System;

namespace Adyen.IntegrationTest
{
    public class ClientConstants
    {
        public static readonly string MerchantAccount = Environment.GetEnvironmentVariable("INTEGRATION_MERCHANT_ACCOUNT");
        public static readonly string Xapikey = Environment.GetEnvironmentVariable("INTEGRATION_X_API_KEY");
        
        public static readonly string CaUsername = Environment.GetEnvironmentVariable("INTEGRATION_CA_USERNAME");
        public static readonly string CaPassword = Environment.GetEnvironmentVariable("INTEGRATION_CA_PASSWORD");
    }
}