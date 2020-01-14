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
    /// the response from the directory server indicating if the card holder is enrolled in a 3D secure service
    /// </summary>
    /// <value>the response from the directory server indicating if the card holder is enrolled in a 3D secure service</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ThreeDDirectoryServerResponseEnum
    {

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
        /// Enum Y for "Y"
        /// </summary>
        [EnumMember(Value = "Y")]
        Y
    }

}
