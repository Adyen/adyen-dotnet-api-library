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
  public class BacsDirectDebitDetails {
    /// <summary>
    /// The bank account number (without separators).
    /// </summary>
    /// <value>The bank account number (without separators).</value>
    [DataMember(Name="bankAccountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bankAccountNumber")]
    public string BankAccountNumber { get; set; }

    /// <summary>
    /// The bank routing number of the account.
    /// </summary>
    /// <value>The bank routing number of the account.</value>
    [DataMember(Name="bankLocationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bankLocationId")]
    public string BankLocationId { get; set; }

    /// <summary>
    /// The name of the bank account holder.
    /// </summary>
    /// <value>The name of the bank account holder.</value>
    [DataMember(Name="holderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "holderName")]
    public string HolderName { get; set; }

    /// <summary>
    /// **directdebit_GB**
    /// </summary>
    /// <value>**directdebit_GB**</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BacsDirectDebitDetails {\n");
      sb.Append("  BankAccountNumber: ").Append(BankAccountNumber).Append("\n");
      sb.Append("  BankLocationId: ").Append(BankLocationId).Append("\n");
      sb.Append("  HolderName: ").Append(HolderName).Append("\n");
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
