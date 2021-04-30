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
//  Copyright (c) 2021 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Adyen.Model.MarketPay.Notification
{
    public class ErrorFieldTypeContainer
    {
        /// <summary>
        /// The code of the account.
        /// </summary>
        /// <value>The code of the account.</value>
        [DataMember(Name = "errorFieldType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "errorFieldType")]
        public ErrorFieldType ErrorFieldType { get; set; }
    }
}
