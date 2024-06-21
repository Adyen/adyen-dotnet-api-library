/*
* Adyen Payment API
*
*
* The version of the OpenAPI document: 68
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

namespace Adyen.Model.Payment
{
    /// <summary>
    /// ThreeDS2ResultResponse
    /// </summary>
    [DataContract(Name = "ThreeDS2ResultResponse")]
    public partial class ThreeDS2ResultResponse : IEquatable<ThreeDS2ResultResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDS2ResultResponse" /> class.
        /// </summary>
        /// <param name="threeDS2Result">threeDS2Result.</param>
        public ThreeDS2ResultResponse(ThreeDS2Result threeDS2Result = default(ThreeDS2Result))
        {
            this.ThreeDS2Result = threeDS2Result;
        }

        /// <summary>
        /// Gets or Sets ThreeDS2Result
        /// </summary>
        [DataMember(Name = "threeDS2Result", EmitDefaultValue = false)]
        public ThreeDS2Result ThreeDS2Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ThreeDS2ResultResponse {\n");
            sb.Append("  ThreeDS2Result: ").Append(ThreeDS2Result).Append("\n");
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
            return this.Equals(input as ThreeDS2ResultResponse);
        }

        /// <summary>
        /// Returns true if ThreeDS2ResultResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ThreeDS2ResultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThreeDS2ResultResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ThreeDS2Result == input.ThreeDS2Result ||
                    (this.ThreeDS2Result != null &&
                    this.ThreeDS2Result.Equals(input.ThreeDS2Result))
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
                if (this.ThreeDS2Result != null)
                {
                    hashCode = (hashCode * 59) + this.ThreeDS2Result.GetHashCode();
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
