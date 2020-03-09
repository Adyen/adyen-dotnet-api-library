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
    /// RefundFundsTransferRequest
    /// </summary>
    [DataContract]
    public class RefundFundsTransferRequest : IEquatable<RefundFundsTransferRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundFundsTransferRequest" /> class.
        /// </summary>
        /// <param name="amount">amount (required).</param>
        /// <param name="merchantReference">A value that can be supplied at the discretion of the executing user in order to link multiple transactions to one another..</param>
        /// <param name="originalReference">A PSP reference of the original fund transfer. (required).</param>
        public RefundFundsTransferRequest(Amount amount = default(Amount), string merchantReference = default(string), string originalReference = default(string))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for RefundFundsTransferRequest and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            // to ensure "originalReference" is required (not null)
            if (originalReference == null)
            {
                throw new InvalidDataException("originalReference is a required property for RefundFundsTransferRequest and cannot be null");
            }
            else
            {
                this.OriginalReference = originalReference;
            }
            this.MerchantReference = merchantReference;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// A value that can be supplied at the discretion of the executing user in order to link multiple transactions to one another.
        /// </summary>
        /// <value>A value that can be supplied at the discretion of the executing user in order to link multiple transactions to one another.</value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// A PSP reference of the original fund transfer.
        /// </summary>
        /// <value>A PSP reference of the original fund transfer.</value>
        [DataMember(Name = "originalReference", EmitDefaultValue = false)]
        public string OriginalReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefundFundsTransferRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  OriginalReference: ").Append(OriginalReference).Append("\n");
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
            return this.Equals(input as RefundFundsTransferRequest);
        }

        /// <summary>
        /// Returns true if RefundFundsTransferRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RefundFundsTransferRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefundFundsTransferRequest input)
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
                    this.MerchantReference == input.MerchantReference ||
                    (this.MerchantReference != null &&
                    this.MerchantReference.Equals(input.MerchantReference))
                ) &&
                (
                    this.OriginalReference == input.OriginalReference ||
                    (this.OriginalReference != null &&
                    this.OriginalReference.Equals(input.OriginalReference))
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
                if (this.MerchantReference != null)
                    hashCode = hashCode * 59 + this.MerchantReference.GetHashCode();
                if (this.OriginalReference != null)
                    hashCode = hashCode * 59 + this.OriginalReference.GetHashCode();
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
