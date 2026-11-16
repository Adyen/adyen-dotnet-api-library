using Adyen.Core.Client;
using Adyen.Core.Options;
using Region = Adyen.Core.Options.AdyenRegion;

namespace Adyen.Test.Core.Client
{
    [TestClass]
    public class RegionalUrlBuilderTest
    {
        [TestMethod]
        [DataRow(Region.EU, "")]
        [DataRow(Region.AU, "-au")]
        [DataRow(Region.US, "-us")]
        [DataRow(Region.APSE, "-apse")]
        [DataRow(Region.NEA, "-nea")]
        public void Given_RegionalApi_When_LiveRegionIsConfigured_Then_OnlyHostChanges(Region region, string suffix)
        {
            var options = new AdyenOptions { Environment = AdyenEnvironment.Live, Region = region };
            Assert.AreEqual(
                $"https://softposconfig-live{suffix}.adyen.com:8443/api/v3?key=value#section",
                UrlBuilderExtensions.ConstructHostUrl(options, "https://softposconfig-test.adyen.com:8443/api/v3?key=value#section"));
        }

        [TestMethod]
        public void Given_UnsetRegion_When_LiveUrlIsBuilt_Then_DefaultsToEu()
        {
            var options = new AdyenOptions { Environment = AdyenEnvironment.Live };
            Assert.AreEqual("https://softposconfig-live.adyen.com/v3",
                UrlBuilderExtensions.ConstructHostUrl(options, "https://softposconfig-test.adyen.com/v3"));
            Assert.AreEqual("https://softposconfig-live.adyen.com/v3",
                UrlBuilderExtensions.ConstructLiveUrl(null, "https://softposconfig-test.adyen.com/v3"));
        }

        [TestMethod]
        [DataRow((Region)(-1))]
        [DataRow((Region)999)]
        public void Given_UnsupportedRegion_When_RegionalLiveUrlIsBuilt_Then_Throws(Region region)
        {
            var options = new AdyenOptions { Environment = AdyenEnvironment.Live, Region = region };
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                UrlBuilderExtensions.ConstructHostUrl(options, "https://softposconfig-test.adyen.com/v3"));
        }

        [TestMethod]
        [DataRow("https://management-test.adyen.com/v3", "https://management-live.adyen.com/v3")]
        [DataRow("https://device-api-test.adyen.com/v1", "https://device-api-live.adyen.com/v1")]
        [DataRow("https://softposconfig-test.adyen.com.example.com/v3", "https://softposconfig-live.adyen.com.example.com/v3")]
        [DataRow("https://proxy-test.example.com/device-api/v1", "https://proxy-live.example.com/device-api/v1")]
        [DataRow("https://pal-test.adyen.com/pal/servlet/Payment/v68", "https://prefix-pal-live.adyenpayments.com/pal/servlet/Payment/v68")]
        [DataRow("https://checkout-test.adyen.com/v71", "https://prefix-checkout-live.adyenpayments.com/checkout/v71")]
        [DataRow("https://test.adyen.com/authe/api/v1", "https://authe-live.adyen.com/authe/api/v1")]
        public void Given_OtherApi_When_RegionIsConfigured_Then_PreservesExistingRouting(string url, string expected)
        {
            var options = new AdyenOptions { Environment = AdyenEnvironment.Live, Region = Region.NEA, LiveEndpointUrlPrefix = "prefix" };
            Assert.AreEqual(expected, UrlBuilderExtensions.ConstructHostUrl(options, url));
        }

        [TestMethod]
        [DataRow(Region.EU)]
        [DataRow(Region.AU)]
        [DataRow(Region.US)]
        [DataRow(Region.APSE)]
        [DataRow(Region.NEA)]
        [DataRow((Region)(-1))]
        [DataRow((Region)999)]
        public void Given_TestEnvironment_When_AnyRegionIsConfigured_Then_UsesSharedTestEndpoint(Region region)
        {
            var options = new AdyenOptions { Environment = AdyenEnvironment.Test, Region = region };
            foreach (var host in new[] { "device-api", "softposconfig" })
                Assert.AreEqual($"https://{host}-test.adyen.com/v3",
                    UrlBuilderExtensions.ConstructHostUrl(options, $"https://{host}-test.adyen.com/v3"));
        }
    }
}
