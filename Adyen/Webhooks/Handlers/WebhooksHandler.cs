using System.Text.Json;
using Adyen.Util;
using Adyen.Webhooks.Client;
using Adyen.Webhooks.Models;

namespace Adyen.Webhooks.Handlers
{
    /// <summary>
    /// Interface for deserializing classic webhooks.
    /// </summary>
    public interface IWebhooksHandler
    {
        /// <summary>
        /// Returns the <see cref="JsonSerializerOptionsProvider"/> to deserialize the json payload from the webhook.
        /// </summary>
        JsonSerializerOptionsProvider JsonSerializerOptionsProvider { get; }

        /// <summary>
        /// Uses <see cref="JsonSerializerOptionsProvider"/> to attempt to deserialize <see cref="NotificationRequest"/>.
        /// </summary>
        /// <param name="json">The full webhook payload.</param>
        /// <exception cref="JsonException"></exception>
        NotificationRequest DeserializeNotificationRequest(string json);

        /// <summary>
        /// Verifies the HMAC signature from a notification item using the provided HMAC key.
        /// </summary>
        /// <param name="notificationRequestItem"><see cref="NotificationRequestItem"/> from the webhook payload.</param>
        /// <param name="hmacKey">The HMAC key, retrieved from the Adyen Customer Area.</param>
        /// <returns>True if the HMAC signature is valid.</returns>
        bool IsValidHmacSignature(NotificationRequestItem notificationRequestItem, string hmacKey);
    }

    /// <summary>
    /// Handler utility function used to deserialize classic webhooks.
    /// </summary>
    public class WebhooksHandler : IWebhooksHandler
    {
        private readonly IHmacValidator _hmacValidator;

        /// <inheritdoc/>
        public JsonSerializerOptionsProvider JsonSerializerOptionsProvider { get; }

        /// <summary>
        /// Initializes the handler utility for deserializing classic webhooks.
        /// </summary>
        /// <param name="jsonSerializerOptionsProvider"><see cref="JsonSerializerOptionsProvider"/>.</param>
        /// <param name="hmacValidator"><see cref="IHmacValidator"/>.</param>
        public WebhooksHandler(JsonSerializerOptionsProvider jsonSerializerOptionsProvider, IHmacValidator hmacValidator)
        {
            JsonSerializerOptionsProvider = jsonSerializerOptionsProvider;
            _hmacValidator = hmacValidator;
        }

        /// <inheritdoc/>
        public NotificationRequest DeserializeNotificationRequest(string json)
        {
            return JsonSerializer.Deserialize<NotificationRequest>(json, JsonSerializerOptionsProvider.Options);
        }

        /// <inheritdoc/>
        public bool IsValidHmacSignature(NotificationRequestItem notificationRequestItem, string hmacKey)
        {
            return _hmacValidator.IsValidHmac(notificationRequestItem, hmacKey);
        }
    }
}
