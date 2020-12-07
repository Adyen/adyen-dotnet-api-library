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
  public class DetailsRequest {
    /// <summary>
    /// Gets or Sets Details
    /// </summary>
    [DataMember(Name="details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "details")]
    public PaymentCompletionDetails Details { get; set; }

    /// <summary>
    /// The `paymentData` value that you received in the response to the `/payments` call.
    /// </summary>
    /// <value>The `paymentData` value that you received in the response to the `/payments` call.</value>
    [DataMember(Name="paymentData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentData")]
    public string PaymentData { get; set; }

    /// <summary>
    /// Change the `authenticationOnly` indicator originally set in the `/payments` request. Only needs to be set if you want to modify the value set previously.
    /// </summary>
    /// <value>Change the `authenticationOnly` indicator originally set in the `/payments` request. Only needs to be set if you want to modify the value set previously.</value>
    [DataMember(Name="threeDSAuthenticationOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "threeDSAuthenticationOnly")]
    public bool? ThreeDSAuthenticationOnly { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DetailsRequest {\n");
      sb.Append("  Details: ").Append(Details).Append("\n");
      sb.Append("  PaymentData: ").Append(PaymentData).Append("\n");
      sb.Append("  ThreeDSAuthenticationOnly: ").Append(ThreeDSAuthenticationOnly).Append("\n");
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
