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

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.BinLookup
{

    /// <summary>
    /// ThreeDSAvailabilityRequest
    /// </summary>
    [DataContract]
    public class ThreeDSAvailabilityRequest
    {

        /// <summary>
        /// This field contains additional data, which may be required for a particular request.  The `additionalData` object consists of entries, each of which includes the key and value. For more information on possible key-value pairs, refer to the [additionalData section](https://docs.adyen.com/developers/api-reference/payments-api#paymentrequestadditionaldata).
        /// </summary>
        /// <value>This field contains additional data, which may be required for a particular request.  The `additionalData` object consists of entries, each of which includes the key and value. For more information on possible key-value pairs, refer to the [additionalData section](https://docs.adyen.com/developers/api-reference/payments-api#paymentrequestadditionaldata).</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additionalData")]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// List of brands.
        /// </summary>
        /// <value>List of brands.</value>
        [DataMember(Name = "brands", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "brands")]
        public List<string> Brands { get; set; }

        /// <summary>
        /// Card number or BIN.
        /// </summary>
        /// <value>Card number or BIN.</value>
        [DataMember(Name = "cardNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cardNumber")]
        public string CardNumber { get; set; }

        /// <summary>
        /// The merchant account identifier.
        /// </summary>
        /// <value>The merchant account identifier.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// A recurring detail reference corresponding to a card.
        /// </summary>
        /// <value>A recurring detail reference corresponding to a card.</value>
        [DataMember(Name = "recurringDetailReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "recurringDetailReference")]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// The shopper's reference to uniquely identify this shopper (e.g. user ID or account ID).
        /// </summary>
        /// <value>The shopper's reference to uniquely identify this shopper (e.g. user ID or account ID).</value>
        [DataMember(Name = "shopperReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shopperReference")]
        public string ShopperReference { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThreeDSAvailabilityRequest {\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  Brands: ").Append(Brands).Append("\n");
            sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
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
