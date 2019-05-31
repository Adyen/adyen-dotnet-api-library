using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.EcommLibrary.Model.Checkout
{
    /// <summary>
    /// Company
    /// </summary>
    [DataContract]
    public partial class Company : IEquatable<Company>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Company" /> class.
        /// </summary>
        /// <param name="Homepage">The company website&#39;s home page..</param>
        /// <param name="Name">The company name..</param>
        /// <param name="RegistrationNumber">Registration number of the company..</param>
        /// <param name="RegistryLocation">Registry location of the company..</param>
        /// <param name="TaxId">Tax ID of the company..</param>
        /// <param name="Type">The company type..</param>
        public Company(string Homepage = default(string), string Name = default(string),
            string RegistrationNumber = default(string), string RegistryLocation = default(string),
            string TaxId = default(string), string Type = default(string))
        {
            this.Homepage = Homepage;
            this.Name = Name;
            this.RegistrationNumber = RegistrationNumber;
            this.RegistryLocation = RegistryLocation;
            this.TaxId = TaxId;
            this.Type = Type;
        }

        /// <summary>
        /// The company website&#39;s home page.
        /// </summary>
        /// <value>The company website&#39;s home page.</value>
        [DataMember(Name = "homepage", EmitDefaultValue = false)]
        public string Homepage { get; set; }

        /// <summary>
        /// The company name.
        /// </summary>
        /// <value>The company name.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Registration number of the company.
        /// </summary>
        /// <value>Registration number of the company.</value>
        [DataMember(Name = "registrationNumber", EmitDefaultValue = false)]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// Registry location of the company.
        /// </summary>
        /// <value>Registry location of the company.</value>
        [DataMember(Name = "registryLocation", EmitDefaultValue = false)]
        public string RegistryLocation { get; set; }

        /// <summary>
        /// Tax ID of the company.
        /// </summary>
        /// <value>Tax ID of the company.</value>
        [DataMember(Name = "taxId", EmitDefaultValue = false)]
        public string TaxId { get; set; }

        /// <summary>
        /// The company type.
        /// </summary>
        /// <value>The company type.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Company {\n");
            sb.Append("  Homepage: ").Append(Homepage).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RegistrationNumber: ").Append(RegistrationNumber).Append("\n");
            sb.Append("  RegistryLocation: ").Append(RegistryLocation).Append("\n");
            sb.Append("  TaxId: ").Append(TaxId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return Equals(input as Company);
        }

        /// <summary>
        /// Returns true if Company instances are equal
        /// </summary>
        /// <param name="input">Instance of Company to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Company input)
        {
            if (input == null)
                return false;

            return
                (
                    Homepage == input.Homepage ||
                    Homepage != null &&
                    Homepage.Equals(input.Homepage)
                ) &&
                (
                    Name == input.Name ||
                    Name != null &&
                    Name.Equals(input.Name)
                ) &&
                (
                    RegistrationNumber == input.RegistrationNumber ||
                    RegistrationNumber != null &&
                    RegistrationNumber.Equals(input.RegistrationNumber)
                ) &&
                (
                    RegistryLocation == input.RegistryLocation ||
                    RegistryLocation != null &&
                    RegistryLocation.Equals(input.RegistryLocation)
                ) &&
                (
                    TaxId == input.TaxId ||
                    TaxId != null &&
                    TaxId.Equals(input.TaxId)
                ) &&
                (
                    Type == input.Type ||
                    Type != null &&
                    Type.Equals(input.Type)
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
                if (Homepage != null)
                    hashCode = hashCode * 59 + Homepage.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (RegistrationNumber != null)
                    hashCode = hashCode * 59 + RegistrationNumber.GetHashCode();
                if (RegistryLocation != null)
                    hashCode = hashCode * 59 + RegistryLocation.GetHashCode();
                if (TaxId != null)
                    hashCode = hashCode * 59 + TaxId.GetHashCode();
                if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
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