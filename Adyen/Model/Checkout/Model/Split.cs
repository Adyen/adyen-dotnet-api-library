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
  public class Split {
    /// <summary>
    /// The account to which this split applies.  >Required if the type is `MarketPlace`.
    /// </summary>
    /// <value>The account to which this split applies.  >Required if the type is `MarketPlace`.</value>
    [DataMember(Name="account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account")]
    public string Account { get; set; }

    /// <summary>
    /// Gets or Sets Amount
    /// </summary>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public SplitAmount Amount { get; set; }

    /// <summary>
    /// A description of this split.
    /// </summary>
    /// <value>A description of this split.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The reference of this split. Used to link other operations (e.g. captures and refunds) to this split.  >Required if the type is `MarketPlace`.
    /// </summary>
    /// <value>The reference of this split. Used to link other operations (e.g. captures and refunds) to this split.  >Required if the type is `MarketPlace`.</value>
    [DataMember(Name="reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reference")]
    public string Reference { get; set; }

    /// <summary>
    /// The type of this split.  >Permitted values: `Default`, `PaymentFee`, `VAT`, `Commission`, `MarketPlace`, `BalanceAccount`.
    /// </summary>
    /// <value>The type of this split.  >Permitted values: `Default`, `PaymentFee`, `VAT`, `Commission`, `MarketPlace`, `BalanceAccount`.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Split {\n");
      sb.Append("  Account: ").Append(Account).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Reference: ").Append(Reference).Append("\n");
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
