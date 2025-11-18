namespace Adyen.ApiSerialization
{
    internal interface IMessagePayloadSerializer<out T> where T : IMessagePayload
    {
        IMessagePayload Deserialize(string messagePayloadJson);
    }
}
