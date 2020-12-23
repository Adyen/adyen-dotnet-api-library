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
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// ResponseAdditionalDataPayPal
    /// </summary>
    [DataContract]
    public partial class ResponseAdditionalDataPayPal : IEquatable<ResponseAdditionalDataPayPal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataPayPal" /> class.
        /// </summary>
        /// <param name="paypalEmail">The buyer&#x27;s PayPal account email address.  Example: paypaltest@adyen.com.</param>
        /// <param name="paypalPayerId">The buyer&#x27;s PayPal ID.  Example: LF5HCWWBRV2KL.</param>
        /// <param name="paypalPayerResidenceCountry">The buyer&#x27;s country of residence.  Example: NL.</param>
        /// <param name="paypalPayerStatus">The status of the buyer&#x27;s PayPal account.  Example: unverified.</param>
        /// <param name="paypalProtectionEligibility">The eligibility for PayPal Seller Protection for this payment.  Example: Ineligible.</param>
        public ResponseAdditionalDataPayPal(string paypalEmail = default(string),
            string paypalPayerId = default(string), string paypalPayerResidenceCountry = default(string),
            string paypalPayerStatus = default(string), string paypalProtectionEligibility = default(string))
        {
            this.PaypalEmail = paypalEmail;
            this.PaypalPayerId = paypalPayerId;
            this.PaypalPayerResidenceCountry = paypalPayerResidenceCountry;
            this.PaypalPayerStatus = paypalPayerStatus;
            this.PaypalProtectionEligibility = paypalProtectionEligibility;
        }

        /// <summary>
        /// The buyer&#x27;s PayPal account email address.  Example: paypaltest@adyen.com
        /// </summary>
        /// <value>The buyer&#x27;s PayPal account email address.  Example: paypaltest@adyen.com</value>
        [DataMember(Name = "paypalEmail", EmitDefaultValue = false)]
        public string PaypalEmail { get; set; }

        /// <summary>
        /// The buyer&#x27;s PayPal ID.  Example: LF5HCWWBRV2KL
        /// </summary>
        /// <value>The buyer&#x27;s PayPal ID.  Example: LF5HCWWBRV2KL</value>
        [DataMember(Name = "paypalPayerId", EmitDefaultValue = false)]
        public string PaypalPayerId { get; set; }

        /// <summary>
        /// The buyer&#x27;s country of residence.  Example: NL
        /// </summary>
        /// <value>The buyer&#x27;s country of residence.  Example: NL</value>
        [DataMember(Name = "paypalPayerResidenceCountry", EmitDefaultValue = false)]
        public string PaypalPayerResidenceCountry { get; set; }

        /// <summary>
        /// The status of the buyer&#x27;s PayPal account.  Example: unverified
        /// </summary>
        /// <value>The status of the buyer&#x27;s PayPal account.  Example: unverified</value>
        [DataMember(Name = "paypalPayerStatus", EmitDefaultValue = false)]
        public string PaypalPayerStatus { get; set; }

        /// <summary>
        /// The eligibility for PayPal Seller Protection for this payment.  Example: Ineligible
        /// </summary>
        /// <value>The eligibility for PayPal Seller Protection for this payment.  Example: Ineligible</value>
        [DataMember(Name = "paypalProtectionEligibility", EmitDefaultValue = false)]
        public string PaypalProtectionEligibility { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseAdditionalDataPayPal {\n");
            sb.Append("  PaypalEmail: ").Append(PaypalEmail).Append("\n");
            sb.Append("  PaypalPayerId: ").Append(PaypalPayerId).Append("\n");
            sb.Append("  PaypalPayerResidenceCountry: ").Append(PaypalPayerResidenceCountry).Append("\n");
            sb.Append("  PaypalPayerStatus: ").Append(PaypalPayerStatus).Append("\n");
            sb.Append("  PaypalProtectionEligibility: ").Append(PaypalProtectionEligibility).Append("\n");
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
            return this.Equals(input as ResponseAdditionalDataPayPal);
        }

        /// <summary>
        /// Returns true if ResponseAdditionalDataPayPal instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseAdditionalDataPayPal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseAdditionalDataPayPal input)
        {
            if (input == null)
                return false;

            return
                (
                    this.PaypalEmail == input.PaypalEmail ||
                    this.PaypalEmail != null &&
                    this.PaypalEmail.Equals(input.PaypalEmail)
                ) &&
                (
                    this.PaypalPayerId == input.PaypalPayerId ||
                    this.PaypalPayerId != null &&
                    this.PaypalPayerId.Equals(input.PaypalPayerId)
                ) &&
                (
                    this.PaypalPayerResidenceCountry == input.PaypalPayerResidenceCountry ||
                    this.PaypalPayerResidenceCountry != null &&
                    this.PaypalPayerResidenceCountry.Equals(input.PaypalPayerResidenceCountry)
                ) &&
                (
                    this.PaypalPayerStatus == input.PaypalPayerStatus ||
                    this.PaypalPayerStatus != null &&
                    this.PaypalPayerStatus.Equals(input.PaypalPayerStatus)
                ) &&
                (
                    this.PaypalProtectionEligibility == input.PaypalProtectionEligibility ||
                    this.PaypalProtectionEligibility != null &&
                    this.PaypalProtectionEligibility.Equals(input.PaypalProtectionEligibility)
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
                if (this.PaypalEmail != null)
                    hashCode = hashCode * 59 + this.PaypalEmail.GetHashCode();
                if (this.PaypalPayerId != null)
                    hashCode = hashCode * 59 + this.PaypalPayerId.GetHashCode();
                if (this.PaypalPayerResidenceCountry != null)
                    hashCode = hashCode * 59 + this.PaypalPayerResidenceCountry.GetHashCode();
                if (this.PaypalPayerStatus != null)
                    hashCode = hashCode * 59 + this.PaypalPayerStatus.GetHashCode();
                if (this.PaypalProtectionEligibility != null)
                    hashCode = hashCode * 59 + this.PaypalProtectionEligibility.GetHashCode();
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