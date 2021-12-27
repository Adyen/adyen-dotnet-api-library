#region License
/*
 *                       ######
 *                       ######
 * ############    ####( ######  #####. ######  ############   ############
 * #############  #####( ######  #####. ######  #############  #############
 *        ######  #####( ######  #####. ######  #####  ######  #####  ######
 * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
 * ###### ######  #####( ######  #####. ######  #####          #####  ######
 * #############  #############  #############  #############  #####  ######
 *  ############   ############  #############   ############  #####  ######
 *                                      ######
 *                               #############
 *                               ############
 *
 * Adyen Dotnet API Library
 *
 * Copyright (c) 2021 Adyen B.V.
 * This file is open source and available under the MIT license.
 * See the LICENSE file for more info.
 */
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
    /// CreatePaymentReversalRequest
    /// </summary>
    [DataContract]
    public partial class CreatePaymentReversalRequest : IEquatable<CreatePaymentReversalRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentReversalRequest" /> class.
        /// </summary>
        /// <param name="merchantAccount">The merchant account that is used to process the payment. (required).</param>
        /// <param name="reference">Your reference for the reversal request. Maximum length: 80 characters..</param>
        public CreatePaymentReversalRequest(string merchantAccount = default(string),
            string reference = default(string))
        {
            this.MerchantAccount = merchantAccount;
            this.Reference = reference;
        }

        /// <summary>
        /// The merchant account that is used to process the payment.
        /// </summary>
        /// <value>The merchant account that is used to process the payment.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Your reference for the reversal request. Maximum length: 80 characters.
        /// </summary>
        /// <value>Your reference for the reversal request. Maximum length: 80 characters.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePaymentReversalRequest {\n");
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
            return this.Equals(input as CreatePaymentReversalRequest);
        }

        /// <summary>
        /// Returns true if CreatePaymentReversalRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatePaymentReversalRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePaymentReversalRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                     this.MerchantAccount.Equals(input.MerchantAccount))
                ) &&
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                     this.Reference.Equals(input.Reference))
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