#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using Adyen.Model.Nexo;

namespace Adyen.ApiSerialization
{
    internal class MessagePayloadSerializerFactory
    {
        internal IMessagePayloadSerializer<IMessagePayload> CreateSerializer(string messageCategory, string messageType)
        {
            string messagePayoadFullName = CreateMessagePayloadFullName(messageCategory, messageType);
            Type messagePayloadSerializer = TypeHelper.CreateGenericTypeFromStringFullNamespace(typeof(MessagePayloadSerializer<>), messagePayoadFullName);

            return (IMessagePayloadSerializer<IMessagePayload>)Activator.CreateInstance(messagePayloadSerializer);
        }

        private string CreateMessagePayloadFullName(string messageCategory, string messageType)
        {
            string nameSpaceSeparator = ".";

            string messagePayloadName = messageCategory.ToString() + messageType;
            string nexoDomainNameSpace = typeof(PaymentRequest).Namespace;

            return string.Concat(nexoDomainNameSpace, nameSpaceSeparator, messagePayloadName);
        }
    }
}
