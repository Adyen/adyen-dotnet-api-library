using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.EcommLibrary.Model.Checkout
{
    /// <summary>
    /// Address
    /// </summary>
    [DataContract]
    public partial class Address : IEquatable<Address>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        [JsonConstructor]
        protected Address()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="City">The name of the city. &gt;Required if either houseNumberOrName, street, postalCode, or stateOrProvince are provided..</param>
        /// <param name="Country">The two-character country code of the address &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. &#39;NL&#39;). (required).</param>
        /// <param name="HouseNumberOrName">The number or name of the house..</param>
        /// <param name="PostalCode">The postal code. &gt;A maximum of five (5) digits for an address in the USA, or a maximum of ten (10) characters for an address in all other countries. &gt;Required if either houseNumberOrName, street, city, or stateOrProvince are provided..</param>
        /// <param name="StateOrProvince">The abbreviation of the state or province. &gt;Two (2) characters for an address in the USA or Canada, or a maximum of three (3) characters for an address in all other countries. &gt;Required for an address in the USA or Canada if either houseNumberOrName, street, city, or postalCode are provided..</param>
        /// <param name="Street">The name of the street. &gt;The house number should not be included in this field; it should be separately provided via &#x60;houseNumberOrName&#x60;. &gt;Required if either houseNumberOrName, city, postalCode, or stateOrProvince are provided..</param>
        public Address(string City = default(string), string Country = default(string),
            string HouseNumberOrName = default(string), string PostalCode = default(string),
            string StateOrProvince = default(string), string Street = default(string))
        {
            // to ensure "Country" is required (not null)
            if (Country == null)
                throw new InvalidDataException("Country is a required property for Address and cannot be null");
            else
                this.Country = Country;
            this.City = City;
            this.HouseNumberOrName = HouseNumberOrName;
            this.PostalCode = PostalCode;
            this.StateOrProvince = StateOrProvince;
            this.Street = Street;
        }

        /// <summary>
        /// The name of the city. &gt;Required if either houseNumberOrName, street, postalCode, or stateOrProvince are provided.
        /// </summary>
        /// <value>The name of the city. &gt;Required if either houseNumberOrName, street, postalCode, or stateOrProvince are provided.</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The two-character country code of the address &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. &#39;NL&#39;).
        /// </summary>
        /// <value>The two-character country code of the address &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. &#39;NL&#39;).</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// The number or name of the house.
        /// </summary>
        /// <value>The number or name of the house.</value>
        [DataMember(Name = "houseNumberOrName", EmitDefaultValue = false)]
        public string HouseNumberOrName { get; set; }

        /// <summary>
        /// The postal code. &gt;A maximum of five (5) digits for an address in the USA, or a maximum of ten (10) characters for an address in all other countries. &gt;Required if either houseNumberOrName, street, city, or stateOrProvince are provided.
        /// </summary>
        /// <value>The postal code. &gt;A maximum of five (5) digits for an address in the USA, or a maximum of ten (10) characters for an address in all other countries. &gt;Required if either houseNumberOrName, street, city, or stateOrProvince are provided.</value>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The abbreviation of the state or province. &gt;Two (2) characters for an address in the USA or Canada, or a maximum of three (3) characters for an address in all other countries. &gt;Required for an address in the USA or Canada if either houseNumberOrName, street, city, or postalCode are provided.
        /// </summary>
        /// <value>The abbreviation of the state or province. &gt;Two (2) characters for an address in the USA or Canada, or a maximum of three (3) characters for an address in all other countries. &gt;Required for an address in the USA or Canada if either houseNumberOrName, street, city, or postalCode are provided.</value>
        [DataMember(Name = "stateOrProvince", EmitDefaultValue = false)]
        public string StateOrProvince { get; set; }

        /// <summary>
        /// The name of the street. &gt;The house number should not be included in this field; it should be separately provided via &#x60;houseNumberOrName&#x60;. &gt;Required if either houseNumberOrName, city, postalCode, or stateOrProvince are provided.
        /// </summary>
        /// <value>The name of the street. &gt;The house number should not be included in this field; it should be separately provided via &#x60;houseNumberOrName&#x60;. &gt;Required if either houseNumberOrName, city, postalCode, or stateOrProvince are provided.</value>
        [DataMember(Name = "street", EmitDefaultValue = false)]
        public string Street { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  HouseNumberOrName: ").Append(HouseNumberOrName).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  StateOrProvince: ").Append(StateOrProvince).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
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
            return Equals(input as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="input">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address input)
        {
            if (input == null)
                return false;

            return
                (
                    City == input.City ||
                    City != null &&
                    City.Equals(input.City)
                ) &&
                (
                    Country == input.Country ||
                    Country != null &&
                    Country.Equals(input.Country)
                ) &&
                (
                    HouseNumberOrName == input.HouseNumberOrName ||
                    HouseNumberOrName != null &&
                    HouseNumberOrName.Equals(input.HouseNumberOrName)
                ) &&
                (
                    PostalCode == input.PostalCode ||
                    PostalCode != null &&
                    PostalCode.Equals(input.PostalCode)
                ) &&
                (
                    StateOrProvince == input.StateOrProvince ||
                    StateOrProvince != null &&
                    StateOrProvince.Equals(input.StateOrProvince)
                ) &&
                (
                    Street == input.Street ||
                    Street != null &&
                    Street.Equals(input.Street)
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
                if (City != null)
                    hashCode = hashCode * 59 + City.GetHashCode();
                if (Country != null)
                    hashCode = hashCode * 59 + Country.GetHashCode();
                if (HouseNumberOrName != null)
                    hashCode = hashCode * 59 + HouseNumberOrName.GetHashCode();
                if (PostalCode != null)
                    hashCode = hashCode * 59 + PostalCode.GetHashCode();
                if (StateOrProvince != null)
                    hashCode = hashCode * 59 + StateOrProvince.GetHashCode();
                if (Street != null)
                    hashCode = hashCode * 59 + Street.GetHashCode();
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