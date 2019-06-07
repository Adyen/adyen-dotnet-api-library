using System;
using Adyen.Model.Enum;
using Adyen.Model.Nexo;

namespace Adyen.CloudApiSerialization
{
    internal class MessagePayloadSerializerFactory
    {
        internal IMessagePayloadSerializer<IMessagePayload> CreateSerializer(string messageCategory, string messageType)
        {
            var messagePayoadFullName = CreateMessagePayloadFullName(messageCategory, messageType);
            var messagePayloadSerializer = TypeHelper.CreateGenericTypeFromStringFullNamespace(typeof(MessagePayloadSerializer<>), messagePayoadFullName);

            return (IMessagePayloadSerializer<IMessagePayload>)Activator.CreateInstance(messagePayloadSerializer);
        }

        private string CreateMessagePayloadFullName(string messageCategory, string messageType)
        {
            var nameSpaceSeparator = ".";

            var messagePayloadName = messageCategory.ToString() + messageType;
            var nexoDomainNameSpace = typeof(PaymentRequest).Namespace;

            return string.Concat(nexoDomainNameSpace, nameSpaceSeparator, messagePayloadName);
        }
    }
}
