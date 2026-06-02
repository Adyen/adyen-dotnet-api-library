using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.DirectDebitMandates
{
    [TestClass]
    public class DirectDebitMandatesTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public DirectDebitMandatesTest()
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
        public void Given_ListMandatesResponse_When_Deserialized_Then_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/ListMandatesResponse.json");

            // Act
            ListMandatesResponse result = JsonSerializer.Deserialize<ListMandatesResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Mandates);
            Assert.AreEqual(1, result.Mandates.Count);

            Mandate mandate = result.Mandates[0];
            Assert.AreEqual("MNDT7QXPLKT9R333640TX334709E", mandate.Id);
            Assert.AreEqual(MandateType.Bacs, mandate.Type);
            Assert.AreEqual("BA43EKD334339T6N8X655DW77", mandate.BalanceAccountId);
            Assert.AreEqual("PI43EKK334339T6N8X65688CS", mandate.PaymentInstrumentId);
            Assert.AreEqual(MandateStatus.Approved, mandate.Status);
            Assert.AreEqual("Example Merchant Ltd", mandate.Counterparty.AccountHolder.FullName);
            Assert.IsInstanceOfType(mandate.Counterparty.AccountIdentification, typeof(UKLocalMandateAccountIdentification));
            var accountId = (UKLocalMandateAccountIdentification)mandate.Counterparty.AccountIdentification;
            Assert.AreEqual("12345678", accountId.AccountNumber);
            Assert.AreEqual("123456", accountId.SortCode);
        }

        [TestMethod]
        public void Given_Mandate_When_Deserialized_Then_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/Mandate.json");

            // Act
            Mandate result = JsonSerializer.Deserialize<Mandate>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("MNDT7QXPLKT9R333640TX334709E", result.Id);
            Assert.AreEqual(MandateType.Bacs, result.Type);
            Assert.AreEqual("BA43EKD334339T6N8X655DW77", result.BalanceAccountId);
            Assert.AreEqual("PI43EKK334339T6N8X65688CS", result.PaymentInstrumentId);
            Assert.AreEqual(MandateStatus.Approved, result.Status);
            Assert.AreEqual("Example Merchant Ltd", result.Counterparty.AccountHolder.FullName);
            Assert.IsInstanceOfType(result.Counterparty.AccountIdentification, typeof(UKLocalMandateAccountIdentification));
            Assert.IsNotNull(result.CreatedAt);
            Assert.IsNotNull(result.UpdatedAt);
        }

        [TestMethod]
        public void Given_UKLocalMandateAccountIdentification_When_Serialized_Then_TypeIsApiWireValue()
        {
            // Arrange
            var accountId = new UKLocalMandateAccountIdentification
            {
                AccountNumber = "12345678",
                SortCode = "123456"
            };

            // Act
            string result = JsonSerializer.Serialize<MandateAccountIdentification>(accountId, _jsonSerializerOptionsProvider.Options);

            // Assert
            using JsonDocument json = JsonDocument.Parse(result);
            Assert.AreEqual("ukLocal", json.RootElement.GetProperty("type").GetString(),
                "Expected wire value 'ukLocal' but got: " + result);
        }

        [TestMethod]
        public void Given_UKLocalMandateAccountIdentificationJson_When_Deserialized_Then_Returns_UKLocalMandateAccountIdentification()
        {
            // Arrange
            string json = @"{""type"":""ukLocal"",""accountNumber"":""12345678"",""sortCode"":""123456""}";

            // Act
            var result = JsonSerializer.Deserialize<MandateAccountIdentification>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(UKLocalMandateAccountIdentification),
                "Expected UKLocalMandateAccountIdentification but got: " + result.GetType().Name);
            var ukLocal = (UKLocalMandateAccountIdentification)result;
            Assert.AreEqual("12345678", ukLocal.AccountNumber);
            Assert.AreEqual("123456", ukLocal.SortCode);
        }

        [TestMethod]
        public void Given_MandateUpdate_When_Serialized_Then_PaymentInstrumentId_Is_Present()
        {
            // Arrange
            var mandateUpdate = new MandateUpdate
            {
                PaymentInstrumentId = "PI43EKK334339T6N8X65688CS"
            };

            // Act
            string result = JsonSerializer.Serialize(mandateUpdate, _jsonSerializerOptionsProvider.Options);

            // Assert
            using JsonDocument json = JsonDocument.Parse(result);
            Assert.IsTrue(json.RootElement.TryGetProperty("paymentInstrumentId", out _),
                "paymentInstrumentId must be present in the serialized output when set");
        }
    }
}
