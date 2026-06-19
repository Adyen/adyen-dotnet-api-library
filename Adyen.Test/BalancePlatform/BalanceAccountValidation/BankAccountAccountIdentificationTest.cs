using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.BalanceAccountValidation
{
    [TestClass]
    public class BankAccountAccountIdentificationTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public BankAccountAccountIdentificationTest()
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.AdyenApiKey = "ApiKey";
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();

            _jsonSerializerOptionsProvider = host.Services.GetRequiredService<JsonSerializerOptionsProvider>();
        }

        [TestMethod]
        public void Given_Deserialize_When_Type_Is_Iban_Then_IbanAccountIdentification_Is_Set()
        {
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/BankAccountAccountIdentificationIban.json");

            var result = JsonSerializer.Deserialize<BankAccountAccountIdentification>(json, _jsonSerializerOptionsProvider.Options);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.IbanAccountIdentification);
            Assert.AreEqual("NL91ABNA0417164300", result.IbanAccountIdentification.Iban);
            Assert.IsNull(result.UKLocalAccountIdentification);
            Assert.IsNull(result.AULocalAccountIdentification);
        }

        [TestMethod]
        public void Given_Deserialize_When_Type_Is_UkLocal_Then_UKLocalAccountIdentification_Is_Set()
        {
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/BankAccountAccountIdentificationUkLocal.json");

            var result = JsonSerializer.Deserialize<BankAccountAccountIdentification>(json, _jsonSerializerOptionsProvider.Options);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.UKLocalAccountIdentification);
            Assert.AreEqual("12345678", result.UKLocalAccountIdentification.AccountNumber);
            Assert.AreEqual("123456", result.UKLocalAccountIdentification.SortCode);
            Assert.IsNull(result.IbanAccountIdentification);
        }

        [TestMethod]
        public void Given_Deserialize_When_Type_Is_Missing_Then_ArgumentException_Is_Thrown()
        {
            string json = """{"iban": "NL91ABNA0417164300"}""";

            Assert.Throws<ArgumentException>(() =>
            {
                JsonSerializer.Deserialize<BankAccountAccountIdentification>(json, _jsonSerializerOptionsProvider.Options);
            });
        }

        [TestMethod]
        public void Given_Serialize_When_Type_Is_Iban_Then_Json_Contains_StartAndEndObject()
        {
            var iban = new IbanAccountIdentification
            {
                Iban = "NL91ABNA0417164300",
                Type = IbanAccountIdentification.TypeEnum.Iban
            };
            var identification = new BankAccountAccountIdentification(iban);

            string json = JsonSerializer.Serialize(identification, _jsonSerializerOptionsProvider.Options);

            using var doc = JsonDocument.Parse(json);
            JsonElement root = doc.RootElement;
            Assert.AreEqual(JsonValueKind.Object, root.ValueKind);
            Assert.AreEqual("iban", root.GetProperty("type").GetString());
            Assert.AreEqual("NL91ABNA0417164300", root.GetProperty("iban").GetString());
        }

        [TestMethod]
        public void Given_Serialize_When_Type_Is_UkLocal_Then_Json_Contains_Correct_Fields()
        {
            var ukLocal = new UKLocalAccountIdentification
            {
                AccountNumber = "12345678",
                SortCode = "123456",
                Type = UKLocalAccountIdentification.TypeEnum.UkLocal
            };
            var identification = new BankAccountAccountIdentification(ukLocal);

            string json = JsonSerializer.Serialize(identification, _jsonSerializerOptionsProvider.Options);

            using var doc = JsonDocument.Parse(json);
            JsonElement root = doc.RootElement;
            Assert.AreEqual(JsonValueKind.Object, root.ValueKind);
            Assert.AreEqual("ukLocal", root.GetProperty("type").GetString());
            Assert.AreEqual("12345678", root.GetProperty("accountNumber").GetString());
            Assert.AreEqual("123456", root.GetProperty("sortCode").GetString());
        }

        [TestMethod]
        public void Given_TypeEnum_Values_Are_Correct()
        {
            Assert.AreEqual("iban", (string?)BankAccountAccountIdentification.TypeEnum.Iban);
            Assert.AreEqual("ukLocal", (string?)BankAccountAccountIdentification.TypeEnum.UkLocal);
            Assert.AreEqual("usLocal", (string?)BankAccountAccountIdentification.TypeEnum.UsLocal);
            Assert.AreEqual("auLocal", (string?)BankAccountAccountIdentification.TypeEnum.AuLocal);
        }
    }
}
