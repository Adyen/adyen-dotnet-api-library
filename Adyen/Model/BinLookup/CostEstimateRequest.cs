/*
* Adyen BinLookup API
*
*
* The version of the OpenAPI document: 54
* 
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

namespace Adyen.Model.BinLookup
{
    /// <summary>
    /// CostEstimateRequest
    /// </summary>
    [DataContract(Name = "CostEstimateRequest")]
    public partial class CostEstimateRequest : IEquatable<CostEstimateRequest>, IValidatableObject
    {
        /// <summary>
        /// Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * &#x60;Ecommerce&#x60; - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * &#x60;ContAuth&#x60; - Card on file and/or subscription transactions, where the card holder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * &#x60;Moto&#x60; - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * &#x60;POS&#x60; - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.
        /// </summary>
        /// <value>Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * &#x60;Ecommerce&#x60; - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * &#x60;ContAuth&#x60; - Card on file and/or subscription transactions, where the card holder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * &#x60;Moto&#x60; - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * &#x60;POS&#x60; - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShopperInteractionEnum
        {
            /// <summary>
            /// Enum Ecommerce for value: Ecommerce
            /// </summary>
            [EnumMember(Value = "Ecommerce")]
            Ecommerce = 1,

            /// <summary>
            /// Enum ContAuth for value: ContAuth
            /// </summary>
            [EnumMember(Value = "ContAuth")]
            ContAuth = 2,

            /// <summary>
            /// Enum Moto for value: Moto
            /// </summary>
            [EnumMember(Value = "Moto")]
            Moto = 3,

            /// <summary>
            /// Enum POS for value: POS
            /// </summary>
            [EnumMember(Value = "POS")]
            POS = 4

        }


        /// <summary>
        /// Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * &#x60;Ecommerce&#x60; - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * &#x60;ContAuth&#x60; - Card on file and/or subscription transactions, where the card holder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * &#x60;Moto&#x60; - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * &#x60;POS&#x60; - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.
        /// </summary>
        /// <value>Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * &#x60;Ecommerce&#x60; - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * &#x60;ContAuth&#x60; - Card on file and/or subscription transactions, where the card holder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * &#x60;Moto&#x60; - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * &#x60;POS&#x60; - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.</value>
        [DataMember(Name = "shopperInteraction", EmitDefaultValue = false)]
        public ShopperInteractionEnum? ShopperInteraction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CostEstimateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CostEstimateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CostEstimateRequest" /> class.
        /// </summary>
        /// <param name="amount">amount (required).</param>
        /// <param name="assumptions">assumptions.</param>
        /// <param name="cardNumber">The card number (4-19 characters) for PCI compliant use cases. Do not use any separators.  &gt; Either the &#x60;cardNumber&#x60; or &#x60;encryptedCardNumber&#x60; field must be provided in a payment request..</param>
        /// <param name="encryptedCardNumber">Encrypted data that stores card information for non PCI-compliant use cases. The encrypted data must be created with the Checkout Card Component or Secured Fields Component, and must contain the &#x60;encryptedCardNumber&#x60; field.  &gt; Either the &#x60;cardNumber&#x60; or &#x60;encryptedCardNumber&#x60; field must be provided in a payment request..</param>
        /// <param name="merchantAccount">The merchant account identifier you want to process the (transaction) request with. (required).</param>
        /// <param name="merchantDetails">merchantDetails.</param>
        /// <param name="recurring">recurring.</param>
        /// <param name="selectedRecurringDetailReference">The &#x60;recurringDetailReference&#x60; you want to use for this cost estimate. The value &#x60;LATEST&#x60; can be used to select the most recently stored recurring detail..</param>
        /// <param name="shopperInteraction">Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * &#x60;Ecommerce&#x60; - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * &#x60;ContAuth&#x60; - Card on file and/or subscription transactions, where the card holder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * &#x60;Moto&#x60; - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * &#x60;POS&#x60; - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal..</param>
        /// <param name="shopperReference">Required for recurring payments.  Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address..</param>
        public CostEstimateRequest(Amount amount = default(Amount), CostEstimateAssumptions assumptions = default(CostEstimateAssumptions), string cardNumber = default(string), string encryptedCardNumber = default(string), string merchantAccount = default(string), MerchantDetails merchantDetails = default(MerchantDetails), Recurring recurring = default(Recurring), string selectedRecurringDetailReference = default(string), ShopperInteractionEnum? shopperInteraction = default(ShopperInteractionEnum?), string shopperReference = default(string))
        {
            this.Amount = amount;
            this.MerchantAccount = merchantAccount;
            this.Assumptions = assumptions;
            this.CardNumber = cardNumber;
            this.EncryptedCardNumber = encryptedCardNumber;
            this.MerchantDetails = merchantDetails;
            this.Recurring = recurring;
            this.SelectedRecurringDetailReference = selectedRecurringDetailReference;
            this.ShopperInteraction = shopperInteraction;
            this.ShopperReference = shopperReference;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = false, EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// Gets or Sets Assumptions
        /// </summary>
        [DataMember(Name = "assumptions", EmitDefaultValue = false)]
        public CostEstimateAssumptions Assumptions { get; set; }

        /// <summary>
        /// The card number (4-19 characters) for PCI compliant use cases. Do not use any separators.  &gt; Either the &#x60;cardNumber&#x60; or &#x60;encryptedCardNumber&#x60; field must be provided in a payment request.
        /// </summary>
        /// <value>The card number (4-19 characters) for PCI compliant use cases. Do not use any separators.  &gt; Either the &#x60;cardNumber&#x60; or &#x60;encryptedCardNumber&#x60; field must be provided in a payment request.</value>
        [DataMember(Name = "cardNumber", EmitDefaultValue = false)]
        public string CardNumber { get; set; }

        /// <summary>
        /// Encrypted data that stores card information for non PCI-compliant use cases. The encrypted data must be created with the Checkout Card Component or Secured Fields Component, and must contain the &#x60;encryptedCardNumber&#x60; field.  &gt; Either the &#x60;cardNumber&#x60; or &#x60;encryptedCardNumber&#x60; field must be provided in a payment request.
        /// </summary>
        /// <value>Encrypted data that stores card information for non PCI-compliant use cases. The encrypted data must be created with the Checkout Card Component or Secured Fields Component, and must contain the &#x60;encryptedCardNumber&#x60; field.  &gt; Either the &#x60;cardNumber&#x60; or &#x60;encryptedCardNumber&#x60; field must be provided in a payment request.</value>
        [DataMember(Name = "encryptedCardNumber", EmitDefaultValue = false)]
        public string EncryptedCardNumber { get; set; }

        /// <summary>
        /// The merchant account identifier you want to process the (transaction) request with.
        /// </summary>
        /// <value>The merchant account identifier you want to process the (transaction) request with.</value>
        [DataMember(Name = "merchantAccount", IsRequired = false, EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Gets or Sets MerchantDetails
        /// </summary>
        [DataMember(Name = "merchantDetails", EmitDefaultValue = false)]
        public MerchantDetails MerchantDetails { get; set; }

        /// <summary>
        /// Gets or Sets Recurring
        /// </summary>
        [DataMember(Name = "recurring", EmitDefaultValue = false)]
        public Recurring Recurring { get; set; }

        /// <summary>
        /// The &#x60;recurringDetailReference&#x60; you want to use for this cost estimate. The value &#x60;LATEST&#x60; can be used to select the most recently stored recurring detail.
        /// </summary>
        /// <value>The &#x60;recurringDetailReference&#x60; you want to use for this cost estimate. The value &#x60;LATEST&#x60; can be used to select the most recently stored recurring detail.</value>
        [DataMember(Name = "selectedRecurringDetailReference", EmitDefaultValue = false)]
        public string SelectedRecurringDetailReference { get; set; }

        /// <summary>
        /// Required for recurring payments.  Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address.
        /// </summary>
        /// <value>Required for recurring payments.  Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address.</value>
        [DataMember(Name = "shopperReference", EmitDefaultValue = false)]
        public string ShopperReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CostEstimateRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Assumptions: ").Append(Assumptions).Append("\n");
            sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
            sb.Append("  EncryptedCardNumber: ").Append(EncryptedCardNumber).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  MerchantDetails: ").Append(MerchantDetails).Append("\n");
            sb.Append("  Recurring: ").Append(Recurring).Append("\n");
            sb.Append("  SelectedRecurringDetailReference: ").Append(SelectedRecurringDetailReference).Append("\n");
            sb.Append("  ShopperInteraction: ").Append(ShopperInteraction).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
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
            return this.Equals(input as CostEstimateRequest);
        }

        /// <summary>
        /// Returns true if CostEstimateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CostEstimateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CostEstimateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Assumptions == input.Assumptions ||
                    (this.Assumptions != null &&
                    this.Assumptions.Equals(input.Assumptions))
                ) && 
                (
                    this.CardNumber == input.CardNumber ||
                    (this.CardNumber != null &&
                    this.CardNumber.Equals(input.CardNumber))
                ) && 
                (
                    this.EncryptedCardNumber == input.EncryptedCardNumber ||
                    (this.EncryptedCardNumber != null &&
                    this.EncryptedCardNumber.Equals(input.EncryptedCardNumber))
                ) && 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) && 
                (
                    this.MerchantDetails == input.MerchantDetails ||
                    (this.MerchantDetails != null &&
                    this.MerchantDetails.Equals(input.MerchantDetails))
                ) && 
                (
                    this.Recurring == input.Recurring ||
                    (this.Recurring != null &&
                    this.Recurring.Equals(input.Recurring))
                ) && 
                (
                    this.SelectedRecurringDetailReference == input.SelectedRecurringDetailReference ||
                    (this.SelectedRecurringDetailReference != null &&
                    this.SelectedRecurringDetailReference.Equals(input.SelectedRecurringDetailReference))
                ) && 
                (
                    this.ShopperInteraction == input.ShopperInteraction ||
                    this.ShopperInteraction.Equals(input.ShopperInteraction)
                ) && 
                (
                    this.ShopperReference == input.ShopperReference ||
                    (this.ShopperReference != null &&
                    this.ShopperReference.Equals(input.ShopperReference))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.Assumptions != null)
                {
                    hashCode = (hashCode * 59) + this.Assumptions.GetHashCode();
                }
                if (this.CardNumber != null)
                {
                    hashCode = (hashCode * 59) + this.CardNumber.GetHashCode();
                }
                if (this.EncryptedCardNumber != null)
                {
                    hashCode = (hashCode * 59) + this.EncryptedCardNumber.GetHashCode();
                }
                if (this.MerchantAccount != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccount.GetHashCode();
                }
                if (this.MerchantDetails != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantDetails.GetHashCode();
                }
                if (this.Recurring != null)
                {
                    hashCode = (hashCode * 59) + this.Recurring.GetHashCode();
                }
                if (this.SelectedRecurringDetailReference != null)
                {
                    hashCode = (hashCode * 59) + this.SelectedRecurringDetailReference.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ShopperInteraction.GetHashCode();
                if (this.ShopperReference != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperReference.GetHashCode();
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
            // CardNumber (string) maxLength
            if (this.CardNumber != null && this.CardNumber.Length > 19)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CardNumber, length must be less than 19.", new [] { "CardNumber" });
            }

            // CardNumber (string) minLength
            if (this.CardNumber != null && this.CardNumber.Length < 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CardNumber, length must be greater than 4.", new [] { "CardNumber" });
            }

            yield break;
        }
    }

}
