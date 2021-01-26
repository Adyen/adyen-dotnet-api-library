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
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class CreatePaymentLinkRequest
    {
        /// <summary>
        /// List of payments methods to be presented to the shopper. To refer to payment methods, use their `brandCode` from [Payment methods overview](https://docs.adyen.com/payment-methods).
        /// </summary>
        /// <value>List of payments methods to be presented to the shopper. To refer to payment methods, use their `brandCode` from [Payment methods overview](https://docs.adyen.com/payment-methods).</value>
        [DataMember(Name = "allowedPaymentMethods", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "allowedPaymentMethods")]
        public List<string> AllowedPaymentMethods { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amount")]
        public Amount Amount { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "billingAddress")]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// List of payments methods to be hidden from the shopper. To refer to payment methods, use their `brandCode` from [Payment methods overview](https://docs.adyen.com/payment-methods).
        /// </summary>
        /// <value>List of payments methods to be hidden from the shopper. To refer to payment methods, use their `brandCode` from [Payment methods overview](https://docs.adyen.com/payment-methods).</value>
        [DataMember(Name = "blockedPaymentMethods", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "blockedPaymentMethods")]
        public List<string> BlockedPaymentMethods { get; set; }

        /// <summary>
        /// The shopper's country code.
        /// </summary>
        /// <value>The shopper's country code.</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryAddress
        /// </summary>
        [DataMember(Name = "deliveryAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "deliveryAddress")]
        public Address DeliveryAddress { get; set; }

        /// <summary>
        /// A short description visible on the Pay By Link page. Maximum length: 280 characters.
        /// </summary>
        /// <value>A short description visible on the Pay By Link page. Maximum length: 280 characters.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The date that the Pay By Link expires; e.g. 2019-03-23T12:25:28Z. If not provided, the default expiry duration is 1 day.
        /// </summary>
        /// <value>The date that the Pay By Link expires; e.g. 2019-03-23T12:25:28Z. If not provided, the default expiry duration is 1 day.</value>
        [DataMember(Name = "expiresAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "expiresAt")]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// The merchant account identifier, with which you want to process the transaction.
        /// </summary>
        /// <value>The merchant account identifier, with which you want to process the transaction.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement. If you need to provide multiple references for a transaction, separate them with hyphens (\"-\"). Maximum length: 80 characters.
        /// </summary>
        /// <value>The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement. If you need to provide multiple references for a transaction, separate them with hyphens (\"-\"). Maximum length: 80 characters.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Merchant URL used for redirection after payment is completed
        /// </summary>
        /// <value>Merchant URL used for redirection after payment is completed</value>
        [DataMember(Name = "returnUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "returnUrl")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The shopper's email address. We recommend that you provide this data, as it is used in velocity fraud checks. > For 3D Secure 2 transactions, schemes require the `shopperEmail` for both `deviceChannel` **browser** and **app**.
        /// </summary>
        /// <value>The shopper's email address. We recommend that you provide this data, as it is used in velocity fraud checks. > For 3D Secure 2 transactions, schemes require the `shopperEmail` for both `deviceChannel` **browser** and **app**.</value>
        [DataMember(Name = "shopperEmail", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shopperEmail")]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// The combination of a language code and a country code to specify the language to be used in the payment.
        /// </summary>
        /// <value>The combination of a language code and a country code to specify the language to be used in the payment.</value>
        [DataMember(Name = "shopperLocale", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shopperLocale")]
        public string ShopperLocale { get; set; }

        /// <summary>
        /// The shopper's reference to uniquely identify this shopper (e.g. user ID or account ID). > This field is required for recurring payments.
        /// </summary>
        /// <value>The shopper's reference to uniquely identify this shopper (e.g. user ID or account ID). > This field is required for recurring payments.</value>
        [DataMember(Name = "shopperReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shopperReference")]
        public string ShopperReference { get; set; }

        /// <summary>
        /// When true and `shopperReference` is provided, the payment details will be stored.
        /// </summary>
        /// <value>When true and `shopperReference` is provided, the payment details will be stored.</value>
        [DataMember(Name = "storePaymentMethod", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "storePaymentMethod")]
        public bool? StorePaymentMethod { get; set; }

        /// <summary>
        /// The physical store, for which this payment is processed.
        /// </summary>
        /// <value>Store</value>
        [DataMember(Name = "store", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "store")]
        public string Store { get; set; }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePaymentLinkRequest {\n");
            sb.Append("  AllowedPaymentMethods: ").Append(AllowedPaymentMethods).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  BlockedPaymentMethods: ").Append(BlockedPaymentMethods).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
            sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
            sb.Append("  ShopperLocale: ").Append(ShopperLocale).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
            sb.Append("  StorePaymentMethod: ").Append(StorePaymentMethod).Append("\n");
            sb.Append("  Store: ").Append(Store).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
