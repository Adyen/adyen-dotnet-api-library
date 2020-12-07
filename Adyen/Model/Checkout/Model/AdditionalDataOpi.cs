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
  public class AdditionalDataOpi {
    /// <summary>
    /// Optional boolean indicator. Set to **true** if you want an ecommerce transaction to return an `opi.transToken` as additional data in the response.  You can store this Oracle Payment Interface token in your Oracle Opera database. For more information and required settings, see [Oracle Opera](https://docs.adyen.com/plugins/oracle-opera#opi-token-ecommerce).
    /// </summary>
    /// <value>Optional boolean indicator. Set to **true** if you want an ecommerce transaction to return an `opi.transToken` as additional data in the response.  You can store this Oracle Payment Interface token in your Oracle Opera database. For more information and required settings, see [Oracle Opera](https://docs.adyen.com/plugins/oracle-opera#opi-token-ecommerce).</value>
    [DataMember(Name="opi.includeTransToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "opi.includeTransToken")]
    public string OpiIncludeTransToken { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AdditionalDataOpi {\n");
      sb.Append("  OpiIncludeTransToken: ").Append(OpiIncludeTransToken).Append("\n");
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
