using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Adyen.EcommLibrary.Model
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
        /// <param name="OwnerName">The name of the bank account holder..</param>
        /// <param name="CountryCode">Country code where the bank is located.  A valid value is an ISO two-character country code (e.g. &#39;NL&#39;)..</param>
        /// <param name="TaxId">The bank account holder&#39;s tax ID..</param>
        /// <param name="Iban">The [International Bank Account Number](https://en.wikipedia.org/wiki/International_Bank_Account_Number) (IBAN)..</param>
        /// <param name="BankAccountNumber">The bank account number (without separators)..</param>
        /// <param name="BankName">The name of the bank..</param>
        /// <param name="BankLocationId">The location id of the bank. The field value is &#x60;nil&#x60; in most cases..</param>
        /// <param name="Bic">The [Business Identifier Code](https://en.wikipedia.org/wiki/ISO_9362) (BIC) is the SWIFT address assigned to a bank. The field value is &#x60;nil&#x60; in most cases..</param>
        /// <param name="BankCity">The bank city..</param>
        public BankAccount(string OwnerName = default(string), string CountryCode = default(string),
            string TaxId = default(string), string Iban = default(string), string BankAccountNumber = default(string),
            string BankName = default(string), string BankLocationId = default(string), string Bic = default(string),
            string BankCity = default(string))
        {
            this.OwnerName = OwnerName;
            this.CountryCode = CountryCode;
            this.TaxId = TaxId;
            this.Iban = Iban;
            this.BankAccountNumber = BankAccountNumber;
            this.BankName = BankName;
            this.BankLocationId = BankLocationId;
            this.Bic = Bic;
            this.BankCity = BankCity;
        }

        /// <summary>
        /// The name of the bank account holder.
        /// </summary>
        /// <value>The name of the bank account holder.</value>
        [DataMember(Name = "ownerName", EmitDefaultValue = false)]
        public string OwnerName { get; set; }

        /// <summary>
        /// Country code where the bank is located.  A valid value is an ISO two-character country code (e.g. &#39;NL&#39;).
        /// </summary>
        /// <value>Country code where the bank is located.  A valid value is an ISO two-character country code (e.g. &#39;NL&#39;).</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The bank account holder&#39;s tax ID.
        /// </summary>
        /// <value>The bank account holder&#39;s tax ID.</value>
        [DataMember(Name = "taxId", EmitDefaultValue = false)]
        public string TaxId { get; set; }

        /// <summary>
        /// The [International Bank Account Number](https://en.wikipedia.org/wiki/International_Bank_Account_Number) (IBAN).
        /// </summary>
        /// <value>The [International Bank Account Number](https://en.wikipedia.org/wiki/International_Bank_Account_Number) (IBAN).</value>
        [DataMember(Name = "iban", EmitDefaultValue = false)]
        public string Iban { get; set; }

        /// <summary>
        /// The bank account number (without separators).
        /// </summary>
        /// <value>The bank account number (without separators).</value>
        [DataMember(Name = "bankAccountNumber", EmitDefaultValue = false)]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// The name of the bank.
        /// </summary>
        /// <value>The name of the bank.</value>
        [DataMember(Name = "bankName", EmitDefaultValue = false)]
        public string BankName { get; set; }

        /// <summary>
        /// The location id of the bank. The field value is &#x60;nil&#x60; in most cases.
        /// </summary>
        /// <value>The location id of the bank. The field value is &#x60;nil&#x60; in most cases.</value>
        [DataMember(Name = "bankLocationId", EmitDefaultValue = false)]
        public string BankLocationId { get; set; }

        /// <summary>
        /// The [Business Identifier Code](https://en.wikipedia.org/wiki/ISO_9362) (BIC) is the SWIFT address assigned to a bank. The field value is &#x60;nil&#x60; in most cases.
        /// </summary>
        /// <value>The [Business Identifier Code](https://en.wikipedia.org/wiki/ISO_9362) (BIC) is the SWIFT address assigned to a bank. The field value is &#x60;nil&#x60; in most cases.</value>
        [DataMember(Name = "bic", EmitDefaultValue = false)]
        public string Bic { get; set; }

        /// <summary>
        /// The bank city.
        /// </summary>
        /// <value>The bank city.</value>
        [DataMember(Name = "bankCity", EmitDefaultValue = false)]
        public string BankCity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankAccount {\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  TaxId: ").Append(TaxId).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  BankAccountNumber: ").Append(BankAccountNumber).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  BankLocationId: ").Append(BankLocationId).Append("\n");
            sb.Append("  Bic: ").Append(Bic).Append("\n");
            sb.Append("  BankCity: ").Append(BankCity).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return Equals(obj as BankAccount);
        }

        /// <summary>
        /// Returns true if BankAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of BankAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankAccount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    OwnerName == other.OwnerName ||
                    OwnerName != null &&
                    OwnerName.Equals(other.OwnerName)
                ) &&
                (
                    CountryCode == other.CountryCode ||
                    CountryCode != null &&
                    CountryCode.Equals(other.CountryCode)
                ) &&
                (
                    TaxId == other.TaxId ||
                    TaxId != null &&
                    TaxId.Equals(other.TaxId)
                ) &&
                (
                    Iban == other.Iban ||
                    Iban != null &&
                    Iban.Equals(other.Iban)
                ) &&
                (
                    BankAccountNumber == other.BankAccountNumber ||
                    BankAccountNumber != null &&
                    BankAccountNumber.Equals(other.BankAccountNumber)
                ) &&
                (
                    BankName == other.BankName ||
                    BankName != null &&
                    BankName.Equals(other.BankName)
                ) &&
                (
                    BankLocationId == other.BankLocationId ||
                    BankLocationId != null &&
                    BankLocationId.Equals(other.BankLocationId)
                ) &&
                (
                    Bic == other.Bic ||
                    Bic != null &&
                    Bic.Equals(other.Bic)
                ) &&
                (
                    BankCity == other.BankCity ||
                    BankCity != null &&
                    BankCity.Equals(other.BankCity)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                var hash = 41;
                // Suitable nullity checks etc, of course :)
                if (OwnerName != null)
                    hash = hash * 59 + OwnerName.GetHashCode();
                if (CountryCode != null)
                    hash = hash * 59 + CountryCode.GetHashCode();
                if (TaxId != null)
                    hash = hash * 59 + TaxId.GetHashCode();
                if (Iban != null)
                    hash = hash * 59 + Iban.GetHashCode();
                if (BankAccountNumber != null)
                    hash = hash * 59 + BankAccountNumber.GetHashCode();
                if (BankName != null)
                    hash = hash * 59 + BankName.GetHashCode();
                if (BankLocationId != null)
                    hash = hash * 59 + BankLocationId.GetHashCode();
                if (Bic != null)
                    hash = hash * 59 + Bic.GetHashCode();
                if (BankCity != null)
                    hash = hash * 59 + BankCity.GetHashCode();
                return hash;
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