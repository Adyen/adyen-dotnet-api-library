using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Core.Converters
{
    public class ByteArrayConverter : JsonConverter<byte[]>
    {
        public override byte[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;

            string value = reader.GetString();
            return Encoding.UTF8.GetBytes(value);
        }

        public override void Write(Utf8JsonWriter writer, byte[] value, JsonSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStringValue(Encoding.UTF8.GetString(value));
        }
    }
}