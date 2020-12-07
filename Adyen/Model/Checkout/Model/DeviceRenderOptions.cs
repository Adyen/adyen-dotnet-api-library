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
  public class DeviceRenderOptions {
    /// <summary>
    /// Supported SDK interface types. Allowed values: * native * html * both
    /// </summary>
    /// <value>Supported SDK interface types. Allowed values: * native * html * both</value>
    [DataMember(Name="sdkInterface", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sdkInterface")]
    public string SdkInterface { get; set; }

    /// <summary>
    /// UI types supported for displaying specific challenges. Allowed values: * text * singleSelect * outOfBand * otherHtml * multiSelect
    /// </summary>
    /// <value>UI types supported for displaying specific challenges. Allowed values: * text * singleSelect * outOfBand * otherHtml * multiSelect</value>
    [DataMember(Name="sdkUiType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sdkUiType")]
    public List<string> SdkUiType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DeviceRenderOptions {\n");
      sb.Append("  SdkInterface: ").Append(SdkInterface).Append("\n");
      sb.Append("  SdkUiType: ").Append(SdkUiType).Append("\n");
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
