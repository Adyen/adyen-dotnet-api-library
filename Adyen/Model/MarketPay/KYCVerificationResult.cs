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
        /// <param name="accountHolder">accountHolder (required).</param>
        /// <param name="bankAccounts">The result(s) of the checks on the bank account(s). (required).</param>
        /// <param name="shareholders">The result(s) of the checks on the shareholder(s). (required).</param>
        public KYCVerificationResult(KYCCheckResult accountHolder = default(KYCCheckResult), List<KYCBankAccountCheckResult> bankAccounts = default(List<KYCBankAccountCheckResult>), List<KYCShareholderCheckResult> shareholders = default(List<KYCShareholderCheckResult>))
        {
            this.AccountHolder = accountHolder;
            this.Shareholders = shareholders;
            this.BankAccounts = bankAccounts;
        }

        /// <summary>
        /// Gets or Sets AccountHolder
        /// </summary>
        [DataMember(Name="accountHolder", EmitDefaultValue=false)]
        public KYCCheckResult AccountHolder { get; set; }

        /// <summary>
        /// The result(s) of the checks on the bank account(s).
        /// </summary>
        /// <value>The result(s) of the checks on the bank account(s).</value>
        [DataMember(Name="bankAccounts", EmitDefaultValue=false)]
        public List<KYCBankAccountCheckResult> BankAccounts { get; set; }

        /// <summary>
        /// The result(s) of the checks on the shareholder(s).
        /// </summary>
        /// <value>The result(s) of the checks on the shareholder(s).</value>
        [DataMember(Name="shareholders", EmitDefaultValue=false)]
        public List<KYCShareholderCheckResult> Shareholders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KYCVerificationResult {\n");
            sb.Append("  AccountHolder: ").Append(AccountHolder).Append("\n");
            sb.Append("  BankAccounts: ").Append(BankAccounts).Append("\n");
            sb.Append("  Shareholders: ").Append(Shareholders).Append("\n");
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
                    this.BankAccounts == input.BankAccounts ||
                    this.BankAccounts != null &&
                    input.BankAccounts != null &&
                    this.BankAccounts.SequenceEqual(input.BankAccounts)
                ) && 
                (
                    this.Shareholders == input.Shareholders ||
                    this.Shareholders != null &&
                    input.Shareholders != null &&
                    this.Shareholders.SequenceEqual(input.Shareholders)
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
                if (this.BankAccounts != null)
                    hashCode = hashCode * 59 + this.BankAccounts.GetHashCode();
                if (this.Shareholders != null)
                    hashCode = hashCode * 59 + this.Shareholders.GetHashCode();
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
