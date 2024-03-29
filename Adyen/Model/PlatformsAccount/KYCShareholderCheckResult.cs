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
    /// KYCShareholderCheckResult
    /// </summary>
    [DataContract(Name = "KYCShareholderCheckResult")]
    public partial class KYCShareholderCheckResult : IEquatable<KYCShareholderCheckResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KYCShareholderCheckResult" /> class.
        /// </summary>
        /// <param name="checks">A list of the checks and their statuses..</param>
        /// <param name="legalArrangementCode">The unique ID of the legal arrangement to which the shareholder belongs, if applicable..</param>
        /// <param name="legalArrangementEntityCode">The unique ID of the legal arrangement entity to which the shareholder belongs, if applicable..</param>
        /// <param name="shareholderCode">The code of the shareholder to which the check applies..</param>
        public KYCShareholderCheckResult(List<KYCCheckStatusData> checks = default(List<KYCCheckStatusData>), string legalArrangementCode = default(string), string legalArrangementEntityCode = default(string), string shareholderCode = default(string))
        {
            this.Checks = checks;
            this.LegalArrangementCode = legalArrangementCode;
            this.LegalArrangementEntityCode = legalArrangementEntityCode;
            this.ShareholderCode = shareholderCode;
        }

        /// <summary>
        /// A list of the checks and their statuses.
        /// </summary>
        /// <value>A list of the checks and their statuses.</value>
        [DataMember(Name = "checks", EmitDefaultValue = false)]
        public List<KYCCheckStatusData> Checks { get; set; }

        /// <summary>
        /// The unique ID of the legal arrangement to which the shareholder belongs, if applicable.
        /// </summary>
        /// <value>The unique ID of the legal arrangement to which the shareholder belongs, if applicable.</value>
        [DataMember(Name = "legalArrangementCode", EmitDefaultValue = false)]
        public string LegalArrangementCode { get; set; }

        /// <summary>
        /// The unique ID of the legal arrangement entity to which the shareholder belongs, if applicable.
        /// </summary>
        /// <value>The unique ID of the legal arrangement entity to which the shareholder belongs, if applicable.</value>
        [DataMember(Name = "legalArrangementEntityCode", EmitDefaultValue = false)]
        public string LegalArrangementEntityCode { get; set; }

        /// <summary>
        /// The code of the shareholder to which the check applies.
        /// </summary>
        /// <value>The code of the shareholder to which the check applies.</value>
        [DataMember(Name = "shareholderCode", EmitDefaultValue = false)]
        public string ShareholderCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KYCShareholderCheckResult {\n");
            sb.Append("  Checks: ").Append(Checks).Append("\n");
            sb.Append("  LegalArrangementCode: ").Append(LegalArrangementCode).Append("\n");
            sb.Append("  LegalArrangementEntityCode: ").Append(LegalArrangementEntityCode).Append("\n");
            sb.Append("  ShareholderCode: ").Append(ShareholderCode).Append("\n");
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
            return this.Equals(input as KYCShareholderCheckResult);
        }

        /// <summary>
        /// Returns true if KYCShareholderCheckResult instances are equal
        /// </summary>
        /// <param name="input">Instance of KYCShareholderCheckResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KYCShareholderCheckResult input)
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
                    this.LegalArrangementCode == input.LegalArrangementCode ||
                    (this.LegalArrangementCode != null &&
                    this.LegalArrangementCode.Equals(input.LegalArrangementCode))
                ) && 
                (
                    this.LegalArrangementEntityCode == input.LegalArrangementEntityCode ||
                    (this.LegalArrangementEntityCode != null &&
                    this.LegalArrangementEntityCode.Equals(input.LegalArrangementEntityCode))
                ) && 
                (
                    this.ShareholderCode == input.ShareholderCode ||
                    (this.ShareholderCode != null &&
                    this.ShareholderCode.Equals(input.ShareholderCode))
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
                if (this.LegalArrangementCode != null)
                {
                    hashCode = (hashCode * 59) + this.LegalArrangementCode.GetHashCode();
                }
                if (this.LegalArrangementEntityCode != null)
                {
                    hashCode = (hashCode * 59) + this.LegalArrangementEntityCode.GetHashCode();
                }
                if (this.ShareholderCode != null)
                {
                    hashCode = (hashCode * 59) + this.ShareholderCode.GetHashCode();
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
