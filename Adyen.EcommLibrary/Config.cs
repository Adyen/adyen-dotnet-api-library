using Adyen.EcommLibrary.Model.Enum;

namespace Adyen.EcommLibrary
{
    public class Config
    {
        //Merchant details
        public string Username { get; set; }
        public string Password { get; set; }
        public string MerchantAccount { get; set; }

        public Environment Environment { get; set; }
        public string Endpoint { get; set; }
        
        public string ApplicationName { get; set; }

        //HPP specific
        public string HppEndpoint { get; set; }
        public string SkinCode{ get; set; }
        public string HmacKey { get; set; }
        //Terminal cloud api
        public string XApiKey { get; set; }
        public string CloudApiEndPoint { get; set; }
    }
}