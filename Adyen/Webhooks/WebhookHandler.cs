using System;
using System.Text.Json;
using Adyen.Webhooks.Models;

namespace Adyen.Webhooks
{
    /// <summary>
    /// Utility function to deserialize <see cref="NotificationRequest"/>.
    /// </summary>
    [Obsolete("WebhookHandler is deprecated and will be removed in a future version. Use Adyen.Webhooks.Handlers.IWebhooksHandler via services.AddWebhooksHandler() and HostBuilder.ConfigureWebhooks(...).")]
    public class WebhookHandler
    {
        /// <summary>
        /// Deserializes a <see cref="NotificationRequest"/> object.
        /// </summary>
        /// <param name="jsonRequest">The JSON payload.</param>
        /// <param name="jsonSerializerOptions"><see cref="JsonSerializerOptions"/>.</param>
        /// <returns><see cref="NotificationRequest"/>.</returns>
        [Obsolete("HandleNotificationRequest is deprecated. Use Adyen.Webhooks.Handlers.IWebhooksHandler.DeserializeNotificationRequest instead.")]
        public NotificationRequest HandleNotificationRequest(string jsonRequest, JsonSerializerOptions jsonSerializerOptions = null)
        {
            if (jsonSerializerOptions == null)
            {
                jsonSerializerOptions = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
            }
            return JsonSerializer.Deserialize<NotificationRequest>(jsonRequest, jsonSerializerOptions);
        }
    }
}
