using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.Payout
{
    /// <summary>
    /// ModifyRequest
    /// </summary>
    [DataContract]
    public class ModifyRequest
    {
        /// <summary>
        /// This field contains additional data, which may be required for a particular payout request.
        /// </summary>
        /// <value>This field contains additional data, which may be required for a particular payout request.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additionalData")]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// The merchant account identifier, with which you want to process the transaction.
        /// </summary>
        /// <value>The merchant account identifier, with which you want to process the transaction.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// The PSP reference received in the `/submitThirdParty` response.
        /// </summary>
        /// <value>The PSP reference received in the `/submitThirdParty` response.</value>
        [DataMember(Name = "originalReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "originalReference")]
        public string OriginalReference { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyRequest {\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  OriginalReference: ").Append(OriginalReference).Append("\n");
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