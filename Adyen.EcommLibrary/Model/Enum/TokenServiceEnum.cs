using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.EcommLibrary.Model.Enum
{
    /// <summary>
    /// The name of the token service.
    /// </summary>
    /// <value>The name of the token service.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TokenServiceEnum
    {

        /// <summary>
        /// Enum VISATOKENSERVICE for "VISATOKENSERVICE"
        /// </summary>
        [EnumMember(Value = "VISATOKENSERVICE")]
        VISATOKENSERVICE
    }

}
