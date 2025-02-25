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
    /// AssociationDelegatedAuthenticationData
    /// </summary>
    [DataContract(Name = "AssociationDelegatedAuthenticationData")]
    public partial class AssociationDelegatedAuthenticationData : IEquatable<AssociationDelegatedAuthenticationData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociationDelegatedAuthenticationData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssociationDelegatedAuthenticationData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociationDelegatedAuthenticationData" /> class.
        /// </summary>
        /// <param name="sdkOutput">A base64-encoded block with the data required to authenticate the request. You obtain this information by using our authentication SDK. (required).</param>
        public AssociationDelegatedAuthenticationData(string sdkOutput = default(string))
        {
            this.SdkOutput = sdkOutput;
        }

        /// <summary>
        /// A base64-encoded block with the data required to authenticate the request. You obtain this information by using our authentication SDK.
        /// </summary>
        /// <value>A base64-encoded block with the data required to authenticate the request. You obtain this information by using our authentication SDK.</value>
        [DataMember(Name = "sdkOutput", IsRequired = false, EmitDefaultValue = false)]
        public string SdkOutput { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AssociationDelegatedAuthenticationData {\n");
            sb.Append("  SdkOutput: ").Append(SdkOutput).Append("\n");
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
            return this.Equals(input as AssociationDelegatedAuthenticationData);
        }

        /// <summary>
        /// Returns true if AssociationDelegatedAuthenticationData instances are equal
        /// </summary>
        /// <param name="input">Instance of AssociationDelegatedAuthenticationData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssociationDelegatedAuthenticationData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SdkOutput == input.SdkOutput ||
                    (this.SdkOutput != null &&
                    this.SdkOutput.Equals(input.SdkOutput))
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
                if (this.SdkOutput != null)
                {
                    hashCode = (hashCode * 59) + this.SdkOutput.GetHashCode();
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
            // SdkOutput (string) maxLength
            if (this.SdkOutput != null && this.SdkOutput.Length > 20000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SdkOutput, length must be less than 20000.", new [] { "SdkOutput" });
            }

            yield break;
        }
    }

}
