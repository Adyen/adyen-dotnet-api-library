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
using Adyen.Util;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay.Notification
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class BeneficiarySetupNotificationContent
    {
        /// <summary>
        /// The code of the beneficiary account.
        /// </summary>
        /// <value>The code of the beneficiary account.</value>
        [DataMember(Name = "destinationAccountCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "destinationAccountCode")]
        public string DestinationAccountCode { get; set; }

        /// <summary>
        /// The code of the beneficiary Account Holder.
        /// </summary>
        /// <value>The code of the beneficiary Account Holder.</value>
        [DataMember(Name = "destinationAccountHolderCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "destinationAccountHolderCode")]
        public string DestinationAccountHolderCode { get; set; }

        /// <summary>
        /// A listing of the invalid fields which have caused the Setup Beneficiary request to fail. If this is empty, the Setup Beneficiary request has succeeded.
        /// </summary>
        /// <value>A listing of the invalid fields which have caused the Setup Beneficiary request to fail. If this is empty, the Setup Beneficiary request has succeeded.</value>
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
        /// The code of the benefactor account.
        /// </summary>
        /// <value>The code of the benefactor account.</value>
        [DataMember(Name = "sourceAccountCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sourceAccountCode")]
        public string SourceAccountCode { get; set; }

        /// <summary>
        /// The code of the benefactor Account Holder.
        /// </summary>
        /// <value>The code of the benefactor Account Holder.</value>
        [DataMember(Name = "sourceAccountHolderCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sourceAccountHolderCode")]
        public string SourceAccountHolderCode { get; set; }

        /// <summary>
        /// The date on which the beneficiary was set up and funds transferred from benefactor to beneficiary.
        /// </summary>
        /// <value>The date on which the beneficiary was set up and funds transferred from benefactor to beneficiary.</value>
        [DataMember(Name = "transferDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "transferDate")]
        public DateTime? TransferDate { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeneficiarySetupNotificationContent {\n");
            sb.Append("  DestinationAccountCode: ").Append(DestinationAccountCode).Append("\n");
            sb.Append("  DestinationAccountHolderCode: ").Append(DestinationAccountHolderCode).Append("\n");
            sb.Append("  InvalidFields: ").Append(InvalidFields.ObjectListToString()).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  SourceAccountCode: ").Append(SourceAccountCode).Append("\n");
            sb.Append("  SourceAccountHolderCode: ").Append(SourceAccountHolderCode).Append("\n");
            sb.Append("  TransferDate: ").Append(TransferDate).Append("\n");
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