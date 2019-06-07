using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Enum
{
    /// <summary>
    /// The enrollment response from the 3D directory server.
    /// </summary>
    /// <value>The enrollment response from the 3D directory server.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DirectoryResponseEnum
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
        /// Enum E for "E"
        /// </summary>
        [EnumMember(Value = "E")]
        E
    }
}
