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
    public class AccountHolderVerificationNotification
    {
        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "content")]
        public AccountHolderVerificationNotificationContent Content { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "error")]
        public NotificationErrorContainer Error { get; set; }

        /// <summary>
        /// The date and time when an event has been completed.
        /// </summary>
        /// <value>The date and time when an event has been completed.</value>
        [DataMember(Name = "eventDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eventDate")]
        public DateTime? EventDate { get; set; }

        /// <summary>
        /// The event type of the notification.
        /// </summary>
        /// <value>The event type of the notification.</value>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eventType")]
        public string EventType { get; set; }

        /// <summary>
        /// The user or process that has triggered the notification.
        /// </summary>
        /// <value>The user or process that has triggered the notification.</value>
        [DataMember(Name = "executingUserKey", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "executingUserKey")]
        public string ExecutingUserKey { get; set; }

        /// <summary>
        /// Indicates whether the notification originated from the live environment or the test environment. If true, the notification originated from the live environment. If false, the notification originated from the test environment.
        /// </summary>
        /// <value>Indicates whether the notification originated from the live environment or the test environment. If true, the notification originated from the live environment. If false, the notification originated from the test environment.</value>
        [DataMember(Name = "live", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "live")]
        public bool? Live { get; set; }

        /// <summary>
        /// The PSP reference of the request from which the notification originates.
        /// </summary>
        /// <value>The PSP reference of the request from which the notification originates.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pspReference")]
        public string PspReference { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountHolderVerificationNotification {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  ExecutingUserKey: ").Append(ExecutingUserKey).Append("\n");
            sb.Append("  Live: ").Append(Live).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
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