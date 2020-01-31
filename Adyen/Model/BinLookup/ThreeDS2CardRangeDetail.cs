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
  public class ThreeDS2CardRangeDetail {
    /// <summary>
    /// Card brand.
    /// </summary>
    /// <value>Card brand.</value>
    [DataMember(Name="brandCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brandCode")]
    public string BrandCode { get; set; }

    /// <summary>
    /// BIN end range.
    /// </summary>
    /// <value>BIN end range.</value>
    [DataMember(Name="endRange", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endRange")]
    public string EndRange { get; set; }

    /// <summary>
    /// BIN start range.
    /// </summary>
    /// <value>BIN start range.</value>
    [DataMember(Name="startRange", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startRange")]
    public string StartRange { get; set; }

    /// <summary>
    /// 3D Secure protocol version.
    /// </summary>
    /// <value>3D Secure protocol version.</value>
    [DataMember(Name="threeDS2Version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "threeDS2Version")]
    public string ThreeDS2Version { get; set; }

    /// <summary>
    /// In a 3D Secure 2 browser-based flow, this is the URL where you should send the device fingerprint to.
    /// </summary>
    /// <value>In a 3D Secure 2 browser-based flow, this is the URL where you should send the device fingerprint to.</value>
    [DataMember(Name="threeDSMethodURL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "threeDSMethodURL")]
    public string ThreeDSMethodURL { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ThreeDS2CardRangeDetail {\n");
      sb.Append("  BrandCode: ").Append(BrandCode).Append("\n");
      sb.Append("  EndRange: ").Append(EndRange).Append("\n");
      sb.Append("  StartRange: ").Append(StartRange).Append("\n");
      sb.Append("  ThreeDS2Version: ").Append(ThreeDS2Version).Append("\n");
      sb.Append("  ThreeDSMethodURL: ").Append(ThreeDSMethodURL).Append("\n");
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
