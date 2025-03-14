﻿using System;
using Adyen.Model.TerminalApi;
using Newtonsoft.Json;

namespace Adyen.ApiSerialization.Converter
{
    internal class SaleToPoiMessageConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName(value.GetType().Name);
            writer.WriteStartObject();
            var saleToPoiMessage = value as SaleToPOIMessage;
            writer.WritePropertyName(saleToPoiMessage.MessageHeader.GetType().Name);
            serializer.Serialize(writer, saleToPoiMessage.MessageHeader);
            writer.WritePropertyName(saleToPoiMessage.MessagePayload.GetType().Name);
            serializer.Serialize(writer, saleToPoiMessage.MessagePayload);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(SaleToPOIMessage).IsAssignableFrom(objectType);
        }
    }
}
