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

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// AccountPayoutState
    /// </summary>
    [DataContract]
        public partial class AccountPayoutState :  IEquatable<AccountPayoutState>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountPayoutState" /> class.
        /// </summary>
        /// <param name="allowPayout">Indicates whether payouts are allowed. This field is the overarching payout status, and is the aggregate of multiple conditions (e.g., KYC status, disabled flag, etc). If this field is false, no payouts will be permitted for any of the account holder&#x27;s accounts. If this field is true, payouts will be permitted for any of the account holder&#x27;s accounts. (required).</param>
        /// <param name="disableReason">The reason why payouts (to all of the account holder&#x27;s accounts) have been disabled (by the platform). If the &#x60;disabled&#x60; field is true, this field can be used to explain why. (required).</param>
        /// <param name="disabled">Indicates whether payouts have been disabled (by the platform) for all of the account holder&#x27;s accounts. A platform may enable and disable this field at their discretion. If this field is true, &#x60;allowPayout&#x60; will be false and no payouts will be permitted for any of the account holder&#x27;s accounts. If this field is false, &#x60;allowPayout&#x60; may or may not be enabled, depending on other factors. (required).</param>
        /// <param name="notAllowedReason">The reason why payouts (to all of the account holder&#x27;s accounts) have been disabled (by Adyen). If payouts have been disabled by Adyen, this field will explain why. If this field is blank, payouts have not been disabled by Adyen. (required).</param>
        /// <param name="payoutLimit">payoutLimit (required).</param>
        /// <param name="tierNumber">The payout tier that the account holder occupies. (required).</param>
        public AccountPayoutState(bool? allowPayout = default(bool?), string disableReason = default(string), bool? disabled = default(bool?), string notAllowedReason = default(string), Amount payoutLimit = default(Amount), int? tierNumber = default(int?))
        {
            // to ensure "allowPayout" is required (not null)
            if (allowPayout == null)
            {
                throw new InvalidDataException("allowPayout is a required property for AccountPayoutState and cannot be null");
            }
            else
            {
                this.AllowPayout = allowPayout;
            }
            // to ensure "disabled" is required (not null)
            if (disabled == null)
            {
                throw new InvalidDataException("disabled is a required property for AccountPayoutState and cannot be null");
            }
            else
            {
                this.Disabled = disabled;
            }
           
            this.NotAllowedReason = notAllowedReason;
            this.TierNumber = tierNumber;
            this.PayoutLimit = payoutLimit;
            this.DisableReason = disableReason;
        }
        
        /// <summary>
        /// Indicates whether payouts are allowed. This field is the overarching payout status, and is the aggregate of multiple conditions (e.g., KYC status, disabled flag, etc). If this field is false, no payouts will be permitted for any of the account holder&#x27;s accounts. If this field is true, payouts will be permitted for any of the account holder&#x27;s accounts.
        /// </summary>
        /// <value>Indicates whether payouts are allowed. This field is the overarching payout status, and is the aggregate of multiple conditions (e.g., KYC status, disabled flag, etc). If this field is false, no payouts will be permitted for any of the account holder&#x27;s accounts. If this field is true, payouts will be permitted for any of the account holder&#x27;s accounts.</value>
        [DataMember(Name="allowPayout", EmitDefaultValue=false)]
        public bool? AllowPayout { get; set; }

        /// <summary>
        /// The reason why payouts (to all of the account holder&#x27;s accounts) have been disabled (by the platform). If the &#x60;disabled&#x60; field is true, this field can be used to explain why.
        /// </summary>
        /// <value>The reason why payouts (to all of the account holder&#x27;s accounts) have been disabled (by the platform). If the &#x60;disabled&#x60; field is true, this field can be used to explain why.</value>
        [DataMember(Name="disableReason", EmitDefaultValue=false)]
        public string DisableReason { get; set; }

        /// <summary>
        /// Indicates whether payouts have been disabled (by the platform) for all of the account holder&#x27;s accounts. A platform may enable and disable this field at their discretion. If this field is true, &#x60;allowPayout&#x60; will be false and no payouts will be permitted for any of the account holder&#x27;s accounts. If this field is false, &#x60;allowPayout&#x60; may or may not be enabled, depending on other factors.
        /// </summary>
        /// <value>Indicates whether payouts have been disabled (by the platform) for all of the account holder&#x27;s accounts. A platform may enable and disable this field at their discretion. If this field is true, &#x60;allowPayout&#x60; will be false and no payouts will be permitted for any of the account holder&#x27;s accounts. If this field is false, &#x60;allowPayout&#x60; may or may not be enabled, depending on other factors.</value>
        [DataMember(Name="disabled", EmitDefaultValue=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// The reason why payouts (to all of the account holder&#x27;s accounts) have been disabled (by Adyen). If payouts have been disabled by Adyen, this field will explain why. If this field is blank, payouts have not been disabled by Adyen.
        /// </summary>
        /// <value>The reason why payouts (to all of the account holder&#x27;s accounts) have been disabled (by Adyen). If payouts have been disabled by Adyen, this field will explain why. If this field is blank, payouts have not been disabled by Adyen.</value>
        [DataMember(Name="notAllowedReason", EmitDefaultValue=false)]
        public string NotAllowedReason { get; set; }

        /// <summary>
        /// Gets or Sets PayoutLimit
        /// </summary>
        [DataMember(Name="payoutLimit", EmitDefaultValue=false)]
        public Amount PayoutLimit { get; set; }

        /// <summary>
        /// The payout tier that the account holder occupies.
        /// </summary>
        /// <value>The payout tier that the account holder occupies.</value>
        [DataMember(Name="tierNumber", EmitDefaultValue=false)]
        public int? TierNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountPayoutState {\n");
            sb.Append("  AllowPayout: ").Append(AllowPayout).Append("\n");
            sb.Append("  DisableReason: ").Append(DisableReason).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  NotAllowedReason: ").Append(NotAllowedReason).Append("\n");
            sb.Append("  PayoutLimit: ").Append(PayoutLimit).Append("\n");
            sb.Append("  TierNumber: ").Append(TierNumber).Append("\n");
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
            return this.Equals(input as AccountPayoutState);
        }

        /// <summary>
        /// Returns true if AccountPayoutState instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountPayoutState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountPayoutState input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowPayout == input.AllowPayout ||
                    (this.AllowPayout != null &&
                    this.AllowPayout.Equals(input.AllowPayout))
                ) && 
                (
                    this.DisableReason == input.DisableReason ||
                    (this.DisableReason != null &&
                    this.DisableReason.Equals(input.DisableReason))
                ) && 
                (
                    this.Disabled == input.Disabled ||
                    (this.Disabled != null &&
                    this.Disabled.Equals(input.Disabled))
                ) && 
                (
                    this.NotAllowedReason == input.NotAllowedReason ||
                    (this.NotAllowedReason != null &&
                    this.NotAllowedReason.Equals(input.NotAllowedReason))
                ) && 
                (
                    this.PayoutLimit == input.PayoutLimit ||
                    (this.PayoutLimit != null &&
                    ((Object) this.PayoutLimit).Equals(input.PayoutLimit))
                ) && 
                (
                    this.TierNumber == input.TierNumber ||
                    (this.TierNumber != null &&
                    this.TierNumber.Equals(input.TierNumber))
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
                if (this.AllowPayout != null)
                    hashCode = hashCode * 59 + this.AllowPayout.GetHashCode();
                if (this.DisableReason != null)
                    hashCode = hashCode * 59 + this.DisableReason.GetHashCode();
                if (this.Disabled != null)
                    hashCode = hashCode * 59 + this.Disabled.GetHashCode();
                if (this.NotAllowedReason != null)
                    hashCode = hashCode * 59 + this.NotAllowedReason.GetHashCode();
                if (this.PayoutLimit != null)
                    hashCode = hashCode * 59 + this.PayoutLimit.GetHashCode();
                if (this.TierNumber != null)
                    hashCode = hashCode * 59 + this.TierNumber.GetHashCode();
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
