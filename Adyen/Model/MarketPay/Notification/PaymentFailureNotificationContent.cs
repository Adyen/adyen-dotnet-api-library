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
using Adyen.Util;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay.Notification
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class PaymentFailureNotificationContent
    {
        /// <summary>
        /// Missing or invalid fields that caused the payment error.
        /// </summary>
        /// <value>Missing or invalid fields that caused the payment error.</value>
        [DataMember(Name = "errorFields", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "errorFields")]
        public List<ErrorFieldTypeContainer> ErrorFields { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "errorMessage")]
        public Message ErrorMessage { get; set; }

        /// <summary>
        /// The modification merchant reference.
        /// </summary>
        /// <value>The modification merchant reference.</value>
        [DataMember(Name = "modificationMerchantReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "modificationMerchantReference")]
        public string ModificationMerchantReference { get; set; }

        /// <summary>
        /// The modification psp reference.
        /// </summary>
        /// <value>The modification psp reference.</value>
        [DataMember(Name = "modificationPspReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "modificationPspReference")]
        public string ModificationPspReference { get; set; }

        /// <summary>
        /// The payment merchant reference.
        /// </summary>
        /// <value>The payment merchant reference.</value>
        [DataMember(Name = "paymentMerchantReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentMerchantReference")]
        public string PaymentMerchantReference { get; set; }

        /// <summary>
        /// The payment psp reference.
        /// </summary>
        /// <value>The payment psp reference.</value>
        [DataMember(Name = "paymentPspReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentPspReference")]
        public string PaymentPspReference { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentFailureNotificationContent {\n");
            sb.Append("  ErrorFields: ").Append(ErrorFields.ObjectListToString()).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  ModificationMerchantReference: ").Append(ModificationMerchantReference).Append("\n");
            sb.Append("  ModificationPspReference: ").Append(ModificationPspReference).Append("\n");
            sb.Append("  PaymentMerchantReference: ").Append(PaymentMerchantReference).Append("\n");
            sb.Append("  PaymentPspReference: ").Append(PaymentPspReference).Append("\n");
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