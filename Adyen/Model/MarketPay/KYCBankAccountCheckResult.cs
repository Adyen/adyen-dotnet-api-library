using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// KYCBankAccountCheckResult
    /// </summary>
    [DataContract]
        public class KYCBankAccountCheckResult :  IEquatable<KYCBankAccountCheckResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KYCBankAccountCheckResult" /> class.
        /// </summary>
        /// <param name="bankAccountUUID">The unique ID of the bank account to which the check applies. (required).</param>
        /// <param name="checks">A list of the checks and their statuses. (required).</param>
        public KYCBankAccountCheckResult(string bankAccountUUID = default(string), List<KYCCheckStatusData> checks = default(List<KYCCheckStatusData>))
        {
            // to ensure "bankAccountUUID" is required (not null)
            if (bankAccountUUID == null)
            {
                throw new InvalidDataException("bankAccountUUID is a required property for KYCBankAccountCheckResult and cannot be null");
            }

            BankAccountUUID = bankAccountUUID;
            // to ensure "checks" is required (not null)
            if (checks == null)
            {
                throw new InvalidDataException("checks is a required property for KYCBankAccountCheckResult and cannot be null");
            }

            Checks = checks;
        }
        
        /// <summary>
        /// The unique ID of the bank account to which the check applies.
        /// </summary>
        /// <value>The unique ID of the bank account to which the check applies.</value>
        [DataMember(Name="bankAccountUUID", EmitDefaultValue=false)]
        public string BankAccountUUID { get; set; }

        /// <summary>
        /// A list of the checks and their statuses.
        /// </summary>
        /// <value>A list of the checks and their statuses.</value>
        [DataMember(Name="checks", EmitDefaultValue=false)]
        public List<KYCCheckStatusData> Checks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KYCBankAccountCheckResult {\n");
            sb.Append("  BankAccountUUID: ").Append(BankAccountUUID).Append("\n");
            sb.Append("  Checks: ").Append(Checks).Append("\n");
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
            return Equals(input as KYCBankAccountCheckResult);
        }

        /// <summary>
        /// Returns true if KYCBankAccountCheckResult instances are equal
        /// </summary>
        /// <param name="input">Instance of KYCBankAccountCheckResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KYCBankAccountCheckResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    BankAccountUUID == input.BankAccountUUID ||
                    (BankAccountUUID != null &&
                    BankAccountUUID.Equals(input.BankAccountUUID))
                ) && 
                (
                    Checks == input.Checks ||
                    Checks != null &&
                    input.Checks != null &&
                    Checks.SequenceEqual(input.Checks)
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
                if (BankAccountUUID != null)
                    hashCode = hashCode * 59 + BankAccountUUID.GetHashCode();
                if (Checks != null)
                    hashCode = hashCode * 59 + Checks.GetHashCode();
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
