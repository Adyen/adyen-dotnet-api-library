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
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
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
        /// <param name="city">The name of the city. (required).</param>
        /// <param name="country">The two-character country code as defined in ISO-3166-1 alpha-2. For example, **US**. &gt; If you don&#x27;t know the country or are not collecting the country from the shopper, provide &#x60;country&#x60; as &#x60;ZZ&#x60;. (required).</param>
        /// <param name="houseNumberOrName">The number or name of the house. (required).</param>
        /// <param name="postalCode">A maximum of five digits for an address in the US, or a maximum of ten characters for an address in all other countries. (required).</param>
        /// <param name="stateOrProvince">State or province codes as defined in ISO 3166-2. For example, **CA** in the US or **ON** in Canada. &gt; Required for the US and Canada..</param>
        /// <param name="street">The name of the street. &gt; The house number should not be included in this field; it should be separately provided via &#x60;houseNumberOrName&#x60;. (required).</param>
        public Address(string city = default(string), string country = default(string),
            string houseNumberOrName = default(string), string postalCode = default(string),
            string stateOrProvince = default(string), string street = default(string))
        {
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new InvalidDataException("city is a required property for Address and cannot be null");
            }
            else
            {
                this.City = city;
            }
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new InvalidDataException("country is a required property for Address and cannot be null");
            }
            else
            {
                this.Country = country;
            }
            // to ensure "houseNumberOrName" is required (not null)
            if (houseNumberOrName == null)
            {
                throw new InvalidDataException(
                    "houseNumberOrName is a required property for Address and cannot be null");
            }
            else
            {
                this.HouseNumberOrName = houseNumberOrName;
            }
            // to ensure "postalCode" is required (not null)
            if (postalCode == null)
            {
                throw new InvalidDataException("postalCode is a required property for Address and cannot be null");
            }
            else
            {
                this.PostalCode = postalCode;
            }
            // to ensure "street" is required (not null)
            if (street == null)
            {
                throw new InvalidDataException("street is a required property for Address and cannot be null");
            }
            else
            {
                this.Street = street;
            }
            this.StateOrProvince = stateOrProvince;
        }

        /// <summary>
        /// The name of the city.
        /// </summary>
        /// <value>The name of the city.</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The two-character country code as defined in ISO-3166-1 alpha-2. For example, **US**. &gt; If you don&#x27;t know the country or are not collecting the country from the shopper, provide &#x60;country&#x60; as &#x60;ZZ&#x60;.
        /// </summary>
        /// <value>The two-character country code as defined in ISO-3166-1 alpha-2. For example, **US**. &gt; If you don&#x27;t know the country or are not collecting the country from the shopper, provide &#x60;country&#x60; as &#x60;ZZ&#x60;.</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// The number or name of the house.
        /// </summary>
        /// <value>The number or name of the house.</value>
        [DataMember(Name = "houseNumberOrName", EmitDefaultValue = false)]
        public string HouseNumberOrName { get; set; }

        /// <summary>
        /// A maximum of five digits for an address in the US, or a maximum of ten characters for an address in all other countries.
        /// </summary>
        /// <value>A maximum of five digits for an address in the US, or a maximum of ten characters for an address in all other countries.</value>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// State or province codes as defined in ISO 3166-2. For example, **CA** in the US or **ON** in Canada. &gt; Required for the US and Canada.
        /// </summary>
        /// <value>State or province codes as defined in ISO 3166-2. For example, **CA** in the US or **ON** in Canada. &gt; Required for the US and Canada.</value>
        [DataMember(Name = "stateOrProvince", EmitDefaultValue = false)]
        public string StateOrProvince { get; set; }

        /// <summary>
        /// The name of the street. &gt; The house number should not be included in this field; it should be separately provided via &#x60;houseNumberOrName&#x60;.
        /// </summary>
        /// <value>The name of the street. &gt; The house number should not be included in this field; it should be separately provided via &#x60;houseNumberOrName&#x60;.</value>
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
                return false;

            return
                (
                    this.City == input.City ||
                    this.City != null &&
                    this.City.Equals(input.City)
                ) &&
                (
                    this.Country == input.Country ||
                    this.Country != null &&
                    this.Country.Equals(input.Country)
                ) &&
                (
                    this.HouseNumberOrName == input.HouseNumberOrName ||
                    this.HouseNumberOrName != null &&
                    this.HouseNumberOrName.Equals(input.HouseNumberOrName)
                ) &&
                (
                    this.PostalCode == input.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode)
                ) &&
                (
                    this.StateOrProvince == input.StateOrProvince ||
                    this.StateOrProvince != null &&
                    this.StateOrProvince.Equals(input.StateOrProvince)
                ) &&
                (
                    this.Street == input.Street ||
                    this.Street != null &&
                    this.Street.Equals(input.Street)
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
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.HouseNumberOrName != null)
                    hashCode = hashCode * 59 + this.HouseNumberOrName.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.StateOrProvince != null)
                    hashCode = hashCode * 59 + this.StateOrProvince.GetHashCode();
                if (this.Street != null)
                    hashCode = hashCode * 59 + this.Street.GetHashCode();
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