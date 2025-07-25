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
    /// Address
    /// </summary>
    [DataContract(Name = "Address")]
    public partial class Address : IEquatable<Address>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Address() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="city">The name of the city. Required if &#x60;stateOrProvince&#x60; is provided.  If you specify the city, you must also send &#x60;postalCode&#x60; and &#x60;street&#x60;..</param>
        /// <param name="country">The two-letter [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code. (required).</param>
        /// <param name="postalCode">The postal code. Required if &#x60;stateOrProvince&#x60; and/or &#x60;city&#x60; is provided.  When using alphanumeric postal codes, all letters must be uppercase. For example, 1234 AB or SW1A 1AA..</param>
        /// <param name="stateOrProvince">The two-letter ISO 3166-2 state or province code. For example, **CA** in the US.  If you specify the state or province, you must also send &#x60;city&#x60;, &#x60;postalCode&#x60;, and &#x60;street&#x60;..</param>
        /// <param name="street">The name of the street, and the house or building number. Required if &#x60;stateOrProvince&#x60; and/or &#x60;city&#x60; is provided..</param>
        /// <param name="street2">The apartment, unit, or suite number..</param>
        public Address(string city = default(string), string country = default(string), string postalCode = default(string), string stateOrProvince = default(string), string street = default(string), string street2 = default(string))
        {
            this.Country = country;
            this.City = city;
            this.PostalCode = postalCode;
            this.StateOrProvince = stateOrProvince;
            this.Street = street;
            this.Street2 = street2;
        }

        /// <summary>
        /// The name of the city. Required if &#x60;stateOrProvince&#x60; is provided.  If you specify the city, you must also send &#x60;postalCode&#x60; and &#x60;street&#x60;.
        /// </summary>
        /// <value>The name of the city. Required if &#x60;stateOrProvince&#x60; is provided.  If you specify the city, you must also send &#x60;postalCode&#x60; and &#x60;street&#x60;.</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The two-letter [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code.
        /// </summary>
        /// <value>The two-letter [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code.</value>
        [DataMember(Name = "country", IsRequired = false, EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// The postal code. Required if &#x60;stateOrProvince&#x60; and/or &#x60;city&#x60; is provided.  When using alphanumeric postal codes, all letters must be uppercase. For example, 1234 AB or SW1A 1AA.
        /// </summary>
        /// <value>The postal code. Required if &#x60;stateOrProvince&#x60; and/or &#x60;city&#x60; is provided.  When using alphanumeric postal codes, all letters must be uppercase. For example, 1234 AB or SW1A 1AA.</value>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The two-letter ISO 3166-2 state or province code. For example, **CA** in the US.  If you specify the state or province, you must also send &#x60;city&#x60;, &#x60;postalCode&#x60;, and &#x60;street&#x60;.
        /// </summary>
        /// <value>The two-letter ISO 3166-2 state or province code. For example, **CA** in the US.  If you specify the state or province, you must also send &#x60;city&#x60;, &#x60;postalCode&#x60;, and &#x60;street&#x60;.</value>
        [DataMember(Name = "stateOrProvince", EmitDefaultValue = false)]
        public string StateOrProvince { get; set; }

        /// <summary>
        /// The name of the street, and the house or building number. Required if &#x60;stateOrProvince&#x60; and/or &#x60;city&#x60; is provided.
        /// </summary>
        /// <value>The name of the street, and the house or building number. Required if &#x60;stateOrProvince&#x60; and/or &#x60;city&#x60; is provided.</value>
        [DataMember(Name = "street", EmitDefaultValue = false)]
        public string Street { get; set; }

        /// <summary>
        /// The apartment, unit, or suite number.
        /// </summary>
        /// <value>The apartment, unit, or suite number.</value>
        [DataMember(Name = "street2", EmitDefaultValue = false)]
        public string Street2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  StateOrProvince: ").Append(StateOrProvince).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  Street2: ").Append(Street2).Append("\n");
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
            return this.Equals(input as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="input">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.StateOrProvince == input.StateOrProvince ||
                    (this.StateOrProvince != null &&
                    this.StateOrProvince.Equals(input.StateOrProvince))
                ) && 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
                ) && 
                (
                    this.Street2 == input.Street2 ||
                    (this.Street2 != null &&
                    this.Street2.Equals(input.Street2))
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
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.PostalCode != null)
                {
                    hashCode = (hashCode * 59) + this.PostalCode.GetHashCode();
                }
                if (this.StateOrProvince != null)
                {
                    hashCode = (hashCode * 59) + this.StateOrProvince.GetHashCode();
                }
                if (this.Street != null)
                {
                    hashCode = (hashCode * 59) + this.Street.GetHashCode();
                }
                if (this.Street2 != null)
                {
                    hashCode = (hashCode * 59) + this.Street2.GetHashCode();
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
