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
  public class CheckoutThreeDS2FingerPrintAction {
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
    /// A token to pass to the 3DS2 Component to get the fingerprint.
    /// </summary>
    /// <value>A token to pass to the 3DS2 Component to get the fingerprint.</value>
    [DataMember(Name="token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token")]
    public string Token { get; set; }

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
      sb.Append("class CheckoutThreeDS2FingerPrintAction {\n");
      sb.Append("  PaymentData: ").Append(PaymentData).Append("\n");
      sb.Append("  PaymentMethodType: ").Append(PaymentMethodType).Append("\n");
      sb.Append("  Token: ").Append(Token).Append("\n");
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
