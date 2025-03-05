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
    /// AffirmInfo
    /// </summary>
    [DataContract(Name = "AffirmInfo")]
    public partial class AffirmInfo : IEquatable<AffirmInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AffirmInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AffirmInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AffirmInfo" /> class.
        /// </summary>
        /// <param name="supportEmail">Merchant support email (required).</param>
        public AffirmInfo(string supportEmail = default(string))
        {
            this.SupportEmail = supportEmail;
        }

        /// <summary>
        /// Merchant support email
        /// </summary>
        /// <value>Merchant support email</value>
        [DataMember(Name = "supportEmail", IsRequired = false, EmitDefaultValue = false)]
        public string SupportEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AffirmInfo {\n");
            sb.Append("  SupportEmail: ").Append(SupportEmail).Append("\n");
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
            return this.Equals(input as AffirmInfo);
        }

        /// <summary>
        /// Returns true if AffirmInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AffirmInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AffirmInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SupportEmail == input.SupportEmail ||
                    (this.SupportEmail != null &&
                    this.SupportEmail.Equals(input.SupportEmail))
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
                if (this.SupportEmail != null)
                {
                    hashCode = (hashCode * 59) + this.SupportEmail.GetHashCode();
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
