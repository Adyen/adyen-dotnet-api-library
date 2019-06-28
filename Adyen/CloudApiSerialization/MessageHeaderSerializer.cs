using Adyen.Model.Nexo;
using Adyen.Model.Nexo.Message;

namespace Adyen.CloudApiSerialization
{
    internal class MessageHeaderSerializer
    {
        internal MessageHeader Deserialize(string messageHeaderJson)
        {
            return Converter.JSonConvertDeserializerWrapper<MessageHeader>.DeserializeObject(messageHeaderJson);
        }
    }
}
