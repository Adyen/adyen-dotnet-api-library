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
  public class CardDetails {
    /// <summary>
    /// Brand of the card. For example: **plastix**, **hmclub**.
    /// </summary>
    /// <value>Brand of the card. For example: **plastix**, **hmclub**.</value>
    [DataMember(Name="brand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brand")]
    public string Brand { get; set; }

    /// <summary>
    /// Gets or Sets CupsecureplusSmscode
    /// </summary>
    [DataMember(Name="cupsecureplus.smscode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cupsecureplus.smscode")]
    public string CupsecureplusSmscode { get; set; }

    /// <summary>
    /// Gets or Sets Cvc
    /// </summary>
    [DataMember(Name="cvc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cvc")]
    public string Cvc { get; set; }

    /// <summary>
    /// Gets or Sets EncryptedCardNumber
    /// </summary>
    [DataMember(Name="encryptedCardNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "encryptedCardNumber")]
    public string EncryptedCardNumber { get; set; }

    /// <summary>
    /// Gets or Sets EncryptedExpiryMonth
    /// </summary>
    [DataMember(Name="encryptedExpiryMonth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "encryptedExpiryMonth")]
    public string EncryptedExpiryMonth { get; set; }

    /// <summary>
    /// Gets or Sets EncryptedExpiryYear
    /// </summary>
    [DataMember(Name="encryptedExpiryYear", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "encryptedExpiryYear")]
    public string EncryptedExpiryYear { get; set; }

    /// <summary>
    /// Gets or Sets ExpiryMonth
    /// </summary>
    [DataMember(Name="expiryMonth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiryMonth")]
    public string ExpiryMonth { get; set; }

    /// <summary>
    /// Gets or Sets ExpiryYear
    /// </summary>
    [DataMember(Name="expiryYear", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiryYear")]
    public string ExpiryYear { get; set; }

    /// <summary>
    /// Gets or Sets FundingSource
    /// </summary>
    [DataMember(Name="fundingSource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fundingSource")]
    public string FundingSource { get; set; }

    /// <summary>
    /// Gets or Sets HolderName
    /// </summary>
    [DataMember(Name="holderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "holderName")]
    public string HolderName { get; set; }

    /// <summary>
    /// Gets or Sets Number
    /// </summary>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public string Number { get; set; }

    /// <summary>
    /// This is the `recurringDetailReference` returned in the response when you created the token.
    /// </summary>
    /// <value>This is the `recurringDetailReference` returned in the response when you created the token.</value>
    [DataMember(Name="recurringDetailReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurringDetailReference")]
    public string RecurringDetailReference { get; set; }

    /// <summary>
    /// This is the `recurringDetailReference` returned in the response when you created the token.
    /// </summary>
    /// <value>This is the `recurringDetailReference` returned in the response when you created the token.</value>
    [DataMember(Name="storedPaymentMethodId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storedPaymentMethodId")]
    public string StoredPaymentMethodId { get; set; }

    /// <summary>
    /// **scheme**
    /// </summary>
    /// <value>**scheme**</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CardDetails {\n");
      sb.Append("  Brand: ").Append(Brand).Append("\n");
      sb.Append("  CupsecureplusSmscode: ").Append(CupsecureplusSmscode).Append("\n");
      sb.Append("  Cvc: ").Append(Cvc).Append("\n");
      sb.Append("  EncryptedCardNumber: ").Append(EncryptedCardNumber).Append("\n");
      sb.Append("  EncryptedExpiryMonth: ").Append(EncryptedExpiryMonth).Append("\n");
      sb.Append("  EncryptedExpiryYear: ").Append(EncryptedExpiryYear).Append("\n");
      sb.Append("  ExpiryMonth: ").Append(ExpiryMonth).Append("\n");
      sb.Append("  ExpiryYear: ").Append(ExpiryYear).Append("\n");
      sb.Append("  FundingSource: ").Append(FundingSource).Append("\n");
      sb.Append("  HolderName: ").Append(HolderName).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
      sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
