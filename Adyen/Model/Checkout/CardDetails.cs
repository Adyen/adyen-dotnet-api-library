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
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// CardDetails
    /// </summary>
    [DataContract]
    public partial class CardDetails : IEquatable<CardDetails>, IValidatableObject
    {
        /// <summary>
        /// Defines FundingSource
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FundingSourceEnum
        {
            /// <summary>
            /// Enum Debit for value: debit
            /// </summary>
            [EnumMember(Value = "debit")] Debit = 1
        }

        /// <summary>
        /// Gets or Sets FundingSource
        /// </summary>
        [DataMember(Name = "fundingSource", EmitDefaultValue = false)]
        public FundingSourceEnum? FundingSource { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardDetails" /> class.
        /// </summary>
        /// <param name="brand">Brand of the card. For example: **plastix**, **hmclub**..</param>
        /// <param name="cupsecureplusSmscode">cupsecureplusSmscode.</param>
        /// <param name="cvc">cvc.</param>
        /// <param name="encryptedCardNumber">encryptedCardNumber (required).</param>
        /// <param name="encryptedExpiryMonth">encryptedExpiryMonth (required).</param>
        /// <param name="encryptedExpiryYear">encryptedExpiryYear (required).</param>
        /// <param name="expiryMonth">expiryMonth.</param>
        /// <param name="expiryYear">expiryYear.</param>
        /// <param name="fundingSource">fundingSource.</param>
        /// <param name="holderName">holderName.</param>
        /// <param name="number">number.</param>
        /// <param name="recurringDetailReference">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="storedPaymentMethodId">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="type">**scheme** (default to &quot;scheme&quot;).</param>
        public CardDetails(string brand = default(string), string cupsecureplusSmscode = default(string),
            string cvc = default(string), string encryptedCardNumber = default(string),
            string encryptedExpiryMonth = default(string), string encryptedExpiryYear = default(string),
            string expiryMonth = default(string), string expiryYear = default(string),
            FundingSourceEnum? fundingSource = default(FundingSourceEnum?), string holderName = default(string),
            string number = default(string), string recurringDetailReference = default(string),
            string storedPaymentMethodId = default(string), string type = "scheme")
        {
            // to ensure "encryptedCardNumber" is required (not null)
            if (encryptedCardNumber == null)
            {
                throw new InvalidDataException(
                    "encryptedCardNumber is a required property for CardDetails and cannot be null");
            }
            else
            {
                this.EncryptedCardNumber = encryptedCardNumber;
            }
            // to ensure "encryptedExpiryMonth" is required (not null)
            if (encryptedExpiryMonth == null)
            {
                throw new InvalidDataException(
                    "encryptedExpiryMonth is a required property for CardDetails and cannot be null");
            }
            else
            {
                this.EncryptedExpiryMonth = encryptedExpiryMonth;
            }
            // to ensure "encryptedExpiryYear" is required (not null)
            if (encryptedExpiryYear == null)
            {
                throw new InvalidDataException(
                    "encryptedExpiryYear is a required property for CardDetails and cannot be null");
            }
            else
            {
                this.EncryptedExpiryYear = encryptedExpiryYear;
            }
            this.Brand = brand;
            this.CupsecureplusSmscode = cupsecureplusSmscode;
            this.Cvc = cvc;
            this.ExpiryMonth = expiryMonth;
            this.ExpiryYear = expiryYear;
            this.FundingSource = fundingSource;
            this.HolderName = holderName;
            this.Number = number;
            this.RecurringDetailReference = recurringDetailReference;
            this.StoredPaymentMethodId = storedPaymentMethodId;
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "scheme";
            }
            else
            {
                this.Type = type;
            }
        }

        /// <summary>
        /// Brand of the card. For example: **plastix**, **hmclub**.
        /// </summary>
        /// <value>Brand of the card. For example: **plastix**, **hmclub**.</value>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// Gets or Sets CupsecureplusSmscode
        /// </summary>
        [DataMember(Name = "cupsecureplus.smscode", EmitDefaultValue = false)]
        public string CupsecureplusSmscode { get; set; }

        /// <summary>
        /// Gets or Sets Cvc
        /// </summary>
        [DataMember(Name = "cvc", EmitDefaultValue = false)]
        public string Cvc { get; set; }

        /// <summary>
        /// Gets or Sets EncryptedCardNumber
        /// </summary>
        [DataMember(Name = "encryptedCardNumber", EmitDefaultValue = false)]
        public string EncryptedCardNumber { get; set; }

        /// <summary>
        /// Gets or Sets EncryptedExpiryMonth
        /// </summary>
        [DataMember(Name = "encryptedExpiryMonth", EmitDefaultValue = false)]
        public string EncryptedExpiryMonth { get; set; }

        /// <summary>
        /// Gets or Sets EncryptedExpiryYear
        /// </summary>
        [DataMember(Name = "encryptedExpiryYear", EmitDefaultValue = false)]
        public string EncryptedExpiryYear { get; set; }

        /// <summary>
        /// Gets or Sets ExpiryMonth
        /// </summary>
        [DataMember(Name = "expiryMonth", EmitDefaultValue = false)]
        public string ExpiryMonth { get; set; }

        /// <summary>
        /// Gets or Sets ExpiryYear
        /// </summary>
        [DataMember(Name = "expiryYear", EmitDefaultValue = false)]
        public string ExpiryYear { get; set; }


        /// <summary>
        /// Gets or Sets HolderName
        /// </summary>
        [DataMember(Name = "holderName", EmitDefaultValue = false)]
        public string HolderName { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "recurringDetailReference", EmitDefaultValue = false)]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "storedPaymentMethodId", EmitDefaultValue = false)]
        public string StoredPaymentMethodId { get; set; }

        /// <summary>
        /// **scheme**
        /// </summary>
        /// <value>**scheme**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CardDetails {\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  CupsecureplusSmscode: ").Append(CupsecureplusSmscode).Append("\n");
            sb.Append("  Cvc: ").Append(Cvc).Append("\n");
            sb.Append("  EncryptedCardNumber: ").Append(EncryptedCardNumber).Append("\n");
            sb.Append("  EncryptedExpiryMonth: ").Append(EncryptedExpiryMonth).Append("\n");
            sb.Append("  EncryptedExpiryYear: ").Append(EncryptedExpiryYear).Append("\n");
            sb.Append("  ExpiryMonth: ").Append(ExpiryMonth).Append("\n");
            sb.Append("  ExpiryYear: ").Append(ExpiryYear).Append("\n");
            sb.Append("  FundingSource: ").Append(FundingSource).Append("\n");
            sb.Append("  HolderName: ").Append(HolderName).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
            sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as CardDetails);
        }

        /// <summary>
        /// Returns true if CardDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of CardDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Brand == input.Brand ||
                    this.Brand != null &&
                    this.Brand.Equals(input.Brand)
                ) &&
                (
                    this.CupsecureplusSmscode == input.CupsecureplusSmscode ||
                    this.CupsecureplusSmscode != null &&
                    this.CupsecureplusSmscode.Equals(input.CupsecureplusSmscode)
                ) &&
                (
                    this.Cvc == input.Cvc ||
                    this.Cvc != null &&
                    this.Cvc.Equals(input.Cvc)
                ) &&
                (
                    this.EncryptedCardNumber == input.EncryptedCardNumber ||
                    this.EncryptedCardNumber != null &&
                    this.EncryptedCardNumber.Equals(input.EncryptedCardNumber)
                ) &&
                (
                    this.EncryptedExpiryMonth == input.EncryptedExpiryMonth ||
                    this.EncryptedExpiryMonth != null &&
                    this.EncryptedExpiryMonth.Equals(input.EncryptedExpiryMonth)
                ) &&
                (
                    this.EncryptedExpiryYear == input.EncryptedExpiryYear ||
                    this.EncryptedExpiryYear != null &&
                    this.EncryptedExpiryYear.Equals(input.EncryptedExpiryYear)
                ) &&
                (
                    this.ExpiryMonth == input.ExpiryMonth ||
                    this.ExpiryMonth != null &&
                    this.ExpiryMonth.Equals(input.ExpiryMonth)
                ) &&
                (
                    this.ExpiryYear == input.ExpiryYear ||
                    this.ExpiryYear != null &&
                    this.ExpiryYear.Equals(input.ExpiryYear)
                ) &&
                (
                    this.FundingSource == input.FundingSource ||
                    this.FundingSource != null &&
                    this.FundingSource.Equals(input.FundingSource)
                ) &&
                (
                    this.HolderName == input.HolderName ||
                    this.HolderName != null &&
                    this.HolderName.Equals(input.HolderName)
                ) &&
                (
                    this.Number == input.Number ||
                    this.Number != null &&
                    this.Number.Equals(input.Number)
                ) &&
                (
                    this.RecurringDetailReference == input.RecurringDetailReference ||
                    this.RecurringDetailReference != null &&
                    this.RecurringDetailReference.Equals(input.RecurringDetailReference)
                ) &&
                (
                    this.StoredPaymentMethodId == input.StoredPaymentMethodId ||
                    this.StoredPaymentMethodId != null &&
                    this.StoredPaymentMethodId.Equals(input.StoredPaymentMethodId)
                ) &&
                (
                    this.Type == input.Type ||
                    this.Type != null &&
                    this.Type.Equals(input.Type)
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
                if (this.Brand != null)
                    hashCode = hashCode * 59 + this.Brand.GetHashCode();
                if (this.CupsecureplusSmscode != null)
                    hashCode = hashCode * 59 + this.CupsecureplusSmscode.GetHashCode();
                if (this.Cvc != null)
                    hashCode = hashCode * 59 + this.Cvc.GetHashCode();
                if (this.EncryptedCardNumber != null)
                    hashCode = hashCode * 59 + this.EncryptedCardNumber.GetHashCode();
                if (this.EncryptedExpiryMonth != null)
                    hashCode = hashCode * 59 + this.EncryptedExpiryMonth.GetHashCode();
                if (this.EncryptedExpiryYear != null)
                    hashCode = hashCode * 59 + this.EncryptedExpiryYear.GetHashCode();
                if (this.ExpiryMonth != null)
                    hashCode = hashCode * 59 + this.ExpiryMonth.GetHashCode();
                if (this.ExpiryYear != null)
                    hashCode = hashCode * 59 + this.ExpiryYear.GetHashCode();
                if (this.FundingSource != null)
                    hashCode = hashCode * 59 + this.FundingSource.GetHashCode();
                if (this.HolderName != null)
                    hashCode = hashCode * 59 + this.HolderName.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.RecurringDetailReference != null)
                    hashCode = hashCode * 59 + this.RecurringDetailReference.GetHashCode();
                if (this.StoredPaymentMethodId != null)
                    hashCode = hashCode * 59 + this.StoredPaymentMethodId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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