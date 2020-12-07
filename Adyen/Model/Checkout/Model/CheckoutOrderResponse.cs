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
  public class CheckoutOrderResponse {
    /// <summary>
    /// The expiry date for the order.
    /// </summary>
    /// <value>The expiry date for the order.</value>
    [DataMember(Name="expiresAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiresAt")]
    public string ExpiresAt { get; set; }

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
    /// The merchant reference for the order.
    /// </summary>
    /// <value>The merchant reference for the order.</value>
    [DataMember(Name="reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reference")]
    public string Reference { get; set; }

    /// <summary>
    /// Gets or Sets RemainingAmount
    /// </summary>
    [DataMember(Name="remainingAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remainingAmount")]
    public Amount RemainingAmount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CheckoutOrderResponse {\n");
      sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
      sb.Append("  OrderData: ").Append(OrderData).Append("\n");
      sb.Append("  PspReference: ").Append(PspReference).Append("\n");
      sb.Append("  Reference: ").Append(Reference).Append("\n");
      sb.Append("  RemainingAmount: ").Append(RemainingAmount).Append("\n");
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
