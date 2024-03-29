/*
* Disputes API
*
*
* The version of the OpenAPI document: 30
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

namespace Adyen.Model.Disputes
{
    /// <summary>
    /// DisputeServiceResult
    /// </summary>
    [DataContract(Name = "DisputeServiceResult")]
    public partial class DisputeServiceResult : IEquatable<DisputeServiceResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisputeServiceResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DisputeServiceResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DisputeServiceResult" /> class.
        /// </summary>
        /// <param name="errorMessage">The general error message..</param>
        /// <param name="success">Indicates whether the request succeeded. (required).</param>
        public DisputeServiceResult(string errorMessage = default(string), bool? success = default(bool?))
        {
            this.Success = success;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// The general error message.
        /// </summary>
        /// <value>The general error message.</value>
        [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Indicates whether the request succeeded.
        /// </summary>
        /// <value>Indicates whether the request succeeded.</value>
        [DataMember(Name = "success", IsRequired = false, EmitDefaultValue = false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DisputeServiceResult {\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
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
            return this.Equals(input as DisputeServiceResult);
        }

        /// <summary>
        /// Returns true if DisputeServiceResult instances are equal
        /// </summary>
        /// <param name="input">Instance of DisputeServiceResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisputeServiceResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.Success == input.Success ||
                    this.Success.Equals(input.Success)
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
                if (this.ErrorMessage != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorMessage.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Success.GetHashCode();
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
