#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Constants;
using Adyen.Model.ApplicationInformation;
using Adyen.Model.Checkout.Details;
using Adyen.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// PaymentRequest
    /// </summary>
    [DataContract]
    public partial class PaymentRequest : IEquatable<PaymentRequest>, IValidatableObject
    {
        /// <summary>
        /// The platform where a payment transaction takes place. This field is optional for filtering out payment methods that are only available on specific platforms. If this value is not set, then we will try to infer it from the &#x60;sdkVersion&#x60; or &#x60;token&#x60;.  Possible values: * iOS * Android * Web
        /// </summary>
        /// <value>The platform where a payment transaction takes place. This field is optional for filtering out payment methods that are only available on specific platforms. If this value is not set, then we will try to infer it from the &#x60;sdkVersion&#x60; or &#x60;token&#x60;.  Possible values: * iOS * Android * Web</value>
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
        /// The platform where a payment transaction takes place. This field is optional for filtering out payment methods that are only available on specific platforms. If this value is not set, then we will try to infer it from the &#x60;sdkVersion&#x60; or &#x60;token&#x60;.  Possible values: * iOS * Android * Web
        /// </summary>
        /// <value>The platform where a payment transaction takes place. This field is optional for filtering out payment methods that are only available on specific platforms. If this value is not set, then we will try to infer it from the &#x60;sdkVersion&#x60; or &#x60;token&#x60;.  Possible values: * iOS * Android * Web</value>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public ChannelEnum? Channel { get; set; }

        /// <summary>
        /// The type of the entity the payment is processed for.
        /// </summary>
        /// <value>The type of the entity the payment is processed for.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EntityTypeEnum
        {
            /// <summary>
            /// Enum NaturalPerson for value: NaturalPerson
            /// </summary>
            [EnumMember(Value = "NaturalPerson")] NaturalPerson = 1,

            /// <summary>
            /// Enum CompanyName for value: CompanyName
            /// </summary>
            [EnumMember(Value = "CompanyName")] CompanyName = 2
        }

        /// <summary>
        /// The type of the entity the payment is processed for.
        /// </summary>
        /// <value>The type of the entity the payment is processed for.</value>
        [DataMember(Name = "entityType", EmitDefaultValue = false)]
        public EntityTypeEnum? EntityType { get; set; }

        /// <summary>
        /// Defines a recurring payment type. Allowed values: * &#x60;Subscription&#x60; – A transaction for a fixed or variable amount, which follows a fixed schedule. * &#x60;CardOnFile&#x60; – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * &#x60;UnscheduledCardOnFile&#x60; – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder&#x27;s balance drops below a certain amount. 
        /// </summary>
        /// <value>Defines a recurring payment type. Allowed values: * &#x60;Subscription&#x60; – A transaction for a fixed or variable amount, which follows a fixed schedule. * &#x60;CardOnFile&#x60; – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * &#x60;UnscheduledCardOnFile&#x60; – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder&#x27;s balance drops below a certain amount. </value>
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
            [EnumMember(Value = "Subscription")] Subscription = 2,

            /// <summary>
            /// Enum UnscheduledCardOnFile for value: UnscheduledCardOnFile
            /// </summary>
            [EnumMember(Value = "UnscheduledCardOnFile")] UnscheduledCardOnFile = 3
        }

        /// <summary>
        /// Defines a recurring payment type. Allowed values: * &#x60;Subscription&#x60; – A transaction for a fixed or variable amount, which follows a fixed schedule. * &#x60;CardOnFile&#x60; – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * &#x60;UnscheduledCardOnFile&#x60; – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder&#x27;s balance drops below a certain amount. 
        /// </summary>
        /// <value>Defines a recurring payment type. Allowed values: * &#x60;Subscription&#x60; – A transaction for a fixed or variable amount, which follows a fixed schedule. * &#x60;CardOnFile&#x60; – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * &#x60;UnscheduledCardOnFile&#x60; – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder&#x27;s balance drops below a certain amount. </value>
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
        /// Initializes a new instance of the <see cref="PaymentRequest" /> class.
        /// </summary>
        [JsonConstructor]
        public PaymentRequest()
        {
            CreateApplicationInfo();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRequest" /> class.
        /// </summary>
        /// <param name="accountInfo">accountInfo.</param>
        /// <param name="additionalData">This field contains additional data, which may be required for a particular payment request.  The &#x60;additionalData&#x60; object consists of entries, each of which includes the key and value..</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="applicationInfo">applicationInfo.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="browserInfo">browserInfo.</param>
        /// <param name="captureDelayHours">The delay between the authorisation and scheduled auto-capture, specified in hours..</param>
        /// <param name="channel">The platform where a payment transaction takes place. This field is optional for filtering out payment methods that are only available on specific platforms. If this value is not set, then we will try to infer it from the &#x60;sdkVersion&#x60; or &#x60;token&#x60;.  Possible values: * iOS * Android * Web.</param>
        /// <param name="company">company.</param>
        /// <param name="conversionId">Conversion ID that corresponds to the Id generated for tracking user payment journey..</param>
        /// <param name="countryCode">The shopper country.  Format: [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) Example: NL or DE.</param>
        /// <param name="dateOfBirth">The shopper&#x27;s date of birth.  Format [ISO-8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DD.</param>
        /// <param name="dccQuote">dccQuote.</param>
        /// <param name="deliveryAddress">deliveryAddress.</param>
        /// <param name="deliveryDate">The date and time the purchased goods should be delivered.  Format [ISO 8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DDThh:mm:ss.sssTZD  Example: 2017-07-17T13:42:40.428+01:00.</param>
        /// <param name="deviceFingerprint">A string containing the shopper&#x27;s device fingerprint. For more information, refer to [Device fingerprinting](https://docs.adyen.com/risk-management/device-fingerprinting)..</param>
        /// <param name="enableOneClick">When true and &#x60;shopperReference&#x60; is provided, the shopper will be asked if the payment details should be stored for future one-click payments..</param>
        /// <param name="enablePayOut">When true and &#x60;shopperReference&#x60; is provided, the payment details will be tokenized for payouts..</param>
        /// <param name="enableRecurring">When true and &#x60;shopperReference&#x60; is provided, the payment details will be tokenized for recurring payments..</param>
        /// <param name="entityType">The type of the entity the payment is processed for..</param>
        /// <param name="fraudOffset">An integer value that is added to the normal fraud score. The value can be either positive or negative..</param>
        /// <param name="installments">installments.</param>
        /// <param name="lineItems">Price and product information about the purchased items, to be included on the invoice sent to the shopper. &gt; This field is required for 3x 4x Oney, Affirm, AfterPay, Klarna, RatePay, and Zip..</param>
        /// <param name="mcc">The [merchant category code](https://en.wikipedia.org/wiki/Merchant_category_code) (MCC) is a four-digit number, which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant..</param>
        /// <param name="merchantAccount">The merchant account identifier, with which you want to process the transaction. (required).</param>
        /// <param name="merchantOrderReference">This reference allows linking multiple transactions to each other for reporting purposes (i.e. order auth-rate). The reference should be unique per billing cycle. The same merchant order reference should never be reused after the first authorised attempt. If used, this field should be supplied for all incoming authorisations. &gt; We strongly recommend you send the &#x60;merchantOrderReference&#x60; value to benefit from linking payment requests when authorisation retries take place. In addition, we recommend you provide &#x60;retry.orderAttemptNumber&#x60;, &#x60;retry.chainAttemptNumber&#x60;, and &#x60;retry.skipRetry&#x60; values in &#x60;PaymentRequest.additionalData&#x60;..</param>
        /// <param name="merchantRiskIndicator">merchantRiskIndicator.</param>
        /// <param name="metadata">Metadata consists of entries, each of which includes a key and a value. Limitations: Maximum 20 key-value pairs per request. When exceeding, the \&quot;177\&quot; error occurs: \&quot;Metadata size exceeds limit\&quot;..</param>
        /// <param name="mpiData">mpiData.</param>
        /// <param name="order">order.</param>
        /// <param name="orderReference">When you are doing multiple partial (gift card) payments, this is the &#x60;pspReference&#x60; of the first payment. We use this to link the multiple payments to each other. As your own reference for linking multiple payments, use the &#x60;merchantOrderReference&#x60;instead..</param>
        /// <param name="origin">Required for the 3D Secure 2 &#x60;channel&#x60; **Web** integration.  Set this parameter to the origin URL of the page that you are loading the 3D Secure Component from..</param>
        /// <param name="paymentMethod">The type and required details of a payment method to use. (required).</param>
        /// <param name="recurringExpiry">Date after which no further authorisations shall be performed. Only for 3D Secure 2..</param>
        /// <param name="recurringFrequency">Minimum number of days between authorisations. Only for 3D Secure 2..</param>
        /// <param name="recurringProcessingModel">Defines a recurring payment type. Allowed values: * &#x60;Subscription&#x60; – A transaction for a fixed or variable amount, which follows a fixed schedule. * &#x60;CardOnFile&#x60; – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * &#x60;UnscheduledCardOnFile&#x60; – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder&#x27;s balance drops below a certain amount. .</param>
        /// <param name="redirectFromIssuerMethod">Specifies the redirect method (GET or POST) when redirecting back from the issuer..</param>
        /// <param name="redirectToIssuerMethod">Specifies the redirect method (GET or POST) when redirecting to the issuer..</param>
        /// <param name="reference">The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement. If you need to provide multiple references for a transaction, separate them with hyphens (\&quot;-\&quot;). Maximum length: 80 characters. (required).</param>
        /// <param name="returnUrl">The URL to return to in case of a redirection. The format depends on the channel. This URL can have a maximum of 1024 characters. * For web, include the protocol &#x60;http://&#x60; or &#x60;https://&#x60;. You can also include your own additional query parameters, for example, shopper ID or order reference number. Example: &#x60;https://your-company.com/checkout?shopperOrder&#x3D;12xy&#x60; * For iOS, use the custom URL for your app. To know more about setting custom URL schemes, refer to the [Apple Developer documentation](https://developer.apple.com/documentation/uikit/inter-process_communication/allowing_apps_and_websites_to_link_to_your_content/defining_a_custom_url_scheme_for_your_app). Example: &#x60;my-app://&#x60; * For Android, use a custom URL handled by an Activity on your app. You can configure it with an [intent filter](https://developer.android.com/guide/components/intents-filters). Example: &#x60;my-app://your.package.name&#x60; (required).</param>
        /// <param name="riskData">riskData.</param>
        /// <param name="sessionValidity">The date and time until when the session remains valid, in [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.  For example: 2020-07-18T15:42:40.428+01:00.</param>
        /// <param name="shopperEmail">The shopper&#x27;s email address. We recommend that you provide this data, as it is used in velocity fraud checks. &gt; For 3D Secure 2 transactions, schemes require &#x60;shopperEmail&#x60; for all browser-based and mobile implementations..</param>
        /// <param name="shopperIP">The shopper&#x27;s IP address. In general, we recommend that you provide this data, as it is used in a number of risk checks (for instance, number of payment attempts or location-based checks). &gt; For 3D Secure 2 transactions, schemes require &#x60;shopperIP&#x60; for all browser-based implementations. This field is also mandatory for some merchants depending on your business model. For more information, [contact Support](https://support.adyen.com/hc/en-us/requests/new)..</param>
        /// <param name="shopperInteraction">Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * &#x60;Ecommerce&#x60; - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * &#x60;ContAuth&#x60; - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * &#x60;Moto&#x60; - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * &#x60;POS&#x60; - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal..</param>
        /// <param name="shopperLocale">The combination of a language code and a country code to specify the language to be used in the payment..</param>
        /// <param name="shopperName">shopperName.</param>
        /// <param name="shopperReference">Your reference to uniquely identify this shopper (for example, user ID or account ID). Minimum length: 3 characters. &gt; This field is required for recurring payments..</param>
        /// <param name="shopperStatement">The text to be shown on the shopper&#x27;s bank statement. To enable this field, contact our [Support Team](https://support.adyen.com/hc/en-us/requests/new).  We recommend sending a maximum of 25 characters, otherwise banks might truncate the string..</param>
        /// <param name="socialSecurityNumber">The shopper&#x27;s social security number..</param>
        /// <param name="splits">Information on how the payment should be split between accounts when using [Adyen for Platforms](https://docs.adyen.com/platforms/processing-payments#providing-split-information)..</param>
        /// <param name="store">The physical store, for which this payment is processed..</param>
        /// <param name="storePaymentMethod">When true and &#x60;shopperReference&#x60; is provided, the payment details will be stored..</param>
        /// <param name="telephoneNumber">The shopper&#x27;s telephone number..</param>
        /// <param name="threeDS2RequestData">threeDS2RequestData.</param>
        /// <param name="threeDSAuthenticationOnly">If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation. (default to false).</param>
        /// <param name="trustedShopper">Set to true if the payment should be routed to a trusted MID..</param>
        public PaymentRequest(AccountInfo accountInfo = default(AccountInfo),
             Dictionary<string, string> additionalData = default(Dictionary<string, string>),
            Amount amount = default(Amount), ApplicationInfo applicationInfo = default(ApplicationInfo),
            Address billingAddress = default(Address), BrowserInfo browserInfo = default(BrowserInfo),
            int? captureDelayHours = default(int?), ChannelEnum? channel = default(ChannelEnum?),
            Company company = default(Company), string conversionId = default(string),
            string countryCode = default(string), DateTime? dateOfBirth = default(DateTime?),
            ForexQuote dccQuote = default(ForexQuote), Address deliveryAddress = default(Address),
            DateTime? deliveryDate = default(DateTime?), string deviceFingerprint = default(string),
            bool? enableOneClick = default(bool?), bool? enablePayOut = default(bool?),
            bool? enableRecurring = default(bool?), EntityTypeEnum? entityType = default(EntityTypeEnum?),
            int? fraudOffset = default(int?), Installments installments = default(Installments),
            List<LineItem> lineItems = default(List<LineItem>), string mcc = default(string),
            string merchantAccount = default(string), string merchantOrderReference = default(string),
            MerchantRiskIndicator merchantRiskIndicator = default(MerchantRiskIndicator),
            Dictionary<string, string> metadata = default(Dictionary<string, string>),
            ThreeDSecureData mpiData = default(ThreeDSecureData), CheckoutOrder order = default(CheckoutOrder),
            string orderReference = default(string), string origin = default(string),
            DefaultPaymentMethodDetails paymentMethod = default(DefaultPaymentMethodDetails),
            string recurringExpiry = default(string), string recurringFrequency = default(string),
            RecurringProcessingModelEnum? recurringProcessingModel = default(RecurringProcessingModelEnum?),
            string redirectFromIssuerMethod = default(string), string redirectToIssuerMethod = default(string),
            string reference = default(string), string returnUrl = default(string),
            RiskData riskData = default(RiskData), string sessionValidity = default(string),
            string shopperEmail = default(string), string shopperIP = default(string),
            ShopperInteractionEnum? shopperInteraction = default(ShopperInteractionEnum?),
            string shopperLocale = default(string), Name shopperName = default(Name),
            string shopperReference = default(string), string shopperStatement = default(string),
            string socialSecurityNumber = default(string), List<Split> splits = default(List<Split>),
            string store = default(string), bool? storePaymentMethod = default(bool?),
            string telephoneNumber = default(string),
            ThreeDS2RequestData threeDS2RequestData = default(ThreeDS2RequestData),
            bool? threeDSAuthenticationOnly = false, bool? trustedShopper = default(bool?))
        {
            CreateApplicationInfo();
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for PaymentRequest and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            // to ensure "merchantAccount" is required (not null)
            if (merchantAccount == null)
            {
                throw new InvalidDataException(
                    "merchantAccount is a required property for PaymentRequest and cannot be null");
            }
            else
            {
                this.MerchantAccount = merchantAccount;
            }
            // to ensure "paymentMethod" is required (not null)
            if (paymentMethod == null)
            {
                throw new InvalidDataException(
                    "paymentMethod is a required property for PaymentRequest and cannot be null");
            }
            else
            {
                this.PaymentMethod = paymentMethod;
            }
            // to ensure "reference" is required (not null)
            if (reference == null)
            {
                throw new InvalidDataException(
                    "reference is a required property for PaymentRequest and cannot be null");
            }
            else
            {
                this.Reference = reference;
            }
            // to ensure "returnUrl" is required (not null)
            if (returnUrl == null)
            {
                throw new InvalidDataException(
                    "returnUrl is a required property for PaymentRequest and cannot be null");
            }
            else
            {
                this.ReturnUrl = returnUrl;
            }
            this.AccountInfo = accountInfo;
            this.AdditionalData = additionalData;
            this.ApplicationInfo = applicationInfo;
            this.BillingAddress = billingAddress;
            this.BrowserInfo = browserInfo;
            this.CaptureDelayHours = captureDelayHours;
            this.Channel = channel;
            this.Company = company;
            this.ConversionId = conversionId;
            this.CountryCode = countryCode;
            this.DateOfBirth = dateOfBirth;
            this.DccQuote = dccQuote;
            this.DeliveryAddress = deliveryAddress;
            this.DeliveryDate = deliveryDate;
            this.DeviceFingerprint = deviceFingerprint;
            this.EnableOneClick = enableOneClick;
            this.EnablePayOut = enablePayOut;
            this.EnableRecurring = enableRecurring;
            this.EntityType = entityType;
            this.FraudOffset = fraudOffset;
            this.Installments = installments;
            this.LineItems = lineItems;
            this.Mcc = mcc;
            this.MerchantOrderReference = merchantOrderReference;
            this.MerchantRiskIndicator = merchantRiskIndicator;
            this.Metadata = metadata;
            this.MpiData = mpiData;
            this.Order = order;
            this.OrderReference = orderReference;
            this.Origin = origin;
            this.RecurringExpiry = recurringExpiry;
            this.RecurringFrequency = recurringFrequency;
            this.RecurringProcessingModel = recurringProcessingModel;
            this.RedirectFromIssuerMethod = redirectFromIssuerMethod;
            this.RedirectToIssuerMethod = redirectToIssuerMethod;
            this.RiskData = riskData;
            this.SessionValidity = sessionValidity;
            this.ShopperEmail = shopperEmail;
            this.ShopperIP = shopperIP;
            this.ShopperInteraction = shopperInteraction;
            this.ShopperLocale = shopperLocale;
            this.ShopperName = shopperName;
            this.ShopperReference = shopperReference;
            this.ShopperStatement = shopperStatement;
            this.SocialSecurityNumber = socialSecurityNumber;
            this.Splits = splits;
            this.Store = store;
            this.StorePaymentMethod = storePaymentMethod;
            this.TelephoneNumber = telephoneNumber;
            this.ThreeDS2RequestData = threeDS2RequestData;
            // use default value if no "threeDSAuthenticationOnly" provided
            if (threeDSAuthenticationOnly == null)
            {
                this.ThreeDSAuthenticationOnly = false;
            }
            else
            {
                this.ThreeDSAuthenticationOnly = threeDSAuthenticationOnly;
            }
            this.TrustedShopper = trustedShopper;
        }

        /// <summary>
        /// Gets or Sets AccountInfo
        /// </summary>
        [DataMember(Name = "accountInfo", EmitDefaultValue = false)]
        public AccountInfo AccountInfo { get; set; }

        /// <summary>
        /// This field contains additional data, which may be required for a particular payment request.  The &#x60;additionalData&#x60; object consists of entries, each of which includes the key and value.
        /// </summary>
        /// <value>This field contains additional data, which may be required for a particular payment request.  The &#x60;additionalData&#x60; object consists of entries, each of which includes the key and value.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationInfo
        /// </summary>
        [DataMember(Name = "applicationInfo", EmitDefaultValue = false)]
        public ApplicationInfo ApplicationInfo { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Gets or Sets BrowserInfo
        /// </summary>
        [DataMember(Name = "browserInfo", EmitDefaultValue = false)]
        public BrowserInfo BrowserInfo { get; set; }

        /// <summary>
        /// The delay between the authorisation and scheduled auto-capture, specified in hours.
        /// </summary>
        /// <value>The delay between the authorisation and scheduled auto-capture, specified in hours.</value>
        [DataMember(Name = "captureDelayHours", EmitDefaultValue = false)]
        public int? CaptureDelayHours { get; set; }


        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name = "company", EmitDefaultValue = false)]
        public Company Company { get; set; }

        /// <summary>
        /// Conversion ID that corresponds to the Id generated for tracking user payment journey.
        /// </summary>
        /// <value>Conversion ID that corresponds to the Id generated for tracking user payment journey.</value>
        [DataMember(Name = "conversionId", EmitDefaultValue = false)]
        public string ConversionId { get; set; }

        /// <summary>
        /// The shopper country.  Format: [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) Example: NL or DE
        /// </summary>
        /// <value>The shopper country.  Format: [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) Example: NL or DE</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The shopper&#x27;s date of birth.  Format [ISO-8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DD
        /// </summary>
        /// <value>The shopper&#x27;s date of birth.  Format [ISO-8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DD</value>
        [DataMember(Name = "dateOfBirth", EmitDefaultValue = false)]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets DccQuote
        /// </summary>
        [DataMember(Name = "dccQuote", EmitDefaultValue = false)]
        public ForexQuote DccQuote { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryAddress
        /// </summary>
        [DataMember(Name = "deliveryAddress", EmitDefaultValue = false)]
        public Address DeliveryAddress { get; set; }

        /// <summary>
        /// The date and time the purchased goods should be delivered.  Format [ISO 8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DDThh:mm:ss.sssTZD  Example: 2017-07-17T13:42:40.428+01:00
        /// </summary>
        /// <value>The date and time the purchased goods should be delivered.  Format [ISO 8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DDThh:mm:ss.sssTZD  Example: 2017-07-17T13:42:40.428+01:00</value>
        [DataMember(Name = "deliveryDate", EmitDefaultValue = false)]
        public DateTime? DeliveryDate { get; set; }

        /// <summary>
        /// A string containing the shopper&#x27;s device fingerprint. For more information, refer to [Device fingerprinting](https://docs.adyen.com/risk-management/device-fingerprinting).
        /// </summary>
        /// <value>A string containing the shopper&#x27;s device fingerprint. For more information, refer to [Device fingerprinting](https://docs.adyen.com/risk-management/device-fingerprinting).</value>
        [DataMember(Name = "deviceFingerprint", EmitDefaultValue = false)]
        public string DeviceFingerprint { get; set; }

        /// <summary>
        /// When true and &#x60;shopperReference&#x60; is provided, the shopper will be asked if the payment details should be stored for future one-click payments.
        /// </summary>
        /// <value>When true and &#x60;shopperReference&#x60; is provided, the shopper will be asked if the payment details should be stored for future one-click payments.</value>
        [DataMember(Name = "enableOneClick", EmitDefaultValue = false)]
        public bool? EnableOneClick { get; set; }

        /// <summary>
        /// When true and &#x60;shopperReference&#x60; is provided, the payment details will be tokenized for payouts.
        /// </summary>
        /// <value>When true and &#x60;shopperReference&#x60; is provided, the payment details will be tokenized for payouts.</value>
        [DataMember(Name = "enablePayOut", EmitDefaultValue = false)]
        public bool? EnablePayOut { get; set; }

        /// <summary>
        /// When true and &#x60;shopperReference&#x60; is provided, the payment details will be tokenized for recurring payments.
        /// </summary>
        /// <value>When true and &#x60;shopperReference&#x60; is provided, the payment details will be tokenized for recurring payments.</value>
        [DataMember(Name = "enableRecurring", EmitDefaultValue = false)]
        public bool? EnableRecurring { get; set; }


        /// <summary>
        /// An integer value that is added to the normal fraud score. The value can be either positive or negative.
        /// </summary>
        /// <value>An integer value that is added to the normal fraud score. The value can be either positive or negative.</value>
        [DataMember(Name = "fraudOffset", EmitDefaultValue = false)]
        public int? FraudOffset { get; set; }

        /// <summary>
        /// Gets or Sets Installments
        /// </summary>
        [DataMember(Name = "installments", EmitDefaultValue = false)]
        public Installments Installments { get; set; }

        /// <summary>
        /// Price and product information about the purchased items, to be included on the invoice sent to the shopper. &gt; This field is required for 3x 4x Oney, Affirm, AfterPay, Klarna, RatePay, and Zip.
        /// </summary>
        /// <value>Price and product information about the purchased items, to be included on the invoice sent to the shopper. &gt; This field is required for 3x 4x Oney, Affirm, AfterPay, Klarna, RatePay, and Zip.</value>
        [DataMember(Name = "lineItems", EmitDefaultValue = false)]
        public List<LineItem> LineItems { get; set; }

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
        /// This reference allows linking multiple transactions to each other for reporting purposes (i.e. order auth-rate). The reference should be unique per billing cycle. The same merchant order reference should never be reused after the first authorised attempt. If used, this field should be supplied for all incoming authorisations. &gt; We strongly recommend you send the &#x60;merchantOrderReference&#x60; value to benefit from linking payment requests when authorisation retries take place. In addition, we recommend you provide &#x60;retry.orderAttemptNumber&#x60;, &#x60;retry.chainAttemptNumber&#x60;, and &#x60;retry.skipRetry&#x60; values in &#x60;PaymentRequest.additionalData&#x60;.
        /// </summary>
        /// <value>This reference allows linking multiple transactions to each other for reporting purposes (i.e. order auth-rate). The reference should be unique per billing cycle. The same merchant order reference should never be reused after the first authorised attempt. If used, this field should be supplied for all incoming authorisations. &gt; We strongly recommend you send the &#x60;merchantOrderReference&#x60; value to benefit from linking payment requests when authorisation retries take place. In addition, we recommend you provide &#x60;retry.orderAttemptNumber&#x60;, &#x60;retry.chainAttemptNumber&#x60;, and &#x60;retry.skipRetry&#x60; values in &#x60;PaymentRequest.additionalData&#x60;.</value>
        [DataMember(Name = "merchantOrderReference", EmitDefaultValue = false)]
        public string MerchantOrderReference { get; set; }

        /// <summary>
        /// Gets or Sets MerchantRiskIndicator
        /// </summary>
        [DataMember(Name = "merchantRiskIndicator", EmitDefaultValue = false)]
        public MerchantRiskIndicator MerchantRiskIndicator { get; set; }

        /// <summary>
        /// Metadata consists of entries, each of which includes a key and a value. Limitations: Maximum 20 key-value pairs per request. When exceeding, the \&quot;177\&quot; error occurs: \&quot;Metadata size exceeds limit\&quot;.
        /// </summary>
        /// <value>Metadata consists of entries, each of which includes a key and a value. Limitations: Maximum 20 key-value pairs per request. When exceeding, the \&quot;177\&quot; error occurs: \&quot;Metadata size exceeds limit\&quot;.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets MpiData
        /// </summary>
        [DataMember(Name = "mpiData", EmitDefaultValue = false)]
        public ThreeDSecureData MpiData { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public CheckoutOrder Order { get; set; }

        /// <summary>
        /// When you are doing multiple partial (gift card) payments, this is the &#x60;pspReference&#x60; of the first payment. We use this to link the multiple payments to each other. As your own reference for linking multiple payments, use the &#x60;merchantOrderReference&#x60;instead.
        /// </summary>
        /// <value>When you are doing multiple partial (gift card) payments, this is the &#x60;pspReference&#x60; of the first payment. We use this to link the multiple payments to each other. As your own reference for linking multiple payments, use the &#x60;merchantOrderReference&#x60;instead.</value>
        [DataMember(Name = "orderReference", EmitDefaultValue = false)]
        public string OrderReference { get; set; }

        /// <summary>
        /// The collection that contains the type of the payment method and its specific information (e.g. &#x60;idealIssuer&#x60;).
        /// </summary>
        /// <value>The collection that contains the type of the payment method and its specific information (e.g. &#x60;idealIssuer&#x60;).</value>
        [DataMember(Name = "paymentMethod", EmitDefaultValue = false)]
        public IPaymentMethodDetails PaymentMethod { get; set; }

        /// <summary>
        /// Required for the 3D Secure 2 &#x60;channel&#x60; **Web** integration.  Set this parameter to the origin URL of the page that you are loading the 3D Secure Component from.
        /// </summary>
        /// <value>Required for the 3D Secure 2 &#x60;channel&#x60; **Web** integration.  Set this parameter to the origin URL of the page that you are loading the 3D Secure Component from.</value>
        [DataMember(Name = "origin", EmitDefaultValue = false)]
        public string Origin { get; set; }

        /// <summary>
        /// Date after which no further authorisations shall be performed. Only for 3D Secure 2.
        /// </summary>
        /// <value>Date after which no further authorisations shall be performed. Only for 3D Secure 2.</value>
        [DataMember(Name = "recurringExpiry", EmitDefaultValue = false)]
        public string RecurringExpiry { get; set; }

        /// <summary>
        /// Minimum number of days between authorisations. Only for 3D Secure 2.
        /// </summary>
        /// <value>Minimum number of days between authorisations. Only for 3D Secure 2.</value>
        [DataMember(Name = "recurringFrequency", EmitDefaultValue = false)]
        public string RecurringFrequency { get; set; }


        /// <summary>
        /// Specifies the redirect method (GET or POST) when redirecting back from the issuer.
        /// </summary>
        /// <value>Specifies the redirect method (GET or POST) when redirecting back from the issuer.</value>
        [DataMember(Name = "redirectFromIssuerMethod", EmitDefaultValue = false)]
        public string RedirectFromIssuerMethod { get; set; }

        /// <summary>
        /// Specifies the redirect method (GET or POST) when redirecting to the issuer.
        /// </summary>
        /// <value>Specifies the redirect method (GET or POST) when redirecting to the issuer.</value>
        [DataMember(Name = "redirectToIssuerMethod", EmitDefaultValue = false)]
        public string RedirectToIssuerMethod { get; set; }

        /// <summary>
        /// The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement. If you need to provide multiple references for a transaction, separate them with hyphens (\&quot;-\&quot;). Maximum length: 80 characters.
        /// </summary>
        /// <value>The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement. If you need to provide multiple references for a transaction, separate them with hyphens (\&quot;-\&quot;). Maximum length: 80 characters.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// The URL to return to in case of a redirection. The format depends on the channel. This URL can have a maximum of 1024 characters. * For web, include the protocol &#x60;http://&#x60; or &#x60;https://&#x60;. You can also include your own additional query parameters, for example, shopper ID or order reference number. Example: &#x60;https://your-company.com/checkout?shopperOrder&#x3D;12xy&#x60; * For iOS, use the custom URL for your app. To know more about setting custom URL schemes, refer to the [Apple Developer documentation](https://developer.apple.com/documentation/uikit/inter-process_communication/allowing_apps_and_websites_to_link_to_your_content/defining_a_custom_url_scheme_for_your_app). Example: &#x60;my-app://&#x60; * For Android, use a custom URL handled by an Activity on your app. You can configure it with an [intent filter](https://developer.android.com/guide/components/intents-filters). Example: &#x60;my-app://your.package.name&#x60;
        /// </summary>
        /// <value>The URL to return to in case of a redirection. The format depends on the channel. This URL can have a maximum of 1024 characters. * For web, include the protocol &#x60;http://&#x60; or &#x60;https://&#x60;. You can also include your own additional query parameters, for example, shopper ID or order reference number. Example: &#x60;https://your-company.com/checkout?shopperOrder&#x3D;12xy&#x60; * For iOS, use the custom URL for your app. To know more about setting custom URL schemes, refer to the [Apple Developer documentation](https://developer.apple.com/documentation/uikit/inter-process_communication/allowing_apps_and_websites_to_link_to_your_content/defining_a_custom_url_scheme_for_your_app). Example: &#x60;my-app://&#x60; * For Android, use a custom URL handled by an Activity on your app. You can configure it with an [intent filter](https://developer.android.com/guide/components/intents-filters). Example: &#x60;my-app://your.package.name&#x60;</value>
        [DataMember(Name = "returnUrl", EmitDefaultValue = false)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Gets or Sets RiskData
        /// </summary>
        [DataMember(Name = "riskData", EmitDefaultValue = false)]
        public RiskData RiskData { get; set; }

        /// <summary>
        /// The date and time until when the session remains valid, in [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.  For example: 2020-07-18T15:42:40.428+01:00
        /// </summary>
        /// <value>The date and time until when the session remains valid, in [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.  For example: 2020-07-18T15:42:40.428+01:00</value>
        [DataMember(Name = "sessionValidity", EmitDefaultValue = false)]
        public string SessionValidity { get; set; }

        /// <summary>
        /// The shopper&#x27;s email address. We recommend that you provide this data, as it is used in velocity fraud checks. &gt; For 3D Secure 2 transactions, schemes require &#x60;shopperEmail&#x60; for all browser-based and mobile implementations.
        /// </summary>
        /// <value>The shopper&#x27;s email address. We recommend that you provide this data, as it is used in velocity fraud checks. &gt; For 3D Secure 2 transactions, schemes require &#x60;shopperEmail&#x60; for all browser-based and mobile implementations.</value>
        [DataMember(Name = "shopperEmail", EmitDefaultValue = false)]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// The shopper&#x27;s IP address. In general, we recommend that you provide this data, as it is used in a number of risk checks (for instance, number of payment attempts or location-based checks). &gt; For 3D Secure 2 transactions, schemes require &#x60;shopperIP&#x60; for all browser-based implementations. This field is also mandatory for some merchants depending on your business model. For more information, [contact Support](https://support.adyen.com/hc/en-us/requests/new).
        /// </summary>
        /// <value>The shopper&#x27;s IP address. In general, we recommend that you provide this data, as it is used in a number of risk checks (for instance, number of payment attempts or location-based checks). &gt; For 3D Secure 2 transactions, schemes require &#x60;shopperIP&#x60; for all browser-based implementations. This field is also mandatory for some merchants depending on your business model. For more information, [contact Support](https://support.adyen.com/hc/en-us/requests/new).</value>
        [DataMember(Name = "shopperIP", EmitDefaultValue = false)]
        public string ShopperIP { get; set; }


        /// <summary>
        /// The combination of a language code and a country code to specify the language to be used in the payment.
        /// </summary>
        /// <value>The combination of a language code and a country code to specify the language to be used in the payment.</value>
        [DataMember(Name = "shopperLocale", EmitDefaultValue = false)]
        public string ShopperLocale { get; set; }

        /// <summary>
        /// Gets or Sets ShopperName
        /// </summary>
        [DataMember(Name = "shopperName", EmitDefaultValue = false)]
        public Name ShopperName { get; set; }

        /// <summary>
        /// Your reference to uniquely identify this shopper (for example, user ID or account ID). Minimum length: 3 characters. &gt; This field is required for recurring payments.
        /// </summary>
        /// <value>Your reference to uniquely identify this shopper (for example, user ID or account ID). Minimum length: 3 characters. &gt; This field is required for recurring payments.</value>
        [DataMember(Name = "shopperReference", EmitDefaultValue = false)]
        public string ShopperReference { get; set; }

        /// <summary>
        /// The text to be shown on the shopper&#x27;s bank statement. To enable this field, contact our [Support Team](https://support.adyen.com/hc/en-us/requests/new).  We recommend sending a maximum of 25 characters, otherwise banks might truncate the string.
        /// </summary>
        /// <value>The text to be shown on the shopper&#x27;s bank statement. To enable this field, contact our [Support Team](https://support.adyen.com/hc/en-us/requests/new).  We recommend sending a maximum of 25 characters, otherwise banks might truncate the string.</value>
        [DataMember(Name = "shopperStatement", EmitDefaultValue = false)]
        public string ShopperStatement { get; set; }

        /// <summary>
        /// The shopper&#x27;s social security number.
        /// </summary>
        /// <value>The shopper&#x27;s social security number.</value>
        [DataMember(Name = "socialSecurityNumber", EmitDefaultValue = false)]
        public string SocialSecurityNumber { get; set; }

        /// <summary>
        /// Information on how the payment should be split between accounts when using [Adyen for Platforms](https://docs.adyen.com/platforms/processing-payments#providing-split-information).
        /// </summary>
        /// <value>Information on how the payment should be split between accounts when using [Adyen for Platforms](https://docs.adyen.com/platforms/processing-payments#providing-split-information).</value>
        [DataMember(Name = "splits", EmitDefaultValue = false)]
        public List<Split> Splits { get; set; }

        /// <summary>
        /// The physical store, for which this payment is processed.
        /// </summary>
        /// <value>The physical store, for which this payment is processed.</value>
        [DataMember(Name = "store", EmitDefaultValue = false)]
        public string Store { get; set; }

        /// <summary>
        /// When true and &#x60;shopperReference&#x60; is provided, the payment details will be stored.
        /// </summary>
        /// <value>When true and &#x60;shopperReference&#x60; is provided, the payment details will be stored.</value>
        [DataMember(Name = "storePaymentMethod", EmitDefaultValue = false)]
        public bool? StorePaymentMethod { get; set; }

        /// <summary>
        /// The shopper&#x27;s telephone number.
        /// </summary>
        /// <value>The shopper&#x27;s telephone number.</value>
        [DataMember(Name = "telephoneNumber", EmitDefaultValue = false)]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets ThreeDS2RequestData
        /// </summary>
        [DataMember(Name = "threeDS2RequestData", EmitDefaultValue = false)]
        public ThreeDS2RequestData ThreeDS2RequestData { get; set; }

        /// <summary>
        /// If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation.
        /// </summary>
        /// <value>If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation.</value>
        [DataMember(Name = "threeDSAuthenticationOnly", EmitDefaultValue = false)]
        public bool? ThreeDSAuthenticationOnly { get; set; }

        /// <summary>
        /// Set to true if the payment should be routed to a trusted MID.
        /// </summary>
        /// <value>Set to true if the payment should be routed to a trusted MID.</value>
        [DataMember(Name = "trustedShopper", EmitDefaultValue = false)]
        public bool? TrustedShopper { get; set; }

        public void AddCardData(string cardNumber, string expiryMonth, string expiryYear, string securityCode, string holderName)
        {
            var defaultPaymentMethodDetails = new DefaultPaymentMethodDetails
            {
                Type = ApiConstants.TypeScheme,
                Number = cardNumber,
                ExpiryMonth = expiryMonth,
                ExpiryYear = expiryYear,
            };

            if (!string.IsNullOrEmpty(securityCode))
            {
                defaultPaymentMethodDetails.Cvc = securityCode;
            }

            if (!string.IsNullOrEmpty(holderName))
            {
                defaultPaymentMethodDetails.HolderName = holderName;
            }

            this.PaymentMethod = defaultPaymentMethodDetails;
        }

        private void CreateApplicationInfo()
        {
            if (ApplicationInfo == null)
                ApplicationInfo = new ApplicationInfo();
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentRequest {\n");
            sb.Append("  AccountInfo: ").Append(AccountInfo).Append("\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData.ToCollectionsString()).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ApplicationInfo: ").Append(ApplicationInfo).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  BrowserInfo: ").Append(BrowserInfo).Append("\n");
            sb.Append("  CaptureDelayHours: ").Append(CaptureDelayHours).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  ConversionId: ").Append(ConversionId).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  DccQuote: ").Append(DccQuote).Append("\n");
            sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
            sb.Append("  DeliveryDate: ").Append(DeliveryDate).Append("\n");
            sb.Append("  DeviceFingerprint: ").Append(DeviceFingerprint).Append("\n");
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
            sb.Append("  MerchantRiskIndicator: ").Append(MerchantRiskIndicator).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata.ToCollectionsString()).Append("\n");
            sb.Append("  MpiData: ").Append(MpiData).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  OrderReference: ").Append(OrderReference).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  RecurringExpiry: ").Append(RecurringExpiry).Append("\n");
            sb.Append("  RecurringFrequency: ").Append(RecurringFrequency).Append("\n");
            sb.Append("  RecurringProcessingModel: ").Append(RecurringProcessingModel).Append("\n");
            sb.Append("  RedirectFromIssuerMethod: ").Append(RedirectFromIssuerMethod).Append("\n");
            sb.Append("  RedirectToIssuerMethod: ").Append(RedirectToIssuerMethod).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
            sb.Append("  RiskData: ").Append(RiskData).Append("\n");
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
            sb.Append("  Store: ").Append(Store).Append("\n");
            sb.Append("  StorePaymentMethod: ").Append(StorePaymentMethod).Append("\n");
            sb.Append("  TelephoneNumber: ").Append(TelephoneNumber).Append("\n");
            sb.Append("  ThreeDS2RequestData: ").Append(ThreeDS2RequestData).Append("\n");
            sb.Append("  ThreeDSAuthenticationOnly: ").Append(ThreeDSAuthenticationOnly).Append("\n");
            sb.Append("  TrustedShopper: ").Append(TrustedShopper).Append("\n");
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
            return this.Equals(input as PaymentRequest);
        }

        /// <summary>
        /// Returns true if PaymentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AccountInfo == input.AccountInfo ||
                    this.AccountInfo != null &&
                    this.AccountInfo.Equals(input.AccountInfo)
                ) &&
                (
                    this.AdditionalData == input.AdditionalData ||
                    this.AdditionalData != null &&
                    this.AdditionalData.Equals(input.AdditionalData)
                ) &&
                (
                    this.Amount == input.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(input.Amount)
                ) &&
                (
                    this.ApplicationInfo == input.ApplicationInfo ||
                    this.ApplicationInfo != null &&
                    this.ApplicationInfo.Equals(input.ApplicationInfo)
                ) &&
                (
                    this.BillingAddress == input.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress)
                ) &&
                (
                    this.BrowserInfo == input.BrowserInfo ||
                    this.BrowserInfo != null &&
                    this.BrowserInfo.Equals(input.BrowserInfo)
                ) &&
                (
                    this.CaptureDelayHours == input.CaptureDelayHours ||
                    this.CaptureDelayHours != null &&
                    this.CaptureDelayHours.Equals(input.CaptureDelayHours)
                ) &&
                (
                    this.Channel == input.Channel ||
                    this.Channel != null &&
                    this.Channel.Equals(input.Channel)
                ) &&
                (
                    this.Company == input.Company ||
                    this.Company != null &&
                    this.Company.Equals(input.Company)
                ) &&
                (
                    this.ConversionId == input.ConversionId ||
                    this.ConversionId != null &&
                    this.ConversionId.Equals(input.ConversionId)
                ) &&
                (
                    this.CountryCode == input.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode)
                ) &&
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth)
                ) &&
                (
                    this.DccQuote == input.DccQuote ||
                    this.DccQuote != null &&
                    this.DccQuote.Equals(input.DccQuote)
                ) &&
                (
                    this.DeliveryAddress == input.DeliveryAddress ||
                    this.DeliveryAddress != null &&
                    this.DeliveryAddress.Equals(input.DeliveryAddress)
                ) &&
                (
                    this.DeliveryDate == input.DeliveryDate ||
                    this.DeliveryDate != null &&
                    this.DeliveryDate.Equals(input.DeliveryDate)
                ) &&
                (
                    this.DeviceFingerprint == input.DeviceFingerprint ||
                    this.DeviceFingerprint != null &&
                    this.DeviceFingerprint.Equals(input.DeviceFingerprint)
                ) &&
                (
                    this.EnableOneClick == input.EnableOneClick ||
                    this.EnableOneClick != null &&
                    this.EnableOneClick.Equals(input.EnableOneClick)
                ) &&
                (
                    this.EnablePayOut == input.EnablePayOut ||
                    this.EnablePayOut != null &&
                    this.EnablePayOut.Equals(input.EnablePayOut)
                ) &&
                (
                    this.EnableRecurring == input.EnableRecurring ||
                    this.EnableRecurring != null &&
                    this.EnableRecurring.Equals(input.EnableRecurring)
                ) &&
                (
                    this.EntityType == input.EntityType ||
                    this.EntityType != null &&
                    this.EntityType.Equals(input.EntityType)
                ) &&
                (
                    this.FraudOffset == input.FraudOffset ||
                    this.FraudOffset != null &&
                    this.FraudOffset.Equals(input.FraudOffset)
                ) &&
                (
                    this.Installments == input.Installments ||
                    this.Installments != null &&
                    this.Installments.Equals(input.Installments)
                ) &&
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) &&
                (
                    this.Mcc == input.Mcc ||
                    this.Mcc != null &&
                    this.Mcc.Equals(input.Mcc)
                ) &&
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount)
                ) &&
                (
                    this.MerchantOrderReference == input.MerchantOrderReference ||
                    this.MerchantOrderReference != null &&
                    this.MerchantOrderReference.Equals(input.MerchantOrderReference)
                ) &&
                (
                    this.MerchantRiskIndicator == input.MerchantRiskIndicator ||
                    this.MerchantRiskIndicator != null &&
                    this.MerchantRiskIndicator.Equals(input.MerchantRiskIndicator)
                ) &&
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) &&
                (
                    this.MpiData == input.MpiData ||
                    this.MpiData != null &&
                    this.MpiData.Equals(input.MpiData)
                ) &&
                (
                    this.Order == input.Order ||
                    this.Order != null &&
                    this.Order.Equals(input.Order)
                ) &&
                (
                    this.OrderReference == input.OrderReference ||
                    this.OrderReference != null &&
                    this.OrderReference.Equals(input.OrderReference)
                ) &&
                (
                    this.Origin == input.Origin ||
                    this.Origin != null &&
                    this.Origin.Equals(input.Origin)
                ) &&
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod)
                ) &&
                (
                    this.RecurringExpiry == input.RecurringExpiry ||
                    this.RecurringExpiry != null &&
                    this.RecurringExpiry.Equals(input.RecurringExpiry)
                ) &&
                (
                    this.RecurringFrequency == input.RecurringFrequency ||
                    this.RecurringFrequency != null &&
                    this.RecurringFrequency.Equals(input.RecurringFrequency)
                ) &&
                (
                    this.RecurringProcessingModel == input.RecurringProcessingModel ||
                    this.RecurringProcessingModel != null &&
                    this.RecurringProcessingModel.Equals(input.RecurringProcessingModel)
                ) &&
                (
                    this.RedirectFromIssuerMethod == input.RedirectFromIssuerMethod ||
                    this.RedirectFromIssuerMethod != null &&
                    this.RedirectFromIssuerMethod.Equals(input.RedirectFromIssuerMethod)
                ) &&
                (
                    this.RedirectToIssuerMethod == input.RedirectToIssuerMethod ||
                    this.RedirectToIssuerMethod != null &&
                    this.RedirectToIssuerMethod.Equals(input.RedirectToIssuerMethod)
                ) &&
                (
                    this.Reference == input.Reference ||
                    this.Reference != null &&
                    this.Reference.Equals(input.Reference)
                ) &&
                (
                    this.ReturnUrl == input.ReturnUrl ||
                    this.ReturnUrl != null &&
                    this.ReturnUrl.Equals(input.ReturnUrl)
                ) &&
                (
                    this.RiskData == input.RiskData ||
                    this.RiskData != null &&
                    this.RiskData.Equals(input.RiskData)
                ) &&
                (
                    this.SessionValidity == input.SessionValidity ||
                    this.SessionValidity != null &&
                    this.SessionValidity.Equals(input.SessionValidity)
                ) &&
                (
                    this.ShopperEmail == input.ShopperEmail ||
                    this.ShopperEmail != null &&
                    this.ShopperEmail.Equals(input.ShopperEmail)
                ) &&
                (
                    this.ShopperIP == input.ShopperIP ||
                    this.ShopperIP != null &&
                    this.ShopperIP.Equals(input.ShopperIP)
                ) &&
                (
                    this.ShopperInteraction == input.ShopperInteraction ||
                    this.ShopperInteraction != null &&
                    this.ShopperInteraction.Equals(input.ShopperInteraction)
                ) &&
                (
                    this.ShopperLocale == input.ShopperLocale ||
                    this.ShopperLocale != null &&
                    this.ShopperLocale.Equals(input.ShopperLocale)
                ) &&
                (
                    this.ShopperName == input.ShopperName ||
                    this.ShopperName != null &&
                    this.ShopperName.Equals(input.ShopperName)
                ) &&
                (
                    this.ShopperReference == input.ShopperReference ||
                    this.ShopperReference != null &&
                    this.ShopperReference.Equals(input.ShopperReference)
                ) &&
                (
                    this.ShopperStatement == input.ShopperStatement ||
                    this.ShopperStatement != null &&
                    this.ShopperStatement.Equals(input.ShopperStatement)
                ) &&
                (
                    this.SocialSecurityNumber == input.SocialSecurityNumber ||
                    this.SocialSecurityNumber != null &&
                    this.SocialSecurityNumber.Equals(input.SocialSecurityNumber)
                ) &&
                (
                    this.Splits == input.Splits ||
                    this.Splits != null &&
                    input.Splits != null &&
                    this.Splits.SequenceEqual(input.Splits)
                ) &&
                (
                    this.Store == input.Store ||
                    this.Store != null &&
                    this.Store.Equals(input.Store)
                ) &&
                (
                    this.StorePaymentMethod == input.StorePaymentMethod ||
                    this.StorePaymentMethod != null &&
                    this.StorePaymentMethod.Equals(input.StorePaymentMethod)
                ) &&
                (
                    this.TelephoneNumber == input.TelephoneNumber ||
                    this.TelephoneNumber != null &&
                    this.TelephoneNumber.Equals(input.TelephoneNumber)
                ) &&
                (
                    this.ThreeDS2RequestData == input.ThreeDS2RequestData ||
                    this.ThreeDS2RequestData != null &&
                    this.ThreeDS2RequestData.Equals(input.ThreeDS2RequestData)
                ) &&
                (
                    this.ThreeDSAuthenticationOnly == input.ThreeDSAuthenticationOnly ||
                    this.ThreeDSAuthenticationOnly != null &&
                    this.ThreeDSAuthenticationOnly.Equals(input.ThreeDSAuthenticationOnly)
                ) &&
                (
                    this.TrustedShopper == input.TrustedShopper ||
                    this.TrustedShopper != null &&
                    this.TrustedShopper.Equals(input.TrustedShopper)
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
                if (this.AccountInfo != null)
                    hashCode = hashCode * 59 + this.AccountInfo.GetHashCode();
                if (this.AdditionalData != null)
                    hashCode = hashCode * 59 + this.AdditionalData.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.ApplicationInfo != null)
                    hashCode = hashCode * 59 + this.ApplicationInfo.GetHashCode();
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                if (this.BrowserInfo != null)
                    hashCode = hashCode * 59 + this.BrowserInfo.GetHashCode();
                if (this.CaptureDelayHours != null)
                    hashCode = hashCode * 59 + this.CaptureDelayHours.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.ConversionId != null)
                    hashCode = hashCode * 59 + this.ConversionId.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.DateOfBirth != null)
                    hashCode = hashCode * 59 + this.DateOfBirth.GetHashCode();
                if (this.DccQuote != null)
                    hashCode = hashCode * 59 + this.DccQuote.GetHashCode();
                if (this.DeliveryAddress != null)
                    hashCode = hashCode * 59 + this.DeliveryAddress.GetHashCode();
                if (this.DeliveryDate != null)
                    hashCode = hashCode * 59 + this.DeliveryDate.GetHashCode();
                if (this.DeviceFingerprint != null)
                    hashCode = hashCode * 59 + this.DeviceFingerprint.GetHashCode();
                if (this.EnableOneClick != null)
                    hashCode = hashCode * 59 + this.EnableOneClick.GetHashCode();
                if (this.EnablePayOut != null)
                    hashCode = hashCode * 59 + this.EnablePayOut.GetHashCode();
                if (this.EnableRecurring != null)
                    hashCode = hashCode * 59 + this.EnableRecurring.GetHashCode();
                if (this.EntityType != null)
                    hashCode = hashCode * 59 + this.EntityType.GetHashCode();
                if (this.FraudOffset != null)
                    hashCode = hashCode * 59 + this.FraudOffset.GetHashCode();
                if (this.Installments != null)
                    hashCode = hashCode * 59 + this.Installments.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.Mcc != null)
                    hashCode = hashCode * 59 + this.Mcc.GetHashCode();
                if (this.MerchantAccount != null)
                    hashCode = hashCode * 59 + this.MerchantAccount.GetHashCode();
                if (this.MerchantOrderReference != null)
                    hashCode = hashCode * 59 + this.MerchantOrderReference.GetHashCode();
                if (this.MerchantRiskIndicator != null)
                    hashCode = hashCode * 59 + this.MerchantRiskIndicator.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.MpiData != null)
                    hashCode = hashCode * 59 + this.MpiData.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.OrderReference != null)
                    hashCode = hashCode * 59 + this.OrderReference.GetHashCode();
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.RecurringExpiry != null)
                    hashCode = hashCode * 59 + this.RecurringExpiry.GetHashCode();
                if (this.RecurringFrequency != null)
                    hashCode = hashCode * 59 + this.RecurringFrequency.GetHashCode();
                if (this.RecurringProcessingModel != null)
                    hashCode = hashCode * 59 + this.RecurringProcessingModel.GetHashCode();
                if (this.RedirectFromIssuerMethod != null)
                    hashCode = hashCode * 59 + this.RedirectFromIssuerMethod.GetHashCode();
                if (this.RedirectToIssuerMethod != null)
                    hashCode = hashCode * 59 + this.RedirectToIssuerMethod.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.ReturnUrl != null)
                    hashCode = hashCode * 59 + this.ReturnUrl.GetHashCode();
                if (this.RiskData != null)
                    hashCode = hashCode * 59 + this.RiskData.GetHashCode();
                if (this.SessionValidity != null)
                    hashCode = hashCode * 59 + this.SessionValidity.GetHashCode();
                if (this.ShopperEmail != null)
                    hashCode = hashCode * 59 + this.ShopperEmail.GetHashCode();
                if (this.ShopperIP != null)
                    hashCode = hashCode * 59 + this.ShopperIP.GetHashCode();
                if (this.ShopperInteraction != null)
                    hashCode = hashCode * 59 + this.ShopperInteraction.GetHashCode();
                if (this.ShopperLocale != null)
                    hashCode = hashCode * 59 + this.ShopperLocale.GetHashCode();
                if (this.ShopperName != null)
                    hashCode = hashCode * 59 + this.ShopperName.GetHashCode();
                if (this.ShopperReference != null)
                    hashCode = hashCode * 59 + this.ShopperReference.GetHashCode();
                if (this.ShopperStatement != null)
                    hashCode = hashCode * 59 + this.ShopperStatement.GetHashCode();
                if (this.SocialSecurityNumber != null)
                    hashCode = hashCode * 59 + this.SocialSecurityNumber.GetHashCode();
                if (this.Splits != null)
                    hashCode = hashCode * 59 + this.Splits.GetHashCode();
                if (this.Store != null)
                    hashCode = hashCode * 59 + this.Store.GetHashCode();
                if (this.StorePaymentMethod != null)
                    hashCode = hashCode * 59 + this.StorePaymentMethod.GetHashCode();
                if (this.TelephoneNumber != null)
                    hashCode = hashCode * 59 + this.TelephoneNumber.GetHashCode();
                if (this.ThreeDS2RequestData != null)
                    hashCode = hashCode * 59 + this.ThreeDS2RequestData.GetHashCode();
                if (this.ThreeDSAuthenticationOnly != null)
                    hashCode = hashCode * 59 + this.ThreeDSAuthenticationOnly.GetHashCode();
                if (this.TrustedShopper != null)
                    hashCode = hashCode * 59 + this.TrustedShopper.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}