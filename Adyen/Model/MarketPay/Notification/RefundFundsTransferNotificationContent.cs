using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Util;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay.Notification
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class RefundFundsTransferNotificationContent
    {
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amount")]
        public Amount Amount { get; set; }

        /// <summary>
        /// Invalid fields list.
        /// </summary>
        /// <value>Invalid fields list.</value>
        [DataMember(Name = "invalidFields", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "invalidFields")]
        public List<ErrorFieldType> InvalidFields { get; set; }

        /// <summary>
        /// A value that can be supplied at the discretion of the executing user in order to link multiple transactions to one another.
        /// </summary>
        /// <value>A value that can be supplied at the discretion of the executing user in order to link multiple transactions to one another.</value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantReference")]
        public string MerchantReference { get; set; }

        /// <summary>
        /// A PSP reference of the original fund transfer.
        /// </summary>
        /// <value>A PSP reference of the original fund transfer.</value>
        [DataMember(Name = "originalReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "originalReference")]
        public string OriginalReference { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public OperationStatus Status { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefundFundsTransferNotificationContent {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  InvalidFields: ").Append(InvalidFields.ObjectListToString()).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  OriginalReference: ").Append(OriginalReference).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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