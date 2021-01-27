#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// BankAccount
    /// </summary>
    [DataContract]
    public partial class BankAccount : IEquatable<BankAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount" /> class.
        /// </summary>
        /// <param name="bankAccountNumber">The bank account number (without separators)..</param>
        /// <param name="bankCity">The bank city..</param>
        /// <param name="bankLocationId">The location id of the bank. The field value is &#x60;nil&#x60; in most cases..</param>
        /// <param name="bankName">The name of the bank..</param>
        /// <param name="bic">The [Business Identifier Code](https://en.wikipedia.org/wiki/ISO_9362) (BIC) is the SWIFT address assigned to a bank. The field value is &#x60;nil&#x60; in most cases..</param>
        /// <param name="countryCode">Country code where the bank is located.  A valid value is an ISO two-character country code (e.g. &#x27;NL&#x27;)..</param>
        /// <param name="iban">The [International Bank Account Number](https://en.wikipedia.org/wiki/International_Bank_Account_Number) (IBAN)..</param>
        /// <param name="ownerName">The name of the bank account holder. If you submit a name with non-Latin characters, we automatically replace some of them with corresponding Latin characters to meet the FATF recommendations. For example: * χ12 is converted to ch12. * üA is converted to euA. * Peter Møller is converted to Peter Mller, because banks don&#x27;t accept &#x27;ø&#x27;. After replacement, the ownerName must have at least three alphanumeric characters (A-Z, a-z, 0-9), and at least one of them must be a valid Latin character (A-Z, a-z). For example: * John17 - allowed. * J17 - allowed. * 171 - not allowed. * John-7 - allowed. &gt; If provided details don&#x27;t match the required format, the response returns the error message: 203 &#x27;Invalid bank account holder name&#x27;..</param>
        /// <param name="taxId">The bank account holder&#x27;s tax ID..</param>
        public BankAccount(string bankAccountNumber = default(string), string bankCity = default(string),
            string bankLocationId = default(string), string bankName = default(string), string bic = default(string),
            string countryCode = default(string), string iban = default(string), string ownerName = default(string),
            string taxId = default(string))
        {
            this.BankAccountNumber = bankAccountNumber;
            this.BankCity = bankCity;
            this.BankLocationId = bankLocationId;
            this.BankName = bankName;
            this.Bic = bic;
            this.CountryCode = countryCode;
            this.Iban = iban;
            this.OwnerName = ownerName;
            this.TaxId = taxId;
        }

        /// <summary>
        /// The bank account number (without separators).
        /// </summary>
        /// <value>The bank account number (without separators).</value>
        [DataMember(Name = "bankAccountNumber", EmitDefaultValue = false)]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// The bank city.
        /// </summary>
        /// <value>The bank city.</value>
        [DataMember(Name = "bankCity", EmitDefaultValue = false)]
        public string BankCity { get; set; }

        /// <summary>
        /// The location id of the bank. The field value is &#x60;nil&#x60; in most cases.
        /// </summary>
        /// <value>The location id of the bank. The field value is &#x60;nil&#x60; in most cases.</value>
        [DataMember(Name = "bankLocationId", EmitDefaultValue = false)]
        public string BankLocationId { get; set; }

        /// <summary>
        /// The name of the bank.
        /// </summary>
        /// <value>The name of the bank.</value>
        [DataMember(Name = "bankName", EmitDefaultValue = false)]
        public string BankName { get; set; }

        /// <summary>
        /// The [Business Identifier Code](https://en.wikipedia.org/wiki/ISO_9362) (BIC) is the SWIFT address assigned to a bank. The field value is &#x60;nil&#x60; in most cases.
        /// </summary>
        /// <value>The [Business Identifier Code](https://en.wikipedia.org/wiki/ISO_9362) (BIC) is the SWIFT address assigned to a bank. The field value is &#x60;nil&#x60; in most cases.</value>
        [DataMember(Name = "bic", EmitDefaultValue = false)]
        public string Bic { get; set; }

        /// <summary>
        /// Country code where the bank is located.  A valid value is an ISO two-character country code (e.g. &#x27;NL&#x27;).
        /// </summary>
        /// <value>Country code where the bank is located.  A valid value is an ISO two-character country code (e.g. &#x27;NL&#x27;).</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The [International Bank Account Number](https://en.wikipedia.org/wiki/International_Bank_Account_Number) (IBAN).
        /// </summary>
        /// <value>The [International Bank Account Number](https://en.wikipedia.org/wiki/International_Bank_Account_Number) (IBAN).</value>
        [DataMember(Name = "iban", EmitDefaultValue = false)]
        public string Iban { get; set; }

        /// <summary>
        /// The name of the bank account holder. If you submit a name with non-Latin characters, we automatically replace some of them with corresponding Latin characters to meet the FATF recommendations. For example: * χ12 is converted to ch12. * üA is converted to euA. * Peter Møller is converted to Peter Mller, because banks don&#x27;t accept &#x27;ø&#x27;. After replacement, the ownerName must have at least three alphanumeric characters (A-Z, a-z, 0-9), and at least one of them must be a valid Latin character (A-Z, a-z). For example: * John17 - allowed. * J17 - allowed. * 171 - not allowed. * John-7 - allowed. &gt; If provided details don&#x27;t match the required format, the response returns the error message: 203 &#x27;Invalid bank account holder name&#x27;.
        /// </summary>
        /// <value>The name of the bank account holder. If you submit a name with non-Latin characters, we automatically replace some of them with corresponding Latin characters to meet the FATF recommendations. For example: * χ12 is converted to ch12. * üA is converted to euA. * Peter Møller is converted to Peter Mller, because banks don&#x27;t accept &#x27;ø&#x27;. After replacement, the ownerName must have at least three alphanumeric characters (A-Z, a-z, 0-9), and at least one of them must be a valid Latin character (A-Z, a-z). For example: * John17 - allowed. * J17 - allowed. * 171 - not allowed. * John-7 - allowed. &gt; If provided details don&#x27;t match the required format, the response returns the error message: 203 &#x27;Invalid bank account holder name&#x27;.</value>
        [DataMember(Name = "ownerName", EmitDefaultValue = false)]
        public string OwnerName { get; set; }

        /// <summary>
        /// The bank account holder&#x27;s tax ID.
        /// </summary>
        /// <value>The bank account holder&#x27;s tax ID.</value>
        [DataMember(Name = "taxId", EmitDefaultValue = false)]
        public string TaxId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankAccount {\n");
            sb.Append("  BankAccountNumber: ").Append(BankAccountNumber).Append("\n");
            sb.Append("  BankCity: ").Append(BankCity).Append("\n");
            sb.Append("  BankLocationId: ").Append(BankLocationId).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  Bic: ").Append(Bic).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  TaxId: ").Append(TaxId).Append("\n");
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
            return this.Equals(input as BankAccount);
        }

        /// <summary>
        /// Returns true if BankAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of BankAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankAccount input)
        {
            if (input == null)
                return false;

            return
                (
                    this.BankAccountNumber == input.BankAccountNumber ||
                    this.BankAccountNumber != null &&
                    this.BankAccountNumber.Equals(input.BankAccountNumber)
                ) &&
                (
                    this.BankCity == input.BankCity ||
                    this.BankCity != null &&
                    this.BankCity.Equals(input.BankCity)
                ) &&
                (
                    this.BankLocationId == input.BankLocationId ||
                    this.BankLocationId != null &&
                    this.BankLocationId.Equals(input.BankLocationId)
                ) &&
                (
                    this.BankName == input.BankName ||
                    this.BankName != null &&
                    this.BankName.Equals(input.BankName)
                ) &&
                (
                    this.Bic == input.Bic ||
                    this.Bic != null &&
                    this.Bic.Equals(input.Bic)
                ) &&
                (
                    this.CountryCode == input.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode)
                ) &&
                (
                    this.Iban == input.Iban ||
                    this.Iban != null &&
                    this.Iban.Equals(input.Iban)
                ) &&
                (
                    this.OwnerName == input.OwnerName ||
                    this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName)
                ) &&
                (
                    this.TaxId == input.TaxId ||
                    this.TaxId != null &&
                    this.TaxId.Equals(input.TaxId)
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
                if (this.BankAccountNumber != null)
                    hashCode = hashCode * 59 + this.BankAccountNumber.GetHashCode();
                if (this.BankCity != null)
                    hashCode = hashCode * 59 + this.BankCity.GetHashCode();
                if (this.BankLocationId != null)
                    hashCode = hashCode * 59 + this.BankLocationId.GetHashCode();
                if (this.BankName != null)
                    hashCode = hashCode * 59 + this.BankName.GetHashCode();
                if (this.Bic != null)
                    hashCode = hashCode * 59 + this.Bic.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.Iban != null)
                    hashCode = hashCode * 59 + this.Iban.GetHashCode();
                if (this.OwnerName != null)
                    hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
                if (this.TaxId != null)
                    hashCode = hashCode * 59 + this.TaxId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}