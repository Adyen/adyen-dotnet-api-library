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
    public class TransferFundsNotificationContent
    {
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amount")]
        public Amount Amount { get; set; }

        /// <summary>
        /// The code of the Account to which funds were credited.
        /// </summary>
        /// <value>The code of the Account to which funds were credited.</value>
        [DataMember(Name = "destinationAccountCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "destinationAccountCode")]
        public string DestinationAccountCode { get; set; }

        /// <summary>
        /// Invalid fields list.
        /// </summary>
        /// <value>Invalid fields list.</value>
        [DataMember(Name = "invalidFields", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "invalidFields")]
        public List<ErrorFieldType> InvalidFields { get; set; }

        /// <summary>
        /// The reference provided by the merchant.
        /// </summary>
        /// <value>The reference provided by the merchant.</value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantReference")]
        public string MerchantReference { get; set; }

        /// <summary>
        /// The code of the Account from which funds were debited.
        /// </summary>
        /// <value>The code of the Account from which funds were debited.</value>
        [DataMember(Name = "sourceAccountCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sourceAccountCode")]
        public string SourceAccountCode { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public OperationStatus Status { get; set; }

        /// <summary>
        /// The transfer code.
        /// </summary>
        /// <value>The transfer code.</value>
        [DataMember(Name = "transferCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "transferCode")]
        public string TransferCode { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferFundsNotificationContent {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  DestinationAccountCode: ").Append(DestinationAccountCode).Append("\n");
            sb.Append("  InvalidFields: ").Append(InvalidFields.ObjectListToString()).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  SourceAccountCode: ").Append(SourceAccountCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TransferCode: ").Append(TransferCode).Append("\n");
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