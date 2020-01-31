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
    /// SetupBeneficiaryRequest
    /// </summary>
    [DataContract]
    public class SetupBeneficiaryRequest : IEquatable<SetupBeneficiaryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetupBeneficiaryRequest" /> class.
        /// </summary>
        /// <param name="destinationAccountCode">The destination account code. (required).</param>
        /// <param name="merchantReference">A value that can be supplied at the discretion of the executing user. (required).</param>
        /// <param name="sourceAccountCode">The benefactor account. (required).</param>
        public SetupBeneficiaryRequest(string destinationAccountCode = default(string), string merchantReference = default(string), string sourceAccountCode = default(string))
        {
            // to ensure "destinationAccountCode" is required (not null)
            if (destinationAccountCode == null)
            {
                throw new InvalidDataException("destinationAccountCode is a required property for SetupBeneficiaryRequest and cannot be null");
            }
            else
            {
                this.DestinationAccountCode = destinationAccountCode;
            }
            // to ensure "merchantReference" is required (not null)
            if (merchantReference == null)
            {
                throw new InvalidDataException("merchantReference is a required property for SetupBeneficiaryRequest and cannot be null");
            }
            else
            {
                this.MerchantReference = merchantReference;
            }
            // to ensure "sourceAccountCode" is required (not null)
            if (sourceAccountCode == null)
            {
                throw new InvalidDataException("sourceAccountCode is a required property for SetupBeneficiaryRequest and cannot be null");
            }
            else
            {
                this.SourceAccountCode = sourceAccountCode;
            }
        }

        /// <summary>
        /// The destination account code.
        /// </summary>
        /// <value>The destination account code.</value>
        [DataMember(Name = "destinationAccountCode", EmitDefaultValue = false)]
        public string DestinationAccountCode { get; set; }

        /// <summary>
        /// A value that can be supplied at the discretion of the executing user.
        /// </summary>
        /// <value>A value that can be supplied at the discretion of the executing user.</value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// The benefactor account.
        /// </summary>
        /// <value>The benefactor account.</value>
        [DataMember(Name = "sourceAccountCode", EmitDefaultValue = false)]
        public string SourceAccountCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetupBeneficiaryRequest {\n");
            sb.Append("  DestinationAccountCode: ").Append(DestinationAccountCode).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  SourceAccountCode: ").Append(SourceAccountCode).Append("\n");
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
            return this.Equals(input as SetupBeneficiaryRequest);
        }

        /// <summary>
        /// Returns true if SetupBeneficiaryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SetupBeneficiaryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetupBeneficiaryRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.DestinationAccountCode == input.DestinationAccountCode ||
                    (this.DestinationAccountCode != null &&
                    this.DestinationAccountCode.Equals(input.DestinationAccountCode))
                ) &&
                (
                    this.MerchantReference == input.MerchantReference ||
                    (this.MerchantReference != null &&
                    this.MerchantReference.Equals(input.MerchantReference))
                ) &&
                (
                    this.SourceAccountCode == input.SourceAccountCode ||
                    (this.SourceAccountCode != null &&
                    this.SourceAccountCode.Equals(input.SourceAccountCode))
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
                if (this.DestinationAccountCode != null)
                    hashCode = hashCode * 59 + this.DestinationAccountCode.GetHashCode();
                if (this.MerchantReference != null)
                    hashCode = hashCode * 59 + this.MerchantReference.GetHashCode();
                if (this.SourceAccountCode != null)
                    hashCode = hashCode * 59 + this.SourceAccountCode.GetHashCode();
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
