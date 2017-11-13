using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.EcommLibrary.Model.Enum
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
        APRIL,

        /// <summary>
        /// Enum AUGUST for "AUGUST"
        /// </summary>
        [EnumMember(Value = "AUGUST")]
        AUGUST,

        /// <summary>
        /// Enum DECEMBER for "DECEMBER"
        /// </summary>
        [EnumMember(Value = "DECEMBER")]
        DECEMBER,

        /// <summary>
        /// Enum FEBRUARY for "FEBRUARY"
        /// </summary>
        [EnumMember(Value = "FEBRUARY")]
        FEBRUARY,

        /// <summary>
        /// Enum JANUARY for "JANUARY"
        /// </summary>
        [EnumMember(Value = "JANUARY")]
        JANUARY,

        /// <summary>
        /// Enum JULY for "JULY"
        /// </summary>
        [EnumMember(Value = "JULY")]
        JULY,

        /// <summary>
        /// Enum JUNE for "JUNE"
        /// </summary>
        [EnumMember(Value = "JUNE")]
        JUNE,

        /// <summary>
        /// Enum MARCH for "MARCH"
        /// </summary>
        [EnumMember(Value = "MARCH")]
        MARCH,

        /// <summary>
        /// Enum MAY for "MAY"
        /// </summary>
        [EnumMember(Value = "MAY")]
        MAY,

        /// <summary>
        /// Enum NOVEMBER for "NOVEMBER"
        /// </summary>
        [EnumMember(Value = "NOVEMBER")]
        NOVEMBER,

        /// <summary>
        /// Enum OCTOBER for "OCTOBER"
        /// </summary>
        [EnumMember(Value = "OCTOBER")]
        OCTOBER,

        /// <summary>
        /// Enum SEPTEMBER for "SEPTEMBER"
        /// </summary>
        [EnumMember(Value = "SEPTEMBER")]
        SEPTEMBER
    }

}
