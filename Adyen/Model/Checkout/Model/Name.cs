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
  public class Name {
    /// <summary>
    /// The first name.
    /// </summary>
    /// <value>The first name.</value>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// The gender. >The following values are permitted: `MALE`, `FEMALE`, `UNKNOWN`.
    /// </summary>
    /// <value>The gender. >The following values are permitted: `MALE`, `FEMALE`, `UNKNOWN`.</value>
    [DataMember(Name="gender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gender")]
    public string Gender { get; set; }

    /// <summary>
    /// The name's infix, if applicable. >A maximum length of twenty (20) characters is imposed.
    /// </summary>
    /// <value>The name's infix, if applicable. >A maximum length of twenty (20) characters is imposed.</value>
    [DataMember(Name="infix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "infix")]
    public string Infix { get; set; }

    /// <summary>
    /// The last name.
    /// </summary>
    /// <value>The last name.</value>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Name {\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  Gender: ").Append(Gender).Append("\n");
      sb.Append("  Infix: ").Append(Infix).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
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
