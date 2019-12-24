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
//  * Copyright (c) 2019 Adyen B.V.
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
  public class CostEstimateAssumptions {
    /// <summary>
    /// If true, the cardholder is expected to successfully authorise via 3D Secure.
    /// </summary>
    /// <value>If true, the cardholder is expected to successfully authorise via 3D Secure.</value>
    [DataMember(Name="assume3DSecureAuthenticated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assume3DSecureAuthenticated")]
    public bool? Assume3DSecureAuthenticated { get; set; }

    /// <summary>
    /// If true, the transaction is expected to have valid Level 3 data.
    /// </summary>
    /// <value>If true, the transaction is expected to have valid Level 3 data.</value>
    [DataMember(Name="assumeLevel3Data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assumeLevel3Data")]
    public bool? AssumeLevel3Data { get; set; }

    /// <summary>
    /// If not zero, the number of installments.
    /// </summary>
    /// <value>If not zero, the number of installments.</value>
    [DataMember(Name="installments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installments")]
    public int? Installments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CostEstimateAssumptions {\n");
      sb.Append("  Assume3DSecureAuthenticated: ").Append(Assume3DSecureAuthenticated).Append("\n");
      sb.Append("  AssumeLevel3Data: ").Append(AssumeLevel3Data).Append("\n");
      sb.Append("  Installments: ").Append(Installments).Append("\n");
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
