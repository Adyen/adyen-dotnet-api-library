/*
* POS Terminal Management API
*
*
* The version of the OpenAPI document: 1
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

namespace Adyen.Model.PosTerminalManagement
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
        /// <param name="city">city.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="stateOrProvince">stateOrProvince.</param>
        /// <param name="streetAddress">streetAddress.</param>
        /// <param name="streetAddress2">streetAddress2.</param>
        public Address(string city = default(string), string countryCode = default(string), string postalCode = default(string), string stateOrProvince = default(string), string streetAddress = default(string), string streetAddress2 = default(string))
        {
            this.City = city;
            this.CountryCode = countryCode;
            this.PostalCode = postalCode;
            this.StateOrProvince = stateOrProvince;
            this.StreetAddress = streetAddress;
            this.StreetAddress2 = streetAddress2;
        }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets StateOrProvince
        /// </summary>
        [DataMember(Name = "stateOrProvince", EmitDefaultValue = false)]
        public string StateOrProvince { get; set; }

        /// <summary>
        /// Gets or Sets StreetAddress
        /// </summary>
        [DataMember(Name = "streetAddress", EmitDefaultValue = false)]
        public string StreetAddress { get; set; }

        /// <summary>
        /// Gets or Sets StreetAddress2
        /// </summary>
        [DataMember(Name = "streetAddress2", EmitDefaultValue = false)]
        public string StreetAddress2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  StateOrProvince: ").Append(StateOrProvince).Append("\n");
            sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
            sb.Append("  StreetAddress2: ").Append(StreetAddress2).Append("\n");
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
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
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
                    this.StreetAddress == input.StreetAddress ||
                    (this.StreetAddress != null &&
                    this.StreetAddress.Equals(input.StreetAddress))
                ) && 
                (
                    this.StreetAddress2 == input.StreetAddress2 ||
                    (this.StreetAddress2 != null &&
                    this.StreetAddress2.Equals(input.StreetAddress2))
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
                if (this.CountryCode != null)
                {
                    hashCode = (hashCode * 59) + this.CountryCode.GetHashCode();
                }
                if (this.PostalCode != null)
                {
                    hashCode = (hashCode * 59) + this.PostalCode.GetHashCode();
                }
                if (this.StateOrProvince != null)
                {
                    hashCode = (hashCode * 59) + this.StateOrProvince.GetHashCode();
                }
                if (this.StreetAddress != null)
                {
                    hashCode = (hashCode * 59) + this.StreetAddress.GetHashCode();
                }
                if (this.StreetAddress2 != null)
                {
                    hashCode = (hashCode * 59) + this.StreetAddress2.GetHashCode();
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
