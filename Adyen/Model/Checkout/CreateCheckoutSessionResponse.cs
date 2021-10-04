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
//  Copyright (c) 2021 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.
#endregion


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Adyen.Model.ApplicationInformation;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using Adyen.Util;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// CreateCheckoutSessionResponse
    /// </summary>
    [DataContract]
    public partial class CreateCheckoutSessionResponse : IEquatable<CreateCheckoutSessionResponse>, IValidatableObject
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
        /// The platform where a payment transaction takes place. This field is optional for filtering out payment methods that are only available on specific platforms. If this value is not set, then we will try to infer it from the &#x60;sdkVersion&#x60; or &#x60;token&#x60;.  Possible values: * iOS * Android * Web
        /// </summary>
        /// <value>The platform where a payment transaction takes place. This field is optional for filtering out payment methods that are only available on specific platforms. If this value is not set, then we will try to infer it from the &#x60;sdkVersion&#x60; or &#x60;token&#x60;.  Possible values: * iOS * Android * Web</value>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public ChannelEnum? channel { get; set; }
        /// <summary>
        /// Defines a recurring payment type. Allowed values: * &#x60;Subscription&#x60; – A transaction for a fixed or variable amount, which follows a fixed schedule. * &#x60;CardOnFile&#x60; – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * &#x60;UnscheduledCardOnFile&#x60; – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder&#39;s balance drops below a certain amount. 
        /// </summary>
        /// <value>Defines a recurring payment type. Allowed values: * &#x60;Subscription&#x60; – A transaction for a fixed or variable amount, which follows a fixed schedule. * &#x60;CardOnFile&#x60; – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * &#x60;UnscheduledCardOnFile&#x60; – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder&#39;s balance drops below a certain amount. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RecurringProcessingModelEnum
        {
            /// <summary>
            /// Enum CardOnFile for value: CardOnFile
            /// </summary>
            [EnumMember(Value = "CardOnFile")]
            CardOnFile = 1,

            /// <summary>
            /// Enum Subscription for value: Subscription
            /// </summary>
            [EnumMember(Value = "Subscription")]
            Subscription = 2,

            /// <summary>
            /// Enum UnscheduledCardOnFile for value: UnscheduledCardOnFile
            /// </summary>
            [EnumMember(Value = "UnscheduledCardOnFile")]
            UnscheduledCardOnFile = 3

        }

        /// <summary>
        /// Defines a recurring payment type. Allowed values: * &#x60;Subscription&#x60; – A transaction for a fixed or variable amount, which follows a fixed schedule. * &#x60;CardOnFile&#x60; – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * &#x60;UnscheduledCardOnFile&#x60; – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder&#39;s balance drops below a certain amount. 
        /// </summary>
        /// <value>Defines a recurring payment type. Allowed values: * &#x60;Subscription&#x60; – A transaction for a fixed or variable amount, which follows a fixed schedule. * &#x60;CardOnFile&#x60; – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * &#x60;UnscheduledCardOnFile&#x60; – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder&#39;s balance drops below a certain amount. </value>
        [DataMember(Name = "recurringProcessingModel", EmitDefaultValue = false)]
        public RecurringProcessingModelEnum? recurringProcessingModel { get; set; }
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
        /// Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * &#x60;Ecommerce&#x60; - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * &#x60;ContAuth&#x60; - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * &#x60;Moto&#x60; - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * &#x60;POS&#x60; - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.
        /// </summary>
        /// <value>Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * &#x60;Ecommerce&#x60; - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * &#x60;ContAuth&#x60; - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * &#x60;Moto&#x60; - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * &#x60;POS&#x60; - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.</value>
        [DataMember(Name = "shopperInteraction", EmitDefaultValue = false)]
        public ShopperInteractionEnum? shopperInteraction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckoutSessionResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCheckoutSessionResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckoutSessionResponse" /> class.
        /// </summary>
        /// <param name="accountInfo">accountInfo.</param>
        /// <param name="additionalAmount">additionalAmount.</param>
        /// <param name="additionalData">This field contains additional data, which may be required for a particular payment request.  The &#x60;additionalData&#x60; object consists of entries, each of which includes the key and value..</param>
        /// <param name="allowedPaymentMethods">List of payment methods to be presented to the shopper. To refer to payment methods, use their &#x60;paymentMethod.type&#x60;from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: &#x60;\&quot;allowedPaymentMethods\&quot;:[\&quot;ideal\&quot;,\&quot;giropay\&quot;]&#x60;.</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="applicationInfo">applicationInfo.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="blockedPaymentMethods">List of payment methods to be hidden from the shopper. To refer to payment methods, use their &#x60;paymentMethod.type&#x60;from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: &#x60;\&quot;blockedPaymentMethods\&quot;:[\&quot;ideal\&quot;,\&quot;giropay\&quot;]&#x60;.</param>
        /// <param name="captureDelayHours">The delay between the authorisation and scheduled auto-capture, specified in hours..</param>
        /// <param name="channel">The platform where a payment transaction takes place. This field is optional for filtering out payment methods that are only available on specific platforms. If this value is not set, then we will try to infer it from the &#x60;sdkVersion&#x60; or &#x60;token&#x60;.  Possible values: * iOS * Android * Web.</param>
        /// <param name="company">company.</param>
        /// <param name="countryCode">The shopper&#39;s two-letter country code..</param>
        /// <param name="dateOfBirth">The shopper&#39;s date of birth.  Format [ISO-8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DD.</param>
        /// <param name="deliveryAddress">deliveryAddress.</param>
        /// <param name="enableOneClick">When true and &#x60;shopperReference&#x60; is provided, the shopper will be asked if the payment details should be stored for future one-click payments..</param>
        /// <param name="enablePayOut">When true and &#x60;shopperReference&#x60; is provided, the payment details will be tokenized for payouts..</param>
        /// <param name="enableRecurring">When true and &#x60;shopperReference&#x60; is provided, the payment details will be tokenized for recurring payments..</param>
        /// <param name="expiresAt">The date the session expires in ISO8601 format. When not specified, it defaults to 1h after creation. (required).</param>
        /// <param name="lineItems">Price and product information about the purchased items, to be included on the invoice sent to the shopper. &gt; This field is required for 3x 4x Oney, Affirm, Afterpay, Clearpay, Klarna, Ratepay, and Zip..</param>
        /// <param name="mandate">mandate.</param>
        /// <param name="mcc">The [merchant category code](https://en.wikipedia.org/wiki/Merchant_category_code) (MCC) is a four-digit number, which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant..</param>
        /// <param name="merchantAccount">The merchant account identifier, with which you want to process the transaction. (required).</param>
        /// <param name="merchantOrderReference">This reference allows linking multiple transactions to each other for reporting purposes (i.e. order auth-rate). The reference should be unique per billing cycle. The same merchant order reference should never be reused after the first authorised attempt. If used, this field should be supplied for all incoming authorisations. &gt; We strongly recommend you send the &#x60;merchantOrderReference&#x60; value to benefit from linking payment requests when authorisation retries take place. In addition, we recommend you provide &#x60;retry.orderAttemptNumber&#x60;, &#x60;retry.chainAttemptNumber&#x60;, and &#x60;retry.skipRetry&#x60; values in &#x60;PaymentRequest.additionalData&#x60;..</param>
        /// <param name="metadata">Metadata consists of entries, each of which includes a key and a value. Limits: * Maximum 20 key-value pairs per request.* Maximum 20 characters per key. * Maximum 80 characters per value. .</param>
        /// <param name="mpiData">mpiData.</param>
        /// <param name="recurringExpiry">Date after which no further authorisations shall be performed. Only for 3D Secure 2..</param>
        /// <param name="recurringFrequency">Minimum number of days between authorisations. Only for 3D Secure 2..</param>
        /// <param name="recurringProcessingModel">Defines a recurring payment type. Allowed values: * &#x60;Subscription&#x60; – A transaction for a fixed or variable amount, which follows a fixed schedule. * &#x60;CardOnFile&#x60; – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * &#x60;UnscheduledCardOnFile&#x60; – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder&#39;s balance drops below a certain amount. .</param>
        /// <param name="redirectFromIssuerMethod">Specifies the redirect method (GET or POST) when redirecting back from the issuer..</param>
        /// <param name="redirectToIssuerMethod">Specifies the redirect method (GET or POST) when redirecting to the issuer..</param>
        /// <param name="reference">The reference to uniquely identify a payment. (required).</param>
        /// <param name="returnUrl">The URL to return to when a redirect payment is completed. (required).</param>
        /// <param name="riskData">riskData.</param>
        /// <param name="sessionData">sessionData.</param>
        /// <param name="shopperEmail">The shopper&#39;s email address..</param>
        /// <param name="shopperIP">The shopper&#39;s IP address. In general, we recommend that you provide this data, as it is used in a number of risk checks (for instance, number of payment attempts or location-based checks). &gt; For 3D Secure 2 transactions, schemes require &#x60;shopperIP&#x60; for all browser-based implementations. This field is also mandatory for some merchants depending on your business model. For more information, [contact Support](https://support.adyen.com/hc/en-us/requests/new)..</param>
        /// <param name="shopperInteraction">Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * &#x60;Ecommerce&#x60; - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * &#x60;ContAuth&#x60; - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * &#x60;Moto&#x60; - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * &#x60;POS&#x60; - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal..</param>
        /// <param name="shopperLocale">The combination of a language code and a country code to specify the language to be used in the payment..</param>
        /// <param name="shopperName">shopperName.</param>
        /// <param name="shopperReference">Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address..</param>
        /// <param name="shopperStatement">The text to be shown on the shopper&#39;s bank statement. To enable this field, contact our [Support Team](https://support.adyen.com/hc/en-us/requests/new).  We recommend sending a maximum of 22 characters, otherwise banks might truncate the string..</param>
        /// <param name="socialSecurityNumber">The shopper&#39;s social security number..</param>
        /// <param name="splitCardFundingSources">Boolean value indicating whether the card payment method should be split into separate debit and credit options. (default to false).</param>
        /// <param name="splits">An array of objects specifying how the payment should be split when using [Adyen for Platforms](https://docs.adyen.com/platforms/processing-payments#providing-split-information) or [Issuing](https://docs.adyen.com/issuing/manage-funds#split)..</param>
        /// <param name="storePaymentMethod">When this is set to **true** and the &#x60;shopperReference&#x60; is provided, the payment details will be stored..</param>
        /// <param name="telephoneNumber">The shopper&#39;s telephone number..</param>
        /// <param name="threeDSAuthenticationOnly">If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation. (default to false).</param>
        /// <param name="trustedShopper">Set to true if the payment should be routed to a trusted MID..</param>
        public CreateCheckoutSessionResponse(AccountInfo accountInfo = default(AccountInfo), Amount additionalAmount = default(Amount), Dictionary<string, string> additionalData = default(Dictionary<string, string>), List<string> allowedPaymentMethods = default(List<string>), Amount amount = default(Amount), ApplicationInfo applicationInfo = default(ApplicationInfo), Address billingAddress = default(Address), List<string> blockedPaymentMethods = default(List<string>), int captureDelayHours = default(int), ChannelEnum? channel = default(ChannelEnum?), Company company = default(Company), string countryCode = default(string), DateTime dateOfBirth = default(DateTime), Address deliveryAddress = default(Address), bool enableOneClick = default(bool), bool enablePayOut = default(bool), bool enableRecurring = default(bool), DateTime expiresAt = default(DateTime), List<LineItem> lineItems = default(List<LineItem>), Mandate mandate = default(Mandate), string mcc = default(string), string merchantAccount = default(string), string merchantOrderReference = default(string), Dictionary<string, string> metadata = default(Dictionary<string, string>), ThreeDSecureData mpiData = default(ThreeDSecureData), string recurringExpiry = default(string), string recurringFrequency = default(string), RecurringProcessingModelEnum? recurringProcessingModel = default(RecurringProcessingModelEnum?), string redirectFromIssuerMethod = default(string), string redirectToIssuerMethod = default(string), string reference = default(string), string returnUrl = default(string), RiskData riskData = default(RiskData), string sessionData = default(string), string shopperEmail = default(string), string shopperIP = default(string), ShopperInteractionEnum? shopperInteraction = default(ShopperInteractionEnum?), string shopperLocale = default(string), Name shopperName = default(Name), string shopperReference = default(string), string shopperStatement = default(string), string socialSecurityNumber = default(string), bool splitCardFundingSources = false, List<Split> splits = default(List<Split>), bool storePaymentMethod = default(bool), string telephoneNumber = default(string), bool threeDSAuthenticationOnly = false, bool trustedShopper = default(bool))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for CreateCheckoutSessionResponse and cannot be null");
            }
            else
            {
                this.amount = amount;
            }

            // to ensure "expiresAt" is required (not null)
            if (expiresAt == null)
            {
                throw new InvalidDataException("expiresAt is a required property for CreateCheckoutSessionResponse and cannot be null");
            }
            else
            {
                this.expiresAt = expiresAt;
            }

            // to ensure "merchantAccount" is required (not null)
            if (merchantAccount == null)
            {
                throw new InvalidDataException("merchantAccount is a required property for CreateCheckoutSessionResponse and cannot be null");
            }
            else
            {
                this.merchantAccount = merchantAccount;
            }

            // to ensure "reference" is required (not null)
            if (reference == null)
            {
                throw new InvalidDataException("reference is a required property for CreateCheckoutSessionResponse and cannot be null");
            }
            else
            {
                this.reference = reference;
            }

            // to ensure "returnUrl" is required (not null)
            if (returnUrl == null)
            {
                throw new InvalidDataException("returnUrl is a required property for CreateCheckoutSessionResponse and cannot be null");
            }
            else
            {
                this.returnUrl = returnUrl;
            }

            this.accountInfo = accountInfo;
            this.additionalAmount = additionalAmount;
            this.additionalData = additionalData;
            this.allowedPaymentMethods = allowedPaymentMethods;
            this.applicationInfo = applicationInfo;
            this.billingAddress = billingAddress;
            this.blockedPaymentMethods = blockedPaymentMethods;
            this.captureDelayHours = captureDelayHours;
            this.channel = channel;
            this.company = company;
            this.countryCode = countryCode;
            this.dateOfBirth = dateOfBirth;
            this.deliveryAddress = deliveryAddress;
            this.enableOneClick = enableOneClick;
            this.enablePayOut = enablePayOut;
            this.enableRecurring = enableRecurring;
            this.lineItems = lineItems;
            this.mandate = mandate;
            this.mcc = mcc;
            this.merchantOrderReference = merchantOrderReference;
            this.metadata = metadata;
            this.mpiData = mpiData;
            this.recurringExpiry = recurringExpiry;
            this.recurringFrequency = recurringFrequency;
            this.recurringProcessingModel = recurringProcessingModel;
            this.redirectFromIssuerMethod = redirectFromIssuerMethod;
            this.redirectToIssuerMethod = redirectToIssuerMethod;
            this.riskData = riskData;
            this.sessionData = sessionData;
            this.shopperEmail = shopperEmail;
            this.shopperIP = shopperIP;
            this.shopperInteraction = shopperInteraction;
            this.shopperLocale = shopperLocale;
            this.shopperName = shopperName;
            this.shopperReference = shopperReference;
            this.shopperStatement = shopperStatement;
            this.socialSecurityNumber = socialSecurityNumber;
            // use default value if no "splitCardFundingSources" provided
            if (splitCardFundingSources == null)
            {
                this.splitCardFundingSources = false;
            }
            else
            {
                this.splitCardFundingSources = splitCardFundingSources;
            }
            this.splits = splits;
            this.storePaymentMethod = storePaymentMethod;
            this.telephoneNumber = telephoneNumber;
            // use default value if no "threeDSAuthenticationOnly" provided
            if (threeDSAuthenticationOnly == null)
            {
                this.threeDSAuthenticationOnly = false;
            }
            else
            {
                this.threeDSAuthenticationOnly = threeDSAuthenticationOnly;
            }
            this.trustedShopper = trustedShopper;
        }

        /// <summary>
        /// Gets or Sets accountInfo
        /// </summary>
        [DataMember(Name = "accountInfo", EmitDefaultValue = false)]
        public AccountInfo accountInfo { get; set; }

        /// <summary>
        /// Gets or Sets additionalAmount
        /// </summary>
        [DataMember(Name = "additionalAmount", EmitDefaultValue = false)]
        public Amount additionalAmount { get; set; }

        /// <summary>
        /// This field contains additional data, which may be required for a particular payment request.  The &#x60;additionalData&#x60; object consists of entries, each of which includes the key and value.
        /// </summary>
        /// <value>This field contains additional data, which may be required for a particular payment request.  The &#x60;additionalData&#x60; object consists of entries, each of which includes the key and value.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        public Dictionary<string, string> additionalData { get; set; }

        /// <summary>
        /// List of payment methods to be presented to the shopper. To refer to payment methods, use their &#x60;paymentMethod.type&#x60;from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: &#x60;\&quot;allowedPaymentMethods\&quot;:[\&quot;ideal\&quot;,\&quot;giropay\&quot;]&#x60;
        /// </summary>
        /// <value>List of payment methods to be presented to the shopper. To refer to payment methods, use their &#x60;paymentMethod.type&#x60;from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: &#x60;\&quot;allowedPaymentMethods\&quot;:[\&quot;ideal\&quot;,\&quot;giropay\&quot;]&#x60;</value>
        [DataMember(Name = "allowedPaymentMethods", EmitDefaultValue = false)]
        public List<string> allowedPaymentMethods { get; set; }

        /// <summary>
        /// Gets or Sets amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = true)]
        public Amount amount { get; set; }

        /// <summary>
        /// Gets or Sets applicationInfo
        /// </summary>
        [DataMember(Name = "applicationInfo", EmitDefaultValue = false)]
        public ApplicationInfo applicationInfo { get; set; }

        /// <summary>
        /// Gets or Sets billingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public Address billingAddress { get; set; }

        /// <summary>
        /// List of payment methods to be hidden from the shopper. To refer to payment methods, use their &#x60;paymentMethod.type&#x60;from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: &#x60;\&quot;blockedPaymentMethods\&quot;:[\&quot;ideal\&quot;,\&quot;giropay\&quot;]&#x60;
        /// </summary>
        /// <value>List of payment methods to be hidden from the shopper. To refer to payment methods, use their &#x60;paymentMethod.type&#x60;from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: &#x60;\&quot;blockedPaymentMethods\&quot;:[\&quot;ideal\&quot;,\&quot;giropay\&quot;]&#x60;</value>
        [DataMember(Name = "blockedPaymentMethods", EmitDefaultValue = false)]
        public List<string> blockedPaymentMethods { get; set; }

        /// <summary>
        /// The delay between the authorisation and scheduled auto-capture, specified in hours.
        /// </summary>
        /// <value>The delay between the authorisation and scheduled auto-capture, specified in hours.</value>
        [DataMember(Name = "captureDelayHours", EmitDefaultValue = false)]
        public int captureDelayHours { get; set; }


        /// <summary>
        /// Gets or Sets company
        /// </summary>
        [DataMember(Name = "company", EmitDefaultValue = false)]
        public Company company { get; set; }

        /// <summary>
        /// The shopper&#39;s two-letter country code.
        /// </summary>
        /// <value>The shopper&#39;s two-letter country code.</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string countryCode { get; set; }

        /// <summary>
        /// The shopper&#39;s date of birth.  Format [ISO-8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DD
        /// </summary>
        /// <value>The shopper&#39;s date of birth.  Format [ISO-8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DD</value>
        [DataMember(Name = "dateOfBirth", EmitDefaultValue = false)]
        public DateTime dateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets deliveryAddress
        /// </summary>
        [DataMember(Name = "deliveryAddress", EmitDefaultValue = false)]
        public Address deliveryAddress { get; set; }

        /// <summary>
        /// When true and &#x60;shopperReference&#x60; is provided, the shopper will be asked if the payment details should be stored for future one-click payments.
        /// </summary>
        /// <value>When true and &#x60;shopperReference&#x60; is provided, the shopper will be asked if the payment details should be stored for future one-click payments.</value>
        [DataMember(Name = "enableOneClick", EmitDefaultValue = false)]
        public bool enableOneClick { get; set; }

        /// <summary>
        /// When true and &#x60;shopperReference&#x60; is provided, the payment details will be tokenized for payouts.
        /// </summary>
        /// <value>When true and &#x60;shopperReference&#x60; is provided, the payment details will be tokenized for payouts.</value>
        [DataMember(Name = "enablePayOut", EmitDefaultValue = false)]
        public bool enablePayOut { get; set; }

        /// <summary>
        /// When true and &#x60;shopperReference&#x60; is provided, the payment details will be tokenized for recurring payments.
        /// </summary>
        /// <value>When true and &#x60;shopperReference&#x60; is provided, the payment details will be tokenized for recurring payments.</value>
        [DataMember(Name = "enableRecurring", EmitDefaultValue = false)]
        public bool enableRecurring { get; set; }

        /// <summary>
        /// The date the session expires in ISO8601 format. When not specified, it defaults to 1h after creation.
        /// </summary>
        /// <value>The date the session expires in ISO8601 format. When not specified, it defaults to 1h after creation.</value>
        [DataMember(Name = "expiresAt", EmitDefaultValue = true)]
        public DateTime expiresAt { get; set; }

        /// <summary>
        /// A unique identifier of the session.
        /// </summary>
        /// <value>A unique identifier of the session.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string id { get; private set; }

        /// <summary>
        /// Price and product information about the purchased items, to be included on the invoice sent to the shopper. &gt; This field is required for 3x 4x Oney, Affirm, Afterpay, Clearpay, Klarna, Ratepay, and Zip.
        /// </summary>
        /// <value>Price and product information about the purchased items, to be included on the invoice sent to the shopper. &gt; This field is required for 3x 4x Oney, Affirm, Afterpay, Clearpay, Klarna, Ratepay, and Zip.</value>
        [DataMember(Name = "lineItems", EmitDefaultValue = false)]
        public List<LineItem> lineItems { get; set; }

        /// <summary>
        /// Gets or Sets mandate
        /// </summary>
        [DataMember(Name = "mandate", EmitDefaultValue = false)]
        public Mandate mandate { get; set; }

        /// <summary>
        /// The [merchant category code](https://en.wikipedia.org/wiki/Merchant_category_code) (MCC) is a four-digit number, which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant.
        /// </summary>
        /// <value>The [merchant category code](https://en.wikipedia.org/wiki/Merchant_category_code) (MCC) is a four-digit number, which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant.</value>
        [DataMember(Name = "mcc", EmitDefaultValue = false)]
        public string mcc { get; set; }

        /// <summary>
        /// The merchant account identifier, with which you want to process the transaction.
        /// </summary>
        /// <value>The merchant account identifier, with which you want to process the transaction.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = true)]
        public string merchantAccount { get; set; }

        /// <summary>
        /// This reference allows linking multiple transactions to each other for reporting purposes (i.e. order auth-rate). The reference should be unique per billing cycle. The same merchant order reference should never be reused after the first authorised attempt. If used, this field should be supplied for all incoming authorisations. &gt; We strongly recommend you send the &#x60;merchantOrderReference&#x60; value to benefit from linking payment requests when authorisation retries take place. In addition, we recommend you provide &#x60;retry.orderAttemptNumber&#x60;, &#x60;retry.chainAttemptNumber&#x60;, and &#x60;retry.skipRetry&#x60; values in &#x60;PaymentRequest.additionalData&#x60;.
        /// </summary>
        /// <value>This reference allows linking multiple transactions to each other for reporting purposes (i.e. order auth-rate). The reference should be unique per billing cycle. The same merchant order reference should never be reused after the first authorised attempt. If used, this field should be supplied for all incoming authorisations. &gt; We strongly recommend you send the &#x60;merchantOrderReference&#x60; value to benefit from linking payment requests when authorisation retries take place. In addition, we recommend you provide &#x60;retry.orderAttemptNumber&#x60;, &#x60;retry.chainAttemptNumber&#x60;, and &#x60;retry.skipRetry&#x60; values in &#x60;PaymentRequest.additionalData&#x60;.</value>
        [DataMember(Name = "merchantOrderReference", EmitDefaultValue = false)]
        public string merchantOrderReference { get; set; }

        /// <summary>
        /// Metadata consists of entries, each of which includes a key and a value. Limits: * Maximum 20 key-value pairs per request.* Maximum 20 characters per key. * Maximum 80 characters per value. 
        /// </summary>
        /// <value>Metadata consists of entries, each of which includes a key and a value. Limits: * Maximum 20 key-value pairs per request.* Maximum 20 characters per key. * Maximum 80 characters per value. </value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> metadata { get; set; }

        /// <summary>
        /// Gets or Sets mpiData
        /// </summary>
        [DataMember(Name = "mpiData", EmitDefaultValue = false)]
        public ThreeDSecureData mpiData { get; set; }

        /// <summary>
        /// Date after which no further authorisations shall be performed. Only for 3D Secure 2.
        /// </summary>
        /// <value>Date after which no further authorisations shall be performed. Only for 3D Secure 2.</value>
        [DataMember(Name = "recurringExpiry", EmitDefaultValue = false)]
        public string recurringExpiry { get; set; }

        /// <summary>
        /// Minimum number of days between authorisations. Only for 3D Secure 2.
        /// </summary>
        /// <value>Minimum number of days between authorisations. Only for 3D Secure 2.</value>
        [DataMember(Name = "recurringFrequency", EmitDefaultValue = false)]
        public string recurringFrequency { get; set; }


        /// <summary>
        /// Specifies the redirect method (GET or POST) when redirecting back from the issuer.
        /// </summary>
        /// <value>Specifies the redirect method (GET or POST) when redirecting back from the issuer.</value>
        [DataMember(Name = "redirectFromIssuerMethod", EmitDefaultValue = false)]
        public string redirectFromIssuerMethod { get; set; }

        /// <summary>
        /// Specifies the redirect method (GET or POST) when redirecting to the issuer.
        /// </summary>
        /// <value>Specifies the redirect method (GET or POST) when redirecting to the issuer.</value>
        [DataMember(Name = "redirectToIssuerMethod", EmitDefaultValue = false)]
        public string redirectToIssuerMethod { get; set; }

        /// <summary>
        /// The reference to uniquely identify a payment.
        /// </summary>
        /// <value>The reference to uniquely identify a payment.</value>
        [DataMember(Name = "reference", EmitDefaultValue = true)]
        public string reference { get; set; }

        /// <summary>
        /// The URL to return to when a redirect payment is completed.
        /// </summary>
        /// <value>The URL to return to when a redirect payment is completed.</value>
        [DataMember(Name = "returnUrl", EmitDefaultValue = true)]
        public string returnUrl { get; set; }

        /// <summary>
        /// Gets or Sets riskData
        /// </summary>
        [DataMember(Name = "riskData", EmitDefaultValue = false)]
        public RiskData riskData { get; set; }

        /// <summary>
        /// Gets or Sets sessionData
        /// </summary>
        [DataMember(Name = "sessionData", EmitDefaultValue = false)]
        public string sessionData { get; set; }

        /// <summary>
        /// The shopper&#39;s email address.
        /// </summary>
        /// <value>The shopper&#39;s email address.</value>
        [DataMember(Name = "shopperEmail", EmitDefaultValue = false)]
        public string shopperEmail { get; set; }

        /// <summary>
        /// The shopper&#39;s IP address. In general, we recommend that you provide this data, as it is used in a number of risk checks (for instance, number of payment attempts or location-based checks). &gt; For 3D Secure 2 transactions, schemes require &#x60;shopperIP&#x60; for all browser-based implementations. This field is also mandatory for some merchants depending on your business model. For more information, [contact Support](https://support.adyen.com/hc/en-us/requests/new).
        /// </summary>
        /// <value>The shopper&#39;s IP address. In general, we recommend that you provide this data, as it is used in a number of risk checks (for instance, number of payment attempts or location-based checks). &gt; For 3D Secure 2 transactions, schemes require &#x60;shopperIP&#x60; for all browser-based implementations. This field is also mandatory for some merchants depending on your business model. For more information, [contact Support](https://support.adyen.com/hc/en-us/requests/new).</value>
        [DataMember(Name = "shopperIP", EmitDefaultValue = false)]
        public string shopperIP { get; set; }


        /// <summary>
        /// The combination of a language code and a country code to specify the language to be used in the payment.
        /// </summary>
        /// <value>The combination of a language code and a country code to specify the language to be used in the payment.</value>
        [DataMember(Name = "shopperLocale", EmitDefaultValue = false)]
        public string shopperLocale { get; set; }

        /// <summary>
        /// Gets or Sets shopperName
        /// </summary>
        [DataMember(Name = "shopperName", EmitDefaultValue = false)]
        public Name shopperName { get; set; }

        /// <summary>
        /// Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address.
        /// </summary>
        /// <value>Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address.</value>
        [DataMember(Name = "shopperReference", EmitDefaultValue = false)]
        public string shopperReference { get; set; }

        /// <summary>
        /// The text to be shown on the shopper&#39;s bank statement. To enable this field, contact our [Support Team](https://support.adyen.com/hc/en-us/requests/new).  We recommend sending a maximum of 22 characters, otherwise banks might truncate the string.
        /// </summary>
        /// <value>The text to be shown on the shopper&#39;s bank statement. To enable this field, contact our [Support Team](https://support.adyen.com/hc/en-us/requests/new).  We recommend sending a maximum of 22 characters, otherwise banks might truncate the string.</value>
        [DataMember(Name = "shopperStatement", EmitDefaultValue = false)]
        public string shopperStatement { get; set; }

        /// <summary>
        /// The shopper&#39;s social security number.
        /// </summary>
        /// <value>The shopper&#39;s social security number.</value>
        [DataMember(Name = "socialSecurityNumber", EmitDefaultValue = false)]
        public string socialSecurityNumber { get; set; }

        /// <summary>
        /// Boolean value indicating whether the card payment method should be split into separate debit and credit options.
        /// </summary>
        /// <value>Boolean value indicating whether the card payment method should be split into separate debit and credit options.</value>
        [DataMember(Name = "splitCardFundingSources", EmitDefaultValue = false)]
        public bool splitCardFundingSources { get; set; }

        /// <summary>
        /// An array of objects specifying how the payment should be split when using [Adyen for Platforms](https://docs.adyen.com/platforms/processing-payments#providing-split-information) or [Issuing](https://docs.adyen.com/issuing/manage-funds#split).
        /// </summary>
        /// <value>An array of objects specifying how the payment should be split when using [Adyen for Platforms](https://docs.adyen.com/platforms/processing-payments#providing-split-information) or [Issuing](https://docs.adyen.com/issuing/manage-funds#split).</value>
        [DataMember(Name = "splits", EmitDefaultValue = false)]
        public List<Split> splits { get; set; }

        /// <summary>
        /// When this is set to **true** and the &#x60;shopperReference&#x60; is provided, the payment details will be stored.
        /// </summary>
        /// <value>When this is set to **true** and the &#x60;shopperReference&#x60; is provided, the payment details will be stored.</value>
        [DataMember(Name = "storePaymentMethod", EmitDefaultValue = false)]
        public bool storePaymentMethod { get; set; }

        /// <summary>
        /// The shopper&#39;s telephone number.
        /// </summary>
        /// <value>The shopper&#39;s telephone number.</value>
        [DataMember(Name = "telephoneNumber", EmitDefaultValue = false)]
        public string telephoneNumber { get; set; }

        /// <summary>
        /// If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation.
        /// </summary>
        /// <value>If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation.</value>
        [DataMember(Name = "threeDSAuthenticationOnly", EmitDefaultValue = false)]
        public bool threeDSAuthenticationOnly { get; set; }

        /// <summary>
        /// Set to true if the payment should be routed to a trusted MID.
        /// </summary>
        /// <value>Set to true if the payment should be routed to a trusted MID.</value>
        [DataMember(Name = "trustedShopper", EmitDefaultValue = false)]
        public bool trustedShopper { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCheckoutSessionResponse {\n");
            sb.Append("  accountInfo: ").Append(accountInfo).Append("\n");
            sb.Append("  additionalAmount: ").Append(additionalAmount).Append("\n");
            sb.Append("  additionalData: ").Append(additionalData.ToCollectionsString()).Append("\n");
            sb.Append("  allowedPaymentMethods: ").Append(allowedPaymentMethods).Append("\n");
            sb.Append("  amount: ").Append(amount).Append("\n");
            sb.Append("  applicationInfo: ").Append(applicationInfo).Append("\n");
            sb.Append("  billingAddress: ").Append(billingAddress).Append("\n");
            sb.Append("  blockedPaymentMethods: ").Append(blockedPaymentMethods).Append("\n");
            sb.Append("  captureDelayHours: ").Append(captureDelayHours).Append("\n");
            sb.Append("  channel: ").Append(channel).Append("\n");
            sb.Append("  company: ").Append(company).Append("\n");
            sb.Append("  countryCode: ").Append(countryCode).Append("\n");
            sb.Append("  dateOfBirth: ").Append(dateOfBirth).Append("\n");
            sb.Append("  deliveryAddress: ").Append(deliveryAddress).Append("\n");
            sb.Append("  enableOneClick: ").Append(enableOneClick).Append("\n");
            sb.Append("  enablePayOut: ").Append(enablePayOut).Append("\n");
            sb.Append("  enableRecurring: ").Append(enableRecurring).Append("\n");
            sb.Append("  expiresAt: ").Append(expiresAt).Append("\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  lineItems: ").Append(lineItems).Append("\n");
            sb.Append("  mandate: ").Append(mandate).Append("\n");
            sb.Append("  mcc: ").Append(mcc).Append("\n");
            sb.Append("  merchantAccount: ").Append(merchantAccount).Append("\n");
            sb.Append("  merchantOrderReference: ").Append(merchantOrderReference).Append("\n");
            sb.Append("  metadata: ").Append(metadata).Append("\n");
            sb.Append("  mpiData: ").Append(mpiData).Append("\n");
            sb.Append("  recurringExpiry: ").Append(recurringExpiry).Append("\n");
            sb.Append("  recurringFrequency: ").Append(recurringFrequency).Append("\n");
            sb.Append("  recurringProcessingModel: ").Append(recurringProcessingModel).Append("\n");
            sb.Append("  redirectFromIssuerMethod: ").Append(redirectFromIssuerMethod).Append("\n");
            sb.Append("  redirectToIssuerMethod: ").Append(redirectToIssuerMethod).Append("\n");
            sb.Append("  reference: ").Append(reference).Append("\n");
            sb.Append("  returnUrl: ").Append(returnUrl).Append("\n");
            sb.Append("  riskData: ").Append(riskData).Append("\n");
            sb.Append("  sessionData: ").Append(sessionData).Append("\n");
            sb.Append("  shopperEmail: ").Append(shopperEmail).Append("\n");
            sb.Append("  shopperIP: ").Append(shopperIP).Append("\n");
            sb.Append("  shopperInteraction: ").Append(shopperInteraction).Append("\n");
            sb.Append("  shopperLocale: ").Append(shopperLocale).Append("\n");
            sb.Append("  shopperName: ").Append(shopperName).Append("\n");
            sb.Append("  shopperReference: ").Append(shopperReference).Append("\n");
            sb.Append("  shopperStatement: ").Append(shopperStatement).Append("\n");
            sb.Append("  socialSecurityNumber: ").Append(socialSecurityNumber).Append("\n");
            sb.Append("  splitCardFundingSources: ").Append(splitCardFundingSources).Append("\n");
            sb.Append("  splits: ").Append(splits).Append("\n");
            sb.Append("  storePaymentMethod: ").Append(storePaymentMethod).Append("\n");
            sb.Append("  telephoneNumber: ").Append(telephoneNumber).Append("\n");
            sb.Append("  threeDSAuthenticationOnly: ").Append(threeDSAuthenticationOnly).Append("\n");
            sb.Append("  trustedShopper: ").Append(trustedShopper).Append("\n");
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
            return this.Equals(input as CreateCheckoutSessionResponse);
        }

        /// <summary>
        /// Returns true if CreateCheckoutSessionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCheckoutSessionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCheckoutSessionResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.accountInfo == input.accountInfo ||
                    (this.accountInfo != null &&
                    this.accountInfo.Equals(input.accountInfo))
                ) &&
                (
                    this.additionalAmount == input.additionalAmount ||
                    (this.additionalAmount != null &&
                    this.additionalAmount.Equals(input.additionalAmount))
                ) &&
                (
                    this.additionalData == input.additionalData ||
                    this.additionalData != null &&
                    input.additionalData != null &&
                    this.additionalData.SequenceEqual(input.additionalData)
                ) &&
                (
                    this.allowedPaymentMethods == input.allowedPaymentMethods ||
                    this.allowedPaymentMethods != null &&
                    input.allowedPaymentMethods != null &&
                    this.allowedPaymentMethods.SequenceEqual(input.allowedPaymentMethods)
                ) &&
                (
                    this.amount == input.amount ||
                    (this.amount != null &&
                    this.amount.Equals(input.amount))
                ) &&
                (
                    this.applicationInfo == input.applicationInfo ||
                    (this.applicationInfo != null &&
                    this.applicationInfo.Equals(input.applicationInfo))
                ) &&
                (
                    this.billingAddress == input.billingAddress ||
                    (this.billingAddress != null &&
                    this.billingAddress.Equals(input.billingAddress))
                ) &&
                (
                    this.blockedPaymentMethods == input.blockedPaymentMethods ||
                    this.blockedPaymentMethods != null &&
                    input.blockedPaymentMethods != null &&
                    this.blockedPaymentMethods.SequenceEqual(input.blockedPaymentMethods)
                ) &&
                (
                    this.captureDelayHours == input.captureDelayHours ||
                    (this.captureDelayHours != null &&
                    this.captureDelayHours.Equals(input.captureDelayHours))
                ) &&
                (
                    this.channel == input.channel ||
                    (this.channel != null &&
                    this.channel.Equals(input.channel))
                ) &&
                (
                    this.company == input.company ||
                    (this.company != null &&
                    this.company.Equals(input.company))
                ) &&
                (
                    this.countryCode == input.countryCode ||
                    (this.countryCode != null &&
                    this.countryCode.Equals(input.countryCode))
                ) &&
                (
                    this.dateOfBirth == input.dateOfBirth ||
                    (this.dateOfBirth != null &&
                    this.dateOfBirth.Equals(input.dateOfBirth))
                ) &&
                (
                    this.deliveryAddress == input.deliveryAddress ||
                    (this.deliveryAddress != null &&
                    this.deliveryAddress.Equals(input.deliveryAddress))
                ) &&
                (
                    this.enableOneClick == input.enableOneClick ||
                    (this.enableOneClick != null &&
                    this.enableOneClick.Equals(input.enableOneClick))
                ) &&
                (
                    this.enablePayOut == input.enablePayOut ||
                    (this.enablePayOut != null &&
                    this.enablePayOut.Equals(input.enablePayOut))
                ) &&
                (
                    this.enableRecurring == input.enableRecurring ||
                    (this.enableRecurring != null &&
                    this.enableRecurring.Equals(input.enableRecurring))
                ) &&
                (
                    this.expiresAt == input.expiresAt ||
                    (this.expiresAt != null &&
                    this.expiresAt.Equals(input.expiresAt))
                ) &&
                (
                    this.id == input.id ||
                    (this.id != null &&
                    this.id.Equals(input.id))
                ) &&
                (
                    this.lineItems == input.lineItems ||
                    this.lineItems != null &&
                    input.lineItems != null &&
                    this.lineItems.SequenceEqual(input.lineItems)
                ) &&
                (
                    this.mandate == input.mandate ||
                    (this.mandate != null &&
                    this.mandate.Equals(input.mandate))
                ) &&
                (
                    this.mcc == input.mcc ||
                    (this.mcc != null &&
                    this.mcc.Equals(input.mcc))
                ) &&
                (
                    this.merchantAccount == input.merchantAccount ||
                    (this.merchantAccount != null &&
                    this.merchantAccount.Equals(input.merchantAccount))
                ) &&
                (
                    this.merchantOrderReference == input.merchantOrderReference ||
                    (this.merchantOrderReference != null &&
                    this.merchantOrderReference.Equals(input.merchantOrderReference))
                ) &&
                (
                    this.metadata == input.metadata ||
                    this.metadata != null &&
                    input.metadata != null &&
                    this.metadata.SequenceEqual(input.metadata)
                ) &&
                (
                    this.mpiData == input.mpiData ||
                    (this.mpiData != null &&
                    this.mpiData.Equals(input.mpiData))
                ) &&
                (
                    this.recurringExpiry == input.recurringExpiry ||
                    (this.recurringExpiry != null &&
                    this.recurringExpiry.Equals(input.recurringExpiry))
                ) &&
                (
                    this.recurringFrequency == input.recurringFrequency ||
                    (this.recurringFrequency != null &&
                    this.recurringFrequency.Equals(input.recurringFrequency))
                ) &&
                (
                    this.recurringProcessingModel == input.recurringProcessingModel ||
                    (this.recurringProcessingModel != null &&
                    this.recurringProcessingModel.Equals(input.recurringProcessingModel))
                ) &&
                (
                    this.redirectFromIssuerMethod == input.redirectFromIssuerMethod ||
                    (this.redirectFromIssuerMethod != null &&
                    this.redirectFromIssuerMethod.Equals(input.redirectFromIssuerMethod))
                ) &&
                (
                    this.redirectToIssuerMethod == input.redirectToIssuerMethod ||
                    (this.redirectToIssuerMethod != null &&
                    this.redirectToIssuerMethod.Equals(input.redirectToIssuerMethod))
                ) &&
                (
                    this.reference == input.reference ||
                    (this.reference != null &&
                    this.reference.Equals(input.reference))
                ) &&
                (
                    this.returnUrl == input.returnUrl ||
                    (this.returnUrl != null &&
                    this.returnUrl.Equals(input.returnUrl))
                ) &&
                (
                    this.riskData == input.riskData ||
                    (this.riskData != null &&
                    this.riskData.Equals(input.riskData))
                ) &&
                (
                    this.sessionData == input.sessionData ||
                    (this.sessionData != null &&
                    this.sessionData.Equals(input.sessionData))
                ) &&
                (
                    this.shopperEmail == input.shopperEmail ||
                    (this.shopperEmail != null &&
                    this.shopperEmail.Equals(input.shopperEmail))
                ) &&
                (
                    this.shopperIP == input.shopperIP ||
                    (this.shopperIP != null &&
                    this.shopperIP.Equals(input.shopperIP))
                ) &&
                (
                    this.shopperInteraction == input.shopperInteraction ||
                    (this.shopperInteraction != null &&
                    this.shopperInteraction.Equals(input.shopperInteraction))
                ) &&
                (
                    this.shopperLocale == input.shopperLocale ||
                    (this.shopperLocale != null &&
                    this.shopperLocale.Equals(input.shopperLocale))
                ) &&
                (
                    this.shopperName == input.shopperName ||
                    (this.shopperName != null &&
                    this.shopperName.Equals(input.shopperName))
                ) &&
                (
                    this.shopperReference == input.shopperReference ||
                    (this.shopperReference != null &&
                    this.shopperReference.Equals(input.shopperReference))
                ) &&
                (
                    this.shopperStatement == input.shopperStatement ||
                    (this.shopperStatement != null &&
                    this.shopperStatement.Equals(input.shopperStatement))
                ) &&
                (
                    this.socialSecurityNumber == input.socialSecurityNumber ||
                    (this.socialSecurityNumber != null &&
                    this.socialSecurityNumber.Equals(input.socialSecurityNumber))
                ) &&
                (
                    this.splitCardFundingSources == input.splitCardFundingSources ||
                    (this.splitCardFundingSources != null &&
                    this.splitCardFundingSources.Equals(input.splitCardFundingSources))
                ) &&
                (
                    this.splits == input.splits ||
                    this.splits != null &&
                    input.splits != null &&
                    this.splits.SequenceEqual(input.splits)
                ) &&
                (
                    this.storePaymentMethod == input.storePaymentMethod ||
                    (this.storePaymentMethod != null &&
                    this.storePaymentMethod.Equals(input.storePaymentMethod))
                ) &&
                (
                    this.telephoneNumber == input.telephoneNumber ||
                    (this.telephoneNumber != null &&
                    this.telephoneNumber.Equals(input.telephoneNumber))
                ) &&
                (
                    this.threeDSAuthenticationOnly == input.threeDSAuthenticationOnly ||
                    (this.threeDSAuthenticationOnly != null &&
                    this.threeDSAuthenticationOnly.Equals(input.threeDSAuthenticationOnly))
                ) &&
                (
                    this.trustedShopper == input.trustedShopper ||
                    (this.trustedShopper != null &&
                    this.trustedShopper.Equals(input.trustedShopper))
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
                if (this.accountInfo != null)
                    hashCode = hashCode * 59 + this.accountInfo.GetHashCode();
                if (this.additionalAmount != null)
                    hashCode = hashCode * 59 + this.additionalAmount.GetHashCode();
                if (this.additionalData != null)
                    hashCode = hashCode * 59 + this.additionalData.GetHashCode();
                if (this.allowedPaymentMethods != null)
                    hashCode = hashCode * 59 + this.allowedPaymentMethods.GetHashCode();
                if (this.amount != null)
                    hashCode = hashCode * 59 + this.amount.GetHashCode();
                if (this.applicationInfo != null)
                    hashCode = hashCode * 59 + this.applicationInfo.GetHashCode();
                if (this.billingAddress != null)
                    hashCode = hashCode * 59 + this.billingAddress.GetHashCode();
                if (this.blockedPaymentMethods != null)
                    hashCode = hashCode * 59 + this.blockedPaymentMethods.GetHashCode();
                if (this.captureDelayHours != null)
                    hashCode = hashCode * 59 + this.captureDelayHours.GetHashCode();
                if (this.channel != null)
                    hashCode = hashCode * 59 + this.channel.GetHashCode();
                if (this.company != null)
                    hashCode = hashCode * 59 + this.company.GetHashCode();
                if (this.countryCode != null)
                    hashCode = hashCode * 59 + this.countryCode.GetHashCode();
                if (this.dateOfBirth != null)
                    hashCode = hashCode * 59 + this.dateOfBirth.GetHashCode();
                if (this.deliveryAddress != null)
                    hashCode = hashCode * 59 + this.deliveryAddress.GetHashCode();
                if (this.enableOneClick != null)
                    hashCode = hashCode * 59 + this.enableOneClick.GetHashCode();
                if (this.enablePayOut != null)
                    hashCode = hashCode * 59 + this.enablePayOut.GetHashCode();
                if (this.enableRecurring != null)
                    hashCode = hashCode * 59 + this.enableRecurring.GetHashCode();
                if (this.expiresAt != null)
                    hashCode = hashCode * 59 + this.expiresAt.GetHashCode();
                if (this.id != null)
                    hashCode = hashCode * 59 + this.id.GetHashCode();
                if (this.lineItems != null)
                    hashCode = hashCode * 59 + this.lineItems.GetHashCode();
                if (this.mandate != null)
                    hashCode = hashCode * 59 + this.mandate.GetHashCode();
                if (this.mcc != null)
                    hashCode = hashCode * 59 + this.mcc.GetHashCode();
                if (this.merchantAccount != null)
                    hashCode = hashCode * 59 + this.merchantAccount.GetHashCode();
                if (this.merchantOrderReference != null)
                    hashCode = hashCode * 59 + this.merchantOrderReference.GetHashCode();
                if (this.metadata != null)
                    hashCode = hashCode * 59 + this.metadata.GetHashCode();
                if (this.mpiData != null)
                    hashCode = hashCode * 59 + this.mpiData.GetHashCode();
                if (this.recurringExpiry != null)
                    hashCode = hashCode * 59 + this.recurringExpiry.GetHashCode();
                if (this.recurringFrequency != null)
                    hashCode = hashCode * 59 + this.recurringFrequency.GetHashCode();
                if (this.recurringProcessingModel != null)
                    hashCode = hashCode * 59 + this.recurringProcessingModel.GetHashCode();
                if (this.redirectFromIssuerMethod != null)
                    hashCode = hashCode * 59 + this.redirectFromIssuerMethod.GetHashCode();
                if (this.redirectToIssuerMethod != null)
                    hashCode = hashCode * 59 + this.redirectToIssuerMethod.GetHashCode();
                if (this.reference != null)
                    hashCode = hashCode * 59 + this.reference.GetHashCode();
                if (this.returnUrl != null)
                    hashCode = hashCode * 59 + this.returnUrl.GetHashCode();
                if (this.riskData != null)
                    hashCode = hashCode * 59 + this.riskData.GetHashCode();
                if (this.sessionData != null)
                    hashCode = hashCode * 59 + this.sessionData.GetHashCode();
                if (this.shopperEmail != null)
                    hashCode = hashCode * 59 + this.shopperEmail.GetHashCode();
                if (this.shopperIP != null)
                    hashCode = hashCode * 59 + this.shopperIP.GetHashCode();
                if (this.shopperInteraction != null)
                    hashCode = hashCode * 59 + this.shopperInteraction.GetHashCode();
                if (this.shopperLocale != null)
                    hashCode = hashCode * 59 + this.shopperLocale.GetHashCode();
                if (this.shopperName != null)
                    hashCode = hashCode * 59 + this.shopperName.GetHashCode();
                if (this.shopperReference != null)
                    hashCode = hashCode * 59 + this.shopperReference.GetHashCode();
                if (this.shopperStatement != null)
                    hashCode = hashCode * 59 + this.shopperStatement.GetHashCode();
                if (this.socialSecurityNumber != null)
                    hashCode = hashCode * 59 + this.socialSecurityNumber.GetHashCode();
                if (this.splitCardFundingSources != null)
                    hashCode = hashCode * 59 + this.splitCardFundingSources.GetHashCode();
                if (this.splits != null)
                    hashCode = hashCode * 59 + this.splits.GetHashCode();
                if (this.storePaymentMethod != null)
                    hashCode = hashCode * 59 + this.storePaymentMethod.GetHashCode();
                if (this.telephoneNumber != null)
                    hashCode = hashCode * 59 + this.telephoneNumber.GetHashCode();
                if (this.threeDSAuthenticationOnly != null)
                    hashCode = hashCode * 59 + this.threeDSAuthenticationOnly.GetHashCode();
                if (this.trustedShopper != null)
                    hashCode = hashCode * 59 + this.trustedShopper.GetHashCode();
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
