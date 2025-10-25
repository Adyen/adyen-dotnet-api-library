using Adyen.Checkout.Extensions;
using Adyen.BalancePlatform.Extensions;
using Adyen.Core.Auth;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Core.Auth
{
    [TestClass]
    public class ApiKeyTokenTest
    {
        [TestMethod]
        public async Task Given_Multiple_Api_Tokens_When_Injected_Then_Correct_TokenProvider_Is_Used_To_Provide_Correct_ApiKeyToken()
        {
            // Arrange
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.AdyenApiKey = "adyen-api-key";
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.AdyenApiKey = "balanceplatform-adyen-api-key";
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();
            
            // Act
            ITokenProvider<Adyen.BalancePlatform.Client.ApiKeyToken> balancePlatformApiKey = testHost.Services.GetRequiredService<ITokenProvider<Adyen.BalancePlatform.Client.ApiKeyToken>>();
            ITokenProvider<Adyen.Checkout.Client.ApiKeyToken> checkoutApiKey = testHost.Services.GetRequiredService<ITokenProvider<Adyen.Checkout.Client.ApiKeyToken>>();
            
            using var balancePlatformMessage = new HttpRequestMessage(HttpMethod.Get, "/dummy/endpoint");
            balancePlatformApiKey.Get().AddTokenToHttpRequestMessageHeader(balancePlatformMessage);
            
            using var checkoutMessage = new HttpRequestMessage(HttpMethod.Get, "/dummy/endpoint");
            checkoutApiKey.Get().AddTokenToHttpRequestMessageHeader(checkoutMessage);

            // Assert
            Assert.AreEqual(balancePlatformMessage.Headers.First().Value.First(), "balanceplatform-adyen-api-key");
            Assert.AreEqual(checkoutMessage.Headers.First().Value.First(), "adyen-api-key");
        }

    }
}