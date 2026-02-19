using Adyen.BalancePlatform.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.Core.Options;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Adyen.Test.BalancePlatform.BalanceAccountValidation
{
    [TestClass]
    public class BankAccountIdentificationValidationRequestAccountIdentificationTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public BankAccountIdentificationValidationRequestAccountIdentificationTest()
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

        // test oneOf deserialization
        [TestMethod]
        public void Given_Deserialize_When_BankAccountIdentification_Is_BrLocal()
        {
            
            string json =  TestUtilities.GetTestFileContent("mocks/balanceplatform/BankAccountIdentificationValidationRequestTypeBr.json");

            // Act
            var response = JsonSerializer.Deserialize<BankAccountIdentificationValidationRequest>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.AccountIdentification.BRLocalAccountIdentification);
            Assert.AreEqual("12345", response.AccountIdentification.BRLocalAccountIdentification.AccountNumber);
            Assert.AreEqual("123", response.AccountIdentification.BRLocalAccountIdentification.BankCode);
            Assert.AreEqual("6789", response.AccountIdentification.BRLocalAccountIdentification.BranchNumber);
            Assert.AreEqual(BRLocalAccountIdentification.TypeEnum.BrLocal, response.AccountIdentification.BRLocalAccountIdentification.Type);
            
            // Assert that other identification types are null
            Assert.IsNull(response.AccountIdentification.AULocalAccountIdentification);
            Assert.IsNull(response.AccountIdentification.CALocalAccountIdentification);
        }
        
        [TestMethod]
        public void Given_Serialize_When_BankAccountIdentification_Is_BrLocal()
        {
            // Arrange
            BRLocalAccountIdentification brLocalAccountIdentification = new BRLocalAccountIdentification(
                accountNumber: "12345",
                bankCode: "123",
                branchNumber: "6789",
                type: BRLocalAccountIdentification.TypeEnum.BrLocal
            );
            
            // Act
            string target = JsonSerializer.Serialize(brLocalAccountIdentification, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            using var jsonDoc = JsonDocument.Parse(target);
            JsonElement root = jsonDoc.RootElement;
            
            Assert.AreEqual("brLocal", root.GetProperty("type").GetString());
            
        }        
        
        [TestMethod]
        public void Given_Serialize_When_IbanAccountIdentification()
        {
            // Arrange
            IbanAccountIdentification ibanAccountIdentification = new IbanAccountIdentification(
                iban: "NL12345",
                type: IbanAccountIdentification.TypeEnum.Iban
            );
            
            // Act
            string target = JsonSerializer.Serialize(ibanAccountIdentification, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            using var jsonDoc = JsonDocument.Parse(target);
            JsonElement root = jsonDoc.RootElement;
            
            Assert.AreEqual("NL12345", root.GetProperty("iban").GetString());
            Assert.AreEqual("iban", root.GetProperty("type").GetString());
        }        
        
        [TestMethod]
        public void Given_Serialize_When_IbanAccountIdentification_Without_Type()
        {
            // Arrange
            IbanAccountIdentification ibanAccountIdentification = new IbanAccountIdentification(
                iban: "NL12345"
            );
            
            Assert.IsNotNull(ibanAccountIdentification.Iban);
            Assert.IsNull(ibanAccountIdentification.Type);
            
            // Act
            string target = JsonSerializer.Serialize(ibanAccountIdentification, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            using var jsonDoc = JsonDocument.Parse(target);
            JsonElement root = jsonDoc.RootElement;
            
            Assert.AreEqual("NL12345", root.GetProperty("iban").GetString());
            Assert.IsFalse(root.TryGetProperty("type", out _));
        }
        
        [TestMethod]
        public void Given_Deserialize_When_IbanAccountIdentification_Without_Type_Throws_Exception()
        {
            
            string json =  TestUtilities.GetTestFileContent("mocks/balanceplatform/IbanAccountIdentificationWithoutType.json");

            Assert.Throws<NullReferenceException>(() =>
            {
                var response = JsonSerializer.Deserialize<IbanAccountIdentification>(json, _jsonSerializerOptionsProvider.Options);
            });
            
        }

    }
}
