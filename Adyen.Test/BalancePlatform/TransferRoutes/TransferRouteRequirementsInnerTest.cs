using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.TransferRoutes
{
    [TestClass]
    public class TransferRouteRequirementsInnerTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public TransferRouteRequirementsInnerTest()
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();

            _jsonSerializerOptionsProvider = host.Services.GetRequiredService<JsonSerializerOptionsProvider>();
        }

        [TestMethod]
        public void Given_Deserialize_When_Type_Is_AmountMinMaxRequirement_Then_Correct_Type_Is_Set()
        {
            string json = """
                {
                    "type": "amountMinMaxRequirement",
                    "description": "Amount must be between 1 and 9999999",
                    "min": 1,
                    "max": 9999999
                }
                """;

            var result = JsonSerializer.Deserialize<TransferRouteRequirementsInner>(
                json, _jsonSerializerOptionsProvider.Options);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.AmountMinMaxRequirement);
            Assert.AreEqual(1, result.AmountMinMaxRequirement.Min);
            Assert.AreEqual(9999999, result.AmountMinMaxRequirement.Max);
            Assert.AreEqual("Amount must be between 1 and 9999999", result.AmountMinMaxRequirement.Description);
            Assert.IsNull(result.BankAccountIdentificationTypeRequirement);
        }

        [TestMethod]
        public void Given_Deserialize_When_Type_Is_BankAccountIdentificationTypeRequirement_Then_Correct_Type_Is_Set()
        {
            string json = """
                {
                    "type": "bankAccountIdentificationTypeRequirement",
                    "description": "Bank account identification type must be iban or numberAndBic",
                    "bankAccountIdentificationTypes": ["iban", "numberAndBic"]
                }
                """;

            var result = JsonSerializer.Deserialize<TransferRouteRequirementsInner>(
                json, _jsonSerializerOptionsProvider.Options);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.BankAccountIdentificationTypeRequirement);
            Assert.IsNotNull(result.BankAccountIdentificationTypeRequirement.BankAccountIdentificationTypes);
            Assert.AreEqual(2, result.BankAccountIdentificationTypeRequirement.BankAccountIdentificationTypes.Count);
            Assert.AreEqual(BankAccountIdentificationTypeRequirement.BankAccountIdentificationTypesEnum.Iban,
                result.BankAccountIdentificationTypeRequirement.BankAccountIdentificationTypes[0]);
            Assert.IsNull(result.AmountMinMaxRequirement);
        }

        [TestMethod]
        public void Given_Deserialize_When_Type_Is_AddressRequirement_Then_Correct_Type_Is_Set()
        {
            string json = """
                {
                    "type": "addressRequirement",
                    "description": "Country, street and city is required.",
                    "requiredAddressFields": ["line1", "city", "country"]
                }
                """;

            var result = JsonSerializer.Deserialize<TransferRouteRequirementsInner>(
                json, _jsonSerializerOptionsProvider.Options);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.AddressRequirement);
            Assert.IsNotNull(result.AddressRequirement.RequiredAddressFields);
            Assert.AreEqual(3, result.AddressRequirement.RequiredAddressFields.Count);
            Assert.IsNull(result.AmountMinMaxRequirement);
        }

        [TestMethod]
        public void Given_TransferRouteResponse_When_Deserialized_Requirements_Are_Correctly_Typed()
        {
            string json = TestUtilities.GetTestFileContent(
                "mocks/balanceplatform/TransferRouteResponseWithAllRequirementTypes.json");

            var result = JsonSerializer.Deserialize<TransferRouteResponse>(json, _jsonSerializerOptionsProvider.Options);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.TransferRoutes);
            Assert.AreEqual(1, result.TransferRoutes.Count);

            var requirements = result.TransferRoutes[0].Requirements;
            Assert.IsNotNull(requirements);
            Assert.AreEqual(3, requirements.Count);

            Assert.IsNotNull(requirements[0].AmountMinMaxRequirement);
            Assert.AreEqual(1, requirements[0].AmountMinMaxRequirement.Min);
            Assert.AreEqual(9999999, requirements[0].AmountMinMaxRequirement.Max);

            Assert.IsNotNull(requirements[1].BankAccountIdentificationTypeRequirement);
            Assert.IsNotNull(requirements[2].AddressRequirement);
        }

        [TestMethod]
        public void Given_Serialize_AmountMinMaxRequirement_Then_Json_Is_Valid_Object()
        {
            var requirement = new AmountMinMaxRequirement
            {
                Type = AmountMinMaxRequirement.TypeEnum.AmountMinMaxRequirement,
                Min = 100,
                Max = 50000,
                Description = "Test description"
            };
            var inner = new TransferRouteRequirementsInner(requirement);

            string json = JsonSerializer.Serialize(inner, _jsonSerializerOptionsProvider.Options);

            using var doc = JsonDocument.Parse(json);
            JsonElement root = doc.RootElement;
            Assert.AreEqual(JsonValueKind.Object, root.ValueKind);
            Assert.AreEqual("amountMinMaxRequirement", root.GetProperty("type").GetString());
            Assert.AreEqual(100, root.GetProperty("min").GetInt64());
            Assert.AreEqual(50000, root.GetProperty("max").GetInt64());
        }

        [TestMethod]
        public void Given_TypeEnum_Values_Are_Correct()
        {
            Assert.AreEqual("amountMinMaxRequirement",
                (string?)TransferRouteRequirementsInner.TypeEnum.AmountMinMaxRequirement);
            Assert.AreEqual("bankAccountIdentificationTypeRequirement",
                (string?)TransferRouteRequirementsInner.TypeEnum.BankAccountIdentificationTypeRequirement);
            Assert.AreEqual("addressRequirement",
                (string?)TransferRouteRequirementsInner.TypeEnum.AddressRequirement);
            Assert.AreEqual("paymentInstrumentRequirement",
                (string?)TransferRouteRequirementsInner.TypeEnum.PaymentInstrumentRequirement);
        }
    }
}
