using System;

namespace Adyen.IntegrationTest
{
    public class ClientConstants
    {
        public static readonly string MerchantAccount = Environment.GetEnvironmentVariable("INTEGRATION_MERCHANT_ACCOUNT");

        public static readonly string Xapikey =
            "AQEwhmfxJo3GbBdFw0m/n3Q5qf3VfI5eGbBFVXVXyGH6zDXzQ826g1ALHYQE3/a+9EmJEMFdWw2+5HzctViMSCJMYAc=-lmQ8ow42JTlz9E7yeMv7YorGjOrGZJYb8KGxyIPto8I=->y<*juIuEG:t9^>9";
        
        public static readonly string CaUsername = Environment.GetEnvironmentVariable("INTEGRATION_CA_USERNAME");
        public static readonly string CaPassword = Environment.GetEnvironmentVariable("INTEGRATION_CA_PASSWORD");
    }
}