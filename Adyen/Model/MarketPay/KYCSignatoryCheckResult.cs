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
    /// KYCSignatoryCheckResult
    /// </summary>
    [DataContract]
        public class KYCSignatoryCheckResult :  IEquatable<KYCSignatoryCheckResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KYCSignatoryCheckResult" /> class.
        /// </summary>
        /// <param name="checks">A list of the checks and their statuses..</param>
        /// <param name="signatoryCode">The code of the signatory to which the check applies..</param>
        public KYCSignatoryCheckResult(List<KYCCheckStatusData> checks = default(List<KYCCheckStatusData>), string signatoryCode = default(string))
        {
            Checks = checks;
            SignatoryCode = signatoryCode;
        }
        
        /// <summary>
        /// A list of the checks and their statuses.
        /// </summary>
        /// <value>A list of the checks and their statuses.</value>
        [DataMember(Name="checks", EmitDefaultValue=false)]
        public List<KYCCheckStatusData> Checks { get; set; }

        /// <summary>
        /// The code of the signatory to which the check applies.
        /// </summary>
        /// <value>The code of the signatory to which the check applies.</value>
        [DataMember(Name="signatoryCode", EmitDefaultValue=false)]
        public string SignatoryCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KYCSignatoryCheckResult {\n");
            sb.Append("  Checks: ").Append(Checks.ObjectListToString()).Append("\n");
            sb.Append("  SignatoryCode: ").Append(SignatoryCode).Append("\n");
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
            return Equals(input as KYCSignatoryCheckResult);
        }

        /// <summary>
        /// Returns true if KYCSignatoryCheckResult instances are equal
        /// </summary>
        /// <param name="input">Instance of KYCSignatoryCheckResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KYCSignatoryCheckResult input)
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
                    SignatoryCode == input.SignatoryCode ||
                    (SignatoryCode != null &&
                    SignatoryCode.Equals(input.SignatoryCode))
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
                if (SignatoryCode != null)
                    hashCode = hashCode * 59 + SignatoryCode.GetHashCode();
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