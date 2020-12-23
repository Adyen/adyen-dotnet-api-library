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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// ResponseAdditionalDataCommon
    /// </summary>
    [DataContract]
    public partial class ResponseAdditionalDataCommon : IEquatable<ResponseAdditionalDataCommon>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataCommon" /> class.
        /// </summary>
        /// <param name="acquirerAccountCode">The name of the Adyen acquirer account.  Example: PayPalSandbox_TestAcquirer  &gt; Only relevant for PayPal transactions..</param>
        /// <param name="acquirerCode">The name of the acquirer processing the payment request.  Example: TestPmmAcquirer.</param>
        /// <param name="acquirerReference">The reference number that can be used for reconciliation in case a non-Adyen acquirer is used for settlement.  Example: 7C9N3FNBKT9.</param>
        /// <param name="alias">The Adyen alias of the card.  Example: H167852639363479.</param>
        /// <param name="aliasType">The type of the card alias.  Example: Default.</param>
        /// <param name="authCode">Authorisation code: * When the payment is authorised successfully, this field holds the authorisation code for the payment. * When the payment is not authorised, this field is empty.  Example: 58747.</param>
        /// <param name="authorisedAmountCurrency">The currency of the authorised amount, as a three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes)..</param>
        /// <param name="authorisedAmountValue">Value of the amount authorised.  This amount is represented in minor units according to the [following table](https://docs.adyen.com/development-resources/currency-codes)..</param>
        /// <param name="avsResult">The AVS result code of the payment, which provides information about the outcome of the AVS check.  For possible values, see [AVS](https://docs.adyen.com/risk-management/configure-standard-risk-rules/consistency-rules#billing-address-does-not-match-cardholder-address-avs)..</param>
        /// <param name="avsResultRaw">Raw AVS result received from the acquirer, where available.  Example: D.</param>
        /// <param name="bic">BIC of a bank account.  Example: TESTNL01  &gt; Only relevant for SEPA Direct Debit transactions..</param>
        /// <param name="dsTransID">Supported for 3D Secure 2. The unique transaction identifier assigned by the DS to identify a single transaction..</param>
        /// <param name="eci">The Electronic Commerce Indicator returned from the schemes for the 3DS payment session.  Example: 02.</param>
        /// <param name="expiryDate">The expiry date on the card.  Example: 6/2016  &gt; Returned only in case of a card payment..</param>
        /// <param name="extraCostsCurrency">The currency of the extra amount charged due to additional amounts set in the skin used in the HPP payment request.  Example: EUR.</param>
        /// <param name="extraCostsValue">The value of the extra amount charged due to additional amounts set in the skin used in the HPP payment request. The amount is in minor units..</param>
        /// <param name="fraudCheckItemNrFraudCheckname">The fraud score due to a particular fraud check. The fraud check name is found in the key of the key-value pair..</param>
        /// <param name="fundingSource">Information regarding the funding type of the card. The possible return values are: * CHARGE * CREDIT * DEBIT * PREPAID * PREPAID_RELOADABLE  * PREPAID_NONRELOADABLE * DEFFERED_DEBIT  &gt; This functionality requires additional configuration on Adyen&#x27;s end. To enable it, contact the Support Team.  For receiving this field in the notification, enable **Include Funding Source** in **Notifications** &gt; **Additional settings**..</param>
        /// <param name="fundsAvailability">Indicates availability of funds.  Visa: * \&quot;I\&quot; (fast funds are supported) * \&quot;N\&quot; (otherwise)  Mastercard: * \&quot;I\&quot; (product type is Prepaid or Debit, or issuing country is in CEE/HGEM list) * \&quot;N\&quot; (otherwise)  &gt; Returned when you verify a card BIN or estimate costs, and only if payoutEligible is \&quot;Y\&quot; or \&quot;D\&quot;..</param>
        /// <param name="inferredRefusalReason">Provides the more granular indication of why a transaction was refused. When a transaction fails with either \&quot;Refused\&quot;, \&quot;Restricted Card\&quot;, \&quot;Transaction Not Permitted\&quot;, \&quot;Not supported\&quot; or \&quot;DeclinedNon Generic\&quot; refusalReason from the issuer, Adyen cross references its PSP-wide data for extra insight into the refusal reason. If an inferred refusal reason is available, the &#x60;inferredRefusalReason&#x60;, field is populated and the &#x60;refusalReason&#x60;, is set to \&quot;Not Supported\&quot;.  Possible values:  * 3D Secure Mandated * Closed Account * ContAuth Not Supported * CVC Mandated * Ecommerce Not Allowed * Crossborder Not Supported * Card Updated  * Low Authrate Bin * Non-reloadable prepaid card.</param>
        /// <param name="issuerCountry">The issuing country of the card based on the BIN list that Adyen maintains.  Example: JP.</param>
        /// <param name="mcBankNetReferenceNumber">The &#x60;mcBankNetReferenceNumber&#x60;, is a minimum of six characters and a maximum of nine characters long.  &gt; Contact Support Team to enable this field..</param>
        /// <param name="networkTxReference">Returned in the response if you are not tokenizing with Adyen and are using the Merchant-initiated transactions (MIT) framework from Mastercard or Visa.  This contains either the Mastercard Trace ID or the Visa Transaction ID..</param>
        /// <param name="ownerName">The owner name of a bank account.  Only relevant for SEPA Direct Debit transactions..</param>
        /// <param name="paymentAccountReference">The Payment Account Reference (PAR) value links a network token with the underlying primary account number (PAN). The PAR value consists of 29 uppercase alphanumeric characters..</param>
        /// <param name="paymentMethodVariant">The Adyen sub-variant of the payment method used for the payment request.  For more information, refer to [PaymentMethodVariant](https://docs.adyen.com/development-resources/paymentmethodvariant).  Example: mcpro.</param>
        /// <param name="payoutEligible">Indicates whether a payout is eligible or not for this card.  Visa: * \&quot;Y\&quot; * \&quot;N\&quot;  Mastercard: * \&quot;Y\&quot; (domestic and cross-border)  * \&quot;D\&quot; (only domestic) * \&quot;N\&quot; (no MoneySend) * \&quot;U\&quot; (unknown).</param>
        /// <param name="realtimeAccountUpdaterStatus">The response code from the Real Time Account Updater service.  Possible return values are: * CardChanged * CardExpiryChanged * CloseAccount  * ContactCardAccountHolder.</param>
        /// <param name="receiptFreeText">Message to be displayed on the terminal..</param>
        /// <param name="recurringFirstPspReference">The &#x60;pspReference&#x60;, of the first recurring payment that created the recurring detail.  This functionality requires additional configuration on Adyen&#x27;s end. To enable it, contact the Support Team..</param>
        /// <param name="recurringRecurringDetailReference">The reference that uniquely identifies the recurring transaction..</param>
        /// <param name="referred">If the payment is referred, this field is set to true.  This field is unavailable if the payment is referred and is usually not returned with ecommerce transactions.  Example: true.</param>
        /// <param name="refusalReasonRaw">Raw refusal reason received from the acquirer, where available.  Example: AUTHORISED.</param>
        /// <param name="shopperInteraction">The shopper interaction type of the payment request.  Example: Ecommerce.</param>
        /// <param name="shopperReference">The shopperReference passed in the payment request.  Example: AdyenTestShopperXX.</param>
        /// <param name="terminalId">The terminal ID used in a point-of-sale payment.  Example: 06022622.</param>
        /// <param name="threeDAuthenticated">A Boolean value indicating whether 3DS authentication was completed on this payment.  Example: true.</param>
        /// <param name="threeDAuthenticatedResponse">The raw 3DS authentication result from the card issuer.  Example: N.</param>
        /// <param name="threeDOffered">A Boolean value indicating whether 3DS was offered for this payment.  Example: true.</param>
        /// <param name="threeDOfferedResponse">The raw enrollment result from the 3DS directory services of the card schemes.  Example: Y.</param>
        /// <param name="threeDSVersion">The 3D Secure 2 version..</param>
        /// <param name="visaTransactionId">The &#x60;visaTransactionId&#x60;, has a fixed length of 15 numeric characters.  &gt; Contact Support Team to enable this field..</param>
        /// <param name="xid">The 3DS transaction ID of the 3DS session sent in notifications. The value is Base64-encoded and is returned for transactions with directoryResponse &#x27;N&#x27; or &#x27;Y&#x27;. If you want to submit the xid in your 3D Secure 1 request, use the &#x60;mpiData.xid&#x60;, field.  Example: ODgxNDc2MDg2MDExODk5MAAAAAA&#x3D;.</param>
        public ResponseAdditionalDataCommon(string acquirerAccountCode = default(string),
            string acquirerCode = default(string), string acquirerReference = default(string),
            string alias = default(string), string aliasType = default(string), string authCode = default(string),
            string authorisedAmountCurrency = default(string), string authorisedAmountValue = default(string),
            string avsResult = default(string), string avsResultRaw = default(string), string bic = default(string),
            string dsTransID = default(string), string eci = default(string), string expiryDate = default(string),
            string extraCostsCurrency = default(string), string extraCostsValue = default(string),
            string fraudCheckItemNrFraudCheckname = default(string), string fundingSource = default(string),
            string fundsAvailability = default(string), string inferredRefusalReason = default(string),
            string issuerCountry = default(string), string mcBankNetReferenceNumber = default(string),
            string networkTxReference = default(string), string ownerName = default(string),
            string paymentAccountReference = default(string), string paymentMethodVariant = default(string),
            string payoutEligible = default(string), string realtimeAccountUpdaterStatus = default(string),
            string receiptFreeText = default(string), string recurringFirstPspReference = default(string),
            string recurringRecurringDetailReference = default(string), string referred = default(string),
            string refusalReasonRaw = default(string), string shopperInteraction = default(string),
            string shopperReference = default(string), string terminalId = default(string),
            string threeDAuthenticated = default(string), string threeDAuthenticatedResponse = default(string),
            string threeDOffered = default(string), string threeDOfferedResponse = default(string),
            string threeDSVersion = default(string), string visaTransactionId = default(string),
            string xid = default(string))
        {
            this.AcquirerAccountCode = acquirerAccountCode;
            this.AcquirerCode = acquirerCode;
            this.AcquirerReference = acquirerReference;
            this.Alias = alias;
            this.AliasType = aliasType;
            this.AuthCode = authCode;
            this.AuthorisedAmountCurrency = authorisedAmountCurrency;
            this.AuthorisedAmountValue = authorisedAmountValue;
            this.AvsResult = avsResult;
            this.AvsResultRaw = avsResultRaw;
            this.Bic = bic;
            this.DsTransID = dsTransID;
            this.Eci = eci;
            this.ExpiryDate = expiryDate;
            this.ExtraCostsCurrency = extraCostsCurrency;
            this.ExtraCostsValue = extraCostsValue;
            this.FraudCheckItemNrFraudCheckname = fraudCheckItemNrFraudCheckname;
            this.FundingSource = fundingSource;
            this.FundsAvailability = fundsAvailability;
            this.InferredRefusalReason = inferredRefusalReason;
            this.IssuerCountry = issuerCountry;
            this.McBankNetReferenceNumber = mcBankNetReferenceNumber;
            this.NetworkTxReference = networkTxReference;
            this.OwnerName = ownerName;
            this.PaymentAccountReference = paymentAccountReference;
            this.PaymentMethodVariant = paymentMethodVariant;
            this.PayoutEligible = payoutEligible;
            this.RealtimeAccountUpdaterStatus = realtimeAccountUpdaterStatus;
            this.ReceiptFreeText = receiptFreeText;
            this.RecurringFirstPspReference = recurringFirstPspReference;
            this.RecurringRecurringDetailReference = recurringRecurringDetailReference;
            this.Referred = referred;
            this.RefusalReasonRaw = refusalReasonRaw;
            this.ShopperInteraction = shopperInteraction;
            this.ShopperReference = shopperReference;
            this.TerminalId = terminalId;
            this.ThreeDAuthenticated = threeDAuthenticated;
            this.ThreeDAuthenticatedResponse = threeDAuthenticatedResponse;
            this.ThreeDOffered = threeDOffered;
            this.ThreeDOfferedResponse = threeDOfferedResponse;
            this.ThreeDSVersion = threeDSVersion;
            this.VisaTransactionId = visaTransactionId;
            this.Xid = xid;
        }

        /// <summary>
        /// The name of the Adyen acquirer account.  Example: PayPalSandbox_TestAcquirer  &gt; Only relevant for PayPal transactions.
        /// </summary>
        /// <value>The name of the Adyen acquirer account.  Example: PayPalSandbox_TestAcquirer  &gt; Only relevant for PayPal transactions.</value>
        [DataMember(Name = "acquirerAccountCode", EmitDefaultValue = false)]
        public string AcquirerAccountCode { get; set; }

        /// <summary>
        /// The name of the acquirer processing the payment request.  Example: TestPmmAcquirer
        /// </summary>
        /// <value>The name of the acquirer processing the payment request.  Example: TestPmmAcquirer</value>
        [DataMember(Name = "acquirerCode", EmitDefaultValue = false)]
        public string AcquirerCode { get; set; }

        /// <summary>
        /// The reference number that can be used for reconciliation in case a non-Adyen acquirer is used for settlement.  Example: 7C9N3FNBKT9
        /// </summary>
        /// <value>The reference number that can be used for reconciliation in case a non-Adyen acquirer is used for settlement.  Example: 7C9N3FNBKT9</value>
        [DataMember(Name = "acquirerReference", EmitDefaultValue = false)]
        public string AcquirerReference { get; set; }

        /// <summary>
        /// The Adyen alias of the card.  Example: H167852639363479
        /// </summary>
        /// <value>The Adyen alias of the card.  Example: H167852639363479</value>
        [DataMember(Name = "alias", EmitDefaultValue = false)]
        public string Alias { get; set; }

        /// <summary>
        /// The type of the card alias.  Example: Default
        /// </summary>
        /// <value>The type of the card alias.  Example: Default</value>
        [DataMember(Name = "aliasType", EmitDefaultValue = false)]
        public string AliasType { get; set; }

        /// <summary>
        /// Authorisation code: * When the payment is authorised successfully, this field holds the authorisation code for the payment. * When the payment is not authorised, this field is empty.  Example: 58747
        /// </summary>
        /// <value>Authorisation code: * When the payment is authorised successfully, this field holds the authorisation code for the payment. * When the payment is not authorised, this field is empty.  Example: 58747</value>
        [DataMember(Name = "authCode", EmitDefaultValue = false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// The currency of the authorised amount, as a three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes).
        /// </summary>
        /// <value>The currency of the authorised amount, as a three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes).</value>
        [DataMember(Name = "authorisedAmountCurrency", EmitDefaultValue = false)]
        public string AuthorisedAmountCurrency { get; set; }

        /// <summary>
        /// Value of the amount authorised.  This amount is represented in minor units according to the [following table](https://docs.adyen.com/development-resources/currency-codes).
        /// </summary>
        /// <value>Value of the amount authorised.  This amount is represented in minor units according to the [following table](https://docs.adyen.com/development-resources/currency-codes).</value>
        [DataMember(Name = "authorisedAmountValue", EmitDefaultValue = false)]
        public string AuthorisedAmountValue { get; set; }

        /// <summary>
        /// The AVS result code of the payment, which provides information about the outcome of the AVS check.  For possible values, see [AVS](https://docs.adyen.com/risk-management/configure-standard-risk-rules/consistency-rules#billing-address-does-not-match-cardholder-address-avs).
        /// </summary>
        /// <value>The AVS result code of the payment, which provides information about the outcome of the AVS check.  For possible values, see [AVS](https://docs.adyen.com/risk-management/configure-standard-risk-rules/consistency-rules#billing-address-does-not-match-cardholder-address-avs).</value>
        [DataMember(Name = "avsResult", EmitDefaultValue = false)]
        public string AvsResult { get; set; }

        /// <summary>
        /// Raw AVS result received from the acquirer, where available.  Example: D
        /// </summary>
        /// <value>Raw AVS result received from the acquirer, where available.  Example: D</value>
        [DataMember(Name = "avsResultRaw", EmitDefaultValue = false)]
        public string AvsResultRaw { get; set; }

        /// <summary>
        /// BIC of a bank account.  Example: TESTNL01  &gt; Only relevant for SEPA Direct Debit transactions.
        /// </summary>
        /// <value>BIC of a bank account.  Example: TESTNL01  &gt; Only relevant for SEPA Direct Debit transactions.</value>
        [DataMember(Name = "bic", EmitDefaultValue = false)]
        public string Bic { get; set; }

        /// <summary>
        /// Supported for 3D Secure 2. The unique transaction identifier assigned by the DS to identify a single transaction.
        /// </summary>
        /// <value>Supported for 3D Secure 2. The unique transaction identifier assigned by the DS to identify a single transaction.</value>
        [DataMember(Name = "dsTransID", EmitDefaultValue = false)]
        public string DsTransID { get; set; }

        /// <summary>
        /// The Electronic Commerce Indicator returned from the schemes for the 3DS payment session.  Example: 02
        /// </summary>
        /// <value>The Electronic Commerce Indicator returned from the schemes for the 3DS payment session.  Example: 02</value>
        [DataMember(Name = "eci", EmitDefaultValue = false)]
        public string Eci { get; set; }

        /// <summary>
        /// The expiry date on the card.  Example: 6/2016  &gt; Returned only in case of a card payment.
        /// </summary>
        /// <value>The expiry date on the card.  Example: 6/2016  &gt; Returned only in case of a card payment.</value>
        [DataMember(Name = "expiryDate", EmitDefaultValue = false)]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// The currency of the extra amount charged due to additional amounts set in the skin used in the HPP payment request.  Example: EUR
        /// </summary>
        /// <value>The currency of the extra amount charged due to additional amounts set in the skin used in the HPP payment request.  Example: EUR</value>
        [DataMember(Name = "extraCostsCurrency", EmitDefaultValue = false)]
        public string ExtraCostsCurrency { get; set; }

        /// <summary>
        /// The value of the extra amount charged due to additional amounts set in the skin used in the HPP payment request. The amount is in minor units.
        /// </summary>
        /// <value>The value of the extra amount charged due to additional amounts set in the skin used in the HPP payment request. The amount is in minor units.</value>
        [DataMember(Name = "extraCostsValue", EmitDefaultValue = false)]
        public string ExtraCostsValue { get; set; }

        /// <summary>
        /// The fraud score due to a particular fraud check. The fraud check name is found in the key of the key-value pair.
        /// </summary>
        /// <value>The fraud score due to a particular fraud check. The fraud check name is found in the key of the key-value pair.</value>
        [DataMember(Name = "fraudCheck-[itemNr]-[FraudCheckname]", EmitDefaultValue = false)]
        public string FraudCheckItemNrFraudCheckname { get; set; }

        /// <summary>
        /// Information regarding the funding type of the card. The possible return values are: * CHARGE * CREDIT * DEBIT * PREPAID * PREPAID_RELOADABLE  * PREPAID_NONRELOADABLE * DEFFERED_DEBIT  &gt; This functionality requires additional configuration on Adyen&#x27;s end. To enable it, contact the Support Team.  For receiving this field in the notification, enable **Include Funding Source** in **Notifications** &gt; **Additional settings**.
        /// </summary>
        /// <value>Information regarding the funding type of the card. The possible return values are: * CHARGE * CREDIT * DEBIT * PREPAID * PREPAID_RELOADABLE  * PREPAID_NONRELOADABLE * DEFFERED_DEBIT  &gt; This functionality requires additional configuration on Adyen&#x27;s end. To enable it, contact the Support Team.  For receiving this field in the notification, enable **Include Funding Source** in **Notifications** &gt; **Additional settings**.</value>
        [DataMember(Name = "fundingSource", EmitDefaultValue = false)]
        public string FundingSource { get; set; }

        /// <summary>
        /// Indicates availability of funds.  Visa: * \&quot;I\&quot; (fast funds are supported) * \&quot;N\&quot; (otherwise)  Mastercard: * \&quot;I\&quot; (product type is Prepaid or Debit, or issuing country is in CEE/HGEM list) * \&quot;N\&quot; (otherwise)  &gt; Returned when you verify a card BIN or estimate costs, and only if payoutEligible is \&quot;Y\&quot; or \&quot;D\&quot;.
        /// </summary>
        /// <value>Indicates availability of funds.  Visa: * \&quot;I\&quot; (fast funds are supported) * \&quot;N\&quot; (otherwise)  Mastercard: * \&quot;I\&quot; (product type is Prepaid or Debit, or issuing country is in CEE/HGEM list) * \&quot;N\&quot; (otherwise)  &gt; Returned when you verify a card BIN or estimate costs, and only if payoutEligible is \&quot;Y\&quot; or \&quot;D\&quot;.</value>
        [DataMember(Name = "fundsAvailability", EmitDefaultValue = false)]
        public string FundsAvailability { get; set; }

        /// <summary>
        /// Provides the more granular indication of why a transaction was refused. When a transaction fails with either \&quot;Refused\&quot;, \&quot;Restricted Card\&quot;, \&quot;Transaction Not Permitted\&quot;, \&quot;Not supported\&quot; or \&quot;DeclinedNon Generic\&quot; refusalReason from the issuer, Adyen cross references its PSP-wide data for extra insight into the refusal reason. If an inferred refusal reason is available, the &#x60;inferredRefusalReason&#x60;, field is populated and the &#x60;refusalReason&#x60;, is set to \&quot;Not Supported\&quot;.  Possible values:  * 3D Secure Mandated * Closed Account * ContAuth Not Supported * CVC Mandated * Ecommerce Not Allowed * Crossborder Not Supported * Card Updated  * Low Authrate Bin * Non-reloadable prepaid card
        /// </summary>
        /// <value>Provides the more granular indication of why a transaction was refused. When a transaction fails with either \&quot;Refused\&quot;, \&quot;Restricted Card\&quot;, \&quot;Transaction Not Permitted\&quot;, \&quot;Not supported\&quot; or \&quot;DeclinedNon Generic\&quot; refusalReason from the issuer, Adyen cross references its PSP-wide data for extra insight into the refusal reason. If an inferred refusal reason is available, the &#x60;inferredRefusalReason&#x60;, field is populated and the &#x60;refusalReason&#x60;, is set to \&quot;Not Supported\&quot;.  Possible values:  * 3D Secure Mandated * Closed Account * ContAuth Not Supported * CVC Mandated * Ecommerce Not Allowed * Crossborder Not Supported * Card Updated  * Low Authrate Bin * Non-reloadable prepaid card</value>
        [DataMember(Name = "inferredRefusalReason", EmitDefaultValue = false)]
        public string InferredRefusalReason { get; set; }

        /// <summary>
        /// The issuing country of the card based on the BIN list that Adyen maintains.  Example: JP
        /// </summary>
        /// <value>The issuing country of the card based on the BIN list that Adyen maintains.  Example: JP</value>
        [DataMember(Name = "issuerCountry", EmitDefaultValue = false)]
        public string IssuerCountry { get; set; }

        /// <summary>
        /// The &#x60;mcBankNetReferenceNumber&#x60;, is a minimum of six characters and a maximum of nine characters long.  &gt; Contact Support Team to enable this field.
        /// </summary>
        /// <value>The &#x60;mcBankNetReferenceNumber&#x60;, is a minimum of six characters and a maximum of nine characters long.  &gt; Contact Support Team to enable this field.</value>
        [DataMember(Name = "mcBankNetReferenceNumber", EmitDefaultValue = false)]
        public string McBankNetReferenceNumber { get; set; }

        /// <summary>
        /// Returned in the response if you are not tokenizing with Adyen and are using the Merchant-initiated transactions (MIT) framework from Mastercard or Visa.  This contains either the Mastercard Trace ID or the Visa Transaction ID.
        /// </summary>
        /// <value>Returned in the response if you are not tokenizing with Adyen and are using the Merchant-initiated transactions (MIT) framework from Mastercard or Visa.  This contains either the Mastercard Trace ID or the Visa Transaction ID.</value>
        [DataMember(Name = "networkTxReference", EmitDefaultValue = false)]
        public string NetworkTxReference { get; set; }

        /// <summary>
        /// The owner name of a bank account.  Only relevant for SEPA Direct Debit transactions.
        /// </summary>
        /// <value>The owner name of a bank account.  Only relevant for SEPA Direct Debit transactions.</value>
        [DataMember(Name = "ownerName", EmitDefaultValue = false)]
        public string OwnerName { get; set; }

        /// <summary>
        /// The Payment Account Reference (PAR) value links a network token with the underlying primary account number (PAN). The PAR value consists of 29 uppercase alphanumeric characters.
        /// </summary>
        /// <value>The Payment Account Reference (PAR) value links a network token with the underlying primary account number (PAN). The PAR value consists of 29 uppercase alphanumeric characters.</value>
        [DataMember(Name = "paymentAccountReference", EmitDefaultValue = false)]
        public string PaymentAccountReference { get; set; }

        /// <summary>
        /// The Adyen sub-variant of the payment method used for the payment request.  For more information, refer to [PaymentMethodVariant](https://docs.adyen.com/development-resources/paymentmethodvariant).  Example: mcpro
        /// </summary>
        /// <value>The Adyen sub-variant of the payment method used for the payment request.  For more information, refer to [PaymentMethodVariant](https://docs.adyen.com/development-resources/paymentmethodvariant).  Example: mcpro</value>
        [DataMember(Name = "paymentMethodVariant", EmitDefaultValue = false)]
        public string PaymentMethodVariant { get; set; }

        /// <summary>
        /// Indicates whether a payout is eligible or not for this card.  Visa: * \&quot;Y\&quot; * \&quot;N\&quot;  Mastercard: * \&quot;Y\&quot; (domestic and cross-border)  * \&quot;D\&quot; (only domestic) * \&quot;N\&quot; (no MoneySend) * \&quot;U\&quot; (unknown)
        /// </summary>
        /// <value>Indicates whether a payout is eligible or not for this card.  Visa: * \&quot;Y\&quot; * \&quot;N\&quot;  Mastercard: * \&quot;Y\&quot; (domestic and cross-border)  * \&quot;D\&quot; (only domestic) * \&quot;N\&quot; (no MoneySend) * \&quot;U\&quot; (unknown)</value>
        [DataMember(Name = "payoutEligible", EmitDefaultValue = false)]
        public string PayoutEligible { get; set; }

        /// <summary>
        /// The response code from the Real Time Account Updater service.  Possible return values are: * CardChanged * CardExpiryChanged * CloseAccount  * ContactCardAccountHolder
        /// </summary>
        /// <value>The response code from the Real Time Account Updater service.  Possible return values are: * CardChanged * CardExpiryChanged * CloseAccount  * ContactCardAccountHolder</value>
        [DataMember(Name = "realtimeAccountUpdaterStatus", EmitDefaultValue = false)]
        public string RealtimeAccountUpdaterStatus { get; set; }

        /// <summary>
        /// Message to be displayed on the terminal.
        /// </summary>
        /// <value>Message to be displayed on the terminal.</value>
        [DataMember(Name = "receiptFreeText", EmitDefaultValue = false)]
        public string ReceiptFreeText { get; set; }

        /// <summary>
        /// The &#x60;pspReference&#x60;, of the first recurring payment that created the recurring detail.  This functionality requires additional configuration on Adyen&#x27;s end. To enable it, contact the Support Team.
        /// </summary>
        /// <value>The &#x60;pspReference&#x60;, of the first recurring payment that created the recurring detail.  This functionality requires additional configuration on Adyen&#x27;s end. To enable it, contact the Support Team.</value>
        [DataMember(Name = "recurring.firstPspReference", EmitDefaultValue = false)]
        public string RecurringFirstPspReference { get; set; }

        /// <summary>
        /// The reference that uniquely identifies the recurring transaction.
        /// </summary>
        /// <value>The reference that uniquely identifies the recurring transaction.</value>
        [DataMember(Name = "recurring.recurringDetailReference", EmitDefaultValue = false)]
        public string RecurringRecurringDetailReference { get; set; }

        /// <summary>
        /// If the payment is referred, this field is set to true.  This field is unavailable if the payment is referred and is usually not returned with ecommerce transactions.  Example: true
        /// </summary>
        /// <value>If the payment is referred, this field is set to true.  This field is unavailable if the payment is referred and is usually not returned with ecommerce transactions.  Example: true</value>
        [DataMember(Name = "referred", EmitDefaultValue = false)]
        public string Referred { get; set; }

        /// <summary>
        /// Raw refusal reason received from the acquirer, where available.  Example: AUTHORISED
        /// </summary>
        /// <value>Raw refusal reason received from the acquirer, where available.  Example: AUTHORISED</value>
        [DataMember(Name = "refusalReasonRaw", EmitDefaultValue = false)]
        public string RefusalReasonRaw { get; set; }

        /// <summary>
        /// The shopper interaction type of the payment request.  Example: Ecommerce
        /// </summary>
        /// <value>The shopper interaction type of the payment request.  Example: Ecommerce</value>
        [DataMember(Name = "shopperInteraction", EmitDefaultValue = false)]
        public string ShopperInteraction { get; set; }

        /// <summary>
        /// The shopperReference passed in the payment request.  Example: AdyenTestShopperXX
        /// </summary>
        /// <value>The shopperReference passed in the payment request.  Example: AdyenTestShopperXX</value>
        [DataMember(Name = "shopperReference", EmitDefaultValue = false)]
        public string ShopperReference { get; set; }

        /// <summary>
        /// The terminal ID used in a point-of-sale payment.  Example: 06022622
        /// </summary>
        /// <value>The terminal ID used in a point-of-sale payment.  Example: 06022622</value>
        [DataMember(Name = "terminalId", EmitDefaultValue = false)]
        public string TerminalId { get; set; }

        /// <summary>
        /// A Boolean value indicating whether 3DS authentication was completed on this payment.  Example: true
        /// </summary>
        /// <value>A Boolean value indicating whether 3DS authentication was completed on this payment.  Example: true</value>
        [DataMember(Name = "threeDAuthenticated", EmitDefaultValue = false)]
        public string ThreeDAuthenticated { get; set; }

        /// <summary>
        /// The raw 3DS authentication result from the card issuer.  Example: N
        /// </summary>
        /// <value>The raw 3DS authentication result from the card issuer.  Example: N</value>
        [DataMember(Name = "threeDAuthenticatedResponse", EmitDefaultValue = false)]
        public string ThreeDAuthenticatedResponse { get; set; }

        /// <summary>
        /// A Boolean value indicating whether 3DS was offered for this payment.  Example: true
        /// </summary>
        /// <value>A Boolean value indicating whether 3DS was offered for this payment.  Example: true</value>
        [DataMember(Name = "threeDOffered", EmitDefaultValue = false)]
        public string ThreeDOffered { get; set; }

        /// <summary>
        /// The raw enrollment result from the 3DS directory services of the card schemes.  Example: Y
        /// </summary>
        /// <value>The raw enrollment result from the 3DS directory services of the card schemes.  Example: Y</value>
        [DataMember(Name = "threeDOfferedResponse", EmitDefaultValue = false)]
        public string ThreeDOfferedResponse { get; set; }

        /// <summary>
        /// The 3D Secure 2 version.
        /// </summary>
        /// <value>The 3D Secure 2 version.</value>
        [DataMember(Name = "threeDSVersion", EmitDefaultValue = false)]
        public string ThreeDSVersion { get; set; }

        /// <summary>
        /// The &#x60;visaTransactionId&#x60;, has a fixed length of 15 numeric characters.  &gt; Contact Support Team to enable this field.
        /// </summary>
        /// <value>The &#x60;visaTransactionId&#x60;, has a fixed length of 15 numeric characters.  &gt; Contact Support Team to enable this field.</value>
        [DataMember(Name = "visaTransactionId", EmitDefaultValue = false)]
        public string VisaTransactionId { get; set; }

        /// <summary>
        /// The 3DS transaction ID of the 3DS session sent in notifications. The value is Base64-encoded and is returned for transactions with directoryResponse &#x27;N&#x27; or &#x27;Y&#x27;. If you want to submit the xid in your 3D Secure 1 request, use the &#x60;mpiData.xid&#x60;, field.  Example: ODgxNDc2MDg2MDExODk5MAAAAAA&#x3D;
        /// </summary>
        /// <value>The 3DS transaction ID of the 3DS session sent in notifications. The value is Base64-encoded and is returned for transactions with directoryResponse &#x27;N&#x27; or &#x27;Y&#x27;. If you want to submit the xid in your 3D Secure 1 request, use the &#x60;mpiData.xid&#x60;, field.  Example: ODgxNDc2MDg2MDExODk5MAAAAAA&#x3D;</value>
        [DataMember(Name = "xid", EmitDefaultValue = false)]
        public string Xid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseAdditionalDataCommon {\n");
            sb.Append("  AcquirerAccountCode: ").Append(AcquirerAccountCode).Append("\n");
            sb.Append("  AcquirerCode: ").Append(AcquirerCode).Append("\n");
            sb.Append("  AcquirerReference: ").Append(AcquirerReference).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  AliasType: ").Append(AliasType).Append("\n");
            sb.Append("  AuthCode: ").Append(AuthCode).Append("\n");
            sb.Append("  AuthorisedAmountCurrency: ").Append(AuthorisedAmountCurrency).Append("\n");
            sb.Append("  AuthorisedAmountValue: ").Append(AuthorisedAmountValue).Append("\n");
            sb.Append("  AvsResult: ").Append(AvsResult).Append("\n");
            sb.Append("  AvsResultRaw: ").Append(AvsResultRaw).Append("\n");
            sb.Append("  Bic: ").Append(Bic).Append("\n");
            sb.Append("  DsTransID: ").Append(DsTransID).Append("\n");
            sb.Append("  Eci: ").Append(Eci).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  ExtraCostsCurrency: ").Append(ExtraCostsCurrency).Append("\n");
            sb.Append("  ExtraCostsValue: ").Append(ExtraCostsValue).Append("\n");
            sb.Append("  FraudCheckItemNrFraudCheckname: ").Append(FraudCheckItemNrFraudCheckname).Append("\n");
            sb.Append("  FundingSource: ").Append(FundingSource).Append("\n");
            sb.Append("  FundsAvailability: ").Append(FundsAvailability).Append("\n");
            sb.Append("  InferredRefusalReason: ").Append(InferredRefusalReason).Append("\n");
            sb.Append("  IssuerCountry: ").Append(IssuerCountry).Append("\n");
            sb.Append("  McBankNetReferenceNumber: ").Append(McBankNetReferenceNumber).Append("\n");
            sb.Append("  NetworkTxReference: ").Append(NetworkTxReference).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  PaymentAccountReference: ").Append(PaymentAccountReference).Append("\n");
            sb.Append("  PaymentMethodVariant: ").Append(PaymentMethodVariant).Append("\n");
            sb.Append("  PayoutEligible: ").Append(PayoutEligible).Append("\n");
            sb.Append("  RealtimeAccountUpdaterStatus: ").Append(RealtimeAccountUpdaterStatus).Append("\n");
            sb.Append("  ReceiptFreeText: ").Append(ReceiptFreeText).Append("\n");
            sb.Append("  RecurringFirstPspReference: ").Append(RecurringFirstPspReference).Append("\n");
            sb.Append("  RecurringRecurringDetailReference: ").Append(RecurringRecurringDetailReference).Append("\n");
            sb.Append("  Referred: ").Append(Referred).Append("\n");
            sb.Append("  RefusalReasonRaw: ").Append(RefusalReasonRaw).Append("\n");
            sb.Append("  ShopperInteraction: ").Append(ShopperInteraction).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
            sb.Append("  TerminalId: ").Append(TerminalId).Append("\n");
            sb.Append("  ThreeDAuthenticated: ").Append(ThreeDAuthenticated).Append("\n");
            sb.Append("  ThreeDAuthenticatedResponse: ").Append(ThreeDAuthenticatedResponse).Append("\n");
            sb.Append("  ThreeDOffered: ").Append(ThreeDOffered).Append("\n");
            sb.Append("  ThreeDOfferedResponse: ").Append(ThreeDOfferedResponse).Append("\n");
            sb.Append("  ThreeDSVersion: ").Append(ThreeDSVersion).Append("\n");
            sb.Append("  VisaTransactionId: ").Append(VisaTransactionId).Append("\n");
            sb.Append("  Xid: ").Append(Xid).Append("\n");
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
            return this.Equals(input as ResponseAdditionalDataCommon);
        }

        /// <summary>
        /// Returns true if ResponseAdditionalDataCommon instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseAdditionalDataCommon to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseAdditionalDataCommon input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AcquirerAccountCode == input.AcquirerAccountCode ||
                    this.AcquirerAccountCode != null &&
                    this.AcquirerAccountCode.Equals(input.AcquirerAccountCode)
                ) &&
                (
                    this.AcquirerCode == input.AcquirerCode ||
                    this.AcquirerCode != null &&
                    this.AcquirerCode.Equals(input.AcquirerCode)
                ) &&
                (
                    this.AcquirerReference == input.AcquirerReference ||
                    this.AcquirerReference != null &&
                    this.AcquirerReference.Equals(input.AcquirerReference)
                ) &&
                (
                    this.Alias == input.Alias ||
                    this.Alias != null &&
                    this.Alias.Equals(input.Alias)
                ) &&
                (
                    this.AliasType == input.AliasType ||
                    this.AliasType != null &&
                    this.AliasType.Equals(input.AliasType)
                ) &&
                (
                    this.AuthCode == input.AuthCode ||
                    this.AuthCode != null &&
                    this.AuthCode.Equals(input.AuthCode)
                ) &&
                (
                    this.AuthorisedAmountCurrency == input.AuthorisedAmountCurrency ||
                    this.AuthorisedAmountCurrency != null &&
                    this.AuthorisedAmountCurrency.Equals(input.AuthorisedAmountCurrency)
                ) &&
                (
                    this.AuthorisedAmountValue == input.AuthorisedAmountValue ||
                    this.AuthorisedAmountValue != null &&
                    this.AuthorisedAmountValue.Equals(input.AuthorisedAmountValue)
                ) &&
                (
                    this.AvsResult == input.AvsResult ||
                    this.AvsResult != null &&
                    this.AvsResult.Equals(input.AvsResult)
                ) &&
                (
                    this.AvsResultRaw == input.AvsResultRaw ||
                    this.AvsResultRaw != null &&
                    this.AvsResultRaw.Equals(input.AvsResultRaw)
                ) &&
                (
                    this.Bic == input.Bic ||
                    this.Bic != null &&
                    this.Bic.Equals(input.Bic)
                ) &&
                (
                    this.DsTransID == input.DsTransID ||
                    this.DsTransID != null &&
                    this.DsTransID.Equals(input.DsTransID)
                ) &&
                (
                    this.Eci == input.Eci ||
                    this.Eci != null &&
                    this.Eci.Equals(input.Eci)
                ) &&
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate)
                ) &&
                (
                    this.ExtraCostsCurrency == input.ExtraCostsCurrency ||
                    this.ExtraCostsCurrency != null &&
                    this.ExtraCostsCurrency.Equals(input.ExtraCostsCurrency)
                ) &&
                (
                    this.ExtraCostsValue == input.ExtraCostsValue ||
                    this.ExtraCostsValue != null &&
                    this.ExtraCostsValue.Equals(input.ExtraCostsValue)
                ) &&
                (
                    this.FraudCheckItemNrFraudCheckname == input.FraudCheckItemNrFraudCheckname ||
                    this.FraudCheckItemNrFraudCheckname != null &&
                    this.FraudCheckItemNrFraudCheckname.Equals(input.FraudCheckItemNrFraudCheckname)
                ) &&
                (
                    this.FundingSource == input.FundingSource ||
                    this.FundingSource != null &&
                    this.FundingSource.Equals(input.FundingSource)
                ) &&
                (
                    this.FundsAvailability == input.FundsAvailability ||
                    this.FundsAvailability != null &&
                    this.FundsAvailability.Equals(input.FundsAvailability)
                ) &&
                (
                    this.InferredRefusalReason == input.InferredRefusalReason ||
                    this.InferredRefusalReason != null &&
                    this.InferredRefusalReason.Equals(input.InferredRefusalReason)
                ) &&
                (
                    this.IssuerCountry == input.IssuerCountry ||
                    this.IssuerCountry != null &&
                    this.IssuerCountry.Equals(input.IssuerCountry)
                ) &&
                (
                    this.McBankNetReferenceNumber == input.McBankNetReferenceNumber ||
                    this.McBankNetReferenceNumber != null &&
                    this.McBankNetReferenceNumber.Equals(input.McBankNetReferenceNumber)
                ) &&
                (
                    this.NetworkTxReference == input.NetworkTxReference ||
                    this.NetworkTxReference != null &&
                    this.NetworkTxReference.Equals(input.NetworkTxReference)
                ) &&
                (
                    this.OwnerName == input.OwnerName ||
                    this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName)
                ) &&
                (
                    this.PaymentAccountReference == input.PaymentAccountReference ||
                    this.PaymentAccountReference != null &&
                    this.PaymentAccountReference.Equals(input.PaymentAccountReference)
                ) &&
                (
                    this.PaymentMethodVariant == input.PaymentMethodVariant ||
                    this.PaymentMethodVariant != null &&
                    this.PaymentMethodVariant.Equals(input.PaymentMethodVariant)
                ) &&
                (
                    this.PayoutEligible == input.PayoutEligible ||
                    this.PayoutEligible != null &&
                    this.PayoutEligible.Equals(input.PayoutEligible)
                ) &&
                (
                    this.RealtimeAccountUpdaterStatus == input.RealtimeAccountUpdaterStatus ||
                    this.RealtimeAccountUpdaterStatus != null &&
                    this.RealtimeAccountUpdaterStatus.Equals(input.RealtimeAccountUpdaterStatus)
                ) &&
                (
                    this.ReceiptFreeText == input.ReceiptFreeText ||
                    this.ReceiptFreeText != null &&
                    this.ReceiptFreeText.Equals(input.ReceiptFreeText)
                ) &&
                (
                    this.RecurringFirstPspReference == input.RecurringFirstPspReference ||
                    this.RecurringFirstPspReference != null &&
                    this.RecurringFirstPspReference.Equals(input.RecurringFirstPspReference)
                ) &&
                (
                    this.RecurringRecurringDetailReference == input.RecurringRecurringDetailReference ||
                    this.RecurringRecurringDetailReference != null &&
                    this.RecurringRecurringDetailReference.Equals(input.RecurringRecurringDetailReference)
                ) &&
                (
                    this.Referred == input.Referred ||
                    this.Referred != null &&
                    this.Referred.Equals(input.Referred)
                ) &&
                (
                    this.RefusalReasonRaw == input.RefusalReasonRaw ||
                    this.RefusalReasonRaw != null &&
                    this.RefusalReasonRaw.Equals(input.RefusalReasonRaw)
                ) &&
                (
                    this.ShopperInteraction == input.ShopperInteraction ||
                    this.ShopperInteraction != null &&
                    this.ShopperInteraction.Equals(input.ShopperInteraction)
                ) &&
                (
                    this.ShopperReference == input.ShopperReference ||
                    this.ShopperReference != null &&
                    this.ShopperReference.Equals(input.ShopperReference)
                ) &&
                (
                    this.TerminalId == input.TerminalId ||
                    this.TerminalId != null &&
                    this.TerminalId.Equals(input.TerminalId)
                ) &&
                (
                    this.ThreeDAuthenticated == input.ThreeDAuthenticated ||
                    this.ThreeDAuthenticated != null &&
                    this.ThreeDAuthenticated.Equals(input.ThreeDAuthenticated)
                ) &&
                (
                    this.ThreeDAuthenticatedResponse == input.ThreeDAuthenticatedResponse ||
                    this.ThreeDAuthenticatedResponse != null &&
                    this.ThreeDAuthenticatedResponse.Equals(input.ThreeDAuthenticatedResponse)
                ) &&
                (
                    this.ThreeDOffered == input.ThreeDOffered ||
                    this.ThreeDOffered != null &&
                    this.ThreeDOffered.Equals(input.ThreeDOffered)
                ) &&
                (
                    this.ThreeDOfferedResponse == input.ThreeDOfferedResponse ||
                    this.ThreeDOfferedResponse != null &&
                    this.ThreeDOfferedResponse.Equals(input.ThreeDOfferedResponse)
                ) &&
                (
                    this.ThreeDSVersion == input.ThreeDSVersion ||
                    this.ThreeDSVersion != null &&
                    this.ThreeDSVersion.Equals(input.ThreeDSVersion)
                ) &&
                (
                    this.VisaTransactionId == input.VisaTransactionId ||
                    this.VisaTransactionId != null &&
                    this.VisaTransactionId.Equals(input.VisaTransactionId)
                ) &&
                (
                    this.Xid == input.Xid ||
                    this.Xid != null &&
                    this.Xid.Equals(input.Xid)
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
                if (this.AcquirerAccountCode != null)
                    hashCode = hashCode * 59 + this.AcquirerAccountCode.GetHashCode();
                if (this.AcquirerCode != null)
                    hashCode = hashCode * 59 + this.AcquirerCode.GetHashCode();
                if (this.AcquirerReference != null)
                    hashCode = hashCode * 59 + this.AcquirerReference.GetHashCode();
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.AliasType != null)
                    hashCode = hashCode * 59 + this.AliasType.GetHashCode();
                if (this.AuthCode != null)
                    hashCode = hashCode * 59 + this.AuthCode.GetHashCode();
                if (this.AuthorisedAmountCurrency != null)
                    hashCode = hashCode * 59 + this.AuthorisedAmountCurrency.GetHashCode();
                if (this.AuthorisedAmountValue != null)
                    hashCode = hashCode * 59 + this.AuthorisedAmountValue.GetHashCode();
                if (this.AvsResult != null)
                    hashCode = hashCode * 59 + this.AvsResult.GetHashCode();
                if (this.AvsResultRaw != null)
                    hashCode = hashCode * 59 + this.AvsResultRaw.GetHashCode();
                if (this.Bic != null)
                    hashCode = hashCode * 59 + this.Bic.GetHashCode();
                if (this.DsTransID != null)
                    hashCode = hashCode * 59 + this.DsTransID.GetHashCode();
                if (this.Eci != null)
                    hashCode = hashCode * 59 + this.Eci.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.ExtraCostsCurrency != null)
                    hashCode = hashCode * 59 + this.ExtraCostsCurrency.GetHashCode();
                if (this.ExtraCostsValue != null)
                    hashCode = hashCode * 59 + this.ExtraCostsValue.GetHashCode();
                if (this.FraudCheckItemNrFraudCheckname != null)
                    hashCode = hashCode * 59 + this.FraudCheckItemNrFraudCheckname.GetHashCode();
                if (this.FundingSource != null)
                    hashCode = hashCode * 59 + this.FundingSource.GetHashCode();
                if (this.FundsAvailability != null)
                    hashCode = hashCode * 59 + this.FundsAvailability.GetHashCode();
                if (this.InferredRefusalReason != null)
                    hashCode = hashCode * 59 + this.InferredRefusalReason.GetHashCode();
                if (this.IssuerCountry != null)
                    hashCode = hashCode * 59 + this.IssuerCountry.GetHashCode();
                if (this.McBankNetReferenceNumber != null)
                    hashCode = hashCode * 59 + this.McBankNetReferenceNumber.GetHashCode();
                if (this.NetworkTxReference != null)
                    hashCode = hashCode * 59 + this.NetworkTxReference.GetHashCode();
                if (this.OwnerName != null)
                    hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
                if (this.PaymentAccountReference != null)
                    hashCode = hashCode * 59 + this.PaymentAccountReference.GetHashCode();
                if (this.PaymentMethodVariant != null)
                    hashCode = hashCode * 59 + this.PaymentMethodVariant.GetHashCode();
                if (this.PayoutEligible != null)
                    hashCode = hashCode * 59 + this.PayoutEligible.GetHashCode();
                if (this.RealtimeAccountUpdaterStatus != null)
                    hashCode = hashCode * 59 + this.RealtimeAccountUpdaterStatus.GetHashCode();
                if (this.ReceiptFreeText != null)
                    hashCode = hashCode * 59 + this.ReceiptFreeText.GetHashCode();
                if (this.RecurringFirstPspReference != null)
                    hashCode = hashCode * 59 + this.RecurringFirstPspReference.GetHashCode();
                if (this.RecurringRecurringDetailReference != null)
                    hashCode = hashCode * 59 + this.RecurringRecurringDetailReference.GetHashCode();
                if (this.Referred != null)
                    hashCode = hashCode * 59 + this.Referred.GetHashCode();
                if (this.RefusalReasonRaw != null)
                    hashCode = hashCode * 59 + this.RefusalReasonRaw.GetHashCode();
                if (this.ShopperInteraction != null)
                    hashCode = hashCode * 59 + this.ShopperInteraction.GetHashCode();
                if (this.ShopperReference != null)
                    hashCode = hashCode * 59 + this.ShopperReference.GetHashCode();
                if (this.TerminalId != null)
                    hashCode = hashCode * 59 + this.TerminalId.GetHashCode();
                if (this.ThreeDAuthenticated != null)
                    hashCode = hashCode * 59 + this.ThreeDAuthenticated.GetHashCode();
                if (this.ThreeDAuthenticatedResponse != null)
                    hashCode = hashCode * 59 + this.ThreeDAuthenticatedResponse.GetHashCode();
                if (this.ThreeDOffered != null)
                    hashCode = hashCode * 59 + this.ThreeDOffered.GetHashCode();
                if (this.ThreeDOfferedResponse != null)
                    hashCode = hashCode * 59 + this.ThreeDOfferedResponse.GetHashCode();
                if (this.ThreeDSVersion != null)
                    hashCode = hashCode * 59 + this.ThreeDSVersion.GetHashCode();
                if (this.VisaTransactionId != null)
                    hashCode = hashCode * 59 + this.VisaTransactionId.GetHashCode();
                if (this.Xid != null)
                    hashCode = hashCode * 59 + this.Xid.GetHashCode();
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