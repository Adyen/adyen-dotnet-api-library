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
    public class CompensateNegativeBalanceNotificationContent
    {
        /// <summary>
        /// A list of the negative balances compensated.
        /// </summary>
        /// <value>A list of the negative balances compensated.</value>
        [DataMember(Name = "records", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "records")]
        public List<CompensateNegativeBalanceNotificationRecord> Records { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompensateNegativeBalanceNotificationContent {\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
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