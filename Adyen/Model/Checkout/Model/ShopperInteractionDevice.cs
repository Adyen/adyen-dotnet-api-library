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
  public class ShopperInteractionDevice {
    /// <summary>
    /// Locale on the shopper interaction device.
    /// </summary>
    /// <value>Locale on the shopper interaction device.</value>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public string Locale { get; set; }

    /// <summary>
    /// Operating system running on the shopper interaction device.
    /// </summary>
    /// <value>Operating system running on the shopper interaction device.</value>
    [DataMember(Name="os", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "os")]
    public string Os { get; set; }

    /// <summary>
    /// Version of the operating system on the shopper interaction device.
    /// </summary>
    /// <value>Version of the operating system on the shopper interaction device.</value>
    [DataMember(Name="osVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "osVersion")]
    public string OsVersion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShopperInteractionDevice {\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  Os: ").Append(Os).Append("\n");
      sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
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
