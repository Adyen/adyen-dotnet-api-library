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
//  Copyright (c) 2022 Adyen N.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// Mandate
    /// </summary>
    [DataContract]
    public partial class Mandate : IEquatable<Mandate>, IValidatableObject
    {
        /// <summary>
        /// The limitation rule of the billing amount.  Possible values:  * **max**: The transaction amount can not exceed the &#x60;amount&#x60;.   * **exact**: The transaction amount should be the same as the &#x60;amount&#x60;.  
        /// </summary>
        /// <value>The limitation rule of the billing amount.  Possible values:  * **max**: The transaction amount can not exceed the &#x60;amount&#x60;.   * **exact**: The transaction amount should be the same as the &#x60;amount&#x60;.  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AmountRuleEnum
        {
            /// <summary>
            /// Enum Max for value: max
            /// </summary>
            [EnumMember(Value = "max")] Max = 1,

            /// <summary>
            /// Enum Exact for value: exact
            /// </summary>
            [EnumMember(Value = "exact")] Exact = 2
        }

        /// <summary>
        /// The limitation rule of the billing amount.  Possible values:  * **max**: The transaction amount can not exceed the &#x60;amount&#x60;.   * **exact**: The transaction amount should be the same as the &#x60;amount&#x60;.  
        /// </summary>
        /// <value>The limitation rule of the billing amount.  Possible values:  * **max**: The transaction amount can not exceed the &#x60;amount&#x60;.   * **exact**: The transaction amount should be the same as the &#x60;amount&#x60;.  </value>
        [DataMember(Name = "amountRule", EmitDefaultValue = false)]
        public AmountRuleEnum? AmountRule { get; set; }

        /// <summary>
        /// The rule to specify the period, within which the recurring debit can happen, relative to the mandate recurring date.  Possible values:   * **on**: On a specific date.   * **before**:  Before and on a specific date.   * **after**: On and after a specific date.  
        /// </summary>
        /// <value>The rule to specify the period, within which the recurring debit can happen, relative to the mandate recurring date.  Possible values:   * **on**: On a specific date.   * **before**:  Before and on a specific date.   * **after**: On and after a specific date.  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BillingAttemptsRuleEnum
        {
            /// <summary>
            /// Enum On for value: on
            /// </summary>
            [EnumMember(Value = "on")] On = 1,

            /// <summary>
            /// Enum Before for value: before
            /// </summary>
            [EnumMember(Value = "before")] Before = 2,

            /// <summary>
            /// Enum After for value: after
            /// </summary>
            [EnumMember(Value = "after")] After = 3
        }

        /// <summary>
        /// The rule to specify the period, within which the recurring debit can happen, relative to the mandate recurring date.  Possible values:   * **on**: On a specific date.   * **before**:  Before and on a specific date.   * **after**: On and after a specific date.  
        /// </summary>
        /// <value>The rule to specify the period, within which the recurring debit can happen, relative to the mandate recurring date.  Possible values:   * **on**: On a specific date.   * **before**:  Before and on a specific date.   * **after**: On and after a specific date.  </value>
        [DataMember(Name = "billingAttemptsRule", EmitDefaultValue = false)]
        public BillingAttemptsRuleEnum? BillingAttemptsRule { get; set; }

        /// <summary>
        /// The frequency with which a shopper should be charged.  Possible values: **daily**, **weekly**, **biWeekly**, **monthly**, **quarterly**, **halfYearly**, **yearly**.
        /// </summary>
        /// <value>The frequency with which a shopper should be charged.  Possible values: **daily**, **weekly**, **biWeekly**, **monthly**, **quarterly**, **halfYearly**, **yearly**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FrequencyEnum
        {
            /// <summary>
            /// Enum Adhoc for value: adhoc
            /// </summary>
            [EnumMember(Value = "adhoc")] Adhoc = 1,

            /// <summary>
            /// Enum Daily for value: daily
            /// </summary>
            [EnumMember(Value = "daily")] Daily = 2,

            /// <summary>
            /// Enum Weekly for value: weekly
            /// </summary>
            [EnumMember(Value = "weekly")] Weekly = 3,

            /// <summary>
            /// Enum BiWeekly for value: biWeekly
            /// </summary>
            [EnumMember(Value = "biWeekly")] BiWeekly = 4,

            /// <summary>
            /// Enum Monthly for value: monthly
            /// </summary>
            [EnumMember(Value = "monthly")] Monthly = 5,

            /// <summary>
            /// Enum Quarterly for value: quarterly
            /// </summary>
            [EnumMember(Value = "quarterly")] Quarterly = 6,

            /// <summary>
            /// Enum HalfYearly for value: halfYearly
            /// </summary>
            [EnumMember(Value = "halfYearly")] HalfYearly = 7,

            /// <summary>
            /// Enum Yearly for value: yearly
            /// </summary>
            [EnumMember(Value = "yearly")] Yearly = 8
        }

        /// <summary>
        /// The frequency with which a shopper should be charged.  Possible values: **daily**, **weekly**, **biWeekly**, **monthly**, **quarterly**, **halfYearly**, **yearly**.
        /// </summary>
        /// <value>The frequency with which a shopper should be charged.  Possible values: **daily**, **weekly**, **biWeekly**, **monthly**, **quarterly**, **halfYearly**, **yearly**.</value>
        [DataMember(Name = "frequency", EmitDefaultValue = false)]
        public FrequencyEnum Frequency { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mandate" /> class.
        /// </summary>
        /// <param name="amount">The billing amount (in minor units) of the recurring transactions. (required).</param>
        /// <param name="amountRule">The limitation rule of the billing amount.  Possible values:  * **max**: The transaction amount can not exceed the &#x60;amount&#x60;.   * **exact**: The transaction amount should be the same as the &#x60;amount&#x60;.  .</param>
        /// <param name="billingAttemptsRule">The rule to specify the period, within which the recurring debit can happen, relative to the mandate recurring date.  Possible values:   * **on**: On a specific date.   * **before**:  Before and on a specific date.   * **after**: On and after a specific date.  .</param>
        /// <param name="billingDay">The number of the day, on which the recurring debit can happen. Should be within the same calendar month as the mandate recurring date.  Possible values: 1-31 based on the &#x60;frequency&#x60;..</param>
        /// <param name="endsAt">End date of the billing plan, in YYYY-MM-DD format. (required).</param>
        /// <param name="frequency">The frequency with which a shopper should be charged.  Possible values: **daily**, **weekly**, **biWeekly**, **monthly**, **quarterly**, **halfYearly**, **yearly**. (required).</param>
        /// <param name="remarks">The message shown by UPI to the shopper on the approval screen..</param>
        /// <param name="startsAt">Start date of the billing plan, in YYYY-MM-DD format. By default, the transaction date..</param>
        public Mandate(string amount = default(string), AmountRuleEnum? amountRule = default(AmountRuleEnum?),
            BillingAttemptsRuleEnum? billingAttemptsRule = default(BillingAttemptsRuleEnum?),
            string billingDay = default(string), string endsAt = default(string),
            FrequencyEnum frequency = default(FrequencyEnum), string remarks = default(string),
            string startsAt = default(string))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for Mandate and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }

            // to ensure "endsAt" is required (not null)
            if (endsAt == null)
            {
                throw new InvalidDataException("endsAt is a required property for Mandate and cannot be null");
            }
            else
            {
                this.EndsAt = endsAt;
            }

            // to ensure "frequency" is required (not null)
            if (frequency == null)
            {
                throw new InvalidDataException("frequency is a required property for Mandate and cannot be null");
            }
            else
            {
                this.Frequency = frequency;
            }

            this.AmountRule = amountRule;
            this.BillingAttemptsRule = billingAttemptsRule;
            this.BillingDay = billingDay;
            this.Remarks = remarks;
            this.StartsAt = startsAt;
        }

        /// <summary>
        /// The billing amount (in minor units) of the recurring transactions.
        /// </summary>
        /// <value>The billing amount (in minor units) of the recurring transactions.</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }


        /// <summary>
        /// The number of the day, on which the recurring debit can happen. Should be within the same calendar month as the mandate recurring date.  Possible values: 1-31 based on the &#x60;frequency&#x60;.
        /// </summary>
        /// <value>The number of the day, on which the recurring debit can happen. Should be within the same calendar month as the mandate recurring date.  Possible values: 1-31 based on the &#x60;frequency&#x60;.</value>
        [DataMember(Name = "billingDay", EmitDefaultValue = false)]
        public string BillingDay { get; set; }

        /// <summary>
        /// End date of the billing plan, in YYYY-MM-DD format.
        /// </summary>
        /// <value>End date of the billing plan, in YYYY-MM-DD format.</value>
        [DataMember(Name = "endsAt", EmitDefaultValue = false)]
        public string EndsAt { get; set; }


        /// <summary>
        /// The message shown by UPI to the shopper on the approval screen.
        /// </summary>
        /// <value>The message shown by UPI to the shopper on the approval screen.</value>
        [DataMember(Name = "remarks", EmitDefaultValue = false)]
        public string Remarks { get; set; }

        /// <summary>
        /// Start date of the billing plan, in YYYY-MM-DD format. By default, the transaction date.
        /// </summary>
        /// <value>Start date of the billing plan, in YYYY-MM-DD format. By default, the transaction date.</value>
        [DataMember(Name = "startsAt", EmitDefaultValue = false)]
        public string StartsAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Mandate {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AmountRule: ").Append(AmountRule).Append("\n");
            sb.Append("  BillingAttemptsRule: ").Append(BillingAttemptsRule).Append("\n");
            sb.Append("  BillingDay: ").Append(BillingDay).Append("\n");
            sb.Append("  EndsAt: ").Append(EndsAt).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  Remarks: ").Append(Remarks).Append("\n");
            sb.Append("  StartsAt: ").Append(StartsAt).Append("\n");
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
            return this.Equals(input as Mandate);
        }

        /// <summary>
        /// Returns true if Mandate instances are equal
        /// </summary>
        /// <param name="input">Instance of Mandate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Mandate input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                     this.Amount.Equals(input.Amount))
                ) &&
                (
                    this.AmountRule == input.AmountRule ||
                    (this.AmountRule != null &&
                     this.AmountRule.Equals(input.AmountRule))
                ) &&
                (
                    this.BillingAttemptsRule == input.BillingAttemptsRule ||
                    (this.BillingAttemptsRule != null &&
                     this.BillingAttemptsRule.Equals(input.BillingAttemptsRule))
                ) &&
                (
                    this.BillingDay == input.BillingDay ||
                    (this.BillingDay != null &&
                     this.BillingDay.Equals(input.BillingDay))
                ) &&
                (
                    this.EndsAt == input.EndsAt ||
                    (this.EndsAt != null &&
                     this.EndsAt.Equals(input.EndsAt))
                ) &&
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                     this.Frequency.Equals(input.Frequency))
                ) &&
                (
                    this.Remarks == input.Remarks ||
                    (this.Remarks != null &&
                     this.Remarks.Equals(input.Remarks))
                ) &&
                (
                    this.StartsAt == input.StartsAt ||
                    (this.StartsAt != null &&
                     this.StartsAt.Equals(input.StartsAt))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.AmountRule != null)
                    hashCode = hashCode * 59 + this.AmountRule.GetHashCode();
                if (this.BillingAttemptsRule != null)
                    hashCode = hashCode * 59 + this.BillingAttemptsRule.GetHashCode();
                if (this.BillingDay != null)
                    hashCode = hashCode * 59 + this.BillingDay.GetHashCode();
                if (this.EndsAt != null)
                    hashCode = hashCode * 59 + this.EndsAt.GetHashCode();
                if (this.Frequency != null)
                    hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.Remarks != null)
                    hashCode = hashCode * 59 + this.Remarks.GetHashCode();
                if (this.StartsAt != null)
                    hashCode = hashCode * 59 + this.StartsAt.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}