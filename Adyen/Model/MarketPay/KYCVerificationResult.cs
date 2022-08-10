#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
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
        public partial class KYCVerificationResult :  IEquatable<KYCVerificationResult>, IValidatableObject
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
            this.AccountHolder = accountHolder;
            this.LegalArrangements = legalArrangements;
            this.LegalArrangementsEntities = legalArrangementsEntities;
            this.PayoutMethods = payoutMethods;
            this.Shareholders = shareholders;
            this.Signatories = signatories;
            this.UltimateParentCompany = ultimateParentCompany;
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
            return this.Equals(input as KYCVerificationResult);
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
                    this.AccountHolder == input.AccountHolder ||
                    (this.AccountHolder != null &&
                    this.AccountHolder.Equals(input.AccountHolder))
                ) && 
                (
                    this.LegalArrangements == input.LegalArrangements ||
                    this.LegalArrangements != null &&
                    input.LegalArrangements != null &&
                    this.LegalArrangements.SequenceEqual(input.LegalArrangements)
                ) && 
                (
                    this.LegalArrangementsEntities == input.LegalArrangementsEntities ||
                    this.LegalArrangementsEntities != null &&
                    input.LegalArrangementsEntities != null &&
                    this.LegalArrangementsEntities.SequenceEqual(input.LegalArrangementsEntities)
                ) && 
                (
                    this.PayoutMethods == input.PayoutMethods ||
                    this.PayoutMethods != null &&
                    input.PayoutMethods != null &&
                    this.PayoutMethods.SequenceEqual(input.PayoutMethods)
                ) && 
                (
                    this.Shareholders == input.Shareholders ||
                    this.Shareholders != null &&
                    input.Shareholders != null &&
                    this.Shareholders.SequenceEqual(input.Shareholders)
                ) && 
                (
                    this.Signatories == input.Signatories ||
                    this.Signatories != null &&
                    input.Signatories != null &&
                    this.Signatories.SequenceEqual(input.Signatories)
                ) && 
                (
                    this.UltimateParentCompany == input.UltimateParentCompany ||
                    this.UltimateParentCompany != null &&
                    input.UltimateParentCompany != null &&
                    this.UltimateParentCompany.SequenceEqual(input.UltimateParentCompany)
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
                if (this.AccountHolder != null)
                    hashCode = hashCode * 59 + this.AccountHolder.GetHashCode();
                if (this.LegalArrangements != null)
                    hashCode = hashCode * 59 + this.LegalArrangements.GetHashCode();
                if (this.LegalArrangementsEntities != null)
                    hashCode = hashCode * 59 + this.LegalArrangementsEntities.GetHashCode();
                if (this.PayoutMethods != null)
                    hashCode = hashCode * 59 + this.PayoutMethods.GetHashCode();
                if (this.Shareholders != null)
                    hashCode = hashCode * 59 + this.Shareholders.GetHashCode();
                if (this.Signatories != null)
                    hashCode = hashCode * 59 + this.Signatories.GetHashCode();
                if (this.UltimateParentCompany != null)
                    hashCode = hashCode * 59 + this.UltimateParentCompany.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
