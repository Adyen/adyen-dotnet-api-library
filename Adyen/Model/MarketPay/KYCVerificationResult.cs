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
    /// KYCVerificationResult
    /// </summary>
    [DataContract]
        public class KYCVerificationResult :  IEquatable<KYCVerificationResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KYCVerificationResult" /> class.
        /// </summary>
        /// <param name="accountHolder">accountHolder.</param>
        /// <param name="legalArrangements">The results of the checks on the legal arrangements..</param>
        /// <param name="legalArrangementsEntities">The results of the checks on the legal arrangement entities..</param>
        /// <param name="payoutMethods">The results of the checks on the payout methods..</param>
        /// <param name="shareholders">The results of the checks on the shareholders..</param>
        /// <param name="signatories">The results of the checks on the signatories..</param>
        /// <param name="ultimateParentCompany">The result of the check on the Ultimate Parent Company..</param>
        public KYCVerificationResult(KYCCheckResult accountHolder = default(KYCCheckResult), List<KYCLegalArrangementCheckResult> legalArrangements = default(List<KYCLegalArrangementCheckResult>), List<KYCLegalArrangementEntityCheckResult> legalArrangementsEntities = default(List<KYCLegalArrangementEntityCheckResult>), List<KYCPayoutMethodCheckResult> payoutMethods = default(List<KYCPayoutMethodCheckResult>), List<KYCShareholderCheckResult> shareholders = default(List<KYCShareholderCheckResult>), List<KYCSignatoryCheckResult> signatories = default(List<KYCSignatoryCheckResult>), List<KYCUltimateParentCompanyCheckResult> ultimateParentCompany = default(List<KYCUltimateParentCompanyCheckResult>))
        {
            AccountHolder = accountHolder;
            LegalArrangements = legalArrangements;
            LegalArrangementsEntities = legalArrangementsEntities;
            PayoutMethods = payoutMethods;
            Shareholders = shareholders;
            Signatories = signatories;
            UltimateParentCompany = ultimateParentCompany;
        }
        
        /// <summary>
        /// Gets or Sets AccountHolder
        /// </summary>
        [DataMember(Name="accountHolder", EmitDefaultValue=false)]
        public KYCCheckResult AccountHolder { get; set; }

        /// <summary>
        /// The results of the checks on the legal arrangements.
        /// </summary>
        /// <value>The results of the checks on the legal arrangements.</value>
        [DataMember(Name="legalArrangements", EmitDefaultValue=false)]
        public List<KYCLegalArrangementCheckResult> LegalArrangements { get; set; }

        /// <summary>
        /// The results of the checks on the legal arrangement entities.
        /// </summary>
        /// <value>The results of the checks on the legal arrangement entities.</value>
        [DataMember(Name="legalArrangementsEntities", EmitDefaultValue=false)]
        public List<KYCLegalArrangementEntityCheckResult> LegalArrangementsEntities { get; set; }

        /// <summary>
        /// The results of the checks on the payout methods.
        /// </summary>
        /// <value>The results of the checks on the payout methods.</value>
        [DataMember(Name="payoutMethods", EmitDefaultValue=false)]
        public List<KYCPayoutMethodCheckResult> PayoutMethods { get; set; }

        /// <summary>
        /// The results of the checks on the shareholders.
        /// </summary>
        /// <value>The results of the checks on the shareholders.</value>
        [DataMember(Name="shareholders", EmitDefaultValue=false)]
        public List<KYCShareholderCheckResult> Shareholders { get; set; }

        /// <summary>
        /// The results of the checks on the signatories.
        /// </summary>
        /// <value>The results of the checks on the signatories.</value>
        [DataMember(Name="signatories", EmitDefaultValue=false)]
        public List<KYCSignatoryCheckResult> Signatories { get; set; }

        /// <summary>
        /// The result of the check on the Ultimate Parent Company.
        /// </summary>
        /// <value>The result of the check on the Ultimate Parent Company.</value>
        [DataMember(Name="ultimateParentCompany", EmitDefaultValue=false)]
        public List<KYCUltimateParentCompanyCheckResult> UltimateParentCompany { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KYCVerificationResult {\n");
            sb.Append("  AccountHolder: ").Append(AccountHolder).Append("\n");
            sb.Append("  LegalArrangements: ").Append(LegalArrangements.ObjectListToString()).Append("\n");
            sb.Append("  LegalArrangementsEntities: ").Append(LegalArrangementsEntities.ObjectListToString()).Append("\n");
            sb.Append("  PayoutMethods: ").Append(PayoutMethods.ObjectListToString()).Append("\n");
            sb.Append("  Shareholders: ").Append(Shareholders.ObjectListToString()).Append("\n");
            sb.Append("  Signatories: ").Append(Signatories.ObjectListToString()).Append("\n");
            sb.Append("  UltimateParentCompany: ").Append(UltimateParentCompany.ObjectListToString()).Append("\n");
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
            return Equals(input as KYCVerificationResult);
        }

        /// <summary>
        /// Returns true if KYCVerificationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of KYCVerificationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KYCVerificationResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    AccountHolder == input.AccountHolder ||
                    (AccountHolder != null &&
                    AccountHolder.Equals(input.AccountHolder))
                ) && 
                (
                    LegalArrangements == input.LegalArrangements ||
                    LegalArrangements != null &&
                    input.LegalArrangements != null &&
                    LegalArrangements.SequenceEqual(input.LegalArrangements)
                ) && 
                (
                    LegalArrangementsEntities == input.LegalArrangementsEntities ||
                    LegalArrangementsEntities != null &&
                    input.LegalArrangementsEntities != null &&
                    LegalArrangementsEntities.SequenceEqual(input.LegalArrangementsEntities)
                ) && 
                (
                    PayoutMethods == input.PayoutMethods ||
                    PayoutMethods != null &&
                    input.PayoutMethods != null &&
                    PayoutMethods.SequenceEqual(input.PayoutMethods)
                ) && 
                (
                    Shareholders == input.Shareholders ||
                    Shareholders != null &&
                    input.Shareholders != null &&
                    Shareholders.SequenceEqual(input.Shareholders)
                ) && 
                (
                    Signatories == input.Signatories ||
                    Signatories != null &&
                    input.Signatories != null &&
                    Signatories.SequenceEqual(input.Signatories)
                ) && 
                (
                    UltimateParentCompany == input.UltimateParentCompany ||
                    UltimateParentCompany != null &&
                    input.UltimateParentCompany != null &&
                    UltimateParentCompany.SequenceEqual(input.UltimateParentCompany)
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
                if (AccountHolder != null)
                    hashCode = hashCode * 59 + AccountHolder.GetHashCode();
                if (LegalArrangements != null)
                    hashCode = hashCode * 59 + LegalArrangements.GetHashCode();
                if (LegalArrangementsEntities != null)
                    hashCode = hashCode * 59 + LegalArrangementsEntities.GetHashCode();
                if (PayoutMethods != null)
                    hashCode = hashCode * 59 + PayoutMethods.GetHashCode();
                if (Shareholders != null)
                    hashCode = hashCode * 59 + Shareholders.GetHashCode();
                if (Signatories != null)
                    hashCode = hashCode * 59 + Signatories.GetHashCode();
                if (UltimateParentCompany != null)
                    hashCode = hashCode * 59 + UltimateParentCompany.GetHashCode();
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
