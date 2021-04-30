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

using System;
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
    public class DirectDebitInitiatedNotificationContent
    {
        /// <summary>
        /// The code of the account.
        /// </summary>
        /// <value>The code of the account.</value>
        [DataMember(Name = "accountCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "accountCode")]
        public string AccountCode { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amount")]
        public Amount Amount { get; set; }

        /// <summary>
        /// Gets or Sets DebitInitiationDate
        /// </summary>
        [DataMember(Name = "debitInitiationDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "debitInitiationDate")]
        public DateTime DebitInitiationDate { get; set; }

        /// <summary>
        /// Invalid fields list.
        /// </summary>
        /// <value>Invalid fields list.</value>
        [DataMember(Name = "invalidFields", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "invalidFields")]
        public List<ErrorFieldType> InvalidFields { get; set; }

        /// <summary>
        /// The code of the merchant account.
        /// </summary>
        /// <value>The code of the merchant account.</value>
        [DataMember(Name = "merchantAccountCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantAccountCode")]
        public string MerchantAccountCode { get; set; }

        /// <summary>
        /// The split data for the debit request
        /// </summary>
        /// <value>The split data for the debit request</value>
        [DataMember(Name = "splits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "splits")]
        public List<Split> Splits { get; set; }

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
            sb.Append("class DirectDebitInitiatedNotificationContent {\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  DebitInitiationDate: ").Append(DebitInitiationDate).Append("\n");
            sb.Append("  InvalidFields: ").Append(InvalidFields).Append("\n");
            sb.Append("  MerchantAccountCode: ").Append(MerchantAccountCode).Append("\n");
            sb.Append("  Splits: ").Append(Splits).Append("\n");
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