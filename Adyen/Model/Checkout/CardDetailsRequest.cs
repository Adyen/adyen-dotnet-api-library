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
    /// CardDetailsRequest
    /// </summary>
    [DataContract(Name = "CardDetailsRequest")]
    public partial class CardDetailsRequest : IEquatable<CardDetailsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardDetailsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CardDetailsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardDetailsRequest" /> class.
        /// </summary>
        /// <param name="cardNumber">A minimum of the first 8 digits of the card number and a maximum of the full card number. 11 digits gives the best result.   You must be [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide) to collect raw card data. (required).</param>
        /// <param name="countryCode">The shopper country.  Format: [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) Example: NL or DE.</param>
        /// <param name="merchantAccount">The merchant account identifier, with which you want to process the transaction. (required).</param>
        /// <param name="supportedBrands">The card brands you support. This is the [&#x60;brands&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/paymentMethods__resParam_paymentMethods-brands) array from your [&#x60;/paymentMethods&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/paymentMethods) response.   If not included, our API uses the ones configured for your merchant account and, if provided, the country code..</param>
        public CardDetailsRequest(string cardNumber = default(string), string countryCode = default(string), string merchantAccount = default(string), List<string> supportedBrands = default(List<string>))
        {
            this.CardNumber = cardNumber;
            this.MerchantAccount = merchantAccount;
            this.CountryCode = countryCode;
            this.SupportedBrands = supportedBrands;
        }

        /// <summary>
        /// A minimum of the first 8 digits of the card number and a maximum of the full card number. 11 digits gives the best result.   You must be [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide) to collect raw card data.
        /// </summary>
        /// <value>A minimum of the first 8 digits of the card number and a maximum of the full card number. 11 digits gives the best result.   You must be [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide) to collect raw card data.</value>
        [DataMember(Name = "cardNumber", IsRequired = false, EmitDefaultValue = true)]
        public string CardNumber { get; set; }

        /// <summary>
        /// The shopper country.  Format: [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) Example: NL or DE
        /// </summary>
        /// <value>The shopper country.  Format: [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) Example: NL or DE</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The merchant account identifier, with which you want to process the transaction.
        /// </summary>
        /// <value>The merchant account identifier, with which you want to process the transaction.</value>
        [DataMember(Name = "merchantAccount", IsRequired = false, EmitDefaultValue = true)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// The card brands you support. This is the [&#x60;brands&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/paymentMethods__resParam_paymentMethods-brands) array from your [&#x60;/paymentMethods&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/paymentMethods) response.   If not included, our API uses the ones configured for your merchant account and, if provided, the country code.
        /// </summary>
        /// <value>The card brands you support. This is the [&#x60;brands&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/paymentMethods__resParam_paymentMethods-brands) array from your [&#x60;/paymentMethods&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/paymentMethods) response.   If not included, our API uses the ones configured for your merchant account and, if provided, the country code.</value>
        [DataMember(Name = "supportedBrands", EmitDefaultValue = false)]
        public List<string> SupportedBrands { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CardDetailsRequest {\n");
            sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  SupportedBrands: ").Append(SupportedBrands).Append("\n");
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
            return this.Equals(input as CardDetailsRequest);
        }

        /// <summary>
        /// Returns true if CardDetailsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CardDetailsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardDetailsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CardNumber == input.CardNumber ||
                    (this.CardNumber != null &&
                    this.CardNumber.Equals(input.CardNumber))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) && 
                (
                    this.SupportedBrands == input.SupportedBrands ||
                    this.SupportedBrands != null &&
                    input.SupportedBrands != null &&
                    this.SupportedBrands.SequenceEqual(input.SupportedBrands)
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
                if (this.CardNumber != null)
                {
                    hashCode = (hashCode * 59) + this.CardNumber.GetHashCode();
                }
                if (this.CountryCode != null)
                {
                    hashCode = (hashCode * 59) + this.CountryCode.GetHashCode();
                }
                if (this.MerchantAccount != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccount.GetHashCode();
                }
                if (this.SupportedBrands != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedBrands.GetHashCode();
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
            yield break;
        }
    }

}
