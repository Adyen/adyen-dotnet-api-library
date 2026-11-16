using Adyen.Core.Options;

namespace Adyen.Core.Client
{
    /// <summary>
    /// Helper utility functions to construct the Adyen live-urls for our APIs.
    /// </summary>
    public static class UrlBuilderExtensions
    {
        private static readonly string[] RegionalApiHostNames = { "softposconfig" };

        private static readonly Dictionary<AdyenRegion, string> RegionalLiveUrlTemplates = new()
        {
            { AdyenRegion.EU, "https://{0}-live.adyen.com" },
            { AdyenRegion.AU, "https://{0}-live-au.adyen.com" },
            { AdyenRegion.US, "https://{0}-live-us.adyen.com" },
            { AdyenRegion.APSE, "https://{0}-live-apse.adyen.com" },
            { AdyenRegion.NEA, "https://{0}-live-nea.adyen.com" }
        };

        /// <summary>
        /// Constructs the Host URL based on the selected <see cref="AdyenEnvironment"/>, used to populate the `HttpClient.BaseAddress`.
        /// </summary>
        /// <param name="adyenOptions"><see cref="AdyenOptions"/>.</param>
        /// <param name="baseUrl">The base URL of the API.</param>
        /// <returns>String containing the Host URL.</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string ConstructHostUrl(AdyenOptions adyenOptions, string baseUrl)
        {
            if (adyenOptions.Environment == AdyenEnvironment.Live)
                return ConstructLiveUrl(adyenOptions.LiveEndpointUrlPrefix, baseUrl, adyenOptions.Region);

            // Some Adyen OpenApi Specifications use the live-url, instead of the test-url, this line replaces "-live" with "-test".
            // If you need to override this URL, you can do so by replacing the BASE_URL in ClientUtils.cs.
            if (adyenOptions.Environment == AdyenEnvironment.Test)
                return baseUrl.Replace("-live", "-test");

            throw new ArgumentOutOfRangeException(adyenOptions.Environment.ToString());
        }

        /// <summary>
        /// Construct LIVE BaseUrl, add the liveEndpointUrlPrefix it's the Checkout API or the Classic Payment API.
        /// This helper function can be removed when all URLs (test & live) are included in the Adyen OpenApi Specifications: https://github.com/Adyen/adyen-openapi.
        /// </summary>
        /// <param name="liveEndpointUrlPrefix">The Live endpoint url prefix.</param>
        /// <param name="url">The base URL of the API.</param>
        /// <returns>String containing the LIVE URL.</returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static string ConstructLiveUrl(string liveEndpointUrlPrefix, string url)
        {
            return ConstructLiveUrl(liveEndpointUrlPrefix, url, AdyenRegion.EU);
        }

        /// <summary>
        /// Constructs a live URL, applying the region only to APIs with regional hosts.
        /// </summary>
        /// <param name="liveEndpointUrlPrefix">The live endpoint URL prefix.</param>
        /// <param name="url">The base URL of the API.</param>
        /// <param name="region">The target region for regional APIs.</param>
        /// <returns>The live URL.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The regional API does not support the region.</exception>
        public static string ConstructLiveUrl(string liveEndpointUrlPrefix, string url, AdyenRegion region)
        {
            // Change base url for Live environment
            if (url.Contains("pal-")) // Payment API prefix
            {
                if (liveEndpointUrlPrefix == null)
                {
                    throw new InvalidOperationException("LiveEndpointUrlPrefix is null - please configure your AdyenOptions.LiveEndpointUrlPrefix");
                }

                url = url.Replace("https://pal-test.adyen.com/pal/servlet/",
                    "https://" + liveEndpointUrlPrefix + "-pal-live.adyenpayments.com/pal/servlet/");
            }
            else if (url.Contains("checkout-")) // Checkout API prefix
            {
                if (liveEndpointUrlPrefix == null)
                {
                    throw new InvalidOperationException("LiveEndpointUrlPrefix is null - please configure your AdyenOptions.LiveEndpointUrlPrefix");
                }

                if (url.Contains("possdk"))
                {
                    url = url.Replace("https://checkout-test.adyen.com/",
                        "https://" + liveEndpointUrlPrefix + "-checkout-live.adyenpayments.com/");
                }
                else
                {
                    url = url.Replace("https://checkout-test.adyen.com/",
                        "https://" + liveEndpointUrlPrefix + "-checkout-live.adyenpayments.com/checkout/");
                }
            }
            else if (url.Contains("https://test.adyen.com/authe/api/")) // SessionAuthentication
            {
                url = url.Replace("https://test.adyen.com/authe/api/",
                    "https://authe-live.adyen.com/authe/api/");
            }

            return ConstructRegionalLiveUrl(url, region);
        }

        private static string ConstructRegionalLiveUrl(string url, AdyenRegion region)
        {
            if (Uri.TryCreate(url, UriKind.Absolute, out var uri) && uri.Scheme == Uri.UriSchemeHttps)
            {
                foreach (var apiHostName in RegionalApiHostNames)
                {
                    if (!string.Equals(uri.Host, $"{apiHostName}-test.adyen.com", StringComparison.OrdinalIgnoreCase))
                        continue;

                    if (!RegionalLiveUrlTemplates.TryGetValue(region, out var template))
                        throw new ArgumentOutOfRangeException(nameof(region), region, $"Currently not supported: {region}");

                    var liveHost = new Uri(string.Format(template, apiHostName)).Host;
                    return new UriBuilder(uri) { Host = liveHost }.Uri.AbsoluteUri;
                }
            }

            // If no prefix is required, we replace "test" -> "live"
            url = url.Replace("-test", "-live");
            return url;
        }
    }
}