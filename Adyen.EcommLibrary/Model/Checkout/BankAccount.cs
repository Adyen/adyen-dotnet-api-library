using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.EcommLibrary.Model.Checkout
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
        /// <param name="BankAccountNumber">The bank account number (without separators)..</param>
        /// <param name="BankCity">The bank city..</param>
        /// <param name="BankLocationId">The location id of the bank. The field value is &#x60;nil&#x60; in most cases..</param>
        /// <param name="BankName">The name of the bank..</param>
        /// <param name="Bic">The [Business Identifier Code](https://en.wikipedia.org/wiki/ISO_9362) (BIC) is the SWIFT address assigned to a bank. The field value is &#x60;nil&#x60; in most cases..</param>
        /// <param name="CountryCode">Country code where the bank is located.  A valid value is an ISO two-character country code (e.g. &#39;NL&#39;)..</param>
        /// <param name="Iban">The [International Bank Account Number](https://en.wikipedia.org/wiki/International_Bank_Account_Number) (IBAN)..</param>
        /// <param name="OwnerName">The name of the bank account holder. If you submit a name with non-Latin characters, we automatically replace some of them with corresponding Latin characters to meet the FATF recommendations. For example: * χ12 is converted to ch12. * üA is converted to euA. * Peter Møller is converted to Peter Mller, because banks don&#39;t accept &#39;ø&#39;. After replacement, the ownerName must have at least three alphanumeric characters (A-Z, a-z, 0-9), and at least one of them must be a valid Latin character (A-Z, a-z). For example: * John17 - allowed. * J17 - allowed. * 171 - not allowed. * John-7 - allowed. &gt; If provided details don&#39;t match the required format, the response returns the error message: 203 &#39;Invalid bank account holder name&#39;..</param>
        /// <param name="TaxId">The bank account holder&#39;s tax ID..</param>
        public BankAccount(string BankAccountNumber = default(string), string BankCity = default(string),
            string BankLocationId = default(string), string BankName = default(string), string Bic = default(string),
            string CountryCode = default(string), string Iban = default(string), string OwnerName = default(string),
            string TaxId = default(string))
        {
            this.BankAccountNumber = BankAccountNumber;
            this.BankCity = BankCity;
            this.BankLocationId = BankLocationId;
            this.BankName = BankName;
            this.Bic = Bic;
            this.CountryCode = CountryCode;
            this.Iban = Iban;
            this.OwnerName = OwnerName;
            this.TaxId = TaxId;
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
        /// Country code where the bank is located.  A valid value is an ISO two-character country code (e.g. &#39;NL&#39;).
        /// </summary>
        /// <value>Country code where the bank is located.  A valid value is an ISO two-character country code (e.g. &#39;NL&#39;).</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The [International Bank Account Number](https://en.wikipedia.org/wiki/International_Bank_Account_Number) (IBAN).
        /// </summary>
        /// <value>The [International Bank Account Number](https://en.wikipedia.org/wiki/International_Bank_Account_Number) (IBAN).</value>
        [DataMember(Name = "iban", EmitDefaultValue = false)]
        public string Iban { get; set; }

        /// <summary>
        /// The name of the bank account holder. If you submit a name with non-Latin characters, we automatically replace some of them with corresponding Latin characters to meet the FATF recommendations. For example: * χ12 is converted to ch12. * üA is converted to euA. * Peter Møller is converted to Peter Mller, because banks don&#39;t accept &#39;ø&#39;. After replacement, the ownerName must have at least three alphanumeric characters (A-Z, a-z, 0-9), and at least one of them must be a valid Latin character (A-Z, a-z). For example: * John17 - allowed. * J17 - allowed. * 171 - not allowed. * John-7 - allowed. &gt; If provided details don&#39;t match the required format, the response returns the error message: 203 &#39;Invalid bank account holder name&#39;.
        /// </summary>
        /// <value>The name of the bank account holder. If you submit a name with non-Latin characters, we automatically replace some of them with corresponding Latin characters to meet the FATF recommendations. For example: * χ12 is converted to ch12. * üA is converted to euA. * Peter Møller is converted to Peter Mller, because banks don&#39;t accept &#39;ø&#39;. After replacement, the ownerName must have at least three alphanumeric characters (A-Z, a-z, 0-9), and at least one of them must be a valid Latin character (A-Z, a-z). For example: * John17 - allowed. * J17 - allowed. * 171 - not allowed. * John-7 - allowed. &gt; If provided details don&#39;t match the required format, the response returns the error message: 203 &#39;Invalid bank account holder name&#39;.</value>
        [DataMember(Name = "ownerName", EmitDefaultValue = false)]
        public string OwnerName { get; set; }

        /// <summary>
        /// The bank account holder&#39;s tax ID.
        /// </summary>
        /// <value>The bank account holder&#39;s tax ID.</value>
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
        public string ToJson()
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
            return Equals(input as BankAccount);
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
                    BankAccountNumber == input.BankAccountNumber ||
                    BankAccountNumber != null &&
                    BankAccountNumber.Equals(input.BankAccountNumber)
                ) &&
                (
                    BankCity == input.BankCity ||
                    BankCity != null &&
                    BankCity.Equals(input.BankCity)
                ) &&
                (
                    BankLocationId == input.BankLocationId ||
                    BankLocationId != null &&
                    BankLocationId.Equals(input.BankLocationId)
                ) &&
                (
                    BankName == input.BankName ||
                    BankName != null &&
                    BankName.Equals(input.BankName)
                ) &&
                (
                    Bic == input.Bic ||
                    Bic != null &&
                    Bic.Equals(input.Bic)
                ) &&
                (
                    CountryCode == input.CountryCode ||
                    CountryCode != null &&
                    CountryCode.Equals(input.CountryCode)
                ) &&
                (
                    Iban == input.Iban ||
                    Iban != null &&
                    Iban.Equals(input.Iban)
                ) &&
                (
                    OwnerName == input.OwnerName ||
                    OwnerName != null &&
                    OwnerName.Equals(input.OwnerName)
                ) &&
                (
                    TaxId == input.TaxId ||
                    TaxId != null &&
                    TaxId.Equals(input.TaxId)
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
                var hashCode = 41;
                if (BankAccountNumber != null)
                    hashCode = hashCode * 59 + BankAccountNumber.GetHashCode();
                if (BankCity != null)
                    hashCode = hashCode * 59 + BankCity.GetHashCode();
                if (BankLocationId != null)
                    hashCode = hashCode * 59 + BankLocationId.GetHashCode();
                if (BankName != null)
                    hashCode = hashCode * 59 + BankName.GetHashCode();
                if (Bic != null)
                    hashCode = hashCode * 59 + Bic.GetHashCode();
                if (CountryCode != null)
                    hashCode = hashCode * 59 + CountryCode.GetHashCode();
                if (Iban != null)
                    hashCode = hashCode * 59 + Iban.GetHashCode();
                if (OwnerName != null)
                    hashCode = hashCode * 59 + OwnerName.GetHashCode();
                if (TaxId != null)
                    hashCode = hashCode * 59 + TaxId.GetHashCode();
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