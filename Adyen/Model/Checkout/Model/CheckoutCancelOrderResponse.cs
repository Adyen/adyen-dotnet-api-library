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
  public class CheckoutCancelOrderResponse {
    /// <summary>
    /// A unique reference of the cancellation request.
    /// </summary>
    /// <value>A unique reference of the cancellation request.</value>
    [DataMember(Name="pspReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pspReference")]
    public string PspReference { get; set; }

    /// <summary>
    /// The result of the cancellation request.
    /// </summary>
    /// <value>The result of the cancellation request.</value>
    [DataMember(Name="resultCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resultCode")]
    public string ResultCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CheckoutCancelOrderResponse {\n");
      sb.Append("  PspReference: ").Append(PspReference).Append("\n");
      sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
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
