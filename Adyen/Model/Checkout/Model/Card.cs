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
  public class Card {
    /// <summary>
    /// The [card verification code](https://docs.adyen.com/payments-fundamentals/payment-glossary#card-security-code-cvc-cvv-cid) (1-20 characters). Depending on the card brand, it is known also as: * CVV2/CVC2 – length: 3 digits * CID – length: 4 digits > If you are using [Client-Side Encryption](https://docs.adyen.com/classic-integration/cse-integration-ecommerce), the CVC code is present in the encrypted data. You must never post the card details to the server. > This field must be always present in a [one-click payment request](https://docs.adyen.com/classic-integration/recurring-payments). > When this value is returned in a response, it is always empty because it is not stored.
    /// </summary>
    /// <value>The [card verification code](https://docs.adyen.com/payments-fundamentals/payment-glossary#card-security-code-cvc-cvv-cid) (1-20 characters). Depending on the card brand, it is known also as: * CVV2/CVC2 – length: 3 digits * CID – length: 4 digits > If you are using [Client-Side Encryption](https://docs.adyen.com/classic-integration/cse-integration-ecommerce), the CVC code is present in the encrypted data. You must never post the card details to the server. > This field must be always present in a [one-click payment request](https://docs.adyen.com/classic-integration/recurring-payments). > When this value is returned in a response, it is always empty because it is not stored.</value>
    [DataMember(Name="cvc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cvc")]
    public string Cvc { get; set; }

    /// <summary>
    /// The card expiry month. Format: 2 digits, zero-padded for single digits. For example: * 03 = March * 11 = November
    /// </summary>
    /// <value>The card expiry month. Format: 2 digits, zero-padded for single digits. For example: * 03 = March * 11 = November</value>
    [DataMember(Name="expiryMonth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiryMonth")]
    public string ExpiryMonth { get; set; }

    /// <summary>
    /// The card expiry year. Format: 4 digits. For example: 2020
    /// </summary>
    /// <value>The card expiry year. Format: 4 digits. For example: 2020</value>
    [DataMember(Name="expiryYear", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiryYear")]
    public string ExpiryYear { get; set; }

    /// <summary>
    /// The name of the cardholder, as printed on the card.
    /// </summary>
    /// <value>The name of the cardholder, as printed on the card.</value>
    [DataMember(Name="holderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "holderName")]
    public string HolderName { get; set; }

    /// <summary>
    /// The issue number of the card (for some UK debit cards only).
    /// </summary>
    /// <value>The issue number of the card (for some UK debit cards only).</value>
    [DataMember(Name="issueNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueNumber")]
    public string IssueNumber { get; set; }

    /// <summary>
    /// The card number (4-19 characters). Do not use any separators. When this value is returned in a response, only the last 4 digits of the card number are returned.
    /// </summary>
    /// <value>The card number (4-19 characters). Do not use any separators. When this value is returned in a response, only the last 4 digits of the card number are returned.</value>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public string Number { get; set; }

    /// <summary>
    /// The month component of the start date (for some UK debit cards only).
    /// </summary>
    /// <value>The month component of the start date (for some UK debit cards only).</value>
    [DataMember(Name="startMonth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startMonth")]
    public string StartMonth { get; set; }

    /// <summary>
    /// The year component of the start date (for some UK debit cards only).
    /// </summary>
    /// <value>The year component of the start date (for some UK debit cards only).</value>
    [DataMember(Name="startYear", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startYear")]
    public string StartYear { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Card {\n");
      sb.Append("  Cvc: ").Append(Cvc).Append("\n");
      sb.Append("  ExpiryMonth: ").Append(ExpiryMonth).Append("\n");
      sb.Append("  ExpiryYear: ").Append(ExpiryYear).Append("\n");
      sb.Append("  HolderName: ").Append(HolderName).Append("\n");
      sb.Append("  IssueNumber: ").Append(IssueNumber).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  StartMonth: ").Append(StartMonth).Append("\n");
      sb.Append("  StartYear: ").Append(StartYear).Append("\n");
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
