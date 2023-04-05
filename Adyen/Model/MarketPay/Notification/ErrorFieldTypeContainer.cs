using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay.Notification
{
    public class ErrorFieldTypeContainer
    {
        /// <summary>
        /// The code of the account.
        /// </summary>
        /// <value>The code of the account.</value>
        [DataMember(Name = "errorFieldType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "errorFieldType")]
        public ErrorFieldType ErrorFieldType { get; set; }
    }
}
