/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
* Contact: developer-experience@adyen.com
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
    /// StoredPaymentMethodResource
    /// </summary>
    [DataContract(Name = "StoredPaymentMethodResource")]
    public partial class StoredPaymentMethodResource : IEquatable<StoredPaymentMethodResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoredPaymentMethodResource" /> class.
        /// </summary>
        /// <param name="brand">The brand of the card..</param>
        /// <param name="expiryMonth">The month the card expires..</param>
        /// <param name="expiryYear">The last two digits of the year the card expires. For example, **22** for the year 2022..</param>
        /// <param name="externalResponseCode">The response code returned by an external system (for example after a provisioning operation)..</param>
        /// <param name="externalTokenReference">The token reference of a linked token in an external system (for example a network token reference)..</param>
        /// <param name="holderName">The unique payment method code..</param>
        /// <param name="iban">The IBAN of the bank account..</param>
        /// <param name="id">A unique identifier of this stored payment method..</param>
        /// <param name="issuerName">The name of the issuer of token or card..</param>
        /// <param name="lastFour">The last four digits of the PAN..</param>
        /// <param name="name">The display name of the stored payment method..</param>
        /// <param name="networkTxReference">Returned in the response if you are not tokenizing with Adyen and are using the Merchant-initiated transactions (MIT) framework from Mastercard or Visa.  This contains either the Mastercard Trace ID or the Visa Transaction ID..</param>
        /// <param name="ownerName">The name of the bank account holder..</param>
        /// <param name="shopperEmail">The shopper’s email address..</param>
        /// <param name="shopperReference">Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address..</param>
        /// <param name="supportedRecurringProcessingModels">Defines a recurring payment type. Allowed values: * &#x60;Subscription&#x60; – A transaction for a fixed or variable amount, which follows a fixed schedule. * &#x60;CardOnFile&#x60; – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * &#x60;UnscheduledCardOnFile&#x60; – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder&#39;s balance drops below a certain amount..</param>
        /// <param name="type">The type of payment method..</param>
        public StoredPaymentMethodResource(string brand = default(string), string expiryMonth = default(string), string expiryYear = default(string), string externalResponseCode = default(string), string externalTokenReference = default(string), string holderName = default(string), string iban = default(string), string id = default(string), string issuerName = default(string), string lastFour = default(string), string name = default(string), string networkTxReference = default(string), string ownerName = default(string), string shopperEmail = default(string), string shopperReference = default(string), List<string> supportedRecurringProcessingModels = default(List<string>), string type = default(string))
        {
            this.Brand = brand;
            this.ExpiryMonth = expiryMonth;
            this.ExpiryYear = expiryYear;
            this.ExternalResponseCode = externalResponseCode;
            this.ExternalTokenReference = externalTokenReference;
            this.HolderName = holderName;
            this.Iban = iban;
            this.Id = id;
            this.IssuerName = issuerName;
            this.LastFour = lastFour;
            this.Name = name;
            this.NetworkTxReference = networkTxReference;
            this.OwnerName = ownerName;
            this.ShopperEmail = shopperEmail;
            this.ShopperReference = shopperReference;
            this.SupportedRecurringProcessingModels = supportedRecurringProcessingModels;
            this.Type = type;
        }

        /// <summary>
        /// The brand of the card.
        /// </summary>
        /// <value>The brand of the card.</value>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// The month the card expires.
        /// </summary>
        /// <value>The month the card expires.</value>
        [DataMember(Name = "expiryMonth", EmitDefaultValue = false)]
        public string ExpiryMonth { get; set; }

        /// <summary>
        /// The last two digits of the year the card expires. For example, **22** for the year 2022.
        /// </summary>
        /// <value>The last two digits of the year the card expires. For example, **22** for the year 2022.</value>
        [DataMember(Name = "expiryYear", EmitDefaultValue = false)]
        public string ExpiryYear { get; set; }

        /// <summary>
        /// The response code returned by an external system (for example after a provisioning operation).
        /// </summary>
        /// <value>The response code returned by an external system (for example after a provisioning operation).</value>
        [DataMember(Name = "externalResponseCode", EmitDefaultValue = false)]
        public string ExternalResponseCode { get; set; }

        /// <summary>
        /// The token reference of a linked token in an external system (for example a network token reference).
        /// </summary>
        /// <value>The token reference of a linked token in an external system (for example a network token reference).</value>
        [DataMember(Name = "externalTokenReference", EmitDefaultValue = false)]
        public string ExternalTokenReference { get; set; }

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
        /// The name of the issuer of token or card.
        /// </summary>
        /// <value>The name of the issuer of token or card.</value>
        [DataMember(Name = "issuerName", EmitDefaultValue = false)]
        public string IssuerName { get; set; }

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
        /// Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address.
        /// </summary>
        /// <value>Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address.</value>
        [DataMember(Name = "shopperReference", EmitDefaultValue = false)]
        public string ShopperReference { get; set; }

        /// <summary>
        /// Defines a recurring payment type. Allowed values: * &#x60;Subscription&#x60; – A transaction for a fixed or variable amount, which follows a fixed schedule. * &#x60;CardOnFile&#x60; – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * &#x60;UnscheduledCardOnFile&#x60; – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder&#39;s balance drops below a certain amount.
        /// </summary>
        /// <value>Defines a recurring payment type. Allowed values: * &#x60;Subscription&#x60; – A transaction for a fixed or variable amount, which follows a fixed schedule. * &#x60;CardOnFile&#x60; – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * &#x60;UnscheduledCardOnFile&#x60; – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder&#39;s balance drops below a certain amount.</value>
        [DataMember(Name = "supportedRecurringProcessingModels", EmitDefaultValue = false)]
        public List<string> SupportedRecurringProcessingModels { get; set; }

        /// <summary>
        /// The type of payment method.
        /// </summary>
        /// <value>The type of payment method.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StoredPaymentMethodResource {\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  ExpiryMonth: ").Append(ExpiryMonth).Append("\n");
            sb.Append("  ExpiryYear: ").Append(ExpiryYear).Append("\n");
            sb.Append("  ExternalResponseCode: ").Append(ExternalResponseCode).Append("\n");
            sb.Append("  ExternalTokenReference: ").Append(ExternalTokenReference).Append("\n");
            sb.Append("  HolderName: ").Append(HolderName).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IssuerName: ").Append(IssuerName).Append("\n");
            sb.Append("  LastFour: ").Append(LastFour).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NetworkTxReference: ").Append(NetworkTxReference).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
            sb.Append("  SupportedRecurringProcessingModels: ").Append(SupportedRecurringProcessingModels).Append("\n");
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
            return this.Equals(input as StoredPaymentMethodResource);
        }

        /// <summary>
        /// Returns true if StoredPaymentMethodResource instances are equal
        /// </summary>
        /// <param name="input">Instance of StoredPaymentMethodResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoredPaymentMethodResource input)
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
                    this.ExternalResponseCode == input.ExternalResponseCode ||
                    (this.ExternalResponseCode != null &&
                    this.ExternalResponseCode.Equals(input.ExternalResponseCode))
                ) && 
                (
                    this.ExternalTokenReference == input.ExternalTokenReference ||
                    (this.ExternalTokenReference != null &&
                    this.ExternalTokenReference.Equals(input.ExternalTokenReference))
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
                    this.IssuerName == input.IssuerName ||
                    (this.IssuerName != null &&
                    this.IssuerName.Equals(input.IssuerName))
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
                    this.ShopperReference == input.ShopperReference ||
                    (this.ShopperReference != null &&
                    this.ShopperReference.Equals(input.ShopperReference))
                ) && 
                (
                    this.SupportedRecurringProcessingModels == input.SupportedRecurringProcessingModels ||
                    this.SupportedRecurringProcessingModels != null &&
                    input.SupportedRecurringProcessingModels != null &&
                    this.SupportedRecurringProcessingModels.SequenceEqual(input.SupportedRecurringProcessingModels)
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
                if (this.ExpiryMonth != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiryMonth.GetHashCode();
                }
                if (this.ExpiryYear != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiryYear.GetHashCode();
                }
                if (this.ExternalResponseCode != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalResponseCode.GetHashCode();
                }
                if (this.ExternalTokenReference != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalTokenReference.GetHashCode();
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
                if (this.IssuerName != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerName.GetHashCode();
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
                if (this.ShopperReference != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperReference.GetHashCode();
                }
                if (this.SupportedRecurringProcessingModels != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedRecurringProcessingModels.GetHashCode();
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
            // ShopperReference (string) maxLength
            if (this.ShopperReference != null && this.ShopperReference.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShopperReference, length must be less than 256.", new [] { "ShopperReference" });
            }

            // ShopperReference (string) minLength
            if (this.ShopperReference != null && this.ShopperReference.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShopperReference, length must be greater than 3.", new [] { "ShopperReference" });
            }

            yield break;
        }
    }

}
