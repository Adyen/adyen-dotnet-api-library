using System.Text.Json;
using Adyen.Core.Options;
using Adyen.Disputes.Client;
using Adyen.Disputes.Extensions;
using Adyen.Disputes.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Disputes
{
    [TestClass]
    public class DisputesTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public DisputesTest()
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureDisputes((context, services, config) =>
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
        public void Given_Deserialize_AcceptDispute_Returns_Success()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/disputes/accept-dispute.json");
            
            // Act
            var response = JsonSerializer.Deserialize<AcceptDisputeResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.IsTrue(response.DisputeServiceResult.Success);
        }
        
        [TestMethod]
        public void Given_Deserialize_DefendDispute_Returns_Success()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/disputes/defend-dispute.json");
            
            // Act
            var response = JsonSerializer.Deserialize<DefendDisputeResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.IsTrue(response.DisputeServiceResult.Success);
        }

        [TestMethod]
        public void Given_Deserialize_DeleteDefenseDocumentResponse_Returns_Success()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/disputes/delete-dispute.json");
            
            // Act
            var response = JsonSerializer.Deserialize<DeleteDefenseDocumentResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.IsTrue(response.DisputeServiceResult.Success);
        }
        
        [TestMethod]
        public void Given_Deserialize_DefenseReasonsResponse_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/disputes/retrieve-applicable-defense-reasons.json");
            
            // Act
            var response = JsonSerializer.Deserialize<DefenseReasonsResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsTrue(response.DisputeServiceResult.Success);
            Assert.IsTrue(response.DefenseReasons.Count!=0);
            Assert.AreEqual(response.DefenseReasons[0].DefenseDocumentTypes[0].DefenseDocumentTypeCode, "TIDorInvoice");
            Assert.IsFalse(response.DefenseReasons[0].DefenseDocumentTypes[0].Available);
            Assert.AreEqual(response.DefenseReasons[0].DefenseDocumentTypes[0].RequirementLevel, "Optional");
            Assert.AreEqual(response.DefenseReasons[0].DefenseDocumentTypes[1].DefenseDocumentTypeCode, "GoodsNotReturned");
            Assert.IsFalse(response.DefenseReasons[0].DefenseDocumentTypes[1].Available);
            Assert.AreEqual(response.DefenseReasons[0].DefenseDocumentTypes[1].RequirementLevel, "Required");
            Assert.AreEqual(response.DefenseReasons[0].DefenseReasonCode, "GoodsNotReturned");
            Assert.IsFalse(response.DefenseReasons[0].Satisfied);
        }
        
        [TestMethod]
        public void Given_Deserialize_SupplyDefenceDocumentResponse_Returns_Success()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/disputes/supply-dispute-defense-document.json");
            
            // Act
            var response = JsonSerializer.Deserialize<SupplyDefenseDocumentResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.IsTrue(response.DisputeServiceResult.Success);
        }
    }
}