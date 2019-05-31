using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.EcommLibrary.Model.Checkout
{
    /// <summary>
    /// PermitRestriction
    /// </summary>
    [DataContract]
    public partial class PermitRestriction : IEquatable<PermitRestriction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermitRestriction" /> class.
        /// </summary>
        /// <param name="MaxAmount">The total sum amount of one or more payments made using this permit may not exceed this amount if set..</param>
        /// <param name="SingleTransactionLimit">The amount of any single payment using this permit may not exceed this amount if set..</param>
        /// <param name="SingleUse">Only a single payment can be made using this permit if set to true, otherwise multiple payments are allowed..</param>
        public PermitRestriction(Amount MaxAmount = default(Amount), Amount SingleTransactionLimit = default(Amount),
            bool? SingleUse = default(bool?))
        {
            this.MaxAmount = MaxAmount;
            this.SingleTransactionLimit = SingleTransactionLimit;
            this.SingleUse = SingleUse;
        }

        /// <summary>
        /// The total sum amount of one or more payments made using this permit may not exceed this amount if set.
        /// </summary>
        /// <value>The total sum amount of one or more payments made using this permit may not exceed this amount if set.</value>
        [DataMember(Name = "maxAmount", EmitDefaultValue = false)]
        public Amount MaxAmount { get; set; }

        /// <summary>
        /// The amount of any single payment using this permit may not exceed this amount if set.
        /// </summary>
        /// <value>The amount of any single payment using this permit may not exceed this amount if set.</value>
        [DataMember(Name = "singleTransactionLimit", EmitDefaultValue = false)]
        public Amount SingleTransactionLimit { get; set; }

        /// <summary>
        /// Only a single payment can be made using this permit if set to true, otherwise multiple payments are allowed.
        /// </summary>
        /// <value>Only a single payment can be made using this permit if set to true, otherwise multiple payments are allowed.</value>
        [DataMember(Name = "singleUse", EmitDefaultValue = false)]
        public bool? SingleUse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermitRestriction {\n");
            sb.Append("  MaxAmount: ").Append(MaxAmount).Append("\n");
            sb.Append("  SingleTransactionLimit: ").Append(SingleTransactionLimit).Append("\n");
            sb.Append("  SingleUse: ").Append(SingleUse).Append("\n");
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
            return Equals(input as PermitRestriction);
        }

        /// <summary>
        /// Returns true if PermitRestriction instances are equal
        /// </summary>
        /// <param name="input">Instance of PermitRestriction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PermitRestriction input)
        {
            if (input == null)
                return false;

            return
                (
                    MaxAmount == input.MaxAmount ||
                    MaxAmount != null &&
                    MaxAmount.Equals(input.MaxAmount)
                ) &&
                (
                    SingleTransactionLimit == input.SingleTransactionLimit ||
                    SingleTransactionLimit != null &&
                    SingleTransactionLimit.Equals(input.SingleTransactionLimit)
                ) &&
                (
                    SingleUse == input.SingleUse ||
                    SingleUse != null &&
                    SingleUse.Equals(input.SingleUse)
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
                if (MaxAmount != null)
                    hashCode = hashCode * 59 + MaxAmount.GetHashCode();
                if (SingleTransactionLimit != null)
                    hashCode = hashCode * 59 + SingleTransactionLimit.GetHashCode();
                if (SingleUse != null)
                    hashCode = hashCode * 59 + SingleUse.GetHashCode();
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