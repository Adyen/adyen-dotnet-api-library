/*
* Account API
*
*
* The version of the OpenAPI document: 6
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

namespace Adyen.Model.PlatformsAccount
{
    /// <summary>
    /// KYCUltimateParentCompanyCheckResult
    /// </summary>
    [DataContract(Name = "KYCUltimateParentCompanyCheckResult")]
    public partial class KYCUltimateParentCompanyCheckResult : IEquatable<KYCUltimateParentCompanyCheckResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KYCUltimateParentCompanyCheckResult" /> class.
        /// </summary>
        /// <param name="checks">A list of the checks and their statuses..</param>
        /// <param name="ultimateParentCompanyCode">The code of the Ultimate Parent Company to which the check applies..</param>
        public KYCUltimateParentCompanyCheckResult(List<KYCCheckStatusData> checks = default(List<KYCCheckStatusData>), string ultimateParentCompanyCode = default(string))
        {
            this.Checks = checks;
            this.UltimateParentCompanyCode = ultimateParentCompanyCode;
        }

        /// <summary>
        /// A list of the checks and their statuses.
        /// </summary>
        /// <value>A list of the checks and their statuses.</value>
        [DataMember(Name = "checks", EmitDefaultValue = false)]
        public List<KYCCheckStatusData> Checks { get; set; }

        /// <summary>
        /// The code of the Ultimate Parent Company to which the check applies.
        /// </summary>
        /// <value>The code of the Ultimate Parent Company to which the check applies.</value>
        [DataMember(Name = "ultimateParentCompanyCode", EmitDefaultValue = false)]
        public string UltimateParentCompanyCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KYCUltimateParentCompanyCheckResult {\n");
            sb.Append("  Checks: ").Append(Checks).Append("\n");
            sb.Append("  UltimateParentCompanyCode: ").Append(UltimateParentCompanyCode).Append("\n");
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
            return this.Equals(input as KYCUltimateParentCompanyCheckResult);
        }

        /// <summary>
        /// Returns true if KYCUltimateParentCompanyCheckResult instances are equal
        /// </summary>
        /// <param name="input">Instance of KYCUltimateParentCompanyCheckResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KYCUltimateParentCompanyCheckResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Checks == input.Checks ||
                    this.Checks != null &&
                    input.Checks != null &&
                    this.Checks.SequenceEqual(input.Checks)
                ) && 
                (
                    this.UltimateParentCompanyCode == input.UltimateParentCompanyCode ||
                    (this.UltimateParentCompanyCode != null &&
                    this.UltimateParentCompanyCode.Equals(input.UltimateParentCompanyCode))
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
                if (this.Checks != null)
                {
                    hashCode = (hashCode * 59) + this.Checks.GetHashCode();
                }
                if (this.UltimateParentCompanyCode != null)
                {
                    hashCode = (hashCode * 59) + this.UltimateParentCompanyCode.GetHashCode();
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
