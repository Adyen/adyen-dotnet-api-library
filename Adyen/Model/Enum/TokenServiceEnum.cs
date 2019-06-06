using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Adyen.Model.Enum
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
        Visatokenservice
    }

}
