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
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Adyen.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
  public class AuthenticationResultResponse {
    /// <summary>
    /// Gets or Sets ThreeDS1Result
    /// </summary>
    [DataMember(Name="threeDS1Result", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "threeDS1Result")]
    public ThreeDS1Result ThreeDS1Result { get; set; }

    /// <summary>
    /// Gets or Sets ThreeDS2Result
    /// </summary>
    [DataMember(Name="threeDS2Result", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "threeDS2Result")]
    public ThreeDS2Result ThreeDS2Result { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuthenticationResultResponse {\n");
      sb.Append("  ThreeDS1Result: ").Append(ThreeDS1Result).Append("\n");
      sb.Append("  ThreeDS2Result: ").Append(ThreeDS2Result).Append("\n");
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
