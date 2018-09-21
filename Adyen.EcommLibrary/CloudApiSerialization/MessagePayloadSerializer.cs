using Adyen.EcommLibrary.Model.Nexo;

namespace Adyen.EcommLibrary.CloudApiSerialization
{
    internal class MessagePayloadSerializer<T> : IMessagePayloadSerializer<T> where T : IMessagePayload
    {
        public IMessagePayload Deserialize(string messagePayloadJson)
        {
            return Converter.JSonConvertDeserializerWrapper<T>.DeserializeObject(messagePayloadJson);
        }
    }
}
