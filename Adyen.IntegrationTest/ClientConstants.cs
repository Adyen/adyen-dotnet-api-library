using System;

namespace Adyen.IntegrationTest
{
    public class ClientConstants
    {
        public static readonly string MerchantAccount = Environment.GetEnvironmentVariable("INTEGRATION_MERCHANT_ACCOUNT");

        public static readonly string Xapikey =
            "12345ldskajg;lkj939692j;fdkgja;elrkjt2384568594302fdsadg;ktrjetr23798559684329345fdsa";
        
        public static readonly string CaUsername = Environment.GetEnvironmentVariable("INTEGRATION_CA_USERNAME");
        public static readonly string CaPassword = Environment.GetEnvironmentVariable("INTEGRATION_CA_PASSWORD");
    }
}