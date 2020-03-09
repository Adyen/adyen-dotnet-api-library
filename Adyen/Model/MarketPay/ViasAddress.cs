#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// ViasAddress
    /// </summary>
    [DataContract]
        public partial class ViasAddress :  IEquatable<ViasAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViasAddress" /> class.
        /// </summary>
        /// <param name="city">The name of the city. &gt;Required if either &#x60;houseNumberOrName&#x60;, &#x60;street&#x60;, &#x60;postalCode&#x60;, or &#x60;stateOrProvince&#x60; are provided..</param>
        /// <param name="country">The two-character country code of the address. The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. &#x27;NL&#x27;). &gt; If you don&#x27;t know the country or are not collecting the country from the shopper, provide &#x60;country&#x60; as &#x60;ZZ&#x60;. (required).</param>
        /// <param name="houseNumberOrName">The number or name of the house..</param>
        /// <param name="postalCode">The postal code. &gt;A maximum of five (5) digits for an address in the USA, or a maximum of ten (10) characters for an address in all other countries. &gt;Required if either &#x60;houseNumberOrName&#x60;, &#x60;street&#x60;, &#x60;city&#x60;, or &#x60;stateOrProvince&#x60; are provided..</param>
        /// <param name="stateOrProvince">The abbreviation of the state or province. &gt;Two (2) characters for an address in the USA or Canada, or a maximum of three (3) characters for an address in all other countries. &gt;Required for an address in the USA or Canada if either &#x60;houseNumberOrName&#x60;, &#x60;street&#x60;, &#x60;city&#x60;, or &#x60;postalCode&#x60; are provided..</param>
        /// <param name="street">The name of the street. &gt;The house number should not be included in this field; it should be separately provided via &#x60;houseNumberOrName&#x60;. &gt;Required if either &#x60;houseNumberOrName&#x60;, &#x60;city&#x60;, &#x60;postalCode&#x60;, or &#x60;stateOrProvince&#x60; are provided..</param>
        public ViasAddress(string city = default(string), string country = default(string), string houseNumberOrName = default(string), string postalCode = default(string), string stateOrProvince = default(string), string street = default(string))
        {
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new InvalidDataException("country is a required property for ViasAddress and cannot be null");
            }
            else
            {
                this.Country = country;
            }
            this.City = city;
            this.HouseNumberOrName = houseNumberOrName;
            this.PostalCode = postalCode;
            this.StateOrProvince = stateOrProvince;
            this.Street = street;
        }
        
        /// <summary>
        /// The name of the city. &gt;Required if either &#x60;houseNumberOrName&#x60;, &#x60;street&#x60;, &#x60;postalCode&#x60;, or &#x60;stateOrProvince&#x60; are provided.
        /// </summary>
        /// <value>The name of the city. &gt;Required if either &#x60;houseNumberOrName&#x60;, &#x60;street&#x60;, &#x60;postalCode&#x60;, or &#x60;stateOrProvince&#x60; are provided.</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// The two-character country code of the address. The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. &#x27;NL&#x27;). &gt; If you don&#x27;t know the country or are not collecting the country from the shopper, provide &#x60;country&#x60; as &#x60;ZZ&#x60;.
        /// </summary>
        /// <value>The two-character country code of the address. The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. &#x27;NL&#x27;). &gt; If you don&#x27;t know the country or are not collecting the country from the shopper, provide &#x60;country&#x60; as &#x60;ZZ&#x60;.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// The number or name of the house.
        /// </summary>
        /// <value>The number or name of the house.</value>
        [DataMember(Name="houseNumberOrName", EmitDefaultValue=false)]
        public string HouseNumberOrName { get; set; }

        /// <summary>
        /// The postal code. &gt;A maximum of five (5) digits for an address in the USA, or a maximum of ten (10) characters for an address in all other countries. &gt;Required if either &#x60;houseNumberOrName&#x60;, &#x60;street&#x60;, &#x60;city&#x60;, or &#x60;stateOrProvince&#x60; are provided.
        /// </summary>
        /// <value>The postal code. &gt;A maximum of five (5) digits for an address in the USA, or a maximum of ten (10) characters for an address in all other countries. &gt;Required if either &#x60;houseNumberOrName&#x60;, &#x60;street&#x60;, &#x60;city&#x60;, or &#x60;stateOrProvince&#x60; are provided.</value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The abbreviation of the state or province. &gt;Two (2) characters for an address in the USA or Canada, or a maximum of three (3) characters for an address in all other countries. &gt;Required for an address in the USA or Canada if either &#x60;houseNumberOrName&#x60;, &#x60;street&#x60;, &#x60;city&#x60;, or &#x60;postalCode&#x60; are provided.
        /// </summary>
        /// <value>The abbreviation of the state or province. &gt;Two (2) characters for an address in the USA or Canada, or a maximum of three (3) characters for an address in all other countries. &gt;Required for an address in the USA or Canada if either &#x60;houseNumberOrName&#x60;, &#x60;street&#x60;, &#x60;city&#x60;, or &#x60;postalCode&#x60; are provided.</value>
        [DataMember(Name="stateOrProvince", EmitDefaultValue=false)]
        public string StateOrProvince { get; set; }

        /// <summary>
        /// The name of the street. &gt;The house number should not be included in this field; it should be separately provided via &#x60;houseNumberOrName&#x60;. &gt;Required if either &#x60;houseNumberOrName&#x60;, &#x60;city&#x60;, &#x60;postalCode&#x60;, or &#x60;stateOrProvince&#x60; are provided.
        /// </summary>
        /// <value>The name of the street. &gt;The house number should not be included in this field; it should be separately provided via &#x60;houseNumberOrName&#x60;. &gt;Required if either &#x60;houseNumberOrName&#x60;, &#x60;city&#x60;, &#x60;postalCode&#x60;, or &#x60;stateOrProvince&#x60; are provided.</value>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ViasAddress {\n");
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
            return this.Equals(input as ViasAddress);
        }

        /// <summary>
        /// Returns true if ViasAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of ViasAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViasAddress input)
        {
            if (input == null)
                return false;

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
                    this.HouseNumberOrName == input.HouseNumberOrName ||
                    (this.HouseNumberOrName != null &&
                    this.HouseNumberOrName.Equals(input.HouseNumberOrName))
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
