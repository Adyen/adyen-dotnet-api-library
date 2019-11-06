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
    public class StoreDetailResponse
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
        /// The token which you can use later on for submitting the payout.
        /// </summary>
        /// <value>The token which you can use later on for submitting the payout.</value>
        [DataMember(Name = "recurringDetailReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "recurringDetailReference")]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// The result code of the transaction. `Success` indicates that the details were stored successfully.
        /// </summary>
        /// <value>The result code of the transaction. `Success` indicates that the details were stored successfully.</value>
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
            sb.Append("class StoreDetailResponse {\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
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
