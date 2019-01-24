using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.EcommLibrary.Model.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ThreeDSecure2TransactionResultStatus
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
    }
}
