using Adyen.Model.Nexo;

namespace Adyen.CloudApiSerialization
{
    internal interface IMessagePayloadSerializer<out T> where T : IMessagePayload
    {
        IMessagePayload Deserialize(string messagePayloadJson);
    }
}
