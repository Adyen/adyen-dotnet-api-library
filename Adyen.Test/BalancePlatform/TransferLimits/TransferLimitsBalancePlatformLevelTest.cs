using System.Net;
using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;
using Adyen.Core.Options;
using Adyen.LegalEntityManagement.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Adyen.Test.BalancePlatform.TransferLimits
{
    [TestClass]
    public class TransferLimitsBalancePlatformLevelTest : BaseTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;
        private readonly ITransferLimitsBalanceAccountLevelService _transferLimitsBalanceAccountLevelService;


        public TransferLimitsBalancePlatformLevelTest()
        {
            IHost host = Host.CreateDefaultBuilder()
            .ConfigureBalancePlatform((context, services, config) =>
            {
                config.ConfigureAdyenOptions(options =>
                {
                    options.AdyenApiKey = context.Configuration["ADYEN_API_KEY"];
                    options.Environment = AdyenEnvironment.Test;
                });
            })
            .Build();

            _jsonSerializerOptionsProvider = host.Services.GetRequiredService<JsonSerializerOptionsProvider>();
            _transferLimitsBalanceAccountLevelService = Substitute.For<ITransferLimitsBalanceAccountLevelService>();

        }

        [TestMethod]
        public void GetTransferLimitDeserializes()
        {
            // Arrange
            var json = TestUtilities.GetTestFileContent("mocks/balanceplatform/TransferLimit.json");
            
            // Act
            var response = JsonSerializer.Deserialize<TransferLimit>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(10000, response.Amount.Value);
            Assert.AreEqual("EUR", response.Amount.Currency);
            Assert.AreEqual("TRLI00000000000000000000000001", response.Id);
            Assert.AreEqual(Scope.PerTransaction, response.Scope);
            Assert.AreEqual("Your reference for the transfer limit", response.Reference);
            Assert.AreEqual(ScaStatus.Pending, response.ScaInformation.Status);
            Assert.AreEqual(LimitStatus.PendingSCA, response.LimitStatus);
            Assert.AreEqual(TransferType.All, response.TransferType);
        }
        
        [TestMethod]
        public void GetTransferLimitsListDeserializes()
        {
            // Arrange
            var json = TestUtilities.GetTestFileContent("mocks/balanceplatform/TransferLimits.json");
            
            // Act
            var response = JsonSerializer.Deserialize<TransferLimitListResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(2, response.TransferLimits.Count);
            
            Assert.AreEqual(10000, response.TransferLimits[0].Amount.Value);
            Assert.AreEqual("EUR", response.TransferLimits[0].Amount.Currency);
            Assert.AreEqual("TRLI00000000000000000000000001", response.TransferLimits[0].Id);
            Assert.AreEqual(Scope.PerTransaction, response.TransferLimits[0].Scope);
            Assert.AreEqual("Your reference for the transfer limit", response.TransferLimits[0].Reference);
            Assert.AreEqual(ScaExemption.InitialLimit, response.TransferLimits[0].ScaInformation.Exemption);
            Assert.AreEqual(ScaStatus.NotPerformed, response.TransferLimits[0].ScaInformation.Status);
            Assert.AreEqual(LimitStatus.Active, response.TransferLimits[0].LimitStatus);
            Assert.AreEqual(TransferType.Instant, response.TransferLimits[0].TransferType);
            
            Assert.AreEqual(20000, response.TransferLimits[1].Amount.Value);
            Assert.AreEqual("EUR", response.TransferLimits[1].Amount.Currency);
            Assert.AreEqual("TRLI00000000000000000000000002", response.TransferLimits[1].Id);
            Assert.AreEqual(Scope.PerTransaction, response.TransferLimits[1].Scope);
            Assert.AreEqual("Your reference for the transfer limit", response.TransferLimits[1].Reference);
            Assert.AreEqual(ScaExemption.InitialLimit, response.TransferLimits[1].ScaInformation.Exemption);
            Assert.AreEqual(ScaStatus.NotPerformed, response.TransferLimits[1].ScaInformation.Status);
            Assert.AreEqual(LimitStatus.Active, response.TransferLimits[1].LimitStatus);
            Assert.AreEqual(TransferType.All, response.TransferLimits[1].TransferType);
        }
        
        /// <summary>
        /// Test GetLegalEntity
        /// </summary>
        [TestMethod]
        public async Task GetSpecificTransferLimitAsync()
        {
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/TransferLimit.json");
            
            _transferLimitsBalanceAccountLevelService.GetSpecificTransferLimitAsync(Arg.Any<string>(), Arg.Any<string>())
                .Returns(
                    Task.FromResult<IGetSpecificTransferLimitApiResponse>(
                        new TransferLimitsBalanceAccountLevelService.GetSpecificTransferLimitApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<TransferLimitsBalanceAccountLevelService.GetSpecificTransferLimitApiResponse>>(),
                            new HttpRequestMessage(), 
                            new HttpResponseMessage(), 
                            json, 
                            "/balanceAccounts/BA1234567890/transferLimits/TRLI00000000000000000000000001", 
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));
            
            IGetSpecificTransferLimitApiResponse response = await _transferLimitsBalanceAccountLevelService.GetSpecificTransferLimitAsync("BA1234567890","TRLI00000000000000000000000001");
            
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual("TRLI00000000000000000000000001", response.Ok().Id);
        }
        
    }
}
