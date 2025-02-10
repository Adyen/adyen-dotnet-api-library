using System.Collections.Generic;

namespace Adyen.Constants
{
    /// <summary>
    /// Enum to set region-based URLs for the Terminal API.
    /// For all possible values refer to: https://docs.adyen.com/point-of-sale/design-your-integration/terminal-api/#live-endpoints
    /// </summary>
    public enum Region
    {
        /// <summary>
        /// European Union region.
        /// </summary>
        EU = 0,

        /// <summary>
        /// Australia region.
        /// </summary>
        AU = 1,

        /// <summary>
        /// United States region.
        /// </summary>
        US = 2,

        /// <summary>
        /// Asia-Pacific, South East region.
        /// </summary>
        APSE = 3,

        /// <summary>
        /// India region.
        /// </summary>
        IN = 4
    }

    /// <summary>
    /// A static class that provides mapping of regions to their respective Terminal API endpoints.
    /// </summary>
    public static class RegionMapping
    {
        /// <summary>
        /// Maps regions to their respective Terminal API live endpoints.
        /// </summary>
        public static readonly Dictionary<Region, string> TERMINAL_API_ENDPOINTS_MAPPING = new Dictionary<Region, string>()
        {
            { Region.EU, "https://terminal-api-live.adyen.com" },
            { Region.AU, "https://terminal-api-live-au.adyen.com" },
            { Region.US, "https://terminal-api-live-us.adyen.com" },
            { Region.APSE, "https://terminal-api-live-apse.adyen.com" }
        };
    }
}
