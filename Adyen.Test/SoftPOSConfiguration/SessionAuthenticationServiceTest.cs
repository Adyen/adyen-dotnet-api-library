using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using Adyen.Core.Options;
using Adyen.SoftPOSConfiguration.Client;
using Adyen.SoftPOSConfiguration.Extensions;
using Adyen.SoftPOSConfiguration.Models;
using Adyen.SoftPOSConfiguration.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Adyen.Test.SoftPOSConfiguration
{
    [TestClass]
    public class SessionAuthenticationServiceTest
    {
        private const string IssueCertificatesPath = "/softposconfig/v3/auth/certificate";

        private static IHost CreateHost(AdyenEnvironment environment, MockDelegatingHandler mockHandler = null, string apiKey = null)
        {
            return Host.CreateDefaultBuilder()
                .ConfigureSoftPOSConfiguration((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = environment;
                        options.AdyenApiKey = apiKey;
                    });
                    services.AddAllSoftPOSConfigurationServices(httpClientBuilderOptions: builder =>
                    {
                        if (mockHandler != null)
                            builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();
        }

        private static MockDelegatingHandler CreateMockHandler(HttpStatusCode statusCode, string json, Action<HttpRequestMessage, string> onRequest)
        {
            return new MockDelegatingHandler(request =>
            {
                string body = request.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
                onRequest(request, body);
                return new HttpResponseMessage(statusCode)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });
        }

        private static CertificateLoadingRequest CreateRequest()
        {
            return new CertificateLoadingRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                SetupToken = "SETUP_TOKEN",
                Store = "YOUR_STORE_REFERENCE"
            };
        }

        #region URL verification

        [TestMethod]
        public void Given_TestEnvironment_When_ServiceIsResolved_Then_BaseAddressIsSoftPosConfigTestUrl()
        {
            // Arrange
            IHost host = CreateHost(AdyenEnvironment.Test);

            // Act
            var service = host.Services.GetRequiredService<ISessionAuthenticationService>();

            // Assert
            Assert.AreEqual("https://softposconfig-test.adyen.com/softposconfig/v3", service.HttpClient.BaseAddress!.ToString());
        }

        [TestMethod]
        public void Given_LiveEnvironment_When_ServiceIsResolved_Then_BaseAddressIsSoftPosConfigLiveUrl()
        {
            // Arrange
            IHost host = CreateHost(AdyenEnvironment.Live);

            // Act
            var service = host.Services.GetRequiredService<ISessionAuthenticationService>();

            // Assert
            Assert.AreEqual("https://softposconfig-live.adyen.com/softposconfig/v3", service.HttpClient.BaseAddress!.ToString());
        }

        [TestMethod]
        public void Given_LiveEnvironmentWithPrefix_When_ServiceIsResolved_Then_PrefixIsIgnored()
        {
            // Arrange
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureSoftPOSConfiguration((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Live;
                        options.LiveEndpointUrlPrefix = "prefix";
                    });
                    services.AddAllSoftPOSConfigurationServices();
                })
                .Build();

            // Act
            var service = host.Services.GetRequiredService<ISessionAuthenticationService>();

            // Assert
            Assert.AreEqual("https://softposconfig-live.adyen.com/softposconfig/v3", service.HttpClient.BaseAddress!.ToString());
        }

        [TestMethod]
        public void Given_CustomBaseAddress_When_ServiceIsResolved_Then_CustomBaseAddressIsKept()
        {
            // Arrange
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureSoftPOSConfiguration((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Live; });
                    services.AddAllSoftPOSConfigurationServices(httpClientOptions: httpClient =>
                    {
                        httpClient.BaseAddress = new Uri("https://softposconfig-live-au.adyen.com/softposconfig/v3");
                    });
                })
                .Build();

            // Act
            var service = host.Services.GetRequiredService<ISessionAuthenticationService>();

            // Assert
            Assert.AreEqual("https://softposconfig-live-au.adyen.com/softposconfig/v3", service.HttpClient.BaseAddress!.ToString());
        }

        #endregion

        #region IssueCertificatesAsync

        [TestMethod]
        public async Task Given_ValidRequest_When_IssueCertificatesAsync_Then_Returns201CreatedWithCorrectVerbPathAndBody()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/softposconfiguration/issue-certificates.json");
            HttpRequestMessage capturedRequest = null;
            string capturedBody = null;
            var mockHandler = CreateMockHandler(HttpStatusCode.Created, json, (request, body) =>
            {
                capturedRequest = request;
                capturedBody = body;
            });
            IHost host = CreateHost(AdyenEnvironment.Test, mockHandler);
            var service = host.Services.GetRequiredService<ISessionAuthenticationService>();

            // Act
            var response = await service.IssueCertificatesAsync(CreateRequest());

            // Assert - response
            Assert.IsTrue(response.IsCreated);
            Assert.IsTrue(response.TryDeserializeCreatedResponse(out var result));
            Assert.AreEqual("APP_SESSION_ID", result.Id);
            Assert.AreEqual("INSTALLATION_ID", result.InstallationId);
            Assert.AreEqual("YOUR_MERCHANT_ACCOUNT", result.MerchantAccount);
            Assert.AreEqual("YOUR_STORE_REFERENCE", result.Store);
            Assert.AreEqual("SDK_DATA_BLOB", result.SdkData);

            // Assert - request
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.AreEqual("softposconfig-test.adyen.com", capturedRequest.RequestUri!.Host);
            Assert.AreEqual(IssueCertificatesPath, capturedRequest.RequestUri.AbsolutePath);
            Assert.AreEqual("application/json", capturedRequest.Content!.Headers.ContentType!.MediaType);

            using JsonDocument body = JsonDocument.Parse(capturedBody!);
            Assert.AreEqual("YOUR_MERCHANT_ACCOUNT", body.RootElement.GetProperty("merchantAccount").GetString());
            Assert.AreEqual("SETUP_TOKEN", body.RootElement.GetProperty("setupToken").GetString());
            Assert.AreEqual("YOUR_STORE_REFERENCE", body.RootElement.GetProperty("store").GetString());
            Assert.IsFalse(body.RootElement.TryGetProperty("subMerchantData", out _));
        }

        [TestMethod]
        public async Task Given_RequestWithAllSubMerchantDataFields_When_IssueCertificatesAsync_Then_AllFieldsAreSerialized()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/softposconfiguration/issue-certificates.json");
            string capturedBody = null;
            var mockHandler = CreateMockHandler(HttpStatusCode.Created, json, (request, body) => capturedBody = body);
            IHost host = CreateHost(AdyenEnvironment.Test, mockHandler);
            var service = host.Services.GetRequiredService<ISessionAuthenticationService>();

            CertificateLoadingRequest request = CreateRequest();
            request.SubMerchantData = new SubMerchantData
            {
                DisplayName = "Sub Merchant",
                Id = "SUB_MERCHANT_ID",
                Mcc = "5411",
                Name = "Sub Merchant Ltd",
                City = "Amsterdam",
                Country = "NL",
                Email = "info@submerchant.example",
                PhoneNumber = "+31201234567",
                PostalCode = "1011DJ",
                State = "NH",
                Street = "Simon Carmiggeltstraat 6",
                TaxId = "NL123456789B01"
            };

            // Act
            await service.IssueCertificatesAsync(request);

            // Assert
            using JsonDocument body = JsonDocument.Parse(capturedBody!);
            JsonElement subMerchantData = body.RootElement.GetProperty("subMerchantData");
            Assert.AreEqual("Sub Merchant", subMerchantData.GetProperty("displayName").GetString());
            Assert.AreEqual("SUB_MERCHANT_ID", subMerchantData.GetProperty("id").GetString());
            Assert.AreEqual("5411", subMerchantData.GetProperty("mcc").GetString());
            Assert.AreEqual("Sub Merchant Ltd", subMerchantData.GetProperty("name").GetString());
            Assert.AreEqual("Amsterdam", subMerchantData.GetProperty("city").GetString());
            Assert.AreEqual("NL", subMerchantData.GetProperty("country").GetString());
            Assert.AreEqual("info@submerchant.example", subMerchantData.GetProperty("email").GetString());
            Assert.AreEqual("+31201234567", subMerchantData.GetProperty("phoneNumber").GetString());
            Assert.AreEqual("1011DJ", subMerchantData.GetProperty("postalCode").GetString());
            Assert.AreEqual("NH", subMerchantData.GetProperty("state").GetString());
            Assert.AreEqual("Simon Carmiggeltstraat 6", subMerchantData.GetProperty("street").GetString());
            Assert.AreEqual("NL123456789B01", subMerchantData.GetProperty("taxId").GetString());
        }

        [TestMethod]
        public async Task Given_SubMerchantDataWithOnlyRequiredFields_When_IssueCertificatesAsync_Then_OptionalFieldsAreOmitted()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/softposconfiguration/issue-certificates.json");
            string capturedBody = null;
            var mockHandler = CreateMockHandler(HttpStatusCode.Created, json, (request, body) => capturedBody = body);
            IHost host = CreateHost(AdyenEnvironment.Test, mockHandler);
            var service = host.Services.GetRequiredService<ISessionAuthenticationService>();

            CertificateLoadingRequest request = CreateRequest();
            request.SubMerchantData = new SubMerchantData
            {
                DisplayName = "Sub Merchant",
                Id = "SUB_MERCHANT_ID",
                Mcc = "5411",
                Name = "Sub Merchant Ltd"
            };

            // Act
            await service.IssueCertificatesAsync(request);

            // Assert
            using JsonDocument body = JsonDocument.Parse(capturedBody!);
            JsonElement subMerchantData = body.RootElement.GetProperty("subMerchantData");
            CollectionAssert.AreEquivalent(
                new[] { "displayName", "id", "mcc", "name" },
                subMerchantData.EnumerateObject().Select(property => property.Name).ToArray());
        }

        [TestMethod]
        public async Task Given_ApiKey_When_IssueCertificatesAsync_Then_AddsXApiKeyHeader()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/softposconfiguration/issue-certificates.json");
            HttpRequestMessage capturedRequest = null;
            var mockHandler = CreateMockHandler(HttpStatusCode.Created, json, (request, body) => capturedRequest = request);
            IHost host = CreateHost(AdyenEnvironment.Test, mockHandler, apiKey: "test-api-key");
            var service = host.Services.GetRequiredService<ISessionAuthenticationService>();

            // Act
            await service.IssueCertificatesAsync(CreateRequest());

            // Assert
            Assert.IsNotNull(capturedRequest);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var values));
            Assert.AreEqual("test-api-key", values.First());
        }

        [TestMethod]
        public async Task Given_InvalidSetupToken_When_IssueCertificatesAsync_Then_Returns422WithInvalidFields()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/softposconfiguration/error-response-422.json");
            var mockHandler = CreateMockHandler((HttpStatusCode)422, json, (request, body) => { });
            IHost host = CreateHost(AdyenEnvironment.Test, mockHandler);
            var service = host.Services.GetRequiredService<ISessionAuthenticationService>();

            // Act
            var response = await service.IssueCertificatesAsync(CreateRequest());

            // Assert
            Assert.IsFalse(response.IsCreated);
            Assert.IsTrue(response.IsUnprocessableContent);
            Assert.IsTrue(response.TryDeserializeUnprocessableContentResponse(out var error));
            Assert.AreEqual(422, error.Status);
            Assert.AreEqual("Unprocessable entity", error.Title);
            Assert.AreEqual("00_422", error.ErrorCode);
            Assert.AreEqual("https://docs.adyen.com/errors/unprocessable-entity", error.Type);
            Assert.AreEqual("Session token or request fields are semantically invalid.", error.Detail);
            Assert.AreEqual("/softposconfig/v3/auth/certificate", error.Instance);
            Assert.AreEqual("REQUEST_ID", error.RequestId);
            Assert.AreEqual(1, error.InvalidFields!.Count);
            Assert.AreEqual("setupToken", error.InvalidFields[0].Name);
            Assert.AreEqual("SETUP_TOKEN", error.InvalidFields[0].Value);
            Assert.AreEqual("The setup token is invalid or expired.", error.InvalidFields[0].Message);
        }

        [TestMethod]
        [DataRow(400, "error-response-400.json", "Bad request", "00_400")]
        [DataRow(401, "error-response-401.json", "Unauthorized", "00_401")]
        [DataRow(500, "error-response-500.json", "Internal error", "00_500")]
        public async Task Given_ErrorStatus_When_IssueCertificatesAsync_Then_ErrorResponseIsDeserialized(int statusCode, string mockFile, string expectedTitle, string expectedErrorCode)
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/softposconfiguration/" + mockFile);
            var mockHandler = CreateMockHandler((HttpStatusCode)statusCode, json, (request, body) => { });
            IHost host = CreateHost(AdyenEnvironment.Test, mockHandler);
            var service = host.Services.GetRequiredService<ISessionAuthenticationService>();

            // Act
            var response = await service.IssueCertificatesAsync(CreateRequest());

            // Assert
            Assert.AreEqual(statusCode, (int)response.StatusCode);
            Assert.IsFalse(response.IsCreated);

            DefaultErrorResponseEntity error;
            bool deserialized;
            switch (statusCode)
            {
                case 400:
                    Assert.IsTrue(response.IsBadRequest);
                    deserialized = response.TryDeserializeBadRequestResponse(out error);
                    break;
                case 401:
                    Assert.IsTrue(response.IsUnauthorized);
                    deserialized = response.TryDeserializeUnauthorizedResponse(out error);
                    break;
                default:
                    Assert.IsTrue(response.IsInternalServerError);
                    deserialized = response.TryDeserializeInternalServerErrorResponse(out error);
                    break;
            }

            Assert.IsTrue(deserialized);
            Assert.AreEqual(statusCode, error!.Status);
            Assert.AreEqual(expectedTitle, error.Title);
            Assert.AreEqual(expectedErrorCode, error.ErrorCode);
        }

        #endregion

        #region Deserialization

        [TestMethod]
        public void Given_IssueCertificatesJson_When_Deserialized_Then_AllFieldsArePopulated()
        {
            // Arrange
            IHost host = CreateHost(AdyenEnvironment.Test);
            var jsonSerializerOptionsProvider = host.Services.GetRequiredService<JsonSerializerOptionsProvider>();
            string json = TestUtilities.GetTestFileContent("mocks/softposconfiguration/issue-certificates.json");

            // Act
            var response = JsonSerializer.Deserialize<CertificateLoadingResponse>(json, jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("APP_SESSION_ID", response.Id);
            Assert.AreEqual("INSTALLATION_ID", response.InstallationId);
            Assert.AreEqual("YOUR_MERCHANT_ACCOUNT", response.MerchantAccount);
            Assert.AreEqual("YOUR_STORE_REFERENCE", response.Store);
            Assert.AreEqual("SDK_DATA_BLOB", response.SdkData);
        }

        #endregion
    }
}
