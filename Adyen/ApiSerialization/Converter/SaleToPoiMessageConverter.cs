using System;
using Adyen.Model.Terminal;
using Adyen.Model.TerminalApi;
using Newtonsoft.Json;

namespace Adyen.ApiSerialization.Converter
{
    internal class SaleToPoiMessageConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.NullValueHandling = NullValueHandling.Ignore;
            serializer.MissingMemberHandling = MissingMemberHandling.Ignore;
            writer.WriteStartObject();
            writer.WritePropertyName(value.GetType().Name);
            writer.WriteStartObject();
            var saleToPoiMessage = value as SaleToPOIRequest;
            writer.WritePropertyName(saleToPoiMessage.MessageHeader.GetType().Name);
            serializer.Serialize(writer, saleToPoiMessage.MessageHeader);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(SaleToPOIRequest).IsAssignableFrom(objectType);
        }
    }
}
