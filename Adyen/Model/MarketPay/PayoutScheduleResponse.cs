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
    /// PayoutScheduleResponse
    /// </summary>
    [DataContract]
        public partial class PayoutScheduleResponse :  IEquatable<PayoutScheduleResponse>, IValidatableObject
    {
        /// <summary>
        /// The payout schedule of the account. &gt;Permitted values: &#x60;DEFAULT&#x60;, &#x60;HOLD&#x60;, &#x60;DAILY&#x60;, &#x60;WEEKLY&#x60;, &#x60;MONTHLY&#x60;.
        /// </summary>
        /// <value>The payout schedule of the account. &gt;Permitted values: &#x60;DEFAULT&#x60;, &#x60;HOLD&#x60;, &#x60;DAILY&#x60;, &#x60;WEEKLY&#x60;, &#x60;MONTHLY&#x60;.</value>
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
        /// The payout schedule of the account. &gt;Permitted values: &#x60;DEFAULT&#x60;, &#x60;HOLD&#x60;, &#x60;DAILY&#x60;, &#x60;WEEKLY&#x60;, &#x60;MONTHLY&#x60;.
        /// </summary>
        /// <value>The payout schedule of the account. &gt;Permitted values: &#x60;DEFAULT&#x60;, &#x60;HOLD&#x60;, &#x60;DAILY&#x60;, &#x60;WEEKLY&#x60;, &#x60;MONTHLY&#x60;.</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public ScheduleEnum Schedule { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutScheduleResponse" /> class.
        /// </summary>
        /// <param name="nextScheduledPayout">The date of the next scheduled payout. (required).</param>
        /// <param name="schedule">The payout schedule of the account. &gt;Permitted values: &#x60;DEFAULT&#x60;, &#x60;HOLD&#x60;, &#x60;DAILY&#x60;, &#x60;WEEKLY&#x60;, &#x60;MONTHLY&#x60;. (required).</param>
        public PayoutScheduleResponse(DateTime? nextScheduledPayout = default(DateTime?), ScheduleEnum schedule = default(ScheduleEnum))
        {
            // to ensure "schedule" is required (not null)
            if (schedule == null)
            {
                throw new InvalidDataException("schedule is a required property for PayoutScheduleResponse and cannot be null");
            }
            else
            {
                this.Schedule = schedule;
            }
            this.NextScheduledPayout = nextScheduledPayout;
        }
        
        /// <summary>
        /// The date of the next scheduled payout.
        /// </summary>
        /// <value>The date of the next scheduled payout.</value>
        [DataMember(Name="nextScheduledPayout", EmitDefaultValue=false)]
        public DateTime? NextScheduledPayout { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayoutScheduleResponse {\n");
            sb.Append("  NextScheduledPayout: ").Append(NextScheduledPayout).Append("\n");
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
            return this.Equals(input as PayoutScheduleResponse);
        }

        /// <summary>
        /// Returns true if PayoutScheduleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutScheduleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutScheduleResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NextScheduledPayout == input.NextScheduledPayout ||
                    (this.NextScheduledPayout != null &&
                    this.NextScheduledPayout.Equals(input.NextScheduledPayout))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
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
                if (this.NextScheduledPayout != null)
                    hashCode = hashCode * 59 + this.NextScheduledPayout.GetHashCode();
                if (this.Schedule != null)
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
