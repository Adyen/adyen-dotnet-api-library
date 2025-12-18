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
            List<string> validRegions = Enum.GetValues(typeof(Region))
                                .Cast<Region>()
                                .Select(r => r.ToString().ToLower())
                                .ToList();

            // Define the expected list of valid regions
            var expected = new List<string>
            {
                "eu",
                "au",
                "us",
                "apse",
                "in"
            };

            // Assert that the valid regions match the expected list
            CollectionAssert.AreEquivalent(expected, validRegions);
        }

        [TestMethod]
        public void TestTerminalApiEndpointsMapping()
        {
            // Convert TERMINAL_API_ENDPOINTS_MAPPING keys to lowercase strings for comparison
            Dictionary<Region, string> expected = RegionMapping.TERMINAL_API_ENDPOINTS_MAPPING
                                    .ToDictionary(
                                        entry => entry.Key,
                                        entry => entry.Value
                                    );

            // Define the expected map of region to endpoint mappings
            var actual = new Dictionary<Region, string>
            {
                { Region.EU, "https://terminal-api-live.adyen.com" },
                { Region.AU, "https://terminal-api-live-au.adyen.com" },
                { Region.US, "https://terminal-api-live-us.adyen.com" },
                { Region.APSE, "https://terminal-api-live-apse.adyen.com" },
            };

            // Assert that the TERMINAL_API_ENDPOINTS_MAPPING matches the expected map
            CollectionAssert.AreEquivalent(actual, expected);
        }
        
        [TestMethod]
        public void TestTerminalApiEndpointsMappingIndia()
        {
            // Convert TERMINAL_API_ENDPOINTS_MAPPING keys to lowercase strings for comparison
            Dictionary<Region, string> expected = RegionMapping.TERMINAL_API_ENDPOINTS_MAPPING
                .ToDictionary(
                    entry => entry.Key,
                    entry => entry.Value
                );
            
            if (expected.TryGetValue(Region.IN, out string actualUrl))
            {
                Assert.Fail();
            }
            
            // Assert that the India region endpoint maps to null.
            Assert.IsNull(actualUrl);
        }
    }
}
