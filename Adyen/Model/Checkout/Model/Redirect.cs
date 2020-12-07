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
  public class Redirect {
    /// <summary>
    /// When the redirect URL must be accessed via POST, use this data to post to the redirect URL.
    /// </summary>
    /// <value>When the redirect URL must be accessed via POST, use this data to post to the redirect URL.</value>
    [DataMember(Name="data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "data")]
    public Dictionary<string, string> Data { get; set; }

    /// <summary>
    /// The web method that you must use to access the redirect URL.  Possible values: GET, POST.
    /// </summary>
    /// <value>The web method that you must use to access the redirect URL.  Possible values: GET, POST.</value>
    [DataMember(Name="method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "method")]
    public string Method { get; set; }

    /// <summary>
    /// The URL, to which you must redirect a shopper to complete a payment.
    /// </summary>
    /// <value>The URL, to which you must redirect a shopper to complete a payment.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Redirect {\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
      sb.Append("  Method: ").Append(Method).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
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
