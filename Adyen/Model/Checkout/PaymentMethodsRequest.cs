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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// PaymentMethodsRequest
    /// </summary>
    [DataContract]
    public partial class PaymentMethodsRequest : IEquatable<PaymentMethodsRequest>, IValidatableObject
    {
        /// <summary>
        /// The platform where a payment transaction takes place. This field can be used for filtering out payment methods that are only available on specific platforms. Possible values: * iOS * Android * Web
        /// </summary>
        /// <value>The platform where a payment transaction takes place. This field can be used for filtering out payment methods that are only available on specific platforms. Possible values: * iOS * Android * Web</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChannelEnum
        {
            /// <summary>
            /// Enum IOS for value: iOS
            /// </summary>
            [EnumMember(Value = "iOS")]
            IOS = 1,
            /// <summary>
            /// Enum Android for value: Android
            /// </summary>
            [EnumMember(Value = "Android")]
            Android = 2,
            /// <summary>
            /// Enum Web for value: Web
            /// </summary>
            [EnumMember(Value = "Web")]
            Web = 3
        }
        /// <summary>
        /// The platform where a payment transaction takes place. This field can be used for filtering out payment methods that are only available on specific platforms. Possible values: * iOS * Android * Web
        /// </summary>
        /// <value>The platform where a payment transaction takes place. This field can be used for filtering out payment methods that are only available on specific platforms. Possible values: * iOS * Android * Web</value>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public ChannelEnum? Channel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodsRequest" /> class.
        /// </summary>
        /// <param name="additionalData">This field contains additional data, which may be required for a particular payment request.  The &#x60;additionalData&#x60; object consists of entries, each of which includes the key and value..</param>
        /// <param name="allowedPaymentMethods">List of payments methods to be presented to the shopper. To refer to payment methods, use their &#x60;brandCode&#x60; from [Payment methods overview](https://docs.adyen.com/payment-methods)..</param>
        /// <param name="amount">amount.</param>
        /// <param name="blockedPaymentMethods">List of payments methods to be hidden from the shopper. To refer to payment methods, use their &#x60;brandCode&#x60; from [Payment methods overview](https://docs.adyen.com/payment-methods)..</param>
        /// <param name="channel">The platform where a payment transaction takes place. This field can be used for filtering out payment methods that are only available on specific platforms. Possible values: * iOS * Android * Web.</param>
        /// <param name="countryCode">The shopper&#x27;s country code..</param>
        /// <param name="enableRealTimeUpdate">Choose if a specific transaction should use the Real-time Account Updater, regardless of other settings..</param>
        /// <param name="merchantAccount">The merchant account identifier, with which you want to process the transaction. (required).</param>
        /// <param name="shopperLocale">The combination of a language code and a country code to specify the language to be used in the payment..</param>
        /// <param name="shopperReference">The shopper&#x27;s reference to uniquely identify this shopper (e.g. user ID or account ID). &gt; This field is required for recurring payments..</param>
        /// <param name="threeDSAuthenticationOnly">If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation..</param>
        public PaymentMethodsRequest(Dictionary<string, string> additionalData = default(Dictionary<string, string>), List<string> allowedPaymentMethods = default(List<string>), Amount amount = default(Amount), List<string> blockedPaymentMethods = default(List<string>), ChannelEnum? channel = default(ChannelEnum?), string countryCode = default(string), bool? enableRealTimeUpdate = default(bool?), string merchantAccount = default(string), string shopperLocale = default(string), string shopperReference = default(string), bool? threeDSAuthenticationOnly = default(bool?))
        {
            // to ensure "merchantAccount" is required (not null)
            if (merchantAccount == null)
            {
                throw new InvalidDataException("merchantAccount is a required property for PaymentMethodsRequest and cannot be null");
            }
            else
            {
                this.MerchantAccount = merchantAccount;
            }
            this.AdditionalData = additionalData;
            this.AllowedPaymentMethods = allowedPaymentMethods;
            this.Amount = amount;
            this.BlockedPaymentMethods = blockedPaymentMethods;
            this.Channel = channel;
            this.CountryCode = countryCode;
            this.EnableRealTimeUpdate = enableRealTimeUpdate;
            this.ShopperLocale = shopperLocale;
            this.ShopperReference = shopperReference;
            this.ThreeDSAuthenticationOnly = threeDSAuthenticationOnly;
        }

        /// <summary>
        /// This field contains additional data, which may be required for a particular payment request.  The &#x60;additionalData&#x60; object consists of entries, each of which includes the key and value.
        /// </summary>
        /// <value>This field contains additional data, which may be required for a particular payment request.  The &#x60;additionalData&#x60; object consists of entries, each of which includes the key and value.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// List of payments methods to be presented to the shopper. To refer to payment methods, use their &#x60;brandCode&#x60; from [Payment methods overview](https://docs.adyen.com/payment-methods).
        /// </summary>
        /// <value>List of payments methods to be presented to the shopper. To refer to payment methods, use their &#x60;brandCode&#x60; from [Payment methods overview](https://docs.adyen.com/payment-methods).</value>
        [DataMember(Name = "allowedPaymentMethods", EmitDefaultValue = false)]
        public List<string> AllowedPaymentMethods { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// List of payments methods to be hidden from the shopper. To refer to payment methods, use their &#x60;brandCode&#x60; from [Payment methods overview](https://docs.adyen.com/payment-methods).
        /// </summary>
        /// <value>List of payments methods to be hidden from the shopper. To refer to payment methods, use their &#x60;brandCode&#x60; from [Payment methods overview](https://docs.adyen.com/payment-methods).</value>
        [DataMember(Name = "blockedPaymentMethods", EmitDefaultValue = false)]
        public List<string> BlockedPaymentMethods { get; set; }


        /// <summary>
        /// The shopper&#x27;s country code.
        /// </summary>
        /// <value>The shopper&#x27;s country code.</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Choose if a specific transaction should use the Real-time Account Updater, regardless of other settings.
        /// </summary>
        /// <value>Choose if a specific transaction should use the Real-time Account Updater, regardless of other settings.</value>
        [DataMember(Name = "enableRealTimeUpdate", EmitDefaultValue = false)]
        public bool? EnableRealTimeUpdate { get; set; }

        /// <summary>
        /// The merchant account identifier, with which you want to process the transaction.
        /// </summary>
        /// <value>The merchant account identifier, with which you want to process the transaction.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// The combination of a language code and a country code to specify the language to be used in the payment.
        /// </summary>
        /// <value>The combination of a language code and a country code to specify the language to be used in the payment.</value>
        [DataMember(Name = "shopperLocale", EmitDefaultValue = false)]
        public string ShopperLocale { get; set; }

        /// <summary>
        /// The shopper&#x27;s reference to uniquely identify this shopper (e.g. user ID or account ID). &gt; This field is required for recurring payments.
        /// </summary>
        /// <value>The shopper&#x27;s reference to uniquely identify this shopper (e.g. user ID or account ID). &gt; This field is required for recurring payments.</value>
        [DataMember(Name = "shopperReference", EmitDefaultValue = false)]
        public string ShopperReference { get; set; }

        /// <summary>
        /// If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation.
        /// </summary>
        /// <value>If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation.</value>
        [DataMember(Name = "threeDSAuthenticationOnly", EmitDefaultValue = false)]
        public bool? ThreeDSAuthenticationOnly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethodsRequest {\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  AllowedPaymentMethods: ").Append(AllowedPaymentMethods).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BlockedPaymentMethods: ").Append(BlockedPaymentMethods).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  EnableRealTimeUpdate: ").Append(EnableRealTimeUpdate).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  ShopperLocale: ").Append(ShopperLocale).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
            sb.Append("  ThreeDSAuthenticationOnly: ").Append(ThreeDSAuthenticationOnly).Append("\n");
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
            return this.Equals(input as PaymentMethodsRequest);
        }

        /// <summary>
        /// Returns true if PaymentMethodsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodsRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AdditionalData == input.AdditionalData ||
                    this.AdditionalData != null &&
                    input.AdditionalData != null &&
                    this.AdditionalData.Equals(input.AdditionalData)
                ) &&
                (
                    this.AllowedPaymentMethods == input.AllowedPaymentMethods ||
                    this.AllowedPaymentMethods != null &&
                    input.AllowedPaymentMethods != null &&
                    this.AllowedPaymentMethods.SequenceEqual(input.AllowedPaymentMethods)
                ) &&
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) &&
                (
                    this.BlockedPaymentMethods == input.BlockedPaymentMethods ||
                    this.BlockedPaymentMethods != null &&
                    input.BlockedPaymentMethods != null &&
                    this.BlockedPaymentMethods.SequenceEqual(input.BlockedPaymentMethods)
                ) &&
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) &&
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) &&
                (
                    this.EnableRealTimeUpdate == input.EnableRealTimeUpdate ||
                    (this.EnableRealTimeUpdate != null &&
                    this.EnableRealTimeUpdate.Equals(input.EnableRealTimeUpdate))
                ) &&
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) &&
                (
                    this.ShopperLocale == input.ShopperLocale ||
                    (this.ShopperLocale != null &&
                    this.ShopperLocale.Equals(input.ShopperLocale))
                ) &&
                (
                    this.ShopperReference == input.ShopperReference ||
                    (this.ShopperReference != null &&
                    this.ShopperReference.Equals(input.ShopperReference))
                ) &&
                (
                    this.ThreeDSAuthenticationOnly == input.ThreeDSAuthenticationOnly ||
                    (this.ThreeDSAuthenticationOnly != null &&
                    this.ThreeDSAuthenticationOnly.Equals(input.ThreeDSAuthenticationOnly))
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
                if (this.AdditionalData != null)
                    hashCode = hashCode * 59 + this.AdditionalData.GetHashCode();
                if (this.AllowedPaymentMethods != null)
                    hashCode = hashCode * 59 + this.AllowedPaymentMethods.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.BlockedPaymentMethods != null)
                    hashCode = hashCode * 59 + this.BlockedPaymentMethods.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.EnableRealTimeUpdate != null)
                    hashCode = hashCode * 59 + this.EnableRealTimeUpdate.GetHashCode();
                if (this.MerchantAccount != null)
                    hashCode = hashCode * 59 + this.MerchantAccount.GetHashCode();
                if (this.ShopperLocale != null)
                    hashCode = hashCode * 59 + this.ShopperLocale.GetHashCode();
                if (this.ShopperReference != null)
                    hashCode = hashCode * 59 + this.ShopperReference.GetHashCode();
                if (this.ThreeDSAuthenticationOnly != null)
                    hashCode = hashCode * 59 + this.ThreeDSAuthenticationOnly.GetHashCode();
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
            yield break;
        }
    }

}
