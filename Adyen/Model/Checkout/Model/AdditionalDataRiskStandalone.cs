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
  public class AdditionalDataRiskStandalone {
    /// <summary>
    /// Shopper's country of residence in the form of ISO standard 3166 2-character country codes.
    /// </summary>
    /// <value>Shopper's country of residence in the form of ISO standard 3166 2-character country codes.</value>
    [DataMember(Name="PayPal.CountryCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PayPal.CountryCode")]
    public string PayPalCountryCode { get; set; }

    /// <summary>
    /// Shopper's email.
    /// </summary>
    /// <value>Shopper's email.</value>
    [DataMember(Name="PayPal.EmailId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PayPal.EmailId")]
    public string PayPalEmailId { get; set; }

    /// <summary>
    /// Shopper's first name.
    /// </summary>
    /// <value>Shopper's first name.</value>
    [DataMember(Name="PayPal.FirstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PayPal.FirstName")]
    public string PayPalFirstName { get; set; }

    /// <summary>
    /// Shopper's last name.
    /// </summary>
    /// <value>Shopper's last name.</value>
    [DataMember(Name="PayPal.LastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PayPal.LastName")]
    public string PayPalLastName { get; set; }

    /// <summary>
    /// Unique PayPal Customer Account identification number. Character length and limitations: 13 single-byte alphanumeric characters.
    /// </summary>
    /// <value>Unique PayPal Customer Account identification number. Character length and limitations: 13 single-byte alphanumeric characters.</value>
    [DataMember(Name="PayPal.PayerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PayPal.PayerId")]
    public string PayPalPayerId { get; set; }

    /// <summary>
    /// Shopper's phone number.
    /// </summary>
    /// <value>Shopper's phone number.</value>
    [DataMember(Name="PayPal.Phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PayPal.Phone")]
    public string PayPalPhone { get; set; }

    /// <summary>
    /// Allowed values: * **Eligible** — Merchant is protected by PayPal's Seller Protection Policy for Unauthorized Payments and Item Not Received.  * **PartiallyEligible** — Merchant is protected by PayPal's Seller Protection Policy for Item Not Received.  * **Ineligible** — Merchant is not protected under the Seller Protection Policy.
    /// </summary>
    /// <value>Allowed values: * **Eligible** — Merchant is protected by PayPal's Seller Protection Policy for Unauthorized Payments and Item Not Received.  * **PartiallyEligible** — Merchant is protected by PayPal's Seller Protection Policy for Item Not Received.  * **Ineligible** — Merchant is not protected under the Seller Protection Policy.</value>
    [DataMember(Name="PayPal.ProtectionEligibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PayPal.ProtectionEligibility")]
    public string PayPalProtectionEligibility { get; set; }

    /// <summary>
    /// Unique transaction ID of the payment.
    /// </summary>
    /// <value>Unique transaction ID of the payment.</value>
    [DataMember(Name="PayPal.TransactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PayPal.TransactionId")]
    public string PayPalTransactionId { get; set; }

    /// <summary>
    /// Raw AVS result received from the acquirer, where available. Example: D
    /// </summary>
    /// <value>Raw AVS result received from the acquirer, where available. Example: D</value>
    [DataMember(Name="avsResultRaw", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avsResultRaw")]
    public string AvsResultRaw { get; set; }

    /// <summary>
    /// The Bank Identification Number of a credit card, which is the first six digits of a card number. Required for [tokenized card request](https://docs.adyen.com/risk-management/standalone-risk#tokenised-pan-request).
    /// </summary>
    /// <value>The Bank Identification Number of a credit card, which is the first six digits of a card number. Required for [tokenized card request](https://docs.adyen.com/risk-management/standalone-risk#tokenised-pan-request).</value>
    [DataMember(Name="bin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bin")]
    public string Bin { get; set; }

    /// <summary>
    /// Raw CVC result received from the acquirer, where available. Example: 1
    /// </summary>
    /// <value>Raw CVC result received from the acquirer, where available. Example: 1</value>
    [DataMember(Name="cvcResultRaw", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cvcResultRaw")]
    public string CvcResultRaw { get; set; }

    /// <summary>
    /// Unique identifier or token for the shopper's card details.
    /// </summary>
    /// <value>Unique identifier or token for the shopper's card details.</value>
    [DataMember(Name="riskToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "riskToken")]
    public string RiskToken { get; set; }

    /// <summary>
    /// A Boolean value indicating whether 3DS authentication was completed on this payment. Example: true
    /// </summary>
    /// <value>A Boolean value indicating whether 3DS authentication was completed on this payment. Example: true</value>
    [DataMember(Name="threeDAuthenticated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "threeDAuthenticated")]
    public string ThreeDAuthenticated { get; set; }

    /// <summary>
    /// A Boolean value indicating whether 3DS was offered for this payment. Example: true
    /// </summary>
    /// <value>A Boolean value indicating whether 3DS was offered for this payment. Example: true</value>
    [DataMember(Name="threeDOffered", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "threeDOffered")]
    public string ThreeDOffered { get; set; }

    /// <summary>
    /// Required for PayPal payments only. The only supported value is: **paypal**.
    /// </summary>
    /// <value>Required for PayPal payments only. The only supported value is: **paypal**.</value>
    [DataMember(Name="tokenDataType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tokenDataType")]
    public string TokenDataType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AdditionalDataRiskStandalone {\n");
      sb.Append("  PayPalCountryCode: ").Append(PayPalCountryCode).Append("\n");
      sb.Append("  PayPalEmailId: ").Append(PayPalEmailId).Append("\n");
      sb.Append("  PayPalFirstName: ").Append(PayPalFirstName).Append("\n");
      sb.Append("  PayPalLastName: ").Append(PayPalLastName).Append("\n");
      sb.Append("  PayPalPayerId: ").Append(PayPalPayerId).Append("\n");
      sb.Append("  PayPalPhone: ").Append(PayPalPhone).Append("\n");
      sb.Append("  PayPalProtectionEligibility: ").Append(PayPalProtectionEligibility).Append("\n");
      sb.Append("  PayPalTransactionId: ").Append(PayPalTransactionId).Append("\n");
      sb.Append("  AvsResultRaw: ").Append(AvsResultRaw).Append("\n");
      sb.Append("  Bin: ").Append(Bin).Append("\n");
      sb.Append("  CvcResultRaw: ").Append(CvcResultRaw).Append("\n");
      sb.Append("  RiskToken: ").Append(RiskToken).Append("\n");
      sb.Append("  ThreeDAuthenticated: ").Append(ThreeDAuthenticated).Append("\n");
      sb.Append("  ThreeDOffered: ").Append(ThreeDOffered).Append("\n");
      sb.Append("  TokenDataType: ").Append(TokenDataType).Append("\n");
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
