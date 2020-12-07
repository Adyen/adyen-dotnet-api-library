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
  public class CheckoutBankTransferAction {
    /// <summary>
    /// The name of the account holder.
    /// </summary>
    /// <value>The name of the account holder.</value>
    [DataMember(Name="beneficiary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "beneficiary")]
    public string Beneficiary { get; set; }

    /// <summary>
    /// The BIC of the IBAN.
    /// </summary>
    /// <value>The BIC of the IBAN.</value>
    [DataMember(Name="bic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bic")]
    public string Bic { get; set; }

    /// <summary>
    /// The url to download payment details with.
    /// </summary>
    /// <value>The url to download payment details with.</value>
    [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "downloadUrl")]
    public string DownloadUrl { get; set; }

    /// <summary>
    /// The IBAN of the bank transfer.
    /// </summary>
    /// <value>The IBAN of the bank transfer.</value>
    [DataMember(Name="iban", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iban")]
    public string Iban { get; set; }

    /// <summary>
    /// When non-empty, contains a value that you must submit to the `/payments/details` endpoint. In some cases, required for polling.
    /// </summary>
    /// <value>When non-empty, contains a value that you must submit to the `/payments/details` endpoint. In some cases, required for polling.</value>
    [DataMember(Name="paymentData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentData")]
    public string PaymentData { get; set; }

    /// <summary>
    /// Specifies the payment method.
    /// </summary>
    /// <value>Specifies the payment method.</value>
    [DataMember(Name="paymentMethodType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentMethodType")]
    public string PaymentMethodType { get; set; }

    /// <summary>
    /// The transfer reference.
    /// </summary>
    /// <value>The transfer reference.</value>
    [DataMember(Name="reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reference")]
    public string Reference { get; set; }

    /// <summary>
    /// The e-mail of the shopper, included if an e-mail was sent to the shopper.
    /// </summary>
    /// <value>The e-mail of the shopper, included if an e-mail was sent to the shopper.</value>
    [DataMember(Name="shopperEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperEmail")]
    public string ShopperEmail { get; set; }

    /// <summary>
    /// Gets or Sets TotalAmount
    /// </summary>
    [DataMember(Name="totalAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalAmount")]
    public Amount TotalAmount { get; set; }

    /// <summary>
    /// The type of bank transfer.
    /// </summary>
    /// <value>The type of bank transfer.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Specifies the URL to redirect to.
    /// </summary>
    /// <value>Specifies the URL to redirect to.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CheckoutBankTransferAction {\n");
      sb.Append("  Beneficiary: ").Append(Beneficiary).Append("\n");
      sb.Append("  Bic: ").Append(Bic).Append("\n");
      sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
      sb.Append("  Iban: ").Append(Iban).Append("\n");
      sb.Append("  PaymentData: ").Append(PaymentData).Append("\n");
      sb.Append("  PaymentMethodType: ").Append(PaymentMethodType).Append("\n");
      sb.Append("  Reference: ").Append(Reference).Append("\n");
      sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
      sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
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
