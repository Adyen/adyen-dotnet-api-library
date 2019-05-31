using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.EcommLibrary.Model.Checkout
{
    /// <summary>
    /// PaymentMethodsGroup
    /// </summary>
    [DataContract]
    public partial class PaymentMethodsGroup : IEquatable<PaymentMethodsGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodsGroup" /> class.
        /// </summary>
        /// <param name="GroupType">The type to submit for any payment method in this group..</param>
        /// <param name="Name">The human-readable name of this group..</param>
        /// <param name="Types">The types of payment methods that belong in this group..</param>
        public PaymentMethodsGroup(string GroupType = default(string), string Name = default(string),
            List<string> Types = default(List<string>))
        {
            this.GroupType = GroupType;
            this.Name = Name;
            this.Types = Types;
        }

        /// <summary>
        /// The type to submit for any payment method in this group.
        /// </summary>
        /// <value>The type to submit for any payment method in this group.</value>
        [DataMember(Name = "groupType", EmitDefaultValue = false)]
        public string GroupType { get; set; }

        /// <summary>
        /// The human-readable name of this group.
        /// </summary>
        /// <value>The human-readable name of this group.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The types of payment methods that belong in this group.
        /// </summary>
        /// <value>The types of payment methods that belong in this group.</value>
        [DataMember(Name = "types", EmitDefaultValue = false)]
        public List<string> Types { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethodsGroup {\n");
            sb.Append("  GroupType: ").Append(GroupType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
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
            return Equals(input as PaymentMethodsGroup);
        }

        /// <summary>
        /// Returns true if PaymentMethodsGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodsGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodsGroup input)
        {
            if (input == null)
                return false;

            return
                (
                    GroupType == input.GroupType ||
                    GroupType != null &&
                    GroupType.Equals(input.GroupType)
                ) &&
                (
                    Name == input.Name ||
                    Name != null &&
                    Name.Equals(input.Name)
                ) &&
                (
                    Types == input.Types ||
                    Types != null &&
                    Types.SequenceEqual(input.Types)
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
                if (GroupType != null)
                    hashCode = hashCode * 59 + GroupType.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Types != null)
                    hashCode = hashCode * 59 + Types.GetHashCode();
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