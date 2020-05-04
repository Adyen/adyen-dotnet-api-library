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
    public class GenericIssuerPaymentMethodDetails : IOneOfPaymentRequestPaymentMethod
    {
        /// <summary>
        /// The issuer id of the shopper's selected bank.
        /// </summary>
        /// <value>The issuer id of the shopper's selected bank.</value>
        [DataMember(Name = "issuer", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// This is the recurringDetailReference returned in the response when you created the token.
        /// </summary>
        /// <value>This is the recurringDetailReference returned in the response when you created the token.</value>
        [DataMember(Name = "storedPaymentMethodId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "storedPaymentMethodId")]
        public string StoredPaymentMethodId { get; set; }

        /// <summary>
        /// **genericissuer**
        /// </summary>
        /// <value>**genericissuer**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; } 


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenericIssuerPaymentMethodDetails {\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
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
