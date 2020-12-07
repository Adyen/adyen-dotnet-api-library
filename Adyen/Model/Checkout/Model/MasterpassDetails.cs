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
  public class MasterpassDetails {
    /// <summary>
    /// The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.
    /// </summary>
    /// <value>The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.</value>
    [DataMember(Name="fundingSource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fundingSource")]
    public string FundingSource { get; set; }

    /// <summary>
    /// The Masterpass transaction ID.
    /// </summary>
    /// <value>The Masterpass transaction ID.</value>
    [DataMember(Name="masterpassTransactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "masterpassTransactionId")]
    public string MasterpassTransactionId { get; set; }

    /// <summary>
    /// **masterpass**
    /// </summary>
    /// <value>**masterpass**</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MasterpassDetails {\n");
      sb.Append("  FundingSource: ").Append(FundingSource).Append("\n");
      sb.Append("  MasterpassTransactionId: ").Append(MasterpassTransactionId).Append("\n");
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
