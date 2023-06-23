/*
* Legal Entity Management API
*
*
* The version of the OpenAPI document: 3
* 
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

namespace Adyen.Model.LegalEntityManagement
{
    /// <summary>
    /// BusinessLines
    /// </summary>
    [DataContract(Name = "BusinessLines")]
    public partial class BusinessLines : IEquatable<BusinessLines>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLines" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BusinessLines() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLines" /> class.
        /// </summary>
        /// <param name="businessLines">List of business lines. (required).</param>
        public BusinessLines(List<BusinessLine> businessLines = default(List<BusinessLine>))
        {
            this._BusinessLines = businessLines;
        }

        /// <summary>
        /// List of business lines.
        /// </summary>
        /// <value>List of business lines.</value>
        [DataMember(Name = "businessLines", IsRequired = false, EmitDefaultValue = false)]
        public List<BusinessLine> _BusinessLines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BusinessLines {\n");
            sb.Append("  _BusinessLines: ").Append(_BusinessLines).Append("\n");
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
            return this.Equals(input as BusinessLines);
        }

        /// <summary>
        /// Returns true if BusinessLines instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessLines to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessLines input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._BusinessLines == input._BusinessLines ||
                    this._BusinessLines != null &&
                    input._BusinessLines != null &&
                    this._BusinessLines.SequenceEqual(input._BusinessLines)
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
                if (this._BusinessLines != null)
                {
                    hashCode = (hashCode * 59) + this._BusinessLines.GetHashCode();
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
