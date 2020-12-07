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
  public class ResponseAdditionalDataCommon {
    /// <summary>
    /// The name of the Adyen acquirer account.  Example: PayPalSandbox_TestAcquirer  > Only relevant for PayPal transactions.
    /// </summary>
    /// <value>The name of the Adyen acquirer account.  Example: PayPalSandbox_TestAcquirer  > Only relevant for PayPal transactions.</value>
    [DataMember(Name="acquirerAccountCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acquirerAccountCode")]
    public string AcquirerAccountCode { get; set; }

    /// <summary>
    /// The name of the acquirer processing the payment request.  Example: TestPmmAcquirer
    /// </summary>
    /// <value>The name of the acquirer processing the payment request.  Example: TestPmmAcquirer</value>
    [DataMember(Name="acquirerCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acquirerCode")]
    public string AcquirerCode { get; set; }

    /// <summary>
    /// The reference number that can be used for reconciliation in case a non-Adyen acquirer is used for settlement.  Example: 7C9N3FNBKT9
    /// </summary>
    /// <value>The reference number that can be used for reconciliation in case a non-Adyen acquirer is used for settlement.  Example: 7C9N3FNBKT9</value>
    [DataMember(Name="acquirerReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acquirerReference")]
    public string AcquirerReference { get; set; }

    /// <summary>
    /// The Adyen alias of the card.  Example: H167852639363479
    /// </summary>
    /// <value>The Adyen alias of the card.  Example: H167852639363479</value>
    [DataMember(Name="alias", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alias")]
    public string Alias { get; set; }

    /// <summary>
    /// The type of the card alias.  Example: Default
    /// </summary>
    /// <value>The type of the card alias.  Example: Default</value>
    [DataMember(Name="aliasType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aliasType")]
    public string AliasType { get; set; }

    /// <summary>
    /// Authorisation code: * When the payment is authorised successfully, this field holds the authorisation code for the payment. * When the payment is not authorised, this field is empty.  Example: 58747
    /// </summary>
    /// <value>Authorisation code: * When the payment is authorised successfully, this field holds the authorisation code for the payment. * When the payment is not authorised, this field is empty.  Example: 58747</value>
    [DataMember(Name="authCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authCode")]
    public string AuthCode { get; set; }

    /// <summary>
    /// The currency of the authorised amount, as a three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes).
    /// </summary>
    /// <value>The currency of the authorised amount, as a three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes).</value>
    [DataMember(Name="authorisedAmountCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authorisedAmountCurrency")]
    public string AuthorisedAmountCurrency { get; set; }

    /// <summary>
    /// Value of the amount authorised.  This amount is represented in minor units according to the [following table](https://docs.adyen.com/development-resources/currency-codes).
    /// </summary>
    /// <value>Value of the amount authorised.  This amount is represented in minor units according to the [following table](https://docs.adyen.com/development-resources/currency-codes).</value>
    [DataMember(Name="authorisedAmountValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authorisedAmountValue")]
    public string AuthorisedAmountValue { get; set; }

    /// <summary>
    /// The AVS result code of the payment, which provides information about the outcome of the AVS check.  For possible values, see [AVS](https://docs.adyen.com/risk-management/configure-standard-risk-rules/consistency-rules#billing-address-does-not-match-cardholder-address-avs).
    /// </summary>
    /// <value>The AVS result code of the payment, which provides information about the outcome of the AVS check.  For possible values, see [AVS](https://docs.adyen.com/risk-management/configure-standard-risk-rules/consistency-rules#billing-address-does-not-match-cardholder-address-avs).</value>
    [DataMember(Name="avsResult", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avsResult")]
    public string AvsResult { get; set; }

    /// <summary>
    /// Raw AVS result received from the acquirer, where available.  Example: D
    /// </summary>
    /// <value>Raw AVS result received from the acquirer, where available.  Example: D</value>
    [DataMember(Name="avsResultRaw", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avsResultRaw")]
    public string AvsResultRaw { get; set; }

    /// <summary>
    /// BIC of a bank account.  Example: TESTNL01  > Only relevant for SEPA Direct Debit transactions.
    /// </summary>
    /// <value>BIC of a bank account.  Example: TESTNL01  > Only relevant for SEPA Direct Debit transactions.</value>
    [DataMember(Name="bic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bic")]
    public string Bic { get; set; }

    /// <summary>
    /// Supported for 3D Secure 2. The unique transaction identifier assigned by the DS to identify a single transaction.
    /// </summary>
    /// <value>Supported for 3D Secure 2. The unique transaction identifier assigned by the DS to identify a single transaction.</value>
    [DataMember(Name="dsTransID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dsTransID")]
    public string DsTransID { get; set; }

    /// <summary>
    /// The Electronic Commerce Indicator returned from the schemes for the 3DS payment session.  Example: 02
    /// </summary>
    /// <value>The Electronic Commerce Indicator returned from the schemes for the 3DS payment session.  Example: 02</value>
    [DataMember(Name="eci", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eci")]
    public string Eci { get; set; }

    /// <summary>
    /// The expiry date on the card.  Example: 6/2016  > Returned only in case of a card payment.
    /// </summary>
    /// <value>The expiry date on the card.  Example: 6/2016  > Returned only in case of a card payment.</value>
    [DataMember(Name="expiryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiryDate")]
    public string ExpiryDate { get; set; }

    /// <summary>
    /// The currency of the extra amount charged due to additional amounts set in the skin used in the HPP payment request.  Example: EUR
    /// </summary>
    /// <value>The currency of the extra amount charged due to additional amounts set in the skin used in the HPP payment request.  Example: EUR</value>
    [DataMember(Name="extraCostsCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extraCostsCurrency")]
    public string ExtraCostsCurrency { get; set; }

    /// <summary>
    /// The value of the extra amount charged due to additional amounts set in the skin used in the HPP payment request. The amount is in minor units.
    /// </summary>
    /// <value>The value of the extra amount charged due to additional amounts set in the skin used in the HPP payment request. The amount is in minor units.</value>
    [DataMember(Name="extraCostsValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extraCostsValue")]
    public string ExtraCostsValue { get; set; }

    /// <summary>
    /// The fraud score due to a particular fraud check. The fraud check name is found in the key of the key-value pair.
    /// </summary>
    /// <value>The fraud score due to a particular fraud check. The fraud check name is found in the key of the key-value pair.</value>
    [DataMember(Name="fraudCheck-[itemNr]-[FraudCheckname]", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fraudCheck-[itemNr]-[FraudCheckname]")]
    public string FraudCheckItemNrFraudCheckname { get; set; }

    /// <summary>
    /// Information regarding the funding type of the card. The possible return values are: * CHARGE * CREDIT * DEBIT * PREPAID * PREPAID_RELOADABLE  * PREPAID_NONRELOADABLE * DEFFERED_DEBIT  > This functionality requires additional configuration on Adyen's end. To enable it, contact the Support Team.  For receiving this field in the notification, enable **Include Funding Source** in **Notifications** > **Additional settings**.
    /// </summary>
    /// <value>Information regarding the funding type of the card. The possible return values are: * CHARGE * CREDIT * DEBIT * PREPAID * PREPAID_RELOADABLE  * PREPAID_NONRELOADABLE * DEFFERED_DEBIT  > This functionality requires additional configuration on Adyen's end. To enable it, contact the Support Team.  For receiving this field in the notification, enable **Include Funding Source** in **Notifications** > **Additional settings**.</value>
    [DataMember(Name="fundingSource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fundingSource")]
    public string FundingSource { get; set; }

    /// <summary>
    /// Indicates availability of funds.  Visa: * \"I\" (fast funds are supported) * \"N\" (otherwise)  Mastercard: * \"I\" (product type is Prepaid or Debit, or issuing country is in CEE/HGEM list) * \"N\" (otherwise)  > Returned when you verify a card BIN or estimate costs, and only if payoutEligible is \"Y\" or \"D\".
    /// </summary>
    /// <value>Indicates availability of funds.  Visa: * \"I\" (fast funds are supported) * \"N\" (otherwise)  Mastercard: * \"I\" (product type is Prepaid or Debit, or issuing country is in CEE/HGEM list) * \"N\" (otherwise)  > Returned when you verify a card BIN or estimate costs, and only if payoutEligible is \"Y\" or \"D\".</value>
    [DataMember(Name="fundsAvailability", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fundsAvailability")]
    public string FundsAvailability { get; set; }

    /// <summary>
    /// Provides the more granular indication of why a transaction was refused. When a transaction fails with either \"Refused\", \"Restricted Card\", \"Transaction Not Permitted\", \"Not supported\" or \"DeclinedNon Generic\" refusalReason from the issuer, Adyen cross references its PSP-wide data for extra insight into the refusal reason. If an inferred refusal reason is available, the `inferredRefusalReason`, field is populated and the `refusalReason`, is set to \"Not Supported\".  Possible values:  * 3D Secure Mandated * Closed Account * ContAuth Not Supported * CVC Mandated * Ecommerce Not Allowed * Crossborder Not Supported * Card Updated  * Low Authrate Bin * Non-reloadable prepaid card
    /// </summary>
    /// <value>Provides the more granular indication of why a transaction was refused. When a transaction fails with either \"Refused\", \"Restricted Card\", \"Transaction Not Permitted\", \"Not supported\" or \"DeclinedNon Generic\" refusalReason from the issuer, Adyen cross references its PSP-wide data for extra insight into the refusal reason. If an inferred refusal reason is available, the `inferredRefusalReason`, field is populated and the `refusalReason`, is set to \"Not Supported\".  Possible values:  * 3D Secure Mandated * Closed Account * ContAuth Not Supported * CVC Mandated * Ecommerce Not Allowed * Crossborder Not Supported * Card Updated  * Low Authrate Bin * Non-reloadable prepaid card</value>
    [DataMember(Name="inferredRefusalReason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inferredRefusalReason")]
    public string InferredRefusalReason { get; set; }

    /// <summary>
    /// The issuing country of the card based on the BIN list that Adyen maintains.  Example: JP
    /// </summary>
    /// <value>The issuing country of the card based on the BIN list that Adyen maintains.  Example: JP</value>
    [DataMember(Name="issuerCountry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issuerCountry")]
    public string IssuerCountry { get; set; }

    /// <summary>
    /// The `mcBankNetReferenceNumber`, is a minimum of six characters and a maximum of nine characters long.  > Contact Support Team to enable this field.
    /// </summary>
    /// <value>The `mcBankNetReferenceNumber`, is a minimum of six characters and a maximum of nine characters long.  > Contact Support Team to enable this field.</value>
    [DataMember(Name="mcBankNetReferenceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mcBankNetReferenceNumber")]
    public string McBankNetReferenceNumber { get; set; }

    /// <summary>
    /// Returned in the response if you are not tokenizing with Adyen and are using the Merchant-initiated transactions (MIT) framework from Mastercard or Visa.  This contains either the Mastercard Trace ID or the Visa Transaction ID.
    /// </summary>
    /// <value>Returned in the response if you are not tokenizing with Adyen and are using the Merchant-initiated transactions (MIT) framework from Mastercard or Visa.  This contains either the Mastercard Trace ID or the Visa Transaction ID.</value>
    [DataMember(Name="networkTxReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "networkTxReference")]
    public string NetworkTxReference { get; set; }

    /// <summary>
    /// The owner name of a bank account.  Only relevant for SEPA Direct Debit transactions.
    /// </summary>
    /// <value>The owner name of a bank account.  Only relevant for SEPA Direct Debit transactions.</value>
    [DataMember(Name="ownerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownerName")]
    public string OwnerName { get; set; }

    /// <summary>
    /// The Payment Account Reference (PAR) value links a network token with the underlying primary account number (PAN). The PAR value consists of 29 uppercase alphanumeric characters.
    /// </summary>
    /// <value>The Payment Account Reference (PAR) value links a network token with the underlying primary account number (PAN). The PAR value consists of 29 uppercase alphanumeric characters.</value>
    [DataMember(Name="paymentAccountReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentAccountReference")]
    public string PaymentAccountReference { get; set; }

    /// <summary>
    /// The Adyen sub-variant of the payment method used for the payment request.  For more information, refer to [PaymentMethodVariant](https://docs.adyen.com/development-resources/paymentmethodvariant).  Example: mcpro
    /// </summary>
    /// <value>The Adyen sub-variant of the payment method used for the payment request.  For more information, refer to [PaymentMethodVariant](https://docs.adyen.com/development-resources/paymentmethodvariant).  Example: mcpro</value>
    [DataMember(Name="paymentMethodVariant", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentMethodVariant")]
    public string PaymentMethodVariant { get; set; }

    /// <summary>
    /// Indicates whether a payout is eligible or not for this card.  Visa: * \"Y\" * \"N\"  Mastercard: * \"Y\" (domestic and cross-border)  * \"D\" (only domestic) * \"N\" (no MoneySend) * \"U\" (unknown)
    /// </summary>
    /// <value>Indicates whether a payout is eligible or not for this card.  Visa: * \"Y\" * \"N\"  Mastercard: * \"Y\" (domestic and cross-border)  * \"D\" (only domestic) * \"N\" (no MoneySend) * \"U\" (unknown)</value>
    [DataMember(Name="payoutEligible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payoutEligible")]
    public string PayoutEligible { get; set; }

    /// <summary>
    /// The response code from the Real Time Account Updater service.  Possible return values are: * CardChanged * CardExpiryChanged * CloseAccount  * ContactCardAccountHolder
    /// </summary>
    /// <value>The response code from the Real Time Account Updater service.  Possible return values are: * CardChanged * CardExpiryChanged * CloseAccount  * ContactCardAccountHolder</value>
    [DataMember(Name="realtimeAccountUpdaterStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "realtimeAccountUpdaterStatus")]
    public string RealtimeAccountUpdaterStatus { get; set; }

    /// <summary>
    /// Message to be displayed on the terminal.
    /// </summary>
    /// <value>Message to be displayed on the terminal.</value>
    [DataMember(Name="receiptFreeText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "receiptFreeText")]
    public string ReceiptFreeText { get; set; }

    /// <summary>
    /// The `pspReference`, of the first recurring payment that created the recurring detail.  This functionality requires additional configuration on Adyen's end. To enable it, contact the Support Team.
    /// </summary>
    /// <value>The `pspReference`, of the first recurring payment that created the recurring detail.  This functionality requires additional configuration on Adyen's end. To enable it, contact the Support Team.</value>
    [DataMember(Name="recurring.firstPspReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurring.firstPspReference")]
    public string RecurringFirstPspReference { get; set; }

    /// <summary>
    /// The reference that uniquely identifies the recurring transaction.
    /// </summary>
    /// <value>The reference that uniquely identifies the recurring transaction.</value>
    [DataMember(Name="recurring.recurringDetailReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurring.recurringDetailReference")]
    public string RecurringRecurringDetailReference { get; set; }

    /// <summary>
    /// If the payment is referred, this field is set to true.  This field is unavailable if the payment is referred and is usually not returned with ecommerce transactions.  Example: true
    /// </summary>
    /// <value>If the payment is referred, this field is set to true.  This field is unavailable if the payment is referred and is usually not returned with ecommerce transactions.  Example: true</value>
    [DataMember(Name="referred", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referred")]
    public string Referred { get; set; }

    /// <summary>
    /// Raw refusal reason received from the acquirer, where available.  Example: AUTHORISED
    /// </summary>
    /// <value>Raw refusal reason received from the acquirer, where available.  Example: AUTHORISED</value>
    [DataMember(Name="refusalReasonRaw", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refusalReasonRaw")]
    public string RefusalReasonRaw { get; set; }

    /// <summary>
    /// The shopper interaction type of the payment request.  Example: Ecommerce
    /// </summary>
    /// <value>The shopper interaction type of the payment request.  Example: Ecommerce</value>
    [DataMember(Name="shopperInteraction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperInteraction")]
    public string ShopperInteraction { get; set; }

    /// <summary>
    /// The shopperReference passed in the payment request.  Example: AdyenTestShopperXX
    /// </summary>
    /// <value>The shopperReference passed in the payment request.  Example: AdyenTestShopperXX</value>
    [DataMember(Name="shopperReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperReference")]
    public string ShopperReference { get; set; }

    /// <summary>
    /// The terminal ID used in a point-of-sale payment.  Example: 06022622
    /// </summary>
    /// <value>The terminal ID used in a point-of-sale payment.  Example: 06022622</value>
    [DataMember(Name="terminalId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "terminalId")]
    public string TerminalId { get; set; }

    /// <summary>
    /// A Boolean value indicating whether 3DS authentication was completed on this payment.  Example: true
    /// </summary>
    /// <value>A Boolean value indicating whether 3DS authentication was completed on this payment.  Example: true</value>
    [DataMember(Name="threeDAuthenticated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "threeDAuthenticated")]
    public string ThreeDAuthenticated { get; set; }

    /// <summary>
    /// The raw 3DS authentication result from the card issuer.  Example: N
    /// </summary>
    /// <value>The raw 3DS authentication result from the card issuer.  Example: N</value>
    [DataMember(Name="threeDAuthenticatedResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "threeDAuthenticatedResponse")]
    public string ThreeDAuthenticatedResponse { get; set; }

    /// <summary>
    /// A Boolean value indicating whether 3DS was offered for this payment.  Example: true
    /// </summary>
    /// <value>A Boolean value indicating whether 3DS was offered for this payment.  Example: true</value>
    [DataMember(Name="threeDOffered", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "threeDOffered")]
    public string ThreeDOffered { get; set; }

    /// <summary>
    /// The raw enrollment result from the 3DS directory services of the card schemes.  Example: Y
    /// </summary>
    /// <value>The raw enrollment result from the 3DS directory services of the card schemes.  Example: Y</value>
    [DataMember(Name="threeDOfferedResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "threeDOfferedResponse")]
    public string ThreeDOfferedResponse { get; set; }

    /// <summary>
    /// The 3D Secure 2 version.
    /// </summary>
    /// <value>The 3D Secure 2 version.</value>
    [DataMember(Name="threeDSVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "threeDSVersion")]
    public string ThreeDSVersion { get; set; }

    /// <summary>
    /// The `visaTransactionId`, has a fixed length of 15 numeric characters.  > Contact Support Team to enable this field.
    /// </summary>
    /// <value>The `visaTransactionId`, has a fixed length of 15 numeric characters.  > Contact Support Team to enable this field.</value>
    [DataMember(Name="visaTransactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visaTransactionId")]
    public string VisaTransactionId { get; set; }

    /// <summary>
    /// The 3DS transaction ID of the 3DS session sent in notifications. The value is Base64-encoded and is returned for transactions with directoryResponse 'N' or 'Y'. If you want to submit the xid in your 3D Secure 1 request, use the `mpiData.xid`, field.  Example: ODgxNDc2MDg2MDExODk5MAAAAAA=
    /// </summary>
    /// <value>The 3DS transaction ID of the 3DS session sent in notifications. The value is Base64-encoded and is returned for transactions with directoryResponse 'N' or 'Y'. If you want to submit the xid in your 3D Secure 1 request, use the `mpiData.xid`, field.  Example: ODgxNDc2MDg2MDExODk5MAAAAAA=</value>
    [DataMember(Name="xid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "xid")]
    public string Xid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
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
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
