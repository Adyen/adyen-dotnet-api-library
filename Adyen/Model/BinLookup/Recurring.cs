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

using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.BinLookup {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Recurring {
    /// <summary>
    /// The type of recurring contract to be used. Possible values: * `ONECLICK` – Payment details can be used to initiate a one-click payment, where the shopper enters the [card security code (CVC/CVV)](https://docs.adyen.com/payments-essentials/payment-glossary#card_security_code_cvc_cvv_cid_). * `RECURRING` – Payment details can be used without the card security code to initiate [card-not-present transactions](https://docs.adyen.com/developers/payment-glossary#cardnotpresentcnp). * `ONECLICK,RECURRING` – Payment details can be used regardless of whether the shopper is on your site or not. * `PAYOUT` – Payment details can be used to [make a payout](https://docs.adyen.com/developers/features/third-party-payouts).
    /// </summary>
    /// <value>The type of recurring contract to be used. Possible values: * `ONECLICK` – Payment details can be used to initiate a one-click payment, where the shopper enters the [card security code (CVC/CVV)](https://docs.adyen.com/payments-essentials/payment-glossary#card_security_code_cvc_cvv_cid_). * `RECURRING` – Payment details can be used without the card security code to initiate [card-not-present transactions](https://docs.adyen.com/developers/payment-glossary#cardnotpresentcnp). * `ONECLICK,RECURRING` – Payment details can be used regardless of whether the shopper is on your site or not. * `PAYOUT` – Payment details can be used to [make a payout](https://docs.adyen.com/developers/features/third-party-payouts).</value>
    [DataMember(Name="contract", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contract")]
    public string Contract { get; set; }

    /// <summary>
    /// A descriptive name for this detail.
    /// </summary>
    /// <value>A descriptive name for this detail.</value>
    [DataMember(Name="recurringDetailName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurringDetailName")]
    public string RecurringDetailName { get; set; }

    /// <summary>
    /// Date after which no further authorisations shall be performed. Only for 3D Secure 2.
    /// </summary>
    /// <value>Date after which no further authorisations shall be performed. Only for 3D Secure 2.</value>
    [DataMember(Name="recurringExpiry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurringExpiry")]
    public DateTime? RecurringExpiry { get; set; }

    /// <summary>
    /// Minimum number of days between authorisations. Only for 3D Secure 2.
    /// </summary>
    /// <value>Minimum number of days between authorisations. Only for 3D Secure 2.</value>
    [DataMember(Name="recurringFrequency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurringFrequency")]
    public string RecurringFrequency { get; set; }

    /// <summary>
    /// The name of the token service.
    /// </summary>
    /// <value>The name of the token service.</value>
    [DataMember(Name="tokenService", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tokenService")]
    public string TokenService { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Recurring {\n");
      sb.Append("  Contract: ").Append(Contract).Append("\n");
      sb.Append("  RecurringDetailName: ").Append(RecurringDetailName).Append("\n");
      sb.Append("  RecurringExpiry: ").Append(RecurringExpiry).Append("\n");
      sb.Append("  RecurringFrequency: ").Append(RecurringFrequency).Append("\n");
      sb.Append("  TokenService: ").Append(TokenService).Append("\n");
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
