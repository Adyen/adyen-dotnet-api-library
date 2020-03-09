#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.BinLookup {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class DSPublicKeyDetail {
    /// <summary>
    /// Card brand.
    /// </summary>
    /// <value>Card brand.</value>
    [DataMember(Name="brand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brand")]
    public string Brand { get; set; }

    /// <summary>
    /// Directory Server (DS) identifier.
    /// </summary>
    /// <value>Directory Server (DS) identifier.</value>
    [DataMember(Name="directoryServerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "directoryServerId")]
    public string DirectoryServerId { get; set; }

    /// <summary>
    /// Public key. The 3D Secure 2 SDK encrypts the device information by using the DS public key.
    /// </summary>
    /// <value>Public key. The 3D Secure 2 SDK encrypts the device information by using the DS public key.</value>
    [DataMember(Name="publicKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publicKey")]
    public byte[] PublicKey { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DSPublicKeyDetail {\n");
      sb.Append("  Brand: ").Append(Brand).Append("\n");
      sb.Append("  DirectoryServerId: ").Append(DirectoryServerId).Append("\n");
      sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
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
