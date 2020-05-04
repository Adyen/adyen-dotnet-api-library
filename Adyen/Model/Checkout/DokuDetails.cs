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
    public class DokuDetails : IOneOfPaymentRequestPaymentMethod
    {

        /// <summary>
        /// **doku**
        /// </summary>
        /// <value>**doku**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Mandiriva for value: doku_mandiri_va
            /// </summary>
            [EnumMember(Value = "doku_mandiri_va")]
            Mandiriva = 1,
            /// <summary>
            /// Enum Cimbva for value: doku_cimb_va
            /// </summary>
            [EnumMember(Value = "doku_cimb_va")]
            Cimbva = 2,
            /// <summary>
            /// Enum Danamonva for value: doku_danamon_va
            /// </summary>
            [EnumMember(Value = "doku_danamon_va")]
            Danamonva = 3,
            /// <summary>
            /// Enum Bniva for value: doku_bni_va
            /// </summary>
            [EnumMember(Value = "doku_bni_va")]
            Bniva = 4,
            /// <summary>
            /// Enum Permataliteatm for value: doku_permata_lite_atm
            /// </summary>
            [EnumMember(Value = "doku_permata_lite_atm")]
            Permataliteatm = 5,
            /// <summary>
            /// Enum Briva for value: doku_bri_va
            /// </summary>
            [EnumMember(Value = "doku_bri_va")]
            Briva = 6,
            /// <summary>
            /// Enum Bcava for value: doku_bca_va
            /// </summary>
            [EnumMember(Value = "doku_bca_va")]
            Bcava = 7,
            /// <summary>
            /// Enum Alfamart for value: doku_alfamart
            /// </summary>
            [EnumMember(Value = "doku_alfamart")]
            Alfamart = 8,
            /// <summary>
            /// Enum Indomaret for value: doku_indomaret
            /// </summary>
            [EnumMember(Value = "doku_indomaret")]
            Indomaret = 9
        }

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
        public TypeEnum Type { get; set; } 


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
