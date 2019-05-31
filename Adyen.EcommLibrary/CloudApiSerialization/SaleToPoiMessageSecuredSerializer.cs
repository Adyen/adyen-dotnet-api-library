using System;
using System.Runtime.Serialization;
using Adyen.EcommLibrary.Exceptions;
using Adyen.EcommLibrary.Model.Nexo;
using Adyen.EcommLibrary.Security;
using Newtonsoft.Json.Linq;

namespace Adyen.EcommLibrary.CloudApiSerialization
{
    internal class SaleToPoiMessageSecuredSerializer
    {
        internal string Serialize(SaleToPoiMessageSecured saleToPoiMessageSecured)
        {
            return Converter.JSonConvertSerializerWrapper.Serialize(saleToPoiMessageSecured);
        }

        internal SaleToPoiMessageSecured Deserialize(string saleToPoiMessageSecuredJSon)
        {
            var saleToPoiMessageSecuredJObject = JObject.Parse(saleToPoiMessageSecuredJSon);

            CheckForTerminalError(saleToPoiMessageSecuredJObject);

            var saleToPoiMessageSecuredJObjectRoot = saleToPoiMessageSecuredJObject.First;
            var saleToPoiMessageSecuredJObjectWithoutRoot = saleToPoiMessageSecuredJObjectRoot?.First;
            if (saleToPoiMessageSecuredJObjectWithoutRoot != null)
                return ParseSaleToPoiMessageSecured(saleToPoiMessageSecuredJObjectWithoutRoot);

            var exceptionMessage = string.Format(ExceptionMessages.ExceptionDuringDeserialization,
                saleToPoiMessageSecuredJSon, ExceptionMessages.SaleToPoiMessageRootMissing);
            throw new SerializationException(exceptionMessage);
        }

        private void CheckForTerminalError(JObject terminalResponseJObject)
        {
            var possibleTerminalError = terminalResponseJObject.SelectToken("errors");
            if (possibleTerminalError != null)
                throw new Exception(string.Format(ExceptionMessages.TerminalErrorResponse, possibleTerminalError));
        }

        private SaleToPoiMessageSecured ParseSaleToPoiMessageSecured(JToken saleToPoiMessageSecuredJToken)
        {
            var saleToPoiMessageSecured = new SaleToPoiMessageSecured()
            {
                MessageHeader = saleToPoiMessageSecuredJToken.SelectToken("MessageHeader").ToObject<MessageHeader>(),
                NexoBlob = saleToPoiMessageSecuredJToken.SelectToken("NexoBlob").ToObject<string>(),
                SecurityTrailer = saleToPoiMessageSecuredJToken.SelectToken("SecurityTrailer")
                    .ToObject<SecurityTrailer>()
            };

            return saleToPoiMessageSecured;
        }
    }
}