using System.Net;
using System.Text;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.ManageSCADevices
{
    [TestClass]
    public class ManageSCADevicesServiceTest
    {
        public ManageSCADevicesServiceTest() { }

        [TestMethod]
        public async Task InitiateRegistrationOfScaDeviceAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/RegisterSCAResponse.json");

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
                    services.AddManageSCADevicesService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var manageSCADevicesService = testHost.Services.GetRequiredService<IManageSCADevicesService>();
            var request = new RegisterSCARequest
            {
                PaymentInstrumentId = "PI3227C223222B5BPCMFXD2XG",
                StrongCustomerAuthentication = new DelegatedAuthenticationData { SdkOutput = "UNIQUE_SDK_OUTPUT_DATA" }
            };

            // Act
            IInitiateRegistrationOfScaDeviceApiResponse response =
                await manageSCADevicesService.InitiateRegistrationOfScaDeviceAsync(request);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            RegisterSCAResponse? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual("UNIQUE_SCA_DEVICE_ID", result.Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/registeredDevices", capturedRequest.RequestUri?.AbsolutePath);
        }

        [TestMethod]
        public async Task ListRegisteredScaDevicesAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/SearchRegisteredDevicesResponse.json");

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
                    services.AddManageSCADevicesService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var manageSCADevicesService = testHost.Services.GetRequiredService<IManageSCADevicesService>();

            // Act
            IListRegisteredScaDevicesApiResponse response =
                await manageSCADevicesService.ListRegisteredScaDevicesAsync("PI3227C223222B5BPCMFXD2XG");

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            SearchRegisteredDevicesResponse? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ItemsTotal);
            Assert.IsNotNull(result.Data);
            Assert.AreEqual(1, result.Data.Count);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/registeredDevices", capturedRequest.RequestUri?.AbsolutePath);
        }

        [TestMethod]
        public async Task DeleteRegistrationOfScaDeviceAsync_Returns204NoContent_WithCorrectVerbAndPath()
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
                    services.AddManageSCADevicesService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var manageSCADevicesService = testHost.Services.GetRequiredService<IManageSCADevicesService>();

            // Act
            IDeleteRegistrationOfScaDeviceApiResponse response =
                await manageSCADevicesService.DeleteRegistrationOfScaDeviceAsync("BSDR42XV3223223S5N6CDQDGH53M8H", "PI3227C223222B5BPCMFXD2XG");

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsNoContent);
            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Delete, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/registeredDevices/BSDR42XV3223223S5N6CDQDGH53M8H", capturedRequest.RequestUri?.AbsolutePath);
        }
    }
}
