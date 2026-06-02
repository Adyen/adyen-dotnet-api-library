using System.Text.Json;
using Adyen.SessionAuthentication.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.SessionAuthentication
{
    /// <summary>
    /// Regression tests for issue #1717: verifies that <see cref="ResourceJsonConverter"/>
    /// correctly matches the discriminator against API wire values (e.g. "legalEntity")
    /// rather than C# class names (e.g. "LegalEntityResource").
    /// </summary>
    [TestClass]
    public class ResourceDiscriminatorTest
    {
        // ── Deserialization ──────────────────────────────────────────────────────────

        [TestMethod]
        public void Given_LegalEntityResourceJson_When_DeserializeAsResource_Then_Returns_LegalEntityResource()
        {
            string json = "{\"type\":\"legalEntity\",\"legalEntityId\":\"LE00000000000000000000001\"}";

            var resource = JsonSerializer.Deserialize<Resource>(json);

            Assert.IsNotNull(resource);
            Assert.IsInstanceOfType(resource, typeof(LegalEntityResource),
                "Expected LegalEntityResource but got: " + resource.GetType().Name);
            Assert.AreEqual("LE00000000000000000000001", ((LegalEntityResource)resource).LegalEntityId);
        }

        [TestMethod]
        public void Given_AccountHolderResourceJson_When_DeserializeAsResource_Then_Returns_AccountHolderResource()
        {
            string json = "{\"type\":\"accountHolder\",\"accountHolderId\":\"AH00000000000000000000001\"}";

            var resource = JsonSerializer.Deserialize<Resource>(json);

            Assert.IsNotNull(resource);
            Assert.IsInstanceOfType(resource, typeof(AccountHolderResource),
                "Expected AccountHolderResource but got: " + resource.GetType().Name);
            Assert.AreEqual("AH00000000000000000000001", ((AccountHolderResource)resource).AccountHolderId);
        }

        [TestMethod]
        public void Given_PaymentInstrumentResourceJson_When_DeserializeAsResource_Then_Returns_PaymentInstrumentResource()
        {
            string json = "{\"type\":\"paymentInstrument\",\"paymentInstrumentId\":\"PI00000000000000000000001\"}";

            var resource = JsonSerializer.Deserialize<Resource>(json);

            Assert.IsNotNull(resource);
            Assert.IsInstanceOfType(resource, typeof(PaymentInstrumentResource),
                "Expected PaymentInstrumentResource but got: " + resource.GetType().Name);
            Assert.AreEqual("PI00000000000000000000001", ((PaymentInstrumentResource)resource).PaymentInstrumentId);
        }

        // ── Serialization ────────────────────────────────────────────────────────────

        [TestMethod]
        public void Given_LegalEntityResource_When_Serialize_Then_TypeIsApiWireValue()
        {
            var resource = new LegalEntityResource { LegalEntityId = "LE00000000000000000000001" };

            string json = JsonSerializer.Serialize<Resource>(resource);

            Assert.IsTrue(json.Contains("\"type\":\"legalEntity\""),
                "Expected wire value 'legalEntity' but got: " + json);
        }

        [TestMethod]
        public void Given_AccountHolderResource_When_Serialize_Then_TypeIsApiWireValue()
        {
            var resource = new AccountHolderResource { AccountHolderId = "AH00000000000000000000001" };

            string json = JsonSerializer.Serialize<Resource>(resource);

            Assert.IsTrue(json.Contains("\"type\":\"accountHolder\""),
                "Expected wire value 'accountHolder' but got: " + json);
        }

        [TestMethod]
        public void Given_PaymentInstrumentResource_When_Serialize_Then_TypeIsApiWireValue()
        {
            var resource = new PaymentInstrumentResource { PaymentInstrumentId = "PI00000000000000000000001" };

            string json = JsonSerializer.Serialize<Resource>(resource);

            Assert.IsTrue(json.Contains("\"type\":\"paymentInstrument\""),
                "Expected wire value 'paymentInstrument' but got: " + json);
        }

        // ── Full request round-trip (OpenAPI examples) ───────────────────────────────

        [TestMethod]
        public void Given_OnboardingExampleJson_When_Deserialize_Then_PolicyContainsLegalEntityResource()
        {
            string json = TestUtilities.GetTestFileContent(
                "mocks/sessionauthentication/create-session-onboarding.json");

            var request = JsonSerializer.Deserialize<AuthenticationSessionRequest>(json);

            Assert.IsNotNull(request);
            Assert.IsNotNull(request.Policy?.Resources);
            Assert.AreEqual(1, request.Policy.Resources.Count);
            var resource = System.Linq.Enumerable.First(request.Policy.Resources);
            Assert.IsInstanceOfType(resource, typeof(LegalEntityResource),
                "Expected LegalEntityResource but got: " + resource.GetType().Name);
            Assert.AreEqual("LE00000000000000000000001", ((LegalEntityResource)resource).LegalEntityId);
        }

        [TestMethod]
        public void Given_PlatformExampleJson_When_Deserialize_Then_PolicyContainsAccountHolderResource()
        {
            string json = TestUtilities.GetTestFileContent(
                "mocks/sessionauthentication/create-session-platform.json");

            var request = JsonSerializer.Deserialize<AuthenticationSessionRequest>(json);

            Assert.IsNotNull(request);
            Assert.IsNotNull(request.Policy?.Resources);
            Assert.AreEqual(1, request.Policy.Resources.Count);
            var resource = System.Linq.Enumerable.First(request.Policy.Resources);
            Assert.IsInstanceOfType(resource, typeof(AccountHolderResource),
                "Expected AccountHolderResource but got: " + resource.GetType().Name);
            Assert.AreEqual("AH00000000000000000000001", ((AccountHolderResource)resource).AccountHolderId);
        }
    }
}
