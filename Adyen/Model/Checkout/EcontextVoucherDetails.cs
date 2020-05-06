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
    public class EcontextVoucherDetails : IOneOfPaymentRequestPaymentMethod
    {
        /// <summary>
        /// **econtextvoucher**
        /// </summary>
        /// <value>**econtextvoucher**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Seveneleven for value: econtext_seveneleven
            /// </summary>
            [EnumMember(Value = "econtext_seveneleven")]
            Seveneleven = 1,
            /// <summary>
            /// Enum Stores for value: econtext_stores
            /// </summary>
            [EnumMember(Value = "econtext_stores")]
            Stores = 2
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
        /// The shopper's contact number.
        /// </summary>
        /// <value>The shopper's contact number.</value>
        [DataMember(Name = "telephoneNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "telephoneNumber")]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// **econtextvoucher**
        /// </summary>
        /// <value>**econtextvoucher**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public TypeEnum Type{ get; set; } 


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EcontextVoucherDetails {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
            sb.Append("  TelephoneNumber: ").Append(TelephoneNumber).Append("\n");
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
