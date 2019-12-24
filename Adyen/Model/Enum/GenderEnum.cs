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

using Newtonsoft.Json;
using System.Runtime.Serialization;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Enum
{
    /// <summary>
    /// A person&#39;s gender (can be unknown).
    /// </summary>
    /// <value>A person&#39;s gender (can be unknown).</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GenderEnum
    {

        /// <summary>
        /// Enum MALE for "MALE"
        /// </summary>
        [EnumMember(Value = "MALE")]
        MALE,

        /// <summary>
        /// Enum FEMALE for "FEMALE"
        /// </summary>
        [EnumMember(Value = "FEMALE")]
        FEMALE,

        /// <summary>
        /// Enum UNKNOWN for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN
    }
}
