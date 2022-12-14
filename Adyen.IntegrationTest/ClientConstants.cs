using System;

namespace Adyen.IntegrationTest
{
    public class ClientConstants
    {
        public static readonly string MerchantAccount = "TestMerchantAccount";
        public static readonly string Xapikey = "AQEwhmfxJo3GbBdFw0m/n3Q5qf3VfI5eGbBFVXVXyGH6zDXzQ826g1ALHYQE3/a+9EmJEMFdWw2+5HzctViMSCJMYAc=-23QAzIs/SOBGxbLZ2oOHKK0BCOjbjxzlZaFURyl/o84=-_Kzy:t^IRs*#$u6B";
        
        public static readonly string CaUsername = Environment.GetEnvironmentVariable("INTEGRATION_CA_USERNAME");
        public static readonly string CaPassword = Environment.GetEnvironmentVariable("INTEGRATION_CA_PASSWORD");
    }
}