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
  public class DokuDetails {
    /// <summary>
    /// The shopper's first name.
    /// </summary>
    /// <value>The shopper's first name.</value>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or Sets Infix
    /// </summary>
    [DataMember(Name="infix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "infix")]
    public string Infix { get; set; }

    /// <summary>
    /// The shopper's last name.
    /// </summary>
    /// <value>The shopper's last name.</value>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// Gets or Sets OvoId
    /// </summary>
    [DataMember(Name="ovoId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ovoId")]
    public string OvoId { get; set; }

    /// <summary>
    /// The shopper's email.
    /// </summary>
    /// <value>The shopper's email.</value>
    [DataMember(Name="shopperEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperEmail")]
    public string ShopperEmail { get; set; }

    /// <summary>
    /// **doku**
    /// </summary>
    /// <value>**doku**</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DokuDetails {\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  Infix: ").Append(Infix).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  OvoId: ").Append(OvoId).Append("\n");
      sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
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
