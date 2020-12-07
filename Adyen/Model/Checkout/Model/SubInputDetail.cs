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
  public class SubInputDetail {
    /// <summary>
    /// Configuration parameters for the required input.
    /// </summary>
    /// <value>Configuration parameters for the required input.</value>
    [DataMember(Name="configuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configuration")]
    public Dictionary<string, string> Configuration { get; set; }

    /// <summary>
    /// In case of a select, the items to choose from.
    /// </summary>
    /// <value>In case of a select, the items to choose from.</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<Item> Items { get; set; }

    /// <summary>
    /// The value to provide in the result.
    /// </summary>
    /// <value>The value to provide in the result.</value>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }

    /// <summary>
    /// True if this input is optional to provide.
    /// </summary>
    /// <value>True if this input is optional to provide.</value>
    [DataMember(Name="optional", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "optional")]
    public bool? Optional { get; set; }

    /// <summary>
    /// The type of the required input.
    /// </summary>
    /// <value>The type of the required input.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The value can be pre-filled, if available.
    /// </summary>
    /// <value>The value can be pre-filled, if available.</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubInputDetail {\n");
      sb.Append("  Configuration: ").Append(Configuration).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
      sb.Append("  Optional: ").Append(Optional).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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
