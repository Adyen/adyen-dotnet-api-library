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
  public class ThreeDSecureData {
    /// <summary>
    /// In 3D Secure 1, the authentication response if the shopper was redirected.  In 3D Secure 2, this is the `transStatus` from the challenge result. If the transaction was frictionless, omit this parameter.
    /// </summary>
    /// <value>In 3D Secure 1, the authentication response if the shopper was redirected.  In 3D Secure 2, this is the `transStatus` from the challenge result. If the transaction was frictionless, omit this parameter.</value>
    [DataMember(Name="authenticationResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticationResponse")]
    public string AuthenticationResponse { get; set; }

    /// <summary>
    /// The cardholder authentication value (base64 encoded, 20 bytes in a decoded form).
    /// </summary>
    /// <value>The cardholder authentication value (base64 encoded, 20 bytes in a decoded form).</value>
    [DataMember(Name="cavv", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cavv")]
    public byte[] Cavv { get; set; }

    /// <summary>
    /// The CAVV algorithm used. Include this only for 3D Secure 1.
    /// </summary>
    /// <value>The CAVV algorithm used. Include this only for 3D Secure 1.</value>
    [DataMember(Name="cavvAlgorithm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cavvAlgorithm")]
    public string CavvAlgorithm { get; set; }

    /// <summary>
    /// In 3D Secure 1, this is the enrollment response from the 3D directory server.  In 3D Secure 2, this is the `transStatus` from the `ARes`.
    /// </summary>
    /// <value>In 3D Secure 1, this is the enrollment response from the 3D directory server.  In 3D Secure 2, this is the `transStatus` from the `ARes`.</value>
    [DataMember(Name="directoryResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "directoryResponse")]
    public string DirectoryResponse { get; set; }

    /// <summary>
    /// Supported for 3D Secure 2. The unique transaction identifier assigned by the Directory Server (DS) to identify a single transaction.
    /// </summary>
    /// <value>Supported for 3D Secure 2. The unique transaction identifier assigned by the Directory Server (DS) to identify a single transaction.</value>
    [DataMember(Name="dsTransID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dsTransID")]
    public string DsTransID { get; set; }

    /// <summary>
    /// The electronic commerce indicator.
    /// </summary>
    /// <value>The electronic commerce indicator.</value>
    [DataMember(Name="eci", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eci")]
    public string Eci { get; set; }

    /// <summary>
    /// The version of the 3D Secure protocol.
    /// </summary>
    /// <value>The version of the 3D Secure protocol.</value>
    [DataMember(Name="threeDSVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "threeDSVersion")]
    public string ThreeDSVersion { get; set; }

    /// <summary>
    /// Supported for 3D Secure 1. The transaction identifier (Base64-encoded, 20 bytes in a decoded form).
    /// </summary>
    /// <value>Supported for 3D Secure 1. The transaction identifier (Base64-encoded, 20 bytes in a decoded form).</value>
    [DataMember(Name="xid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "xid")]
    public byte[] Xid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ThreeDSecureData {\n");
      sb.Append("  AuthenticationResponse: ").Append(AuthenticationResponse).Append("\n");
      sb.Append("  Cavv: ").Append(Cavv).Append("\n");
      sb.Append("  CavvAlgorithm: ").Append(CavvAlgorithm).Append("\n");
      sb.Append("  DirectoryResponse: ").Append(DirectoryResponse).Append("\n");
      sb.Append("  DsTransID: ").Append(DsTransID).Append("\n");
      sb.Append("  Eci: ").Append(Eci).Append("\n");
      sb.Append("  ThreeDSVersion: ").Append(ThreeDSVersion).Append("\n");
      sb.Append("  Xid: ").Append(Xid).Append("\n");
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
