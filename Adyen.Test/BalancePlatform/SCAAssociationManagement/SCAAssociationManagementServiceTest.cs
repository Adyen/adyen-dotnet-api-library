using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;
using System.Net;
using Adyen.Core.Client;
using NSubstitute;

namespace Adyen.Test.BalancePlatform.SCAAssociationManagement
{
    [TestClass]
    public class SCAAssociationManagementServiceTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;
        private readonly ISCAAssociationManagementService _scaAssociationManagementService;

        public SCAAssociationManagementServiceTest()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.AdyenApiKey = context.Configuration["ADYEN_API_KEY"];
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();

            _jsonSerializerOptionsProvider = host.Services.GetRequiredService<JsonSerializerOptionsProvider>();
            _scaAssociationManagementService = Substitute.For<ISCAAssociationManagementService>();
        }

        [TestMethod]
        public async Task Given_ApproveAssociationRequestWithWWWAuthenticate_SendsCorrectRequest()
        {
            // Arrange
            string requestJson =
                TestUtilities.GetTestFileContent("mocks/balanceplatform/ApproveAssociationRequest.json");
            var approveAssociationRequest =
                JsonSerializer.Deserialize<ApproveAssociationRequest>(requestJson,
                    _jsonSerializerOptionsProvider.Options);

            var httpResponseMessage = new HttpResponseMessage(HttpStatusCode.Unauthorized);
            httpResponseMessage.Headers.Add("sdkInput", "dummy_sdk_input_string");
            var mockApiResponse = new SCAAssociationManagementService.ApproveAssociationApiResponse(
                Substitute.For<Microsoft.Extensions.Logging.ILogger<SCAAssociationManagementService.ApproveAssociationApiResponse>>(),
                new HttpRequestMessage(),
                httpResponseMessage,
                "{}", // A 401 would typically return an error object, but for this test, we are just focusing on the header.
                "/scaAssociations",
                DateTime.UtcNow,
                _jsonSerializerOptionsProvider.Options
            );
            
            var requestOptions = new RequestOptions();
            requestOptions.AddWWWAuthenticateHeader("TestAuthValue");

            _scaAssociationManagementService.ApproveAssociationAsync(
                    Arg.Is<ApproveAssociationRequest>(req => 
                        req.EntityId == approveAssociationRequest.EntityId &&
                        req.EntityType == approveAssociationRequest.EntityType &&
                        req.ScaDeviceIds.SequenceEqual(approveAssociationRequest.ScaDeviceIds)
                    ),
                    Arg.Is<RequestOptions>(opt => 
                        opt.Headers.ContainsKey("WWW-Authenticate") &&
                        opt.Headers["WWW-Authenticate"] == "TestAuthValue"
                    ),
                    Arg.Any<CancellationToken>()
                )
                .Returns(Task.FromResult<IApproveAssociationApiResponse>(mockApiResponse));

            // Act
            var response = await _scaAssociationManagementService.ApproveAssociationAsync(approveAssociationRequest, requestOptions);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsUnauthorized);
            Assert.AreEqual(HttpStatusCode.Unauthorized, response.StatusCode);  // 401
            Assert.IsTrue(response.Headers.Contains("sdkInput"));
            Assert.AreEqual("dummy_sdk_input_string", response.Headers.GetValues("sdkInput").Single());
            Assert.IsNotNull(response.Unauthorized()); // Assert that the Unauthorized method returns a deserialized error object

            // Verify that the mocked method was called with the correct arguments
            await _scaAssociationManagementService.Received(1).ApproveAssociationAsync(
                Arg.Is<ApproveAssociationRequest>(req => 
                    req.EntityId == approveAssociationRequest.EntityId &&
                    req.EntityType == approveAssociationRequest.EntityType &&
                    req.ScaDeviceIds.SequenceEqual(approveAssociationRequest.ScaDeviceIds)
                ),
                Arg.Is<RequestOptions>(opt => 
                    opt.Headers.ContainsKey("WWW-Authenticate") &&
                    opt.Headers["WWW-Authenticate"] == "TestAuthValue"
                ),
                Arg.Any<CancellationToken>()
            );
        }
    }
}