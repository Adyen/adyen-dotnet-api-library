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
  public class MerchantDetails {
    /// <summary>
    /// 2-letter ISO 3166 country code of the card acceptor location. > This parameter is required for the merchants who don't use Adyen as the payment authorisation gateway.
    /// </summary>
    /// <value>2-letter ISO 3166 country code of the card acceptor location. > This parameter is required for the merchants who don't use Adyen as the payment authorisation gateway.</value>
    [DataMember(Name="countryCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "countryCode")]
    public string CountryCode { get; set; }

    /// <summary>
    /// If true, indicates that the merchant is enrolled in 3D Secure for the card network.
    /// </summary>
    /// <value>If true, indicates that the merchant is enrolled in 3D Secure for the card network.</value>
    [DataMember(Name="enrolledIn3DSecure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enrolledIn3DSecure")]
    public bool? EnrolledIn3DSecure { get; set; }

    /// <summary>
    /// The merchant category code (MCC) is a four-digit number which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant.  The list of MCCs can be found [here](https://en.wikipedia.org/wiki/Merchant_category_code).
    /// </summary>
    /// <value>The merchant category code (MCC) is a four-digit number which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant.  The list of MCCs can be found [here](https://en.wikipedia.org/wiki/Merchant_category_code).</value>
    [DataMember(Name="mcc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mcc")]
    public string Mcc { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MerchantDetails {\n");
      sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
      sb.Append("  EnrolledIn3DSecure: ").Append(EnrolledIn3DSecure).Append("\n");
      sb.Append("  Mcc: ").Append(Mcc).Append("\n");
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
