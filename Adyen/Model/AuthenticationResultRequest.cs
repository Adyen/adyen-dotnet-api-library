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
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Adyen.Model
{

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class AuthenticationResultRequest {
    /// <summary>
    /// The merchant account identifier, with which the authentication was processed.
    /// </summary>
    /// <value>The merchant account identifier, with which the authentication was processed.</value>
    [DataMember(Name="merchantAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantAccount")]
    public string MerchantAccount { get; set; }

    /// <summary>
    /// The pspReference identifier for the transaction.
    /// </summary>
    /// <value>The pspReference identifier for the transaction.</value>
    [DataMember(Name="pspReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pspReference")]
    public string PspReference { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuthenticationResultRequest {\n");
      sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
      sb.Append("  PspReference: ").Append(PspReference).Append("\n");
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
