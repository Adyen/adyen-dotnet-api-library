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
  public class CheckoutCreateOrderRequest {
    /// <summary>
    /// Gets or Sets Amount
    /// </summary>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public Amount Amount { get; set; }

    /// <summary>
    /// The date that order expires; e.g. 2019-03-23T12:25:28Z. If not provided, the default expiry duration is 1 day.
    /// </summary>
    /// <value>The date that order expires; e.g. 2019-03-23T12:25:28Z. If not provided, the default expiry duration is 1 day.</value>
    [DataMember(Name="expiresAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiresAt")]
    public string ExpiresAt { get; set; }

    /// <summary>
    /// The merchant account identifier, with which you want to process the order.
    /// </summary>
    /// <value>The merchant account identifier, with which you want to process the order.</value>
    [DataMember(Name="merchantAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantAccount")]
    public string MerchantAccount { get; set; }

    /// <summary>
    /// A custom reference identifying the order.
    /// </summary>
    /// <value>A custom reference identifying the order.</value>
    [DataMember(Name="reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reference")]
    public string Reference { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CheckoutCreateOrderRequest {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
      sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
      sb.Append("  Reference: ").Append(Reference).Append("\n");
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
