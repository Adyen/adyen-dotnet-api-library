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
    public class GooglePayDetails : IPaymentMethodDetails
    {
        //Possible types
        public const string GooglePay = "paywithgoogle";

        /// <summary>
        /// Defines FundingSource
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FundingSourceEnum
        {
            /// <summary>
            /// Enum Credit for value: credit
            /// </summary>
            [EnumMember(Value = "credit")]
            Credit = 1,
            /// <summary>
            /// Enum Debit for value: debit
            /// </summary>
            [EnumMember(Value = "debit")]
            Debit = 2
        }
        /// <summary>
        /// Gets or Sets FundingSource
        /// </summary>
        [DataMember(Name = "fundingSource", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fundingSource")]
        public FundingSourceEnum FundingSource { get; set; }

        /// <summary>
        /// Gets or Sets GooglePayCardNetwork
        /// </summary>
        [DataMember(Name = "googlePayCardNetwork", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "googlePayCardNetwork")]
        public string GooglePayCardNetwork { get; set; }

        /// <summary>
        /// Gets or Sets GooglePayToken
        /// </summary>
        [DataMember(Name = "googlePayToken", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "googlePayToken")]
        public string GooglePayToken { get; set; }

        /// <summary>
        /// **paywithgoogle**
        /// </summary>
        /// <value>**paywithgoogle**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; } = GooglePay; 


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GooglePayDetails {\n");
            sb.Append("  FundingSource: ").Append(FundingSource).Append("\n");
            sb.Append("  GooglePayCardNetwork: ").Append(GooglePayCardNetwork).Append("\n");
            sb.Append("  GooglePayToken: ").Append(GooglePayToken).Append("\n");
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
