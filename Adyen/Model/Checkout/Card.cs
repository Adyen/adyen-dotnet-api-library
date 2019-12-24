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
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
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
        [JsonConstructor]
        public Card() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Card" /> class.
        /// </summary>
        /// <param name="Cvc">The [card verification code](https://docs.adyen.com/developers/payment-glossary#cardsecuritycodecvccvvcid) (1-20 characters). Depending on the card brand, it is known also as: * CVV2/CVC2 – length: 3 digits * CID – length: 4 digits &gt; If you are using [Client-Side Encryption](https://docs.adyen.com/developers/features/client-side-encryption), the CVC code is present in the encrypted data. You must never post the card details to the server. &gt; This field must be always present in a [one-click payment request](https://docs.adyen.com/developers/classic-integration/recurring-payments). &gt; When this value is returned in a response, it is always empty because it is not stored..</param>
        /// <param name="ExpiryMonth">The card expiry month. Format: 2 digits, zero-padded for single digits. For example: * 03 &#x3D; March * 11 &#x3D; November (required).</param>
        /// <param name="ExpiryYear">The card expiry year. Format: 4 digits. For example: 2018 (required).</param>
        /// <param name="HolderName">The name of the cardholder, as printed on the card. (required).</param>
        /// <param name="IssueNumber">The issue number of the card (for some UK debit cards only)..</param>
        /// <param name="Number">The card number (4-19 characters). Do not use any separators. When this value is returned in a response, only the last 4 digits of the card number are returned. (required).</param>
        /// <param name="StartMonth">The month component of the start date (for some UK debit cards only)..</param>
        /// <param name="StartYear">The year component of the start date (for some UK debit cards only)..</param>
        public Card(string Cvc = default(string), string ExpiryMonth = default(string), string ExpiryYear = default(string), string HolderName = default(string), string IssueNumber = default(string), string Number = default(string), string StartMonth = default(string), string StartYear = default(string))
        {
            // to ensure "ExpiryMonth" is required (not null)
            if (ExpiryMonth == null)
            {
                throw new InvalidDataException("ExpiryMonth is a required property for Card and cannot be null");
            }
            else
            {
                this.ExpiryMonth = ExpiryMonth;
            }
            // to ensure "ExpiryYear" is required (not null)
            if (ExpiryYear == null)
            {
                throw new InvalidDataException("ExpiryYear is a required property for Card and cannot be null");
            }
            else
            {
                this.ExpiryYear = ExpiryYear;
            }
            // to ensure "HolderName" is required (not null)
            if (HolderName == null)
            {
                throw new InvalidDataException("HolderName is a required property for Card and cannot be null");
            }
            else
            {
                this.HolderName = HolderName;
            }
            // to ensure "Number" is required (not null)
            if (Number == null)
            {
                throw new InvalidDataException("Number is a required property for Card and cannot be null");
            }
            else
            {
                this.Number = Number;
            }
            this.Cvc = Cvc;
            this.IssueNumber = IssueNumber;
            this.StartMonth = StartMonth;
            this.StartYear = StartYear;
        }
        
        /// <summary>
        /// The [card verification code](https://docs.adyen.com/developers/payment-glossary#cardsecuritycodecvccvvcid) (1-20 characters). Depending on the card brand, it is known also as: * CVV2/CVC2 – length: 3 digits * CID – length: 4 digits &gt; If you are using [Client-Side Encryption](https://docs.adyen.com/developers/features/client-side-encryption), the CVC code is present in the encrypted data. You must never post the card details to the server. &gt; This field must be always present in a [one-click payment request](https://docs.adyen.com/developers/classic-integration/recurring-payments). &gt; When this value is returned in a response, it is always empty because it is not stored.
        /// </summary>
        /// <value>The [card verification code](https://docs.adyen.com/developers/payment-glossary#cardsecuritycodecvccvvcid) (1-20 characters). Depending on the card brand, it is known also as: * CVV2/CVC2 – length: 3 digits * CID – length: 4 digits &gt; If you are using [Client-Side Encryption](https://docs.adyen.com/developers/features/client-side-encryption), the CVC code is present in the encrypted data. You must never post the card details to the server. &gt; This field must be always present in a [one-click payment request](https://docs.adyen.com/developers/classic-integration/recurring-payments). &gt; When this value is returned in a response, it is always empty because it is not stored.</value>
        [DataMember(Name="cvc", EmitDefaultValue=false)]
        public string Cvc { get; set; }

        /// <summary>
        /// The card expiry month. Format: 2 digits, zero-padded for single digits. For example: * 03 &#x3D; March * 11 &#x3D; November
        /// </summary>
        /// <value>The card expiry month. Format: 2 digits, zero-padded for single digits. For example: * 03 &#x3D; March * 11 &#x3D; November</value>
        [DataMember(Name="expiryMonth", EmitDefaultValue=false)]
        public string ExpiryMonth { get; set; }

        /// <summary>
        /// The card expiry year. Format: 4 digits. For example: 2018
        /// </summary>
        /// <value>The card expiry year. Format: 4 digits. For example: 2018</value>
        [DataMember(Name="expiryYear", EmitDefaultValue=false)]
        public string ExpiryYear { get; set; }

        /// <summary>
        /// The name of the cardholder, as printed on the card.
        /// </summary>
        /// <value>The name of the cardholder, as printed on the card.</value>
        [DataMember(Name="holderName", EmitDefaultValue=false)]
        public string HolderName { get; set; }

        /// <summary>
        /// The issue number of the card (for some UK debit cards only).
        /// </summary>
        /// <value>The issue number of the card (for some UK debit cards only).</value>
        [DataMember(Name="issueNumber", EmitDefaultValue=false)]
        public string IssueNumber { get; set; }

        /// <summary>
        /// The card number (4-19 characters). Do not use any separators. When this value is returned in a response, only the last 4 digits of the card number are returned.
        /// </summary>
        /// <value>The card number (4-19 characters). Do not use any separators. When this value is returned in a response, only the last 4 digits of the card number are returned.</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// The month component of the start date (for some UK debit cards only).
        /// </summary>
        /// <value>The month component of the start date (for some UK debit cards only).</value>
        [DataMember(Name="startMonth", EmitDefaultValue=false)]
        public string StartMonth { get; set; }

        /// <summary>
        /// The year component of the start date (for some UK debit cards only).
        /// </summary>
        /// <value>The year component of the start date (for some UK debit cards only).</value>
        [DataMember(Name="startYear", EmitDefaultValue=false)]
        public string StartYear { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Card {\n");
            sb.Append("  Cvc: ").Append(Cvc).Append("\n");
            sb.Append("  ExpiryMonth: ").Append(ExpiryMonth).Append("\n");
            sb.Append("  ExpiryYear: ").Append(ExpiryYear).Append("\n");
            sb.Append("  HolderName: ").Append(HolderName).Append("\n");
            sb.Append("  IssueNumber: ").Append(IssueNumber).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  StartMonth: ").Append(StartMonth).Append("\n");
            sb.Append("  StartYear: ").Append(StartYear).Append("\n");
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
            return this.Equals(input as Card);
        }

        /// <summary>
        /// Returns true if Card instances are equal
        /// </summary>
        /// <param name="input">Instance of Card to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Card input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cvc == input.Cvc ||
                    (this.Cvc != null &&
                    this.Cvc.Equals(input.Cvc))
                ) && 
                (
                    this.ExpiryMonth == input.ExpiryMonth ||
                    (this.ExpiryMonth != null &&
                    this.ExpiryMonth.Equals(input.ExpiryMonth))
                ) && 
                (
                    this.ExpiryYear == input.ExpiryYear ||
                    (this.ExpiryYear != null &&
                    this.ExpiryYear.Equals(input.ExpiryYear))
                ) && 
                (
                    this.HolderName == input.HolderName ||
                    (this.HolderName != null &&
                    this.HolderName.Equals(input.HolderName))
                ) && 
                (
                    this.IssueNumber == input.IssueNumber ||
                    (this.IssueNumber != null &&
                    this.IssueNumber.Equals(input.IssueNumber))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.StartMonth == input.StartMonth ||
                    (this.StartMonth != null &&
                    this.StartMonth.Equals(input.StartMonth))
                ) && 
                (
                    this.StartYear == input.StartYear ||
                    (this.StartYear != null &&
                    this.StartYear.Equals(input.StartYear))
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
                if (this.Cvc != null)
                    hashCode = hashCode * 59 + this.Cvc.GetHashCode();
                if (this.ExpiryMonth != null)
                    hashCode = hashCode * 59 + this.ExpiryMonth.GetHashCode();
                if (this.ExpiryYear != null)
                    hashCode = hashCode * 59 + this.ExpiryYear.GetHashCode();
                if (this.HolderName != null)
                    hashCode = hashCode * 59 + this.HolderName.GetHashCode();
                if (this.IssueNumber != null)
                    hashCode = hashCode * 59 + this.IssueNumber.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.StartMonth != null)
                    hashCode = hashCode * 59 + this.StartMonth.GetHashCode();
                if (this.StartYear != null)
                    hashCode = hashCode * 59 + this.StartYear.GetHashCode();
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

            yield break;
        }
    }

}
