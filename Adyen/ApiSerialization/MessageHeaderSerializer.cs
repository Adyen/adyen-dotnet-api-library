using Adyen.Model.TerminalApi;

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
