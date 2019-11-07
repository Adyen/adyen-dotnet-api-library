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
    public class SubmitResponse
    {
        /// <summary>
        /// This field contains additional data, which may be returned in a particular response.
        /// </summary>
        /// <value>This field contains additional data, which may be returned in a particular response.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additionalData")]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// A new reference to uniquely identify this request.
        /// </summary>
        /// <value>A new reference to uniquely identify this request.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pspReference")]
        public string PspReference { get; set; }

        /// <summary>
        /// In case of refusal, an informational message for the reason.
        /// </summary>
        /// <value>In case of refusal, an informational message for the reason.</value>
        [DataMember(Name = "refusalReason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "refusalReason")]
        public string RefusalReason { get; set; }

        /// <summary>
        /// The response: * In case of success, it is `payout-submit-received`. * In case of an error, an informational message is returned.
        /// </summary>
        /// <value>The response: * In case of success, it is `payout-submit-received`. * In case of an error, an informational message is returned.</value>
        [DataMember(Name = "resultCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resultCode")]
        public string ResultCode { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubmitResponse {\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  RefusalReason: ").Append(RefusalReason).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
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
