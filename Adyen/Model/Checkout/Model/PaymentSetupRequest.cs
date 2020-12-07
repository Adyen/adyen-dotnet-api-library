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
  public class PaymentSetupRequest {
    /// <summary>
    /// This field contains additional data, which may be required for a particular payment request.  The `additionalData` object consists of entries, each of which includes the key and value.
    /// </summary>
    /// <value>This field contains additional data, which may be required for a particular payment request.  The `additionalData` object consists of entries, each of which includes the key and value.</value>
    [DataMember(Name="additionalData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additionalData")]
    public AnyOfPaymentSetupRequestAdditionalData AdditionalData { get; set; }

    /// <summary>
    /// List of payments methods to be presented to the shopper. To refer to payment methods, use their `paymentMethod.type`from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: `\"allowedPaymentMethods\":[\"ideal\",\"giropay\"]`
    /// </summary>
    /// <value>List of payments methods to be presented to the shopper. To refer to payment methods, use their `paymentMethod.type`from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: `\"allowedPaymentMethods\":[\"ideal\",\"giropay\"]`</value>
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
    /// List of payments methods to be hidden from the shopper. To refer to payment methods, use their `paymentMethod.type`from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: `\"blockedPaymentMethods\":[\"ideal\",\"giropay\"]`
    /// </summary>
    /// <value>List of payments methods to be hidden from the shopper. To refer to payment methods, use their `paymentMethod.type`from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: `\"blockedPaymentMethods\":[\"ideal\",\"giropay\"]`</value>
    [DataMember(Name="blockedPaymentMethods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blockedPaymentMethods")]
    public List<string> BlockedPaymentMethods { get; set; }

    /// <summary>
    /// The delay between the authorisation and scheduled auto-capture, specified in hours.
    /// </summary>
    /// <value>The delay between the authorisation and scheduled auto-capture, specified in hours.</value>
    [DataMember(Name="captureDelayHours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "captureDelayHours")]
    public int? CaptureDelayHours { get; set; }

    /// <summary>
    /// The platform where a payment transaction takes place. This field is optional for filtering out payment methods that are only available on specific platforms. If this value is not set, then we will try to infer it from the `sdkVersion` or `token`.  Possible values: * iOS * Android * Web
    /// </summary>
    /// <value>The platform where a payment transaction takes place. This field is optional for filtering out payment methods that are only available on specific platforms. If this value is not set, then we will try to infer it from the `sdkVersion` or `token`.  Possible values: * iOS * Android * Web</value>
    [DataMember(Name="channel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "channel")]
    public string Channel { get; set; }

    /// <summary>
    /// Gets or Sets Company
    /// </summary>
    [DataMember(Name="company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company")]
    public Company Company { get; set; }

    /// <summary>
    /// Gets or Sets Configuration
    /// </summary>
    [DataMember(Name="configuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configuration")]
    public Configuration Configuration { get; set; }

    /// <summary>
    /// Conversion ID that corresponds to the Id generated for tracking user payment journey.
    /// </summary>
    /// <value>Conversion ID that corresponds to the Id generated for tracking user payment journey.</value>
    [DataMember(Name="conversionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conversionId")]
    public string ConversionId { get; set; }

    /// <summary>
    /// The shopper country.  Format: [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) Example: NL or DE
    /// </summary>
    /// <value>The shopper country.  Format: [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) Example: NL or DE</value>
    [DataMember(Name="countryCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "countryCode")]
    public string CountryCode { get; set; }

    /// <summary>
    /// The shopper's date of birth.  Format [ISO-8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DD
    /// </summary>
    /// <value>The shopper's date of birth.  Format [ISO-8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DD</value>
    [DataMember(Name="dateOfBirth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateOfBirth")]
    public DateTime? DateOfBirth { get; set; }

    /// <summary>
    /// Gets or Sets DccQuote
    /// </summary>
    [DataMember(Name="dccQuote", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dccQuote")]
    public ForexQuote DccQuote { get; set; }

    /// <summary>
    /// Gets or Sets DeliveryAddress
    /// </summary>
    [DataMember(Name="deliveryAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveryAddress")]
    public Address DeliveryAddress { get; set; }

    /// <summary>
    /// The date and time the purchased goods should be delivered.  Format [ISO 8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DDThh:mm:ss.sssTZD  Example: 2017-07-17T13:42:40.428+01:00
    /// </summary>
    /// <value>The date and time the purchased goods should be delivered.  Format [ISO 8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DDThh:mm:ss.sssTZD  Example: 2017-07-17T13:42:40.428+01:00</value>
    [DataMember(Name="deliveryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveryDate")]
    public DateTime? DeliveryDate { get; set; }

    /// <summary>
    /// When true and `shopperReference` is provided, the shopper will be asked if the payment details should be stored for future one-click payments.
    /// </summary>
    /// <value>When true and `shopperReference` is provided, the shopper will be asked if the payment details should be stored for future one-click payments.</value>
    [DataMember(Name="enableOneClick", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enableOneClick")]
    public bool? EnableOneClick { get; set; }

    /// <summary>
    /// When true and `shopperReference` is provided, the payment details will be tokenized for payouts.
    /// </summary>
    /// <value>When true and `shopperReference` is provided, the payment details will be tokenized for payouts.</value>
    [DataMember(Name="enablePayOut", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enablePayOut")]
    public bool? EnablePayOut { get; set; }

    /// <summary>
    /// When true and `shopperReference` is provided, the payment details will be tokenized for recurring payments.
    /// </summary>
    /// <value>When true and `shopperReference` is provided, the payment details will be tokenized for recurring payments.</value>
    [DataMember(Name="enableRecurring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enableRecurring")]
    public bool? EnableRecurring { get; set; }

    /// <summary>
    /// The type of the entity the payment is processed for.
    /// </summary>
    /// <value>The type of the entity the payment is processed for.</value>
    [DataMember(Name="entityType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entityType")]
    public string EntityType { get; set; }

    /// <summary>
    /// An integer value that is added to the normal fraud score. The value can be either positive or negative.
    /// </summary>
    /// <value>An integer value that is added to the normal fraud score. The value can be either positive or negative.</value>
    [DataMember(Name="fraudOffset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fraudOffset")]
    public int? FraudOffset { get; set; }

    /// <summary>
    /// Gets or Sets Installments
    /// </summary>
    [DataMember(Name="installments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installments")]
    public Installments Installments { get; set; }

    /// <summary>
    /// Price and product information about the purchased items, to be included on the invoice sent to the shopper. > This field is required for 3x 4x Oney, Affirm, AfterPay, Klarna, RatePay, and Zip.
    /// </summary>
    /// <value>Price and product information about the purchased items, to be included on the invoice sent to the shopper. > This field is required for 3x 4x Oney, Affirm, AfterPay, Klarna, RatePay, and Zip.</value>
    [DataMember(Name="lineItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineItems")]
    public List<LineItem> LineItems { get; set; }

    /// <summary>
    /// The [merchant category code](https://en.wikipedia.org/wiki/Merchant_category_code) (MCC) is a four-digit number, which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant.
    /// </summary>
    /// <value>The [merchant category code](https://en.wikipedia.org/wiki/Merchant_category_code) (MCC) is a four-digit number, which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant.</value>
    [DataMember(Name="mcc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mcc")]
    public string Mcc { get; set; }

    /// <summary>
    /// The merchant account identifier, with which you want to process the transaction.
    /// </summary>
    /// <value>The merchant account identifier, with which you want to process the transaction.</value>
    [DataMember(Name="merchantAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantAccount")]
    public string MerchantAccount { get; set; }

    /// <summary>
    /// This reference allows linking multiple transactions to each other for reporting purposes (i.e. order auth-rate). The reference should be unique per billing cycle. The same merchant order reference should never be reused after the first authorised attempt. If used, this field should be supplied for all incoming authorisations. > We strongly recommend you send the `merchantOrderReference` value to benefit from linking payment requests when authorisation retries take place. In addition, we recommend you provide `retry.orderAttemptNumber`, `retry.chainAttemptNumber`, and `retry.skipRetry` values in `PaymentRequest.additionalData`.
    /// </summary>
    /// <value>This reference allows linking multiple transactions to each other for reporting purposes (i.e. order auth-rate). The reference should be unique per billing cycle. The same merchant order reference should never be reused after the first authorised attempt. If used, this field should be supplied for all incoming authorisations. > We strongly recommend you send the `merchantOrderReference` value to benefit from linking payment requests when authorisation retries take place. In addition, we recommend you provide `retry.orderAttemptNumber`, `retry.chainAttemptNumber`, and `retry.skipRetry` values in `PaymentRequest.additionalData`.</value>
    [DataMember(Name="merchantOrderReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantOrderReference")]
    public string MerchantOrderReference { get; set; }

    /// <summary>
    /// Metadata consists of entries, each of which includes a key and a value. Limitations: Maximum 20 key-value pairs per request. When exceeding, the \"177\" error occurs: \"Metadata size exceeds limit\".
    /// </summary>
    /// <value>Metadata consists of entries, each of which includes a key and a value. Limitations: Maximum 20 key-value pairs per request. When exceeding, the \"177\" error occurs: \"Metadata size exceeds limit\".</value>
    [DataMember(Name="metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metadata")]
    public Dictionary<string, string> Metadata { get; set; }

    /// <summary>
    /// When you are doing multiple partial (gift card) payments, this is the `pspReference` of the first payment. We use this to link the multiple payments to each other. As your own reference for linking multiple payments, use the `merchantOrderReference`instead.
    /// </summary>
    /// <value>When you are doing multiple partial (gift card) payments, this is the `pspReference` of the first payment. We use this to link the multiple payments to each other. As your own reference for linking multiple payments, use the `merchantOrderReference`instead.</value>
    [DataMember(Name="orderReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderReference")]
    public string OrderReference { get; set; }

    /// <summary>
    /// Required for the Web integration.  Set this parameter to the origin URL of the page that you are loading the SDK from.
    /// </summary>
    /// <value>Required for the Web integration.  Set this parameter to the origin URL of the page that you are loading the SDK from.</value>
    [DataMember(Name="origin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin")]
    public string Origin { get; set; }

    /// <summary>
    /// Date after which no further authorisations shall be performed. Only for 3D Secure 2.
    /// </summary>
    /// <value>Date after which no further authorisations shall be performed. Only for 3D Secure 2.</value>
    [DataMember(Name="recurringExpiry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurringExpiry")]
    public string RecurringExpiry { get; set; }

    /// <summary>
    /// Minimum number of days between authorisations. Only for 3D Secure 2.
    /// </summary>
    /// <value>Minimum number of days between authorisations. Only for 3D Secure 2.</value>
    [DataMember(Name="recurringFrequency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurringFrequency")]
    public string RecurringFrequency { get; set; }

    /// <summary>
    /// The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement. If you need to provide multiple references for a transaction, separate them with hyphens (\"-\"). Maximum length: 80 characters.
    /// </summary>
    /// <value>The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement. If you need to provide multiple references for a transaction, separate them with hyphens (\"-\"). Maximum length: 80 characters.</value>
    [DataMember(Name="reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reference")]
    public string Reference { get; set; }

    /// <summary>
    /// The URL to return to in case of a redirection. The format depends on the channel. This URL can have a maximum of 1024 characters. * For web, include the protocol `http://` or `https://`. You can also include your own additional query parameters, for example, shopper ID or order reference number. Example: `https://your-company.com/checkout?shopperOrder=12xy` * For iOS, use the custom URL for your app. To know more about setting custom URL schemes, refer to the [Apple Developer documentation](https://developer.apple.com/documentation/uikit/inter-process_communication/allowing_apps_and_websites_to_link_to_your_content/defining_a_custom_url_scheme_for_your_app). Example: `my-app://` * For Android, use a custom URL handled by an Activity on your app. You can configure it with an [intent filter](https://developer.android.com/guide/components/intents-filters). Example: `my-app://your.package.name`
    /// </summary>
    /// <value>The URL to return to in case of a redirection. The format depends on the channel. This URL can have a maximum of 1024 characters. * For web, include the protocol `http://` or `https://`. You can also include your own additional query parameters, for example, shopper ID or order reference number. Example: `https://your-company.com/checkout?shopperOrder=12xy` * For iOS, use the custom URL for your app. To know more about setting custom URL schemes, refer to the [Apple Developer documentation](https://developer.apple.com/documentation/uikit/inter-process_communication/allowing_apps_and_websites_to_link_to_your_content/defining_a_custom_url_scheme_for_your_app). Example: `my-app://` * For Android, use a custom URL handled by an Activity on your app. You can configure it with an [intent filter](https://developer.android.com/guide/components/intents-filters). Example: `my-app://your.package.name`</value>
    [DataMember(Name="returnUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "returnUrl")]
    public string ReturnUrl { get; set; }

    /// <summary>
    /// Gets or Sets RiskData
    /// </summary>
    [DataMember(Name="riskData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "riskData")]
    public RiskData RiskData { get; set; }

    /// <summary>
    /// The version of the SDK you are using (for Web SDK integrations only).
    /// </summary>
    /// <value>The version of the SDK you are using (for Web SDK integrations only).</value>
    [DataMember(Name="sdkVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sdkVersion")]
    public string SdkVersion { get; set; }

    /// <summary>
    /// The date and time until when the session remains valid, in [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.  For example: 2020-07-18T15:42:40.428+01:00
    /// </summary>
    /// <value>The date and time until when the session remains valid, in [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.  For example: 2020-07-18T15:42:40.428+01:00</value>
    [DataMember(Name="sessionValidity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sessionValidity")]
    public string SessionValidity { get; set; }

    /// <summary>
    /// The shopper's email address. We recommend that you provide this data, as it is used in velocity fraud checks. > For 3D Secure 2 transactions, schemes require `shopperEmail` for all browser-based and mobile implementations.
    /// </summary>
    /// <value>The shopper's email address. We recommend that you provide this data, as it is used in velocity fraud checks. > For 3D Secure 2 transactions, schemes require `shopperEmail` for all browser-based and mobile implementations.</value>
    [DataMember(Name="shopperEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperEmail")]
    public string ShopperEmail { get; set; }

    /// <summary>
    /// The shopper's IP address. In general, we recommend that you provide this data, as it is used in a number of risk checks (for instance, number of payment attempts or location-based checks). > For 3D Secure 2 transactions, schemes require `shopperIP` for all browser-based implementations. This field is also mandatory for some merchants depending on your business model. For more information, [contact Support](https://support.adyen.com/hc/en-us/requests/new).
    /// </summary>
    /// <value>The shopper's IP address. In general, we recommend that you provide this data, as it is used in a number of risk checks (for instance, number of payment attempts or location-based checks). > For 3D Secure 2 transactions, schemes require `shopperIP` for all browser-based implementations. This field is also mandatory for some merchants depending on your business model. For more information, [contact Support](https://support.adyen.com/hc/en-us/requests/new).</value>
    [DataMember(Name="shopperIP", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperIP")]
    public string ShopperIP { get; set; }

    /// <summary>
    /// Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * `Ecommerce` - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * `ContAuth` - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * `Moto` - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * `POS` - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.
    /// </summary>
    /// <value>Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * `Ecommerce` - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * `ContAuth` - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * `Moto` - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * `POS` - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.</value>
    [DataMember(Name="shopperInteraction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperInteraction")]
    public string ShopperInteraction { get; set; }

    /// <summary>
    /// The combination of a language code and a country code to specify the language to be used in the payment.
    /// </summary>
    /// <value>The combination of a language code and a country code to specify the language to be used in the payment.</value>
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
    /// Your reference to uniquely identify this shopper (for example, user ID or account ID). Minimum length: 3 characters. > This field is required for recurring payments.
    /// </summary>
    /// <value>Your reference to uniquely identify this shopper (for example, user ID or account ID). Minimum length: 3 characters. > This field is required for recurring payments.</value>
    [DataMember(Name="shopperReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperReference")]
    public string ShopperReference { get; set; }

    /// <summary>
    /// The text to be shown on the shopper's bank statement. To enable this field, contact our [Support Team](https://support.adyen.com/hc/en-us/requests/new).  We recommend sending a maximum of 25 characters, otherwise banks might truncate the string.
    /// </summary>
    /// <value>The text to be shown on the shopper's bank statement. To enable this field, contact our [Support Team](https://support.adyen.com/hc/en-us/requests/new).  We recommend sending a maximum of 25 characters, otherwise banks might truncate the string.</value>
    [DataMember(Name="shopperStatement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperStatement")]
    public string ShopperStatement { get; set; }

    /// <summary>
    /// The shopper's social security number.
    /// </summary>
    /// <value>The shopper's social security number.</value>
    [DataMember(Name="socialSecurityNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "socialSecurityNumber")]
    public string SocialSecurityNumber { get; set; }

    /// <summary>
    /// Information on how the payment should be split between accounts when using [Adyen for Platforms](https://docs.adyen.com/platforms/processing-payments#providing-split-information).
    /// </summary>
    /// <value>Information on how the payment should be split between accounts when using [Adyen for Platforms](https://docs.adyen.com/platforms/processing-payments#providing-split-information).</value>
    [DataMember(Name="splits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "splits")]
    public List<Split> Splits { get; set; }

    /// <summary>
    /// When true and `shopperReference` is provided, the payment details will be stored.
    /// </summary>
    /// <value>When true and `shopperReference` is provided, the payment details will be stored.</value>
    [DataMember(Name="storePaymentMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storePaymentMethod")]
    public bool? StorePaymentMethod { get; set; }

    /// <summary>
    /// The shopper's telephone number.
    /// </summary>
    /// <value>The shopper's telephone number.</value>
    [DataMember(Name="telephoneNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "telephoneNumber")]
    public string TelephoneNumber { get; set; }

    /// <summary>
    /// If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation.
    /// </summary>
    /// <value>If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation.</value>
    [DataMember(Name="threeDSAuthenticationOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "threeDSAuthenticationOnly")]
    public bool? ThreeDSAuthenticationOnly { get; set; }

    /// <summary>
    /// The token obtained when initializing the SDK.  > This parameter is required for iOS and Android; not required for Web.
    /// </summary>
    /// <value>The token obtained when initializing the SDK.  > This parameter is required for iOS and Android; not required for Web.</value>
    [DataMember(Name="token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token")]
    public string Token { get; set; }

    /// <summary>
    /// Set to true if the payment should be routed to a trusted MID.
    /// </summary>
    /// <value>Set to true if the payment should be routed to a trusted MID.</value>
    [DataMember(Name="trustedShopper", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trustedShopper")]
    public bool? TrustedShopper { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentSetupRequest {\n");
      sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
      sb.Append("  AllowedPaymentMethods: ").Append(AllowedPaymentMethods).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  ApplicationInfo: ").Append(ApplicationInfo).Append("\n");
      sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
      sb.Append("  BlockedPaymentMethods: ").Append(BlockedPaymentMethods).Append("\n");
      sb.Append("  CaptureDelayHours: ").Append(CaptureDelayHours).Append("\n");
      sb.Append("  Channel: ").Append(Channel).Append("\n");
      sb.Append("  Company: ").Append(Company).Append("\n");
      sb.Append("  Configuration: ").Append(Configuration).Append("\n");
      sb.Append("  ConversionId: ").Append(ConversionId).Append("\n");
      sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
      sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
      sb.Append("  DccQuote: ").Append(DccQuote).Append("\n");
      sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
      sb.Append("  DeliveryDate: ").Append(DeliveryDate).Append("\n");
      sb.Append("  EnableOneClick: ").Append(EnableOneClick).Append("\n");
      sb.Append("  EnablePayOut: ").Append(EnablePayOut).Append("\n");
      sb.Append("  EnableRecurring: ").Append(EnableRecurring).Append("\n");
      sb.Append("  EntityType: ").Append(EntityType).Append("\n");
      sb.Append("  FraudOffset: ").Append(FraudOffset).Append("\n");
      sb.Append("  Installments: ").Append(Installments).Append("\n");
      sb.Append("  LineItems: ").Append(LineItems).Append("\n");
      sb.Append("  Mcc: ").Append(Mcc).Append("\n");
      sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
      sb.Append("  MerchantOrderReference: ").Append(MerchantOrderReference).Append("\n");
      sb.Append("  Metadata: ").Append(Metadata).Append("\n");
      sb.Append("  OrderReference: ").Append(OrderReference).Append("\n");
      sb.Append("  Origin: ").Append(Origin).Append("\n");
      sb.Append("  RecurringExpiry: ").Append(RecurringExpiry).Append("\n");
      sb.Append("  RecurringFrequency: ").Append(RecurringFrequency).Append("\n");
      sb.Append("  Reference: ").Append(Reference).Append("\n");
      sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
      sb.Append("  RiskData: ").Append(RiskData).Append("\n");
      sb.Append("  SdkVersion: ").Append(SdkVersion).Append("\n");
      sb.Append("  SessionValidity: ").Append(SessionValidity).Append("\n");
      sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
      sb.Append("  ShopperIP: ").Append(ShopperIP).Append("\n");
      sb.Append("  ShopperInteraction: ").Append(ShopperInteraction).Append("\n");
      sb.Append("  ShopperLocale: ").Append(ShopperLocale).Append("\n");
      sb.Append("  ShopperName: ").Append(ShopperName).Append("\n");
      sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
      sb.Append("  ShopperStatement: ").Append(ShopperStatement).Append("\n");
      sb.Append("  SocialSecurityNumber: ").Append(SocialSecurityNumber).Append("\n");
      sb.Append("  Splits: ").Append(Splits).Append("\n");
      sb.Append("  StorePaymentMethod: ").Append(StorePaymentMethod).Append("\n");
      sb.Append("  TelephoneNumber: ").Append(TelephoneNumber).Append("\n");
      sb.Append("  ThreeDSAuthenticationOnly: ").Append(ThreeDSAuthenticationOnly).Append("\n");
      sb.Append("  Token: ").Append(Token).Append("\n");
      sb.Append("  TrustedShopper: ").Append(TrustedShopper).Append("\n");
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
