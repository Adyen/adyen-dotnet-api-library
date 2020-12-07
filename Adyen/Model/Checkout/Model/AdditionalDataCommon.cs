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
  public class AdditionalDataCommon {
    /// <summary>
    /// Triggers test scenarios that allow to replicate certain communication errors.  Allowed values: * **NO_CONNECTION_AVAILABLE** – There wasn't a connection available to service the outgoing communication. This is a transient, retriable error since no messaging could be initiated to an issuing system (or third-party acquiring system). Therefore, the header Transient-Error: true is returned in the response. A subsequent request using the same idempotency key will be processed as if it was the first request. * **IOEXCEPTION_RECEIVED** – Something went wrong during transmission of the message or receiving the response. This is a classified as non-transient because the message could have been received by the issuing party and been acted upon. No transient error header is returned. If using idempotency, the (error) response is stored as the final result for the idempotency key. Subsequent messages with the same idempotency key not be processed beyond returning the stored response.
    /// </summary>
    /// <value>Triggers test scenarios that allow to replicate certain communication errors.  Allowed values: * **NO_CONNECTION_AVAILABLE** – There wasn't a connection available to service the outgoing communication. This is a transient, retriable error since no messaging could be initiated to an issuing system (or third-party acquiring system). Therefore, the header Transient-Error: true is returned in the response. A subsequent request using the same idempotency key will be processed as if it was the first request. * **IOEXCEPTION_RECEIVED** – Something went wrong during transmission of the message or receiving the response. This is a classified as non-transient because the message could have been received by the issuing party and been acted upon. No transient error header is returned. If using idempotency, the (error) response is stored as the final result for the idempotency key. Subsequent messages with the same idempotency key not be processed beyond returning the stored response.</value>
    [DataMember(Name="RequestedTestErrorResponseCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestedTestErrorResponseCode")]
    public string RequestedTestErrorResponseCode { get; set; }

    /// <summary>
    /// Flags a card payment request for either pre-authorisation or final authorisation. For more information, refer to [Authorisation types](https://docs.adyen.com/checkout/adjust-authorisation#authorisation-types).  Allowed values: * **PreAuth** – flags the payment request to be handled as a pre-authorisation. * **FinalAuth** – flags the payment request to be handled as a final authorisation.
    /// </summary>
    /// <value>Flags a card payment request for either pre-authorisation or final authorisation. For more information, refer to [Authorisation types](https://docs.adyen.com/checkout/adjust-authorisation#authorisation-types).  Allowed values: * **PreAuth** – flags the payment request to be handled as a pre-authorisation. * **FinalAuth** – flags the payment request to be handled as a final authorisation.</value>
    [DataMember(Name="authorisationType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authorisationType")]
    public string AuthorisationType { get; set; }

    /// <summary>
    /// Allows you to determine or override the acquirer account that should be used for the transaction.  If you need to process a payment with an acquirer different from a default one, you can set up a corresponding configuration on the Adyen payments platform. Then you can pass a custom routing flag in a payment request's additional data to target a specific acquirer.  To enable this functionality, contact [Support](https://support.adyen.com/hc/en-us/requests/new).
    /// </summary>
    /// <value>Allows you to determine or override the acquirer account that should be used for the transaction.  If you need to process a payment with an acquirer different from a default one, you can set up a corresponding configuration on the Adyen payments platform. Then you can pass a custom routing flag in a payment request's additional data to target a specific acquirer.  To enable this functionality, contact [Support](https://support.adyen.com/hc/en-us/requests/new).</value>
    [DataMember(Name="customRoutingFlag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customRoutingFlag")]
    public string CustomRoutingFlag { get; set; }

    /// <summary>
    /// In case of [asynchronous authorisation adjustment](https://docs.adyen.com/checkout/adjust-authorisation#adjust-authorisation), this field denotes why the additional payment is made.  Possible values:   * **NoShow**: An incremental charge is carried out because of a no-show for a guaranteed reservation.   * **DelayedCharge**: An incremental charge is carried out to process an additional payment after the original services have been rendered and the respective payment has been processed.
    /// </summary>
    /// <value>In case of [asynchronous authorisation adjustment](https://docs.adyen.com/checkout/adjust-authorisation#adjust-authorisation), this field denotes why the additional payment is made.  Possible values:   * **NoShow**: An incremental charge is carried out because of a no-show for a guaranteed reservation.   * **DelayedCharge**: An incremental charge is carried out to process an additional payment after the original services have been rendered and the respective payment has been processed.</value>
    [DataMember(Name="industryUsage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "industryUsage")]
    public string IndustryUsage { get; set; }

    /// <summary>
    /// Allows you to link the transaction to the original or previous one in a subscription/card-on-file chain. This field is required for token-based transactions where Adyen does not tokenize the card.  Transaction identifier from card schemes, for example, Mastercard Trace ID or the Visa Transaction ID.  Submit the original transaction ID of the contract in your payment request if you are not tokenizing card details with Adyen and are making a merchant-initiated transaction (MIT) for subsequent charges.  Make sure you are sending `shopperInteraction` **ContAuth** and `recurringProcessingModel` **Subscription** or **UnscheduledCardOnFile** to ensure that the transaction is classified as MIT.
    /// </summary>
    /// <value>Allows you to link the transaction to the original or previous one in a subscription/card-on-file chain. This field is required for token-based transactions where Adyen does not tokenize the card.  Transaction identifier from card schemes, for example, Mastercard Trace ID or the Visa Transaction ID.  Submit the original transaction ID of the contract in your payment request if you are not tokenizing card details with Adyen and are making a merchant-initiated transaction (MIT) for subsequent charges.  Make sure you are sending `shopperInteraction` **ContAuth** and `recurringProcessingModel` **Subscription** or **UnscheduledCardOnFile** to ensure that the transaction is classified as MIT.</value>
    [DataMember(Name="networkTxReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "networkTxReference")]
    public string NetworkTxReference { get; set; }

    /// <summary>
    /// Boolean indicator that can be optionally used for performing debit transactions on combo cards (for example, combo cards in Brazil). This is not mandatory but we recommend that you set this to true if you want to use the `selectedBrand` value to specify how to process the transaction.
    /// </summary>
    /// <value>Boolean indicator that can be optionally used for performing debit transactions on combo cards (for example, combo cards in Brazil). This is not mandatory but we recommend that you set this to true if you want to use the `selectedBrand` value to specify how to process the transaction.</value>
    [DataMember(Name="overwriteBrand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overwriteBrand")]
    public string OverwriteBrand { get; set; }

    /// <summary>
    /// This field is required if the transaction is performed by a registered payment facilitator. This field must contain the city of the actual merchant's address. * Format: alpha-numeric. * Maximum length: 13 characters.
    /// </summary>
    /// <value>This field is required if the transaction is performed by a registered payment facilitator. This field must contain the city of the actual merchant's address. * Format: alpha-numeric. * Maximum length: 13 characters.</value>
    [DataMember(Name="subMerchantCity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subMerchantCity")]
    public string SubMerchantCity { get; set; }

    /// <summary>
    /// This field is required if the transaction is performed by a registered payment facilitator. This field must contain the three-letter country code of the actual merchant's address. * Format: alpha-numeric. * Fixed length: 3 characters.
    /// </summary>
    /// <value>This field is required if the transaction is performed by a registered payment facilitator. This field must contain the three-letter country code of the actual merchant's address. * Format: alpha-numeric. * Fixed length: 3 characters.</value>
    [DataMember(Name="subMerchantCountry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subMerchantCountry")]
    public string SubMerchantCountry { get; set; }

    /// <summary>
    /// This field contains an identifier of the actual merchant when a transaction is submitted via a payment facilitator. The payment facilitator must send in this unique ID.  A unique identifier per submerchant that is required if the transaction is performed by a registered payment facilitator. * Format: alpha-numeric. * Fixed length: 15 characters.
    /// </summary>
    /// <value>This field contains an identifier of the actual merchant when a transaction is submitted via a payment facilitator. The payment facilitator must send in this unique ID.  A unique identifier per submerchant that is required if the transaction is performed by a registered payment facilitator. * Format: alpha-numeric. * Fixed length: 15 characters.</value>
    [DataMember(Name="subMerchantID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subMerchantID")]
    public string SubMerchantID { get; set; }

    /// <summary>
    /// This field is required if the transaction is performed by a registered payment facilitator. This field must contain the name of the actual merchant. * Format: alpha-numeric. * Maximum length: 22 characters.
    /// </summary>
    /// <value>This field is required if the transaction is performed by a registered payment facilitator. This field must contain the name of the actual merchant. * Format: alpha-numeric. * Maximum length: 22 characters.</value>
    [DataMember(Name="subMerchantName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subMerchantName")]
    public string SubMerchantName { get; set; }

    /// <summary>
    /// This field is required if the transaction is performed by a registered payment facilitator. This field must contain the postal code of the actual merchant's address. * Format: alpha-numeric. * Maximum length: 10 characters.
    /// </summary>
    /// <value>This field is required if the transaction is performed by a registered payment facilitator. This field must contain the postal code of the actual merchant's address. * Format: alpha-numeric. * Maximum length: 10 characters.</value>
    [DataMember(Name="subMerchantPostalCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subMerchantPostalCode")]
    public string SubMerchantPostalCode { get; set; }

    /// <summary>
    /// This field is required if the transaction is performed by a registered payment facilitator, and if applicable to the country. This field must contain the state code of the actual merchant's address. * Format: alpha-numeric. * Maximum length: 3 characters.
    /// </summary>
    /// <value>This field is required if the transaction is performed by a registered payment facilitator, and if applicable to the country. This field must contain the state code of the actual merchant's address. * Format: alpha-numeric. * Maximum length: 3 characters.</value>
    [DataMember(Name="subMerchantState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subMerchantState")]
    public string SubMerchantState { get; set; }

    /// <summary>
    /// This field is required if the transaction is performed by a registered payment facilitator. This field must contain the street of the actual merchant's address. * Format: alpha-numeric. * Maximum length: 60 characters.
    /// </summary>
    /// <value>This field is required if the transaction is performed by a registered payment facilitator. This field must contain the street of the actual merchant's address. * Format: alpha-numeric. * Maximum length: 60 characters.</value>
    [DataMember(Name="subMerchantStreet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subMerchantStreet")]
    public string SubMerchantStreet { get; set; }

    /// <summary>
    /// This field is required if the transaction is performed by a registered payment facilitator. This field must contain the tax ID of the actual merchant. * Format: alpha-numeric. * Fixed length: 11 or 14 characters.
    /// </summary>
    /// <value>This field is required if the transaction is performed by a registered payment facilitator. This field must contain the tax ID of the actual merchant. * Format: alpha-numeric. * Fixed length: 11 or 14 characters.</value>
    [DataMember(Name="subMerchantTaxId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subMerchantTaxId")]
    public string SubMerchantTaxId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AdditionalDataCommon {\n");
      sb.Append("  RequestedTestErrorResponseCode: ").Append(RequestedTestErrorResponseCode).Append("\n");
      sb.Append("  AuthorisationType: ").Append(AuthorisationType).Append("\n");
      sb.Append("  CustomRoutingFlag: ").Append(CustomRoutingFlag).Append("\n");
      sb.Append("  IndustryUsage: ").Append(IndustryUsage).Append("\n");
      sb.Append("  NetworkTxReference: ").Append(NetworkTxReference).Append("\n");
      sb.Append("  OverwriteBrand: ").Append(OverwriteBrand).Append("\n");
      sb.Append("  SubMerchantCity: ").Append(SubMerchantCity).Append("\n");
      sb.Append("  SubMerchantCountry: ").Append(SubMerchantCountry).Append("\n");
      sb.Append("  SubMerchantID: ").Append(SubMerchantID).Append("\n");
      sb.Append("  SubMerchantName: ").Append(SubMerchantName).Append("\n");
      sb.Append("  SubMerchantPostalCode: ").Append(SubMerchantPostalCode).Append("\n");
      sb.Append("  SubMerchantState: ").Append(SubMerchantState).Append("\n");
      sb.Append("  SubMerchantStreet: ").Append(SubMerchantStreet).Append("\n");
      sb.Append("  SubMerchantTaxId: ").Append(SubMerchantTaxId).Append("\n");
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
