/*
* Classic Platforms - Notifications
*
*
* The version of the OpenAPI document: 6
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.PlatformsWebhooks
{
    /// <summary>
    /// PayoutScheduleResponse
    /// </summary>
    [DataContract(Name = "PayoutScheduleResponse")]
    public partial class PayoutScheduleResponse : IEquatable<PayoutScheduleResponse>, IValidatableObject
    {
        /// <summary>
        /// The payout schedule of the account. Permitted values: &#x60;DEFAULT&#x60;, &#x60;DAILY&#x60;, &#x60;DAILY_US&#x60;, &#x60;DAILY_EU&#x60;, &#x60;DAILY_AU&#x60;, &#x60;DAILY_SG&#x60;, &#x60;WEEKLY&#x60;, &#x60;WEEKLY_ON_TUE_FRI_MIDNIGHT&#x60;, &#x60;BIWEEKLY_ON_1ST_AND_15TH_AT_MIDNIGHT&#x60;, &#x60;MONTHLY&#x60;, &#x60;HOLD&#x60;.
        /// </summary>
        /// <value>The payout schedule of the account. Permitted values: &#x60;DEFAULT&#x60;, &#x60;DAILY&#x60;, &#x60;DAILY_US&#x60;, &#x60;DAILY_EU&#x60;, &#x60;DAILY_AU&#x60;, &#x60;DAILY_SG&#x60;, &#x60;WEEKLY&#x60;, &#x60;WEEKLY_ON_TUE_FRI_MIDNIGHT&#x60;, &#x60;BIWEEKLY_ON_1ST_AND_15TH_AT_MIDNIGHT&#x60;, &#x60;MONTHLY&#x60;, &#x60;HOLD&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScheduleEnum
        {
            /// <summary>
            /// Enum BIWEEKLYON1STAND15THATMIDNIGHT for value: BIWEEKLY_ON_1ST_AND_15TH_AT_MIDNIGHT
            /// </summary>
            [EnumMember(Value = "BIWEEKLY_ON_1ST_AND_15TH_AT_MIDNIGHT")]
            BIWEEKLYON1STAND15THATMIDNIGHT = 1,

            /// <summary>
            /// Enum DAILY for value: DAILY
            /// </summary>
            [EnumMember(Value = "DAILY")]
            DAILY = 2,

            /// <summary>
            /// Enum DAILYAU for value: DAILY_AU
            /// </summary>
            [EnumMember(Value = "DAILY_AU")]
            DAILYAU = 3,

            /// <summary>
            /// Enum DAILYEU for value: DAILY_EU
            /// </summary>
            [EnumMember(Value = "DAILY_EU")]
            DAILYEU = 4,

            /// <summary>
            /// Enum DAILYSG for value: DAILY_SG
            /// </summary>
            [EnumMember(Value = "DAILY_SG")]
            DAILYSG = 5,

            /// <summary>
            /// Enum DAILYUS for value: DAILY_US
            /// </summary>
            [EnumMember(Value = "DAILY_US")]
            DAILYUS = 6,

            /// <summary>
            /// Enum HOLD for value: HOLD
            /// </summary>
            [EnumMember(Value = "HOLD")]
            HOLD = 7,

            /// <summary>
            /// Enum MONTHLY for value: MONTHLY
            /// </summary>
            [EnumMember(Value = "MONTHLY")]
            MONTHLY = 8,

            /// <summary>
            /// Enum WEEKLY for value: WEEKLY
            /// </summary>
            [EnumMember(Value = "WEEKLY")]
            WEEKLY = 9,

            /// <summary>
            /// Enum WEEKLYMONTOFRIAU for value: WEEKLY_MON_TO_FRI_AU
            /// </summary>
            [EnumMember(Value = "WEEKLY_MON_TO_FRI_AU")]
            WEEKLYMONTOFRIAU = 10,

            /// <summary>
            /// Enum WEEKLYMONTOFRIEU for value: WEEKLY_MON_TO_FRI_EU
            /// </summary>
            [EnumMember(Value = "WEEKLY_MON_TO_FRI_EU")]
            WEEKLYMONTOFRIEU = 11,

            /// <summary>
            /// Enum WEEKLYMONTOFRIUS for value: WEEKLY_MON_TO_FRI_US
            /// </summary>
            [EnumMember(Value = "WEEKLY_MON_TO_FRI_US")]
            WEEKLYMONTOFRIUS = 12,

            /// <summary>
            /// Enum WEEKLYONTUEFRIMIDNIGHT for value: WEEKLY_ON_TUE_FRI_MIDNIGHT
            /// </summary>
            [EnumMember(Value = "WEEKLY_ON_TUE_FRI_MIDNIGHT")]
            WEEKLYONTUEFRIMIDNIGHT = 13,

            /// <summary>
            /// Enum WEEKLYSUNTOTHUAU for value: WEEKLY_SUN_TO_THU_AU
            /// </summary>
            [EnumMember(Value = "WEEKLY_SUN_TO_THU_AU")]
            WEEKLYSUNTOTHUAU = 14,

            /// <summary>
            /// Enum WEEKLYSUNTOTHUUS for value: WEEKLY_SUN_TO_THU_US
            /// </summary>
            [EnumMember(Value = "WEEKLY_SUN_TO_THU_US")]
            WEEKLYSUNTOTHUUS = 15

        }


        /// <summary>
        /// The payout schedule of the account. Permitted values: &#x60;DEFAULT&#x60;, &#x60;DAILY&#x60;, &#x60;DAILY_US&#x60;, &#x60;DAILY_EU&#x60;, &#x60;DAILY_AU&#x60;, &#x60;DAILY_SG&#x60;, &#x60;WEEKLY&#x60;, &#x60;WEEKLY_ON_TUE_FRI_MIDNIGHT&#x60;, &#x60;BIWEEKLY_ON_1ST_AND_15TH_AT_MIDNIGHT&#x60;, &#x60;MONTHLY&#x60;, &#x60;HOLD&#x60;.
        /// </summary>
        /// <value>The payout schedule of the account. Permitted values: &#x60;DEFAULT&#x60;, &#x60;DAILY&#x60;, &#x60;DAILY_US&#x60;, &#x60;DAILY_EU&#x60;, &#x60;DAILY_AU&#x60;, &#x60;DAILY_SG&#x60;, &#x60;WEEKLY&#x60;, &#x60;WEEKLY_ON_TUE_FRI_MIDNIGHT&#x60;, &#x60;BIWEEKLY_ON_1ST_AND_15TH_AT_MIDNIGHT&#x60;, &#x60;MONTHLY&#x60;, &#x60;HOLD&#x60;.</value>
        [DataMember(Name = "schedule", EmitDefaultValue = false)]
        public ScheduleEnum? Schedule { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutScheduleResponse" /> class.
        /// </summary>
        /// <param name="nextScheduledPayout">The date of the next scheduled payout..</param>
        /// <param name="schedule">The payout schedule of the account. Permitted values: &#x60;DEFAULT&#x60;, &#x60;DAILY&#x60;, &#x60;DAILY_US&#x60;, &#x60;DAILY_EU&#x60;, &#x60;DAILY_AU&#x60;, &#x60;DAILY_SG&#x60;, &#x60;WEEKLY&#x60;, &#x60;WEEKLY_ON_TUE_FRI_MIDNIGHT&#x60;, &#x60;BIWEEKLY_ON_1ST_AND_15TH_AT_MIDNIGHT&#x60;, &#x60;MONTHLY&#x60;, &#x60;HOLD&#x60;..</param>
        public PayoutScheduleResponse(DateTime nextScheduledPayout = default(DateTime), ScheduleEnum? schedule = default(ScheduleEnum?))
        {
            this.NextScheduledPayout = nextScheduledPayout;
            this.Schedule = schedule;
        }

        /// <summary>
        /// The date of the next scheduled payout.
        /// </summary>
        /// <value>The date of the next scheduled payout.</value>
        [DataMember(Name = "nextScheduledPayout", EmitDefaultValue = false)]
        public DateTime NextScheduledPayout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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
            {
                return false;
            }
            return 
                (
                    this.NextScheduledPayout == input.NextScheduledPayout ||
                    (this.NextScheduledPayout != null &&
                    this.NextScheduledPayout.Equals(input.NextScheduledPayout))
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
                if (this.NextScheduledPayout != null)
                {
                    hashCode = (hashCode * 59) + this.NextScheduledPayout.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Schedule.GetHashCode();
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
