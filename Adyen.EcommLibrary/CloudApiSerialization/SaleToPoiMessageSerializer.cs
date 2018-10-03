using System;
using System.Collections.Generic;
using Adyen.EcommLibrary.Model.Nexo;
using Adyen.EcommLibrary.Security;
using Newtonsoft.Json.Linq;
using Adyen.EcommLibrary.Model.Nexo.Message;

namespace Adyen.EcommLibrary.CloudApiSerialization
{
    public class SaleToPoiMessageSerializer
    {
        private readonly MessageHeaderSerializer _messageHeaderSerializer;
        private readonly MessagePayloadSerializerFactory _messagePayloadSerializerFactory;
      

        public SaleToPoiMessageSerializer()
        {
            _messageHeaderSerializer = new MessageHeaderSerializer();
            _messagePayloadSerializerFactory = new MessagePayloadSerializerFactory();
        }

        public SaleToPOIResponse Deserialize(string saleToPoiMessageDto)
        {
            try
            {
                //Only for async action
                if (saleToPoiMessageDto == "ok")
                {
                    return new SaleToPOIResponse()
                    {
                        MessageHeader = new MessageHeader()
                        {
                            
                        },
                    };
                }
                var saleToPoiMessageJObject = JObject.Parse(saleToPoiMessageDto);
                var saleToPoiMessageRootJToken = saleToPoiMessageJObject.First;
                var saleToPoiMessageWithoutRootJToken = saleToPoiMessageRootJToken.First;
                var messageHeader = DeserializeMessageHeader(saleToPoiMessageWithoutRootJToken);
                var messagePayload = DeserealizeMessagePayload(messageHeader, saleToPoiMessageWithoutRootJToken);

                var deserializedOutputMessage = new SaleToPOIResponse
                {
                    MessageHeader = messageHeader,
                    MessagePayload = messagePayload
                };
                
                return deserializedOutputMessage;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        
        private object DeserealizeMessagePayload(MessageHeader messageHeader, JToken saleToPoiMessageWithoutRootJToken)
        {
            var messageCategory = messageHeader.MessageCategory;
            var messageType = messageHeader.MessageType;
            var messagePayloadJson = GetMessagePayloadJSon(saleToPoiMessageWithoutRootJToken, messageCategory, messageType);

            var messagePayloadSerializer = _messagePayloadSerializerFactory.CreateSerializer(messageCategory, messageType);
            return messagePayloadSerializer.Deserialize(messagePayloadJson);
        }

        private string GetMessagePayloadJSon(JToken saleToPoiMessageWithoutRootJToken, string messageCategory, string messageType)
        {
            var messagePayloadTypedJson = saleToPoiMessageWithoutRootJToken.SelectToken(messageCategory + messageType.ToString());
          
            if (messagePayloadTypedJson == null)
            {
                return saleToPoiMessageWithoutRootJToken.SelectToken("MessagePayload").ToString();
            }
            return messagePayloadTypedJson.ToString();
        }
        private MessageHeader DeserializeMessageHeader(JToken saleToPoiMessageWithoutRootJObject)
        {
            var messageHeaderJson = saleToPoiMessageWithoutRootJObject.SelectToken("MessageHeader").ToString();
            var messageHeader = _messageHeaderSerializer.Deserialize(messageHeaderJson);
          
            return messageHeader;
        }

        public string Serialize(SaleToPOIMessage saleToPoiMessage)
        {
            try
            {
                return Converter.JSonConvertSerializerWrapper.Serialize(saleToPoiMessage);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string Serialize(SaleToPoiMessageSecured saleToPoiMessage)
        {
            try
            {
                return Converter.JSonConvertSerializerWrapper.Serialize(saleToPoiMessage);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
