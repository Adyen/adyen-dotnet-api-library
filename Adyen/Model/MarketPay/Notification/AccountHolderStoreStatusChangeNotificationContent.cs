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
    public class AccountHolderStoreStatusChangeNotificationContent
    {
        /// <summary>
        /// The code of the account holder.
        /// </summary>
        /// <value>The code of the account holder.</value>
        [DataMember(Name = "accountHolderCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "accountHolderCode")]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// In case the store status has not been updated, contains fields that did not pass the validation.
        /// </summary>
        /// <value>In case the store status has not been updated, contains fields that did not pass the validation.</value>
        [DataMember(Name = "invalidFields", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "invalidFields")]
        public List<ErrorFieldType> InvalidFields { get; set; }

        /// <summary>
        /// The new status of the account holder.
        /// </summary>
        /// <value>The new status of the account holder.</value>
        [DataMember(Name = "newStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "newStatus")]
        public string NewStatus { get; set; }

        /// <summary>
        /// The former status of the account holder.
        /// </summary>
        /// <value>The former status of the account holder.</value>
        [DataMember(Name = "oldStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "oldStatus")]
        public string OldStatus { get; set; }

        /// <summary>
        /// The reason for the status change.
        /// </summary>
        /// <value>The reason for the status change.</value>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Alphanumeric identifier of the store.
        /// </summary>
        /// <value>Alphanumeric identifier of the store.</value>
        [DataMember(Name = "store", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "store")]
        public string Store { get; set; }

        /// <summary>
        /// Store store reference.
        /// </summary>
        /// <value>Store store reference.</value>
        [DataMember(Name = "storeReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "storeReference")]
        public string StoreReference { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountHolderStoreStatusChangeNotificationContent {\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  InvalidFields: ").Append(InvalidFields.ObjectListToString()).Append("\n");
            sb.Append("  NewStatus: ").Append(NewStatus).Append("\n");
            sb.Append("  OldStatus: ").Append(OldStatus).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Store: ").Append(Store).Append("\n");
            sb.Append("  StoreReference: ").Append(StoreReference).Append("\n");
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