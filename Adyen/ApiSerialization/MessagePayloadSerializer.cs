namespace Adyen.ApiSerialization
{
    internal class MessagePayloadSerializer<T> : IMessagePayloadSerializer<T> where T : IMessagePayload
    {
        public IMessagePayload Deserialize(string messagePayloadJson)
        {
            return Converter.JsonConvertDeserializerWrapper<T>.DeserializeObject(messagePayloadJson);
        }

    }
}
