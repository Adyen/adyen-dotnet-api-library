/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 71
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// PaymentMethodToStore
    /// </summary>
    [DataContract(Name = "PaymentMethodToStore")]
    public partial class PaymentMethodToStore : IEquatable<PaymentMethodToStore>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodToStore" /> class.
        /// </summary>
        /// <param name="brand">Secondary brand of the card. For example: **plastix**, **hmclub**..</param>
        /// <param name="cvc">The card verification code. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide)..</param>
        /// <param name="encryptedCard">The encrypted card..</param>
        /// <param name="encryptedCardNumber">The encrypted card number..</param>
        /// <param name="encryptedExpiryMonth">The encrypted card expiry month..</param>
        /// <param name="encryptedExpiryYear">The encrypted card expiry year..</param>
        /// <param name="encryptedSecurityCode">The encrypted card verification code..</param>
        /// <param name="expiryMonth">The card expiry month. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide)..</param>
        /// <param name="expiryYear">The card expiry year. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide)..</param>
        /// <param name="holderName">The name of the card holder..</param>
        /// <param name="number">The card number. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide)..</param>
        /// <param name="type">Set to **scheme**..</param>
        public PaymentMethodToStore(string brand = default(string), string cvc = default(string), string encryptedCard = default(string), string encryptedCardNumber = default(string), string encryptedExpiryMonth = default(string), string encryptedExpiryYear = default(string), string encryptedSecurityCode = default(string), string expiryMonth = default(string), string expiryYear = default(string), string holderName = default(string), string number = default(string), string type = default(string))
        {
            this.Brand = brand;
            this.Cvc = cvc;
            this.EncryptedCard = encryptedCard;
            this.EncryptedCardNumber = encryptedCardNumber;
            this.EncryptedExpiryMonth = encryptedExpiryMonth;
            this.EncryptedExpiryYear = encryptedExpiryYear;
            this.EncryptedSecurityCode = encryptedSecurityCode;
            this.ExpiryMonth = expiryMonth;
            this.ExpiryYear = expiryYear;
            this.HolderName = holderName;
            this.Number = number;
            this.Type = type;
        }

        /// <summary>
        /// Secondary brand of the card. For example: **plastix**, **hmclub**.
        /// </summary>
        /// <value>Secondary brand of the card. For example: **plastix**, **hmclub**.</value>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// The card verification code. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide).
        /// </summary>
        /// <value>The card verification code. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide).</value>
        [DataMember(Name = "cvc", EmitDefaultValue = false)]
        public string Cvc { get; set; }

        /// <summary>
        /// The encrypted card.
        /// </summary>
        /// <value>The encrypted card.</value>
        [DataMember(Name = "encryptedCard", EmitDefaultValue = false)]
        public string EncryptedCard { get; set; }

        /// <summary>
        /// The encrypted card number.
        /// </summary>
        /// <value>The encrypted card number.</value>
        [DataMember(Name = "encryptedCardNumber", EmitDefaultValue = false)]
        public string EncryptedCardNumber { get; set; }

        /// <summary>
        /// The encrypted card expiry month.
        /// </summary>
        /// <value>The encrypted card expiry month.</value>
        [DataMember(Name = "encryptedExpiryMonth", EmitDefaultValue = false)]
        public string EncryptedExpiryMonth { get; set; }

        /// <summary>
        /// The encrypted card expiry year.
        /// </summary>
        /// <value>The encrypted card expiry year.</value>
        [DataMember(Name = "encryptedExpiryYear", EmitDefaultValue = false)]
        public string EncryptedExpiryYear { get; set; }

        /// <summary>
        /// The encrypted card verification code.
        /// </summary>
        /// <value>The encrypted card verification code.</value>
        [DataMember(Name = "encryptedSecurityCode", EmitDefaultValue = false)]
        public string EncryptedSecurityCode { get; set; }

        /// <summary>
        /// The card expiry month. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide).
        /// </summary>
        /// <value>The card expiry month. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide).</value>
        [DataMember(Name = "expiryMonth", EmitDefaultValue = false)]
        public string ExpiryMonth { get; set; }

        /// <summary>
        /// The card expiry year. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide).
        /// </summary>
        /// <value>The card expiry year. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide).</value>
        [DataMember(Name = "expiryYear", EmitDefaultValue = false)]
        public string ExpiryYear { get; set; }

        /// <summary>
        /// The name of the card holder.
        /// </summary>
        /// <value>The name of the card holder.</value>
        [DataMember(Name = "holderName", EmitDefaultValue = false)]
        public string HolderName { get; set; }

        /// <summary>
        /// The card number. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide).
        /// </summary>
        /// <value>The card number. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide).</value>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// Set to **scheme**.
        /// </summary>
        /// <value>Set to **scheme**.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethodToStore {\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  Cvc: ").Append(Cvc).Append("\n");
            sb.Append("  EncryptedCard: ").Append(EncryptedCard).Append("\n");
            sb.Append("  EncryptedCardNumber: ").Append(EncryptedCardNumber).Append("\n");
            sb.Append("  EncryptedExpiryMonth: ").Append(EncryptedExpiryMonth).Append("\n");
            sb.Append("  EncryptedExpiryYear: ").Append(EncryptedExpiryYear).Append("\n");
            sb.Append("  EncryptedSecurityCode: ").Append(EncryptedSecurityCode).Append("\n");
            sb.Append("  ExpiryMonth: ").Append(ExpiryMonth).Append("\n");
            sb.Append("  ExpiryYear: ").Append(ExpiryYear).Append("\n");
            sb.Append("  HolderName: ").Append(HolderName).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaymentMethodToStore);
        }

        /// <summary>
        /// Returns true if PaymentMethodToStore instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodToStore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodToStore input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
                ) && 
                (
                    this.Cvc == input.Cvc ||
                    (this.Cvc != null &&
                    this.Cvc.Equals(input.Cvc))
                ) && 
                (
                    this.EncryptedCard == input.EncryptedCard ||
                    (this.EncryptedCard != null &&
                    this.EncryptedCard.Equals(input.EncryptedCard))
                ) && 
                (
                    this.EncryptedCardNumber == input.EncryptedCardNumber ||
                    (this.EncryptedCardNumber != null &&
                    this.EncryptedCardNumber.Equals(input.EncryptedCardNumber))
                ) && 
                (
                    this.EncryptedExpiryMonth == input.EncryptedExpiryMonth ||
                    (this.EncryptedExpiryMonth != null &&
                    this.EncryptedExpiryMonth.Equals(input.EncryptedExpiryMonth))
                ) && 
                (
                    this.EncryptedExpiryYear == input.EncryptedExpiryYear ||
                    (this.EncryptedExpiryYear != null &&
                    this.EncryptedExpiryYear.Equals(input.EncryptedExpiryYear))
                ) && 
                (
                    this.EncryptedSecurityCode == input.EncryptedSecurityCode ||
                    (this.EncryptedSecurityCode != null &&
                    this.EncryptedSecurityCode.Equals(input.EncryptedSecurityCode))
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
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                {
                    hashCode = (hashCode * 59) + this.Brand.GetHashCode();
                }
                if (this.Cvc != null)
                {
                    hashCode = (hashCode * 59) + this.Cvc.GetHashCode();
                }
                if (this.EncryptedCard != null)
                {
                    hashCode = (hashCode * 59) + this.EncryptedCard.GetHashCode();
                }
                if (this.EncryptedCardNumber != null)
                {
                    hashCode = (hashCode * 59) + this.EncryptedCardNumber.GetHashCode();
                }
                if (this.EncryptedExpiryMonth != null)
                {
                    hashCode = (hashCode * 59) + this.EncryptedExpiryMonth.GetHashCode();
                }
                if (this.EncryptedExpiryYear != null)
                {
                    hashCode = (hashCode * 59) + this.EncryptedExpiryYear.GetHashCode();
                }
                if (this.EncryptedSecurityCode != null)
                {
                    hashCode = (hashCode * 59) + this.EncryptedSecurityCode.GetHashCode();
                }
                if (this.ExpiryMonth != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiryMonth.GetHashCode();
                }
                if (this.ExpiryYear != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiryYear.GetHashCode();
                }
                if (this.HolderName != null)
                {
                    hashCode = (hashCode * 59) + this.HolderName.GetHashCode();
                }
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // EncryptedCard (string) maxLength
            if (this.EncryptedCard != null && this.EncryptedCard.Length > 40000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EncryptedCard, length must be less than 40000.", new [] { "EncryptedCard" });
            }

            // EncryptedCardNumber (string) maxLength
            if (this.EncryptedCardNumber != null && this.EncryptedCardNumber.Length > 15000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EncryptedCardNumber, length must be less than 15000.", new [] { "EncryptedCardNumber" });
            }

            // EncryptedExpiryMonth (string) maxLength
            if (this.EncryptedExpiryMonth != null && this.EncryptedExpiryMonth.Length > 15000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EncryptedExpiryMonth, length must be less than 15000.", new [] { "EncryptedExpiryMonth" });
            }

            // EncryptedExpiryYear (string) maxLength
            if (this.EncryptedExpiryYear != null && this.EncryptedExpiryYear.Length > 15000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EncryptedExpiryYear, length must be less than 15000.", new [] { "EncryptedExpiryYear" });
            }

            // EncryptedSecurityCode (string) maxLength
            if (this.EncryptedSecurityCode != null && this.EncryptedSecurityCode.Length > 15000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EncryptedSecurityCode, length must be less than 15000.", new [] { "EncryptedSecurityCode" });
            }

            yield break;
        }
    }

}
