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
    /// CreateAccountRequest
    /// </summary>
    [DataContract]
        public partial class CreateAccountRequest :  IEquatable<CreateAccountRequest>, IValidatableObject
    {
        /// <summary>
        /// The payout schedule of the prospective account. &gt;Permitted values: &#x60;DEFAULT&#x60;, &#x60;HOLD&#x60;, &#x60;DAILY&#x60;, &#x60;WEEKLY&#x60;, &#x60;MONTHLY&#x60;.
        /// </summary>
        /// <value>The payout schedule of the prospective account. &gt;Permitted values: &#x60;DEFAULT&#x60;, &#x60;HOLD&#x60;, &#x60;DAILY&#x60;, &#x60;WEEKLY&#x60;, &#x60;MONTHLY&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PayoutScheduleEnum
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
        /// The payout schedule of the prospective account. &gt;Permitted values: &#x60;DEFAULT&#x60;, &#x60;HOLD&#x60;, &#x60;DAILY&#x60;, &#x60;WEEKLY&#x60;, &#x60;MONTHLY&#x60;.
        /// </summary>
        /// <value>The payout schedule of the prospective account. &gt;Permitted values: &#x60;DEFAULT&#x60;, &#x60;HOLD&#x60;, &#x60;DAILY&#x60;, &#x60;WEEKLY&#x60;, &#x60;MONTHLY&#x60;.</value>
        [DataMember(Name="payoutSchedule", EmitDefaultValue=false)]
        public PayoutScheduleEnum? PayoutSchedule { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccountRequest" /> class.
        /// </summary>
        /// <param name="accountHolderCode">The code of Account Holder under which to create the account. (required).</param>
        /// <param name="description">A description of the account..</param>
        /// <param name="metadata">A set of key and value pairs for general use by the merchant. The keys do not have specific names and may be used for storing miscellaneous data as desired. &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs..</param>
        /// <param name="payoutSchedule">The payout schedule of the prospective account. &gt;Permitted values: &#x60;DEFAULT&#x60;, &#x60;HOLD&#x60;, &#x60;DAILY&#x60;, &#x60;WEEKLY&#x60;, &#x60;MONTHLY&#x60;..</param>
        /// <param name="payoutScheduleReason">The reason for the payout schedule choice. &gt;Required if the payoutSchedule is &#x60;HOLD&#x60;..</param>
        public CreateAccountRequest(string accountHolderCode = default(string), string description = default(string), Object metadata = default(Object), PayoutScheduleEnum? payoutSchedule = default(PayoutScheduleEnum?), string payoutScheduleReason = default(string))
        {
            // to ensure "accountHolderCode" is required (not null)
            if (accountHolderCode == null)
            {
                throw new InvalidDataException("accountHolderCode is a required property for CreateAccountRequest and cannot be null");
            }
            else
            {
                this.AccountHolderCode = accountHolderCode;
            }
            this.Description = description;
            this.Metadata = metadata;
            this.PayoutSchedule = payoutSchedule;
            this.PayoutScheduleReason = payoutScheduleReason;
        }
        
        /// <summary>
        /// The code of Account Holder under which to create the account.
        /// </summary>
        /// <value>The code of Account Holder under which to create the account.</value>
        [DataMember(Name="accountHolderCode", EmitDefaultValue=false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// A description of the account.
        /// </summary>
        /// <value>A description of the account.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A set of key and value pairs for general use by the merchant. The keys do not have specific names and may be used for storing miscellaneous data as desired. &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs.
        /// </summary>
        /// <value>A set of key and value pairs for general use by the merchant. The keys do not have specific names and may be used for storing miscellaneous data as desired. &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs.</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }


        /// <summary>
        /// The reason for the payout schedule choice. &gt;Required if the payoutSchedule is &#x60;HOLD&#x60;.
        /// </summary>
        /// <value>The reason for the payout schedule choice. &gt;Required if the payoutSchedule is &#x60;HOLD&#x60;.</value>
        [DataMember(Name="payoutScheduleReason", EmitDefaultValue=false)]
        public string PayoutScheduleReason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAccountRequest {\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  PayoutSchedule: ").Append(PayoutSchedule).Append("\n");
            sb.Append("  PayoutScheduleReason: ").Append(PayoutScheduleReason).Append("\n");
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
            return this.Equals(input as CreateAccountRequest);
        }

        /// <summary>
        /// Returns true if CreateAccountRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateAccountRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateAccountRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountHolderCode == input.AccountHolderCode ||
                    (this.AccountHolderCode != null &&
                    this.AccountHolderCode.Equals(input.AccountHolderCode))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.PayoutSchedule == input.PayoutSchedule ||
                    (this.PayoutSchedule != null &&
                    this.PayoutSchedule.Equals(input.PayoutSchedule))
                ) && 
                (
                    this.PayoutScheduleReason == input.PayoutScheduleReason ||
                    (this.PayoutScheduleReason != null &&
                    this.PayoutScheduleReason.Equals(input.PayoutScheduleReason))
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
                if (this.AccountHolderCode != null)
                    hashCode = hashCode * 59 + this.AccountHolderCode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.PayoutSchedule != null)
                    hashCode = hashCode * 59 + this.PayoutSchedule.GetHashCode();
                if (this.PayoutScheduleReason != null)
                    hashCode = hashCode * 59 + this.PayoutScheduleReason.GetHashCode();
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
