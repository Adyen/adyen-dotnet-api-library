using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.EcommLibrary.Model.Enum
{
    /// <summary>
    /// The device that the payment is being initiated from
    /// </summary>
    /// <value>The device that the payment is being initiated from</value>
    [JsonConverter(typeof(StringEnumConverter))]
    [DefaultValue(Browser)]
    public enum DeviceChannelEnum
    {
        /// <summary>
        /// Enum Browser for "browser"
        /// </summary>
        [EnumMember(Value = "browser")] Browser,

        /// <summary>
        /// Enum App for "app"
        /// </summary>
        [EnumMember(Value = "app")] App
    }
}