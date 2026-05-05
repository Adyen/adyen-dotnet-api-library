using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.ManageCardPIN
{
    [TestClass]
    public class ManageCardPINTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public ManageCardPINTest()
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
        public void Given_PinChangeResponse_When_Deserialized_Then_Status_Is_Completed()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/PinChangeResponse.json");

            // Act
            PinChangeResponse result = JsonSerializer.Deserialize<PinChangeResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(PinChangeResponse.StatusEnum.Completed, result.Status);
        }

        [TestMethod]
        public void Given_RevealPinResponse_When_Deserialized_Then_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/RevealPinResponse.json");

            // Act
            RevealPinResponse result = JsonSerializer.Deserialize<RevealPinResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("63E5060591EF65F48DD1D4FECD0FECD5", result.EncryptedPinBlock);
            Assert.AreEqual("5555341244441115", result.Token);
        }

        [TestMethod]
        public void Given_PublicKeyResponse_When_Deserialized_Then_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/PublicKeyResponse.json");

            // Act
            PublicKeyResponse result = JsonSerializer.Deserialize<PublicKeyResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.PublicKey);
            Assert.AreEqual("2027-06-30", result.PublicKeyExpiryDate);
        }

        [TestMethod]
        public void Given_PinChangeRequest_When_Serialized_Then_All_Fields_Are_Present()
        {
            // Arrange
            var request = new PinChangeRequest
            {
                PaymentInstrumentId = "PI6789678967896789",
                EncryptedKey = "75989E8881284D10153ABACF022EEA09F5...",
                EncryptedPinBlock = "63E5060591EF65F48DD1D4FECD0FECD5",
                Token = "5555341244441115"
            };

            // Act
            string result = JsonSerializer.Serialize(request, _jsonSerializerOptionsProvider.Options);

            // Assert
            using JsonDocument json = JsonDocument.Parse(result);
            JsonElement root = json.RootElement;
            Assert.AreEqual("PI6789678967896789", root.GetProperty("paymentInstrumentId").GetString());
            Assert.AreEqual("75989E8881284D10153ABACF022EEA09F5...", root.GetProperty("encryptedKey").GetString());
            Assert.AreEqual("63E5060591EF65F48DD1D4FECD0FECD5", root.GetProperty("encryptedPinBlock").GetString());
            Assert.AreEqual("5555341244441115", root.GetProperty("token").GetString());
        }

        [TestMethod]
        public void Given_RevealPinRequest_When_Serialized_Then_All_Fields_Are_Present()
        {
            // Arrange
            var request = new RevealPinRequest
            {
                PaymentInstrumentId = "PI3227C223222B5BPCMFXD2XG",
                EncryptedKey = "75989E8881284D10153ABACF022EEA09F5..."
            };

            // Act
            string result = JsonSerializer.Serialize(request, _jsonSerializerOptionsProvider.Options);

            // Assert
            using JsonDocument json = JsonDocument.Parse(result);
            JsonElement root = json.RootElement;
            Assert.AreEqual("PI3227C223222B5BPCMFXD2XG", root.GetProperty("paymentInstrumentId").GetString());
            Assert.AreEqual("75989E8881284D10153ABACF022EEA09F5...", root.GetProperty("encryptedKey").GetString());
        }
    }
}
