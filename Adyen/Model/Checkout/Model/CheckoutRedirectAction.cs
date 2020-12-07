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
  public class CheckoutRedirectAction {
    /// <summary>
    /// When the redirect URL must be accessed via POST, use this data to post to the redirect URL.
    /// </summary>
    /// <value>When the redirect URL must be accessed via POST, use this data to post to the redirect URL.</value>
    [DataMember(Name="data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "data")]
    public Dictionary<string, string> Data { get; set; }

    /// <summary>
    /// Specifies the HTTP method, for example GET or POST.
    /// </summary>
    /// <value>Specifies the HTTP method, for example GET or POST.</value>
    [DataMember(Name="method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "method")]
    public string Method { get; set; }

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
      sb.Append("class CheckoutRedirectAction {\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
      sb.Append("  Method: ").Append(Method).Append("\n");
      sb.Append("  PaymentData: ").Append(PaymentData).Append("\n");
      sb.Append("  PaymentMethodType: ").Append(PaymentMethodType).Append("\n");
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
