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
  public class MerchantDevice {
    /// <summary>
    /// Operating system running on the merchant device.
    /// </summary>
    /// <value>Operating system running on the merchant device.</value>
    [DataMember(Name="os", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "os")]
    public string Os { get; set; }

    /// <summary>
    /// Version of the operating system on the merchant device.
    /// </summary>
    /// <value>Version of the operating system on the merchant device.</value>
    [DataMember(Name="osVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "osVersion")]
    public string OsVersion { get; set; }

    /// <summary>
    /// Merchant device reference.
    /// </summary>
    /// <value>Merchant device reference.</value>
    [DataMember(Name="reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reference")]
    public string Reference { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MerchantDevice {\n");
      sb.Append("  Os: ").Append(Os).Append("\n");
      sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
      sb.Append("  Reference: ").Append(Reference).Append("\n");
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
