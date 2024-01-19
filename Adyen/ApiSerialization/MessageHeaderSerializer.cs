using Adyen.Model.Terminal;

namespace Adyen.ApiSerialization
{
    internal class MessageHeaderSerializer
    {
        internal MessageHeader Deserialize(string messageHeaderJson)
        {
            return Converter.JsonConvertDeserializerWrapper<MessageHeader>.DeserializeObject(messageHeaderJson);
        }
    }
}
