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
            BRLocalAccountIdentification brLocalAccountIdentification = new BRLocalAccountIdentification
            {
                AccountNumber = "12345",
                BankCode = "123",
                BranchNumber = "6789",
                Type = BRLocalAccountIdentification.TypeEnum.BrLocal
            };
            
            // Act
            string target = JsonSerializer.Serialize(brLocalAccountIdentification, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            using var jsonDoc = JsonDocument.Parse(target);
            JsonElement root = jsonDoc.RootElement;
            
            Assert.AreEqual("brLocal", root.GetProperty("type").GetString());
            
        }        
        
        [TestMethod]
        public void Given_Serialize_When_IbanAccountIdentification_Is_Provided()
        {
            // Arrange
            IbanAccountIdentification ibanAccountIdentification = new IbanAccountIdentification
            {
                Iban = "NL12345",
                Type = IbanAccountIdentification.TypeEnum.Iban
            };
            
            // Act
            string target = JsonSerializer.Serialize(ibanAccountIdentification, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            using var jsonDoc = JsonDocument.Parse(target);
            JsonElement root = jsonDoc.RootElement;
            
            Assert.AreEqual("NL12345", root.GetProperty("iban").GetString());
            Assert.AreEqual("iban", root.GetProperty("type").GetString());
        }        
        
        [TestMethod]
        public void Given_Serialize_When_IbanAccountIdentification_Is_Provided_Without_Type()
        {
            // Arrange
            IbanAccountIdentification ibanAccountIdentification = new IbanAccountIdentification
            {
                Iban = "NL12345"
            };
            
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
        public void Given_Deserialize_When_IbanAccountIdentification_Is_Provided_Without_Type_Throws_Exception()
        {
            
            string json =  TestUtilities.GetTestFileContent("mocks/balanceplatform/IbanAccountIdentificationWithoutType.json");

            Assert.Throws<ArgumentException>(() =>
            {
                var response = JsonSerializer.Deserialize<IbanAccountIdentification>(json, _jsonSerializerOptionsProvider.Options);
            });
            
        }

        [TestMethod]
        public void Given_Deserialize_When_BankAccountIdentificationValidationRequest_Is_Iban()
        {
            string json = """
                {
                    "accountIdentification": {
                        "type": "iban",
                        "iban": "NL91ABNA0417164300"
                    }
                }
                """;

            var response = JsonSerializer.Deserialize<BankAccountIdentificationValidationRequest>(
                json, _jsonSerializerOptionsProvider.Options);

            Assert.IsNotNull(response);
            Assert.IsNotNull(response.AccountIdentification.IbanAccountIdentification);
            Assert.AreEqual("NL91ABNA0417164300", response.AccountIdentification.IbanAccountIdentification.Iban);
            Assert.IsNull(response.AccountIdentification.BRLocalAccountIdentification);
        }

        [TestMethod]
        public void Given_Serialize_When_BankAccountIdentificationValidationRequest_Is_Iban()
        {
            var iban = new IbanAccountIdentification
            {
                Iban = "NL91ABNA0417164300",
                Type = IbanAccountIdentification.TypeEnum.Iban
            };
            var request = new BankAccountIdentificationValidationRequest
            {
                AccountIdentification = new BankAccountIdentificationValidationRequestAccountIdentification(iban)
            };

            string json = JsonSerializer.Serialize(request, _jsonSerializerOptionsProvider.Options);

            using var doc = JsonDocument.Parse(json);
            JsonElement root = doc.RootElement;
            JsonElement accountId = root.GetProperty("accountIdentification");
            Assert.AreEqual(JsonValueKind.Object, accountId.ValueKind);
            Assert.AreEqual("iban", accountId.GetProperty("type").GetString());
            Assert.AreEqual("NL91ABNA0417164300", accountId.GetProperty("iban").GetString());
        }

        [TestMethod]
        public void Given_TypeEnum_Values_Are_Correct()
        {
            Assert.AreEqual("iban",
                (string?)BankAccountIdentificationValidationRequestAccountIdentification.TypeEnum.Iban);
            Assert.AreEqual("brLocal",
                (string?)BankAccountIdentificationValidationRequestAccountIdentification.TypeEnum.BrLocal);
            Assert.AreEqual("ukLocal",
                (string?)BankAccountIdentificationValidationRequestAccountIdentification.TypeEnum.UkLocal);
            Assert.AreEqual("usLocal",
                (string?)BankAccountIdentificationValidationRequestAccountIdentification.TypeEnum.UsLocal);
        }

    }
}
