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
    public class AccountHolderStatusChangeNotificationContent
    {
        /// <summary>
        /// The code of the account holder.
        /// </summary>
        /// <value>The code of the account holder.</value>
        [DataMember(Name = "accountHolderCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "accountHolderCode")]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// in case the account holder has not been updated, contains account holder fields, that did not pass the validation.
        /// </summary>
        /// <value>in case the account holder has not been updated, contains account holder fields, that did not pass the validation.</value>
        [DataMember(Name = "invalidFields", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "invalidFields")]
        public List<ErrorFieldType> InvalidFields { get; set; }

        /// <summary>
        /// Gets or Sets NewStatus
        /// </summary>
        [DataMember(Name = "newStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "newStatus")]
        public AccountHolderStatus NewStatus { get; set; }

        /// <summary>
        /// Gets or Sets OldStatus
        /// </summary>
        [DataMember(Name = "oldStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "oldStatus")]
        public AccountHolderStatus OldStatus { get; set; }

        /// <summary>
        /// The reason for the status change.
        /// </summary>
        /// <value>The reason for the status change.</value>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountHolderStatusChangeNotificationContent {\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  InvalidFields: ").Append(InvalidFields.ObjectListToString()).Append("\n");
            sb.Append("  NewStatus: ").Append(NewStatus).Append("\n");
            sb.Append("  OldStatus: ").Append(OldStatus).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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