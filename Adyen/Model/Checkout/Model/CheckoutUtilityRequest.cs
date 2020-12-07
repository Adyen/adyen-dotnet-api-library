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
  public class CheckoutUtilityRequest {
    /// <summary>
    /// The list of origin domains, for which origin keys are requested.
    /// </summary>
    /// <value>The list of origin domains, for which origin keys are requested.</value>
    [DataMember(Name="originDomains", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originDomains")]
    public List<string> OriginDomains { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CheckoutUtilityRequest {\n");
      sb.Append("  OriginDomains: ").Append(OriginDomains).Append("\n");
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
