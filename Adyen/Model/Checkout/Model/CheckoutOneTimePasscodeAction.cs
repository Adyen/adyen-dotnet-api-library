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
  public class CheckoutOneTimePasscodeAction {
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
    /// Gets or Sets Redirect
    /// </summary>
    [DataMember(Name="redirect", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redirect")]
    public Redirect Redirect { get; set; }

    /// <summary>
    /// The interval in second between OTP resend.
    /// </summary>
    /// <value>The interval in second between OTP resend.</value>
    [DataMember(Name="resendInterval", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resendInterval")]
    public int? ResendInterval { get; set; }

    /// <summary>
    /// The maximum number of OTP resend attempts.
    /// </summary>
    /// <value>The maximum number of OTP resend attempts.</value>
    [DataMember(Name="resendMaxAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resendMaxAttempts")]
    public int? ResendMaxAttempts { get; set; }

    /// <summary>
    /// The URL, to which you make POST request to trigger OTP resend.
    /// </summary>
    /// <value>The URL, to which you make POST request to trigger OTP resend.</value>
    [DataMember(Name="resendUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resendUrl")]
    public string ResendUrl { get; set; }

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
      sb.Append("class CheckoutOneTimePasscodeAction {\n");
      sb.Append("  PaymentData: ").Append(PaymentData).Append("\n");
      sb.Append("  PaymentMethodType: ").Append(PaymentMethodType).Append("\n");
      sb.Append("  Redirect: ").Append(Redirect).Append("\n");
      sb.Append("  ResendInterval: ").Append(ResendInterval).Append("\n");
      sb.Append("  ResendMaxAttempts: ").Append(ResendMaxAttempts).Append("\n");
      sb.Append("  ResendUrl: ").Append(ResendUrl).Append("\n");
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
