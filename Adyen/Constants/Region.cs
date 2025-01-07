namespace Adyen.Constants
{
    /// <summary>
    /// Enum to set region based urls for terminal api
    /// https://docs.adyen.com/point-of-sale/design-your-integration/terminal-api/
    /// </summary>
    public enum Region
    {
        //Europe
        EU = 0,

        //Australia
        AU = 1,

        //US
        US = 2,

        //East Asia
        APSE = 3
    }

    public static class RegionMapping
    {
        public static readonly Dictionary<Region, string> TERMINAL_API_ENDPOINTS_MAPPING = new()
        {
            { Region.EU, "https://terminal-api-live.adyen.com" },
            { Region.AU, "https://terminal-api-live-au.adyen.com" },
            { Region.US, "https://terminal-api-live-us.adyen.com" },
            { Region.APSE, "https://terminal-api-live-apse.adyen.com" }
        };
    }
}