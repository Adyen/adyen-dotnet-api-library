using Adyen.Model.ApplicationInformation;
using Adyen.Model.Checkout;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using ApplicationInfo = Adyen.Model.ApplicationInformation.ApplicationInfo;

namespace Adyen.Model.Payout
{
    /// <summary>
    /// PayoutRequest
    /// </summary>
    [DataContract]
    public class PayoutRequest
    {
        /// <summary>
        /// Gets or Sets AccountInfo
        /// </summary>
        [DataMember(Name = "accountInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "accountInfo")]
        public AccountInfo AccountInfo { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalAmount
        /// </summary>
        [DataMember(Name = "additionalAmount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additionalAmount")]
        public Amount AdditionalAmount { get; set; }

        /// <summary>
        /// This field contains additional data, which may be required for a particular payment request.  The `additionalData` object consists of entries, each of which includes the key and value. For more information on possible key-value pairs, refer to the [additionalData section](https://docs.adyen.com/api-reference/payments-api/paymentrequest/paymentrequest-additionaldata).
        /// </summary>
        /// <value>This field contains additional data, which may be required for a particular payment request.  The `additionalData` object consists of entries, each of which includes the key and value. For more information on possible key-value pairs, refer to the [additionalData section](https://docs.adyen.com/api-reference/payments-api/paymentrequest/paymentrequest-additionaldata).</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additionalData")]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amount")]
        public Amount Amount { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationInfo
        /// </summary>
        [DataMember(Name = "applicationInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "applicationInfo")]
        public ApplicationInfo ApplicationInfo { get; set; }

        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name = "bankAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bankAccount")]
        public BankAccount BankAccount { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "billingAddress")]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Gets or Sets BrowserInfo
        /// </summary>
        [DataMember(Name = "browserInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "browserInfo")]
        public BrowserInfo BrowserInfo { get; set; }

        /// <summary>
        /// The delay between the authorisation and scheduled auto-capture, specified in hours.
        /// </summary>
        /// <value>The delay between the authorisation and scheduled auto-capture, specified in hours.</value>
        [DataMember(Name = "captureDelayHours", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "captureDelayHours")]
        public int? CaptureDelayHours { get; set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name = "card", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "card")]
        public Card Card { get; set; }

        /// <summary>
        /// The shopper's date of birth.  Format [ISO-8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DD
        /// </summary>
        /// <value>The shopper's date of birth.  Format [ISO-8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DD</value>
        [DataMember(Name = "dateOfBirth", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dateOfBirth")]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets DccQuote
        /// </summary>
        [DataMember(Name = "dccQuote", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dccQuote")]
        public ForexQuote DccQuote { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryAddress
        /// </summary>
        [DataMember(Name = "deliveryAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "deliveryAddress")]
        public Address DeliveryAddress { get; set; }

        /// <summary>
        /// The date and time the purchased goods should be delivered.  Format [ISO 8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DDThh:mm:ss.sssTZD  Example: 2017-07-17T13:42:40.428+01:00
        /// </summary>
        /// <value>The date and time the purchased goods should be delivered.  Format [ISO 8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DDThh:mm:ss.sssTZD  Example: 2017-07-17T13:42:40.428+01:00</value>
        [DataMember(Name = "deliveryDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "deliveryDate")]
        public DateTime? DeliveryDate { get; set; }

        /// <summary>
        /// A string containing the shopper's device fingerprint. For more information, refer to [Device fingerprinting](https://docs.adyen.com/risk-management/device-fingerprinting).
        /// </summary>
        /// <value>A string containing the shopper's device fingerprint. For more information, refer to [Device fingerprinting](https://docs.adyen.com/risk-management/device-fingerprinting).</value>
        [DataMember(Name = "deviceFingerprint", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "deviceFingerprint")]
        public string DeviceFingerprint { get; set; }

        /// <summary>
        /// The type of the entity the payment is processed for.
        /// </summary>
        /// <value>The type of the entity the payment is processed for.</value>
        [DataMember(Name = "entityType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "entityType")]
        public string EntityType { get; set; }

        /// <summary>
        /// An integer value that is added to the normal fraud score. The value can be either positive or negative.
        /// </summary>
        /// <value>An integer value that is added to the normal fraud score. The value can be either positive or negative.</value>
        [DataMember(Name = "fraudOffset", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fraudOffset")]
        public int? FraudOffset { get; set; }

        /// <summary>
        /// Gets or Sets FundSource
        /// </summary>
        [DataMember(Name = "fundSource", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fundSource")]
        public FundSource FundSource { get; set; }

        /// <summary>
        /// Gets or Sets Installments
        /// </summary>
        [DataMember(Name = "installments", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "installments")]
        public Installments Installments { get; set; }

        /// <summary>
        /// The [merchant category code](https://en.wikipedia.org/wiki/Merchant_category_code) (MCC) is a four-digit number, which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant.
        /// </summary>
        /// <value>The [merchant category code](https://en.wikipedia.org/wiki/Merchant_category_code) (MCC) is a four-digit number, which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant.</value>
        [DataMember(Name = "mcc", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// The merchant account identifier, with which you want to process the transaction.
        /// </summary>
        /// <value>The merchant account identifier, with which you want to process the transaction.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// This reference allows linking multiple transactions to each other for reporting purposes (i.e. order auth-rate). The reference should be unique per billing cycle. The same merchant order reference should never be reused after the first authorised attempt. If used, this field should be supplied for all incoming authorisations. > We strongly recommend you send the `merchantOrderReference` value to benefit from linking payment requests when authorisation retries take place. In addition, we recommend you provide `retry.orderAttemptNumber`, `retry.chainAttemptNumber`, and `retry.skipRetry` values in `PaymentRequest.additionalData`.
        /// </summary>
        /// <value>This reference allows linking multiple transactions to each other for reporting purposes (i.e. order auth-rate). The reference should be unique per billing cycle. The same merchant order reference should never be reused after the first authorised attempt. If used, this field should be supplied for all incoming authorisations. > We strongly recommend you send the `merchantOrderReference` value to benefit from linking payment requests when authorisation retries take place. In addition, we recommend you provide `retry.orderAttemptNumber`, `retry.chainAttemptNumber`, and `retry.skipRetry` values in `PaymentRequest.additionalData`.</value>
        [DataMember(Name = "merchantOrderReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantOrderReference")]
        public string MerchantOrderReference { get; set; }

        /// <summary>
        /// Gets or Sets MerchantRiskIndicator
        /// </summary>
        [DataMember(Name = "merchantRiskIndicator", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantRiskIndicator")]
        public MerchantRiskIndicator MerchantRiskIndicator { get; set; }

        /// <summary>
        /// Metadata consists of entries, each of which includes a key and a value. Limitations: Maximum 20 key-value pairs per request. When exceeding, the \"177\" error occurs: \"Metadata size exceeds limit\".
        /// </summary>
        /// <value>Metadata consists of entries, each of which includes a key and a value. Limitations: Maximum 20 key-value pairs per request. When exceeding, the \"177\" error occurs: \"Metadata size exceeds limit\".</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "metadata")]
        public Object Metadata { get; set; }

        /// <summary>
        /// Gets or Sets MpiData
        /// </summary>
        [DataMember(Name = "mpiData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mpiData")]
        public ThreeDSecureData MpiData { get; set; }

        /// <summary>
        /// The two-character country code of the shopper's nationality.
        /// </summary>
        /// <value>The two-character country code of the shopper's nationality.</value>
        [DataMember(Name = "nationality", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// When you are doing multiple partial (gift card) payments, this is the `pspReference` of the first payment. We use this to link the multiple payments to each other. As your own reference for linking multiple payments, use the `merchantOrderReference`instead.
        /// </summary>
        /// <value>When you are doing multiple partial (gift card) payments, this is the `pspReference` of the first payment. We use this to link the multiple payments to each other. As your own reference for linking multiple payments, use the `merchantOrderReference`instead.</value>
        [DataMember(Name = "orderReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "orderReference")]
        public string OrderReference { get; set; }

        /// <summary>
        /// Gets or Sets Recurring
        /// </summary>
        [DataMember(Name = "recurring", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "recurring")]
        public Recurring.Recurring Recurring { get; set; }

        /// <summary>
        /// Defines a recurring payment type. Allowed values: * `Subscription` – A transaction for a fixed or variable amount, which follows a fixed schedule. * `CardOnFile` – Card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * `UnscheduledCardOnFile` – A transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder's balance drops below a certain amount. 
        /// </summary>
        /// <value>Defines a recurring payment type. Allowed values: * `Subscription` – A transaction for a fixed or variable amount, which follows a fixed schedule. * `CardOnFile` – Card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * `UnscheduledCardOnFile` – A transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder's balance drops below a certain amount. </value>
        [DataMember(Name = "recurringProcessingModel", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "recurringProcessingModel")]
        public string RecurringProcessingModel { get; set; }

        /// <summary>
        /// The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement. If you need to provide multiple references for a transaction, separate them with hyphens (\"-\"). Maximum length: 80 characters.
        /// </summary>
        /// <value>The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement. If you need to provide multiple references for a transaction, separate them with hyphens (\"-\"). Maximum length: 80 characters.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Some payment methods require defining a value for this field to specify how to process the transaction.  For the Bancontact payment method, it can be set to: * `maestro` (default), to be processed like a Maestro card, or * `bcmc`, to be processed like a Bancontact card.
        /// </summary>
        /// <value>Some payment methods require defining a value for this field to specify how to process the transaction.  For the Bancontact payment method, it can be set to: * `maestro` (default), to be processed like a Maestro card, or * `bcmc`, to be processed like a Bancontact card.</value>
        [DataMember(Name = "selectedBrand", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "selectedBrand")]
        public string SelectedBrand { get; set; }

        /// <summary>
        /// The `recurringDetailReference` you want to use for this payment. The value `LATEST` can be used to select the most recently stored recurring detail.
        /// </summary>
        /// <value>The `recurringDetailReference` you want to use for this payment. The value `LATEST` can be used to select the most recently stored recurring detail.</value>
        [DataMember(Name = "selectedRecurringDetailReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "selectedRecurringDetailReference")]
        public string SelectedRecurringDetailReference { get; set; }

        /// <summary>
        /// A session ID used to identify a payment session.
        /// </summary>
        /// <value>A session ID used to identify a payment session.</value>
        [DataMember(Name = "sessionId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sessionId")]
        public string SessionId { get; set; }

        /// <summary>
        /// The shopper's email address. We recommend that you provide this data, as it is used in velocity fraud checks. > For 3D Secure 2 transactions, schemes require the `shopperEmail` for both `deviceChannel` **browser** and **app**.
        /// </summary>
        /// <value>The shopper's email address. We recommend that you provide this data, as it is used in velocity fraud checks. > For 3D Secure 2 transactions, schemes require the `shopperEmail` for both `deviceChannel` **browser** and **app**.</value>
        [DataMember(Name = "shopperEmail", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shopperEmail")]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// The shopper's IP address. In general, we recommend that you provide this data, as it is used in a number of risk checks (for instance, number of payment attempts or location-based checks). > Required for 3D Secure 2 transactions. This field is also mandatory for some merchants depending on your business model. For more information, [contact Support](https://support.adyen.com/hc/en-us/requests/new).
        /// </summary>
        /// <value>The shopper's IP address. In general, we recommend that you provide this data, as it is used in a number of risk checks (for instance, number of payment attempts or location-based checks). > Required for 3D Secure 2 transactions. This field is also mandatory for some merchants depending on your business model. For more information, [contact Support](https://support.adyen.com/hc/en-us/requests/new).</value>
        [DataMember(Name = "shopperIP", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shopperIP")]
        public string ShopperIP { get; set; }

        /// <summary>
        /// Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * `Ecommerce` - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * `ContAuth` - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * `Moto` - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * `POS` - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.
        /// </summary>
        /// <value>Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * `Ecommerce` - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * `ContAuth` - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * `Moto` - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * `POS` - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.</value>
        [DataMember(Name = "shopperInteraction", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shopperInteraction")]
        public string ShopperInteraction { get; set; }

        /// <summary>
        /// The combination of a language code and a country code to specify the language to be used in the payment.
        /// </summary>
        /// <value>The combination of a language code and a country code to specify the language to be used in the payment.</value>
        [DataMember(Name = "shopperLocale", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shopperLocale")]
        public string ShopperLocale { get; set; }

        /// <summary>
        /// Gets or Sets ShopperName
        /// </summary>
        [DataMember(Name = "shopperName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shopperName")]
        public Name ShopperName { get; set; }

        /// <summary>
        /// The shopper's reference to uniquely identify this shopper (e.g. user ID or account ID). > This field is required for recurring payments.
        /// </summary>
        /// <value>The shopper's reference to uniquely identify this shopper (e.g. user ID or account ID). > This field is required for recurring payments.</value>
        [DataMember(Name = "shopperReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shopperReference")]
        public string ShopperReference { get; set; }

        /// <summary>
        /// The text to appear on the shopper's bank statement.
        /// </summary>
        /// <value>The text to appear on the shopper's bank statement.</value>
        [DataMember(Name = "shopperStatement", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shopperStatement")]
        public string ShopperStatement { get; set; }

        /// <summary>
        /// The shopper's social security number.
        /// </summary>
        /// <value>The shopper's social security number.</value>
        [DataMember(Name = "socialSecurityNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "socialSecurityNumber")]
        public string SocialSecurityNumber { get; set; }

        /// <summary>
        /// The details of how the payment should be split when distributing a payment to a MarketPay Marketplace and its Accounts.
        /// </summary>
        /// <value>The details of how the payment should be split when distributing a payment to a MarketPay Marketplace and its Accounts.</value>
        [DataMember(Name = "splits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "splits")]
        public List<Split> Splits { get; set; }

        /// <summary>
        /// The physical store, for which this payment is processed.
        /// </summary>
        /// <value>The physical store, for which this payment is processed.</value>
        [DataMember(Name = "store", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "store")]
        public string Store { get; set; }

        /// <summary>
        /// The shopper's telephone number.
        /// </summary>
        /// <value>The shopper's telephone number.</value>
        [DataMember(Name = "telephoneNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "telephoneNumber")]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets ThreeDS2RequestData
        /// </summary>
        [DataMember(Name = "threeDS2RequestData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "threeDS2RequestData")]
        public ThreeDS2RequestData ThreeDS2RequestData { get; set; }

        /// <summary>
        /// If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/checkout/3d-secure/native-3ds2/authentication-only), and not the payment authorisation.
        /// </summary>
        /// <value>If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/checkout/3d-secure/native-3ds2/authentication-only), and not the payment authorisation.</value>
        [DataMember(Name = "threeDSAuthenticationOnly", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "threeDSAuthenticationOnly")]
        public bool? ThreeDSAuthenticationOnly { get; set; }

        /// <summary>
        /// The reference value to aggregate sales totals in reporting. When not specified, the store field is used (if available).
        /// </summary>
        /// <value>The reference value to aggregate sales totals in reporting. When not specified, the store field is used (if available).</value>
        [DataMember(Name = "totalsGroup", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalsGroup")]
        public string TotalsGroup { get; set; }

        /// <summary>
        /// Set to true if the payment should be routed to a trusted MID.
        /// </summary>
        /// <value>Set to true if the payment should be routed to a trusted MID.</value>
        [DataMember(Name = "trustedShopper", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trustedShopper")]
        public bool? TrustedShopper { get; set; }

        public PayoutRequest()
        {
            if (ApplicationInfo == null)
            {
                ApplicationInfo = new ApplicationInfo();
            }
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayoutRequest {\n");
            sb.Append("  AccountInfo: ").Append(AccountInfo).Append("\n");
            sb.Append("  AdditionalAmount: ").Append(AdditionalAmount).Append("\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ApplicationInfo: ").Append(ApplicationInfo).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  BrowserInfo: ").Append(BrowserInfo).Append("\n");
            sb.Append("  CaptureDelayHours: ").Append(CaptureDelayHours).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  DccQuote: ").Append(DccQuote).Append("\n");
            sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
            sb.Append("  DeliveryDate: ").Append(DeliveryDate).Append("\n");
            sb.Append("  DeviceFingerprint: ").Append(DeviceFingerprint).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  FraudOffset: ").Append(FraudOffset).Append("\n");
            sb.Append("  FundSource: ").Append(FundSource).Append("\n");
            sb.Append("  Installments: ").Append(Installments).Append("\n");
            sb.Append("  Mcc: ").Append(Mcc).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  MerchantOrderReference: ").Append(MerchantOrderReference).Append("\n");
            sb.Append("  MerchantRiskIndicator: ").Append(MerchantRiskIndicator).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  MpiData: ").Append(MpiData).Append("\n");
            sb.Append("  Nationality: ").Append(Nationality).Append("\n");
            sb.Append("  OrderReference: ").Append(OrderReference).Append("\n");
            sb.Append("  Recurring: ").Append(Recurring).Append("\n");
            sb.Append("  RecurringProcessingModel: ").Append(RecurringProcessingModel).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  SelectedBrand: ").Append(SelectedBrand).Append("\n");
            sb.Append("  SelectedRecurringDetailReference: ").Append(SelectedRecurringDetailReference).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
            sb.Append("  ShopperIP: ").Append(ShopperIP).Append("\n");
            sb.Append("  ShopperInteraction: ").Append(ShopperInteraction).Append("\n");
            sb.Append("  ShopperLocale: ").Append(ShopperLocale).Append("\n");
            sb.Append("  ShopperName: ").Append(ShopperName).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
            sb.Append("  ShopperStatement: ").Append(ShopperStatement).Append("\n");
            sb.Append("  SocialSecurityNumber: ").Append(SocialSecurityNumber).Append("\n");
            sb.Append("  Splits: ").Append(Splits).Append("\n");
            sb.Append("  Store: ").Append(Store).Append("\n");
            sb.Append("  TelephoneNumber: ").Append(TelephoneNumber).Append("\n");
            sb.Append("  ThreeDS2RequestData: ").Append(ThreeDS2RequestData).Append("\n");
            sb.Append("  ThreeDSAuthenticationOnly: ").Append(ThreeDSAuthenticationOnly).Append("\n");
            sb.Append("  TotalsGroup: ").Append(TotalsGroup).Append("\n");
            sb.Append("  TrustedShopper: ").Append(TrustedShopper).Append("\n");
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