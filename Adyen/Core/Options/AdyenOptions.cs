namespace Adyen.Core.Options
{
    /// <summary>
    /// Stores the variables used to communicate with the Adyen platforms.
    /// </summary>
    public class AdyenOptions
    {
        /// <summary>
        /// The Adyen Environment.
        /// </summary>
        public AdyenEnvironment Environment { get; set; } = AdyenEnvironment.Test;

        /// <summary>
        /// Used in the LIVE environment only.
        /// This prefix is appended to HttpClient.BaseAddress when <see cref="Environment"/> is set to `AdyenEnvironment.Live`
        /// See: https://docs.adyen.com/development-resources/live-endpoints/
        /// </summary>
        public string LiveEndpointUrlPrefix { get; set; }
        
        /// <summary>
        /// The `ADYEN_API_KEY` is an Adyen API authentication token that must be included in the HTTP request header and allows your application to securely communicate with the Adyen APIs.
        /// Guide on how to obtain the `ADYEN_API_KEY`
        /// 1. For Digital/ECOM & In-Person Payments, visit: https://docs.adyen.com/development-resources/api-credentials/#generate-api-key to get your API Key.
        /// 2. For Platforms & Financial Services, visit: https://docs.adyen.com/adyen-for-platforms-model to get started.
        /// </summary>
        public string AdyenApiKey { get; set; }

        /// <summary>
        /// The `ADYEN_HMAC_KEY` is used to verify the incoming HMAC signature from incoming webhooks.
        /// To protect your server from unauthorised webhook events, Adyen recommends that you use Hash-based message authentication code HMAC signatures for our webhooks.
        /// Each webhook event will include a signature calculated using a secret `ADYEN_HMAC_KEY` key and the payload from the webhook.
        /// By verifying this signature, you confirm that the webhook was sent by Adyen, and was not modified during transmission.
        /// </summary>
        public string AdyenHmacKey { get; set; }
    }
}