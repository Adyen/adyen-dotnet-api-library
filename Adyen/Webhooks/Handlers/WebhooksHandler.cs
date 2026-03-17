using System.Text.Json;
using Adyen.Core.Auth;
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
        /// Verifies the HMAC signature of the webhook notification item.
        /// </summary>
        /// <param name="notificationRequestItem"><see cref="NotificationRequestItem"/> from the webhook payload.</param>
        /// <returns>True if the HMAC signature is valid.</returns>
        /// <exception cref="InvalidOperationException">An error has occurred.</exception>
        bool IsValidHmacSignature(NotificationRequestItem notificationRequestItem);
    }

    /// <summary>
    /// Handler utility function used to deserialize classic webhooks.
    /// </summary>
    public class WebhooksHandler : IWebhooksHandler
    {
        private readonly string? _adyenHmacKey;
        private readonly IHmacValidator _hmacValidator;

        /// <inheritdoc/>
        public JsonSerializerOptionsProvider JsonSerializerOptionsProvider { get; }

        /// <summary>
        /// Initializes the handler utility for deserializing classic webhooks.
        /// </summary>
        /// <param name="jsonSerializerOptionsProvider"><see cref="JsonSerializerOptionsProvider"/>.</param>
        /// <param name="hmacValidator"><see cref="IHmacValidator"/>.</param>
        /// <param name="hmacKeyProvider"><see cref="ITokenProvider{HmacKeyToken}"/> which contains the HMAC key configured in <see cref="Adyen.Core.Options.AdyenOptions"/>.</param>
        public WebhooksHandler(JsonSerializerOptionsProvider jsonSerializerOptionsProvider, IHmacValidator hmacValidator, ITokenProvider<HmacKeyToken>? hmacKeyProvider = null)
        {
            JsonSerializerOptionsProvider = jsonSerializerOptionsProvider;
            _hmacValidator = hmacValidator;
            _adyenHmacKey = hmacKeyProvider?.Get().AdyenHmacKey;
        }

        /// <inheritdoc/>
        public NotificationRequest DeserializeNotificationRequest(string json)
        {
            return JsonSerializer.Deserialize<NotificationRequest>(json, JsonSerializerOptionsProvider.Options);
        }

        /// <inheritdoc/>
        public bool IsValidHmacSignature(NotificationRequestItem notificationRequestItem)
        {
            if (string.IsNullOrWhiteSpace(_adyenHmacKey))
            {
                throw new InvalidOperationException(
                    "HMAC validation failed because the ADYEN_HMAC_KEY is not configured.");
            }

            return _hmacValidator.IsValidHmac(notificationRequestItem, _adyenHmacKey);
        }
    }
}
