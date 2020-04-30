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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class SamsungPayDetails : IOneOfPaymentRequestPaymentMethod
    {
        /// <summary>
        /// Gets or Sets FundingSource
        /// </summary>
        [DataMember(Name = "fundingSource", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fundingSource")]
        public string FundingSource { get; set; }

        /// <summary>
        /// Gets or Sets SamsungPayToken
        /// </summary>
        [DataMember(Name = "samsungPayToken", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "samsungPayToken")]
        public string SamsungPayToken { get; set; }

        /// <summary>
        /// **samsungpay**
        /// </summary>
        /// <value>**samsungpay**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; } = "samsungpay"; 


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SamsungPayDetails {\n");
            sb.Append("  FundingSource: ").Append(FundingSource).Append("\n");
            sb.Append("  SamsungPayToken: ").Append(SamsungPayToken).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
