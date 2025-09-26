using System;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Util
{
    internal class ByteArrayConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(byte[]);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;
            return Encoding.UTF8.GetBytes((string)reader.Value);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            byte[] bytes = (byte[])value;
            writer.WriteValue(Encoding.UTF8.GetString(bytes));
        }
        
    }
}