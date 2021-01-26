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
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class DokuDetails : IPaymentMethodDetails
    {
        public const string Mandiriva = "doku_mandiri_va";
        public const string Cimbva = "doku_cimb_va";
        public const string Danamonva = "doku_danamon_va";
        public const string Bniva = "doku_bni_va";
        public const string Permataliteatm = "doku_permata_lite_atm";
        public const string Permatatm = "doku_permata_atm";
        public const string Briva = "doku_bri_va";
        public const string Bcava = "doku_bca_va";
        public const string Alfamart = "doku_alfamart";
        public const string Indomaret = "doku_indomaret";
        public const string Sinarmasva = "doku_sinarmas_va";
        
        /// <summary>
        /// The shopper's first name.
        /// </summary>
        /// <value>The shopper's first name.</value>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// The shopper's last name.
        /// </summary>
        /// <value>The shopper's last name.</value>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// The shopper's email.
        /// </summary>
        /// <value>The shopper's email.</value>
        [DataMember(Name = "shopperEmail", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shopperEmail")]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// **doku**
        /// </summary>
        /// <value>**doku**</value>
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
            sb.Append("class DokuDetails {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
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
