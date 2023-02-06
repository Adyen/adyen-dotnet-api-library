/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
* Contact: developer-experience@adyen.com
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

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// CardBrandDetails
    /// </summary>
    [DataContract(Name = "CardBrandDetails")]
    public partial class CardBrandDetails : IEquatable<CardBrandDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardBrandDetails" /> class.
        /// </summary>
        /// <param name="supported">Indicates if you support the card brand..</param>
        /// <param name="type">The name of the card brand..</param>
        public CardBrandDetails(bool supported = default(bool), string type = default(string))
        {
            this.Supported = supported;
            this.Type = type;
        }

        /// <summary>
        /// Indicates if you support the card brand.
        /// </summary>
        /// <value>Indicates if you support the card brand.</value>
        [DataMember(Name = "supported", EmitDefaultValue = false)]
        public bool Supported { get; set; }

        /// <summary>
        /// The name of the card brand.
        /// </summary>
        /// <value>The name of the card brand.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CardBrandDetails {\n");
            sb.Append("  Supported: ").Append(Supported).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as CardBrandDetails);
        }

        /// <summary>
        /// Returns true if CardBrandDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of CardBrandDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardBrandDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Supported == input.Supported ||
                    this.Supported.Equals(input.Supported)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                hashCode = (hashCode * 59) + this.Supported.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
