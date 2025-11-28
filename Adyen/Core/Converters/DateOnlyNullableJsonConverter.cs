using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Core.Converters
{
    /// <summary>
    /// Formatter for 'date' openapi formats ss defined by full-date - RFC3339
    /// see https://github.com/OAI/OpenAPI-Specification/blob/master/versions/3.0.0.md#data-types
    /// </summary>
    public class DateOnlyNullableJsonConverter : JsonConverter<DateOnly?>
    {
        /// <summary>
        /// The formats used to deserialize the date.
        /// </summary>
        public static string[] Formats { get; } = {
            "yyyy'-'MM'-'dd",
            "yyyyMMdd"

        };

        /// <summary>
        /// Returns a nullable <see cref="DateOnly"/> from the Json object.
        /// </summary>
        /// <param name="reader"><see cref="Utf8JsonReader"/>.</param>
        /// <param name="typeToConvert"><see cref="Type"/>.</param>
        /// <param name="options"><see cref="JsonSerializerOptions"/>.</param>
        /// <returns><see cref="DateOnly"/>.</returns>
        public override DateOnly? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
            if (reader.TokenType == JsonTokenType.Null)
                return null;

            string value = reader.GetString()!;

            foreach(string format in Formats)
                if (DateOnly.TryParseExact(value, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateOnly result))
                    return result;

            return null;
        }

        /// <summary>
        /// Writes the <see cref="DateOnly"/> to the <see cref="Utf8JsonWriter"/>.
        /// </summary>
        /// <param name="writer"><see cref="Utf8JsonWriter"/>.</param>
        /// <param name="dateOnly"><see cref="DateOnly"/>.</param>
        /// <param name="options"><see cref="JsonSerializerOptions"/>.</param>
        public override void Write(Utf8JsonWriter writer, DateOnly? dateOnly, JsonSerializerOptions options)
        {
            if (dateOnly == null)
                writer.WriteNullValue();
            else
                writer.WriteStringValue(dateOnly.Value.ToString("yyyy'-'MM'-'dd", CultureInfo.InvariantCulture));
        }
    }
}
