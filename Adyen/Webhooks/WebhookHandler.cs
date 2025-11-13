using System.Text;
using Adyen.Util;
using Adyen.Webhooks.Models;
using Newtonsoft.Json;

namespace Adyen.Webhooks
{
    /// <summary>
    /// Utility function to deserialize <see cref="NotificationRequest"/>.
    /// </summary>
    public class WebhookHandler
    {
        /// <summary>
        /// Deserializes a <see cref="NotificationRequest"/> object.
        /// </summary>
        /// <param name="jsonRequest">The JSON payload.</param>
        /// <param name="jsonSerializerSettings"><see cref="JsonSerializerSettings"/>.</param>
        /// <returns><see cref="NotificationRequest"/>.</returns>
        public NotificationRequest HandleNotificationRequest(string jsonRequest, JsonSerializerSettings jsonSerializerSettings = null)
        {
            if (jsonSerializerSettings == null)
            {
                jsonSerializerSettings = new JsonSerializerSettings();
                jsonSerializerSettings.Converters.Add(new ByteArrayConverter());
            }
            return JsonConvert.DeserializeObject<NotificationRequest>(jsonRequest, jsonSerializerSettings);
        }
    }
    
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
