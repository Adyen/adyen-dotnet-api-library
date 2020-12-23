#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

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
    /// Company
    /// </summary>
    [DataContract]
    public partial class Company : IEquatable<Company>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Company" /> class.
        /// </summary>
        /// <param name="homepage">The company website&#x27;s home page..</param>
        /// <param name="name">The company name..</param>
        /// <param name="registrationNumber">Registration number of the company..</param>
        /// <param name="registryLocation">Registry location of the company..</param>
        /// <param name="taxId">Tax ID of the company..</param>
        /// <param name="type">The company type..</param>
        public Company(string homepage = default(string), string name = default(string),
            string registrationNumber = default(string), string registryLocation = default(string),
            string taxId = default(string), string type = default(string))
        {
            this.Homepage = homepage;
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.RegistryLocation = registryLocation;
            this.TaxId = taxId;
            this.Type = type;
        }

        /// <summary>
        /// The company website&#x27;s home page.
        /// </summary>
        /// <value>The company website&#x27;s home page.</value>
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
            return this.Equals(input as Company);
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
                    this.Homepage == input.Homepage ||
                    this.Homepage != null &&
                    this.Homepage.Equals(input.Homepage)
                ) &&
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    this.Name.Equals(input.Name)
                ) &&
                (
                    this.RegistrationNumber == input.RegistrationNumber ||
                    this.RegistrationNumber != null &&
                    this.RegistrationNumber.Equals(input.RegistrationNumber)
                ) &&
                (
                    this.RegistryLocation == input.RegistryLocation ||
                    this.RegistryLocation != null &&
                    this.RegistryLocation.Equals(input.RegistryLocation)
                ) &&
                (
                    this.TaxId == input.TaxId ||
                    this.TaxId != null &&
                    this.TaxId.Equals(input.TaxId)
                ) &&
                (
                    this.Type == input.Type ||
                    this.Type != null &&
                    this.Type.Equals(input.Type)
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
                if (this.Homepage != null)
                    hashCode = hashCode * 59 + this.Homepage.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RegistrationNumber != null)
                    hashCode = hashCode * 59 + this.RegistrationNumber.GetHashCode();
                if (this.RegistryLocation != null)
                    hashCode = hashCode * 59 + this.RegistryLocation.GetHashCode();
                if (this.TaxId != null)
                    hashCode = hashCode * 59 + this.TaxId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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