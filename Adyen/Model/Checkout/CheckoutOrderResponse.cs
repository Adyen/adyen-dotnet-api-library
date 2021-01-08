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
    /// CheckoutOrderResponse
    /// </summary>
    [DataContract]
    public partial class CheckoutOrderResponse : IEquatable<CheckoutOrderResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutOrderResponse" /> class.
        /// </summary>
        /// <param name="expiresAt">The expiry date for the order..</param>
        /// <param name="orderData">The encrypted order data..</param>
        /// <param name="pspReference">The &#x60;pspReference&#x60; that belongs to the order. (required).</param>
        /// <param name="reference">The merchant reference for the order..</param>
        /// <param name="remainingAmount">remainingAmount.</param>
        public CheckoutOrderResponse(string expiresAt = default(string), string orderData = default(string),
            string pspReference = default(string), string reference = default(string),
            Amount remainingAmount = default(Amount))
        {
            // to ensure "pspReference" is required (not null)
            if (pspReference == null)
            {
                throw new InvalidDataException(
                    "pspReference is a required property for CheckoutOrderResponse and cannot be null");
            }
            else
            {
                this.PspReference = pspReference;
            }
            this.ExpiresAt = expiresAt;
            this.OrderData = orderData;
            this.Reference = reference;
            this.RemainingAmount = remainingAmount;
        }

        /// <summary>
        /// The expiry date for the order.
        /// </summary>
        /// <value>The expiry date for the order.</value>
        [DataMember(Name = "expiresAt", EmitDefaultValue = false)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// The encrypted order data.
        /// </summary>
        /// <value>The encrypted order data.</value>
        [DataMember(Name = "orderData", EmitDefaultValue = false)]
        public string OrderData { get; set; }

        /// <summary>
        /// The &#x60;pspReference&#x60; that belongs to the order.
        /// </summary>
        /// <value>The &#x60;pspReference&#x60; that belongs to the order.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }

        /// <summary>
        /// The merchant reference for the order.
        /// </summary>
        /// <value>The merchant reference for the order.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets RemainingAmount
        /// </summary>
        [DataMember(Name = "remainingAmount", EmitDefaultValue = false)]
        public Amount RemainingAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckoutOrderResponse {\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  OrderData: ").Append(OrderData).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  RemainingAmount: ").Append(RemainingAmount).Append("\n");
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
            return this.Equals(input as CheckoutOrderResponse);
        }

        /// <summary>
        /// Returns true if CheckoutOrderResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutOrderResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutOrderResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt)
                ) &&
                (
                    this.OrderData == input.OrderData ||
                    this.OrderData != null &&
                    this.OrderData.Equals(input.OrderData)
                ) &&
                (
                    this.PspReference == input.PspReference ||
                    this.PspReference != null &&
                    this.PspReference.Equals(input.PspReference)
                ) &&
                (
                    this.Reference == input.Reference ||
                    this.Reference != null &&
                    this.Reference.Equals(input.Reference)
                ) &&
                (
                    this.RemainingAmount == input.RemainingAmount ||
                    this.RemainingAmount != null &&
                    this.RemainingAmount.Equals(input.RemainingAmount)
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
                if (this.ExpiresAt != null)
                    hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                if (this.OrderData != null)
                    hashCode = hashCode * 59 + this.OrderData.GetHashCode();
                if (this.PspReference != null)
                    hashCode = hashCode * 59 + this.PspReference.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.RemainingAmount != null)
                    hashCode = hashCode * 59 + this.RemainingAmount.GetHashCode();
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