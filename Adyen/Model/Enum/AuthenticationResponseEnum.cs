#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Enum
{
    /// <summary>
    /// The authentication response if the shopper was redirected.
    /// </summary>
    /// <value>The authentication response if the shopper was redirected.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuthenticationResponseEnum
    {

        /// <summary>
        /// Enum Y for "Y"
        /// </summary>
        [EnumMember(Value = "Y")]
        Y,

        /// <summary>
        /// Enum N for "N"
        /// </summary>
        [EnumMember(Value = "N")]
        N,

        /// <summary>
        /// Enum U for "U"
        /// </summary>
        [EnumMember(Value = "U")]
        U,

        /// <summary>
        /// Enum A for "A"
        /// </summary>
        [EnumMember(Value = "A")]
        A
    }

}
