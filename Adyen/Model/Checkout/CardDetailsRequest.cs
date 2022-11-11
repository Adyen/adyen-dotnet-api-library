#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class CardDetailsRequest
  {
    /// <summary>
    /// A minimum of the first 8 digits of the card number and a maximum of the full card number. 11 digits gives the best result.   You must be [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide) to collect raw card data.
    /// </summary>
    /// <value>A minimum of the first 8 digits of the card number and a maximum of the full card number. 11 digits gives the best result.   You must be [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide) to collect raw card data.</value>
    [DataMember(Name = "cardNumber", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "cardNumber")]
    public string CardNumber { get; set; }

    /// <summary>
    /// The shopper country.  Format: [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) Example: NL or DE
    /// </summary>
    /// <value>The shopper country.  Format: [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) Example: NL or DE</value>
    [DataMember(Name = "countryCode", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "countryCode")]
    public string CountryCode { get; set; }

    /// <summary>
    /// The merchant account identifier, with which you want to process the transaction.
    /// </summary>
    /// <value>The merchant account identifier, with which you want to process the transaction.</value>
    [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "merchantAccount")]
    public string MerchantAccount { get; set; }

    /// <summary>
    /// The card brands you support. This is the [`brands`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/paymentMethods__resParam_paymentMethods-brands) array from your [`/paymentMethods`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/paymentMethods) response.   If not included, our API uses the ones configured for your merchant account and, if provided, the country code.
    /// </summary>
    /// <value>The card brands you support. This is the [`brands`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/paymentMethods__resParam_paymentMethods-brands) array from your [`/paymentMethods`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/paymentMethods) response.   If not included, our API uses the ones configured for your merchant account and, if provided, the country code.</value>
    [DataMember(Name = "supportedBrands", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "supportedBrands")]
    public List<string> SupportedBrands { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class CardDetailsRequest {\n");
      sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
      sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
      sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
      sb.Append("  SupportedBrands: ").Append(SupportedBrands).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson()
    {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }
  }
}