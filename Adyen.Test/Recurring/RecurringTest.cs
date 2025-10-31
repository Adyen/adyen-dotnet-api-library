using Adyen.Core.Options;
using Adyen.Recurring.Client;
using Adyen.Recurring.Models;
using Adyen.Recurring.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;

namespace Adyen.Test.Recurring
{
    [TestClass]
    public class RecurringTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public RecurringTest()
        { 
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureRecurring((context, services, config) =>
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
        public void Given_Deserialize_When_ListRecurringDetails_Result_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/recurring/listRecurringDetails-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<RecurringDetailsResult>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(3L, response.Details.Count);
            
            Assert.AreEqual("BFXCHLC5L6KXWD82", response.Details[0].RecurringDetail.RecurringDetailReference);
            Assert.AreEqual("K652534298119846", response.Details[0].RecurringDetail.Alias);
            Assert.AreEqual("0002", response.Details[0].RecurringDetail.Card.Number);
            
            Assert.AreEqual("JW6RTP5PL6KXWD82", response.Details[1].RecurringDetail.RecurringDetailReference);
            Assert.AreEqual("Wirecard", response.Details[1].RecurringDetail.Bank.BankName);
            Assert.AreEqual("sepadirectdebit", response.Details[1].RecurringDetail.Variant);
        }

        [TestMethod]
        public void Given_Deserialize_When_Disable_Result_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/recurring/disable-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<DisableResult>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual("[detail-successfully-disabled]", response.Response);
        }
        
        [TestMethod]
        public void Given_Deserialize_When_NotifyShopper_Result_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/recurring/notifyShopper-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<NotifyShopperResult>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual("Example displayed reference", response.DisplayedReference);
            Assert.AreEqual("8516167336214570", response.PspReference);
            Assert.AreEqual("Request processed successfully", response.Message);
            Assert.AreEqual("Example reference", response.Reference);
            Assert.AreEqual("Success", response.ResultCode);
            Assert.AreEqual("IA0F7500002462", response.ShopperNotificationReference);
        }
        
        [TestMethod]
        public void Given_Deserialize_When_CreatePermit_Result_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/recurring/createPermit-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<CreatePermitResult>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual("string", response.PspReference);
            Assert.AreEqual(1, response.PermitResultList.Count);
        }
        
        [TestMethod]
        public void Given_Deserialize_When_DisablePermit_Result_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/recurring/disablePermit-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<DisablePermitResult>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual("string", response.PspReference);
            Assert.AreEqual("disabled",response.Status);
        }

        [TestMethod]
        public void Given_Deserialize_When_ScheduleAccountUpdater_Result_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/recurring/scheduleAccountUpdater-success.json");

            // Act
            var response = JsonSerializer.Deserialize<ScheduleAccountUpdaterResult>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual("string", response.PspReference);
            Assert.AreEqual("string", response.Result);
        }
    }
}
