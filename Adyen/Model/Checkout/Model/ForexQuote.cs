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
  public class ForexQuote {
    /// <summary>
    /// The account name.
    /// </summary>
    /// <value>The account name.</value>
    [DataMember(Name="account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account")]
    public string Account { get; set; }

    /// <summary>
    /// The account type.
    /// </summary>
    /// <value>The account type.</value>
    [DataMember(Name="accountType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountType")]
    public string AccountType { get; set; }

    /// <summary>
    /// Gets or Sets BaseAmount
    /// </summary>
    [DataMember(Name="baseAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseAmount")]
    public Amount BaseAmount { get; set; }

    /// <summary>
    /// The base points.
    /// </summary>
    /// <value>The base points.</value>
    [DataMember(Name="basePoints", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "basePoints")]
    public int? BasePoints { get; set; }

    /// <summary>
    /// Gets or Sets Buy
    /// </summary>
    [DataMember(Name="buy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buy")]
    public Amount Buy { get; set; }

    /// <summary>
    /// Gets or Sets Interbank
    /// </summary>
    [DataMember(Name="interbank", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interbank")]
    public Amount Interbank { get; set; }

    /// <summary>
    /// The reference assigned to the forex quote request.
    /// </summary>
    /// <value>The reference assigned to the forex quote request.</value>
    [DataMember(Name="reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reference")]
    public string Reference { get; set; }

    /// <summary>
    /// Gets or Sets Sell
    /// </summary>
    [DataMember(Name="sell", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sell")]
    public Amount Sell { get; set; }

    /// <summary>
    /// The signature to validate the integrity.
    /// </summary>
    /// <value>The signature to validate the integrity.</value>
    [DataMember(Name="signature", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "signature")]
    public string Signature { get; set; }

    /// <summary>
    /// The source of the forex quote.
    /// </summary>
    /// <value>The source of the forex quote.</value>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public string Source { get; set; }

    /// <summary>
    /// The type of forex.
    /// </summary>
    /// <value>The type of forex.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The date until which the forex quote is valid.
    /// </summary>
    /// <value>The date until which the forex quote is valid.</value>
    [DataMember(Name="validTill", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validTill")]
    public DateTime? ValidTill { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ForexQuote {\n");
      sb.Append("  Account: ").Append(Account).Append("\n");
      sb.Append("  AccountType: ").Append(AccountType).Append("\n");
      sb.Append("  BaseAmount: ").Append(BaseAmount).Append("\n");
      sb.Append("  BasePoints: ").Append(BasePoints).Append("\n");
      sb.Append("  Buy: ").Append(Buy).Append("\n");
      sb.Append("  Interbank: ").Append(Interbank).Append("\n");
      sb.Append("  Reference: ").Append(Reference).Append("\n");
      sb.Append("  Sell: ").Append(Sell).Append("\n");
      sb.Append("  Signature: ").Append(Signature).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  ValidTill: ").Append(ValidTill).Append("\n");
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
