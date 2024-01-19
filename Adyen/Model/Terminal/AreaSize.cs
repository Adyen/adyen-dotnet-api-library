/*
* Adyen Terminal API
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

namespace Adyen.Model.Terminal
{
    /// <summary>
    /// AreaSize
    /// </summary>
    [DataContract(Name = "AreaSize")]
    public partial class AreaSize : IEquatable<AreaSize>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AreaSize" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AreaSize() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AreaSize" /> class.
        /// </summary>
        /// <param name="x">x (required).</param>
        /// <param name="y">y (required).</param>
        public AreaSize(string x = default(string), string y = default(string))
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Gets or Sets X
        /// </summary>
        [DataMember(Name = "X", IsRequired = false, EmitDefaultValue = false)]
        public string X { get; set; }

        /// <summary>
        /// Gets or Sets Y
        /// </summary>
        [DataMember(Name = "Y", IsRequired = false, EmitDefaultValue = false)]
        public string Y { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AreaSize {\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
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
            return this.Equals(input as AreaSize);
        }

        /// <summary>
        /// Returns true if AreaSize instances are equal
        /// </summary>
        /// <param name="input">Instance of AreaSize to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AreaSize input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.X == input.X ||
                    (this.X != null &&
                    this.X.Equals(input.X))
                ) && 
                (
                    this.Y == input.Y ||
                    (this.Y != null &&
                    this.Y.Equals(input.Y))
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
                if (this.X != null)
                {
                    hashCode = (hashCode * 59) + this.X.GetHashCode();
                }
                if (this.Y != null)
                {
                    hashCode = (hashCode * 59) + this.Y.GetHashCode();
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
