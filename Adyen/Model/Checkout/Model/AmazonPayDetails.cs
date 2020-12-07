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
  public class AmazonPayDetails {
    /// <summary>
    /// Gets or Sets AmazonPayToken
    /// </summary>
    [DataMember(Name="amazonPayToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amazonPayToken")]
    public string AmazonPayToken { get; set; }

    /// <summary>
    /// Gets or Sets CheckoutSessionId
    /// </summary>
    [DataMember(Name="checkoutSessionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checkoutSessionId")]
    public string CheckoutSessionId { get; set; }

    /// <summary>
    /// **amazonpay**
    /// </summary>
    /// <value>**amazonpay**</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AmazonPayDetails {\n");
      sb.Append("  AmazonPayToken: ").Append(AmazonPayToken).Append("\n");
      sb.Append("  CheckoutSessionId: ").Append(CheckoutSessionId).Append("\n");
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
