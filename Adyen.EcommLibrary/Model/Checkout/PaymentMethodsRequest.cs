using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Adyen.EcommLibrary.Model.ApplicationInformation;

namespace Adyen.EcommLibrary.Model.Checkout
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
            [EnumMember(Value = "iOS")] IOS = 1,

            /// <summary>
            /// Enum Android for value: Android
            /// </summary>
            [EnumMember(Value = "Android")] Android = 2,

            /// <summary>
            /// Enum Web for value: Web
            /// </summary>
            [EnumMember(Value = "Web")] Web = 3
        }

        /// <summary>
        /// The platform where a payment transaction takes place. This field can be used for filtering out payment methods that are only available on specific platforms. Possible values: * iOS * Android * Web
        /// </summary>
        /// <value>The platform where a payment transaction takes place. This field can be used for filtering out payment methods that are only available on specific platforms. Possible values: * iOS * Android * Web</value>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public ChannelEnum? Channel { get; set; }

        /// <summary>
        /// Defines a recurring payment type. Allowed values: * &#x60;Subscription&#x60; – A transaction for a fixed or variable amount, which follows a fixed schedule. * &#x60;CardOnFile&#x60; – Card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction.
        /// </summary>
        /// <value>Defines a recurring payment type. Allowed values: * &#x60;Subscription&#x60; – A transaction for a fixed or variable amount, which follows a fixed schedule. * &#x60;CardOnFile&#x60; – Card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RecurringProcessingModelEnum
        {
            /// <summary>
            /// Enum CardOnFile for value: CardOnFile
            /// </summary>
            [EnumMember(Value = "CardOnFile")] CardOnFile = 1,

            /// <summary>
            /// Enum Subscription for value: Subscription
            /// </summary>
            [EnumMember(Value = "Subscription")] Subscription = 2
        }

        /// <summary>
        /// Defines a recurring payment type. Allowed values: * &#x60;Subscription&#x60; – A transaction for a fixed or variable amount, which follows a fixed schedule. * &#x60;CardOnFile&#x60; – Card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction.
        /// </summary>
        /// <value>Defines a recurring payment type. Allowed values: * &#x60;Subscription&#x60; – A transaction for a fixed or variable amount, which follows a fixed schedule. * &#x60;CardOnFile&#x60; – Card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction.</value>
        [DataMember(Name = "recurringProcessingModel", EmitDefaultValue = false)]
        public RecurringProcessingModelEnum? RecurringProcessingModel { get; set; }

        /// <summary>
        /// Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * &#x60;Ecommerce&#x60; - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * &#x60;ContAuth&#x60; - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * &#x60;Moto&#x60; - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * &#x60;POS&#x60; - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.
        /// </summary>
        /// <value>Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * &#x60;Ecommerce&#x60; - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * &#x60;ContAuth&#x60; - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * &#x60;Moto&#x60; - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * &#x60;POS&#x60; - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShopperInteractionEnum
        {
            /// <summary>
            /// Enum Ecommerce for value: Ecommerce
            /// </summary>
            [EnumMember(Value = "Ecommerce")] Ecommerce = 1,

            /// <summary>
            /// Enum ContAuth for value: ContAuth
            /// </summary>
            [EnumMember(Value = "ContAuth")] ContAuth = 2,

            /// <summary>
            /// Enum Moto for value: Moto
            /// </summary>
            [EnumMember(Value = "Moto")] Moto = 3,

            /// <summary>
            /// Enum POS for value: POS
            /// </summary>
            [EnumMember(Value = "POS")] POS = 4
        }

        /// <summary>
        /// Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * &#x60;Ecommerce&#x60; - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * &#x60;ContAuth&#x60; - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * &#x60;Moto&#x60; - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * &#x60;POS&#x60; - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.
        /// </summary>
        /// <value>Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * &#x60;Ecommerce&#x60; - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * &#x60;ContAuth&#x60; - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * &#x60;Moto&#x60; - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * &#x60;POS&#x60; - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.</value>
        [DataMember(Name = "shopperInteraction", EmitDefaultValue = false)]
        public ShopperInteractionEnum? ShopperInteraction { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodsRequest" /> class.
        /// </summary>
        [JsonConstructor]
        protected PaymentMethodsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodsRequest" /> class.
        /// </summary>
        /// <param name="AccountInfo">Shopper account information for 3D Secure 2.0..</param>
        /// <param name="AdditionalAmount">If you want a [BIN or card verification](https://docs.adyen.com/developers/payment-methods/cards/bin-data-and-card-verification) request to use a non-zero value, assign this value to &#x60;additionalAmount&#x60; (while the amount must be still set to 0 to trigger BIN or card verification). Required to be in the same currency as the &#x60;amount&#x60;. .</param>
        /// <param name="AdditionalData">This field contains additional data, which may be required for a particular payment request.  The &#x60;additionalData&#x60; object consists of entries, each of which includes the key and value. For more information on possible key-value pairs, refer to the [additionalData section](https://docs.adyen.com/developers/api-reference/payments-api#paymentrequestadditionaldata)..</param>
        /// <param name="AllowedPaymentMethods">List of payments methods to be presented to the shopper. To refer to payment methods, use their &#x60;brandCode&#x60; from [Payment methods overview](https://docs.adyen.com/developers/payment-methods/payment-methods-overview)..</param>
        /// <param name="Amount">The amount information for the transaction. For [BIN or card verification](https://docs.adyen.com/developers/payment-methods/cards/bin-data-and-card-verification) requests, set amount to 0 (zero). (required).</param>
        /// <param name="ApplicationInfo">Application information..</param>
        /// <param name="BillingAddress">The address where to send the invoice..</param>
        /// <param name="BlockedPaymentMethods">List of payments methods to be hidden from the shopper. To refer to payment methods, use their &#x60;brandCode&#x60; from [Payment methods overview](https://docs.adyen.com/developers/payment-methods/payment-methods-overview)..</param>
        /// <param name="BrowserInfo">The shopper&#39;s browser information..</param>
        /// <param name="CaptureDelayHours">The delay between the authorisation and scheduled auto-capture, specified in hours..</param>
        /// <param name="Channel">The platform where a payment transaction takes place. This field can be used for filtering out payment methods that are only available on specific platforms. Possible values: * iOS * Android * Web.</param>
        /// <param name="ConfigId">Configuration ID that corresponds to the config group to use..</param>
        /// <param name="CountryCode">The shopper&#39;s country code..</param>
        /// <param name="DateOfBirth">The shopper&#39;s date of birth.  Format [ISO-8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DD.</param>
        /// <param name="DccQuote">The forex quote as returned in the response of the forex service..</param>
        /// <param name="DeliveryAddress">The address where the purchased goods should be delivered..</param>
        /// <param name="DeliveryDate">The date and time the purchased goods should be delivered.  Format [ISO 8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DDThh:mm:ss.sssTZD  Example: 2017-07-17T13:42:40.428+01:00.</param>
        /// <param name="DeviceFingerprint">A string containing the shopper&#39;s device fingerprint. For more information, refer to [Device fingerprinting](https://docs.adyen.com/developers/risk-management/device-fingerprinting)..</param>
        /// <param name="FraudOffset">An integer value that is added to the normal fraud score. The value can be either positive or negative..</param>
        /// <param name="Installments">Contains installment settings. For more information, refer to [Installments](https://docs.adyen.com/developers/payment-methods/installment-payments)..</param>
        /// <param name="Mcc">The [merchant category code](https://en.wikipedia.org/wiki/Merchant_category_code) (MCC) is a four-digit number, which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant..</param>
        /// <param name="MerchantAccount">The merchant account identifier, with which you want to process the transaction. (required).</param>
        /// <param name="MerchantOrderReference">This reference allows linking multiple transactions to each other. &gt; We strongly recommend you send the &#x60;merchantOrderReference&#x60; value to benefit from linking payment requests when authorisation retries take place. In addition, we recommend you provide &#x60;retry.orderAttemptNumber&#x60;, &#x60;retry.chainAttemptNumber&#x60;, and &#x60;retry.skipRetry&#x60; values in &#x60;PaymentRequest.additionalData&#x60;..</param>
        /// <param name="MerchantRiskIndicator">Additional risk fields for 3D Secure 2.0..</param>
        /// <param name="Metadata">Metadata consists of entries, each of which includes a key and a value. Limitations: Error \&quot;177\&quot;, \&quot;Metadata size exceeds limit\&quot;.</param>
        /// <param name="OrderReference">The order reference to link multiple partial payments..</param>
        /// <param name="Recurring">The recurring settings for the payment. Use this property when you want to enable [recurring payments](https://docs.adyen.com/developers/features/recurring-payments)..</param>
        /// <param name="RecurringProcessingModel">Defines a recurring payment type. Allowed values: * &#x60;Subscription&#x60; – A transaction for a fixed or variable amount, which follows a fixed schedule. * &#x60;CardOnFile&#x60; – Card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction..</param>
        /// <param name="Reference">The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement. If you need to provide multiple references for a transaction, separate them with hyphens (\&quot;-\&quot;). Maximum length: 80 characters. (required).</param>
        /// <param name="SelectedBrand">Some payment methods require defining a value for this field to specify how to process the transaction.  For the Bancontact payment method, it can be set to: * &#x60;maestro&#x60; (default), to be processed like a Maestro card, or * &#x60;bcmc&#x60;, to be processed like a Bancontact card..</param>
        /// <param name="SelectedRecurringDetailReference">The &#x60;recurringDetailReference&#x60; you want to use for this payment. The value &#x60;LATEST&#x60; can be used to select the most recently stored recurring detail..</param>
        /// <param name="SessionId">A session ID used to identify a payment session..</param>
        /// <param name="ShopperEmail">The shopper&#39;s email address. We recommend that you provide this data, as it is used in velocity fraud checks..</param>
        /// <param name="ShopperIP">The shopper&#39;s IP address. We recommend that you provide this data, as it is used in a number of risk checks (for instance, number of payment attempts or location-based checks). &gt; This field is mandatory for some merchants depending on your business model. For more information, [contact Support](https://support.adyen.com/hc/en-us/requests/new)..</param>
        /// <param name="ShopperInteraction">Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * &#x60;Ecommerce&#x60; - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * &#x60;ContAuth&#x60; - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * &#x60;Moto&#x60; - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * &#x60;POS&#x60; - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal..</param>
        /// <param name="ShopperLocale">The combination of a language code and a country code to specify the language to be used in the payment..</param>
        /// <param name="ShopperName">The shopper&#39;s full name and gender (if specified)..</param>
        /// <param name="ShopperReference">The shopper&#39;s reference to uniquely identify this shopper (e.g. user ID or account ID). &gt; This field is required for recurring payments..</param>
        /// <param name="ShopperStatement">The text to appear on the shopper&#39;s bank statement..</param>
        /// <param name="SocialSecurityNumber">The shopper&#39;s social security number..</param>
        /// <param name="Splits">The details of how the payment should be split when distributing a payment to a MarketPay Marketplace and its Accounts..</param>
        /// <param name="Store">The physical store, for which this payment is processed..</param>
        /// <param name="TelephoneNumber">The shopper&#39;s telephone number..</param>
        /// <param name="ThreeDS2RequestData">Request fields for 3D Secure 2.0..</param>
        /// <param name="TotalsGroup">The reference value to aggregate sales totals in reporting. When not specified, the store field is used (if available)..</param>
        /// <param name="TrustedShopper">Set to true if the payment should be routed to a trusted MID..</param>
        public PaymentMethodsRequest(AccountInfo AccountInfo = default(AccountInfo),
            Amount AdditionalAmount = default(Amount),
            Dictionary<string, string> AdditionalData = default(Dictionary<string, string>),
            List<string> AllowedPaymentMethods = default(List<string>), Amount Amount = default(Amount),
            ApplicationInfo ApplicationInfo = default(ApplicationInfo), Address BillingAddress = default(Address),
            List<string> BlockedPaymentMethods = default(List<string>), BrowserInfo BrowserInfo = default(BrowserInfo),
            int? CaptureDelayHours = default(int?), ChannelEnum? Channel = default(ChannelEnum?),
            string ConfigId = default(string), string CountryCode = default(string),
            DateTime? DateOfBirth = default(DateTime?), ForexQuote DccQuote = default(ForexQuote),
            Address DeliveryAddress = default(Address), DateTime? DeliveryDate = default(DateTime?),
            string DeviceFingerprint = default(string), int? FraudOffset = default(int?),
            Installments Installments = default(Installments), string Mcc = default(string),
            string MerchantAccount = default(string), string MerchantOrderReference = default(string),
            MerchantRiskIndicator MerchantRiskIndicator = default(MerchantRiskIndicator),
            Dictionary<string, string> Metadata = default(Dictionary<string, string>),
            string OrderReference = default(string), Recurring Recurring = default(Recurring),
            RecurringProcessingModelEnum? RecurringProcessingModel = default(RecurringProcessingModelEnum?),
            string Reference = default(string), string SelectedBrand = default(string),
            string SelectedRecurringDetailReference = default(string), string SessionId = default(string),
            string ShopperEmail = default(string), string ShopperIP = default(string),
            ShopperInteractionEnum? ShopperInteraction = default(ShopperInteractionEnum?),
            string ShopperLocale = default(string), Name ShopperName = default(Name),
            string ShopperReference = default(string), string ShopperStatement = default(string),
            string SocialSecurityNumber = default(string), List<Split> Splits = default(List<Split>),
            string Store = default(string), string TelephoneNumber = default(string),
            ThreeDS2RequestData ThreeDS2RequestData = default(ThreeDS2RequestData),
            string TotalsGroup = default(string), bool? TrustedShopper = default(bool?))
        {
            // to ensure "MerchantAccount" is required (not null)
            if (MerchantAccount == null)
                throw new InvalidDataException(
                    "MerchantAccount is a required property for PaymentMethodsRequest and cannot be null");
            else
                this.MerchantAccount = MerchantAccount;
            this.AccountInfo = AccountInfo;
            this.AdditionalAmount = AdditionalAmount;
            this.AdditionalData = AdditionalData;
            this.AllowedPaymentMethods = AllowedPaymentMethods;
            this.ApplicationInfo = ApplicationInfo;
            this.BillingAddress = BillingAddress;
            this.BlockedPaymentMethods = BlockedPaymentMethods;
            this.BrowserInfo = BrowserInfo;
            this.CaptureDelayHours = CaptureDelayHours;
            this.Channel = Channel;
            this.ConfigId = ConfigId;
            this.CountryCode = CountryCode;
            this.DateOfBirth = DateOfBirth;
            this.DccQuote = DccQuote;
            this.DeliveryAddress = DeliveryAddress;
            this.DeliveryDate = DeliveryDate;
            this.DeviceFingerprint = DeviceFingerprint;
            this.FraudOffset = FraudOffset;
            this.Installments = Installments;
            this.Mcc = Mcc;
            this.MerchantOrderReference = MerchantOrderReference;
            this.MerchantRiskIndicator = MerchantRiskIndicator;
            this.Metadata = Metadata;
            this.OrderReference = OrderReference;
            this.Recurring = Recurring;
            this.RecurringProcessingModel = RecurringProcessingModel;
            this.SelectedBrand = SelectedBrand;
            this.SelectedRecurringDetailReference = SelectedRecurringDetailReference;
            this.SessionId = SessionId;
            this.ShopperEmail = ShopperEmail;
            this.ShopperIP = ShopperIP;
            this.ShopperInteraction = ShopperInteraction;
            this.ShopperLocale = ShopperLocale;
            this.ShopperName = ShopperName;
            this.ShopperReference = ShopperReference;
            this.ShopperStatement = ShopperStatement;
            this.SocialSecurityNumber = SocialSecurityNumber;
            this.Splits = Splits;
            this.Store = Store;
            this.TelephoneNumber = TelephoneNumber;
            this.ThreeDS2RequestData = ThreeDS2RequestData;
            this.TotalsGroup = TotalsGroup;
            this.TrustedShopper = TrustedShopper;
        }

        /// <summary>
        /// Shopper account information for 3D Secure 2.0.
        /// </summary>
        /// <value>Shopper account information for 3D Secure 2.0.</value>
        [DataMember(Name = "accountInfo", EmitDefaultValue = false)]
        public AccountInfo AccountInfo { get; set; }

        /// <summary>
        /// If you want a [BIN or card verification](https://docs.adyen.com/developers/payment-methods/cards/bin-data-and-card-verification) request to use a non-zero value, assign this value to &#x60;additionalAmount&#x60; (while the amount must be still set to 0 to trigger BIN or card verification). Required to be in the same currency as the &#x60;amount&#x60;. 
        /// </summary>
        /// <value>If you want a [BIN or card verification](https://docs.adyen.com/developers/payment-methods/cards/bin-data-and-card-verification) request to use a non-zero value, assign this value to &#x60;additionalAmount&#x60; (while the amount must be still set to 0 to trigger BIN or card verification). Required to be in the same currency as the &#x60;amount&#x60;. </value>
        [DataMember(Name = "additionalAmount", EmitDefaultValue = false)]
        public Amount AdditionalAmount { get; set; }

        /// <summary>
        /// This field contains additional data, which may be required for a particular payment request.  The &#x60;additionalData&#x60; object consists of entries, each of which includes the key and value. For more information on possible key-value pairs, refer to the [additionalData section](https://docs.adyen.com/developers/api-reference/payments-api#paymentrequestadditionaldata).
        /// </summary>
        /// <value>This field contains additional data, which may be required for a particular payment request.  The &#x60;additionalData&#x60; object consists of entries, each of which includes the key and value. For more information on possible key-value pairs, refer to the [additionalData section](https://docs.adyen.com/developers/api-reference/payments-api#paymentrequestadditionaldata).</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// List of payments methods to be presented to the shopper. To refer to payment methods, use their &#x60;brandCode&#x60; from [Payment methods overview](https://docs.adyen.com/developers/payment-methods/payment-methods-overview).
        /// </summary>
        /// <value>List of payments methods to be presented to the shopper. To refer to payment methods, use their &#x60;brandCode&#x60; from [Payment methods overview](https://docs.adyen.com/developers/payment-methods/payment-methods-overview).</value>
        [DataMember(Name = "allowedPaymentMethods", EmitDefaultValue = false)]
        public List<string> AllowedPaymentMethods { get; set; }

        /// <summary>
        /// The amount information for the transaction. For [BIN or card verification](https://docs.adyen.com/developers/payment-methods/cards/bin-data-and-card-verification) requests, set amount to 0 (zero).
        /// </summary>
        /// <value>The amount information for the transaction. For [BIN or card verification](https://docs.adyen.com/developers/payment-methods/cards/bin-data-and-card-verification) requests, set amount to 0 (zero).</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// Application information.
        /// </summary>
        /// <value>Application information.</value>
        [DataMember(Name = "applicationInfo", EmitDefaultValue = false)]
        public ApplicationInfo ApplicationInfo { get; set; }

        /// <summary>
        /// The address where to send the invoice.
        /// </summary>
        /// <value>The address where to send the invoice.</value>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// List of payments methods to be hidden from the shopper. To refer to payment methods, use their &#x60;brandCode&#x60; from [Payment methods overview](https://docs.adyen.com/developers/payment-methods/payment-methods-overview).
        /// </summary>
        /// <value>List of payments methods to be hidden from the shopper. To refer to payment methods, use their &#x60;brandCode&#x60; from [Payment methods overview](https://docs.adyen.com/developers/payment-methods/payment-methods-overview).</value>
        [DataMember(Name = "blockedPaymentMethods", EmitDefaultValue = false)]
        public List<string> BlockedPaymentMethods { get; set; }

        /// <summary>
        /// The shopper&#39;s browser information.
        /// </summary>
        /// <value>The shopper&#39;s browser information.</value>
        [DataMember(Name = "browserInfo", EmitDefaultValue = false)]
        public BrowserInfo BrowserInfo { get; set; }

        /// <summary>
        /// The delay between the authorisation and scheduled auto-capture, specified in hours.
        /// </summary>
        /// <value>The delay between the authorisation and scheduled auto-capture, specified in hours.</value>
        [DataMember(Name = "captureDelayHours", EmitDefaultValue = false)]
        public int? CaptureDelayHours { get; set; }


        /// <summary>
        /// Configuration ID that corresponds to the config group to use.
        /// </summary>
        /// <value>Configuration ID that corresponds to the config group to use.</value>
        [DataMember(Name = "configId", EmitDefaultValue = false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// The shopper&#39;s country code.
        /// </summary>
        /// <value>The shopper&#39;s country code.</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The shopper&#39;s date of birth.  Format [ISO-8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DD
        /// </summary>
        /// <value>The shopper&#39;s date of birth.  Format [ISO-8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DD</value>
        [DataMember(Name = "dateOfBirth", EmitDefaultValue = false)]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// The forex quote as returned in the response of the forex service.
        /// </summary>
        /// <value>The forex quote as returned in the response of the forex service.</value>
        [DataMember(Name = "dccQuote", EmitDefaultValue = false)]
        public ForexQuote DccQuote { get; set; }

        /// <summary>
        /// The address where the purchased goods should be delivered.
        /// </summary>
        /// <value>The address where the purchased goods should be delivered.</value>
        [DataMember(Name = "deliveryAddress", EmitDefaultValue = false)]
        public Address DeliveryAddress { get; set; }

        /// <summary>
        /// The date and time the purchased goods should be delivered.  Format [ISO 8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DDThh:mm:ss.sssTZD  Example: 2017-07-17T13:42:40.428+01:00
        /// </summary>
        /// <value>The date and time the purchased goods should be delivered.  Format [ISO 8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DDThh:mm:ss.sssTZD  Example: 2017-07-17T13:42:40.428+01:00</value>
        [DataMember(Name = "deliveryDate", EmitDefaultValue = false)]
        public DateTime? DeliveryDate { get; set; }

        /// <summary>
        /// A string containing the shopper&#39;s device fingerprint. For more information, refer to [Device fingerprinting](https://docs.adyen.com/developers/risk-management/device-fingerprinting).
        /// </summary>
        /// <value>A string containing the shopper&#39;s device fingerprint. For more information, refer to [Device fingerprinting](https://docs.adyen.com/developers/risk-management/device-fingerprinting).</value>
        [DataMember(Name = "deviceFingerprint", EmitDefaultValue = false)]
        public string DeviceFingerprint { get; set; }

        /// <summary>
        /// An integer value that is added to the normal fraud score. The value can be either positive or negative.
        /// </summary>
        /// <value>An integer value that is added to the normal fraud score. The value can be either positive or negative.</value>
        [DataMember(Name = "fraudOffset", EmitDefaultValue = false)]
        public int? FraudOffset { get; set; }

        /// <summary>
        /// Contains installment settings. For more information, refer to [Installments](https://docs.adyen.com/developers/payment-methods/installment-payments).
        /// </summary>
        /// <value>Contains installment settings. For more information, refer to [Installments](https://docs.adyen.com/developers/payment-methods/installment-payments).</value>
        [DataMember(Name = "installments", EmitDefaultValue = false)]
        public Installments Installments { get; set; }

        /// <summary>
        /// The [merchant category code](https://en.wikipedia.org/wiki/Merchant_category_code) (MCC) is a four-digit number, which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant.
        /// </summary>
        /// <value>The [merchant category code](https://en.wikipedia.org/wiki/Merchant_category_code) (MCC) is a four-digit number, which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant.</value>
        [DataMember(Name = "mcc", EmitDefaultValue = false)]
        public string Mcc { get; set; }

        /// <summary>
        /// The merchant account identifier, with which you want to process the transaction.
        /// </summary>
        /// <value>The merchant account identifier, with which you want to process the transaction.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// This reference allows linking multiple transactions to each other. &gt; We strongly recommend you send the &#x60;merchantOrderReference&#x60; value to benefit from linking payment requests when authorisation retries take place. In addition, we recommend you provide &#x60;retry.orderAttemptNumber&#x60;, &#x60;retry.chainAttemptNumber&#x60;, and &#x60;retry.skipRetry&#x60; values in &#x60;PaymentRequest.additionalData&#x60;.
        /// </summary>
        /// <value>This reference allows linking multiple transactions to each other. &gt; We strongly recommend you send the &#x60;merchantOrderReference&#x60; value to benefit from linking payment requests when authorisation retries take place. In addition, we recommend you provide &#x60;retry.orderAttemptNumber&#x60;, &#x60;retry.chainAttemptNumber&#x60;, and &#x60;retry.skipRetry&#x60; values in &#x60;PaymentRequest.additionalData&#x60;.</value>
        [DataMember(Name = "merchantOrderReference", EmitDefaultValue = false)]
        public string MerchantOrderReference { get; set; }

        /// <summary>
        /// Additional risk fields for 3D Secure 2.0.
        /// </summary>
        /// <value>Additional risk fields for 3D Secure 2.0.</value>
        [DataMember(Name = "merchantRiskIndicator", EmitDefaultValue = false)]
        public MerchantRiskIndicator MerchantRiskIndicator { get; set; }

        /// <summary>
        /// Metadata consists of entries, each of which includes a key and a value. Limitations: Error \&quot;177\&quot;, \&quot;Metadata size exceeds limit\&quot;
        /// </summary>
        /// <value>Metadata consists of entries, each of which includes a key and a value. Limitations: Error \&quot;177\&quot;, \&quot;Metadata size exceeds limit\&quot;</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The order reference to link multiple partial payments.
        /// </summary>
        /// <value>The order reference to link multiple partial payments.</value>
        [DataMember(Name = "orderReference", EmitDefaultValue = false)]
        public string OrderReference { get; set; }

        /// <summary>
        /// The recurring settings for the payment. Use this property when you want to enable [recurring payments](https://docs.adyen.com/developers/features/recurring-payments).
        /// </summary>
        /// <value>The recurring settings for the payment. Use this property when you want to enable [recurring payments](https://docs.adyen.com/developers/features/recurring-payments).</value>
        [DataMember(Name = "recurring", EmitDefaultValue = false)]
        public Recurring Recurring { get; set; }


        /// <summary>
        /// The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement. If you need to provide multiple references for a transaction, separate them with hyphens (\&quot;-\&quot;). Maximum length: 80 characters.
        /// </summary>
        /// <value>The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement. If you need to provide multiple references for a transaction, separate them with hyphens (\&quot;-\&quot;). Maximum length: 80 characters.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Some payment methods require defining a value for this field to specify how to process the transaction.  For the Bancontact payment method, it can be set to: * &#x60;maestro&#x60; (default), to be processed like a Maestro card, or * &#x60;bcmc&#x60;, to be processed like a Bancontact card.
        /// </summary>
        /// <value>Some payment methods require defining a value for this field to specify how to process the transaction.  For the Bancontact payment method, it can be set to: * &#x60;maestro&#x60; (default), to be processed like a Maestro card, or * &#x60;bcmc&#x60;, to be processed like a Bancontact card.</value>
        [DataMember(Name = "selectedBrand", EmitDefaultValue = false)]
        public string SelectedBrand { get; set; }

        /// <summary>
        /// The &#x60;recurringDetailReference&#x60; you want to use for this payment. The value &#x60;LATEST&#x60; can be used to select the most recently stored recurring detail.
        /// </summary>
        /// <value>The &#x60;recurringDetailReference&#x60; you want to use for this payment. The value &#x60;LATEST&#x60; can be used to select the most recently stored recurring detail.</value>
        [DataMember(Name = "selectedRecurringDetailReference", EmitDefaultValue = false)]
        public string SelectedRecurringDetailReference { get; set; }

        /// <summary>
        /// A session ID used to identify a payment session.
        /// </summary>
        /// <value>A session ID used to identify a payment session.</value>
        [DataMember(Name = "sessionId", EmitDefaultValue = false)]
        public string SessionId { get; set; }

        /// <summary>
        /// The shopper&#39;s email address. We recommend that you provide this data, as it is used in velocity fraud checks.
        /// </summary>
        /// <value>The shopper&#39;s email address. We recommend that you provide this data, as it is used in velocity fraud checks.</value>
        [DataMember(Name = "shopperEmail", EmitDefaultValue = false)]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// The shopper&#39;s IP address. We recommend that you provide this data, as it is used in a number of risk checks (for instance, number of payment attempts or location-based checks). &gt; This field is mandatory for some merchants depending on your business model. For more information, [contact Support](https://support.adyen.com/hc/en-us/requests/new).
        /// </summary>
        /// <value>The shopper&#39;s IP address. We recommend that you provide this data, as it is used in a number of risk checks (for instance, number of payment attempts or location-based checks). &gt; This field is mandatory for some merchants depending on your business model. For more information, [contact Support](https://support.adyen.com/hc/en-us/requests/new).</value>
        [DataMember(Name = "shopperIP", EmitDefaultValue = false)]
        public string ShopperIP { get; set; }


        /// <summary>
        /// The combination of a language code and a country code to specify the language to be used in the payment.
        /// </summary>
        /// <value>The combination of a language code and a country code to specify the language to be used in the payment.</value>
        [DataMember(Name = "shopperLocale", EmitDefaultValue = false)]
        public string ShopperLocale { get; set; }

        /// <summary>
        /// The shopper&#39;s full name and gender (if specified).
        /// </summary>
        /// <value>The shopper&#39;s full name and gender (if specified).</value>
        [DataMember(Name = "shopperName", EmitDefaultValue = false)]
        public Name ShopperName { get; set; }

        /// <summary>
        /// The shopper&#39;s reference to uniquely identify this shopper (e.g. user ID or account ID). &gt; This field is required for recurring payments.
        /// </summary>
        /// <value>The shopper&#39;s reference to uniquely identify this shopper (e.g. user ID or account ID). &gt; This field is required for recurring payments.</value>
        [DataMember(Name = "shopperReference", EmitDefaultValue = false)]
        public string ShopperReference { get; set; }

        /// <summary>
        /// The text to appear on the shopper&#39;s bank statement.
        /// </summary>
        /// <value>The text to appear on the shopper&#39;s bank statement.</value>
        [DataMember(Name = "shopperStatement", EmitDefaultValue = false)]
        public string ShopperStatement { get; set; }

        /// <summary>
        /// The shopper&#39;s social security number.
        /// </summary>
        /// <value>The shopper&#39;s social security number.</value>
        [DataMember(Name = "socialSecurityNumber", EmitDefaultValue = false)]
        public string SocialSecurityNumber { get; set; }

        /// <summary>
        /// The details of how the payment should be split when distributing a payment to a MarketPay Marketplace and its Accounts.
        /// </summary>
        /// <value>The details of how the payment should be split when distributing a payment to a MarketPay Marketplace and its Accounts.</value>
        [DataMember(Name = "splits", EmitDefaultValue = false)]
        public List<Split> Splits { get; set; }

        /// <summary>
        /// The physical store, for which this payment is processed.
        /// </summary>
        /// <value>The physical store, for which this payment is processed.</value>
        [DataMember(Name = "store", EmitDefaultValue = false)]
        public string Store { get; set; }

        /// <summary>
        /// The shopper&#39;s telephone number.
        /// </summary>
        /// <value>The shopper&#39;s telephone number.</value>
        [DataMember(Name = "telephoneNumber", EmitDefaultValue = false)]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// Request fields for 3D Secure 2.0.
        /// </summary>
        /// <value>Request fields for 3D Secure 2.0.</value>
        [DataMember(Name = "threeDS2RequestData", EmitDefaultValue = false)]
        public ThreeDS2RequestData ThreeDS2RequestData { get; set; }

        /// <summary>
        /// The reference value to aggregate sales totals in reporting. When not specified, the store field is used (if available).
        /// </summary>
        /// <value>The reference value to aggregate sales totals in reporting. When not specified, the store field is used (if available).</value>
        [DataMember(Name = "totalsGroup", EmitDefaultValue = false)]
        public string TotalsGroup { get; set; }

        /// <summary>
        /// Set to true if the payment should be routed to a trusted MID.
        /// </summary>
        /// <value>Set to true if the payment should be routed to a trusted MID.</value>
        [DataMember(Name = "trustedShopper", EmitDefaultValue = false)]
        public bool? TrustedShopper { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethodsRequest {\n");
            sb.Append("  AccountInfo: ").Append(AccountInfo).Append("\n");
            sb.Append("  AdditionalAmount: ").Append(AdditionalAmount).Append("\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  AllowedPaymentMethods: ").Append(AllowedPaymentMethods).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ApplicationInfo: ").Append(ApplicationInfo).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  BlockedPaymentMethods: ").Append(BlockedPaymentMethods).Append("\n");
            sb.Append("  BrowserInfo: ").Append(BrowserInfo).Append("\n");
            sb.Append("  CaptureDelayHours: ").Append(CaptureDelayHours).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  ConfigId: ").Append(ConfigId).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  DccQuote: ").Append(DccQuote).Append("\n");
            sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
            sb.Append("  DeliveryDate: ").Append(DeliveryDate).Append("\n");
            sb.Append("  DeviceFingerprint: ").Append(DeviceFingerprint).Append("\n");
            sb.Append("  FraudOffset: ").Append(FraudOffset).Append("\n");
            sb.Append("  Installments: ").Append(Installments).Append("\n");
            sb.Append("  Mcc: ").Append(Mcc).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  MerchantOrderReference: ").Append(MerchantOrderReference).Append("\n");
            sb.Append("  MerchantRiskIndicator: ").Append(MerchantRiskIndicator).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            sb.Append("  TotalsGroup: ").Append(TotalsGroup).Append("\n");
            sb.Append("  TrustedShopper: ").Append(TrustedShopper).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return Equals(input as PaymentMethodsRequest);
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
                    AccountInfo == input.AccountInfo ||
                    AccountInfo != null &&
                    AccountInfo.Equals(input.AccountInfo)
                ) &&
                (
                    AdditionalAmount == input.AdditionalAmount ||
                    AdditionalAmount != null &&
                    AdditionalAmount.Equals(input.AdditionalAmount)
                ) &&
                (
                    AdditionalData == input.AdditionalData ||
                    AdditionalData != null &&
                    AdditionalData.SequenceEqual(input.AdditionalData)
                ) &&
                (
                    AllowedPaymentMethods == input.AllowedPaymentMethods ||
                    AllowedPaymentMethods != null &&
                    AllowedPaymentMethods.SequenceEqual(input.AllowedPaymentMethods)
                ) &&
                (
                    Amount == input.Amount ||
                    Amount != null &&
                    Amount.Equals(input.Amount)
                ) &&
                (
                    ApplicationInfo == input.ApplicationInfo ||
                    ApplicationInfo != null &&
                    ApplicationInfo.Equals(input.ApplicationInfo)
                ) &&
                (
                    BillingAddress == input.BillingAddress ||
                    BillingAddress != null &&
                    BillingAddress.Equals(input.BillingAddress)
                ) &&
                (
                    BlockedPaymentMethods == input.BlockedPaymentMethods ||
                    BlockedPaymentMethods != null &&
                    BlockedPaymentMethods.SequenceEqual(input.BlockedPaymentMethods)
                ) &&
                (
                    BrowserInfo == input.BrowserInfo ||
                    BrowserInfo != null &&
                    BrowserInfo.Equals(input.BrowserInfo)
                ) &&
                (
                    CaptureDelayHours == input.CaptureDelayHours ||
                    CaptureDelayHours != null &&
                    CaptureDelayHours.Equals(input.CaptureDelayHours)
                ) &&
                (
                    Channel == input.Channel ||
                    Channel != null &&
                    Channel.Equals(input.Channel)
                ) &&
                (
                    ConfigId == input.ConfigId ||
                    ConfigId != null &&
                    ConfigId.Equals(input.ConfigId)
                ) &&
                (
                    CountryCode == input.CountryCode ||
                    CountryCode != null &&
                    CountryCode.Equals(input.CountryCode)
                ) &&
                (
                    DateOfBirth == input.DateOfBirth ||
                    DateOfBirth != null &&
                    DateOfBirth.Equals(input.DateOfBirth)
                ) &&
                (
                    DccQuote == input.DccQuote ||
                    DccQuote != null &&
                    DccQuote.Equals(input.DccQuote)
                ) &&
                (
                    DeliveryAddress == input.DeliveryAddress ||
                    DeliveryAddress != null &&
                    DeliveryAddress.Equals(input.DeliveryAddress)
                ) &&
                (
                    DeliveryDate == input.DeliveryDate ||
                    DeliveryDate != null &&
                    DeliveryDate.Equals(input.DeliveryDate)
                ) &&
                (
                    DeviceFingerprint == input.DeviceFingerprint ||
                    DeviceFingerprint != null &&
                    DeviceFingerprint.Equals(input.DeviceFingerprint)
                ) &&
                (
                    FraudOffset == input.FraudOffset ||
                    FraudOffset != null &&
                    FraudOffset.Equals(input.FraudOffset)
                ) &&
                (
                    Installments == input.Installments ||
                    Installments != null &&
                    Installments.Equals(input.Installments)
                ) &&
                (
                    Mcc == input.Mcc ||
                    Mcc != null &&
                    Mcc.Equals(input.Mcc)
                ) &&
                (
                    MerchantAccount == input.MerchantAccount ||
                    MerchantAccount != null &&
                    MerchantAccount.Equals(input.MerchantAccount)
                ) &&
                (
                    MerchantOrderReference == input.MerchantOrderReference ||
                    MerchantOrderReference != null &&
                    MerchantOrderReference.Equals(input.MerchantOrderReference)
                ) &&
                (
                    MerchantRiskIndicator == input.MerchantRiskIndicator ||
                    MerchantRiskIndicator != null &&
                    MerchantRiskIndicator.Equals(input.MerchantRiskIndicator)
                ) &&
                (
                    Metadata == input.Metadata ||
                    Metadata != null &&
                    Metadata.SequenceEqual(input.Metadata)
                ) &&
                (
                    OrderReference == input.OrderReference ||
                    OrderReference != null &&
                    OrderReference.Equals(input.OrderReference)
                ) &&
                (
                    Recurring == input.Recurring ||
                    Recurring != null &&
                    Recurring.Equals(input.Recurring)
                ) &&
                (
                    RecurringProcessingModel == input.RecurringProcessingModel ||
                    RecurringProcessingModel != null &&
                    RecurringProcessingModel.Equals(input.RecurringProcessingModel)
                ) &&
                (
                    Reference == input.Reference ||
                    Reference != null &&
                    Reference.Equals(input.Reference)
                ) &&
                (
                    SelectedBrand == input.SelectedBrand ||
                    SelectedBrand != null &&
                    SelectedBrand.Equals(input.SelectedBrand)
                ) &&
                (
                    SelectedRecurringDetailReference == input.SelectedRecurringDetailReference ||
                    SelectedRecurringDetailReference != null &&
                    SelectedRecurringDetailReference.Equals(input.SelectedRecurringDetailReference)
                ) &&
                (
                    SessionId == input.SessionId ||
                    SessionId != null &&
                    SessionId.Equals(input.SessionId)
                ) &&
                (
                    ShopperEmail == input.ShopperEmail ||
                    ShopperEmail != null &&
                    ShopperEmail.Equals(input.ShopperEmail)
                ) &&
                (
                    ShopperIP == input.ShopperIP ||
                    ShopperIP != null &&
                    ShopperIP.Equals(input.ShopperIP)
                ) &&
                (
                    ShopperInteraction == input.ShopperInteraction ||
                    ShopperInteraction != null &&
                    ShopperInteraction.Equals(input.ShopperInteraction)
                ) &&
                (
                    ShopperLocale == input.ShopperLocale ||
                    ShopperLocale != null &&
                    ShopperLocale.Equals(input.ShopperLocale)
                ) &&
                (
                    ShopperName == input.ShopperName ||
                    ShopperName != null &&
                    ShopperName.Equals(input.ShopperName)
                ) &&
                (
                    ShopperReference == input.ShopperReference ||
                    ShopperReference != null &&
                    ShopperReference.Equals(input.ShopperReference)
                ) &&
                (
                    ShopperStatement == input.ShopperStatement ||
                    ShopperStatement != null &&
                    ShopperStatement.Equals(input.ShopperStatement)
                ) &&
                (
                    SocialSecurityNumber == input.SocialSecurityNumber ||
                    SocialSecurityNumber != null &&
                    SocialSecurityNumber.Equals(input.SocialSecurityNumber)
                ) &&
                (
                    Splits == input.Splits ||
                    Splits != null &&
                    Splits.SequenceEqual(input.Splits)
                ) &&
                (
                    Store == input.Store ||
                    Store != null &&
                    Store.Equals(input.Store)
                ) &&
                (
                    TelephoneNumber == input.TelephoneNumber ||
                    TelephoneNumber != null &&
                    TelephoneNumber.Equals(input.TelephoneNumber)
                ) &&
                (
                    ThreeDS2RequestData == input.ThreeDS2RequestData ||
                    ThreeDS2RequestData != null &&
                    ThreeDS2RequestData.Equals(input.ThreeDS2RequestData)
                ) &&
                (
                    TotalsGroup == input.TotalsGroup ||
                    TotalsGroup != null &&
                    TotalsGroup.Equals(input.TotalsGroup)
                ) &&
                (
                    TrustedShopper == input.TrustedShopper ||
                    TrustedShopper != null &&
                    TrustedShopper.Equals(input.TrustedShopper)
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
                var hashCode = 41;
                if (AccountInfo != null)
                    hashCode = hashCode * 59 + AccountInfo.GetHashCode();
                if (AdditionalAmount != null)
                    hashCode = hashCode * 59 + AdditionalAmount.GetHashCode();
                if (AdditionalData != null)
                    hashCode = hashCode * 59 + AdditionalData.GetHashCode();
                if (AllowedPaymentMethods != null)
                    hashCode = hashCode * 59 + AllowedPaymentMethods.GetHashCode();
                if (Amount != null)
                    hashCode = hashCode * 59 + Amount.GetHashCode();
                if (ApplicationInfo != null)
                    hashCode = hashCode * 59 + ApplicationInfo.GetHashCode();
                if (BillingAddress != null)
                    hashCode = hashCode * 59 + BillingAddress.GetHashCode();
                if (BlockedPaymentMethods != null)
                    hashCode = hashCode * 59 + BlockedPaymentMethods.GetHashCode();
                if (BrowserInfo != null)
                    hashCode = hashCode * 59 + BrowserInfo.GetHashCode();
                if (CaptureDelayHours != null)
                    hashCode = hashCode * 59 + CaptureDelayHours.GetHashCode();
                if (Channel != null)
                    hashCode = hashCode * 59 + Channel.GetHashCode();
                if (ConfigId != null)
                    hashCode = hashCode * 59 + ConfigId.GetHashCode();
                if (CountryCode != null)
                    hashCode = hashCode * 59 + CountryCode.GetHashCode();
                if (DateOfBirth != null)
                    hashCode = hashCode * 59 + DateOfBirth.GetHashCode();
                if (DccQuote != null)
                    hashCode = hashCode * 59 + DccQuote.GetHashCode();
                if (DeliveryAddress != null)
                    hashCode = hashCode * 59 + DeliveryAddress.GetHashCode();
                if (DeliveryDate != null)
                    hashCode = hashCode * 59 + DeliveryDate.GetHashCode();
                if (DeviceFingerprint != null)
                    hashCode = hashCode * 59 + DeviceFingerprint.GetHashCode();
                if (FraudOffset != null)
                    hashCode = hashCode * 59 + FraudOffset.GetHashCode();
                if (Installments != null)
                    hashCode = hashCode * 59 + Installments.GetHashCode();
                if (Mcc != null)
                    hashCode = hashCode * 59 + Mcc.GetHashCode();
                if (MerchantAccount != null)
                    hashCode = hashCode * 59 + MerchantAccount.GetHashCode();
                if (MerchantOrderReference != null)
                    hashCode = hashCode * 59 + MerchantOrderReference.GetHashCode();
                if (MerchantRiskIndicator != null)
                    hashCode = hashCode * 59 + MerchantRiskIndicator.GetHashCode();
                if (Metadata != null)
                    hashCode = hashCode * 59 + Metadata.GetHashCode();
                if (OrderReference != null)
                    hashCode = hashCode * 59 + OrderReference.GetHashCode();
                if (Recurring != null)
                    hashCode = hashCode * 59 + Recurring.GetHashCode();
                if (RecurringProcessingModel != null)
                    hashCode = hashCode * 59 + RecurringProcessingModel.GetHashCode();
                if (Reference != null)
                    hashCode = hashCode * 59 + Reference.GetHashCode();
                if (SelectedBrand != null)
                    hashCode = hashCode * 59 + SelectedBrand.GetHashCode();
                if (SelectedRecurringDetailReference != null)
                    hashCode = hashCode * 59 + SelectedRecurringDetailReference.GetHashCode();
                if (SessionId != null)
                    hashCode = hashCode * 59 + SessionId.GetHashCode();
                if (ShopperEmail != null)
                    hashCode = hashCode * 59 + ShopperEmail.GetHashCode();
                if (ShopperIP != null)
                    hashCode = hashCode * 59 + ShopperIP.GetHashCode();
                if (ShopperInteraction != null)
                    hashCode = hashCode * 59 + ShopperInteraction.GetHashCode();
                if (ShopperLocale != null)
                    hashCode = hashCode * 59 + ShopperLocale.GetHashCode();
                if (ShopperName != null)
                    hashCode = hashCode * 59 + ShopperName.GetHashCode();
                if (ShopperReference != null)
                    hashCode = hashCode * 59 + ShopperReference.GetHashCode();
                if (ShopperStatement != null)
                    hashCode = hashCode * 59 + ShopperStatement.GetHashCode();
                if (SocialSecurityNumber != null)
                    hashCode = hashCode * 59 + SocialSecurityNumber.GetHashCode();
                if (Splits != null)
                    hashCode = hashCode * 59 + Splits.GetHashCode();
                if (Store != null)
                    hashCode = hashCode * 59 + Store.GetHashCode();
                if (TelephoneNumber != null)
                    hashCode = hashCode * 59 + TelephoneNumber.GetHashCode();
                if (ThreeDS2RequestData != null)
                    hashCode = hashCode * 59 + ThreeDS2RequestData.GetHashCode();
                if (TotalsGroup != null)
                    hashCode = hashCode * 59 + TotalsGroup.GetHashCode();
                if (TrustedShopper != null)
                    hashCode = hashCode * 59 + TrustedShopper.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Store (string) maxLength
            if (Store != null && Store.Length > 16)
                yield return new ValidationResult("Invalid value for Store, length must be less than 16.",
                    new[] {"Store"});

            // Store (string) minLength
            if (Store != null && Store.Length < 1)
                yield return new ValidationResult("Invalid value for Store, length must be greater than 1.",
                    new[] {"Store"});

            // TotalsGroup (string) maxLength
            if (TotalsGroup != null && TotalsGroup.Length > 16)
                yield return new ValidationResult("Invalid value for TotalsGroup, length must be less than 16.",
                    new[] {"TotalsGroup"});

            // TotalsGroup (string) minLength
            if (TotalsGroup != null && TotalsGroup.Length < 1)
                yield return new ValidationResult("Invalid value for TotalsGroup, length must be greater than 1.",
                    new[] {"TotalsGroup"});

            yield break;
        }
    }
}