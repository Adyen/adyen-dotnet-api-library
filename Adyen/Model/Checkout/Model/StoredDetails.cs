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
  public class StoredDetails {
    /// <summary>
    /// Gets or Sets Bank
    /// </summary>
    [DataMember(Name="bank", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bank")]
    public BankAccount Bank { get; set; }

    /// <summary>
    /// Gets or Sets Card
    /// </summary>
    [DataMember(Name="card", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "card")]
    public Card Card { get; set; }

    /// <summary>
    /// The email associated with stored payment details.
    /// </summary>
    /// <value>The email associated with stored payment details.</value>
    [DataMember(Name="emailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailAddress")]
    public string EmailAddress { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StoredDetails {\n");
      sb.Append("  Bank: ").Append(Bank).Append("\n");
      sb.Append("  Card: ").Append(Card).Append("\n");
      sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
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
