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
  public class ResponseAdditionalDataCard {
    /// <summary>
    /// The Bank Identification Number of a credit card, which is the first six digits of a card number.  Example: 521234
    /// </summary>
    /// <value>The Bank Identification Number of a credit card, which is the first six digits of a card number.  Example: 521234</value>
    [DataMember(Name="cardBin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardBin")]
    public string CardBin { get; set; }

    /// <summary>
    /// The cardholder name passed in the payment request.
    /// </summary>
    /// <value>The cardholder name passed in the payment request.</value>
    [DataMember(Name="cardHolderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardHolderName")]
    public string CardHolderName { get; set; }

    /// <summary>
    /// The bank or the financial institution granting lines of credit through card association branded payment cards. This information can be included when available.
    /// </summary>
    /// <value>The bank or the financial institution granting lines of credit through card association branded payment cards. This information can be included when available.</value>
    [DataMember(Name="cardIssuingBank", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardIssuingBank")]
    public string CardIssuingBank { get; set; }

    /// <summary>
    /// The country where the card was issued.  Example: US
    /// </summary>
    /// <value>The country where the card was issued.  Example: US</value>
    [DataMember(Name="cardIssuingCountry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardIssuingCountry")]
    public string CardIssuingCountry { get; set; }

    /// <summary>
    /// The currency in which the card is issued, if this information is available. Provided as the currency code or currency number from the ISO-4217 standard.   Example: USD
    /// </summary>
    /// <value>The currency in which the card is issued, if this information is available. Provided as the currency code or currency number from the ISO-4217 standard.   Example: USD</value>
    [DataMember(Name="cardIssuingCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardIssuingCurrency")]
    public string CardIssuingCurrency { get; set; }

    /// <summary>
    /// The card payment method used for the transaction.  Example: amex
    /// </summary>
    /// <value>The card payment method used for the transaction.  Example: amex</value>
    [DataMember(Name="cardPaymentMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardPaymentMethod")]
    public string CardPaymentMethod { get; set; }

    /// <summary>
    /// The last four digits of a card number.  > Returned only in case of a card payment.
    /// </summary>
    /// <value>The last four digits of a card number.  > Returned only in case of a card payment.</value>
    [DataMember(Name="cardSummary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardSummary")]
    public string CardSummary { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ResponseAdditionalDataCard {\n");
      sb.Append("  CardBin: ").Append(CardBin).Append("\n");
      sb.Append("  CardHolderName: ").Append(CardHolderName).Append("\n");
      sb.Append("  CardIssuingBank: ").Append(CardIssuingBank).Append("\n");
      sb.Append("  CardIssuingCountry: ").Append(CardIssuingCountry).Append("\n");
      sb.Append("  CardIssuingCurrency: ").Append(CardIssuingCurrency).Append("\n");
      sb.Append("  CardPaymentMethod: ").Append(CardPaymentMethod).Append("\n");
      sb.Append("  CardSummary: ").Append(CardSummary).Append("\n");
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
