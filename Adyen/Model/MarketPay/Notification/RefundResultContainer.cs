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
//  Copyright (c) 2021 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Adyen.Model.MarketPay.Notification
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class RefundResultContainer
    {
        /// <summary>
        /// Gets or Sets OriginalTransaction
        /// </summary>
        [DataMember(Name = "RefundResult", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "RefundResult")]
        public RefundResult RefundResult { get; set; }
    }
}