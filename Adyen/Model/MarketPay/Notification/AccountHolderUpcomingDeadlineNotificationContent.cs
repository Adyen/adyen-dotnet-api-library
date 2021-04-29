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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay.Notification
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class AccountHolderUpcomingDeadlineNotificationContent
    {
        /// <summary>
        /// The code of the account holder whom the event refers to.
        /// </summary>
        /// <value>The code of the account holder whom the event refers to.</value>
        [DataMember(Name = "accountHolderCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "accountHolderCode")]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// The event name that will be trigger if no action is taken.
        /// </summary>
        /// <value>The event name that will be trigger if no action is taken.</value>
        [DataMember(Name = "event", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "event")]
        public string _Event { get; set; }

        /// <summary>
        /// The execution date scheduled for the event.
        /// </summary>
        /// <value>The execution date scheduled for the event.</value>
        [DataMember(Name = "executionDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "executionDate")]
        public DateTime? ExecutionDate { get; set; }

        /// <summary>
        /// The reason that leads to scheduling of the event.
        /// </summary>
        /// <value>The reason that leads to scheduling of the event.</value>
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
            sb.Append("class AccountHolderUpcomingDeadlineNotificationContent {\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  _Event: ").Append(_Event).Append("\n");
            sb.Append("  ExecutionDate: ").Append(ExecutionDate).Append("\n");
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