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
            JObject saleToPoiMessageJObject = JObject.Parse(saleToPoiMessageDto);
            JToken saleToPoiMessageRootJToken = saleToPoiMessageJObject.First;
            JToken saleToPoiMessageWithoutRootJToken = saleToPoiMessageRootJToken.First;
            //Messageheader
            MessageHeader messageHeader = DeserializeMessageHeader(saleToPoiMessageWithoutRootJToken);
            //Message payload
            object messagePayload = DeserializeMessagePayload(messageHeader, saleToPoiMessageWithoutRootJToken);

            SaleToPOIResponse deserializedOutputMessage = new SaleToPOIResponse
            {
                MessageHeader = messageHeader,
                MessagePayload = messagePayload
            };

            //Check and deserialize RepeatedMessageResponse. RepeatedMessageResponse is optional
            if (saleToPoiMessageDto.Contains("TransactionStatusResponse") && saleToPoiMessageDto.Contains("RepeatedMessageResponse") && saleToPoiMessageDto.Contains("RepeatedResponseMessageBody"))
            {
                object response = GetDeserializedRepeatedResponseMessagePayload(saleToPoiMessageWithoutRootJToken);
                TransactionStatusResponse deserializedOutput = (TransactionStatusResponse)deserializedOutputMessage.MessagePayload;
                deserializedOutput.RepeatedMessageResponse.RepeatedResponseMessageBody.MessagePayload = response;
                deserializedOutputMessage.MessagePayload = deserializedOutput;
            }
            return deserializedOutputMessage;
        }

        private object DeserializeMessagePayload(MessageHeader messageHeader, JToken saleToPoiMessageWithoutRootJToken)
        {
            MessageCategoryType messageCategory = messageHeader.MessageCategory;
            MessageType messageType = messageHeader.MessageType;
            string messagePayloadJson = GetMessagePayloadJSon(saleToPoiMessageWithoutRootJToken, messageCategory.ToString(), messageType.ToString());

            IMessagePayloadSerializer<IMessagePayload> messagePayloadSerializer = _messagePayloadSerializerFactory.CreateSerializer(messageCategory.ToString(), messageType.ToString());
            return messagePayloadSerializer.Deserialize(messagePayloadJson);
        }

        public string Serialize(SaleToPOIMessage saleToPoiMessage)
        {
            return Converter.JsonConvertSerializerWrapper.Serialize(saleToPoiMessage);
        }

        public string Serialize(SaleToPoiMessageSecured saleToPoiMessage)
        {
            return Converter.JsonConvertSerializerWrapper.Serialize(saleToPoiMessage);
        }

        private string GetMessagePayloadJSon(JToken saleToPoiMessageWithoutRootJToken, string messageCategory, string messageType)
        {
            JToken messagePayloadTypedJson = saleToPoiMessageWithoutRootJToken.SelectToken(messageCategory + messageType.ToString());
            if (messagePayloadTypedJson == null)
            {
                return saleToPoiMessageWithoutRootJToken.SelectToken("MessagePayload").ToString();
            }
            return messagePayloadTypedJson.ToString();
        }
        private MessageHeader DeserializeMessageHeader(JToken saleToPoiMessageWithoutRootJObject)
        {
            string messageHeaderJson = saleToPoiMessageWithoutRootJObject.SelectToken("MessageHeader").ToString();
            return _messageHeaderSerializer.Deserialize(messageHeaderJson);
        }

        private object GetDeserializedRepeatedResponseMessagePayload(JToken saletoPoiMessageJtoken)
        {
            string repeatedMessageResponse = saletoPoiMessageJtoken.ToString();
            string repeatedMessage = saletoPoiMessageJtoken["TransactionStatusResponse"]["RepeatedMessageResponse"]["RepeatedResponseMessageBody"].ToString();
            JObject objMessage = JObject.Parse(repeatedMessage);
         
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
