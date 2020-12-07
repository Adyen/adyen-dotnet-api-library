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
  public class DragonpayDetails {
    /// <summary>
    /// The Dragonpay issuer value of the shopper's selected bank. Set this to an **id** of a Dragonpay issuer to preselect it.
    /// </summary>
    /// <value>The Dragonpay issuer value of the shopper's selected bank. Set this to an **id** of a Dragonpay issuer to preselect it.</value>
    [DataMember(Name="issuer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issuer")]
    public string Issuer { get; set; }

    /// <summary>
    /// The shopper’s email address.
    /// </summary>
    /// <value>The shopper’s email address.</value>
    [DataMember(Name="shopperEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperEmail")]
    public string ShopperEmail { get; set; }

    /// <summary>
    /// **dragonpay**
    /// </summary>
    /// <value>**dragonpay**</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DragonpayDetails {\n");
      sb.Append("  Issuer: ").Append(Issuer).Append("\n");
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
