using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.EcommLibrary.Model.Checkout
{
    /// <summary>
    /// Permit
    /// </summary>
    [DataContract]
    public partial class Permit : IEquatable<Permit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Permit" /> class.
        /// </summary>
        /// <param name="PartnerId">Partner ID (when using the permit-per-partner token sharing model)..</param>
        /// <param name="ProfileReference">The profile to apply to this permit (when using the shared permits model)..</param>
        /// <param name="Restriction">Permit level restriction overrides..</param>
        /// <param name="ResultKey">The key to link permit requests to permit results..</param>
        /// <param name="ValidTillDate">The expiry date for this permit..</param>
        public Permit(string PartnerId = default(string), string ProfileReference = default(string),
            PermitRestriction Restriction = default(PermitRestriction), string ResultKey = default(string),
            DateTime? ValidTillDate = default(DateTime?))
        {
            this.PartnerId = PartnerId;
            this.ProfileReference = ProfileReference;
            this.Restriction = Restriction;
            this.ResultKey = ResultKey;
            this.ValidTillDate = ValidTillDate;
        }

        /// <summary>
        /// Partner ID (when using the permit-per-partner token sharing model).
        /// </summary>
        /// <value>Partner ID (when using the permit-per-partner token sharing model).</value>
        [DataMember(Name = "partnerId", EmitDefaultValue = false)]
        public string PartnerId { get; set; }

        /// <summary>
        /// The profile to apply to this permit (when using the shared permits model).
        /// </summary>
        /// <value>The profile to apply to this permit (when using the shared permits model).</value>
        [DataMember(Name = "profileReference", EmitDefaultValue = false)]
        public string ProfileReference { get; set; }

        /// <summary>
        /// Permit level restriction overrides.
        /// </summary>
        /// <value>Permit level restriction overrides.</value>
        [DataMember(Name = "restriction", EmitDefaultValue = false)]
        public PermitRestriction Restriction { get; set; }

        /// <summary>
        /// The key to link permit requests to permit results.
        /// </summary>
        /// <value>The key to link permit requests to permit results.</value>
        [DataMember(Name = "resultKey", EmitDefaultValue = false)]
        public string ResultKey { get; set; }

        /// <summary>
        /// The expiry date for this permit.
        /// </summary>
        /// <value>The expiry date for this permit.</value>
        [DataMember(Name = "validTillDate", EmitDefaultValue = false)]
        public DateTime? ValidTillDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Permit {\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  ProfileReference: ").Append(ProfileReference).Append("\n");
            sb.Append("  Restriction: ").Append(Restriction).Append("\n");
            sb.Append("  ResultKey: ").Append(ResultKey).Append("\n");
            sb.Append("  ValidTillDate: ").Append(ValidTillDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return Equals(input as Permit);
        }

        /// <summary>
        /// Returns true if Permit instances are equal
        /// </summary>
        /// <param name="input">Instance of Permit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Permit input)
        {
            if (input == null)
                return false;

            return
                (
                    PartnerId == input.PartnerId ||
                    PartnerId != null &&
                    PartnerId.Equals(input.PartnerId)
                ) &&
                (
                    ProfileReference == input.ProfileReference ||
                    ProfileReference != null &&
                    ProfileReference.Equals(input.ProfileReference)
                ) &&
                (
                    Restriction == input.Restriction ||
                    Restriction != null &&
                    Restriction.Equals(input.Restriction)
                ) &&
                (
                    ResultKey == input.ResultKey ||
                    ResultKey != null &&
                    ResultKey.Equals(input.ResultKey)
                ) &&
                (
                    ValidTillDate == input.ValidTillDate ||
                    ValidTillDate != null &&
                    ValidTillDate.Equals(input.ValidTillDate)
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
                var hashCode = 41;
                if (PartnerId != null)
                    hashCode = hashCode * 59 + PartnerId.GetHashCode();
                if (ProfileReference != null)
                    hashCode = hashCode * 59 + ProfileReference.GetHashCode();
                if (Restriction != null)
                    hashCode = hashCode * 59 + Restriction.GetHashCode();
                if (ResultKey != null)
                    hashCode = hashCode * 59 + ResultKey.GetHashCode();
                if (ValidTillDate != null)
                    hashCode = hashCode * 59 + ValidTillDate.GetHashCode();
                return hashCode;
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