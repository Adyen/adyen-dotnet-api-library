using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Core.Converters
{
    /// <summary>
    /// JsonConverter for byte arrays.
    /// </summary>
    public class ByteArrayConverter : JsonConverter<byte[]>
    {
        /// <summary>
        /// Reads a byte array during deserialization.
        /// </summary>
        /// <param name="reader"><see cref="Utf8JsonReader"/>.</param>
        /// <param name="typeToConvert"><see cref="Type"/>.</param>
        /// <param name="options"><see cref="JsonSerializerOptions"/>.</param>
        /// <returns>Byte array.</returns>
        public override byte[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;

            string value = reader.GetString();
            return Encoding.UTF8.GetBytes(value);
        }
        
        /// <summary>
        /// Writes a byte array during serialization.
        /// </summary>
        /// <param name="writer"><see cref="Utf8JsonWriter"/>.</param>
        /// <param name="value"><see cref="byte[]"/>.</param>
        /// <param name="options"><see cref="JsonSerializerOptions"/>.</param>
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