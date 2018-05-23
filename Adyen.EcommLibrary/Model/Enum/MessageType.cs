using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.EcommLibrary.Model.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MessageType
    {
        Request,
        Response,
        Notification,
    }
}
