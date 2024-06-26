/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// BankIdentification
    /// </summary>
    [DataContract(Name = "BankIdentification")]
    public partial class BankIdentification : IEquatable<BankIdentification>, IValidatableObject
    {
        /// <summary>
        /// The type of the identification.  Possible values: **iban**, **routingNumber**, **sortCode**.
        /// </summary>
        /// <value>The type of the identification.  Possible values: **iban**, **routingNumber**, **sortCode**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IdentificationTypeEnum
        {
            /// <summary>
            /// Enum Iban for value: iban
            /// </summary>
            [EnumMember(Value = "iban")]
            Iban = 1,

            /// <summary>
            /// Enum RoutingNumber for value: routingNumber
            /// </summary>
            [EnumMember(Value = "routingNumber")]
            RoutingNumber = 2,

            /// <summary>
            /// Enum SortCode for value: sortCode
            /// </summary>
            [EnumMember(Value = "sortCode")]
            SortCode = 3

        }


        /// <summary>
        /// The type of the identification.  Possible values: **iban**, **routingNumber**, **sortCode**.
        /// </summary>
        /// <value>The type of the identification.  Possible values: **iban**, **routingNumber**, **sortCode**.</value>
        [DataMember(Name = "identificationType", EmitDefaultValue = false)]
        public IdentificationTypeEnum? IdentificationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BankIdentification" /> class.
        /// </summary>
        /// <param name="country">Two-character [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code..</param>
        /// <param name="identification">The bank identification code..</param>
        /// <param name="identificationType">The type of the identification.  Possible values: **iban**, **routingNumber**, **sortCode**..</param>
        public BankIdentification(string country = default(string), string identification = default(string), IdentificationTypeEnum? identificationType = default(IdentificationTypeEnum?))
        {
            this.Country = country;
            this.Identification = identification;
            this.IdentificationType = identificationType;
        }

        /// <summary>
        /// Two-character [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code.
        /// </summary>
        /// <value>Two-character [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code.</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// The bank identification code.
        /// </summary>
        /// <value>The bank identification code.</value>
        [DataMember(Name = "identification", EmitDefaultValue = false)]
        public string Identification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BankIdentification {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Identification: ").Append(Identification).Append("\n");
            sb.Append("  IdentificationType: ").Append(IdentificationType).Append("\n");
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
            return this.Equals(input as BankIdentification);
        }

        /// <summary>
        /// Returns true if BankIdentification instances are equal
        /// </summary>
        /// <param name="input">Instance of BankIdentification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankIdentification input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Identification == input.Identification ||
                    (this.Identification != null &&
                    this.Identification.Equals(input.Identification))
                ) && 
                (
                    this.IdentificationType == input.IdentificationType ||
                    this.IdentificationType.Equals(input.IdentificationType)
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
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.Identification != null)
                {
                    hashCode = (hashCode * 59) + this.Identification.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IdentificationType.GetHashCode();
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
