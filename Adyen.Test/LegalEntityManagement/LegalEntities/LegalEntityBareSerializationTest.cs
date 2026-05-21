using System.Text.Json;
using Adyen.LegalEntityManagement.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.LegalEntityManagement.LegalEntities
{
    /// <summary>
    /// Verifies that LegalEntityManagement models can be deserialized using a bare
    /// <see cref="JsonSerializer.Deserialize{T}(string)"/> call without supplying any
    /// <see cref="JsonSerializerOptions"/>. Enum types carry class-level <c>[JsonConverter]</c>
    /// attributes that STJ discovers automatically; plain model properties are resolved via
    /// <c>[JsonPropertyName]</c> attributes through STJ's default reflection path.
    ///
    /// </summary>
    [TestClass]
    public class LegalEntityBareSerializationTest
    {
        [TestMethod]
        public void Given_LegalEntityJson_When_BareDeserialize_Then_Returns_CorrectRequiredFields()
        {
            string json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/LegalEntity.json");

            var result = JsonSerializer.Deserialize<LegalEntity>(json);

            Assert.IsNotNull(result);
            Assert.AreEqual("LE322JV223222D5GG42KN6869", result.Id);
            Assert.AreEqual(LegalEntity.TypeEnum.Individual, result.Type);
        }

        [TestMethod]
        public void Given_LegalEntityJson_When_BareDeserialize_Then_Returns_CorrectOptionalFields()
        {
            string json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/LegalEntity.json");

            var result = JsonSerializer.Deserialize<LegalEntity>(json);

            Assert.IsNotNull(result);
            Assert.AreEqual("YOUR_REFERENCE", result.Reference);
        }

        [TestMethod]
        public void Given_LegalEntityJson_When_BareDeserialize_Then_Returns_CorrectIndividualFields()
        {
            string json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/LegalEntity.json");

            var result = JsonSerializer.Deserialize<LegalEntity>(json);

            Assert.IsNotNull(result?.Individual);
            Assert.AreEqual("s.hopper@example.com", result.Individual.Email);
            Assert.IsNotNull(result.Individual.Name);
            Assert.AreEqual("Simone", result.Individual.Name.FirstName);
            Assert.AreEqual("Hopper", result.Individual.Name.LastName);
            Assert.IsNotNull(result.Individual.Phone);
            Assert.AreEqual("+31858888138", result.Individual.Phone.Number);
            Assert.AreEqual("NL", result.Individual.Phone.PhoneCountryCode);
        }

        [TestMethod]
        public void Given_LegalEntityJson_When_BareDeserialize_Then_Returns_CorrectTransferInstruments()
        {
            string json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/LegalEntity.json");

            var result = JsonSerializer.Deserialize<LegalEntity>(json);

            Assert.IsNotNull(result?.TransferInstruments);
            Assert.AreEqual(1, result.TransferInstruments.Count);
            Assert.AreEqual("SE322KH223222F5GXZFNM3BGP", result.TransferInstruments[0].Id);
            Assert.AreEqual("NL**ABNA******0123", result.TransferInstruments[0].AccountIdentifier);
            Assert.AreEqual(false, result.TransferInstruments[0].TrustedSource);
        }

        [TestMethod]
        public void Given_LegalEntityJson_When_BareDeserialize_Then_Returns_CorrectCapabilities()
        {
            string json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/LegalEntity.json");

            var result = JsonSerializer.Deserialize<LegalEntity>(json);

            Assert.IsNotNull(result?.Capabilities);
            Assert.AreEqual(5, result.Capabilities.Count);
            var capability = result.Capabilities["sendToTransferInstrument"];
            Assert.AreEqual(false, capability.Allowed);
            Assert.AreEqual(true, capability.Requested);
            Assert.AreEqual("pending", capability.VerificationStatus);
            Assert.AreEqual(LegalEntityCapability.AllowedLevelEnum.Medium, capability.AllowedLevel);
            Assert.AreEqual(LegalEntityCapability.RequestedLevelEnum.High, capability.RequestedLevel);
            Assert.IsNotNull(capability.TransferInstruments);
            Assert.AreEqual(1, capability.TransferInstruments.Count);
            Assert.AreEqual(false, capability.TransferInstruments[0].Allowed);
            Assert.AreEqual("SE322KH223222F5GXZFNM3BGP", capability.TransferInstruments[0].Id);
        }

        [TestMethod]
        public void Given_LegalEntityJson_When_BareDeserialize_Then_Returns_CorrectVerificationDeadlines()
        {
            string json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/LegalEntity.json");

            var result = JsonSerializer.Deserialize<LegalEntity>(json);

            Assert.IsNotNull(result?.VerificationDeadlines);
            Assert.AreEqual(1, result.VerificationDeadlines.Count);
            Assert.IsNotNull(result.VerificationDeadlines[0].EntityIds);
            Assert.AreEqual("LE322JV223222D5GG42KN6869", result.VerificationDeadlines[0].EntityIds[0]);
        }

        [TestMethod]
        public void Given_LegalEntityObject_When_BareSerialize_Then_RoundTrip_Returns_OriginalValues()
        {
            string json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/LegalEntity.json");
            var original = JsonSerializer.Deserialize<LegalEntity>(json);
            Assert.IsNotNull(original);

            string serialized = JsonSerializer.Serialize(original);
            var roundTripped = JsonSerializer.Deserialize<LegalEntity>(serialized);

            Assert.IsNotNull(roundTripped);
            Assert.AreEqual(original.Id, roundTripped.Id);
            Assert.AreEqual(original.Type, roundTripped.Type);
            Assert.AreEqual(original.Reference, roundTripped.Reference);
            Assert.AreEqual(original.TransferInstruments[0].TrustedSource, roundTripped.TransferInstruments[0].TrustedSource);
            Assert.AreEqual(original.Capabilities["sendToTransferInstrument"].Allowed, roundTripped.Capabilities["sendToTransferInstrument"].Allowed);
            Assert.AreEqual(original.VerificationDeadlines[0].EntityIds[0], roundTripped.VerificationDeadlines[0].EntityIds[0]);
        }

        [TestMethod]
        public void Given_BusinessLinesJson_When_BareDeserialize_Then_Returns_CorrectCount()
        {
            string json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/LegalEntityBusinessLines.json");

            var result = JsonSerializer.Deserialize<Adyen.LegalEntityManagement.Models.BusinessLines>(json);

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.VarBusinessLines.Count);
        }
    }
}
