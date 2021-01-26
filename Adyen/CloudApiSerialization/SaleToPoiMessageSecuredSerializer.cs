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
using System.Runtime.Serialization;
using Adyen.Exceptions;
using Adyen.Model.Nexo;
using Adyen.Security;
using Newtonsoft.Json.Linq;

namespace Adyen.CloudApiSerialization
{
    internal class SaleToPoiMessageSecuredSerializer
    {
        internal string Serialize(SaleToPoiMessageSecured saleToPoiMessageSecured)
        {
            return Converter.JSonConvertSerializerWrapper.Serialize(saleToPoiMessageSecured);
        }

        internal SaleToPoiMessageSecured Deserialize(string saleToPoiMessageSecuredJSon)
        {
            if (string.IsNullOrEmpty(saleToPoiMessageSecuredJSon))
            {
                return null;
            }
            var saleToPoiMessageSecuredJObject = JObject.Parse(saleToPoiMessageSecuredJSon);

            CheckForTerminalError(saleToPoiMessageSecuredJObject);

            var saleToPoiMessageSecuredJObjectRoot = saleToPoiMessageSecuredJObject.First;
            var saleToPoiMessageSecuredJObjectWithoutRoot = saleToPoiMessageSecuredJObjectRoot?.First;
            if (saleToPoiMessageSecuredJObjectWithoutRoot != null)
            {
                return ParseSaleToPoiMessageSecured(saleToPoiMessageSecuredJObjectWithoutRoot);
            }

            var exceptionMessage = string.Format(ExceptionMessages.ExceptionDuringDeserialization, saleToPoiMessageSecuredJSon, ExceptionMessages.SaleToPoiMessageRootMissing);
            throw new SerializationException(exceptionMessage);
        }

        private void CheckForTerminalError(JObject terminalResponseJObject)
        {
            var possibleTerminalError = terminalResponseJObject.SelectToken("errors");
            if (possibleTerminalError != null)
            {
                throw new Exception(string.Format(ExceptionMessages.TerminalErrorResponse, possibleTerminalError));
            }
        }

        private SaleToPoiMessageSecured ParseSaleToPoiMessageSecured(JToken saleToPoiMessageSecuredJToken)
        {
            var saleToPoiMessageSecured = new SaleToPoiMessageSecured()
            {
                MessageHeader = saleToPoiMessageSecuredJToken.SelectToken("MessageHeader").ToObject<MessageHeader>(),
                NexoBlob = saleToPoiMessageSecuredJToken.SelectToken("NexoBlob").ToObject<string>(),
                SecurityTrailer = saleToPoiMessageSecuredJToken.SelectToken("SecurityTrailer").ToObject<SecurityTrailer>()
            };

            return saleToPoiMessageSecured;
        }
    }
}
