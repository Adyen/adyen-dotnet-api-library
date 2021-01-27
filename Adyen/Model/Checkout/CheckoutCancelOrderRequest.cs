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
    /// CheckoutCancelOrderRequest
    /// </summary>
    [DataContract]
    public partial class CheckoutCancelOrderRequest : IEquatable<CheckoutCancelOrderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutCancelOrderRequest" /> class.
        /// </summary>
        /// <param name="merchantAccount">The merchant account identifier that orderData belongs to. (required).</param>
        /// <param name="order">order (required).</param>
        public CheckoutCancelOrderRequest(string merchantAccount = default(string),
            CheckoutOrder order = default(CheckoutOrder))
        {
            // to ensure "merchantAccount" is required (not null)
            if (merchantAccount == null)
            {
                throw new InvalidDataException(
                    "merchantAccount is a required property for CheckoutCancelOrderRequest and cannot be null");
            }
            else
            {
                this.MerchantAccount = merchantAccount;
            }
            // to ensure "order" is required (not null)
            if (order == null)
            {
                throw new InvalidDataException(
                    "order is a required property for CheckoutCancelOrderRequest and cannot be null");
            }
            else
            {
                this.Order = order;
            }
        }

        /// <summary>
        /// The merchant account identifier that orderData belongs to.
        /// </summary>
        /// <value>The merchant account identifier that orderData belongs to.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public CheckoutOrder Order { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckoutCancelOrderRequest {\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(input as CheckoutCancelOrderRequest);
        }

        /// <summary>
        /// Returns true if CheckoutCancelOrderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutCancelOrderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutCancelOrderRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount)
                ) &&
                (
                    this.Order == input.Order ||
                    this.Order != null &&
                    this.Order.Equals(input.Order)
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
                if (this.MerchantAccount != null)
                    hashCode = hashCode * 59 + this.MerchantAccount.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
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