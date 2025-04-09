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
    /// PixStoredPaymentMethod
    /// </summary>
    [DataContract(Name = "PixStoredPaymentMethod")]
    public partial class PixStoredPaymentMethod : IEquatable<PixStoredPaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// The type of payment method.
        /// </summary>
        /// <value>The type of payment method.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Pix for value: pix
            /// </summary>
            [EnumMember(Value = "pix")]
            Pix = 1

        }


        /// <summary>
        /// The type of payment method.
        /// </summary>
        /// <value>The type of payment method.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PixStoredPaymentMethod" /> class.
        /// </summary>
        /// <param name="bankAccountNumber">The bank account number (without separators)..</param>
        /// <param name="bankLocationId">The location id of the bank. The field value is &#x60;nil&#x60; in most cases..</param>
        /// <param name="brand">The brand of the card..</param>
        /// <param name="expiryMonth">The two-digit month when the card expires.</param>
        /// <param name="expiryYear">The last two digits of the year the card expires. For example, **22** for the year 2022..</param>
        /// <param name="holderName">The unique payment method code..</param>
        /// <param name="iban">The IBAN of the bank account..</param>
        /// <param name="id">A unique identifier of this stored payment method..</param>
        /// <param name="label">The shopper’s issuer account label.</param>
        /// <param name="lastFour">The last four digits of the PAN..</param>
        /// <param name="name">The display name of the stored payment method..</param>
        /// <param name="networkTxReference">Returned in the response if you are not tokenizing with Adyen and are using the Merchant-initiated transactions (MIT) framework from Mastercard or Visa.  This contains either the Mastercard Trace ID or the Visa Transaction ID..</param>
        /// <param name="ownerName">The name of the bank account holder..</param>
        /// <param name="shopperEmail">The shopper’s email address..</param>
        /// <param name="supportedRecurringProcessingModels">The supported recurring processing models for this stored payment method..</param>
        /// <param name="supportedShopperInteractions">The supported shopper interactions for this stored payment method..</param>
        /// <param name="type">The type of payment method..</param>
        public PixStoredPaymentMethod(string bankAccountNumber = default(string), string bankLocationId = default(string), string brand = default(string), string expiryMonth = default(string), string expiryYear = default(string), string holderName = default(string), string iban = default(string), string id = default(string), string label = default(string), string lastFour = default(string), string name = default(string), string networkTxReference = default(string), string ownerName = default(string), string shopperEmail = default(string), List<string> supportedRecurringProcessingModels = default(List<string>), List<string> supportedShopperInteractions = default(List<string>), TypeEnum? type = default(TypeEnum?))
        {
            this.BankAccountNumber = bankAccountNumber;
            this.BankLocationId = bankLocationId;
            this.Brand = brand;
            this.ExpiryMonth = expiryMonth;
            this.ExpiryYear = expiryYear;
            this.HolderName = holderName;
            this.Iban = iban;
            this.Id = id;
            this.Label = label;
            this.LastFour = lastFour;
            this.Name = name;
            this.NetworkTxReference = networkTxReference;
            this.OwnerName = ownerName;
            this.ShopperEmail = shopperEmail;
            this.SupportedRecurringProcessingModels = supportedRecurringProcessingModels;
            this.SupportedShopperInteractions = supportedShopperInteractions;
            this.Type = type;
        }

        /// <summary>
        /// The bank account number (without separators).
        /// </summary>
        /// <value>The bank account number (without separators).</value>
        [DataMember(Name = "bankAccountNumber", EmitDefaultValue = false)]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// The location id of the bank. The field value is &#x60;nil&#x60; in most cases.
        /// </summary>
        /// <value>The location id of the bank. The field value is &#x60;nil&#x60; in most cases.</value>
        [DataMember(Name = "bankLocationId", EmitDefaultValue = false)]
        public string BankLocationId { get; set; }

        /// <summary>
        /// The brand of the card.
        /// </summary>
        /// <value>The brand of the card.</value>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// The two-digit month when the card expires
        /// </summary>
        /// <value>The two-digit month when the card expires</value>
        [DataMember(Name = "expiryMonth", EmitDefaultValue = false)]
        public string ExpiryMonth { get; set; }

        /// <summary>
        /// The last two digits of the year the card expires. For example, **22** for the year 2022.
        /// </summary>
        /// <value>The last two digits of the year the card expires. For example, **22** for the year 2022.</value>
        [DataMember(Name = "expiryYear", EmitDefaultValue = false)]
        public string ExpiryYear { get; set; }

        /// <summary>
        /// The unique payment method code.
        /// </summary>
        /// <value>The unique payment method code.</value>
        [DataMember(Name = "holderName", EmitDefaultValue = false)]
        public string HolderName { get; set; }

        /// <summary>
        /// The IBAN of the bank account.
        /// </summary>
        /// <value>The IBAN of the bank account.</value>
        [DataMember(Name = "iban", EmitDefaultValue = false)]
        public string Iban { get; set; }

        /// <summary>
        /// A unique identifier of this stored payment method.
        /// </summary>
        /// <value>A unique identifier of this stored payment method.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The shopper’s issuer account label
        /// </summary>
        /// <value>The shopper’s issuer account label</value>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// The last four digits of the PAN.
        /// </summary>
        /// <value>The last four digits of the PAN.</value>
        [DataMember(Name = "lastFour", EmitDefaultValue = false)]
        public string LastFour { get; set; }

        /// <summary>
        /// The display name of the stored payment method.
        /// </summary>
        /// <value>The display name of the stored payment method.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returned in the response if you are not tokenizing with Adyen and are using the Merchant-initiated transactions (MIT) framework from Mastercard or Visa.  This contains either the Mastercard Trace ID or the Visa Transaction ID.
        /// </summary>
        /// <value>Returned in the response if you are not tokenizing with Adyen and are using the Merchant-initiated transactions (MIT) framework from Mastercard or Visa.  This contains either the Mastercard Trace ID or the Visa Transaction ID.</value>
        [DataMember(Name = "networkTxReference", EmitDefaultValue = false)]
        public string NetworkTxReference { get; set; }

        /// <summary>
        /// The name of the bank account holder.
        /// </summary>
        /// <value>The name of the bank account holder.</value>
        [DataMember(Name = "ownerName", EmitDefaultValue = false)]
        public string OwnerName { get; set; }

        /// <summary>
        /// The shopper’s email address.
        /// </summary>
        /// <value>The shopper’s email address.</value>
        [DataMember(Name = "shopperEmail", EmitDefaultValue = false)]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// The supported recurring processing models for this stored payment method.
        /// </summary>
        /// <value>The supported recurring processing models for this stored payment method.</value>
        [DataMember(Name = "supportedRecurringProcessingModels", EmitDefaultValue = false)]
        public List<string> SupportedRecurringProcessingModels { get; set; }

        /// <summary>
        /// The supported shopper interactions for this stored payment method.
        /// </summary>
        /// <value>The supported shopper interactions for this stored payment method.</value>
        [DataMember(Name = "supportedShopperInteractions", EmitDefaultValue = false)]
        public List<string> SupportedShopperInteractions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PixStoredPaymentMethod {\n");
            sb.Append("  BankAccountNumber: ").Append(BankAccountNumber).Append("\n");
            sb.Append("  BankLocationId: ").Append(BankLocationId).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  ExpiryMonth: ").Append(ExpiryMonth).Append("\n");
            sb.Append("  ExpiryYear: ").Append(ExpiryYear).Append("\n");
            sb.Append("  HolderName: ").Append(HolderName).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  LastFour: ").Append(LastFour).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NetworkTxReference: ").Append(NetworkTxReference).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
            sb.Append("  SupportedRecurringProcessingModels: ").Append(SupportedRecurringProcessingModels).Append("\n");
            sb.Append("  SupportedShopperInteractions: ").Append(SupportedShopperInteractions).Append("\n");
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
            return this.Equals(input as PixStoredPaymentMethod);
        }

        /// <summary>
        /// Returns true if PixStoredPaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of PixStoredPaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PixStoredPaymentMethod input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BankAccountNumber == input.BankAccountNumber ||
                    (this.BankAccountNumber != null &&
                    this.BankAccountNumber.Equals(input.BankAccountNumber))
                ) && 
                (
                    this.BankLocationId == input.BankLocationId ||
                    (this.BankLocationId != null &&
                    this.BankLocationId.Equals(input.BankLocationId))
                ) && 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
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
                    this.Iban == input.Iban ||
                    (this.Iban != null &&
                    this.Iban.Equals(input.Iban))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.LastFour == input.LastFour ||
                    (this.LastFour != null &&
                    this.LastFour.Equals(input.LastFour))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NetworkTxReference == input.NetworkTxReference ||
                    (this.NetworkTxReference != null &&
                    this.NetworkTxReference.Equals(input.NetworkTxReference))
                ) && 
                (
                    this.OwnerName == input.OwnerName ||
                    (this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName))
                ) && 
                (
                    this.ShopperEmail == input.ShopperEmail ||
                    (this.ShopperEmail != null &&
                    this.ShopperEmail.Equals(input.ShopperEmail))
                ) && 
                (
                    this.SupportedRecurringProcessingModels == input.SupportedRecurringProcessingModels ||
                    this.SupportedRecurringProcessingModels != null &&
                    input.SupportedRecurringProcessingModels != null &&
                    this.SupportedRecurringProcessingModels.SequenceEqual(input.SupportedRecurringProcessingModels)
                ) && 
                (
                    this.SupportedShopperInteractions == input.SupportedShopperInteractions ||
                    this.SupportedShopperInteractions != null &&
                    input.SupportedShopperInteractions != null &&
                    this.SupportedShopperInteractions.SequenceEqual(input.SupportedShopperInteractions)
                ) && 
                (
                    this.Type == input.Type ||
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
                if (this.BankAccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.BankAccountNumber.GetHashCode();
                }
                if (this.BankLocationId != null)
                {
                    hashCode = (hashCode * 59) + this.BankLocationId.GetHashCode();
                }
                if (this.Brand != null)
                {
                    hashCode = (hashCode * 59) + this.Brand.GetHashCode();
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
                if (this.Iban != null)
                {
                    hashCode = (hashCode * 59) + this.Iban.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
                }
                if (this.LastFour != null)
                {
                    hashCode = (hashCode * 59) + this.LastFour.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.NetworkTxReference != null)
                {
                    hashCode = (hashCode * 59) + this.NetworkTxReference.GetHashCode();
                }
                if (this.OwnerName != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerName.GetHashCode();
                }
                if (this.ShopperEmail != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperEmail.GetHashCode();
                }
                if (this.SupportedRecurringProcessingModels != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedRecurringProcessingModels.GetHashCode();
                }
                if (this.SupportedShopperInteractions != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedShopperInteractions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
            yield break;
        }
    }

}
