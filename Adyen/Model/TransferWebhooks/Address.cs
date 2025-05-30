/*
* Transfer webhooks
*
*
* The version of the OpenAPI document: 4
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

namespace Adyen.Model.TransferWebhooks
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
        /// <param name="city">The name of the city.  Supported characters: **[a-z] [A-Z] [0-9] . - — / # , ’ ° ( ) : ; [ ] &amp; \\ |** and Space.  &gt; Required when the &#x60;category&#x60; is **card**. .</param>
        /// <param name="country">The two-character ISO 3166-1 alpha-2 country code. For example, **US**, **NL**, or **GB**. (required).</param>
        /// <param name="line1">The first line of the street address.  Supported characters: **[a-z] [A-Z] [0-9] . - — / # , ’ ° ( ) : ; [ ] &amp; \\ |** and Space.  &gt; Required when the &#x60;category&#x60; is **card**. .</param>
        /// <param name="line2">The second line of the street address.  Supported characters: **[a-z] [A-Z] [0-9] . - — / # , ’ ° ( ) : ; [ ] &amp; \\ |** and Space.  &gt; Required when the &#x60;category&#x60; is **card**. .</param>
        /// <param name="postalCode">The postal code. Maximum length: * 5 digits for an address in the US. * 10 characters for an address in all other countries.  Supported characters: **[a-z] [A-Z] [0-9]** and Space.  &gt; Required for addresses in the US. .</param>
        /// <param name="stateOrProvince">   The two-letter ISO 3166-2 state or province code. For example, **CA** in the US or **ON** in Canada.     &gt; Required for the US and Canada. .</param>
        public Address(string city = default(string), string country = default(string), string line1 = default(string), string line2 = default(string), string postalCode = default(string), string stateOrProvince = default(string))
        {
            this.Country = country;
            this.City = city;
            this.Line1 = line1;
            this.Line2 = line2;
            this.PostalCode = postalCode;
            this.StateOrProvince = stateOrProvince;
        }

        /// <summary>
        /// The name of the city.  Supported characters: **[a-z] [A-Z] [0-9] . - — / # , ’ ° ( ) : ; [ ] &amp; \\ |** and Space.  &gt; Required when the &#x60;category&#x60; is **card**. 
        /// </summary>
        /// <value>The name of the city.  Supported characters: **[a-z] [A-Z] [0-9] . - — / # , ’ ° ( ) : ; [ ] &amp; \\ |** and Space.  &gt; Required when the &#x60;category&#x60; is **card**. </value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The two-character ISO 3166-1 alpha-2 country code. For example, **US**, **NL**, or **GB**.
        /// </summary>
        /// <value>The two-character ISO 3166-1 alpha-2 country code. For example, **US**, **NL**, or **GB**.</value>
        [DataMember(Name = "country", IsRequired = false, EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// The first line of the street address.  Supported characters: **[a-z] [A-Z] [0-9] . - — / # , ’ ° ( ) : ; [ ] &amp; \\ |** and Space.  &gt; Required when the &#x60;category&#x60; is **card**. 
        /// </summary>
        /// <value>The first line of the street address.  Supported characters: **[a-z] [A-Z] [0-9] . - — / # , ’ ° ( ) : ; [ ] &amp; \\ |** and Space.  &gt; Required when the &#x60;category&#x60; is **card**. </value>
        [DataMember(Name = "line1", EmitDefaultValue = false)]
        public string Line1 { get; set; }

        /// <summary>
        /// The second line of the street address.  Supported characters: **[a-z] [A-Z] [0-9] . - — / # , ’ ° ( ) : ; [ ] &amp; \\ |** and Space.  &gt; Required when the &#x60;category&#x60; is **card**. 
        /// </summary>
        /// <value>The second line of the street address.  Supported characters: **[a-z] [A-Z] [0-9] . - — / # , ’ ° ( ) : ; [ ] &amp; \\ |** and Space.  &gt; Required when the &#x60;category&#x60; is **card**. </value>
        [DataMember(Name = "line2", EmitDefaultValue = false)]
        public string Line2 { get; set; }

        /// <summary>
        /// The postal code. Maximum length: * 5 digits for an address in the US. * 10 characters for an address in all other countries.  Supported characters: **[a-z] [A-Z] [0-9]** and Space.  &gt; Required for addresses in the US. 
        /// </summary>
        /// <value>The postal code. Maximum length: * 5 digits for an address in the US. * 10 characters for an address in all other countries.  Supported characters: **[a-z] [A-Z] [0-9]** and Space.  &gt; Required for addresses in the US. </value>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        ///    The two-letter ISO 3166-2 state or province code. For example, **CA** in the US or **ON** in Canada.     &gt; Required for the US and Canada. 
        /// </summary>
        /// <value>   The two-letter ISO 3166-2 state or province code. For example, **CA** in the US or **ON** in Canada.     &gt; Required for the US and Canada. </value>
        [DataMember(Name = "stateOrProvince", EmitDefaultValue = false)]
        public string StateOrProvince { get; set; }

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
            sb.Append("  Line1: ").Append(Line1).Append("\n");
            sb.Append("  Line2: ").Append(Line2).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  StateOrProvince: ").Append(StateOrProvince).Append("\n");
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
                    this.Line1 == input.Line1 ||
                    (this.Line1 != null &&
                    this.Line1.Equals(input.Line1))
                ) && 
                (
                    this.Line2 == input.Line2 ||
                    (this.Line2 != null &&
                    this.Line2.Equals(input.Line2))
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
                if (this.Line1 != null)
                {
                    hashCode = (hashCode * 59) + this.Line1.GetHashCode();
                }
                if (this.Line2 != null)
                {
                    hashCode = (hashCode * 59) + this.Line2.GetHashCode();
                }
                if (this.PostalCode != null)
                {
                    hashCode = (hashCode * 59) + this.PostalCode.GetHashCode();
                }
                if (this.StateOrProvince != null)
                {
                    hashCode = (hashCode * 59) + this.StateOrProvince.GetHashCode();
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
            // City (string) minLength
            if (this.City != null && this.City.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be greater than 3.", new [] { "City" });
            }

            // PostalCode (string) minLength
            if (this.PostalCode != null && this.PostalCode.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, length must be greater than 3.", new [] { "PostalCode" });
            }

            yield break;
        }
    }

}
