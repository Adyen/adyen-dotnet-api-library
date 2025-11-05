namespace Adyen.Core.Options
{
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
        /// If this is set to true, we log every 
        /// </summary>
        public bool IsLogInformationServices { get; set; } = false;
    }
}