/*
* Management API
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// UpdatableAddress
    /// </summary>
    [DataContract(Name = "UpdatableAddress")]
    public partial class UpdatableAddress : IEquatable<UpdatableAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatableAddress" /> class.
        /// </summary>
        /// <param name="city">The name of the city..</param>
        /// <param name="line1">The street address..</param>
        /// <param name="line2">Second address line..</param>
        /// <param name="line3">Third address line..</param>
        /// <param name="postalCode">The postal code..</param>
        /// <param name="stateOrProvince">The state or province code as defined in [ISO 3166-2](https://www.iso.org/standard/72483.html). For example, **ON** for Ontario, Canada.  Required for the following countries:  - Australia - Brazil - Canada - India - Mexico - New Zealand - United States.</param>
        public UpdatableAddress(string city = default(string), string line1 = default(string), string line2 = default(string), string line3 = default(string), string postalCode = default(string), string stateOrProvince = default(string))
        {
            this.City = city;
            this.Line1 = line1;
            this.Line2 = line2;
            this.Line3 = line3;
            this.PostalCode = postalCode;
            this.StateOrProvince = stateOrProvince;
        }

        /// <summary>
        /// The name of the city.
        /// </summary>
        /// <value>The name of the city.</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The street address.
        /// </summary>
        /// <value>The street address.</value>
        [DataMember(Name = "line1", EmitDefaultValue = false)]
        public string Line1 { get; set; }

        /// <summary>
        /// Second address line.
        /// </summary>
        /// <value>Second address line.</value>
        [DataMember(Name = "line2", EmitDefaultValue = false)]
        public string Line2 { get; set; }

        /// <summary>
        /// Third address line.
        /// </summary>
        /// <value>Third address line.</value>
        [DataMember(Name = "line3", EmitDefaultValue = false)]
        public string Line3 { get; set; }

        /// <summary>
        /// The postal code.
        /// </summary>
        /// <value>The postal code.</value>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The state or province code as defined in [ISO 3166-2](https://www.iso.org/standard/72483.html). For example, **ON** for Ontario, Canada.  Required for the following countries:  - Australia - Brazil - Canada - India - Mexico - New Zealand - United States
        /// </summary>
        /// <value>The state or province code as defined in [ISO 3166-2](https://www.iso.org/standard/72483.html). For example, **ON** for Ontario, Canada.  Required for the following countries:  - Australia - Brazil - Canada - India - Mexico - New Zealand - United States</value>
        [DataMember(Name = "stateOrProvince", EmitDefaultValue = false)]
        public string StateOrProvince { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdatableAddress {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Line1: ").Append(Line1).Append("\n");
            sb.Append("  Line2: ").Append(Line2).Append("\n");
            sb.Append("  Line3: ").Append(Line3).Append("\n");
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
            return this.Equals(input as UpdatableAddress);
        }

        /// <summary>
        /// Returns true if UpdatableAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdatableAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatableAddress input)
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
                    this.Line3 == input.Line3 ||
                    (this.Line3 != null &&
                    this.Line3.Equals(input.Line3))
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
                if (this.Line1 != null)
                {
                    hashCode = (hashCode * 59) + this.Line1.GetHashCode();
                }
                if (this.Line2 != null)
                {
                    hashCode = (hashCode * 59) + this.Line2.GetHashCode();
                }
                if (this.Line3 != null)
                {
                    hashCode = (hashCode * 59) + this.Line3.GetHashCode();
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
            yield break;
        }
    }

}
