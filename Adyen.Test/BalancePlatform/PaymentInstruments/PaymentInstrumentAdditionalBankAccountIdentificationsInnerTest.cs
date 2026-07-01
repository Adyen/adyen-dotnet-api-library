using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.PaymentInstruments
{
    [TestClass]
    public class PaymentInstrumentAdditionalBankAccountIdentificationsInnerTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public PaymentInstrumentAdditionalBankAccountIdentificationsInnerTest()
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
            string json = """{"type": "iban", "iban": "NL91ABNA0417164300"}""";

            var result = JsonSerializer.Deserialize<PaymentInstrumentAdditionalBankAccountIdentificationsInner>(
                json, _jsonSerializerOptionsProvider.Options);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.IbanAccountIdentification);
            Assert.AreEqual("NL91ABNA0417164300", result.IbanAccountIdentification.Iban);
        }

        [TestMethod]
        public void Given_Deserialize_When_Type_Is_Missing_Then_Returns_Null()
        {
            string json = """{"iban": "NL91ABNA0417164300"}""";

            var result = JsonSerializer.Deserialize<PaymentInstrumentAdditionalBankAccountIdentificationsInner>(
                json, _jsonSerializerOptionsProvider.Options);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void Given_Serialize_When_Type_Is_Iban_Then_Json_Is_Valid_Object()
        {
            var iban = new IbanAccountIdentification
            {
                Iban = "NL91ABNA0417164300",
                Type = IbanAccountIdentification.TypeEnum.Iban
            };
            var inner = new PaymentInstrumentAdditionalBankAccountIdentificationsInner(iban);

            string json = JsonSerializer.Serialize(inner, _jsonSerializerOptionsProvider.Options);

            using var doc = JsonDocument.Parse(json);
            JsonElement root = doc.RootElement;
            Assert.AreEqual(JsonValueKind.Object, root.ValueKind);
            Assert.AreEqual("iban", root.GetProperty("type").GetString());
            Assert.AreEqual("NL91ABNA0417164300", root.GetProperty("iban").GetString());
        }

        [TestMethod]
        public void Given_PaymentInstrument_With_AdditionalBankAccountIdentifications_Deserializes_Correctly()
        {
            string json = TestUtilities.GetTestFileContent(
                "mocks/balanceplatform/PaymentInstrumentWithAdditionalBankAccountIdentifications.json");

            var result = JsonSerializer.Deserialize<PaymentInstrument>(json, _jsonSerializerOptionsProvider.Options);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.AdditionalBankAccountIdentifications);
            Assert.AreEqual(1, result.AdditionalBankAccountIdentifications.Count);
            var additionalId = result.AdditionalBankAccountIdentifications[0];
            Assert.IsNotNull(additionalId.IbanAccountIdentification);
            Assert.AreEqual("NL91ABNA0417164300", additionalId.IbanAccountIdentification.Iban);
        }

        [TestMethod]
        public void Given_TypeEnum_Iban_Value_Is_Correct()
        {
            Assert.AreEqual("iban", (string?)PaymentInstrumentAdditionalBankAccountIdentificationsInner.TypeEnum.Iban);
        }
    }
}
