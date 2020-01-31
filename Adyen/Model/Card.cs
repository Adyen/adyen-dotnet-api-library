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
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Adyen.Model
{
    /// <summary>
    /// Card
    /// </summary>
    [DataContract]
    public partial class Card :  IEquatable<Card>, IValidatableObject
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
        public Card(string Number = default(string), string Cvc = default(string), string HolderName = default(string), string StartMonth = default(string), string IssueNumber = default(string), string ExpiryMonth = default(string), string StartYear = default(string), string ExpiryYear = default(string), Address BillingAddress = default(Address), string Brand = default(string))
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
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// The [card verification code](https://docs.adyen.com/support/payments-101/payment-glossary#cardsecuritycodecvccvvcid) (1-20 characters). Depending on the card brand, it is known also as: * CVV2/CVC2 – length: 3 digits * CID – length: 4 digits &gt; If you are using [Client-Side Encryption](https://docs.adyen.com/developers/ecommerce-integration), the CVC code is present in the encrypted data. You must never post the card details to the server. &gt; This field must be always present in a [one-click payment request](https://docs.adyen.com/developers/products-and-subscriptions/recurring-payments). &gt; When this value is returned in a response, it is always empty because it is not stored.
        /// </summary>
        /// <value>The [card verification code](https://docs.adyen.com/support/payments-101/payment-glossary#cardsecuritycodecvccvvcid) (1-20 characters). Depending on the card brand, it is known also as: * CVV2/CVC2 – length: 3 digits * CID – length: 4 digits &gt; If you are using [Client-Side Encryption](https://docs.adyen.com/developers/ecommerce-integration), the CVC code is present in the encrypted data. You must never post the card details to the server. &gt; This field must be always present in a [one-click payment request](https://docs.adyen.com/developers/products-and-subscriptions/recurring-payments). &gt; When this value is returned in a response, it is always empty because it is not stored.</value>
        [DataMember(Name="cvc", EmitDefaultValue=false)]
        public string Cvc { get; set; }

        /// <summary>
        /// The name of the cardholder, as printed on the card.
        /// </summary>
        /// <value>The name of the cardholder, as printed on the card.</value>
        [DataMember(Name="holderName", EmitDefaultValue=false)]
        public string HolderName { get; set; }

        /// <summary>
        /// The month component of the start date (for some UK debit cards only).
        /// </summary>
        /// <value>The month component of the start date (for some UK debit cards only).</value>
        [DataMember(Name="startMonth", EmitDefaultValue=false)]
        public string StartMonth { get; set; }

        /// <summary>
        /// The issue number of the card (for some UK debit cards only).
        /// </summary>
        /// <value>The issue number of the card (for some UK debit cards only).</value>
        [DataMember(Name="issueNumber", EmitDefaultValue=false)]
        public string IssueNumber { get; set; }

        /// <summary>
        /// The card expiry month. Format: 2 digits, zero-padded for single digits. For example: * 03 &#x3D; March * 11 &#x3D; November
        /// </summary>
        /// <value>The card expiry month. Format: 2 digits, zero-padded for single digits. For example: * 03 &#x3D; March * 11 &#x3D; November</value>
        [DataMember(Name="expiryMonth", EmitDefaultValue=false)]
        public string ExpiryMonth { get; set; }

        /// <summary>
        /// The year component of the start date (for some UK debit cards only).
        /// </summary>
        /// <value>The year component of the start date (for some UK debit cards only).</value>
        [DataMember(Name="startYear", EmitDefaultValue=false)]
        public string StartYear { get; set; }

        /// <summary>
        /// The card expiry year. Format: 4 digits. For example: 2018
        /// </summary>
        /// <value>The card expiry year. Format: 4 digits. For example: 2018</value>
        [DataMember(Name="expiryYear", EmitDefaultValue=false)]
        public string ExpiryYear { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Gets or Sets Brand
        /// </summary>
        [DataMember(Name="brand", EmitDefaultValue=false)]
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
            return this.Equals(obj as Card);
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
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this.Cvc == other.Cvc ||
                    this.Cvc != null &&
                    this.Cvc.Equals(other.Cvc)
                ) && 
                (
                    this.HolderName == other.HolderName ||
                    this.HolderName != null &&
                    this.HolderName.Equals(other.HolderName)
                ) && 
                (
                    this.StartMonth == other.StartMonth ||
                    this.StartMonth != null &&
                    this.StartMonth.Equals(other.StartMonth)
                ) && 
                (
                    this.IssueNumber == other.IssueNumber ||
                    this.IssueNumber != null &&
                    this.IssueNumber.Equals(other.IssueNumber)
                ) && 
                (
                    this.ExpiryMonth == other.ExpiryMonth ||
                    this.ExpiryMonth != null &&
                    this.ExpiryMonth.Equals(other.ExpiryMonth)
                ) && 
                (
                    this.StartYear == other.StartYear ||
                    this.StartYear != null &&
                    this.StartYear.Equals(other.StartYear)
                ) && 
                (
                    this.ExpiryYear == other.ExpiryYear ||
                    this.ExpiryYear != null &&
                    this.ExpiryYear.Equals(other.ExpiryYear)
                ) && 
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
                ) && 
                (
                    this.Brand == other.Brand ||
                    this.Brand != null &&
                    this.Brand.Equals(other.Brand)
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
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                if (this.Cvc != null)
                    hash = hash * 59 + this.Cvc.GetHashCode();
                if (this.HolderName != null)
                    hash = hash * 59 + this.HolderName.GetHashCode();
                if (this.StartMonth != null)
                    hash = hash * 59 + this.StartMonth.GetHashCode();
                if (this.IssueNumber != null)
                    hash = hash * 59 + this.IssueNumber.GetHashCode();
                if (this.ExpiryMonth != null)
                    hash = hash * 59 + this.ExpiryMonth.GetHashCode();
                if (this.StartYear != null)
                    hash = hash * 59 + this.StartYear.GetHashCode();
                if (this.ExpiryYear != null)
                    hash = hash * 59 + this.ExpiryYear.GetHashCode();
                if (this.BillingAddress != null)
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                if (this.Brand != null)
                    hash = hash * 59 + this.Brand.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Number (string) maxLength
            if(this.Number != null && this.Number.Length > 19)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Number, length must be less than 19.", new [] { "Number" });
            }

            // Number (string) minLength
            if(this.Number != null && this.Number.Length < 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Number, length must be greater than 4.", new [] { "Number" });
            }

            // Cvc (string) maxLength
            if(this.Cvc != null && this.Cvc.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cvc, length must be less than 20.", new [] { "Cvc" });
            }

            // Cvc (string) minLength
            if(this.Cvc != null && this.Cvc.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cvc, length must be greater than 1.", new [] { "Cvc" });
            }

            // HolderName (string) maxLength
            if(this.HolderName != null && this.HolderName.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HolderName, length must be less than 50.", new [] { "HolderName" });
            }

            // HolderName (string) minLength
            if(this.HolderName != null && this.HolderName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HolderName, length must be greater than 1.", new [] { "HolderName" });
            }

            // StartMonth (string) maxLength
            if(this.StartMonth != null && this.StartMonth.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StartMonth, length must be less than 2.", new [] { "StartMonth" });
            }

            // StartMonth (string) minLength
            if(this.StartMonth != null && this.StartMonth.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StartMonth, length must be greater than 1.", new [] { "StartMonth" });
            }

            // IssueNumber (string) maxLength
            if(this.IssueNumber != null && this.IssueNumber.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IssueNumber, length must be less than 2.", new [] { "IssueNumber" });
            }

            // IssueNumber (string) minLength
            if(this.IssueNumber != null && this.IssueNumber.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IssueNumber, length must be greater than 1.", new [] { "IssueNumber" });
            }

            // ExpiryMonth (string) maxLength
            if(this.ExpiryMonth != null && this.ExpiryMonth.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpiryMonth, length must be less than 2.", new [] { "ExpiryMonth" });
            }

            // ExpiryMonth (string) minLength
            if(this.ExpiryMonth != null && this.ExpiryMonth.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpiryMonth, length must be greater than 1.", new [] { "ExpiryMonth" });
            }

            // StartYear (string) maxLength
            if(this.StartYear != null && this.StartYear.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StartYear, length must be less than 4.", new [] { "StartYear" });
            }

            // StartYear (string) minLength
            if(this.StartYear != null && this.StartYear.Length < 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StartYear, length must be greater than 4.", new [] { "StartYear" });
            }

            // ExpiryYear (string) maxLength
            if(this.ExpiryYear != null && this.ExpiryYear.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpiryYear, length must be less than 4.", new [] { "ExpiryYear" });
            }

            // ExpiryYear (string) minLength
            if(this.ExpiryYear != null && this.ExpiryYear.Length < 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpiryYear, length must be greater than 4.", new [] { "ExpiryYear" });
            }

            yield break;
        }
    }

}
