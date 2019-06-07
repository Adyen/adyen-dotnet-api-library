using Adyen.Model.Nexo;
using Newtonsoft.Json.Linq;
using System;

namespace Adyen.CloudApiSerialization
{
    internal class MessagePayloadSerializer<T> : IMessagePayloadSerializer<T> where T : IMessagePayload
    {
        public IMessagePayload Deserialize(string messagePayloadJson)
        {
            return Converter.JSonConvertDeserializerWrapper<T>.DeserializeObject(messagePayloadJson);
        }

    }
}
