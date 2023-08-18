/*
* Management API
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// SwishInfo
    /// </summary>
    [DataContract(Name = "SwishInfo")]
    public partial class SwishInfo : IEquatable<SwishInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SwishInfo" /> class.
        /// </summary>
        /// <param name="swishNumber">Swish number. Format: 10 digits without spaces. For example, **1231111111**..</param>
        public SwishInfo(string swishNumber = default(string))
        {
            this.SwishNumber = swishNumber;
        }

        /// <summary>
        /// Swish number. Format: 10 digits without spaces. For example, **1231111111**.
        /// </summary>
        /// <value>Swish number. Format: 10 digits without spaces. For example, **1231111111**.</value>
        [DataMember(Name = "swishNumber", EmitDefaultValue = false)]
        public string SwishNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SwishInfo {\n");
            sb.Append("  SwishNumber: ").Append(SwishNumber).Append("\n");
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
            return this.Equals(input as SwishInfo);
        }

        /// <summary>
        /// Returns true if SwishInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SwishInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SwishInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SwishNumber == input.SwishNumber ||
                    (this.SwishNumber != null &&
                    this.SwishNumber.Equals(input.SwishNumber))
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
                if (this.SwishNumber != null)
                {
                    hashCode = (hashCode * 59) + this.SwishNumber.GetHashCode();
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
            // SwishNumber (string) maxLength
            if (this.SwishNumber != null && this.SwishNumber.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SwishNumber, length must be less than 10.", new [] { "SwishNumber" });
            }

            // SwishNumber (string) minLength
            if (this.SwishNumber != null && this.SwishNumber.Length < 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SwishNumber, length must be greater than 10.", new [] { "SwishNumber" });
            }

            yield break;
        }
    }

}
