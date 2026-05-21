using System.Text.Json;
using Adyen.Core.Options;
using Adyen.SessionAuthentication.Client;
using Adyen.SessionAuthentication.Extensions;
using Adyen.SessionAuthentication.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.SessionAuthentication
{
    [TestClass]
    public class SessionAuthenticationTest
    {
        private static IHost _host;
        private static JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            _host = Host.CreateDefaultBuilder()
                .ConfigureSessionAuthentication((ctx, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();

            _jsonSerializerOptionsProvider = _host.Services.GetRequiredService<JsonSerializerOptionsProvider>();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _host?.Dispose();
        }

        [TestMethod]
        public void Given_AuthenticationSessionResponse_When_Deserialize_Then_Returns_CorrectFields()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/sessionauthentication/create-session-response.json");

            // Act
            var result = JsonSerializer.Deserialize<AuthenticationSessionResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("11a1e60a-18b0-4dda-9258-e0ae29e1e2a3", result.Id);
            Assert.AreEqual("eyJraWQiOiJwbGF0Zm9ybWNvbGRlciI...", result.Token);
        }

        [TestMethod]
        public void Given_AuthenticationSessionRequest_When_Serialize_Then_Returns_CorrectJson()
        {
            // Arrange
            var request = new AuthenticationSessionRequest
            {
                AllowOrigin = "https://www.your-website.com",
                Product = ProductType.Onboarding,
                Policy = new Policy
                {
                    Resources = new HashSet<Resource> { new LegalEntityResource { LegalEntityId = "LE00000000000000000000001" } },
                    Roles = new HashSet<string> { "createTransferInstrumentComponent", "manageTransferInstrumentComponent" },
                },
            };

            // Act
            string result = JsonSerializer.Serialize(request, _jsonSerializerOptionsProvider.Options);

            // Assert
            using var json = JsonDocument.Parse(result);
            Assert.AreEqual("https://www.your-website.com", json.RootElement.GetProperty("allowOrigin").GetString());
            Assert.AreEqual("onboarding", json.RootElement.GetProperty("product").GetString());
            JsonElement policy = json.RootElement.GetProperty("policy");
            Assert.AreEqual("LegalEntityResource", policy.GetProperty("resources")[0].GetProperty("type").GetString());
            Assert.AreEqual("LE00000000000000000000001", policy.GetProperty("resources")[0].GetProperty("legalEntityId").GetString());
            Assert.AreEqual("createTransferInstrumentComponent", policy.GetProperty("roles")[0].GetString());
            Assert.AreEqual("manageTransferInstrumentComponent", policy.GetProperty("roles")[1].GetString());
        }

        [TestMethod]
        public void Given_AuthenticationSessionRequest_When_Deserialize_Then_Returns_CorrectFields()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/sessionauthentication/create-session-request.json");

            // Act
            var result = JsonSerializer.Deserialize<AuthenticationSessionRequest>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("https://www.your-website.com", result.AllowOrigin);
            Assert.AreEqual(ProductType.Onboarding, result.Product);
            Assert.IsNotNull(result.Policy);
            Assert.AreEqual(1, result.Policy.Resources.Count);
            Assert.IsInstanceOfType(result.Policy.Resources.First(), typeof(LegalEntityResource));
            Assert.AreEqual("LE00000000000000000000001", ((LegalEntityResource)result.Policy.Resources.First()).LegalEntityId);
            Assert.AreEqual(2, result.Policy.Roles.Count);
            Assert.IsTrue(result.Policy.Roles.Contains("createTransferInstrumentComponent"));
        }

        [TestMethod]
        public void Given_AuthenticationSessionResponse_When_RoundTrip_Then_Returns_OriginalValues()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/sessionauthentication/create-session-response.json");
            var original = JsonSerializer.Deserialize<AuthenticationSessionResponse>(json, _jsonSerializerOptionsProvider.Options);
            Assert.IsNotNull(original);

            // Act
            string serialized = JsonSerializer.Serialize(original, _jsonSerializerOptionsProvider.Options);
            var roundTripped = JsonSerializer.Deserialize<AuthenticationSessionResponse>(serialized, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(roundTripped);
            Assert.AreEqual(original.Id, roundTripped.Id);
            Assert.AreEqual(original.Token, roundTripped.Token);
        }
    }
}
