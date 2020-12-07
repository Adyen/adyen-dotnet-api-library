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
  public class CheckoutUtilityResponse {
    /// <summary>
    /// The list of origin keys for all requested domains. For each list item, the key is the domain and the value is the origin key.
    /// </summary>
    /// <value>The list of origin keys for all requested domains. For each list item, the key is the domain and the value is the origin key.</value>
    [DataMember(Name="originKeys", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originKeys")]
    public Dictionary<string, string> OriginKeys { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CheckoutUtilityResponse {\n");
      sb.Append("  OriginKeys: ").Append(OriginKeys).Append("\n");
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
