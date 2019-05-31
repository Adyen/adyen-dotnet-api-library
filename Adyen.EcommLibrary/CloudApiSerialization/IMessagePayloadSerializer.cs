namespace Adyen.EcommLibrary.CloudApiSerialization
{
    internal interface IMessagePayloadSerializer<out T> where T : IMessagePayload
    {
        IMessagePayload Deserialize(string messagePayloadJson);
    }
}