using System;
using System.Collections.Generic;
using System.Linq;
using Adyen.Constants;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class RegionTest
    {
        [TestMethod]
        public void TestValidRegions()
        {
            // Get all valid regions from the Region enum
            var validRegions = Enum.GetValues(typeof(Region))
                                   .Cast<Region>()
                                   .Select(r => r.ToString().ToLower())
                                   .ToList();

            // Define the expected list of valid regions
            var expected = new List<string>
            {
                "eu",
                "au",
                "us",
                "in",
                "apse"
            };

            // Assert that the valid regions match the expected list
            CollectionAssert.AreEquivalent(expected, validRegions);
        }

        [TestMethod]
        public void TestTerminalApiEndpointsMapping()
        {
            // Convert TERMINAL_API_ENDPOINTS_MAPPING keys to lowercase strings for comparison
            var actual = RegionMapping.TERMINAL_API_ENDPOINTS_MAPPING
                                       .ToDictionary(
                                           entry => entry.Key.ToString().ToLower(),
                                           entry => entry.Value
                                       );

            // Define the expected map of region to endpoint mappings
            var expected = new Dictionary<string, string>
            {
                { "eu", "https://terminal-api-live.adyen.com" },
                { "au", "https://terminal-api-live-au.adyen.com" },
                { "us", "https://terminal-api-live-us.adyen.com" },
                { "apse", "https://terminal-api-live-apse.adyen.com" }
            };

            // Assert that the TERMINAL_API_ENDPOINTS_MAPPING matches the expected map
            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}
