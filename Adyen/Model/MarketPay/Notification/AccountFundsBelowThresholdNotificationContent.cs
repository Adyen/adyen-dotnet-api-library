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
    public class AccountFundsBelowThresholdNotificationContent 
    {
        /// <summary>
        /// The code of the account with funds under threshold
        /// </summary>
        /// <value>The code of the account with funds under threshold</value>
        [DataMember(Name = "accountCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "accountCode")]
        public string AccountCode { get; set; }

        /// <summary>
        /// Gets or Sets BalanceDate
        /// </summary>
        [DataMember(Name = "balanceDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "balanceDate")]
        public DateTime BalanceDate { get; set; }

        /// <summary>
        /// Gets or Sets CurrentFunds
        /// </summary>
        [DataMember(Name = "currentFunds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currentFunds")]
        public Amount CurrentFunds { get; set; }

        /// <summary>
        /// Gets or Sets FundThreshold
        /// </summary>
        [DataMember(Name = "fundThreshold", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fundThreshold")]
        public Amount FundThreshold { get; set; }

        /// <summary>
        /// The code of the merchant account.
        /// </summary>
        /// <value>The code of the merchant account.</value>
        [DataMember(Name = "merchantAccountCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantAccountCode")]
        public string MerchantAccountCode { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountFundsBelowThresholdNotificationContent {\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  BalanceDate: ").Append(BalanceDate).Append("\n");
            sb.Append("  CurrentFunds: ").Append(CurrentFunds).Append("\n");
            sb.Append("  FundThreshold: ").Append(FundThreshold).Append("\n");
            sb.Append("  MerchantAccountCode: ").Append(MerchantAccountCode).Append("\n");
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