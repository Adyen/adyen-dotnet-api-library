using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.Payout
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class FundSource
    {
        /// <summary>
        /// a map of name/value pairs for passing in additional/industry-specific data
        /// </summary>
        /// <value>a map of name/value pairs for passing in additional/industry-specific data</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additionalData")]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "billingAddress")]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name = "card", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "card")]
        public Card Card { get; set; }

        /// <summary>
        /// the email address of the person
        /// </summary>
        /// <value>the email address of the person</value>
        [DataMember(Name = "shopperEmail", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shopperEmail")]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// Gets or Sets ShopperName
        /// </summary>
        [DataMember(Name = "shopperName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shopperName")]
        public Name ShopperName { get; set; }

        /// <summary>
        /// the telephone number of the person
        /// </summary>
        /// <value>the telephone number of the person</value>
        [DataMember(Name = "telephoneNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "telephoneNumber")]
        public string TelephoneNumber { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FundSource {\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
            sb.Append("  ShopperName: ").Append(ShopperName).Append("\n");
            sb.Append("  TelephoneNumber: ").Append(TelephoneNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

    }
}
