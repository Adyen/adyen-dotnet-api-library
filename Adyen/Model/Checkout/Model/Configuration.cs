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
  public class Configuration {
    /// <summary>
    /// Gets or Sets Avs
    /// </summary>
    [DataMember(Name="avs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avs")]
    public Avs Avs { get; set; }

    /// <summary>
    /// Determines whether the cardholder name should be provided or not.  Permitted values: * NONE * OPTIONAL * REQUIRED
    /// </summary>
    /// <value>Determines whether the cardholder name should be provided or not.  Permitted values: * NONE * OPTIONAL * REQUIRED</value>
    [DataMember(Name="cardHolderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardHolderName")]
    public string CardHolderName { get; set; }

    /// <summary>
    /// Gets or Sets Installments
    /// </summary>
    [DataMember(Name="installments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installments")]
    public Installments Installments { get; set; }

    /// <summary>
    /// Gets or Sets ShopperInput
    /// </summary>
    [DataMember(Name="shopperInput", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperInput")]
    public ShopperInput ShopperInput { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Configuration {\n");
      sb.Append("  Avs: ").Append(Avs).Append("\n");
      sb.Append("  CardHolderName: ").Append(CardHolderName).Append("\n");
      sb.Append("  Installments: ").Append(Installments).Append("\n");
      sb.Append("  ShopperInput: ").Append(ShopperInput).Append("\n");
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
