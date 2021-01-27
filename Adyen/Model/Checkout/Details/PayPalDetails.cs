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

namespace Adyen.Model.Checkout.Details
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class PayPalDetails : IPaymentMethodDetails
    {
        //Possible fields
        public const string PayPal = "paypal";
        
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SubtypeEnum
        {
            /// <summary>
            /// Enum SDK for value: SDK
            /// </summary>
            [EnumMember(Value = "sdk")]
            SDK = 1,

            /// <summary>
            /// Enum SDK for value: SDK
            /// </summary>
            [EnumMember(Value = "redirect")]
            Redirect = 1,
        }

        /// <summary>
        /// PayPal subtype
        /// </summary>
        /// <value>enum subtype</value>
        [DataMember(Name = "subtype", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "subtype")]
        public SubtypeEnum Subtype;

        /// <summary>
        /// **paypal**
        /// </summary>
        /// <value>**paypal**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; } = PayPal;

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayPalDetails {\n");
            sb.Append("  Subtype: ").Append(Subtype).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
