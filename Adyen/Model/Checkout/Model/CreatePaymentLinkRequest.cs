using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class CreatePaymentLinkRequest {
    /// <summary>
    /// List of payments methods to be presented to the shopper. To refer to payment methods, use their `paymentMethod.type` from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: `\"allowedPaymentMethods\":[\"ideal\",\"giropay\"]`
    /// </summary>
    /// <value>List of payments methods to be presented to the shopper. To refer to payment methods, use their `paymentMethod.type` from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: `\"allowedPaymentMethods\":[\"ideal\",\"giropay\"]`</value>
    [DataMember(Name="allowedPaymentMethods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowedPaymentMethods")]
    public List<string> AllowedPaymentMethods { get; set; }

    /// <summary>
    /// Gets or Sets Amount
    /// </summary>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public Amount Amount { get; set; }

    /// <summary>
    /// Gets or Sets ApplicationInfo
    /// </summary>
    [DataMember(Name="applicationInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applicationInfo")]
    public ApplicationInfo ApplicationInfo { get; set; }

    /// <summary>
    /// Gets or Sets BillingAddress
    /// </summary>
    [DataMember(Name="billingAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingAddress")]
    public Address BillingAddress { get; set; }

    /// <summary>
    /// List of payments methods to be hidden from the shopper. To refer to payment methods, use their `paymentMethod.type` from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: `\"blockedPaymentMethods\":[\"ideal\",\"giropay\"]`
    /// </summary>
    /// <value>List of payments methods to be hidden from the shopper. To refer to payment methods, use their `paymentMethod.type` from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: `\"blockedPaymentMethods\":[\"ideal\",\"giropay\"]`</value>
    [DataMember(Name="blockedPaymentMethods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blockedPaymentMethods")]
    public List<string> BlockedPaymentMethods { get; set; }

    /// <summary>
    /// The shopper's two-letter country code.
    /// </summary>
    /// <value>The shopper's two-letter country code.</value>
    [DataMember(Name="countryCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "countryCode")]
    public string CountryCode { get; set; }

    /// <summary>
    /// The date and time the purchased goods should be delivered.
    /// </summary>
    /// <value>The date and time the purchased goods should be delivered.</value>
    [DataMember(Name="deliverAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliverAt")]
    public DateTime? DeliverAt { get; set; }

    /// <summary>
    /// Gets or Sets DeliveryAddress
    /// </summary>
    [DataMember(Name="deliveryAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveryAddress")]
    public Address DeliveryAddress { get; set; }

    /// <summary>
    /// A short description visible on the payment page. Maximum length: 280 characters.
    /// </summary>
    /// <value>A short description visible on the payment page. Maximum length: 280 characters.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The date that the payment link expires, in ISO 8601 format. For example `2019-11-23T12:25:28Z`, or `2020-05-27T20:25:28+08:00`. Maximum expiry date should be 30 days from when the payment link is created. If not provided, the default expiry is set to 24 hours after the payment link is created.
    /// </summary>
    /// <value>The date that the payment link expires, in ISO 8601 format. For example `2019-11-23T12:25:28Z`, or `2020-05-27T20:25:28+08:00`. Maximum expiry date should be 30 days from when the payment link is created. If not provided, the default expiry is set to 24 hours after the payment link is created.</value>
    [DataMember(Name="expiresAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiresAt")]
    public string ExpiresAt { get; set; }

    /// <summary>
    /// Price and product information about the purchased items, to be included on the invoice sent to the shopper. This parameter is required for open invoice (_buy now, pay later_) payment methods such AfterPay, Klarna, RatePay, and Zip.
    /// </summary>
    /// <value>Price and product information about the purchased items, to be included on the invoice sent to the shopper. This parameter is required for open invoice (_buy now, pay later_) payment methods such AfterPay, Klarna, RatePay, and Zip.</value>
    [DataMember(Name="lineItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineItems")]
    public List<LineItem> LineItems { get; set; }

    /// <summary>
    /// The merchant account identifier for which the payment link is created.
    /// </summary>
    /// <value>The merchant account identifier for which the payment link is created.</value>
    [DataMember(Name="merchantAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantAccount")]
    public string MerchantAccount { get; set; }

    /// <summary>
    /// This reference allows linking multiple transactions to each other for reporting purposes (for example, order auth-rate). The reference should be unique per billing cycle.
    /// </summary>
    /// <value>This reference allows linking multiple transactions to each other for reporting purposes (for example, order auth-rate). The reference should be unique per billing cycle.</value>
    [DataMember(Name="merchantOrderReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantOrderReference")]
    public string MerchantOrderReference { get; set; }

    /// <summary>
    /// Metadata consists of entries, each of which includes a key and a value. Limitations: * Maximum 20 key-value pairs per request. When exceeding, the \"177\" error occurs: \"Metadata size exceeds limit\" * Maximum 20 characters per key. When exceeding, the \"178\" error occurs: \"Metadata key size exceeds limit\" * A key cannot have the name `checkout.linkId`. Whatever value is present under that key is going to be replaced by the real link id
    /// </summary>
    /// <value>Metadata consists of entries, each of which includes a key and a value. Limitations: * Maximum 20 key-value pairs per request. When exceeding, the \"177\" error occurs: \"Metadata size exceeds limit\" * Maximum 20 characters per key. When exceeding, the \"178\" error occurs: \"Metadata key size exceeds limit\" * A key cannot have the name `checkout.linkId`. Whatever value is present under that key is going to be replaced by the real link id</value>
    [DataMember(Name="metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metadata")]
    public Dictionary<string, string> Metadata { get; set; }

    /// <summary>
    /// Defines a recurring payment type. Allowed values: * `Subscription` – A transaction for a fixed or variable amount, which follows a fixed schedule. * `CardOnFile` – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * `UnscheduledCardOnFile` – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or has variable amounts. For example, automatic top-ups when a cardholder's balance drops below a certain amount. 
    /// </summary>
    /// <value>Defines a recurring payment type. Allowed values: * `Subscription` – A transaction for a fixed or variable amount, which follows a fixed schedule. * `CardOnFile` – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * `UnscheduledCardOnFile` – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or has variable amounts. For example, automatic top-ups when a cardholder's balance drops below a certain amount. </value>
    [DataMember(Name="recurringProcessingModel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurringProcessingModel")]
    public string RecurringProcessingModel { get; set; }

    /// <summary>
    /// A reference that is used to uniquely identify the payment in future communications about the payment status.
    /// </summary>
    /// <value>A reference that is used to uniquely identify the payment in future communications about the payment status.</value>
    [DataMember(Name="reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reference")]
    public string Reference { get; set; }

    /// <summary>
    /// Website URL used for redirection after payment is completed. If provided, a **Continue** button will be shown on the payment page. If shoppers select the button, they are redirected to the specified URL.
    /// </summary>
    /// <value>Website URL used for redirection after payment is completed. If provided, a **Continue** button will be shown on the payment page. If shoppers select the button, they are redirected to the specified URL.</value>
    [DataMember(Name="returnUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "returnUrl")]
    public string ReturnUrl { get; set; }

    /// <summary>
    /// Indicates whether the payment link can be reused for multiple payments. If not provided, this defaults to **false** which means the link can be used for one successful payment only.
    /// </summary>
    /// <value>Indicates whether the payment link can be reused for multiple payments. If not provided, this defaults to **false** which means the link can be used for one successful payment only.</value>
    [DataMember(Name="reusable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reusable")]
    public bool? Reusable { get; set; }

    /// <summary>
    /// Gets or Sets RiskData
    /// </summary>
    [DataMember(Name="riskData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "riskData")]
    public RiskData RiskData { get; set; }

    /// <summary>
    /// The shopper's email address.
    /// </summary>
    /// <value>The shopper's email address.</value>
    [DataMember(Name="shopperEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperEmail")]
    public string ShopperEmail { get; set; }

    /// <summary>
    /// The language to be used in the payment page, specified by a combination of a language and country code. For example, `en-US`.  For a list of shopper locales that Pay by Link supports, refer to [Language and localization](https://docs.adyen.com/checkout/pay-by-link#language-and-localization).
    /// </summary>
    /// <value>The language to be used in the payment page, specified by a combination of a language and country code. For example, `en-US`.  For a list of shopper locales that Pay by Link supports, refer to [Language and localization](https://docs.adyen.com/checkout/pay-by-link#language-and-localization).</value>
    [DataMember(Name="shopperLocale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperLocale")]
    public string ShopperLocale { get; set; }

    /// <summary>
    /// Gets or Sets ShopperName
    /// </summary>
    [DataMember(Name="shopperName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperName")]
    public Name ShopperName { get; set; }

    /// <summary>
    /// A unique identifier for the shopper (for example, user ID or account ID).
    /// </summary>
    /// <value>A unique identifier for the shopper (for example, user ID or account ID).</value>
    [DataMember(Name="shopperReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperReference")]
    public string ShopperReference { get; set; }

    /// <summary>
    /// Information on how the payment should be split between accounts when using [Adyen for Platforms](https://docs.adyen.com/platforms/processing-payments#providing-split-information).
    /// </summary>
    /// <value>Information on how the payment should be split between accounts when using [Adyen for Platforms](https://docs.adyen.com/platforms/processing-payments#providing-split-information).</value>
    [DataMember(Name="splits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "splits")]
    public List<Split> Splits { get; set; }

    /// <summary>
    /// The physical store, for which this payment is processed.
    /// </summary>
    /// <value>The physical store, for which this payment is processed.</value>
    [DataMember(Name="store", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "store")]
    public string Store { get; set; }

    /// <summary>
    /// When this is set to **true** and the `shopperReference` is provided, the payment details will be stored.
    /// </summary>
    /// <value>When this is set to **true** and the `shopperReference` is provided, the payment details will be stored.</value>
    [DataMember(Name="storePaymentMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storePaymentMethod")]
    public bool? StorePaymentMethod { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreatePaymentLinkRequest {\n");
      sb.Append("  AllowedPaymentMethods: ").Append(AllowedPaymentMethods).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  ApplicationInfo: ").Append(ApplicationInfo).Append("\n");
      sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
      sb.Append("  BlockedPaymentMethods: ").Append(BlockedPaymentMethods).Append("\n");
      sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
      sb.Append("  DeliverAt: ").Append(DeliverAt).Append("\n");
      sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
      sb.Append("  LineItems: ").Append(LineItems).Append("\n");
      sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
      sb.Append("  MerchantOrderReference: ").Append(MerchantOrderReference).Append("\n");
      sb.Append("  Metadata: ").Append(Metadata).Append("\n");
      sb.Append("  RecurringProcessingModel: ").Append(RecurringProcessingModel).Append("\n");
      sb.Append("  Reference: ").Append(Reference).Append("\n");
      sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
      sb.Append("  Reusable: ").Append(Reusable).Append("\n");
      sb.Append("  RiskData: ").Append(RiskData).Append("\n");
      sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
      sb.Append("  ShopperLocale: ").Append(ShopperLocale).Append("\n");
      sb.Append("  ShopperName: ").Append(ShopperName).Append("\n");
      sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
      sb.Append("  Splits: ").Append(Splits).Append("\n");
      sb.Append("  Store: ").Append(Store).Append("\n");
      sb.Append("  StorePaymentMethod: ").Append(StorePaymentMethod).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
