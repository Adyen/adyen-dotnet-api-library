using System.Net;
using System.Text;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.SCADeviceManagement
{
    [TestClass]
    public class SCADeviceManagementServiceTest
    {
        public SCADeviceManagementServiceTest() { }

        [TestMethod]
        public async Task BeginScaDeviceRegistrationAsync_Returns201Created_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/BeginScaDeviceRegistrationResponse.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.Created)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddSCADeviceManagementService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var scaDeviceManagementService = testHost.Services.GetRequiredService<ISCADeviceManagementService>();
            var request = new BeginScaDeviceRegistrationRequest
            {
                Name = "My Device",
                SdkOutput = "UNIQUE_SDK_OUTPUT_DATA"
            };

            // Act
            IBeginScaDeviceRegistrationApiResponse response =
                await scaDeviceManagementService.BeginScaDeviceRegistrationAsync(request);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsCreated);
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
            BeginScaDeviceRegistrationResponse? result = response.Created();
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.ScaDevice);
            Assert.AreEqual("BSDR42XV3223223S5N6CDQDGH53M8H", result.ScaDevice.Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/scaDevices", capturedRequest.RequestUri?.AbsolutePath);
        }

        [TestMethod]
        public async Task FinishScaDeviceRegistrationAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/FinishScaDeviceRegistrationResponse.json");

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
                    services.AddSCADeviceManagementService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var scaDeviceManagementService = testHost.Services.GetRequiredService<ISCADeviceManagementService>();
            var request = new FinishScaDeviceRegistrationRequest { SdkOutput = "UNIQUE_SDK_OUTPUT_DATA" };

            // Act
            IFinishScaDeviceRegistrationApiResponse response =
                await scaDeviceManagementService.FinishScaDeviceRegistrationAsync("BSDR42XV3223223S5N6CDQDGH53M8H", request);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            FinishScaDeviceRegistrationResponse? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.ScaDevice);
            Assert.AreEqual("BSDR42XV3223223S5N6CDQDGH53M8H", result.ScaDevice.Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Patch, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/scaDevices/BSDR42XV3223223S5N6CDQDGH53M8H", capturedRequest.RequestUri?.AbsolutePath);
        }

        [TestMethod]
        public async Task SubmitScaAssociationAsync_Returns201Created_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/SubmitScaAssociationResponse.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.Created)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddSCADeviceManagementService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var scaDeviceManagementService = testHost.Services.GetRequiredService<ISCADeviceManagementService>();
            var request = new SubmitScaAssociationRequest
            {
                Entities = new List<ScaEntity>
                {
                    new ScaEntity { Type = ScaEntityType.AccountHolder, Id = "AH00000000000000000000001" }
                }
            };

            // Act
            ISubmitScaAssociationApiResponse response =
                await scaDeviceManagementService.SubmitScaAssociationAsync("BSDR11111111111A1AAA1AAAAA1AA1", request);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsCreated);
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
            SubmitScaAssociationResponse? result = response.Created();
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ScaAssociations.Count);
            Assert.AreEqual("BSDR11111111111A1AAA1AAAAA1AA1", result.ScaAssociations[0].ScaDeviceId);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/scaDevices/BSDR11111111111A1AAA1AAAAA1AA1/scaAssociations", capturedRequest.RequestUri?.AbsolutePath);
        }
    }
}
