using System.Text.Json;
using Adyen.Core.Options;
using Adyen.LegalEntityManagement.Client;
using Adyen.LegalEntityManagement.Extensions;
using Adyen.LegalEntityManagement.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.LegalEntityManagement.LegalEntities
{
    [TestClass]
    public class LegalEntityTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public LegalEntityTest()
        {
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureLegalEntityManagement((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();
            _jsonSerializerOptionsProvider = testHost.Services.GetRequiredService<JsonSerializerOptionsProvider>();
        }

        /// <summary>
        /// Test deserialization of required properties, optional properties, enum and readOnly fields
        /// </summary>
        [TestMethod]
        public void DeserializeLegalEntity()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/LegalEntity.json");

            // Act
            var result = JsonSerializer.Deserialize<LegalEntity>(json, _jsonSerializerOptionsProvider.Options);

            // Assert - required field
            Assert.IsNotNull(result);
            Assert.AreEqual("LE322JV223222D5GG42KN6869", result.Id);

            // Assert - required enum
            Assert.AreEqual(LegalEntity.TypeEnum.Individual, result.Type);

            // Assert - optional string
            Assert.AreEqual("YOUR_REFERENCE", result.Reference);

            // Assert - optional nested object (Individual with required sub-fields)
            Assert.IsNotNull(result.Individual);
            Assert.AreEqual("s.hopper@example.com", result.Individual.Email);
            Assert.IsNotNull(result.Individual.Name);
            Assert.AreEqual("Simone", result.Individual.Name.FirstName);
            Assert.AreEqual("Hopper", result.Individual.Name.LastName);

            // Assert - readOnly optional boolean (PhoneNumber.PhoneCountryCode)
            Assert.IsNotNull(result.Individual.Phone);
            Assert.AreEqual("+31858888138", result.Individual.Phone.Number);
            Assert.AreEqual("NL", result.Individual.Phone.PhoneCountryCode);

            // Assert - readOnly optional array (transferInstruments)
            Assert.IsNotNull(result.TransferInstruments);
            Assert.AreEqual(1, result.TransferInstruments.Count);
            Assert.AreEqual("SE322KH223222F5GXZFNM3BGP", result.TransferInstruments[0].Id);
            Assert.AreEqual("NL**ABNA******0123", result.TransferInstruments[0].AccountIdentifier);

            // Assert - readOnly optional boolean on nested object
            Assert.AreEqual(false, result.TransferInstruments[0].TrustedSource);

            // Assert - readOnly optional map of capabilities with readOnly sub-fields
            Assert.IsNotNull(result.Capabilities);
            Assert.AreEqual(5, result.Capabilities.Count);
            var capability = result.Capabilities["sendToTransferInstrument"];
            Assert.AreEqual(false, capability.Allowed);
            Assert.AreEqual(true, capability.Requested);
            Assert.AreEqual("pending", capability.VerificationStatus);

            // Assert - readOnly optional enum on capability
            Assert.AreEqual(LegalEntityCapability.AllowedLevelEnum.Medium, capability.AllowedLevel);
            Assert.AreEqual(LegalEntityCapability.RequestedLevelEnum.High, capability.RequestedLevel);

            // Assert - readOnly optional nested array on capability (SupportingEntityCapability)
            Assert.IsNotNull(capability.TransferInstruments);
            Assert.AreEqual(1, capability.TransferInstruments.Count);
            Assert.AreEqual(false, capability.TransferInstruments[0].Allowed);
            Assert.AreEqual("SE322KH223222F5GXZFNM3BGP", capability.TransferInstruments[0].Id);

            // Assert - readOnly optional array (verificationDeadlines) with readOnly sub-field (entityIds)
            Assert.IsNotNull(result.VerificationDeadlines);
            Assert.AreEqual(1, result.VerificationDeadlines.Count);
            Assert.IsNotNull(result.VerificationDeadlines[0].EntityIds);
            Assert.AreEqual("LE322JV223222D5GG42KN6869", result.VerificationDeadlines[0].EntityIds[0]);
        }

        /// <summary>
        /// Test serialization produces correct JSON including readOnly and optional fields
        /// </summary>
        [TestMethod]
        public void SerializeLegalEntity()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/LegalEntity.json");
            var legalEntity = JsonSerializer.Deserialize<LegalEntity>(json, _jsonSerializerOptionsProvider.Options);
            Assert.IsNotNull(legalEntity);

            // Act
            string serialized = JsonSerializer.Serialize(legalEntity, _jsonSerializerOptionsProvider.Options);

            // Assert - required fields present
            Assert.IsTrue(serialized.Contains("\"id\":\"LE322JV223222D5GG42KN6869\""));
            Assert.IsTrue(serialized.Contains("\"type\":\"individual\""));

            // Assert - optional string present
            Assert.IsTrue(serialized.Contains("\"reference\":\"YOUR_REFERENCE\""));

            // Assert - readOnly optional boolean serialized
            Assert.IsTrue(serialized.Contains("\"trustedSource\":false"));

            // Assert - readOnly optional fields on capabilities serialized
            Assert.IsTrue(serialized.Contains("\"allowed\":false"));
            Assert.IsTrue(serialized.Contains("\"requested\":true"));
            Assert.IsTrue(serialized.Contains("\"verificationStatus\":\"pending\""));
            Assert.IsTrue(serialized.Contains("\"allowedLevel\":\"medium\""));
            Assert.IsTrue(serialized.Contains("\"requestedLevel\":\"high\""));

            // Assert - readOnly optional array serialized
            Assert.IsTrue(serialized.Contains("\"transferInstruments\""));
            Assert.IsTrue(serialized.Contains("\"verificationDeadlines\""));
            Assert.IsTrue(serialized.Contains("\"entityIds\""));

            // Assert - readOnly field on PhoneNumber serialized
            Assert.IsTrue(serialized.Contains("\"phoneCountryCode\":\"NL\""));

            // Assert - round-trip: deserialize the serialized output
            var roundTripped = JsonSerializer.Deserialize<LegalEntity>(serialized, _jsonSerializerOptionsProvider.Options);
            Assert.IsNotNull(roundTripped);
            Assert.AreEqual(legalEntity.Id, roundTripped.Id);
            Assert.AreEqual(legalEntity.Type, roundTripped.Type);
            Assert.AreEqual(legalEntity.Reference, roundTripped.Reference);
            Assert.AreEqual(legalEntity.TransferInstruments[0].TrustedSource, roundTripped.TransferInstruments[0].TrustedSource);
            Assert.AreEqual(legalEntity.Capabilities["sendToTransferInstrument"].Allowed, roundTripped.Capabilities["sendToTransferInstrument"].Allowed);
            Assert.AreEqual(legalEntity.VerificationDeadlines[0].EntityIds[0], roundTripped.VerificationDeadlines[0].EntityIds[0]);
        }

        /// <summary>
        /// Test DeserializeLegalEntityBusinessLines
        /// </summary>
        [TestMethod]
        public void DeserializeLegalEntityBusinessLines()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/LegalEntityBusinessLines.json");

            // Act
            var result = JsonSerializer.Deserialize<Adyen.LegalEntityManagement.Models.BusinessLines>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.VarBusinessLines.Count);
        }
        
    }
}
