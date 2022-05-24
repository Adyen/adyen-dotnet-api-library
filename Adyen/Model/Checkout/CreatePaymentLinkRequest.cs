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
using Adyen.Model.ApplicationInformation;
using Adyen.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
   /// <summary>
    /// CreatePaymentLinkRequest
    /// </summary>
    [DataContract]
        public partial class CreatePaymentLinkRequest :  IEquatable<CreatePaymentLinkRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines a recurring payment type. Possible values: * **Subscription** – A transaction for a fixed or variable amount, which follows a fixed schedule. * **CardOnFile** – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * **UnscheduledCardOnFile** – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or has variable amounts. For example, automatic top-ups when a cardholder&#x27;s balance drops below a certain amount. 
        /// </summary>
        /// <value>Defines a recurring payment type. Possible values: * **Subscription** – A transaction for a fixed or variable amount, which follows a fixed schedule. * **CardOnFile** – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * **UnscheduledCardOnFile** – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or has variable amounts. For example, automatic top-ups when a cardholder&#x27;s balance drops below a certain amount. </value>
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
            UnscheduledCardOnFile = 3        }
        /// <summary>
        /// Defines a recurring payment type. Possible values: * **Subscription** – A transaction for a fixed or variable amount, which follows a fixed schedule. * **CardOnFile** – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * **UnscheduledCardOnFile** – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or has variable amounts. For example, automatic top-ups when a cardholder&#x27;s balance drops below a certain amount. 
        /// </summary>
        /// <value>Defines a recurring payment type. Possible values: * **Subscription** – A transaction for a fixed or variable amount, which follows a fixed schedule. * **CardOnFile** – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * **UnscheduledCardOnFile** – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or has variable amounts. For example, automatic top-ups when a cardholder&#x27;s balance drops below a certain amount. </value>
        [DataMember(Name="recurringProcessingModel", EmitDefaultValue=false)]
        public RecurringProcessingModelEnum? RecurringProcessingModel { get; set; }
        /// <summary>
        /// Defines RequiredShopperFields
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum RequiredShopperFieldsEnum
        {
            /// <summary>
            /// Enum BillingAddress for value: billingAddress
            /// </summary>
            [EnumMember(Value = "billingAddress")]
            BillingAddress = 1,
            /// <summary>
            /// Enum DeliveryAddress for value: deliveryAddress
            /// </summary>
            [EnumMember(Value = "deliveryAddress")]
            DeliveryAddress = 2,
            /// <summary>
            /// Enum ShopperEmail for value: shopperEmail
            /// </summary>
            [EnumMember(Value = "shopperEmail")]
            ShopperEmail = 3,
            /// <summary>
            /// Enum ShopperName for value: shopperName
            /// </summary>
            [EnumMember(Value = "shopperName")]
            ShopperName = 4,
            /// <summary>
            /// Enum TelephoneNumber for value: telephoneNumber
            /// </summary>
            [EnumMember(Value = "telephoneNumber")]
            TelephoneNumber = 5        }
        /// <summary>
        /// List of fields that the shopper has to provide on the payment page before completing the payment. For more information, refer to [Provide shopper information](https://docs.adyen.com/unified-commerce/pay-by-link/payment-links/api#shopper-information).  Possible values: * **billingAddress** – The address where to send the invoice. * **deliveryAddress** – The address where the purchased goods should be delivered. * **shopperEmail** – The shopper&#x27;s email address. * **shopperName** – The shopper&#x27;s full name. * **telephoneNumber** – The shopper&#x27;s phone number. 
        /// </summary>
        /// <value>List of fields that the shopper has to provide on the payment page before completing the payment. For more information, refer to [Provide shopper information](https://docs.adyen.com/unified-commerce/pay-by-link/payment-links/api#shopper-information).  Possible values: * **billingAddress** – The address where to send the invoice. * **deliveryAddress** – The address where the purchased goods should be delivered. * **shopperEmail** – The shopper&#x27;s email address. * **shopperName** – The shopper&#x27;s full name. * **telephoneNumber** – The shopper&#x27;s phone number. </value>
        [DataMember(Name="requiredShopperFields", EmitDefaultValue=false)]
        public List<RequiredShopperFieldsEnum> RequiredShopperFields { get; set; }
        /// <summary>
        /// Indicates if the details of the payment method will be stored for the shopper. Possible values: * **disabled** – No details will be stored (default). * **askForConsent** – If the &#x60;shopperReference&#x60; is provided, the UI lets the shopper choose if they want their payment details to be stored. * **enabled** – If the &#x60;shopperReference&#x60; is provided, the details will be stored without asking the shopper for consent.
        /// </summary>
        /// <value>Indicates if the details of the payment method will be stored for the shopper. Possible values: * **disabled** – No details will be stored (default). * **askForConsent** – If the &#x60;shopperReference&#x60; is provided, the UI lets the shopper choose if they want their payment details to be stored. * **enabled** – If the &#x60;shopperReference&#x60; is provided, the details will be stored without asking the shopper for consent.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StorePaymentMethodModeEnum
        {
            /// <summary>
            /// Enum AskForConsent for value: askForConsent
            /// </summary>
            [EnumMember(Value = "askForConsent")]
            AskForConsent = 1,
            /// <summary>
            /// Enum Disabled for value: disabled
            /// </summary>
            [EnumMember(Value = "disabled")]
            Disabled = 2,
            /// <summary>
            /// Enum Enabled for value: enabled
            /// </summary>
            [EnumMember(Value = "enabled")]
            Enabled = 3        }
        /// <summary>
        /// Indicates if the details of the payment method will be stored for the shopper. Possible values: * **disabled** – No details will be stored (default). * **askForConsent** – If the &#x60;shopperReference&#x60; is provided, the UI lets the shopper choose if they want their payment details to be stored. * **enabled** – If the &#x60;shopperReference&#x60; is provided, the details will be stored without asking the shopper for consent.
        /// </summary>
        /// <value>Indicates if the details of the payment method will be stored for the shopper. Possible values: * **disabled** – No details will be stored (default). * **askForConsent** – If the &#x60;shopperReference&#x60; is provided, the UI lets the shopper choose if they want their payment details to be stored. * **enabled** – If the &#x60;shopperReference&#x60; is provided, the details will be stored without asking the shopper for consent.</value>
        [DataMember(Name="storePaymentMethodMode", EmitDefaultValue=false)]
        public StorePaymentMethodModeEnum? StorePaymentMethodMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentLinkRequest" /> class.
        /// </summary>
        /// <param name="allowedPaymentMethods">List of payment methods to be presented to the shopper. To refer to payment methods, use their &#x60;paymentMethod.type&#x60; from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: &#x60;\&quot;allowedPaymentMethods\&quot;:[\&quot;ideal\&quot;,\&quot;giropay\&quot;]&#x60;.</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="applicationInfo">applicationInfo.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="blockedPaymentMethods">List of payment methods to be hidden from the shopper. To refer to payment methods, use their &#x60;paymentMethod.type&#x60; from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: &#x60;\&quot;blockedPaymentMethods\&quot;:[\&quot;ideal\&quot;,\&quot;giropay\&quot;]&#x60;.</param>
        /// <param name="captureDelayHours">The delay between the authorisation and scheduled auto-capture, specified in hours..</param>
        /// <param name="countryCode">The shopper&#x27;s two-letter country code..</param>
        /// <param name="dateOfBirth">The shopper&#x27;s date of birth.  Format [ISO-8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DD.</param>
        /// <param name="deliverAt">The date and time when the purchased goods should be delivered.  [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format: YYYY-MM-DDThh:mm:ss+TZD, for example, **2020-12-18T10:15:30+01:00**..</param>
        /// <param name="deliveryAddress">deliveryAddress.</param>
        /// <param name="description">A short description visible on the payment page. Maximum length: 280 characters..</param>
        /// <param name="expiresAt">The date when the payment link expires.  [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format: YYYY-MM-DDThh:mm:ss+TZD, for example, **2020-12-18T10:15:30+01:00**.  The maximum expiry date is 70 days after the payment link is created.  If not provided, the payment link expires 24 hours after it was created..</param>
        /// <param name="installmentOptions">A set of key-value pairs that specifies the installment options available per payment method. The key must be a payment method name in lowercase. For example, **card** to specify installment options for all cards, or **visa** or **mc**. The value must be an object containing the installment options..</param>
        /// <param name="lineItems">Price and product information about the purchased items, to be included on the invoice sent to the shopper. This parameter is required for open invoice (_buy now, pay later_) payment methods such Afterpay, Clearpay, Klarna, RatePay, and Zip..</param>
        /// <param name="mcc">The [merchant category code](https://en.wikipedia.org/wiki/Merchant_category_code) (MCC) is a four-digit number, which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant..</param>
        /// <param name="merchantAccount">The merchant account identifier for which the payment link is created. (required).</param>
        /// <param name="merchantOrderReference">This reference allows linking multiple transactions to each other for reporting purposes (for example, order auth-rate). The reference should be unique per billing cycle..</param>
        /// <param name="metadata">Metadata consists of entries, each of which includes a key and a value. Limitations: * Maximum 20 key-value pairs per request. Otherwise, error \&quot;177\&quot; occurs: \&quot;Metadata size exceeds limit\&quot; * Maximum 20 characters per key. Otherwise, error \&quot;178\&quot; occurs: \&quot;Metadata key size exceeds limit\&quot; * A key cannot have the name &#x60;checkout.linkId&#x60;. Any value that you provide with this key is going to be replaced by the real payment link ID..</param>
        /// <param name="recurringProcessingModel">Defines a recurring payment type. Possible values: * **Subscription** – A transaction for a fixed or variable amount, which follows a fixed schedule. * **CardOnFile** – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * **UnscheduledCardOnFile** – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or has variable amounts. For example, automatic top-ups when a cardholder&#x27;s balance drops below a certain amount. .</param>
        /// <param name="reference">A reference that is used to uniquely identify the payment in future communications about the payment status. (required).</param>
        /// <param name="requiredShopperFields">List of fields that the shopper has to provide on the payment page before completing the payment. For more information, refer to [Provide shopper information](https://docs.adyen.com/unified-commerce/pay-by-link/payment-links/api#shopper-information).  Possible values: * **billingAddress** – The address where to send the invoice. * **deliveryAddress** – The address where the purchased goods should be delivered. * **shopperEmail** – The shopper&#x27;s email address. * **shopperName** – The shopper&#x27;s full name. * **telephoneNumber** – The shopper&#x27;s phone number. .</param>
        /// <param name="returnUrl">Website URL used for redirection after payment is completed. If provided, a **Continue** button will be shown on the payment page. If shoppers select the button, they are redirected to the specified URL..</param>
        /// <param name="reusable">Indicates whether the payment link can be reused for multiple payments. If not provided, this defaults to **false** which means the link can be used for one successful payment only..</param>
        /// <param name="riskData">riskData.</param>
        /// <param name="shopperEmail">The shopper&#x27;s email address..</param>
        /// <param name="shopperLocale">The language to be used in the payment page, specified by a combination of a language and country code. For example, &#x60;en-US&#x60;.  For a list of shopper locales that Pay by Link supports, refer to [Language and localization](https://docs.adyen.com/online-payments/pay-by-link#language-and-localization)..</param>
        /// <param name="shopperName">shopperName.</param>
        /// <param name="shopperReference">Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address..</param>
        /// <param name="shopperStatement">The text to be shown on the shopper&#x27;s bank statement.  We recommend sending a maximum of 22 characters, otherwise banks might truncate the string.  Allowed characters: **a-z**, **A-Z**, **0-9**, spaces, and special characters **. , &#x27; _ - ? + * /_**..</param>
        /// <param name="socialSecurityNumber">The shopper&#x27;s social security number..</param>
        /// <param name="splitCardFundingSources">Boolean value indicating whether the card payment method should be split into separate debit and credit options. (default to false).</param>
        /// <param name="splits">An array of objects specifying how the payment should be split between accounts when using Adyen for Platforms. For details, refer to [Providing split information](https://docs.adyen.com/platforms/processing-payments#providing-split-information)..</param>
        /// <param name="store">The physical store, for which this payment is processed..</param>
        /// <param name="storePaymentMethodMode">Indicates if the details of the payment method will be stored for the shopper. Possible values: * **disabled** – No details will be stored (default). * **askForConsent** – If the &#x60;shopperReference&#x60; is provided, the UI lets the shopper choose if they want their payment details to be stored. * **enabled** – If the &#x60;shopperReference&#x60; is provided, the details will be stored without asking the shopper for consent..</param>
        /// <param name="telephoneNumber">The shopper&#x27;s telephone number..</param>
        /// <param name="themeId">A [theme](https://docs.adyen.com/unified-commerce/pay-by-link/api#themes) to customize the appearance of the payment page. If not specified, the payment page is rendered according to the theme set as default in your Customer Area..</param>
        public CreatePaymentLinkRequest(List<string> allowedPaymentMethods = default(List<string>), Amount amount = default(Amount), ApplicationInfo applicationInfo = default(ApplicationInfo), Address billingAddress = default(Address), List<string> blockedPaymentMethods = default(List<string>), int? captureDelayHours = default(int?), string countryCode = default(string), DateTime? dateOfBirth = default(DateTime?), DateTime? deliverAt = default(DateTime?), Address deliveryAddress = default(Address), string description = default(string), string expiresAt = default(string), Dictionary<string, InstallmentOption> installmentOptions = default(Dictionary<string, InstallmentOption>), List<LineItem> lineItems = default(List<LineItem>), string mcc = default(string), string merchantAccount = default(string), string merchantOrderReference = default(string), Dictionary<string, string> metadata = default(Dictionary<string, string>), RecurringProcessingModelEnum? recurringProcessingModel = default(RecurringProcessingModelEnum?), string reference = default(string), List<RequiredShopperFieldsEnum> requiredShopperFields = default(List<RequiredShopperFieldsEnum>), string returnUrl = default(string), bool? reusable = default(bool?), RiskData riskData = default(RiskData), string shopperEmail = default(string), string shopperLocale = default(string), Name shopperName = default(Name), string shopperReference = default(string), string shopperStatement = default(string), string socialSecurityNumber = default(string), bool? splitCardFundingSources = false, List<Split> splits = default(List<Split>), string store = default(string), StorePaymentMethodModeEnum? storePaymentMethodMode = default(StorePaymentMethodModeEnum?), string telephoneNumber = default(string), string themeId = default(string))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for CreatePaymentLinkRequest and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            // to ensure "merchantAccount" is required (not null)
            if (merchantAccount == null)
            {
                throw new InvalidDataException("merchantAccount is a required property for CreatePaymentLinkRequest and cannot be null");
            }
            else
            {
                this.MerchantAccount = merchantAccount;
            }
            // to ensure "reference" is required (not null)
            if (reference == null)
            {
                throw new InvalidDataException("reference is a required property for CreatePaymentLinkRequest and cannot be null");
            }
            else
            {
                this.Reference = reference;
            }
            this.AllowedPaymentMethods = allowedPaymentMethods;
            this.ApplicationInfo = applicationInfo;
            this.BillingAddress = billingAddress;
            this.BlockedPaymentMethods = blockedPaymentMethods;
            this.CaptureDelayHours = captureDelayHours;
            this.CountryCode = countryCode;
            this.DateOfBirth = dateOfBirth;
            this.DeliverAt = deliverAt;
            this.DeliveryAddress = deliveryAddress;
            this.Description = description;
            this.ExpiresAt = expiresAt;
            this.InstallmentOptions = installmentOptions;
            this.LineItems = lineItems;
            this.Mcc = mcc;
            this.MerchantOrderReference = merchantOrderReference;
            this.Metadata = metadata;
            this.RecurringProcessingModel = recurringProcessingModel;
            this.RequiredShopperFields = requiredShopperFields;
            this.ReturnUrl = returnUrl;
            this.Reusable = reusable;
            this.RiskData = riskData;
            this.ShopperEmail = shopperEmail;
            this.ShopperLocale = shopperLocale;
            this.ShopperName = shopperName;
            this.ShopperReference = shopperReference;
            this.ShopperStatement = shopperStatement;
            this.SocialSecurityNumber = socialSecurityNumber;
            // use default value if no "splitCardFundingSources" provided
            if (splitCardFundingSources == null)
            {
                this.SplitCardFundingSources = false;
            }
            else
            {
                this.SplitCardFundingSources = splitCardFundingSources;
            }
            this.Splits = splits;
            this.Store = store;
            this.StorePaymentMethodMode = storePaymentMethodMode;
            this.TelephoneNumber = telephoneNumber;
            this.ThemeId = themeId;
        }
        
        /// <summary>
        /// List of payment methods to be presented to the shopper. To refer to payment methods, use their &#x60;paymentMethod.type&#x60; from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: &#x60;\&quot;allowedPaymentMethods\&quot;:[\&quot;ideal\&quot;,\&quot;giropay\&quot;]&#x60;
        /// </summary>
        /// <value>List of payment methods to be presented to the shopper. To refer to payment methods, use their &#x60;paymentMethod.type&#x60; from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: &#x60;\&quot;allowedPaymentMethods\&quot;:[\&quot;ideal\&quot;,\&quot;giropay\&quot;]&#x60;</value>
        [DataMember(Name="allowedPaymentMethods", EmitDefaultValue=false)]
        public List<string> AllowedPaymentMethods { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationInfo
        /// </summary>
        [DataMember(Name="applicationInfo", EmitDefaultValue=false)]
        public ApplicationInfo ApplicationInfo { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// List of payment methods to be hidden from the shopper. To refer to payment methods, use their &#x60;paymentMethod.type&#x60; from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: &#x60;\&quot;blockedPaymentMethods\&quot;:[\&quot;ideal\&quot;,\&quot;giropay\&quot;]&#x60;
        /// </summary>
        /// <value>List of payment methods to be hidden from the shopper. To refer to payment methods, use their &#x60;paymentMethod.type&#x60; from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: &#x60;\&quot;blockedPaymentMethods\&quot;:[\&quot;ideal\&quot;,\&quot;giropay\&quot;]&#x60;</value>
        [DataMember(Name="blockedPaymentMethods", EmitDefaultValue=false)]
        public List<string> BlockedPaymentMethods { get; set; }

        /// <summary>
        /// The delay between the authorisation and scheduled auto-capture, specified in hours.
        /// </summary>
        /// <value>The delay between the authorisation and scheduled auto-capture, specified in hours.</value>
        [DataMember(Name="captureDelayHours", EmitDefaultValue=false)]
        public int? CaptureDelayHours { get; set; }

        /// <summary>
        /// The shopper&#x27;s two-letter country code.
        /// </summary>
        /// <value>The shopper&#x27;s two-letter country code.</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The shopper&#x27;s date of birth.  Format [ISO-8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DD
        /// </summary>
        /// <value>The shopper&#x27;s date of birth.  Format [ISO-8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DD</value>
        [DataMember(Name="dateOfBirth", EmitDefaultValue=false)]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// The date and time when the purchased goods should be delivered.  [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format: YYYY-MM-DDThh:mm:ss+TZD, for example, **2020-12-18T10:15:30+01:00**.
        /// </summary>
        /// <value>The date and time when the purchased goods should be delivered.  [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format: YYYY-MM-DDThh:mm:ss+TZD, for example, **2020-12-18T10:15:30+01:00**.</value>
        [DataMember(Name="deliverAt", EmitDefaultValue=false)]
        public DateTime? DeliverAt { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryAddress
        /// </summary>
        [DataMember(Name="deliveryAddress", EmitDefaultValue=false)]
        public Address DeliveryAddress { get; set; }

        /// <summary>
        /// A short description visible on the payment page. Maximum length: 280 characters.
        /// </summary>
        /// <value>A short description visible on the payment page. Maximum length: 280 characters.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The date when the payment link expires.  [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format: YYYY-MM-DDThh:mm:ss+TZD, for example, **2020-12-18T10:15:30+01:00**.  The maximum expiry date is 70 days after the payment link is created.  If not provided, the payment link expires 24 hours after it was created.
        /// </summary>
        /// <value>The date when the payment link expires.  [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format: YYYY-MM-DDThh:mm:ss+TZD, for example, **2020-12-18T10:15:30+01:00**.  The maximum expiry date is 70 days after the payment link is created.  If not provided, the payment link expires 24 hours after it was created.</value>
        [DataMember(Name="expiresAt", EmitDefaultValue=false)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// A set of key-value pairs that specifies the installment options available per payment method. The key must be a payment method name in lowercase. For example, **card** to specify installment options for all cards, or **visa** or **mc**. The value must be an object containing the installment options.
        /// </summary>
        /// <value>A set of key-value pairs that specifies the installment options available per payment method. The key must be a payment method name in lowercase. For example, **card** to specify installment options for all cards, or **visa** or **mc**. The value must be an object containing the installment options.</value>
        [DataMember(Name="installmentOptions", EmitDefaultValue=false)]
        public Dictionary<string, InstallmentOption> InstallmentOptions { get; set; }

        /// <summary>
        /// Price and product information about the purchased items, to be included on the invoice sent to the shopper. This parameter is required for open invoice (_buy now, pay later_) payment methods such Afterpay, Clearpay, Klarna, RatePay, and Zip.
        /// </summary>
        /// <value>Price and product information about the purchased items, to be included on the invoice sent to the shopper. This parameter is required for open invoice (_buy now, pay later_) payment methods such Afterpay, Clearpay, Klarna, RatePay, and Zip.</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItem> LineItems { get; set; }

        /// <summary>
        /// The [merchant category code](https://en.wikipedia.org/wiki/Merchant_category_code) (MCC) is a four-digit number, which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant.
        /// </summary>
        /// <value>The [merchant category code](https://en.wikipedia.org/wiki/Merchant_category_code) (MCC) is a four-digit number, which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant.</value>
        [DataMember(Name="mcc", EmitDefaultValue=false)]
        public string Mcc { get; set; }

        /// <summary>
        /// The merchant account identifier for which the payment link is created.
        /// </summary>
        /// <value>The merchant account identifier for which the payment link is created.</value>
        [DataMember(Name="merchantAccount", EmitDefaultValue=false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// This reference allows linking multiple transactions to each other for reporting purposes (for example, order auth-rate). The reference should be unique per billing cycle.
        /// </summary>
        /// <value>This reference allows linking multiple transactions to each other for reporting purposes (for example, order auth-rate). The reference should be unique per billing cycle.</value>
        [DataMember(Name="merchantOrderReference", EmitDefaultValue=false)]
        public string MerchantOrderReference { get; set; }

        /// <summary>
        /// Metadata consists of entries, each of which includes a key and a value. Limitations: * Maximum 20 key-value pairs per request. Otherwise, error \&quot;177\&quot; occurs: \&quot;Metadata size exceeds limit\&quot; * Maximum 20 characters per key. Otherwise, error \&quot;178\&quot; occurs: \&quot;Metadata key size exceeds limit\&quot; * A key cannot have the name &#x60;checkout.linkId&#x60;. Any value that you provide with this key is going to be replaced by the real payment link ID.
        /// </summary>
        /// <value>Metadata consists of entries, each of which includes a key and a value. Limitations: * Maximum 20 key-value pairs per request. Otherwise, error \&quot;177\&quot; occurs: \&quot;Metadata size exceeds limit\&quot; * Maximum 20 characters per key. Otherwise, error \&quot;178\&quot; occurs: \&quot;Metadata key size exceeds limit\&quot; * A key cannot have the name &#x60;checkout.linkId&#x60;. Any value that you provide with this key is going to be replaced by the real payment link ID.</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Dictionary<string, string> Metadata { get; set; }


        /// <summary>
        /// A reference that is used to uniquely identify the payment in future communications about the payment status.
        /// </summary>
        /// <value>A reference that is used to uniquely identify the payment in future communications about the payment status.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }


        /// <summary>
        /// Website URL used for redirection after payment is completed. If provided, a **Continue** button will be shown on the payment page. If shoppers select the button, they are redirected to the specified URL.
        /// </summary>
        /// <value>Website URL used for redirection after payment is completed. If provided, a **Continue** button will be shown on the payment page. If shoppers select the button, they are redirected to the specified URL.</value>
        [DataMember(Name="returnUrl", EmitDefaultValue=false)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Indicates whether the payment link can be reused for multiple payments. If not provided, this defaults to **false** which means the link can be used for one successful payment only.
        /// </summary>
        /// <value>Indicates whether the payment link can be reused for multiple payments. If not provided, this defaults to **false** which means the link can be used for one successful payment only.</value>
        [DataMember(Name="reusable", EmitDefaultValue=false)]
        public bool? Reusable { get; set; }

        /// <summary>
        /// Gets or Sets RiskData
        /// </summary>
        [DataMember(Name="riskData", EmitDefaultValue=false)]
        public RiskData RiskData { get; set; }

        /// <summary>
        /// The shopper&#x27;s email address.
        /// </summary>
        /// <value>The shopper&#x27;s email address.</value>
        [DataMember(Name="shopperEmail", EmitDefaultValue=false)]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// The language to be used in the payment page, specified by a combination of a language and country code. For example, &#x60;en-US&#x60;.  For a list of shopper locales that Pay by Link supports, refer to [Language and localization](https://docs.adyen.com/online-payments/pay-by-link#language-and-localization).
        /// </summary>
        /// <value>The language to be used in the payment page, specified by a combination of a language and country code. For example, &#x60;en-US&#x60;.  For a list of shopper locales that Pay by Link supports, refer to [Language and localization](https://docs.adyen.com/online-payments/pay-by-link#language-and-localization).</value>
        [DataMember(Name="shopperLocale", EmitDefaultValue=false)]
        public string ShopperLocale { get; set; }

        /// <summary>
        /// Gets or Sets ShopperName
        /// </summary>
        [DataMember(Name="shopperName", EmitDefaultValue=false)]
        public Name ShopperName { get; set; }

        /// <summary>
        /// Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address.
        /// </summary>
        /// <value>Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address.</value>
        [DataMember(Name="shopperReference", EmitDefaultValue=false)]
        public string ShopperReference { get; set; }

        /// <summary>
        /// The text to be shown on the shopper&#x27;s bank statement.  We recommend sending a maximum of 22 characters, otherwise banks might truncate the string.  Allowed characters: **a-z**, **A-Z**, **0-9**, spaces, and special characters **. , &#x27; _ - ? + * /_**.
        /// </summary>
        /// <value>The text to be shown on the shopper&#x27;s bank statement.  We recommend sending a maximum of 22 characters, otherwise banks might truncate the string.  Allowed characters: **a-z**, **A-Z**, **0-9**, spaces, and special characters **. , &#x27; _ - ? + * /_**.</value>
        [DataMember(Name="shopperStatement", EmitDefaultValue=false)]
        public string ShopperStatement { get; set; }

        /// <summary>
        /// The shopper&#x27;s social security number.
        /// </summary>
        /// <value>The shopper&#x27;s social security number.</value>
        [DataMember(Name="socialSecurityNumber", EmitDefaultValue=false)]
        public string SocialSecurityNumber { get; set; }

        /// <summary>
        /// Boolean value indicating whether the card payment method should be split into separate debit and credit options.
        /// </summary>
        /// <value>Boolean value indicating whether the card payment method should be split into separate debit and credit options.</value>
        [DataMember(Name="splitCardFundingSources", EmitDefaultValue=false)]
        public bool? SplitCardFundingSources { get; set; }

        /// <summary>
        /// An array of objects specifying how the payment should be split between accounts when using Adyen for Platforms. For details, refer to [Providing split information](https://docs.adyen.com/platforms/processing-payments#providing-split-information).
        /// </summary>
        /// <value>An array of objects specifying how the payment should be split between accounts when using Adyen for Platforms. For details, refer to [Providing split information](https://docs.adyen.com/platforms/processing-payments#providing-split-information).</value>
        [DataMember(Name="splits", EmitDefaultValue=false)]
        public List<Split> Splits { get; set; }

        /// <summary>
        /// The physical store, for which this payment is processed.
        /// </summary>
        /// <value>The physical store, for which this payment is processed.</value>
        [DataMember(Name="store", EmitDefaultValue=false)]
        public string Store { get; set; }


        /// <summary>
        /// The shopper&#x27;s telephone number.
        /// </summary>
        /// <value>The shopper&#x27;s telephone number.</value>
        [DataMember(Name="telephoneNumber", EmitDefaultValue=false)]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// A [theme](https://docs.adyen.com/unified-commerce/pay-by-link/api#themes) to customize the appearance of the payment page. If not specified, the payment page is rendered according to the theme set as default in your Customer Area.
        /// </summary>
        /// <value>A [theme](https://docs.adyen.com/unified-commerce/pay-by-link/api#themes) to customize the appearance of the payment page. If not specified, the payment page is rendered according to the theme set as default in your Customer Area.</value>
        [DataMember(Name="themeId", EmitDefaultValue=false)]
        public string ThemeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePaymentLinkRequest {\n");
            sb.Append("  AllowedPaymentMethods: ").Append(AllowedPaymentMethods.ToListString()).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ApplicationInfo: ").Append(ApplicationInfo).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  BlockedPaymentMethods: ").Append(BlockedPaymentMethods).Append("\n");
            sb.Append("  CaptureDelayHours: ").Append(CaptureDelayHours).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  DeliverAt: ").Append(DeliverAt).Append("\n");
            sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  InstallmentOptions: ").Append(InstallmentOptions.ToCollectionsString()).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems.ObjectListToString()).Append("\n");
            sb.Append("  Mcc: ").Append(Mcc).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  MerchantOrderReference: ").Append(MerchantOrderReference).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata.ToCollectionsString()).Append("\n");
            sb.Append("  RecurringProcessingModel: ").Append(RecurringProcessingModel).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  RequiredShopperFields: ").Append(RequiredShopperFields.ObjectListToString()).Append("\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
            sb.Append("  Reusable: ").Append(Reusable).Append("\n");
            sb.Append("  RiskData: ").Append(RiskData).Append("\n");
            sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
            sb.Append("  ShopperLocale: ").Append(ShopperLocale).Append("\n");
            sb.Append("  ShopperName: ").Append(ShopperName).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
            sb.Append("  ShopperStatement: ").Append(ShopperStatement).Append("\n");
            sb.Append("  SocialSecurityNumber: ").Append(SocialSecurityNumber).Append("\n");
            sb.Append("  SplitCardFundingSources: ").Append(SplitCardFundingSources).Append("\n");
            sb.Append("  Splits: ").Append(Splits.ObjectListToString()).Append("\n");
            sb.Append("  Store: ").Append(Store).Append("\n");
            sb.Append("  StorePaymentMethodMode: ").Append(StorePaymentMethodMode).Append("\n");
            sb.Append("  TelephoneNumber: ").Append(TelephoneNumber).Append("\n");
            sb.Append("  ThemeId: ").Append(ThemeId).Append("\n");
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
            return this.Equals(input as CreatePaymentLinkRequest);
        }

        /// <summary>
        /// Returns true if CreatePaymentLinkRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatePaymentLinkRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePaymentLinkRequest input)
        {
            if (input == null)
                return false;

            return 
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
                    this.ApplicationInfo == input.ApplicationInfo ||
                    (this.ApplicationInfo != null &&
                    this.ApplicationInfo.Equals(input.ApplicationInfo))
                ) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.BlockedPaymentMethods == input.BlockedPaymentMethods ||
                    this.BlockedPaymentMethods != null &&
                    input.BlockedPaymentMethods != null &&
                    this.BlockedPaymentMethods.SequenceEqual(input.BlockedPaymentMethods)
                ) && 
                (
                    this.CaptureDelayHours == input.CaptureDelayHours ||
                    (this.CaptureDelayHours != null &&
                    this.CaptureDelayHours.Equals(input.CaptureDelayHours))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) && 
                (
                    this.DeliverAt == input.DeliverAt ||
                    (this.DeliverAt != null &&
                    this.DeliverAt.Equals(input.DeliverAt))
                ) && 
                (
                    this.DeliveryAddress == input.DeliveryAddress ||
                    (this.DeliveryAddress != null &&
                    this.DeliveryAddress.Equals(input.DeliveryAddress))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
                ) && 
                (
                    this.InstallmentOptions == input.InstallmentOptions ||
                    this.InstallmentOptions != null &&
                    input.InstallmentOptions != null &&
                    this.InstallmentOptions.SequenceEqual(input.InstallmentOptions)
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.Mcc == input.Mcc ||
                    (this.Mcc != null &&
                    this.Mcc.Equals(input.Mcc))
                ) && 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) && 
                (
                    this.MerchantOrderReference == input.MerchantOrderReference ||
                    (this.MerchantOrderReference != null &&
                    this.MerchantOrderReference.Equals(input.MerchantOrderReference))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.RecurringProcessingModel == input.RecurringProcessingModel ||
                    (this.RecurringProcessingModel != null &&
                    this.RecurringProcessingModel.Equals(input.RecurringProcessingModel))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.RequiredShopperFields == input.RequiredShopperFields ||
                    this.RequiredShopperFields != null &&
                    input.RequiredShopperFields != null &&
                    this.RequiredShopperFields.SequenceEqual(input.RequiredShopperFields)
                ) && 
                (
                    this.ReturnUrl == input.ReturnUrl ||
                    (this.ReturnUrl != null &&
                    this.ReturnUrl.Equals(input.ReturnUrl))
                ) && 
                (
                    this.Reusable == input.Reusable ||
                    (this.Reusable != null &&
                    this.Reusable.Equals(input.Reusable))
                ) && 
                (
                    this.RiskData == input.RiskData ||
                    (this.RiskData != null &&
                    this.RiskData.Equals(input.RiskData))
                ) && 
                (
                    this.ShopperEmail == input.ShopperEmail ||
                    (this.ShopperEmail != null &&
                    this.ShopperEmail.Equals(input.ShopperEmail))
                ) && 
                (
                    this.ShopperLocale == input.ShopperLocale ||
                    (this.ShopperLocale != null &&
                    this.ShopperLocale.Equals(input.ShopperLocale))
                ) && 
                (
                    this.ShopperName == input.ShopperName ||
                    (this.ShopperName != null &&
                    this.ShopperName.Equals(input.ShopperName))
                ) && 
                (
                    this.ShopperReference == input.ShopperReference ||
                    (this.ShopperReference != null &&
                    this.ShopperReference.Equals(input.ShopperReference))
                ) && 
                (
                    this.ShopperStatement == input.ShopperStatement ||
                    (this.ShopperStatement != null &&
                    this.ShopperStatement.Equals(input.ShopperStatement))
                ) && 
                (
                    this.SocialSecurityNumber == input.SocialSecurityNumber ||
                    (this.SocialSecurityNumber != null &&
                    this.SocialSecurityNumber.Equals(input.SocialSecurityNumber))
                ) && 
                (
                    this.SplitCardFundingSources == input.SplitCardFundingSources ||
                    (this.SplitCardFundingSources != null &&
                    this.SplitCardFundingSources.Equals(input.SplitCardFundingSources))
                ) && 
                (
                    this.Splits == input.Splits ||
                    this.Splits != null &&
                    input.Splits != null &&
                    this.Splits.SequenceEqual(input.Splits)
                ) && 
                (
                    this.Store == input.Store ||
                    (this.Store != null &&
                    this.Store.Equals(input.Store))
                ) && 
                (
                    this.StorePaymentMethodMode == input.StorePaymentMethodMode ||
                    (this.StorePaymentMethodMode != null &&
                    this.StorePaymentMethodMode.Equals(input.StorePaymentMethodMode))
                ) && 
                (
                    this.TelephoneNumber == input.TelephoneNumber ||
                    (this.TelephoneNumber != null &&
                    this.TelephoneNumber.Equals(input.TelephoneNumber))
                ) && 
                (
                    this.ThemeId == input.ThemeId ||
                    (this.ThemeId != null &&
                    this.ThemeId.Equals(input.ThemeId))
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
                if (this.AllowedPaymentMethods != null)
                    hashCode = hashCode * 59 + this.AllowedPaymentMethods.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.ApplicationInfo != null)
                    hashCode = hashCode * 59 + this.ApplicationInfo.GetHashCode();
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                if (this.BlockedPaymentMethods != null)
                    hashCode = hashCode * 59 + this.BlockedPaymentMethods.GetHashCode();
                if (this.CaptureDelayHours != null)
                    hashCode = hashCode * 59 + this.CaptureDelayHours.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.DateOfBirth != null)
                    hashCode = hashCode * 59 + this.DateOfBirth.GetHashCode();
                if (this.DeliverAt != null)
                    hashCode = hashCode * 59 + this.DeliverAt.GetHashCode();
                if (this.DeliveryAddress != null)
                    hashCode = hashCode * 59 + this.DeliveryAddress.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExpiresAt != null)
                    hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                if (this.InstallmentOptions != null)
                    hashCode = hashCode * 59 + this.InstallmentOptions.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.Mcc != null)
                    hashCode = hashCode * 59 + this.Mcc.GetHashCode();
                if (this.MerchantAccount != null)
                    hashCode = hashCode * 59 + this.MerchantAccount.GetHashCode();
                if (this.MerchantOrderReference != null)
                    hashCode = hashCode * 59 + this.MerchantOrderReference.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.RecurringProcessingModel != null)
                    hashCode = hashCode * 59 + this.RecurringProcessingModel.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.RequiredShopperFields != null)
                    hashCode = hashCode * 59 + this.RequiredShopperFields.GetHashCode();
                if (this.ReturnUrl != null)
                    hashCode = hashCode * 59 + this.ReturnUrl.GetHashCode();
                if (this.Reusable != null)
                    hashCode = hashCode * 59 + this.Reusable.GetHashCode();
                if (this.RiskData != null)
                    hashCode = hashCode * 59 + this.RiskData.GetHashCode();
                if (this.ShopperEmail != null)
                    hashCode = hashCode * 59 + this.ShopperEmail.GetHashCode();
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
                if (this.SplitCardFundingSources != null)
                    hashCode = hashCode * 59 + this.SplitCardFundingSources.GetHashCode();
                if (this.Splits != null)
                    hashCode = hashCode * 59 + this.Splits.GetHashCode();
                if (this.Store != null)
                    hashCode = hashCode * 59 + this.Store.GetHashCode();
                if (this.StorePaymentMethodMode != null)
                    hashCode = hashCode * 59 + this.StorePaymentMethodMode.GetHashCode();
                if (this.TelephoneNumber != null)
                    hashCode = hashCode * 59 + this.TelephoneNumber.GetHashCode();
                if (this.ThemeId != null)
                    hashCode = hashCode * 59 + this.ThemeId.GetHashCode();
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