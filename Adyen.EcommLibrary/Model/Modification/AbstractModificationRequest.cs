using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Adyen.EcommLibrary.Model.ApplicationInformation;

namespace Adyen.EcommLibrary.Model.Modification
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

        public ApplicationInfo ApplicationInfo { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append("  Reference:  ").Append(Reference).Append("\n");
            sb.Append("  OriginalReference: ").Append(OriginalReference).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  AuthorisationCode: ").Append(AuthorisationCode).Append("\n");
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
            return Equals(obj as AbstractModificationRequest);
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
                    Reference == other.Reference ||
                    Reference != null &&
                    Reference.Equals(other.Reference)
                ) &&
                (
                    OriginalReference == other.OriginalReference ||
                    OriginalReference != null &&
                    OriginalReference.Equals(other.OriginalReference)
                ) &&
                (
                    MerchantAccount == other.MerchantAccount ||
                    MerchantAccount != null &&
                    MerchantAccount.Equals(other.MerchantAccount)
                ) &&
                (
                    AuthorisationCode == other.AuthorisationCode ||
                    AuthorisationCode != null &&
                    AuthorisationCode.Equals(other.AuthorisationCode)
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
                var hash = 41;
                // Suitable nullity checks etc, of course :)
                if (Reference != null)
                    hash = hash * 59 + Reference.GetHashCode();
                if (OriginalReference != null)
                    hash = hash * 59 + OriginalReference.GetHashCode();
                if (AuthorisationCode != null)
                    hash = hash * 59 + AuthorisationCode.GetHashCode();
                if (MerchantAccount != null)
                    hash = hash * 59 + MerchantAccount.GetHashCode();
                if (AdditionalData != null)
                    hash = hash * 59 + AdditionalData.GetHashCode();
                if (AuthorisationCode != null)
                    hash = hash * 59 + AuthorisationCode.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}