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
  public class CheckoutOrder {
    /// <summary>
    /// The encrypted order data.
    /// </summary>
    /// <value>The encrypted order data.</value>
    [DataMember(Name="orderData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderData")]
    public string OrderData { get; set; }

    /// <summary>
    /// The `pspReference` that belongs to the order.
    /// </summary>
    /// <value>The `pspReference` that belongs to the order.</value>
    [DataMember(Name="pspReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pspReference")]
    public string PspReference { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CheckoutOrder {\n");
      sb.Append("  OrderData: ").Append(OrderData).Append("\n");
      sb.Append("  PspReference: ").Append(PspReference).Append("\n");
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
