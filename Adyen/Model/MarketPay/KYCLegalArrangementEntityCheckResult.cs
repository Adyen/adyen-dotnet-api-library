using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Util;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// KYCLegalArrangementEntityCheckResult
    /// </summary>
    [DataContract]
        public class KYCLegalArrangementEntityCheckResult :  IEquatable<KYCLegalArrangementEntityCheckResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KYCLegalArrangementEntityCheckResult" /> class.
        /// </summary>
        /// <param name="checks">A list of the checks and their statuses..</param>
        /// <param name="legalArrangementCode">The unique ID of the legal arrangement to which the entity belongs..</param>
        /// <param name="legalArrangementEntityCode">The unique ID of the legal arrangement entity to which the check applies..</param>
        public KYCLegalArrangementEntityCheckResult(List<KYCCheckStatusData> checks = default(List<KYCCheckStatusData>), string legalArrangementCode = default(string), string legalArrangementEntityCode = default(string))
        {
            Checks = checks;
            LegalArrangementCode = legalArrangementCode;
            LegalArrangementEntityCode = legalArrangementEntityCode;
        }
        
        /// <summary>
        /// A list of the checks and their statuses.
        /// </summary>
        /// <value>A list of the checks and their statuses.</value>
        [DataMember(Name="checks", EmitDefaultValue=false)]
        public List<KYCCheckStatusData> Checks { get; set; }

        /// <summary>
        /// The unique ID of the legal arrangement to which the entity belongs.
        /// </summary>
        /// <value>The unique ID of the legal arrangement to which the entity belongs.</value>
        [DataMember(Name="legalArrangementCode", EmitDefaultValue=false)]
        public string LegalArrangementCode { get; set; }

        /// <summary>
        /// The unique ID of the legal arrangement entity to which the check applies.
        /// </summary>
        /// <value>The unique ID of the legal arrangement entity to which the check applies.</value>
        [DataMember(Name="legalArrangementEntityCode", EmitDefaultValue=false)]
        public string LegalArrangementEntityCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KYCLegalArrangementEntityCheckResult {\n");
            sb.Append("  Checks: ").Append(Checks.ObjectListToString()).Append("\n");
            sb.Append("  LegalArrangementCode: ").Append(LegalArrangementCode).Append("\n");
            sb.Append("  LegalArrangementEntityCode: ").Append(LegalArrangementEntityCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as KYCLegalArrangementEntityCheckResult);
        }

        /// <summary>
        /// Returns true if KYCLegalArrangementEntityCheckResult instances are equal
        /// </summary>
        /// <param name="input">Instance of KYCLegalArrangementEntityCheckResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KYCLegalArrangementEntityCheckResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    Checks == input.Checks ||
                    Checks != null &&
                    input.Checks != null &&
                    Checks.SequenceEqual(input.Checks)
                ) && 
                (
                    LegalArrangementCode == input.LegalArrangementCode ||
                    (LegalArrangementCode != null &&
                    LegalArrangementCode.Equals(input.LegalArrangementCode))
                ) && 
                (
                    LegalArrangementEntityCode == input.LegalArrangementEntityCode ||
                    (LegalArrangementEntityCode != null &&
                    LegalArrangementEntityCode.Equals(input.LegalArrangementEntityCode))
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
                if (Checks != null)
                    hashCode = hashCode * 59 + Checks.GetHashCode();
                if (LegalArrangementCode != null)
                    hashCode = hashCode * 59 + LegalArrangementCode.GetHashCode();
                if (LegalArrangementEntityCode != null)
                    hashCode = hashCode * 59 + LegalArrangementEntityCode.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}