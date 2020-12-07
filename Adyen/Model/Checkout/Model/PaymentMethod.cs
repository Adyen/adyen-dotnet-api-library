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
  public class PaymentMethod {
    /// <summary>
    /// Brand for the selected gift card. For example: plastix, hmclub.
    /// </summary>
    /// <value>Brand for the selected gift card. For example: plastix, hmclub.</value>
    [DataMember(Name="brand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brand")]
    public string Brand { get; set; }

    /// <summary>
    /// List of possible brands. For example: visa, mc.
    /// </summary>
    /// <value>List of possible brands. For example: visa, mc.</value>
    [DataMember(Name="brands", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brands")]
    public List<string> Brands { get; set; }

    /// <summary>
    /// The configuration of the payment method.
    /// </summary>
    /// <value>The configuration of the payment method.</value>
    [DataMember(Name="configuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configuration")]
    public Dictionary<string, string> Configuration { get; set; }

    /// <summary>
    /// All input details to be provided to complete the payment with this payment method.
    /// </summary>
    /// <value>All input details to be provided to complete the payment with this payment method.</value>
    [DataMember(Name="details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "details")]
    public List<InputDetail> Details { get; set; }

    /// <summary>
    /// The funding source of the payment method.
    /// </summary>
    /// <value>The funding source of the payment method.</value>
    [DataMember(Name="fundingSource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fundingSource")]
    public string FundingSource { get; set; }

    /// <summary>
    /// Gets or Sets Group
    /// </summary>
    [DataMember(Name="group", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group")]
    public PaymentMethodGroup Group { get; set; }

    /// <summary>
    /// All input details to be provided to complete the payment with this payment method.
    /// </summary>
    /// <value>All input details to be provided to complete the payment with this payment method.</value>
    [DataMember(Name="inputDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inputDetails")]
    public List<InputDetail> InputDetails { get; set; }

    /// <summary>
    /// The displayable name of this payment method.
    /// </summary>
    /// <value>The displayable name of this payment method.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The unique payment method code.
    /// </summary>
    /// <value>The unique payment method code.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentMethod {\n");
      sb.Append("  Brand: ").Append(Brand).Append("\n");
      sb.Append("  Brands: ").Append(Brands).Append("\n");
      sb.Append("  Configuration: ").Append(Configuration).Append("\n");
      sb.Append("  Details: ").Append(Details).Append("\n");
      sb.Append("  FundingSource: ").Append(FundingSource).Append("\n");
      sb.Append("  Group: ").Append(Group).Append("\n");
      sb.Append("  InputDetails: ").Append(InputDetails).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
