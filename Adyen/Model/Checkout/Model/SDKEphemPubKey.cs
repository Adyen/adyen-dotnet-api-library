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
  public class SDKEphemPubKey {
    /// <summary>
    /// The `crv` value as received from the 3D Secure 2 SDK.
    /// </summary>
    /// <value>The `crv` value as received from the 3D Secure 2 SDK.</value>
    [DataMember(Name="crv", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "crv")]
    public string Crv { get; set; }

    /// <summary>
    /// The `kty` value as received from the 3D Secure 2 SDK.
    /// </summary>
    /// <value>The `kty` value as received from the 3D Secure 2 SDK.</value>
    [DataMember(Name="kty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kty")]
    public string Kty { get; set; }

    /// <summary>
    /// The `x` value as received from the 3D Secure 2 SDK.
    /// </summary>
    /// <value>The `x` value as received from the 3D Secure 2 SDK.</value>
    [DataMember(Name="x", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "x")]
    public string X { get; set; }

    /// <summary>
    /// The `y` value as received from the 3D Secure 2 SDK.
    /// </summary>
    /// <value>The `y` value as received from the 3D Secure 2 SDK.</value>
    [DataMember(Name="y", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "y")]
    public string Y { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SDKEphemPubKey {\n");
      sb.Append("  Crv: ").Append(Crv).Append("\n");
      sb.Append("  Kty: ").Append(Kty).Append("\n");
      sb.Append("  X: ").Append(X).Append("\n");
      sb.Append("  Y: ").Append(Y).Append("\n");
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
