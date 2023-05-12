using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay.Notification
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class RefundResultContainer
    {
        /// <summary>
        /// Gets or Sets OriginalTransaction
        /// </summary>
        [DataMember(Name = "RefundResult", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "RefundResult")]
        public RefundResult RefundResult { get; set; }
    }
}