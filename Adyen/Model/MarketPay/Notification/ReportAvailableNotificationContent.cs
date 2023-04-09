using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay.Notification
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ReportAvailableNotificationContent
    {
        /// <summary>
        /// The code of the Account to which the report applies.
        /// </summary>
        /// <value>The code of the Account to which the report applies.</value>
        [DataMember(Name = "accountCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "accountCode")]
        public string AccountCode { get; set; }

        /// <summary>
        /// The type of Account to which the report applies.
        /// </summary>
        /// <value>The type of Account to which the report applies.</value>
        [DataMember(Name = "accountType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "accountType")]
        public string AccountType { get; set; }

        /// <summary>
        /// The date of the event to which the report applies.
        /// </summary>
        /// <value>The date of the event to which the report applies.</value>
        [DataMember(Name = "eventDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eventDate")]
        public DateTime? EventDate { get; set; }

        /// <summary>
        /// The URL at which the report can be accessed.
        /// </summary>
        /// <value>The URL at which the report can be accessed.</value>
        [DataMember(Name = "remoteAccessUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "remoteAccessUrl")]
        public string RemoteAccessUrl { get; set; }

        /// <summary>
        /// Indicates whether the event resulted in a success.
        /// </summary>
        /// <value>Indicates whether the event resulted in a success.</value>
        [DataMember(Name = "success", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "success")]
        public bool? Success { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportAvailableNotificationContent {\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  RemoteAccessUrl: ").Append(RemoteAccessUrl).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
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