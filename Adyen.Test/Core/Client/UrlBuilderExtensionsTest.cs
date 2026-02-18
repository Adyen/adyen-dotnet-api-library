using Adyen.Core.Client;
using Adyen.Core.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Core.Client
{
    [TestClass]
    public class UrlBuilderExtensionsTest
    {
        #region Checkout && POS-SDK
        [TestMethod]
        public async Task Given_ConstructHostUrl_When_Environment_Is_Live_Then_CheckoutUrl_Contains_Prefix_And_Live_String()
        {
            // Arrange
            AdyenOptions adyenOptions = new AdyenOptions()
            {
                Environment = AdyenEnvironment.Live,
                LiveEndpointUrlPrefix = "prefix",
            };

            // Act
            string target = UrlBuilderExtensions.ConstructHostUrl(adyenOptions, "https://checkout-test.adyen.com/v71");
    
            // Assert
            Assert.AreEqual("https://prefix-checkout-live.adyenpayments.com/checkout/v71", target);
        }
        
        [TestMethod]
        public async Task Given_ConstructHostUrl_When_Environment_Is_Live_And_No_Prefix_For_Checkout_Throws_InvalidOperationException()
        {
            // Arrange
            AdyenOptions adyenOptions = new AdyenOptions()
            {
                Environment = AdyenEnvironment.Live,
                LiveEndpointUrlPrefix = null
            };

            // Act
            // Assert
            Assert.Throws<InvalidOperationException>(() => UrlBuilderExtensions.ConstructHostUrl(adyenOptions, "https://checkout-test.adyen.com/v71"));
        }
        
        #endregion
        
        [TestMethod]
        public async Task Given_ConstructHostUrl_When_Environment_Is_Live_Then_Checkout_POS_SDK_Contains_Prefix_And_Live_String_Without_Checkout()
        {
            // Arrange
            AdyenOptions adyenOptions = new AdyenOptions()
            {
                Environment = AdyenEnvironment.Live,
                LiveEndpointUrlPrefix = "prefix",
            };

            // Act
            string target = UrlBuilderExtensions.ConstructHostUrl(adyenOptions, "https://checkout-test.adyen.com/checkout/possdk/v68");
    
            // Assert
            Assert.AreEqual("https://prefix-checkout-live.adyenpayments.com/checkout/possdk/v68", target);
        }
        
        
        #region Pal
        [TestMethod]
        public async Task Given_ConstructHostUrl_When_Environment_Is_Live_Then_PalUrl_Contains_Prefix_And_Live_String()
        {
            // Arrange
            AdyenOptions adyenOptions = new AdyenOptions()
            {
                Environment = AdyenEnvironment.Live,
                LiveEndpointUrlPrefix = "prefix",
            };

            // Act
            string target = UrlBuilderExtensions.ConstructHostUrl(adyenOptions, "https://pal-test.adyen.com/pal/servlet/Payment/v68");
    
            // Assert
            Assert.AreEqual("https://prefix-pal-live.adyenpayments.com/pal/servlet/Payment/v68", target);
        }
        
        [TestMethod]
        public async Task Given_ConstructHostUrl_When_Environment_Is_Live_And_No_Prefix_For_Pal_Throws_InvalidOperationException()
        {
            // Arrange
            AdyenOptions adyenOptions = new AdyenOptions()
            {
                Environment = AdyenEnvironment.Live,
                LiveEndpointUrlPrefix = null
            };

            // Act
            // Assert
            Assert.Throws<InvalidOperationException>(() => UrlBuilderExtensions.ConstructHostUrl(adyenOptions, "https://pal-test.adyen.com/pal/servlet/Payment/v68"));
        }
        
        #endregion
        
        #region Paltokenization
        [TestMethod]
        public async Task Given_ConstructHostUrl_When_Environment_Is_Live_Then_PalTokenizationUrl_Contains_Prefix_And_Live_String()
        {
            // Arrange
            AdyenOptions adyenOptions = new AdyenOptions()
            {
                Environment = AdyenEnvironment.Live,
                LiveEndpointUrlPrefix = "prefix",
            };

            // Act
            string target = UrlBuilderExtensions.ConstructHostUrl(adyenOptions, "https://paltokenization-test.adyen.com/paltokenization/servlet/Payment/v68");
    
            // Assert
            Assert.AreEqual("https://prefix-paltokenization-live.adyenpayments.com/paltokenization/servlet/Payment/v68", target);
        }
        
        [TestMethod]
        public async Task Given_ConstructHostUrl_When_Environment_Is_Live_And_No_Prefix_For_PalTokenization_Throws_InvalidOperationException()
        {
            // Arrange
            AdyenOptions adyenOptions = new AdyenOptions()
            {
                Environment = AdyenEnvironment.Live,
                LiveEndpointUrlPrefix = null
            };

            // Act
            // Assert
            Assert.Throws<InvalidOperationException>(() => UrlBuilderExtensions.ConstructHostUrl(adyenOptions, "https://paltokenization-test.adyen.com/paltokenization/servlet/Payment/v68"));
        }
        
        #endregion
        
        #region SessionAuthentication
        [TestMethod]
        public async Task Given_ConstructHostUrl_When_Environment_Is_Live_Then_SessionAuthentication_Url_Contains_Prefix_And_Live_String()
        {
            // Arrange
            AdyenOptions adyenOptions = new AdyenOptions()
            {
                Environment = AdyenEnvironment.Live,
                LiveEndpointUrlPrefix = "prefix",
            };

            // Act
            string target = UrlBuilderExtensions.ConstructHostUrl(adyenOptions, "https://test.adyen.com/authe/api/v1");
    
            // Assert
            Assert.AreEqual("https://authe-live.adyen.com/authe/api/v1", target);
        }

        #endregion
        
        [TestMethod]
        public async Task Given_ConstructHostUrl_When_Environment_Is_Test_And_Prefix_Given_Then_Url_Does_Not_Contain_Prefix()
        {
            // Arrange
            AdyenOptions adyenOptions = new AdyenOptions()
            {
                Environment = AdyenEnvironment.Test,
                LiveEndpointUrlPrefix = "prefix",
            };

            // Act
            string target = UrlBuilderExtensions.ConstructHostUrl(adyenOptions, "https://test.adyen.com");

            // Assert
            Assert.IsFalse(target.Contains("prefix"));
        }
        
        [TestMethod]
        public async Task Given_ConstructHostUrl_When_Environment_Is_Live_And_No_Prefix_Does_Not_Throw_InvalidOperationException_And_Contains_String_Value_Test()
        {
            // Arrange
            AdyenOptions adyenOptions = new AdyenOptions()
            {
                Environment = AdyenEnvironment.Live,
                LiveEndpointUrlPrefix = null
            };

            // Act
            string target = UrlBuilderExtensions.ConstructHostUrl(adyenOptions, "https://test.adyen.com/");
            
            // Assert
            Assert.IsTrue(target.Contains("test"));
        }
        
    }
}