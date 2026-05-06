using System.Net;
using System.Text;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.Balances
{
    [TestClass]
    public class BalancesServiceTest
    {
        public BalancesServiceTest() { }

        [TestMethod]
        public async Task GetAllWebhookSettingsAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/WebhookSettings.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddBalancesService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var balancesService = testHost.Services.GetRequiredService<IBalancesService>();

            // Act
            IGetAllWebhookSettingsApiResponse response = await balancesService.GetAllWebhookSettingsAsync(
                "YOUR_BALANCE_PLATFORM", "UNIQUE_WEBHOOK_ID");

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/balancePlatforms/YOUR_BALANCE_PLATFORM/webhooks/UNIQUE_WEBHOOK_ID/settings", capturedRequest.RequestUri?.AbsolutePath);
        }

        [TestMethod]
        public async Task GetWebhookSettingAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/WebhookSetting.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddBalancesService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var balancesService = testHost.Services.GetRequiredService<IBalancesService>();

            // Act
            IGetWebhookSettingApiResponse response = await balancesService.GetWebhookSettingAsync(
                "YOUR_BALANCE_PLATFORM", "UNIQUE_WEBHOOK_ID", "UNIQUE_WEBHOOK_SETTING_ID");

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/balancePlatforms/YOUR_BALANCE_PLATFORM/webhooks/UNIQUE_WEBHOOK_ID/settings/UNIQUE_WEBHOOK_SETTING_ID", capturedRequest.RequestUri?.AbsolutePath);
        }

        [TestMethod]
        public async Task CreateWebhookSettingAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/WebhookSetting.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddBalancesService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var balancesService = testHost.Services.GetRequiredService<IBalancesService>();
            var settingInfo = new BalanceWebhookSettingInfo { Currency = "EUR" };

            // Act
            ICreateWebhookSettingApiResponse response = await balancesService.CreateWebhookSettingAsync(
                "YOUR_BALANCE_PLATFORM", "UNIQUE_WEBHOOK_ID", settingInfo);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/balancePlatforms/YOUR_BALANCE_PLATFORM/webhooks/UNIQUE_WEBHOOK_ID/settings", capturedRequest.RequestUri?.AbsolutePath);
        }

        [TestMethod]
        public async Task DeleteWebhookSettingAsync_Returns204NoContent_WithCorrectVerbAndPath()
        {
            // Arrange
            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.NoContent);
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddBalancesService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var balancesService = testHost.Services.GetRequiredService<IBalancesService>();

            // Act
            IDeleteWebhookSettingApiResponse response = await balancesService.DeleteWebhookSettingAsync(
                "YOUR_BALANCE_PLATFORM", "UNIQUE_WEBHOOK_ID", "UNIQUE_WEBHOOK_SETTING_ID");

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsNoContent);
            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Delete, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/balancePlatforms/YOUR_BALANCE_PLATFORM/webhooks/UNIQUE_WEBHOOK_ID/settings/UNIQUE_WEBHOOK_SETTING_ID", capturedRequest.RequestUri?.AbsolutePath);
        }
    }
}
