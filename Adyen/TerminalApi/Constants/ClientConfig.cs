namespace Adyen.Constants
{
    public class ClientConfig
    {
        //Test cloud api endpoints
        public const string CloudApiEndPointTest = "https://terminal-api-test.adyen.com";

        //Live cloud api endpoints
        public const string CloudApiEndPointEULive = "https://terminal-api-live.adyen.com";
        public const string CloudApiEndPointAULive = "https://terminal-api-live-au.adyen.com";
        public const string CloudApiEndPointUSLive = "https://terminal-api-live-us.adyen.com";
        public const string CloudApiEndPointAPSELive = "https://terminal-api-live-apse.adyen.com";
        
        public const string NexoProtocolVersion = "3.0";
        
        /// <summary>
        /// Moved to <see cref="Core.Client.Extensions.HttpRequestMessageExtensions.AdyenLibraryName"/>.
        /// </summary>
        [Obsolete("Use Core.Client.Extensions.HttpRequestMessageExtensions.AdyenLibraryVersion/ instead.")]
        public const string UserAgentSuffix = Core.Client.Extensions.HttpRequestMessageExtensions.AdyenLibraryName + "/";

        /// <summary>
        /// Moved to <see cref="Core.Client.Extensions.HttpRequestMessageExtensions.AdyenLibraryName"/>.
        /// </summary>
        [Obsolete("Use Core.Client.Extensions.HttpRequestMessageExtensions.AdyenLibraryName instead.")]
        public const string LibName = Core.Client.Extensions.HttpRequestMessageExtensions.AdyenLibraryName;
        
        /// <summary>
        /// Moved to <see cref="Core.Client.Extensions.HttpRequestMessageExtensions.AdyenLibraryVersion"/>.
        /// </summary>
        [Obsolete("Use Core.Client.Extensions.HttpRequestMessageExtensions.AdyenLibraryVersion instead.")]
        public const string LibVersion = Core.Client.Extensions.HttpRequestMessageExtensions.AdyenLibraryVersion;
    }
}
