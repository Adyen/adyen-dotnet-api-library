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
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// CheckoutCreateOrderRequest
    /// </summary>
    [DataContract]
    public partial class CheckoutCreateOrderRequest : IEquatable<CheckoutCreateOrderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutCreateOrderRequest" /> class.
        /// </summary>
        /// <param name="amount">amount (required).</param>
        /// <param name="expiresAt">The date that order expires; e.g. 2019-03-23T12:25:28Z. If not provided, the default expiry duration is 1 day..</param>
        /// <param name="merchantAccount">The merchant account identifier, with which you want to process the order. (required).</param>
        /// <param name="reference">A custom reference identifying the order..</param>
        public CheckoutCreateOrderRequest(Amount amount = default(Amount), string expiresAt = default(string),
            string merchantAccount = default(string), string reference = default(string))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException(
                    "amount is a required property for CheckoutCreateOrderRequest and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            // to ensure "merchantAccount" is required (not null)
            if (merchantAccount == null)
            {
                throw new InvalidDataException(
                    "merchantAccount is a required property for CheckoutCreateOrderRequest and cannot be null");
            }
            else
            {
                this.MerchantAccount = merchantAccount;
            }
            this.ExpiresAt = expiresAt;
            this.Reference = reference;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// The date that order expires; e.g. 2019-03-23T12:25:28Z. If not provided, the default expiry duration is 1 day.
        /// </summary>
        /// <value>The date that order expires; e.g. 2019-03-23T12:25:28Z. If not provided, the default expiry duration is 1 day.</value>
        [DataMember(Name = "expiresAt", EmitDefaultValue = false)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// The merchant account identifier, with which you want to process the order.
        /// </summary>
        /// <value>The merchant account identifier, with which you want to process the order.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// A custom reference identifying the order.
        /// </summary>
        /// <value>A custom reference identifying the order.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckoutCreateOrderRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
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
            return this.Equals(input as CheckoutCreateOrderRequest);
        }

        /// <summary>
        /// Returns true if CheckoutCreateOrderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutCreateOrderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutCreateOrderRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Amount == input.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(input.Amount)
                ) &&
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt)
                ) &&
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount)
                ) &&
                (
                    this.Reference == input.Reference ||
                    this.Reference != null &&
                    this.Reference.Equals(input.Reference)
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
                if (this.ExpiresAt != null)
                    hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                if (this.MerchantAccount != null)
                    hashCode = hashCode * 59 + this.MerchantAccount.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
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