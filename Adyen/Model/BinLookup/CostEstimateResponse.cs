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
  public class CostEstimateResponse {
    /// <summary>
    /// Gets or Sets CardBin
    /// </summary>
    [DataMember(Name="cardBin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardBin")]
    public CardBin CardBin { get; set; }

    /// <summary>
    /// Gets or Sets CostEstimateAmount
    /// </summary>
    [DataMember(Name="costEstimateAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "costEstimateAmount")]
    public Amount CostEstimateAmount { get; set; }

    /// <summary>
    /// The result of the cost estimation.
    /// </summary>
    /// <value>The result of the cost estimation.</value>
    [DataMember(Name="resultCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resultCode")]
    public string ResultCode { get; set; }

    /// <summary>
    /// Indicates the way the charges can be passed on to the cardholder. The following values are possible: * `ZERO` - the charges are not allowed to pass on * `PASSTHROUGH` - the charges can be passed on * `UNLIMITED` - there is no limit on how much surcharge is passed on
    /// </summary>
    /// <value>Indicates the way the charges can be passed on to the cardholder. The following values are possible: * `ZERO` - the charges are not allowed to pass on * `PASSTHROUGH` - the charges can be passed on * `UNLIMITED` - there is no limit on how much surcharge is passed on</value>
    [DataMember(Name="surchargeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "surchargeType")]
    public string SurchargeType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CostEstimateResponse {\n");
      sb.Append("  CardBin: ").Append(CardBin).Append("\n");
      sb.Append("  CostEstimateAmount: ").Append(CostEstimateAmount).Append("\n");
      sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
      sb.Append("  SurchargeType: ").Append(SurchargeType).Append("\n");
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
