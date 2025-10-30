using Adyen.Core.Options;
using Adyen.Payout.Client;
using Adyen.Payout.Models;
using Adyen.Payout.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;

namespace Adyen.Test
{
    [TestClass]
    public class PayoutTest : BaseTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public PayoutTest()
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigurePayout((context, services, config) =>
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
        public void Given_Deserialize_When_StoreDetailAndSubmitThirdParty_Returns_Not_Null()
        {
            // Arrange
            string client = TestUtilities.GetTestFileContent("mocks/payout/storeDetailAndSubmitThirdParty-success.json");

            // Act
            var response = JsonSerializer.Deserialize<StoreDetailAndSubmitResponse>(client, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual("[payout-submit-received]", response.ResultCode);
            Assert.AreEqual("8515131751004933", response.PspReference);
            Assert.AreEqual("GREEN", response.AdditionalData["fraudResultType"]);
            Assert.AreEqual("false", response.AdditionalData["fraudManualReview"]);
        }

        [TestMethod]
        public void Given_Deserialize_When_StoreDetail_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/payout/storeDetail-success.json");

            // Act
            var response = JsonSerializer.Deserialize<StoreDetailResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual("Success", response.ResultCode);
            Assert.AreEqual("8515136787207087", response.PspReference);
            Assert.AreEqual("8415088571022720", response.RecurringDetailReference);
        }

        [TestMethod]
        public void Given_Deserialize_When_ConfirmThirdParty_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/payout/modifyResponse-success.json");

            // Act
            var response = JsonSerializer.Deserialize<ModifyResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual("[payout-confirm-received]", response.Response);
            Assert.AreEqual("8815131762537886", response.PspReference);
        }

        [TestMethod]
        public void Given_Deserialize_When_SubmitThirdParty_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/payout/submitResponse-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<SubmitResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual("[payout-submit-received]", response.ResultCode);
            Assert.AreEqual("8815131768219992", response.PspReference);
            Assert.AreEqual("GREEN", response.AdditionalData["fraudResultType"]);
            Assert.AreEqual("false", response.AdditionalData["fraudManualReview"]);
        }

        [TestMethod]
        public void Given_Deserialize_When_DeclineThirdParty_ModifyResponse_Then_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/payout/modifyResponse-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<ModifyResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual("[payout-confirm-received]", response.Response);
            Assert.AreEqual("8815131762537886", response.PspReference);
        }

        [TestMethod]
        public void PayoutSuccessTest()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/payout/payout-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<PayoutResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual("8814689190961342", response.PspReference);
            Assert.AreEqual("12345", response.AuthCode);
        }
    }
}

