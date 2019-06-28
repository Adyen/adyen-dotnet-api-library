using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.EcommLibrary.Model.Checkout
{
    [DataContract]
    public partial class Authentication : IEquatable<Authentication>, IValidatableObject
    {
        [DataMember(Name = "threeds2.fingerprintToken", EmitDefaultValue = false)]
        public string FingerprintToken { get; set; }

        [DataMember(Name = "threeds2.challengeToken", EmitDefaultValue = false)]
        public string ChallengeToken { get; set; }

        public Authentication(string FingerprintToken = default(string), string ChallengeToken = default(string))
        {
            this.FingerprintToken = FingerprintToken;
            this.ChallengeToken = ChallengeToken;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Authentication {\n");
            sb.Append("  FingerprintToken: ").Append(FingerprintToken).Append("\n");
            sb.Append("  ChallengeToken: ").Append(ChallengeToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Authentication);
        }

        public bool Equals(Authentication other)
        {
            if (other == null)
                return false;

            return
                (
                    FingerprintToken == other.FingerprintToken ||
                    FingerprintToken != null &&
                    FingerprintToken.Equals(other.FingerprintToken)
                ) &&
                (
                    ChallengeToken == other.ChallengeToken ||
                    ChallengeToken != null &&
                    ChallengeToken.Equals(other.ChallengeToken)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                var hash = 41;
                // Suitable nullity checks etc, of course :)
                if (FingerprintToken != null)
                    hash = hash * 59 + FingerprintToken.GetHashCode();
                if (ChallengeToken != null)
                    hash = hash * 59 + ChallengeToken.GetHashCode();
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
