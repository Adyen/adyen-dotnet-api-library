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

using Adyen.Model.Nexo;
using Adyen.Security;
using Newtonsoft.Json.Linq;

namespace Adyen.ApiSerialization
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
            var saleToPoiMessageJObject = JObject.Parse(saleToPoiMessageDto);
            var saleToPoiMessageRootJToken = saleToPoiMessageJObject.First;
            var saleToPoiMessageWithoutRootJToken = saleToPoiMessageRootJToken.First;
            //Messageheader
            var messageHeader = DeserializeMessageHeader(saleToPoiMessageWithoutRootJToken);
            //Message payload
            object messagePayload = DeserializeMessagePayload(messageHeader, saleToPoiMessageWithoutRootJToken);

            var deserializedOutputMessage = new SaleToPOIResponse
            {
                MessageHeader = messageHeader,
                MessagePayload = messagePayload
            };

            //Check and deserialize RepeatedMessageResponse. RepeatedMessageResponse is optional
            if (saleToPoiMessageDto.Contains("TransactionStatusResponse") && saleToPoiMessageDto.Contains("RepeatedMessageResponse") && saleToPoiMessageDto.Contains("RepeatedResponseMessageBody"))
            {
                var response = GetDeserializedRepeatedResponseMessagePayload(saleToPoiMessageWithoutRootJToken);
                TransactionStatusResponse deserializedOutput = (TransactionStatusResponse)deserializedOutputMessage.MessagePayload;
                deserializedOutput.RepeatedMessageResponse.RepeatedResponseMessageBody.MessagePayload = response;
                deserializedOutputMessage.MessagePayload = deserializedOutput;
            }
            return deserializedOutputMessage;
        }

        private object DeserializeMessagePayload(MessageHeader messageHeader, JToken saleToPoiMessageWithoutRootJToken)
        {
            var messageCategory = messageHeader.MessageCategory;
            var messageType = messageHeader.MessageType;
            var messagePayloadJson = GetMessagePayloadJSon(saleToPoiMessageWithoutRootJToken, messageCategory.ToString(), messageType.ToString());

            var messagePayloadSerializer = _messagePayloadSerializerFactory.CreateSerializer(messageCategory.ToString(), messageType.ToString());
            return messagePayloadSerializer.Deserialize(messagePayloadJson);
        }

        public string Serialize(SaleToPOIMessage saleToPoiMessage)
        {
            return Converter.JSonConvertSerializerWrapper.Serialize(saleToPoiMessage);
        }

        public string Serialize(SaleToPoiMessageSecured saleToPoiMessage)
        {
            return Converter.JSonConvertSerializerWrapper.Serialize(saleToPoiMessage);
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
            return _messageHeaderSerializer.Deserialize(messageHeaderJson);
        }

        private object GetDeserializedRepeatedResponseMessagePayload(JToken saletoPoiMessageJtoken)
        {
            var repeatedMessageResponse = saletoPoiMessageJtoken.ToString();
            var repeatedMessage = saletoPoiMessageJtoken["TransactionStatusResponse"]["RepeatedMessageResponse"]["RepeatedResponseMessageBody"].ToString();
            var objMessage = JObject.Parse(repeatedMessage);
         
            if (repeatedMessageResponse.Contains("CardAcquisitionResponse"))
            {
                return objMessage["CardAcquisitionResponse"].ToObject<CardAcquisitionResponse>();
            }
            if (repeatedMessageResponse.Contains("CardReaderAPDUResponse"))
            {
                return objMessage["CardReaderAPDUResponse"].ToObject<CardReaderAPDUResponse>();
            }
            if (repeatedMessageResponse.Contains("LoyaltyResponse"))
            {
                return objMessage["LoyaltyResponse"].ToObject<LoyaltyResponse>();
            }
            if (repeatedMessageResponse.Contains("PaymentResponse"))
            {
                return objMessage["PaymentResponse"].ToObject<PaymentResponse>();
            }
            if (repeatedMessageResponse.Contains("ReversalResponse"))
            {
                return objMessage["ReversalResponse"].ToObject<ReversalResponse>();
            }
            if (repeatedMessageResponse.Contains("StoredValueResponse"))
            {
                return objMessage["StoredValueResponse"].ToObject<StoredValueResponse>();
            }
            return null;
        }
    }
}
