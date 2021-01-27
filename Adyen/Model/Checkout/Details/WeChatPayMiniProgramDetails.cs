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

namespace Adyen.Model.Checkout.Details
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class WeChatPayMiniProgramDetails : IPaymentMethodDetails
    {
        //Possible types
        public const string WechatpayMiniProgram = "wechatpayMiniProgram";

        /// <summary>
        /// appId
        /// </summary>
        /// <value>appId</value>
        [DataMember(Name = "appId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "appId")]
        public string AppId { get; set; }

        /// <summary>
        /// openid
        /// </summary>
        /// <value>openid</value>
        [DataMember(Name = "openid", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "openid")]
        public string Openid { get; set; }


        /// <summary>
        /// **WechatpayMiniProgram**
        /// </summary>
        /// <value>**WechatpayMiniProgram**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; } = WechatpayMiniProgram;

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WeChatPayMiniProgramDetails {\n");
            sb.Append("  Openid: ").Append(Openid).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
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
