using System;

namespace Adyen.IntegrationTest
{
    public class ClientConstants
    {
        public static readonly string MerchantAccount = "TestMerchantAccount";
        public static readonly string Xapikey = "AQEwhmfxJo3GbBdFw0m/n3Q5qf3VfI5eGbBFVXVXyGH6zDXzQ826g1ALHYQE3/a+9EmJEMFdWw2+5HzctViMSCJMYAc=-ZFf0nHHORUtjUQE9OQj5+RXxuYWdLNT505GcBq+BJbI=-u^?sZ>Cm$2B.gYBW";
        
        public static readonly string CaUsername = Environment.GetEnvironmentVariable("INTEGRATION_CA_USERNAME");
        public static readonly string CaPassword = Environment.GetEnvironmentVariable("INTEGRATION_CA_PASSWORD");
    }
}