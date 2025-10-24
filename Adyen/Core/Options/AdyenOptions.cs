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
        /// Default value: empty string.
        /// This prefix is appended to HttpClient.BaseAddress when <see cref="Environment"/> is set to `AdyenEnvironment.Live`
        /// See: https://docs.adyen.com/development-resources/live-endpoints/
        /// </summary>
        public string LiveEndpointUrlPrefix { get; set; } = string.Empty;
    }
}