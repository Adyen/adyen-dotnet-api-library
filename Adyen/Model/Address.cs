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
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Adyen.Model
{
    /// <summary>
    /// Address
    /// </summary>
    [DataContract]
    public partial class Address :  IEquatable<Address>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="Country">A valid value is an ISO two-character country code (e.g. &#39;NL&#39;)..</param>
        /// <param name="StateOrProvince">For US or Canada: a valid 2-character abbreviation for the state or province, respectively. For other countries: any abbreviation with maximum 3 characters for the state or province..</param>
        /// <param name="City">The city name..</param>
        /// <param name="Street">The street name..</param>
        /// <param name="HouseNumberOrName">The house number or name. Note: this field is required for US and Canada..</param>
        /// <param name="PostalCode">The postal/zip code with a maximum of 5 characters for US, and maximum of 10 characters for any other country..</param>
        public Address(string Country = default(string), string StateOrProvince = default(string), string City = default(string), string Street = default(string), string HouseNumberOrName = default(string), string PostalCode = default(string))
        {
            this.Country = Country;
            this.StateOrProvince = StateOrProvince;
            this.City = City;
            this.Street = Street;
            this.HouseNumberOrName = HouseNumberOrName;
            this.PostalCode = PostalCode;
        }
        
        /// <summary>
        /// A valid value is an ISO two-character country code (e.g. &#39;NL&#39;).
        /// </summary>
        /// <value>A valid value is an ISO two-character country code (e.g. &#39;NL&#39;).</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// For US or Canada: a valid 2-character abbreviation for the state or province, respectively. For other countries: any abbreviation with maximum 3 characters for the state or province.
        /// </summary>
        /// <value>For US or Canada: a valid 2-character abbreviation for the state or province, respectively. For other countries: any abbreviation with maximum 3 characters for the state or province.</value>
        [DataMember(Name="stateOrProvince", EmitDefaultValue=false)]
        public string StateOrProvince { get; set; }

        /// <summary>
        /// The city name.
        /// </summary>
        /// <value>The city name.</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// The street name.
        /// </summary>
        /// <value>The street name.</value>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }

        /// <summary>
        /// The house number or name. Note: this field is required for US and Canada.
        /// </summary>
        /// <value>The house number or name. Note: this field is required for US and Canada.</value>
        [DataMember(Name="houseNumberOrName", EmitDefaultValue=false)]
        public string HouseNumberOrName { get; set; }

        /// <summary>
        /// The postal/zip code with a maximum of 5 characters for US, and maximum of 10 characters for any other country.
        /// </summary>
        /// <value>The postal/zip code with a maximum of 5 characters for US, and maximum of 10 characters for any other country.</value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  StateOrProvince: ").Append(StateOrProvince).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  HouseNumberOrName: ").Append(HouseNumberOrName).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="other">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.StateOrProvince == other.StateOrProvince ||
                    this.StateOrProvince != null &&
                    this.StateOrProvince.Equals(other.StateOrProvince)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.Street == other.Street ||
                    this.Street != null &&
                    this.Street.Equals(other.Street)
                ) && 
                (
                    this.HouseNumberOrName == other.HouseNumberOrName ||
                    this.HouseNumberOrName != null &&
                    this.HouseNumberOrName.Equals(other.HouseNumberOrName)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.StateOrProvince != null)
                    hash = hash * 59 + this.StateOrProvince.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.Street != null)
                    hash = hash * 59 + this.Street.GetHashCode();
                if (this.HouseNumberOrName != null)
                    hash = hash * 59 + this.HouseNumberOrName.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                return hash;
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
