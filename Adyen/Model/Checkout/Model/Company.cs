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
  public class Company {
    /// <summary>
    /// The company website's home page.
    /// </summary>
    /// <value>The company website's home page.</value>
    [DataMember(Name="homepage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "homepage")]
    public string Homepage { get; set; }

    /// <summary>
    /// The company name.
    /// </summary>
    /// <value>The company name.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Registration number of the company.
    /// </summary>
    /// <value>Registration number of the company.</value>
    [DataMember(Name="registrationNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registrationNumber")]
    public string RegistrationNumber { get; set; }

    /// <summary>
    /// Registry location of the company.
    /// </summary>
    /// <value>Registry location of the company.</value>
    [DataMember(Name="registryLocation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registryLocation")]
    public string RegistryLocation { get; set; }

    /// <summary>
    /// Tax ID of the company.
    /// </summary>
    /// <value>Tax ID of the company.</value>
    [DataMember(Name="taxId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxId")]
    public string TaxId { get; set; }

    /// <summary>
    /// The company type.
    /// </summary>
    /// <value>The company type.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Company {\n");
      sb.Append("  Homepage: ").Append(Homepage).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  RegistrationNumber: ").Append(RegistrationNumber).Append("\n");
      sb.Append("  RegistryLocation: ").Append(RegistryLocation).Append("\n");
      sb.Append("  TaxId: ").Append(TaxId).Append("\n");
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
