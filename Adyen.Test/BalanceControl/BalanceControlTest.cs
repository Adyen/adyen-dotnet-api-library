using Adyen.BalanceControl.Client;
using Adyen.BalanceControl.Extensions;
using Adyen.BalanceControl.Models;
using Adyen.BalanceControl.Services;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;

namespace Adyen.Test.BalanceControl
{
    [TestClass]
    public class BalanceControlTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public BalanceControlTest()
        {  
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureBalanceControl((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                    
                    services.AddBalanceControlService();
                })
                .Build();

            
            _jsonSerializerOptionsProvider = host.Services.GetRequiredService<JsonSerializerOptionsProvider>();
        }
        
        [TestMethod]
        public async Task Given_Deserialize_When_BalanceControlTransfer_Returns_Correct_Status()
        {
            // Arrange
            var json = TestUtilities.GetTestFileContent("mocks/balance-control-transfer.json");
            
            // Act
            var response = JsonSerializer.Deserialize<BalanceTransferResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(response.CreatedAt, new DateTime(2022,01, 24));
            Assert.AreEqual(response.Status, BalanceTransferResponse.StatusEnum.Transferred);
        }

        [TestMethod]
        public void Given_Deserialize_When_BalanceTransferResponse_Returns_Correct_Type_And_Amount()
        {
            // Arrange
            var json = TestUtilities.GetTestFileContent("mocks/balance-control-transfer.json");

            // Act
            var response = JsonSerializer.Deserialize<BalanceTransferResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(BalanceTransferResponse.TypeEnum.Debit, response.Type);
            Assert.AreEqual(50000L, response.Amount.Value);
            Assert.AreEqual("EUR", response.Amount.Currency);
        }

        [TestMethod]
        public void Given_Deserialize_When_BalanceTransferRequest_Returns_Correct_Type_And_Amount()
        {
            // Arrange
            var json = TestUtilities.GetTestFileContent("mocks/balance-control-transfer-request.json");

            // Act
            var request = JsonSerializer.Deserialize<BalanceTransferRequest>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(BalanceTransferRequest.TypeEnum.Fee, request.Type);
            Assert.AreEqual(75000L, request.Amount.Value);
            Assert.AreEqual("USD", request.Amount.Currency);
        }

        [TestMethod]
        public void Given_Serialize_When_BalanceTransferResponse_Returns_Correct_Json()
        {
            // Arrange
            var response = new BalanceTransferResponse
            {
                Amount = new Amount { Currency = "EUR", Value = 50000 },
                CreatedAt = new DateTime(2022, 01, 24),
                FromMerchant = "MerchantAccount_NL",
                ToMerchant = "MerchantAccount_DE",
                Type = BalanceTransferResponse.TypeEnum.Debit,
                Status = BalanceTransferResponse.StatusEnum.Transferred,
                PspReference = "8816080397613514"
            };

            // Act
            var json = JsonSerializer.Serialize(response, _jsonSerializerOptionsProvider.Options);
            var doc = JsonDocument.Parse(json);

            // Assert
            Assert.AreEqual("debit", doc.RootElement.GetProperty("type").GetString());
            Assert.AreEqual("transferred", doc.RootElement.GetProperty("status").GetString());
            Assert.AreEqual(50000, doc.RootElement.GetProperty("amount").GetProperty("value").GetInt64());
            Assert.AreEqual("EUR", doc.RootElement.GetProperty("amount").GetProperty("currency").GetString());
        }

        [TestMethod]
        public void Given_Serialize_When_BalanceTransferRequest_Returns_Correct_Json()
        {
            // Arrange
            var request = new BalanceTransferRequest
            {
                Amount = new Amount { Currency = "USD", Value = 75000 },
                FromMerchant = "MerchantAccount_NL",
                ToMerchant = "MerchantAccount_DE",
                Type = BalanceTransferRequest.TypeEnum.Fee
            };

            // Act
            var json = JsonSerializer.Serialize(request, _jsonSerializerOptionsProvider.Options);
            var doc = JsonDocument.Parse(json);

            // Assert
            Assert.AreEqual("fee", doc.RootElement.GetProperty("type").GetString());
            Assert.AreEqual(75000, doc.RootElement.GetProperty("amount").GetProperty("value").GetInt64());
        }

        [TestMethod]
        public async Task Given_IBalanceControlService_When_Live_Url_And_Prefix_Are_Set_Returns_Correct_Live_Url_Endpoint()
        {
            // Arrange
            IHost liveHost = Host.CreateDefaultBuilder()
                .ConfigureBalanceControl((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.AdyenApiKey = "your-live-api-key";
                        options.Environment = AdyenEnvironment.Live;
                        options.LiveEndpointUrlPrefix = "prefix";
                    });
                    
                    services.AddBalanceControlService();
                })
                .Build();
            
            // Act
            var balanceControlService = liveHost.Services.GetRequiredService<IBalanceControlService>();

            // Assert
            Assert.AreEqual("https://prefix-pal-live.adyenpayments.com/pal/servlet/BalanceControl/v1", balanceControlService.HttpClient.BaseAddress.ToString()); 
        }

    }
}