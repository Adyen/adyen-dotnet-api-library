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
  public class WeChatPayMiniProgramDetails {
    /// <summary>
    /// Gets or Sets AppId
    /// </summary>
    [DataMember(Name="appId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "appId")]
    public string AppId { get; set; }

    /// <summary>
    /// Gets or Sets Openid
    /// </summary>
    [DataMember(Name="openid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openid")]
    public string Openid { get; set; }

    /// <summary>
    /// **wechatpayMiniProgram**
    /// </summary>
    /// <value>**wechatpayMiniProgram**</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WeChatPayMiniProgramDetails {\n");
      sb.Append("  AppId: ").Append(AppId).Append("\n");
      sb.Append("  Openid: ").Append(Openid).Append("\n");
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
