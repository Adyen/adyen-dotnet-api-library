using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.Payout
{
    /// <summary>
    /// ModifyResponse
    /// </summary>
    [DataContract]
    public class ModifyResponse
    {
        /// <summary>
        /// This field contains additional data, which may be returned in a particular response.
        /// </summary>
        /// <value>This field contains additional data, which may be returned in a particular response.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additionalData")]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// Adyen's 16-character string reference associated with the transaction. This value is globally unique; quote it when communicating with us about this response.
        /// </summary>
        /// <value>Adyen's 16-character string reference associated with the transaction. This value is globally unique; quote it when communicating with us about this response.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pspReference")]
        public string PspReference { get; set; }

        /// <summary>
        /// The response: * In case of success, it is either `payout-confirm-received` or `payout-decline-received`. * In case of an error, an informational message is returned.
        /// </summary>
        /// <value>The response: * In case of success, it is either `payout-confirm-received` or `payout-decline-received`. * In case of an error, an informational message is returned.</value>
        [DataMember(Name = "response", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "response")]
        public string Response { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyResponse {\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
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