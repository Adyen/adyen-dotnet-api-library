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
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.Modification
{
    [DataContract]
    public class AbstractModificationRequest : IValidatableObject
    {
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        [DataMember(Name = "authorisationCode", EmitDefaultValue = false)]
        public string AuthorisationCode { get; set; }

        [DataMember(Name = "originalReference", EmitDefaultValue = false)]
        public string OriginalReference { get; set; }

        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        public string AdditionalData { get; set; }

        [DataMember(Name = "applicationInfo", EmitDefaultValue = false)]

        public ApplicationInformation.ApplicationInfo ApplicationInfo { get; set; }

        [DataMember(Name = "threeDSecureData", EmitDefaultValue = false)]

        public ThreeDSecureData ThreeDSecureData { get; set; }

        [DataMember(Name = "uniqueTerminalId", EmitDefaultValue = false)]

        public string UniqueTerminalId { get; set; }

        [DataMember(Name = "originalMerchantReference", EmitDefaultValue = false)]

        public string OriginalMerchantReference { get; set; }

        [DataMember(Name = "tenderReference", EmitDefaultValue = false)]

        public string TenderReference { get; set; }


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("  Reference:  ").Append(Reference).Append("\n");
            sb.Append("  OriginalReference: ").Append(OriginalReference).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  AuthorisationCode: ").Append(AuthorisationCode).Append("\n");
            sb.Append("  ThreeDSecureData: ").Append(ThreeDSecureData).Append("\n");
            sb.Append("  TenderReference: ").Append(TenderReference).Append("\n");
            sb.Append("  UniqueTerminalId: ").Append(UniqueTerminalId).Append("\n");
            sb.Append("  OriginalMerchantReference: ").Append(OriginalMerchantReference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as AbstractModificationRequest);
        }

        /// <summary>
        /// Returns true if ModificationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ModificationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractModificationRequest other)
        {
            if (other == null)
                return false;

            return
                (
                    this.Reference == other.Reference ||
                    this.Reference != null &&
                    this.Reference.Equals(other.Reference)
                ) &&
                (
                    this.OriginalReference == other.OriginalReference ||
                    this.OriginalReference != null &&
                    this.OriginalReference.Equals(other.OriginalReference)
                ) &&
                (
                    this.MerchantAccount == other.MerchantAccount ||
                    this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(other.MerchantAccount)
                ) &&
                (
                    this.AuthorisationCode == other.AuthorisationCode ||
                    this.AuthorisationCode != null &&
                    this.AuthorisationCode.Equals(other.AuthorisationCode)
                ) &&
                (
                    this.ThreeDSecureData == other.ThreeDSecureData ||
                    this.ThreeDSecureData != null &&
                    this.ThreeDSecureData.Equals(other.ThreeDSecureData)
                ) &&
                (
                    this.UniqueTerminalId == other.UniqueTerminalId ||
                    this.UniqueTerminalId != null &&
                    this.UniqueTerminalId.Equals(other.UniqueTerminalId)
                ) &&
                (
                    this.TenderReference == other.TenderReference ||
                    this.TenderReference != null &&
                    this.TenderReference.Equals(other.TenderReference)
                ) &&
                (
                    this.OriginalMerchantReference == other.OriginalMerchantReference ||
                    this.OriginalMerchantReference != null &&
                    this.OriginalMerchantReference.Equals(other.OriginalMerchantReference)
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
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Reference != null)
                    hash = hash * 59 + this.Reference.GetHashCode();
                if (this.OriginalReference != null)
                    hash = hash * 59 + this.OriginalReference.GetHashCode();
                if (this.AuthorisationCode != null)
                    hash = hash * 59 + this.AuthorisationCode.GetHashCode();
                if (this.MerchantAccount != null)
                    hash = hash * 59 + this.MerchantAccount.GetHashCode();
                if (this.AdditionalData != null)
                    hash = hash * 59 + this.AdditionalData.GetHashCode();
                if (this.AuthorisationCode != null)
                    hash = hash * 59 + this.AuthorisationCode.GetHashCode();
                if (this.ThreeDSecureData != null)
                    hash = hash * 59 + this.ThreeDSecureData.GetHashCode();
                if (this.OriginalMerchantReference != null)
                    hash = hash * 59 + this.OriginalMerchantReference.GetHashCode();
                if (this.TenderReference != null)
                    hash = hash * 59 + this.TenderReference.GetHashCode();
                if (this.UniqueTerminalId != null)
                    hash = hash * 59 + this.UniqueTerminalId.GetHashCode();
                return hash;
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
