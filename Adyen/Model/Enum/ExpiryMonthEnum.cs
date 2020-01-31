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
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Adyen.Model.Enum
{
    /// <summary>
    /// the month of the expiry date of the card
    /// </summary>
    /// <value>the month of the expiry date of the card</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExpiryMonthEnum
    {

        /// <summary>
        /// Enum APRIL for "APRIL"
        /// </summary>
        [EnumMember(Value = "APRIL")]
        April,

        /// <summary>
        /// Enum AUGUST for "AUGUST"
        /// </summary>
        [EnumMember(Value = "AUGUST")]
        August,

        /// <summary>
        /// Enum DECEMBER for "DECEMBER"
        /// </summary>
        [EnumMember(Value = "DECEMBER")]
        December,

        /// <summary>
        /// Enum FEBRUARY for "FEBRUARY"
        /// </summary>
        [EnumMember(Value = "FEBRUARY")]
        February,

        /// <summary>
        /// Enum JANUARY for "JANUARY"
        /// </summary>
        [EnumMember(Value = "JANUARY")]
        January,

        /// <summary>
        /// Enum JULY for "JULY"
        /// </summary>
        [EnumMember(Value = "JULY")]
        July,

        /// <summary>
        /// Enum JUNE for "JUNE"
        /// </summary>
        [EnumMember(Value = "JUNE")]
        June,

        /// <summary>
        /// Enum MARCH for "MARCH"
        /// </summary>
        [EnumMember(Value = "MARCH")]
        March,

        /// <summary>
        /// Enum MAY for "MAY"
        /// </summary>
        [EnumMember(Value = "MAY")]
        May,

        /// <summary>
        /// Enum NOVEMBER for "NOVEMBER"
        /// </summary>
        [EnumMember(Value = "NOVEMBER")]
        November,

        /// <summary>
        /// Enum OCTOBER for "OCTOBER"
        /// </summary>
        [EnumMember(Value = "OCTOBER")]
        October,

        /// <summary>
        /// Enum SEPTEMBER for "SEPTEMBER"
        /// </summary>
        [EnumMember(Value = "SEPTEMBER")]
        September
    }

}
