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
  public class ResponseAdditionalDataNetworkTokens {
    /// <summary>
    /// Indicates whether a network token is available for the specified card.
    /// </summary>
    /// <value>Indicates whether a network token is available for the specified card.</value>
    [DataMember(Name="networkToken.available", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "networkToken.available")]
    public string NetworkTokenAvailable { get; set; }

    /// <summary>
    /// The Bank Identification Number of a tokenized card, which is the first six digits of a card number.
    /// </summary>
    /// <value>The Bank Identification Number of a tokenized card, which is the first six digits of a card number.</value>
    [DataMember(Name="networkToken.bin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "networkToken.bin")]
    public string NetworkTokenBin { get; set; }

    /// <summary>
    /// The last four digits of a network token.
    /// </summary>
    /// <value>The last four digits of a network token.</value>
    [DataMember(Name="networkToken.tokenSummary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "networkToken.tokenSummary")]
    public string NetworkTokenTokenSummary { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ResponseAdditionalDataNetworkTokens {\n");
      sb.Append("  NetworkTokenAvailable: ").Append(NetworkTokenAvailable).Append("\n");
      sb.Append("  NetworkTokenBin: ").Append(NetworkTokenBin).Append("\n");
      sb.Append("  NetworkTokenTokenSummary: ").Append(NetworkTokenTokenSummary).Append("\n");
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
