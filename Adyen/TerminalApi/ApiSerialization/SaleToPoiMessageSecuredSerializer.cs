using System;
using System.Runtime.Serialization;
using Adyen.Exceptions;
using Adyen.Model.TerminalApi;
using Adyen.Security;
using Newtonsoft.Json.Linq;

namespace Adyen.ApiSerialization
{
    public class SaleToPoiMessageSecuredSerializer
    {
        public string Serialize(SaleToPoiMessageSecured saleToPoiMessageSecured)
        {
            return Converter.JsonConvertSerializerWrapper.Serialize(saleToPoiMessageSecured);
        }

        public SaleToPoiMessageSecured Deserialize(string saleToPoiMessageSecuredJSon)
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

        internal void CheckForTerminalError(JObject terminalResponseJObject)
        {
            var possibleTerminalError = terminalResponseJObject.SelectToken("errors");
            if (possibleTerminalError != null)
            {
                throw new Exception(string.Format(ExceptionMessages.TerminalErrorResponse, possibleTerminalError));
            }
        }

        internal SaleToPoiMessageSecured ParseSaleToPoiMessageSecured(JToken saleToPoiMessageSecuredJToken)
        {
            var saleToPoiMessageSecured = new SaleToPoiMessageSecured();
            saleToPoiMessageSecured.MessageHeader = saleToPoiMessageSecuredJToken.SelectToken("MessageHeader").ToObject<MessageHeader>();
            saleToPoiMessageSecured.SecurityTrailer = saleToPoiMessageSecuredJToken.SelectToken("SecurityTrailer")
                .ToObject<SecurityTrailer>();
            try
            {
                saleToPoiMessageSecured.NexoBlob = saleToPoiMessageSecuredJToken.SelectToken("NexoBlob").ToObject<string>();
            }
            catch (Exception ex)
            {
                throw new DeserializationException("NexoBlob is empty in the response",ex.InnerException);
            }

            return saleToPoiMessageSecured;
        }
    }
}
