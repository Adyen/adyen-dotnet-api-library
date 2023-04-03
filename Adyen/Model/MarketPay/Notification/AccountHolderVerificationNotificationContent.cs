using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay.Notification
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class AccountHolderVerificationNotificationContent
    {
        /// <summary>
        /// The code of the account holder.
        /// </summary>
        /// <value>The code of the account holder.</value>
        [DataMember(Name = "accountHolderCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "accountHolderCode")]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// Gets or Sets KycCheckStatusData
        /// </summary>
        [DataMember(Name = "kycCheckStatusData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "kycCheckStatusData")]
        public KYCCheckStatusData KycCheckStatusData { get; set; }

        /// <summary>
        /// The unique code of the payout method that has been verified.
        /// </summary>
        /// <value>The unique code of the payout method that has been verified.</value>
        [DataMember(Name = "payoutMethodCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payoutMethodCode")]
        public string PayoutMethodCode { get; set; }

        /// <summary>
        /// The code of the shareholder that has been verified.
        /// </summary>
        /// <value>The code of the shareholder that has been verified.</value>
        [DataMember(Name = "shareholderCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shareholderCode")]
        public string ShareholderCode { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountHolderVerificationNotificationContent {\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  KycCheckStatusData: ").Append(KycCheckStatusData).Append("\n");
            sb.Append("  PayoutMethodCode: ").Append(PayoutMethodCode).Append("\n");
            sb.Append("  ShareholderCode: ").Append(ShareholderCode).Append("\n");
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