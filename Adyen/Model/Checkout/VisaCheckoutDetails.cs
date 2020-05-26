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
    public class VisaCheckoutDetails : IPaymentMethodDetails
    {
        //Possible types
        public const string VisaCheckout = "visacheckout";

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
        /// **visacheckout**
        /// </summary>
        /// <value>**visacheckout**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; } = VisaCheckout;

        /// <summary>
        /// Gets or Sets VisaCheckoutCallId
        /// </summary>
        [DataMember(Name = "visaCheckoutCallId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "visaCheckoutCallId")]
        public string VisaCheckoutCallId { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VisaCheckoutDetails {\n");
            sb.Append("  FundingSource: ").Append(FundingSource).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  VisaCheckoutCallId: ").Append(VisaCheckoutCallId).Append("\n");
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
