using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Adyen.EcommLibrary.Model
{
    /// <summary>
    /// Card
    /// </summary>
    [DataContract]
    public partial class Card : IEquatable<Card>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Card" /> class.
        /// </summary>
        /// <param name="Number">The card number (4-19 characters). Do not use any separators. When this value is returned in a response, only the last 4 digits of the card number are returned..</param>
        /// <param name="Cvc">The [card verification code](https://docs.adyen.com/support/payments-101/payment-glossary#cardsecuritycodecvccvvcid) (1-20 characters). Depending on the card brand, it is known also as: * CVV2/CVC2 – length: 3 digits * CID – length: 4 digits &gt; If you are using [Client-Side Encryption](https://docs.adyen.com/developers/ecommerce-integration), the CVC code is present in the encrypted data. You must never post the card details to the server. &gt; This field must be always present in a [one-click payment request](https://docs.adyen.com/developers/products-and-subscriptions/recurring-payments). &gt; When this value is returned in a response, it is always empty because it is not stored..</param>
        /// <param name="HolderName">The name of the cardholder, as printed on the card..</param>
        /// <param name="StartMonth">The month component of the start date (for some UK debit cards only)..</param>
        /// <param name="IssueNumber">The issue number of the card (for some UK debit cards only)..</param>
        /// <param name="ExpiryMonth">The card expiry month. Format: 2 digits, zero-padded for single digits. For example: * 03 &#x3D; March * 11 &#x3D; November.</param>
        /// <param name="StartYear">The year component of the start date (for some UK debit cards only)..</param>
        /// <param name="ExpiryYear">The card expiry year. Format: 4 digits. For example: 2018.</param>
        /// <param name="BillingAddress">BillingAddress.</param>
        /// <param name="Brand">Brand.</param>
        public Card(string Number = default(string), string Cvc = default(string), string HolderName = default(string),
            string StartMonth = default(string), string IssueNumber = default(string),
            string ExpiryMonth = default(string), string StartYear = default(string),
            string ExpiryYear = default(string), Address BillingAddress = default(Address),
            string Brand = default(string))
        {
            this.Number = Number;
            this.Cvc = Cvc;
            this.HolderName = HolderName;
            this.StartMonth = StartMonth;
            this.IssueNumber = IssueNumber;
            this.ExpiryMonth = ExpiryMonth;
            this.StartYear = StartYear;
            this.ExpiryYear = ExpiryYear;
            this.BillingAddress = BillingAddress;
            this.Brand = Brand;
        }

        /// <summary>
        /// The card number (4-19 characters). Do not use any separators. When this value is returned in a response, only the last 4 digits of the card number are returned.
        /// </summary>
        /// <value>The card number (4-19 characters). Do not use any separators. When this value is returned in a response, only the last 4 digits of the card number are returned.</value>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// The [card verification code](https://docs.adyen.com/support/payments-101/payment-glossary#cardsecuritycodecvccvvcid) (1-20 characters). Depending on the card brand, it is known also as: * CVV2/CVC2 – length: 3 digits * CID – length: 4 digits &gt; If you are using [Client-Side Encryption](https://docs.adyen.com/developers/ecommerce-integration), the CVC code is present in the encrypted data. You must never post the card details to the server. &gt; This field must be always present in a [one-click payment request](https://docs.adyen.com/developers/products-and-subscriptions/recurring-payments). &gt; When this value is returned in a response, it is always empty because it is not stored.
        /// </summary>
        /// <value>The [card verification code](https://docs.adyen.com/support/payments-101/payment-glossary#cardsecuritycodecvccvvcid) (1-20 characters). Depending on the card brand, it is known also as: * CVV2/CVC2 – length: 3 digits * CID – length: 4 digits &gt; If you are using [Client-Side Encryption](https://docs.adyen.com/developers/ecommerce-integration), the CVC code is present in the encrypted data. You must never post the card details to the server. &gt; This field must be always present in a [one-click payment request](https://docs.adyen.com/developers/products-and-subscriptions/recurring-payments). &gt; When this value is returned in a response, it is always empty because it is not stored.</value>
        [DataMember(Name = "cvc", EmitDefaultValue = false)]
        public string Cvc { get; set; }

        /// <summary>
        /// The name of the cardholder, as printed on the card.
        /// </summary>
        /// <value>The name of the cardholder, as printed on the card.</value>
        [DataMember(Name = "holderName", EmitDefaultValue = false)]
        public string HolderName { get; set; }

        /// <summary>
        /// The month component of the start date (for some UK debit cards only).
        /// </summary>
        /// <value>The month component of the start date (for some UK debit cards only).</value>
        [DataMember(Name = "startMonth", EmitDefaultValue = false)]
        public string StartMonth { get; set; }

        /// <summary>
        /// The issue number of the card (for some UK debit cards only).
        /// </summary>
        /// <value>The issue number of the card (for some UK debit cards only).</value>
        [DataMember(Name = "issueNumber", EmitDefaultValue = false)]
        public string IssueNumber { get; set; }

        /// <summary>
        /// The card expiry month. Format: 2 digits, zero-padded for single digits. For example: * 03 &#x3D; March * 11 &#x3D; November
        /// </summary>
        /// <value>The card expiry month. Format: 2 digits, zero-padded for single digits. For example: * 03 &#x3D; March * 11 &#x3D; November</value>
        [DataMember(Name = "expiryMonth", EmitDefaultValue = false)]
        public string ExpiryMonth { get; set; }

        /// <summary>
        /// The year component of the start date (for some UK debit cards only).
        /// </summary>
        /// <value>The year component of the start date (for some UK debit cards only).</value>
        [DataMember(Name = "startYear", EmitDefaultValue = false)]
        public string StartYear { get; set; }

        /// <summary>
        /// The card expiry year. Format: 4 digits. For example: 2018
        /// </summary>
        /// <value>The card expiry year. Format: 4 digits. For example: 2018</value>
        [DataMember(Name = "expiryYear", EmitDefaultValue = false)]
        public string ExpiryYear { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Gets or Sets Brand
        /// </summary>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Card {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Cvc: ").Append(Cvc).Append("\n");
            sb.Append("  HolderName: ").Append(HolderName).Append("\n");
            sb.Append("  StartMonth: ").Append(StartMonth).Append("\n");
            sb.Append("  IssueNumber: ").Append(IssueNumber).Append("\n");
            sb.Append("  ExpiryMonth: ").Append(ExpiryMonth).Append("\n");
            sb.Append("  StartYear: ").Append(StartYear).Append("\n");
            sb.Append("  ExpiryYear: ").Append(ExpiryYear).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
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
            return Equals(obj as Card);
        }

        /// <summary>
        /// Returns true if Card instances are equal
        /// </summary>
        /// <param name="other">Instance of Card to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Card other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    Number == other.Number ||
                    Number != null &&
                    Number.Equals(other.Number)
                ) &&
                (
                    Cvc == other.Cvc ||
                    Cvc != null &&
                    Cvc.Equals(other.Cvc)
                ) &&
                (
                    HolderName == other.HolderName ||
                    HolderName != null &&
                    HolderName.Equals(other.HolderName)
                ) &&
                (
                    StartMonth == other.StartMonth ||
                    StartMonth != null &&
                    StartMonth.Equals(other.StartMonth)
                ) &&
                (
                    IssueNumber == other.IssueNumber ||
                    IssueNumber != null &&
                    IssueNumber.Equals(other.IssueNumber)
                ) &&
                (
                    ExpiryMonth == other.ExpiryMonth ||
                    ExpiryMonth != null &&
                    ExpiryMonth.Equals(other.ExpiryMonth)
                ) &&
                (
                    StartYear == other.StartYear ||
                    StartYear != null &&
                    StartYear.Equals(other.StartYear)
                ) &&
                (
                    ExpiryYear == other.ExpiryYear ||
                    ExpiryYear != null &&
                    ExpiryYear.Equals(other.ExpiryYear)
                ) &&
                (
                    BillingAddress == other.BillingAddress ||
                    BillingAddress != null &&
                    BillingAddress.Equals(other.BillingAddress)
                ) &&
                (
                    Brand == other.Brand ||
                    Brand != null &&
                    Brand.Equals(other.Brand)
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
                if (Number != null)
                    hash = hash * 59 + Number.GetHashCode();
                if (Cvc != null)
                    hash = hash * 59 + Cvc.GetHashCode();
                if (HolderName != null)
                    hash = hash * 59 + HolderName.GetHashCode();
                if (StartMonth != null)
                    hash = hash * 59 + StartMonth.GetHashCode();
                if (IssueNumber != null)
                    hash = hash * 59 + IssueNumber.GetHashCode();
                if (ExpiryMonth != null)
                    hash = hash * 59 + ExpiryMonth.GetHashCode();
                if (StartYear != null)
                    hash = hash * 59 + StartYear.GetHashCode();
                if (ExpiryYear != null)
                    hash = hash * 59 + ExpiryYear.GetHashCode();
                if (BillingAddress != null)
                    hash = hash * 59 + BillingAddress.GetHashCode();
                if (Brand != null)
                    hash = hash * 59 + Brand.GetHashCode();
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
            // Number (string) maxLength
            if (Number != null && Number.Length > 19)
                yield return new ValidationResult("Invalid value for Number, length must be less than 19.",
                    new[] {"Number"});

            // Number (string) minLength
            if (Number != null && Number.Length < 4)
                yield return new ValidationResult("Invalid value for Number, length must be greater than 4.",
                    new[] {"Number"});

            // Cvc (string) maxLength
            if (Cvc != null && Cvc.Length > 20)
                yield return new ValidationResult("Invalid value for Cvc, length must be less than 20.", new[] {"Cvc"});

            // Cvc (string) minLength
            if (Cvc != null && Cvc.Length < 1)
                yield return new ValidationResult("Invalid value for Cvc, length must be greater than 1.",
                    new[] {"Cvc"});

            // HolderName (string) maxLength
            if (HolderName != null && HolderName.Length > 50)
                yield return new ValidationResult("Invalid value for HolderName, length must be less than 50.",
                    new[] {"HolderName"});

            // HolderName (string) minLength
            if (HolderName != null && HolderName.Length < 1)
                yield return new ValidationResult("Invalid value for HolderName, length must be greater than 1.",
                    new[] {"HolderName"});

            // StartMonth (string) maxLength
            if (StartMonth != null && StartMonth.Length > 2)
                yield return new ValidationResult("Invalid value for StartMonth, length must be less than 2.",
                    new[] {"StartMonth"});

            // StartMonth (string) minLength
            if (StartMonth != null && StartMonth.Length < 1)
                yield return new ValidationResult("Invalid value for StartMonth, length must be greater than 1.",
                    new[] {"StartMonth"});

            // IssueNumber (string) maxLength
            if (IssueNumber != null && IssueNumber.Length > 2)
                yield return new ValidationResult("Invalid value for IssueNumber, length must be less than 2.",
                    new[] {"IssueNumber"});

            // IssueNumber (string) minLength
            if (IssueNumber != null && IssueNumber.Length < 1)
                yield return new ValidationResult("Invalid value for IssueNumber, length must be greater than 1.",
                    new[] {"IssueNumber"});

            // ExpiryMonth (string) maxLength
            if (ExpiryMonth != null && ExpiryMonth.Length > 2)
                yield return new ValidationResult("Invalid value for ExpiryMonth, length must be less than 2.",
                    new[] {"ExpiryMonth"});

            // ExpiryMonth (string) minLength
            if (ExpiryMonth != null && ExpiryMonth.Length < 1)
                yield return new ValidationResult("Invalid value for ExpiryMonth, length must be greater than 1.",
                    new[] {"ExpiryMonth"});

            // StartYear (string) maxLength
            if (StartYear != null && StartYear.Length > 4)
                yield return new ValidationResult("Invalid value for StartYear, length must be less than 4.",
                    new[] {"StartYear"});

            // StartYear (string) minLength
            if (StartYear != null && StartYear.Length < 4)
                yield return new ValidationResult("Invalid value for StartYear, length must be greater than 4.",
                    new[] {"StartYear"});

            // ExpiryYear (string) maxLength
            if (ExpiryYear != null && ExpiryYear.Length > 4)
                yield return new ValidationResult("Invalid value for ExpiryYear, length must be less than 4.",
                    new[] {"ExpiryYear"});

            // ExpiryYear (string) minLength
            if (ExpiryYear != null && ExpiryYear.Length < 4)
                yield return new ValidationResult("Invalid value for ExpiryYear, length must be greater than 4.",
                    new[] {"ExpiryYear"});

            yield break;
        }
    }
}