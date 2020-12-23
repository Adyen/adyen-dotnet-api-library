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
    /// CheckoutCancelOrderResponse
    /// </summary>
    [DataContract]
    public partial class CheckoutCancelOrderResponse : IEquatable<CheckoutCancelOrderResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutCancelOrderResponse" /> class.
        /// </summary>
        /// <param name="pspReference">A unique reference of the cancellation request. (required).</param>
        /// <param name="resultCode">The result of the cancellation request. (required).</param>
        public CheckoutCancelOrderResponse(string pspReference = default(string), string resultCode = default(string))
        {
            // to ensure "pspReference" is required (not null)
            if (pspReference == null)
            {
                throw new InvalidDataException(
                    "pspReference is a required property for CheckoutCancelOrderResponse and cannot be null");
            }
            else
            {
                this.PspReference = pspReference;
            }
            // to ensure "resultCode" is required (not null)
            if (resultCode == null)
            {
                throw new InvalidDataException(
                    "resultCode is a required property for CheckoutCancelOrderResponse and cannot be null");
            }
            else
            {
                this.ResultCode = resultCode;
            }
        }

        /// <summary>
        /// A unique reference of the cancellation request.
        /// </summary>
        /// <value>A unique reference of the cancellation request.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }

        /// <summary>
        /// The result of the cancellation request.
        /// </summary>
        /// <value>The result of the cancellation request.</value>
        [DataMember(Name = "resultCode", EmitDefaultValue = false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckoutCancelOrderResponse {\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
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
            return this.Equals(input as CheckoutCancelOrderResponse);
        }

        /// <summary>
        /// Returns true if CheckoutCancelOrderResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutCancelOrderResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutCancelOrderResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.PspReference == input.PspReference ||
                    this.PspReference != null &&
                    this.PspReference.Equals(input.PspReference)
                ) &&
                (
                    this.ResultCode == input.ResultCode ||
                    this.ResultCode != null &&
                    this.ResultCode.Equals(input.ResultCode)
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
                if (this.PspReference != null)
                    hashCode = hashCode * 59 + this.PspReference.GetHashCode();
                if (this.ResultCode != null)
                    hashCode = hashCode * 59 + this.ResultCode.GetHashCode();
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