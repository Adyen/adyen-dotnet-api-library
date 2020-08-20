#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// UpdatePayoutScheduleRequest
    /// </summary>
    [DataContract]
        public partial class UpdatePayoutScheduleRequest :  IEquatable<UpdatePayoutScheduleRequest>, IValidatableObject
    {
        /// <summary>
        /// Direction on how to handle any payouts that have already been scheduled. Permitted values: * &#x60;CLOSE&#x60; will close the existing batch of payouts. * &#x60;UPDATE&#x60; will reschedule the existing batch to the new schedule. * &#x60;NOTHING&#x60; (**default**) will allow the payout to proceed.
        /// </summary>
        /// <value>Direction on how to handle any payouts that have already been scheduled. Permitted values: * &#x60;CLOSE&#x60; will close the existing batch of payouts. * &#x60;UPDATE&#x60; will reschedule the existing batch to the new schedule. * &#x60;NOTHING&#x60; (**default**) will allow the payout to proceed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ActionEnum
        {
            /// <summary>
            /// Enum CLOSE for value: CLOSE
            /// </summary>
            [EnumMember(Value = "CLOSE")]
            CLOSE = 1,
            /// <summary>
            /// Enum NOTHING for value: NOTHING
            /// </summary>
            [EnumMember(Value = "NOTHING")]
            NOTHING = 2,
            /// <summary>
            /// Enum UPDATE for value: UPDATE
            /// </summary>
            [EnumMember(Value = "UPDATE")]
            UPDATE = 3        }
        /// <summary>
        /// Direction on how to handle any payouts that have already been scheduled. Permitted values: * &#x60;CLOSE&#x60; will close the existing batch of payouts. * &#x60;UPDATE&#x60; will reschedule the existing batch to the new schedule. * &#x60;NOTHING&#x60; (**default**) will allow the payout to proceed.
        /// </summary>
        /// <value>Direction on how to handle any payouts that have already been scheduled. Permitted values: * &#x60;CLOSE&#x60; will close the existing batch of payouts. * &#x60;UPDATE&#x60; will reschedule the existing batch to the new schedule. * &#x60;NOTHING&#x60; (**default**) will allow the payout to proceed.</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// The payout schedule to which the account is to be updated. Permitted values: &#x60;DEFAULT&#x60;, &#x60;HOLD&#x60;, &#x60;DAILY&#x60;, &#x60;WEEKLY&#x60;, &#x60;MONTHLY&#x60;. &#x60;HOLD&#x60; will prevent scheduled payouts from happening but will still allow manual payouts to occur.
        /// </summary>
        /// <value>The payout schedule to which the account is to be updated. Permitted values: &#x60;DEFAULT&#x60;, &#x60;HOLD&#x60;, &#x60;DAILY&#x60;, &#x60;WEEKLY&#x60;, &#x60;MONTHLY&#x60;. &#x60;HOLD&#x60; will prevent scheduled payouts from happening but will still allow manual payouts to occur.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ScheduleEnum
        {
            /// <summary>
            /// Enum BIWEEKLYON1STAND15THATMIDNIGHT for value: BIWEEKLY_ON_1ST_AND_15TH_AT_MIDNIGHT
            /// </summary>
            [EnumMember(Value = "BIWEEKLY_ON_1ST_AND_15TH_AT_MIDNIGHT")]
            BIWEEKLYON1STAND15THATMIDNIGHT = 1,
            /// <summary>
            /// Enum BIWEEKLYON1STAND15THATNOON for value: BIWEEKLY_ON_1ST_AND_15TH_AT_NOON
            /// </summary>
            [EnumMember(Value = "BIWEEKLY_ON_1ST_AND_15TH_AT_NOON")]
            BIWEEKLYON1STAND15THATNOON = 2,
            /// <summary>
            /// Enum DAILY for value: DAILY
            /// </summary>
            [EnumMember(Value = "DAILY")]
            DAILY = 3,
            /// <summary>
            /// Enum DAILY6PM for value: DAILY_6PM
            /// </summary>
            [EnumMember(Value = "DAILY_6PM")]
            DAILY6PM = 4,
            /// <summary>
            /// Enum DAILYAU for value: DAILY_AU
            /// </summary>
            [EnumMember(Value = "DAILY_AU")]
            DAILYAU = 5,
            /// <summary>
            /// Enum DAILYEU for value: DAILY_EU
            /// </summary>
            [EnumMember(Value = "DAILY_EU")]
            DAILYEU = 6,
            /// <summary>
            /// Enum DAILYUS for value: DAILY_US
            /// </summary>
            [EnumMember(Value = "DAILY_US")]
            DAILYUS = 7,
            /// <summary>
            /// Enum DEFAULT for value: DEFAULT
            /// </summary>
            [EnumMember(Value = "DEFAULT")]
            DEFAULT = 8,
            /// <summary>
            /// Enum EVERY6HOURSFROMMIDNIGHT for value: EVERY_6_HOURS_FROM_MIDNIGHT
            /// </summary>
            [EnumMember(Value = "EVERY_6_HOURS_FROM_MIDNIGHT")]
            EVERY6HOURSFROMMIDNIGHT = 9,
            /// <summary>
            /// Enum HOLD for value: HOLD
            /// </summary>
            [EnumMember(Value = "HOLD")]
            HOLD = 10,
            /// <summary>
            /// Enum MONTHLY for value: MONTHLY
            /// </summary>
            [EnumMember(Value = "MONTHLY")]
            MONTHLY = 11,
            /// <summary>
            /// Enum WEEKLY for value: WEEKLY
            /// </summary>
            [EnumMember(Value = "WEEKLY")]
            WEEKLY = 12,
            /// <summary>
            /// Enum WEEKLYONTUEFRIMIDNIGHT for value: WEEKLY_ON_TUE_FRI_MIDNIGHT
            /// </summary>
            [EnumMember(Value = "WEEKLY_ON_TUE_FRI_MIDNIGHT")]
            WEEKLYONTUEFRIMIDNIGHT = 13,
            /// <summary>
            /// Enum YEARLY for value: YEARLY
            /// </summary>
            [EnumMember(Value = "YEARLY")]
            YEARLY = 14        }
        /// <summary>
        /// The payout schedule to which the account is to be updated. Permitted values: &#x60;DEFAULT&#x60;, &#x60;HOLD&#x60;, &#x60;DAILY&#x60;, &#x60;WEEKLY&#x60;, &#x60;MONTHLY&#x60;. &#x60;HOLD&#x60; will prevent scheduled payouts from happening but will still allow manual payouts to occur.
        /// </summary>
        /// <value>The payout schedule to which the account is to be updated. Permitted values: &#x60;DEFAULT&#x60;, &#x60;HOLD&#x60;, &#x60;DAILY&#x60;, &#x60;WEEKLY&#x60;, &#x60;MONTHLY&#x60;. &#x60;HOLD&#x60; will prevent scheduled payouts from happening but will still allow manual payouts to occur.</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public ScheduleEnum Schedule { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePayoutScheduleRequest" /> class.
        /// </summary>
        /// <param name="action">Direction on how to handle any payouts that have already been scheduled. Permitted values: * &#x60;CLOSE&#x60; will close the existing batch of payouts. * &#x60;UPDATE&#x60; will reschedule the existing batch to the new schedule. * &#x60;NOTHING&#x60; (**default**) will allow the payout to proceed..</param>
        /// <param name="reason">The reason for the payout schedule update. &gt; This field is required when the &#x60;schedule&#x60; parameter is set to &#x60;HOLD&#x60;..</param>
        /// <param name="schedule">The payout schedule to which the account is to be updated. Permitted values: &#x60;DEFAULT&#x60;, &#x60;HOLD&#x60;, &#x60;DAILY&#x60;, &#x60;WEEKLY&#x60;, &#x60;MONTHLY&#x60;. &#x60;HOLD&#x60; will prevent scheduled payouts from happening but will still allow manual payouts to occur. (required).</param>
        public UpdatePayoutScheduleRequest(ActionEnum? action = default(ActionEnum?), string reason = default(string), ScheduleEnum schedule = default(ScheduleEnum))
        {
            this.Schedule = schedule;
            this.Action = action;
            this.Reason = reason;
        }
        

        /// <summary>
        /// The reason for the payout schedule update. &gt; This field is required when the &#x60;schedule&#x60; parameter is set to &#x60;HOLD&#x60;.
        /// </summary>
        /// <value>The reason for the payout schedule update. &gt; This field is required when the &#x60;schedule&#x60; parameter is set to &#x60;HOLD&#x60;.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePayoutScheduleRequest {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePayoutScheduleRequest);
        }

        /// <summary>
        /// Returns true if UpdatePayoutScheduleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdatePayoutScheduleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatePayoutScheduleRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    this.Schedule.Equals(input.Schedule)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
