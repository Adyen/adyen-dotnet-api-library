#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2021 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay.Notification
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class AccountHolderPayoutNotificationContent
    {
        /// <summary>
        /// The code of the account from which the payout was made.
        /// </summary>
        /// <value>The code of the account from which the payout was made.</value>
        [DataMember(Name = "accountCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "accountCode")]
        public string AccountCode { get; set; }

        /// <summary>
        /// The code of the Account Holder to which the payout was made.
        /// </summary>
        /// <value>The code of the Account Holder to which the payout was made.</value>
        [DataMember(Name = "accountHolderCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "accountHolderCode")]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// The payout amounts (per currency).
        /// </summary>
        /// <value>The payout amounts (per currency).</value>
        [DataMember(Name = "amounts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amounts")]
        public List<Amount> Amounts { get; set; }

        /// <summary>
        /// Gets or Sets BankAccountDetail
        /// </summary>
        [DataMember(Name = "bankAccountDetail", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bankAccountDetail")]
        public BankAccountDetail BankAccountDetail { get; set; }

        /// <summary>
        /// A description of the payout.
        /// </summary>
        /// <value>A description of the payout.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedArrivalDate
        /// </summary>
        [DataMember(Name = "estimatedArrivalDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "estimatedArrivalDate")]
        public LocalDate EstimatedArrivalDate { get; set; }

        /// <summary>
        /// Invalid fields list.
        /// </summary>
        /// <value>Invalid fields list.</value>
        [DataMember(Name = "invalidFields", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "invalidFields")]
        public List<ErrorFieldType> InvalidFields { get; set; }

        /// <summary>
        /// The merchant reference.
        /// </summary>
        /// <value>The merchant reference.</value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantReference")]
        public string MerchantReference { get; set; }

        /// <summary>
        /// The PSP reference of the original payout.
        /// </summary>
        /// <value>The PSP reference of the original payout.</value>
        [DataMember(Name = "originalPspReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "originalPspReference")]
        public string OriginalPspReference { get; set; }

        /// <summary>
        /// Payout account country.
        /// </summary>
        /// <value>Payout account country.</value>
        [DataMember(Name = "payoutAccountCountry", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payoutAccountCountry")]
        public string PayoutAccountCountry { get; set; }

        /// <summary>
        /// Payout bank account number.
        /// </summary>
        /// <value>Payout bank account number.</value>
        [DataMember(Name = "payoutAccountNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payoutAccountNumber")]
        public string PayoutAccountNumber { get; set; }

        /// <summary>
        /// Payout bank name.
        /// </summary>
        /// <value>Payout bank name.</value>
        [DataMember(Name = "payoutBankName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payoutBankName")]
        public string PayoutBankName { get; set; }

        /// <summary>
        /// Payout branch code.
        /// </summary>
        /// <value>Payout branch code.</value>
        [DataMember(Name = "payoutBranchCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payoutBranchCode")]
        public string PayoutBranchCode { get; set; }

        /// <summary>
        /// Payout transaction id.
        /// </summary>
        /// <value>Payout transaction id.</value>
        [DataMember(Name = "payoutReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payoutReference")]
        public long? PayoutReference { get; set; }

        /// <summary>
        /// Speed with which payouts for this account are processed. Permitted values: `STANDARD`, `SAME_DAY`.
        /// </summary>
        /// <value>Speed with which payouts for this account are processed. Permitted values: `STANDARD`, `SAME_DAY`.</value>
        [DataMember(Name = "payoutSpeed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payoutSpeed")]
        public string PayoutSpeed { get; set; }

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
            sb.Append("class AccountHolderPayoutNotificationContent {\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  Amounts: ").Append(Amounts).Append("\n");
            sb.Append("  BankAccountDetail: ").Append(BankAccountDetail).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EstimatedArrivalDate: ").Append(EstimatedArrivalDate).Append("\n");
            sb.Append("  InvalidFields: ").Append(InvalidFields).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  OriginalPspReference: ").Append(OriginalPspReference).Append("\n");
            sb.Append("  PayoutAccountCountry: ").Append(PayoutAccountCountry).Append("\n");
            sb.Append("  PayoutAccountNumber: ").Append(PayoutAccountNumber).Append("\n");
            sb.Append("  PayoutBankName: ").Append(PayoutBankName).Append("\n");
            sb.Append("  PayoutBranchCode: ").Append(PayoutBranchCode).Append("\n");
            sb.Append("  PayoutReference: ").Append(PayoutReference).Append("\n");
            sb.Append("  PayoutSpeed: ").Append(PayoutSpeed).Append("\n");
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