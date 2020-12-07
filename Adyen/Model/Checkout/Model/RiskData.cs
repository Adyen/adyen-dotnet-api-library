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
  public class RiskData {
    /// <summary>
    /// Contains client-side data, like the device fingerprint, cookies, and specific browser settings.
    /// </summary>
    /// <value>Contains client-side data, like the device fingerprint, cookies, and specific browser settings.</value>
    [DataMember(Name="clientData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientData")]
    public string ClientData { get; set; }

    /// <summary>
    /// Any custom fields used as part of the input to configured risk rules.
    /// </summary>
    /// <value>Any custom fields used as part of the input to configured risk rules.</value>
    [DataMember(Name="customFields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customFields")]
    public Dictionary<string, string> CustomFields { get; set; }

    /// <summary>
    /// An integer value that is added to the normal fraud score. The value can be either positive or negative.
    /// </summary>
    /// <value>An integer value that is added to the normal fraud score. The value can be either positive or negative.</value>
    [DataMember(Name="fraudOffset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fraudOffset")]
    public int? FraudOffset { get; set; }

    /// <summary>
    /// The risk profile to assign to this payment. When left empty, the merchant-level account's default risk profile will be applied.
    /// </summary>
    /// <value>The risk profile to assign to this payment. When left empty, the merchant-level account's default risk profile will be applied.</value>
    [DataMember(Name="profileReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profileReference")]
    public string ProfileReference { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RiskData {\n");
      sb.Append("  ClientData: ").Append(ClientData).Append("\n");
      sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
      sb.Append("  FraudOffset: ").Append(FraudOffset).Append("\n");
      sb.Append("  ProfileReference: ").Append(ProfileReference).Append("\n");
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
