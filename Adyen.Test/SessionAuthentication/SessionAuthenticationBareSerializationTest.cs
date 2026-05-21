using System.Text.Json;
using Adyen.SessionAuthentication.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.SessionAuthentication
{
    /// <summary>
    /// Verifies that SessionAuthentication models can be serialized and deserialized using bare
    /// <see cref="JsonSerializer"/> calls without supplying any <see cref="JsonSerializerOptions"/>.
    /// All SessionAuthentication models carry a class-level <c>[JsonConverter]</c> attribute that
    /// STJ discovers automatically, so behaviour is identical to the DI-based path tested in
    /// <see cref="SessionAuthenticationTest"/>.
    /// </summary>
    [TestClass]
    public class SessionAuthenticationBareSerializationTest
    {
        [TestMethod]
        public void Given_AuthenticationSessionResponse_When_BareDeserialize_Then_Returns_CorrectFields()
        {
            string json = TestUtilities.GetTestFileContent("mocks/sessionauthentication/create-session-response.json");

            var result = JsonSerializer.Deserialize<AuthenticationSessionResponse>(json);

            Assert.IsNotNull(result);
            Assert.AreEqual("11a1e60a-18b0-4dda-9258-e0ae29e1e2a3", result.Id);
            Assert.AreEqual("eyJraWQiOiJwbGF0Zm9ybWNvbGRlciI...", result.Token);
        }

        [TestMethod]
        public void Given_AuthenticationSessionRequest_When_BareDeserialize_Then_Returns_CorrectFields()
        {
            string json = TestUtilities.GetTestFileContent("mocks/sessionauthentication/create-session-request.json");

            var result = JsonSerializer.Deserialize<AuthenticationSessionRequest>(json);

            Assert.IsNotNull(result);
            Assert.AreEqual("https://www.your-website.com", result.AllowOrigin);
            Assert.AreEqual(ProductType.Onboarding, result.Product);
            Assert.IsNotNull(result.Policy);
            Assert.AreEqual(1, result.Policy.Resources.Count);
            Assert.IsInstanceOfType(result.Policy.Resources.First(), typeof(LegalEntityResource));
            Assert.AreEqual("LE00000000000000000000001", ((LegalEntityResource)result.Policy.Resources.First()).LegalEntityId);
            Assert.AreEqual(2, result.Policy.Roles.Count);
            Assert.IsTrue(result.Policy.Roles.Contains("createTransferInstrumentComponent"));
            Assert.IsTrue(result.Policy.Roles.Contains("manageTransferInstrumentComponent"));
        }

        [TestMethod]
        public void Given_AuthenticationSessionRequest_When_BareSerialize_Then_Returns_CorrectJson()
        {
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

            string result = JsonSerializer.Serialize(request);

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
        public void Given_AuthenticationSessionResponse_When_BareRoundTrip_Then_Returns_OriginalValues()
        {
            string json = TestUtilities.GetTestFileContent("mocks/sessionauthentication/create-session-response.json");
            var original = JsonSerializer.Deserialize<AuthenticationSessionResponse>(json);
            Assert.IsNotNull(original);

            string serialized = JsonSerializer.Serialize(original);
            var roundTripped = JsonSerializer.Deserialize<AuthenticationSessionResponse>(serialized);

            Assert.IsNotNull(roundTripped);
            Assert.AreEqual(original.Id, roundTripped.Id);
            Assert.AreEqual(original.Token, roundTripped.Token);
        }
    }
}
