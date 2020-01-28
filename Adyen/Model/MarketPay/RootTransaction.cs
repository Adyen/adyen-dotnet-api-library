using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Adyen.Model.MarketPay
{
    [DataContract]
    public class RootTransaction
    {
        [JsonProperty("Transaction")]
        public Transaction Transaction { get; set; }
    }
}
