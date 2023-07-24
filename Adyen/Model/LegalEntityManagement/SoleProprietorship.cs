/*
* Legal Entity Management API
*
*
* The version of the OpenAPI document: 3
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.LegalEntityManagement
{
    /// <summary>
    /// SoleProprietorship
    /// </summary>
    [DataContract(Name = "SoleProprietorship")]
    public partial class SoleProprietorship : IEquatable<SoleProprietorship>, IValidatableObject
    {
        /// <summary>
        /// The reason for not providing a VAT number.  Possible values: **industryExemption**, **belowTaxThreshold**.
        /// </summary>
        /// <value>The reason for not providing a VAT number.  Possible values: **industryExemption**, **belowTaxThreshold**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VatAbsenceReasonEnum
        {
            /// <summary>
            /// Enum IndustryExemption for value: industryExemption
            /// </summary>
            [EnumMember(Value = "industryExemption")]
            IndustryExemption = 1,

            /// <summary>
            /// Enum BelowTaxThreshold for value: belowTaxThreshold
            /// </summary>
            [EnumMember(Value = "belowTaxThreshold")]
            BelowTaxThreshold = 2

        }


        /// <summary>
        /// The reason for not providing a VAT number.  Possible values: **industryExemption**, **belowTaxThreshold**.
        /// </summary>
        /// <value>The reason for not providing a VAT number.  Possible values: **industryExemption**, **belowTaxThreshold**.</value>
        [DataMember(Name = "vatAbsenceReason", EmitDefaultValue = false)]
        public VatAbsenceReasonEnum? VatAbsenceReason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SoleProprietorship" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SoleProprietorship() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SoleProprietorship" /> class.
        /// </summary>
        /// <param name="countryOfGoverningLaw">The two-character [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code of the governing country. (required).</param>
        /// <param name="dateOfIncorporation">The date when the legal arrangement was incorporated in YYYY-MM-DD format..</param>
        /// <param name="doingBusinessAs">The registered name, if different from the &#x60;name&#x60;..</param>
        /// <param name="name">The legal name. (required).</param>
        /// <param name="principalPlaceOfBusiness">principalPlaceOfBusiness.</param>
        /// <param name="registeredAddress">registeredAddress (required).</param>
        /// <param name="registrationNumber">The registration number..</param>
        /// <param name="vatAbsenceReason">The reason for not providing a VAT number.  Possible values: **industryExemption**, **belowTaxThreshold**..</param>
        /// <param name="vatNumber">The VAT number..</param>
        public SoleProprietorship(string countryOfGoverningLaw = default(string), string dateOfIncorporation = default(string), string doingBusinessAs = default(string), string name = default(string), Address principalPlaceOfBusiness = default(Address), Address registeredAddress = default(Address), string registrationNumber = default(string), VatAbsenceReasonEnum? vatAbsenceReason = default(VatAbsenceReasonEnum?), string vatNumber = default(string))
        {
            this.CountryOfGoverningLaw = countryOfGoverningLaw;
            this.Name = name;
            this.RegisteredAddress = registeredAddress;
            this.DateOfIncorporation = dateOfIncorporation;
            this.DoingBusinessAs = doingBusinessAs;
            this.PrincipalPlaceOfBusiness = principalPlaceOfBusiness;
            this.RegistrationNumber = registrationNumber;
            this.VatAbsenceReason = vatAbsenceReason;
            this.VatNumber = vatNumber;
        }

        /// <summary>
        /// The two-character [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code of the governing country.
        /// </summary>
        /// <value>The two-character [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code of the governing country.</value>
        [DataMember(Name = "countryOfGoverningLaw", IsRequired = false, EmitDefaultValue = false)]
        public string CountryOfGoverningLaw { get; set; }

        /// <summary>
        /// The date when the legal arrangement was incorporated in YYYY-MM-DD format.
        /// </summary>
        /// <value>The date when the legal arrangement was incorporated in YYYY-MM-DD format.</value>
        [DataMember(Name = "dateOfIncorporation", EmitDefaultValue = false)]
        public string DateOfIncorporation { get; set; }

        /// <summary>
        /// The registered name, if different from the &#x60;name&#x60;.
        /// </summary>
        /// <value>The registered name, if different from the &#x60;name&#x60;.</value>
        [DataMember(Name = "doingBusinessAs", EmitDefaultValue = false)]
        public string DoingBusinessAs { get; set; }

        /// <summary>
        /// The legal name.
        /// </summary>
        /// <value>The legal name.</value>
        [DataMember(Name = "name", IsRequired = false, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PrincipalPlaceOfBusiness
        /// </summary>
        [DataMember(Name = "principalPlaceOfBusiness", EmitDefaultValue = false)]
        public Address PrincipalPlaceOfBusiness { get; set; }

        /// <summary>
        /// Gets or Sets RegisteredAddress
        /// </summary>
        [DataMember(Name = "registeredAddress", IsRequired = false, EmitDefaultValue = false)]
        public Address RegisteredAddress { get; set; }

        /// <summary>
        /// The registration number.
        /// </summary>
        /// <value>The registration number.</value>
        [DataMember(Name = "registrationNumber", EmitDefaultValue = false)]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// The VAT number.
        /// </summary>
        /// <value>The VAT number.</value>
        [DataMember(Name = "vatNumber", EmitDefaultValue = false)]
        public string VatNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SoleProprietorship {\n");
            sb.Append("  CountryOfGoverningLaw: ").Append(CountryOfGoverningLaw).Append("\n");
            sb.Append("  DateOfIncorporation: ").Append(DateOfIncorporation).Append("\n");
            sb.Append("  DoingBusinessAs: ").Append(DoingBusinessAs).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PrincipalPlaceOfBusiness: ").Append(PrincipalPlaceOfBusiness).Append("\n");
            sb.Append("  RegisteredAddress: ").Append(RegisteredAddress).Append("\n");
            sb.Append("  RegistrationNumber: ").Append(RegistrationNumber).Append("\n");
            sb.Append("  VatAbsenceReason: ").Append(VatAbsenceReason).Append("\n");
            sb.Append("  VatNumber: ").Append(VatNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SoleProprietorship);
        }

        /// <summary>
        /// Returns true if SoleProprietorship instances are equal
        /// </summary>
        /// <param name="input">Instance of SoleProprietorship to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SoleProprietorship input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CountryOfGoverningLaw == input.CountryOfGoverningLaw ||
                    (this.CountryOfGoverningLaw != null &&
                    this.CountryOfGoverningLaw.Equals(input.CountryOfGoverningLaw))
                ) && 
                (
                    this.DateOfIncorporation == input.DateOfIncorporation ||
                    (this.DateOfIncorporation != null &&
                    this.DateOfIncorporation.Equals(input.DateOfIncorporation))
                ) && 
                (
                    this.DoingBusinessAs == input.DoingBusinessAs ||
                    (this.DoingBusinessAs != null &&
                    this.DoingBusinessAs.Equals(input.DoingBusinessAs))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PrincipalPlaceOfBusiness == input.PrincipalPlaceOfBusiness ||
                    (this.PrincipalPlaceOfBusiness != null &&
                    this.PrincipalPlaceOfBusiness.Equals(input.PrincipalPlaceOfBusiness))
                ) && 
                (
                    this.RegisteredAddress == input.RegisteredAddress ||
                    (this.RegisteredAddress != null &&
                    this.RegisteredAddress.Equals(input.RegisteredAddress))
                ) && 
                (
                    this.RegistrationNumber == input.RegistrationNumber ||
                    (this.RegistrationNumber != null &&
                    this.RegistrationNumber.Equals(input.RegistrationNumber))
                ) && 
                (
                    this.VatAbsenceReason == input.VatAbsenceReason ||
                    this.VatAbsenceReason.Equals(input.VatAbsenceReason)
                ) && 
                (
                    this.VatNumber == input.VatNumber ||
                    (this.VatNumber != null &&
                    this.VatNumber.Equals(input.VatNumber))
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
                if (this.CountryOfGoverningLaw != null)
                {
                    hashCode = (hashCode * 59) + this.CountryOfGoverningLaw.GetHashCode();
                }
                if (this.DateOfIncorporation != null)
                {
                    hashCode = (hashCode * 59) + this.DateOfIncorporation.GetHashCode();
                }
                if (this.DoingBusinessAs != null)
                {
                    hashCode = (hashCode * 59) + this.DoingBusinessAs.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.PrincipalPlaceOfBusiness != null)
                {
                    hashCode = (hashCode * 59) + this.PrincipalPlaceOfBusiness.GetHashCode();
                }
                if (this.RegisteredAddress != null)
                {
                    hashCode = (hashCode * 59) + this.RegisteredAddress.GetHashCode();
                }
                if (this.RegistrationNumber != null)
                {
                    hashCode = (hashCode * 59) + this.RegistrationNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VatAbsenceReason.GetHashCode();
                if (this.VatNumber != null)
                {
                    hashCode = (hashCode * 59) + this.VatNumber.GetHashCode();
                }
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
