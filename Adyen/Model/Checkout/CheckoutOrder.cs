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
    /// CheckoutOrder
    /// </summary>
    [DataContract]
    public partial class CheckoutOrder : IEquatable<CheckoutOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutOrder" /> class.
        /// </summary>
        /// <param name="orderData">The encrypted order data. (required).</param>
        /// <param name="pspReference">The &#x60;pspReference&#x60; that belongs to the order. (required).</param>
        public CheckoutOrder(string orderData = default(string), string pspReference = default(string))
        {
            // to ensure "orderData" is required (not null)
            if (orderData == null)
            {
                throw new InvalidDataException("orderData is a required property for CheckoutOrder and cannot be null");
            }
            else
            {
                this.OrderData = orderData;
            }
            // to ensure "pspReference" is required (not null)
            if (pspReference == null)
            {
                throw new InvalidDataException(
                    "pspReference is a required property for CheckoutOrder and cannot be null");
            }
            else
            {
                this.PspReference = pspReference;
            }
        }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckoutOrder {\n");
            sb.Append("  OrderData: ").Append(OrderData).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
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
            return this.Equals(input as CheckoutOrder);
        }

        /// <summary>
        /// Returns true if CheckoutOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutOrder input)
        {
            if (input == null)
                return false;

            return
                (
                    this.OrderData == input.OrderData ||
                    this.OrderData != null &&
                    this.OrderData.Equals(input.OrderData)
                ) &&
                (
                    this.PspReference == input.PspReference ||
                    this.PspReference != null &&
                    this.PspReference.Equals(input.PspReference)
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
                if (this.OrderData != null)
                    hashCode = hashCode * 59 + this.OrderData.GetHashCode();
                if (this.PspReference != null)
                    hashCode = hashCode * 59 + this.PspReference.GetHashCode();
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